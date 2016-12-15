using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace MBB_8_1_config
{
    // enumeration for Start/Stop calibration butto
    enum calibState
    {
        buttonStart,
        buttonStop
    };
    //Delegate Prototype callback modbus master function
    public delegate void modbus_master_callback(int req_num, ref byte[] data_respons);
    // Struct for update  calibration state (with voltage source) 
    struct S_current_code_rezult{
        public S_current_code_rezult(int arg1) { 
            this.counter=0;
            this.middle_rez=0;
            this.summ_rez=0;
        }
        public void current_code_rezult_rezet()
        {
            this.counter = 0;
            this.middle_rez = 0;
            this.summ_rez = 0;
        }
        public int counter;
        public double middle_rez;
        public double summ_rez;
    };


    public partial class Form1 : Form
    {

        // - конструктор каласа Form1-------------------------- 
        public Form1()
        {

            InitializeComponent();
            // масив хендлеров ком портов для доступа к ним по индексу масива из ф-и считывания
            a_com_ports[0] = this.serialPort1;

        }


        //----------------------------------------------------------------------------------
        public bool f_COM_is_open = false;
        // масив идентификаторов ком-портов
        System.IO.Ports.SerialPort[] a_com_ports = new System.IO.Ports.SerialPort[2];
        // масив класов протокола modbus
        modbus_master_class[] modbus_master_ex = new modbus_master_class[2];
        //faile for save rezult of mesurement
        FileInfo FileRezMes;
        StreamWriter FileStreamRezMes;
        //faile for save calib data
        FileInfo FileRezCalib;
        StreamWriter FileStreamRezCalib;
        // Mutex for axec "code" rezult
         Mutex mutex_code = new Mutex();
        // class for processing calibration in case of two MBB
         calibProcessing calibMBB;
        // struct for processing current code rezult
        S_current_code_rezult s_current_code_rezult = new S_current_code_rezult(0); 
        //Calib data array
        List<List<double>> calib_data = new List<List<double>>();


        //protected access to cross-thread wariables
        private double update_code_rezult(bool resset_need, bool take_rez_need, double new_rez)
        {
            mutex_code.WaitOne();
            // if need rezet temp rezult
            if (resset_need)
            {
                s_current_code_rezult.current_code_rezult_rezet();
                mutex_code.ReleaseMutex();
                return 0;
            }
            // if need take temp rezult
            if (take_rez_need) {
                mutex_code.ReleaseMutex();
                return s_current_code_rezult.middle_rez;
            }
            s_current_code_rezult.summ_rez += new_rez;
            s_current_code_rezult.counter++;
            s_current_code_rezult.middle_rez = s_current_code_rezult.summ_rez / s_current_code_rezult.counter;
            mutex_code.ReleaseMutex();
            return s_current_code_rezult.middle_rez;
        }

        //----------метод read_com ---------------------
        // считывание заданого к-ва байт из буффер СОМ-порта
        public bool read_com(int byte_to_read, ref byte[] read_com_data, Int32 pos, System.IO.Ports.SerialPort PortUser)
        {
            if (byte_to_read > PortUser.BytesToRead)
            {
                return (false);
            };
            PortUser.Read(read_com_data, pos, (int)byte_to_read);
            return (true);
        }


        //----------метод read_com ---------------------
        // передача заданого к-ва байт в буффер СОМ-порта
        public bool write_com(uint byte_to_write, ref byte[] write_com_data, int shift, System.IO.Ports.SerialPort PortUser)
        {

            PortUser.Write(write_com_data, shift, (int)byte_to_write);
            return (true);
        }


        // --------------событие обекта button_START------------------------
        // возникает в момент нажатия на кнопку START.
        //в теле обработки события происходит открытие потока опроса COM порта и открытие порта.
        private void buton_START_click(object sender, EventArgs e)
        {

            int TimeOut, TimeRequest;
            // Open COM Port
            this.a_com_ports[0].PortName = this.comboBox_SelPort.Text;
            this.a_com_ports[0].BaudRate = Convert.ToInt32(this.comboBox_SelSpeed.Text); // Static speed
            if (this.a_com_ports[0].IsOpen)
            {
                return;
            }
            try
            {
                this.a_com_ports[0].Open();
                TimeOut = Convert.ToInt32(textBoxTimeout.Text);
                TimeRequest = Convert.ToInt32(textBoxTimeRequest.Text);
            }
            catch {
                MessageBox.Show("Com Port ERROR", "ERROR!!!! ",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            //create file with rez of mesurement
            create_file();

            //flags
            f_COM_is_open = true;
            // run class modbus_master
            modbus_master_ex[0] = new modbus_master_class(this, this.a_com_ports[0], TimeOut, TimeRequest);

            //Form control activity
            this.button_START.Enabled = false;
            this.comboBox_SelPort.Enabled = false;
            this.comboBox_SelSpeed.Enabled = false;

            this.button_STOP.Enabled = true;

        }
       

        // create file for save rezult of mesurement
        private void create_file() {
            SaveFileDialog saveFileDialog1=new SaveFileDialog();

            saveFileDialog1.ShowDialog();
            if (String.IsNullOrEmpty(saveFileDialog1.FileName))
            {
                return;
            }
            // Создем файл для записи результатов
            FileRezMes = new FileInfo(saveFileDialog1.FileName + ".txt"); // created file
            FileStreamRezMes = FileRezMes.AppendText();
            FileStreamRezMes.WriteLine("Frequency,Hz        Current_MBB,A       Current_Code        Current_messurement,A ");
            FileStreamRezMes.Close();
            // Создем файл для записи результатов
            FileInfo FileInfoData = new FileInfo(saveFileDialog1.FileName);
            FileRezCalib = new FileInfo(FileInfoData.DirectoryName + "\\processing_mes_calib_current.h"); // created file
            //FileStreamRezCalib = FileRezCalib.AppendText();
            //FileStreamRezCalib.WriteLine("Current_Code        Current_messurement,A ");
            //FileStreamRezCalib.Close();      
        }

        // --------------событие обекта button_STOP------------------------
        // возникает в момент нажатия на кнопку STOP.
        // в теле обработки события происходит завершения потока опроса COM порта и закрытие порта.
        private void button_STOP_click(object sender, EventArgs e)
        {
            f_COM_is_open = false;
            //активность элементов управления
            this.button_START.Enabled = true;
            this.comboBox_SelPort.Enabled = true;
            this.comboBox_SelSpeed.Enabled = true;

            this.button_STOP.Enabled = false;

            if (this.a_com_ports[0].IsOpen)
            {
                this.modbus_master_ex[0].stop_read_com_strem();
            }
            close_modbus_serial(); // отановить потоки протоколов и закрыть порты
            modbus_master_ex[0] = null;
        }


        //-------------метод close_modbus_serial--------------
        //в теле даного метода анализируються открытые порты и запученные класы, и закрываються 
        private void close_modbus_serial()
        {
            int k1;
            for (k1 = 0; k1 < 1; k1++)
            {
                if (modbus_master_ex[k1] != null)
                { //если запущен экземпляр протокола
                    this.modbus_master_ex[k1].stop_read_com_strem();
                    modbus_master_ex[0] = null;
                }
                if (a_com_ports[k1].IsOpen)   //если соответствующий порт токрыт - закрыть порт
                {
                    a_com_ports[k1].Close();
                }
            }
        }



        // Add new request in request list
        private void buttonAddRequest_Click(object sender, EventArgs e)
        {
            UInt16 DevAddress, Function, DataAddress, NumData, Timeout; 
            
            try
            {
                DevAddress = Convert.ToUInt16(textBoxDevAddress.Text);
                Function = Convert.ToUInt16(comboBoxFunction.Text);
                DataAddress = Convert.ToUInt16(textBoxDataAddress.Text);
                NumData = Convert.ToUInt16(textBoxNumData.Text);
            }
            catch
            {
                MessageBox.Show("Not number ", "Error Request paramiters",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            // Add new request
            modbus_master_ex[0].modbus_master_add_request(DevAddress,
                                      Function,
                                      DataAddress,
                                      NumData,
                                      callback_receive_I_F); 

        }


        // Callback respons receive I and F
        public void callback_receive_I_F(int req_num, ref byte[] byte_data)
        {
            String  SCurrentMes="0", SForFile;

            if (labelFreqVal.InvokeRequired || labelCurrentVal.InvokeRequired ||
                chartI_N.InvokeRequired || chartI_F.InvokeRequired || chartF_N.InvokeRequired)
            {
                modbus_master_callback rez_resp_I_F = callback_receive_I_F;
                Invoke(rez_resp_I_F, req_num, byte_data);
            }
            else
            {
                if (byte_data.Length < 4) { return; }
                UInt16 I_mes = BitConverter.ToUInt16(byte_data, 0);
                UInt16 F_mes = BitConverter.ToUInt16(byte_data, 2);
                Double I_code = BitConverter.ToDouble(byte_data, 4);
                Double I_code_visout_everage = I_code;
                float F_mes_float = F_mes;
                F_mes_float = F_mes_float / 1000;

                I_code=this.update_code_rezult(false, false, I_code);

                // Show rez mea data
                this.labelCurrentVal.Text = Convert.ToString(I_mes);
                this.labelFreqVal.Text = Convert.ToString(F_mes_float);
                this.labelCurrentCode.Text = Convert.ToString(I_code);

                if (!checkBoxSelAddMode.Checked) { return; }

                // ------------Add new data to file----------------------
                SForFile = this.labelFreqVal.Text.PadRight(20) + this.labelCurrentVal.Text.PadRight(20) + Convert.ToString(I_code_visout_everage).PadRight(20) + SCurrentMes.PadRight(20);
                FileStreamRezMes = FileRezMes.AppendText();
                FileStreamRezMes.WriteLine(SForFile);
                FileStreamRezMes.Close(); 
                //add new point to plot 
                this.chartI_N.Series["Series1"].Points.AddY(I_mes);
                this.chartF_N.Series["Series1"].Points.AddY(F_mes_float);
                this.chartI_F.Series["Series1"].Points.AddXY(F_mes_float, I_mes);
            }

        }


        // Callback respons IN CALIBRATION MODE
        public void callbackReceiveCalibration(int req_num, ref byte[] byte_data)
        {
            String SCurrentMes = "0", SForFile;

            if ( labelFreqVal.InvokeRequired || labelCurrentVal.InvokeRequired ||
                 calibGrid.InvokeRequired || calibMBBCode.InvokeRequired ||
                 numGlobalPoint.InvokeRequired || numTempPoint.InvokeRequired )
            {
                modbus_master_callback rez_resp_I_F = callback_receive_I_F;
                Invoke(rez_resp_I_F, req_num, byte_data);
            }
            else
            {
                if (byte_data.Length < 4) { return; }
                UInt16 I_mes = BitConverter.ToUInt16(byte_data, 0);
                UInt16 F_mes = BitConverter.ToUInt16(byte_data, 2);
                Double I_code = BitConverter.ToDouble(byte_data, 4);
                Double I_code_visout_everage = I_code;
                float F_mes_float = F_mes;
                F_mes_float = F_mes_float / 1000;

                this.calibMBB.addNewData(req_num, I_mes, I_code); 

                // Show rez meas data
                this.labelCurrentVal.Text = Convert.ToString(I_mes);
                this.labelFreqVal.Text = Convert.ToString(F_mes_float);
                this.labelCurrentCode.Text = Convert.ToString(I_code);

                if (!checkBoxSelAddMode.Checked) { return; }
                //------------Add new point to plot 
                this.chartI_N.Series["Series1"].Points.AddY(I_mes);
                this.chartF_N.Series["Series1"].Points.AddY(F_mes_float);
                this.chartI_F.Series["Series1"].Points.AddXY(F_mes_float, I_mes);
            }

        }


        // add new point in axess
        private void buttonAddPoint_Click(object sender, EventArgs e)
        {
            String SFrequensy, SCurrentMBB, SCurrentMes, SForFile;
            this.chartI_F.Series["Series1"].Points.AddXY(Convert.ToDouble(labelFreqVal.Text),
                                                         Convert.ToDouble(labelCurrentVal.Text));
            SFrequensy = labelFreqVal.Text;
            SCurrentMBB = labelCurrentVal.Text;
            SCurrentMes = textBoxCurrenMes.Text;
            SForFile = SFrequensy.PadRight(20) + SCurrentMBB.PadRight(20) + SCurrentMes.PadRight(20);
            FileStreamRezMes = FileRezMes.AppendText();
            FileStreamRezMes.WriteLine(SForFile);
            FileStreamRezMes.Close(); 
        }
       
        
        //sell mode add point
        private void checkBoxSelAddMode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSelAddMode.Checked)
            {
                buttonAddPoint.Enabled = false;
            }
            else {
                buttonAddPoint.Enabled = true;
            }
        }
        

        // Clear all chart
        private void button1_Click(object sender, EventArgs e)
        {
            this.chartI_N.Series["Series1"].Points.Clear();
            this.chartF_N.Series["Series1"].Points.Clear();
            this.chartI_F.Series["Series1"].Points.Clear();
        }

        // Add new calib point to the list of calibration point (usualy user press this button
        // if code stable)
        private void buttonAddCalib_Click(object sender, EventArgs e)
        {
            List<double> tempcalib=new List<double>();
            double temp_code, mes_current;
            string SForFile;
            string Scurrent_code;
            temp_code = update_code_rezult(false, true, 0);
            // Add code
            tempcalib.Add(temp_code);          
            //Add mes current
            try
            {
                mes_current = Convert.ToDouble(textBoxCurrenMes.Text);
            }
            catch
            {
                MessageBox.Show("Not number ", "Error mesurement current",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            tempcalib.Add(mes_current);   
            //Add new calib pair
            calib_data.Add(tempcalib);
            //Add new pair calibration data to table
            dataGridViewCalibData.Rows.Add(calib_data.Count, calib_data[calib_data.Count-1].ElementAt(0),
                                                             calib_data[calib_data.Count - 1].ElementAt(1));
            // Show num points 
            labelNumPoints.Text = Convert.ToString(calib_data.Count);
        }
        
        
        //Rezet temp code value
        private void buttonRestore_Click(object sender, EventArgs e)
        {
            update_code_rezult(true, false, 0);
        }

        // Save calibration data to fail
        private void buttonSaveCalib_Click(object sender, EventArgs e)
        {
            String stringCalibData;

            stringCalibData = Convert.ToString(calib_data.Count) + ",\n"+"{\n";
            foreach(List<double> pair_point in  calib_data){
                stringCalibData +="{" + Convert.ToString(pair_point[0]).Replace(",", ".")+","+
                                  Convert.ToString(pair_point[1]).Replace(",", ".")+"},\n"; 
            }
            stringCalibData += "}\n";
            // Add calib string to fail
            FileStreamRezCalib = FileRezCalib.AppendText();
            FileStreamRezCalib.WriteLine(stringCalibData);
            FileStreamRezCalib.Close();
        }

        // Add request to device using ModBus protocol in calibration mode
        // Add two reques: to voltmeter
        //                 to device
        private void buttonAddCalibRequest_Click(object sender, EventArgs e)
        {
            int numberPointPerOneCurent;
            //Add request to VOLTMETER
            createRequest(calibVoltAddres.Text,
                         calibModBusFun.Text,
                         calibModBusRegAddress.Text,
                         calibNumReg.Text,
                         callbackReceiveCalibration);           
            //Add request to MBB
            createRequest(calibMBBAddress.Text,
                         calibModBusFun.Text,
                         calibModBusRegAddress.Text,
                         calibNumReg.Text,
                         callbackReceiveCalibration);
            try
            {
                numberPointPerOneCurent = Convert.ToUInt16(calibNumPoinCalib.Text);
            }
            catch
            {
                MessageBox.Show("Not number ", "Error Number calib point per one current",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            calibProcessing calibMBB = new calibProcessing(numberPointPerOneCurent);
        }


        private void createRequest(string inDevAddress, string inFun, string inDataAddress, string inNumData, modbus_master_callback fCallBack)
        {
            UInt16 DevAddress, Function, DataAddress, NumData;

            try
            {
                DevAddress = Convert.ToUInt16(inDevAddress);
                Function = Convert.ToUInt16(inFun);
                DataAddress = Convert.ToUInt16(inDataAddress);
                NumData = Convert.ToUInt16(inNumData);
            }
            catch
            {
                MessageBox.Show("Not number ", "Error Request paramiters",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            // Add new request
            
            modbus_master_ex[0].modbus_master_add_request(DevAddress,
                                      Function,
                                      DataAddress,
                                      NumData,
                                      fCallBack); 
        }

        private void buttonStatCalib_CheckedChanged(object sender, EventArgs e)
        {
            changeStopStart(calibState.buttonStart);
        }
        

        private void buttonStopCalib_CheckedChanged(object sender, EventArgs e)
        {
            changeStopStart(calibState.buttonStop);
        }


        private void changeStopStart(calibState pressButton)
        {
            switch(pressButton)
            {
                case (calibState.buttonStart): 
                    if (this.buttonStartCalib.Checked)
                    {
                        this.buttonStopCalib.Checked = false;
                    }
                    else
                    {
                        this.buttonStartCalib.Checked = true;
                    }
                    break;
                case(calibState.buttonStop): 
                    if(this.buttonStopCalib.Checked)
                    {
                        this.buttonStartCalib.Checked = false;
                    }
                    else
                    {
                         this.buttonStartCalib.Checked = true;
                    }
                    break;
                default: break;
            };

        }


        private void buttonCalc_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoveCalibPoint_Click(object sender, EventArgs e)
        {

        }

    }// end partial class "Form1"


}// end namespace "threshold_procesing"


