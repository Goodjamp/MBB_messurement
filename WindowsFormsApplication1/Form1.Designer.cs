namespace MBB_8_1_config
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_START = new System.Windows.Forms.Button();
            this.comboBox_SelPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_STOP = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label_SPEED = new System.Windows.Forms.Label();
            this.comboBox_SelSpeed = new System.Windows.Forms.ComboBox();
            this.chartI_N = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTimeRequest = new System.Windows.Forms.TextBox();
            this.textBoxTimeout = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTimeout = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxDevAddress = new System.Windows.Forms.TextBox();
            this.textBoxNumData = new System.Windows.Forms.TextBox();
            this.textBoxDataAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddRequest = new System.Windows.Forms.Button();
            this.comboBoxFunction = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelCurrentVal = new System.Windows.Forms.Label();
            this.labelCurrenName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelFreqVal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartF_N = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chartI_F = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridViewCalibData = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Current = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.labelNumPoints = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxCurrenMes = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonSaveCalib = new System.Windows.Forms.Button();
            this.buttonAddCalib = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelCurrentCode = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.buttonStartCalib = new System.Windows.Forms.CheckBox();
            this.buttonStopCalib = new System.Windows.Forms.CheckBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonRemoveCalibPoint = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.bLineKoef = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.kLineKoef = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.calibNumPoinCalib = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.calibMBBAddress = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.calibVoltAddres = new System.Windows.Forms.TextBox();
            this.calibNumReg = new System.Windows.Forms.TextBox();
            this.calibModBusRegAddress = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.buttonAddCalibRequest = new System.Windows.Forms.Button();
            this.calibModBusFun = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.calibGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.numTempPoint = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.numGlobalPoint = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.calibMBBCode = new System.Windows.Forms.Label();
            this.buttonAddPoint = new System.Windows.Forms.Button();
            this.checkBoxSelAddMode = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartI_N)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartF_N)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartI_F)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalibData)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calibGrid)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_START
            // 
            this.button_START.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_START.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_START.Location = new System.Drawing.Point(9, 134);
            this.button_START.Name = "button_START";
            this.button_START.Size = new System.Drawing.Size(78, 26);
            this.button_START.TabIndex = 1;
            this.button_START.Text = "start";
            this.button_START.UseVisualStyleBackColor = true;
            this.button_START.Click += new System.EventHandler(this.buton_START_click);
            // 
            // comboBox_SelPort
            // 
            this.comboBox_SelPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_SelPort.FormattingEnabled = true;
            this.comboBox_SelPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20",
            "COM21",
            "COM22",
            "COM23",
            "COM24",
            "COM25"});
            this.comboBox_SelPort.Location = new System.Drawing.Point(9, 46);
            this.comboBox_SelPort.Name = "comboBox_SelPort";
            this.comboBox_SelPort.Size = new System.Drawing.Size(78, 21);
            this.comboBox_SelPort.TabIndex = 2;
            this.comboBox_SelPort.Text = "COM23";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM";
            // 
            // button_STOP
            // 
            this.button_STOP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_STOP.Enabled = false;
            this.button_STOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_STOP.Location = new System.Drawing.Point(93, 134);
            this.button_STOP.Name = "button_STOP";
            this.button_STOP.Size = new System.Drawing.Size(77, 26);
            this.button_STOP.TabIndex = 4;
            this.button_STOP.Text = "stop";
            this.button_STOP.UseVisualStyleBackColor = true;
            this.button_STOP.Click += new System.EventHandler(this.button_STOP_click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(892, 634);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 29;
            // 
            // label_SPEED
            // 
            this.label_SPEED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_SPEED.AutoSize = true;
            this.label_SPEED.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_SPEED.Location = new System.Drawing.Point(90, 30);
            this.label_SPEED.Name = "label_SPEED";
            this.label_SPEED.Size = new System.Drawing.Size(48, 13);
            this.label_SPEED.TabIndex = 32;
            this.label_SPEED.Text = "SPEED";
            // 
            // comboBox_SelSpeed
            // 
            this.comboBox_SelSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_SelSpeed.FormattingEnabled = true;
            this.comboBox_SelSpeed.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19600",
            "28800",
            "38400",
            "57600"});
            this.comboBox_SelSpeed.Location = new System.Drawing.Point(93, 46);
            this.comboBox_SelSpeed.Name = "comboBox_SelSpeed";
            this.comboBox_SelSpeed.Size = new System.Drawing.Size(78, 21);
            this.comboBox_SelSpeed.TabIndex = 31;
            this.comboBox_SelSpeed.Text = "9600";
            // 
            // chartI_N
            // 
            this.chartI_N.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.AxisX.Interval = 5D;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.Name = "ChartArea1";
            this.chartI_N.ChartAreas.Add(chartArea4);
            this.chartI_N.Location = new System.Drawing.Point(3, 3);
            this.chartI_N.Name = "chartI_N";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.MarkerBorderColor = System.Drawing.Color.Red;
            series4.MarkerColor = System.Drawing.Color.Red;
            series4.MarkerSize = 2;
            series4.Name = "Series1";
            this.chartI_N.Series.Add(series4);
            this.chartI_N.Size = new System.Drawing.Size(820, 509);
            this.chartI_N.TabIndex = 36;
            this.chartI_N.Text = "chartData";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBoxTimeRequest);
            this.groupBox1.Controls.Add(this.textBoxTimeout);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_SelPort);
            this.groupBox1.Controls.Add(this.button_STOP);
            this.groupBox1.Controls.Add(this.labelTimeout);
            this.groupBox1.Controls.Add(this.button_START);
            this.groupBox1.Controls.Add(this.comboBox_SelSpeed);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_SPEED);
            this.groupBox1.Location = new System.Drawing.Point(855, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 175);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection paramiters";
            // 
            // textBoxTimeRequest
            // 
            this.textBoxTimeRequest.Location = new System.Drawing.Point(93, 97);
            this.textBoxTimeRequest.Name = "textBoxTimeRequest";
            this.textBoxTimeRequest.Size = new System.Drawing.Size(78, 20);
            this.textBoxTimeRequest.TabIndex = 41;
            this.textBoxTimeRequest.Text = "500";
            // 
            // textBoxTimeout
            // 
            this.textBoxTimeout.Location = new System.Drawing.Point(9, 97);
            this.textBoxTimeout.Name = "textBoxTimeout";
            this.textBoxTimeout.Size = new System.Drawing.Size(78, 20);
            this.textBoxTimeout.TabIndex = 40;
            this.textBoxTimeout.Text = "1000";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(90, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "TIMREQUES";
            // 
            // labelTimeout
            // 
            this.labelTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTimeout.AutoSize = true;
            this.labelTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeout.Location = new System.Drawing.Point(6, 81);
            this.labelTimeout.Name = "labelTimeout";
            this.labelTimeout.Size = new System.Drawing.Size(63, 13);
            this.labelTimeout.TabIndex = 33;
            this.labelTimeout.Text = "TIMEOUT";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBoxDevAddress);
            this.groupBox2.Controls.Add(this.textBoxNumData);
            this.groupBox2.Controls.Add(this.textBoxDataAddress);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.buttonAddRequest);
            this.groupBox2.Controls.Add(this.comboBoxFunction);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(855, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 175);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Request paramiters";
            // 
            // textBoxDevAddress
            // 
            this.textBoxDevAddress.Location = new System.Drawing.Point(9, 47);
            this.textBoxDevAddress.Name = "textBoxDevAddress";
            this.textBoxDevAddress.Size = new System.Drawing.Size(78, 20);
            this.textBoxDevAddress.TabIndex = 41;
            this.textBoxDevAddress.Text = "1";
            // 
            // textBoxNumData
            // 
            this.textBoxNumData.Location = new System.Drawing.Point(93, 97);
            this.textBoxNumData.Name = "textBoxNumData";
            this.textBoxNumData.Size = new System.Drawing.Size(78, 20);
            this.textBoxNumData.TabIndex = 41;
            this.textBoxNumData.Text = "2";
            // 
            // textBoxDataAddress
            // 
            this.textBoxDataAddress.Location = new System.Drawing.Point(9, 97);
            this.textBoxDataAddress.Name = "textBoxDataAddress";
            this.textBoxDataAddress.Size = new System.Drawing.Size(78, 20);
            this.textBoxDataAddress.TabIndex = 40;
            this.textBoxDataAddress.Text = "529";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(90, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "NumData";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "DataAddress";
            // 
            // buttonAddRequest
            // 
            this.buttonAddRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddRequest.Location = new System.Drawing.Point(9, 134);
            this.buttonAddRequest.Name = "buttonAddRequest";
            this.buttonAddRequest.Size = new System.Drawing.Size(161, 26);
            this.buttonAddRequest.TabIndex = 1;
            this.buttonAddRequest.Text = "Add Request";
            this.buttonAddRequest.UseVisualStyleBackColor = true;
            this.buttonAddRequest.Click += new System.EventHandler(this.buttonAddRequest_Click);
            // 
            // comboBoxFunction
            // 
            this.comboBoxFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFunction.FormattingEnabled = true;
            this.comboBoxFunction.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxFunction.Location = new System.Drawing.Point(93, 46);
            this.comboBoxFunction.Name = "comboBoxFunction";
            this.comboBoxFunction.Size = new System.Drawing.Size(78, 21);
            this.comboBoxFunction.TabIndex = 31;
            this.comboBoxFunction.Text = "3";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "DevAddress";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(90, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Function";
            // 
            // labelCurrentVal
            // 
            this.labelCurrentVal.AutoSize = true;
            this.labelCurrentVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentVal.Location = new System.Drawing.Point(43, 28);
            this.labelCurrentVal.Name = "labelCurrentVal";
            this.labelCurrentVal.Size = new System.Drawing.Size(61, 25);
            this.labelCurrentVal.TabIndex = 40;
            this.labelCurrentVal.Text = "0.000";
            // 
            // labelCurrenName
            // 
            this.labelCurrenName.AutoSize = true;
            this.labelCurrenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrenName.Location = new System.Drawing.Point(8, 28);
            this.labelCurrenName.Name = "labelCurrenName";
            this.labelCurrenName.Size = new System.Drawing.Size(29, 25);
            this.labelCurrenName.TabIndex = 41;
            this.labelCurrenName.Text = "I=";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(115, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 25);
            this.label10.TabIndex = 45;
            this.label10.Text = "mA";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.labelCurrentVal);
            this.groupBox3.Controls.Add(this.labelCurrenName);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(178, 554);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 70);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current from MBB";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.labelFreqVal);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(25, 554);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(145, 70);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Frequency";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(106, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 25);
            this.label9.TabIndex = 44;
            this.label9.Text = "Hz";
            // 
            // labelFreqVal
            // 
            this.labelFreqVal.AutoSize = true;
            this.labelFreqVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFreqVal.Location = new System.Drawing.Point(41, 28);
            this.labelFreqVal.Name = "labelFreqVal";
            this.labelFreqVal.Size = new System.Drawing.Size(61, 25);
            this.labelFreqVal.TabIndex = 42;
            this.labelFreqVal.Text = "0.000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 25);
            this.label8.TabIndex = 43;
            this.label8.Text = "F=";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(837, 541);
            this.tabControl1.TabIndex = 50;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chartI_N);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(829, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "I=f(N)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartF_N);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(829, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "F=f(N)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartF_N
            // 
            this.chartF_N.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.AxisX.Interval = 5D;
            chartArea5.AxisX.Minimum = 0D;
            chartArea5.Name = "ChartArea1";
            this.chartF_N.ChartAreas.Add(chartArea5);
            this.chartF_N.Location = new System.Drawing.Point(4, 3);
            this.chartF_N.Name = "chartF_N";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.MarkerBorderColor = System.Drawing.Color.Red;
            series5.MarkerColor = System.Drawing.Color.Red;
            series5.MarkerSize = 2;
            series5.Name = "Series1";
            this.chartF_N.Series.Add(series5);
            this.chartF_N.Size = new System.Drawing.Size(820, 509);
            this.chartF_N.TabIndex = 37;
            this.chartF_N.Text = "chartData";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chartI_F);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(829, 515);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "I=f(F)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chartI_F
            // 
            this.chartI_F.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.AxisX.Interval = 5D;
            chartArea6.AxisX.Maximum = 150D;
            chartArea6.AxisX.Minimum = 0D;
            chartArea6.Name = "ChartArea1";
            this.chartI_F.ChartAreas.Add(chartArea6);
            this.chartI_F.Location = new System.Drawing.Point(4, 3);
            this.chartI_F.Name = "chartI_F";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.MarkerBorderColor = System.Drawing.Color.Red;
            series6.MarkerColor = System.Drawing.Color.Red;
            series6.MarkerSize = 2;
            series6.Name = "Series1";
            this.chartI_F.Series.Add(series6);
            this.chartI_F.Size = new System.Drawing.Size(820, 509);
            this.chartI_F.TabIndex = 37;
            this.chartI_F.Text = "chartData";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.dataGridViewCalibData);
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.buttonSaveCalib);
            this.tabPage4.Controls.Add(this.buttonAddCalib);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(829, 515);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Calib with voltage source";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(67, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 25);
            this.label11.TabIndex = 60;
            this.label11.Text = "Table calibration data";
            // 
            // dataGridViewCalibData
            // 
            this.dataGridViewCalibData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalibData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Code,
            this.Current});
            this.dataGridViewCalibData.Location = new System.Drawing.Point(9, 140);
            this.dataGridViewCalibData.Name = "dataGridViewCalibData";
            this.dataGridViewCalibData.ReadOnly = true;
            this.dataGridViewCalibData.RowHeadersVisible = false;
            this.dataGridViewCalibData.Size = new System.Drawing.Size(344, 369);
            this.dataGridViewCalibData.TabIndex = 59;
            // 
            // Number
            // 
            this.Number.FillWeight = 40F;
            this.Number.HeaderText = "#";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 40;
            // 
            // Code
            // 
            this.Code.FillWeight = 200F;
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 200;
            // 
            // Current
            // 
            this.Current.HeaderText = "Current, mA";
            this.Current.Name = "Current";
            this.Current.ReadOnly = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox7.Controls.Add(this.labelNumPoints);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox7.Location = new System.Drawing.Point(423, 8);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(89, 55);
            this.groupBox7.TabIndex = 58;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Num points";
            // 
            // labelNumPoints
            // 
            this.labelNumPoints.AutoSize = true;
            this.labelNumPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumPoints.Location = new System.Drawing.Point(17, 17);
            this.labelNumPoints.Name = "labelNumPoints";
            this.labelNumPoints.Size = new System.Drawing.Size(61, 25);
            this.labelNumPoints.TabIndex = 42;
            this.labelNumPoints.Text = "0.000";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox6.Controls.Add(this.textBoxCurrenMes);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.Location = new System.Drawing.Point(255, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(146, 57);
            this.groupBox6.TabIndex = 55;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Current messurement ";
            // 
            // textBoxCurrenMes
            // 
            this.textBoxCurrenMes.Location = new System.Drawing.Point(41, 23);
            this.textBoxCurrenMes.Name = "textBoxCurrenMes";
            this.textBoxCurrenMes.Size = new System.Drawing.Size(65, 21);
            this.textBoxCurrenMes.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(108, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 25);
            this.label12.TabIndex = 45;
            this.label12.Text = "A";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(6, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 25);
            this.label14.TabIndex = 41;
            this.label14.Text = "I=";
            // 
            // buttonSaveCalib
            // 
            this.buttonSaveCalib.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveCalib.Location = new System.Drawing.Point(126, 69);
            this.buttonSaveCalib.Name = "buttonSaveCalib";
            this.buttonSaveCalib.Size = new System.Drawing.Size(112, 23);
            this.buttonSaveCalib.TabIndex = 57;
            this.buttonSaveCalib.Text = "SAVE";
            this.buttonSaveCalib.UseVisualStyleBackColor = true;
            this.buttonSaveCalib.Click += new System.EventHandler(this.buttonSaveCalib_Click);
            // 
            // buttonAddCalib
            // 
            this.buttonAddCalib.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCalib.Location = new System.Drawing.Point(9, 69);
            this.buttonAddCalib.Name = "buttonAddCalib";
            this.buttonAddCalib.Size = new System.Drawing.Size(110, 23);
            this.buttonAddCalib.TabIndex = 56;
            this.buttonAddCalib.Text = "Add calib point";
            this.buttonAddCalib.UseVisualStyleBackColor = true;
            this.buttonAddCalib.Click += new System.EventHandler(this.buttonAddCalib_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.labelCurrentCode);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.buttonRestore);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(9, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(229, 55);
            this.groupBox5.TabIndex = 51;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Current measurement code";
            // 
            // labelCurrentCode
            // 
            this.labelCurrentCode.AutoSize = true;
            this.labelCurrentCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentCode.Location = new System.Drawing.Point(28, 24);
            this.labelCurrentCode.Name = "labelCurrentCode";
            this.labelCurrentCode.Size = new System.Drawing.Size(39, 16);
            this.labelCurrentCode.TabIndex = 46;
            this.labelCurrentCode.Text = "0.000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(6, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 25);
            this.label13.TabIndex = 41;
            this.label13.Text = "I=";
            // 
            // buttonRestore
            // 
            this.buttonRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRestore.Location = new System.Drawing.Point(158, 22);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(65, 23);
            this.buttonRestore.TabIndex = 47;
            this.buttonRestore.Text = "Restore";
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox9);
            this.tabPage5.Controls.Add(this.groupBox12);
            this.tabPage5.Controls.Add(this.groupBox11);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.calibGrid);
            this.tabPage5.Controls.Add(this.groupBox8);
            this.tabPage5.Controls.Add(this.groupBox10);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(829, 515);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Calib with voltmeter";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox9.Controls.Add(this.buttonStartCalib);
            this.groupBox9.Controls.Add(this.buttonStopCalib);
            this.groupBox9.Controls.Add(this.buttonCalc);
            this.groupBox9.Controls.Add(this.buttonRemoveCalibPoint);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox9.Location = new System.Drawing.Point(9, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(200, 126);
            this.groupBox9.TabIndex = 70;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Calib processing";
            // 
            // buttonStartCalib
            // 
            this.buttonStartCalib.Appearance = System.Windows.Forms.Appearance.Button;
            this.buttonStartCalib.AutoSize = true;
            this.buttonStartCalib.BackColor = System.Drawing.Color.Yellow;
            this.buttonStartCalib.Location = new System.Drawing.Point(6, 59);
            this.buttonStartCalib.Name = "buttonStartCalib";
            this.buttonStartCalib.Size = new System.Drawing.Size(80, 25);
            this.buttonStartCalib.TabIndex = 72;
            this.buttonStartCalib.Text = "Start collect";
            this.buttonStartCalib.UseVisualStyleBackColor = false;
            this.buttonStartCalib.CheckedChanged += new System.EventHandler(this.buttonStatCalib_CheckedChanged);
            // 
            // buttonStopCalib
            // 
            this.buttonStopCalib.Appearance = System.Windows.Forms.Appearance.Button;
            this.buttonStopCalib.AutoSize = true;
            this.buttonStopCalib.BackColor = System.Drawing.Color.Yellow;
            this.buttonStopCalib.Checked = true;
            this.buttonStopCalib.CheckState = System.Windows.Forms.CheckState.Checked;
            this.buttonStopCalib.Location = new System.Drawing.Point(6, 23);
            this.buttonStopCalib.Name = "buttonStopCalib";
            this.buttonStopCalib.Size = new System.Drawing.Size(80, 25);
            this.buttonStopCalib.TabIndex = 71;
            this.buttonStopCalib.Text = "Stop collect";
            this.buttonStopCalib.UseVisualStyleBackColor = false;
            this.buttonStopCalib.CheckedChanged += new System.EventHandler(this.buttonStopCalib_CheckedChanged);
            // 
            // buttonCalc
            // 
            this.buttonCalc.BackColor = System.Drawing.Color.Lime;
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalc.Location = new System.Drawing.Point(111, 23);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(79, 60);
            this.buttonCalc.TabIndex = 65;
            this.buttonCalc.Text = "Calc";
            this.buttonCalc.UseVisualStyleBackColor = false;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonRemoveCalibPoint
            // 
            this.buttonRemoveCalibPoint.BackColor = System.Drawing.Color.Red;
            this.buttonRemoveCalibPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveCalibPoint.Location = new System.Drawing.Point(6, 95);
            this.buttonRemoveCalibPoint.Name = "buttonRemoveCalibPoint";
            this.buttonRemoveCalibPoint.Size = new System.Drawing.Size(184, 23);
            this.buttonRemoveCalibPoint.TabIndex = 47;
            this.buttonRemoveCalibPoint.Text = "Remove all data";
            this.buttonRemoveCalibPoint.UseVisualStyleBackColor = false;
            this.buttonRemoveCalibPoint.Click += new System.EventHandler(this.buttonRemoveCalibPoint_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox12.Controls.Add(this.bLineKoef);
            this.groupBox12.Controls.Add(this.label29);
            this.groupBox12.Controls.Add(this.kLineKoef);
            this.groupBox12.Controls.Add(this.label27);
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox12.Location = new System.Drawing.Point(444, 6);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(126, 126);
            this.groupBox12.TabIndex = 69;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Line paramiters";
            // 
            // bLineKoef
            // 
            this.bLineKoef.AutoSize = true;
            this.bLineKoef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bLineKoef.Location = new System.Drawing.Point(37, 81);
            this.bLineKoef.Name = "bLineKoef";
            this.bLineKoef.Size = new System.Drawing.Size(36, 16);
            this.bLineKoef.TabIndex = 48;
            this.bLineKoef.Text = "NaN";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.Location = new System.Drawing.Point(6, 76);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(35, 25);
            this.label29.TabIndex = 47;
            this.label29.Text = "b=";
            // 
            // kLineKoef
            // 
            this.kLineKoef.AutoSize = true;
            this.kLineKoef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kLineKoef.Location = new System.Drawing.Point(37, 38);
            this.kLineKoef.Name = "kLineKoef";
            this.kLineKoef.Size = new System.Drawing.Size(36, 16);
            this.kLineKoef.TabIndex = 46;
            this.kLineKoef.Text = "NaN";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.Location = new System.Drawing.Point(6, 33);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(34, 25);
            this.label27.TabIndex = 41;
            this.label27.Text = "k=";
            // 
            // groupBox11
            // 
            this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox11.Controls.Add(this.calibNumPoinCalib);
            this.groupBox11.Controls.Add(this.label17);
            this.groupBox11.Controls.Add(this.calibMBBAddress);
            this.groupBox11.Controls.Add(this.label25);
            this.groupBox11.Controls.Add(this.calibVoltAddres);
            this.groupBox11.Controls.Add(this.calibNumReg);
            this.groupBox11.Controls.Add(this.calibModBusRegAddress);
            this.groupBox11.Controls.Add(this.label21);
            this.groupBox11.Controls.Add(this.label22);
            this.groupBox11.Controls.Add(this.buttonAddCalibRequest);
            this.groupBox11.Controls.Add(this.calibModBusFun);
            this.groupBox11.Controls.Add(this.label23);
            this.groupBox11.Controls.Add(this.label24);
            this.groupBox11.Location = new System.Drawing.Point(624, 6);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(177, 256);
            this.groupBox11.TabIndex = 68;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Calibration process paramiters";
            // 
            // calibNumPoinCalib
            // 
            this.calibNumPoinCalib.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.calibNumPoinCalib.FormattingEnabled = true;
            this.calibNumPoinCalib.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200"});
            this.calibNumPoinCalib.Location = new System.Drawing.Point(11, 185);
            this.calibNumPoinCalib.Name = "calibNumPoinCalib";
            this.calibNumPoinCalib.Size = new System.Drawing.Size(159, 21);
            this.calibNumPoinCalib.TabIndex = 45;
            this.calibNumPoinCalib.Text = "10";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(8, 169);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(152, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "Num point for one current";
            // 
            // calibMBBAddress
            // 
            this.calibMBBAddress.Location = new System.Drawing.Point(118, 55);
            this.calibMBBAddress.Name = "calibMBBAddress";
            this.calibMBBAddress.Size = new System.Drawing.Size(52, 20);
            this.calibMBBAddress.TabIndex = 43;
            this.calibMBBAddress.Text = "1";
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(3, 59);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(95, 13);
            this.label25.TabIndex = 42;
            this.label25.Text = "Device address";
            // 
            // calibVoltAddres
            // 
            this.calibVoltAddres.Location = new System.Drawing.Point(118, 23);
            this.calibVoltAddres.Name = "calibVoltAddres";
            this.calibVoltAddres.Size = new System.Drawing.Size(52, 20);
            this.calibVoltAddres.TabIndex = 41;
            this.calibVoltAddres.Text = "2";
            // 
            // calibNumReg
            // 
            this.calibNumReg.Location = new System.Drawing.Point(93, 139);
            this.calibNumReg.Name = "calibNumReg";
            this.calibNumReg.Size = new System.Drawing.Size(78, 20);
            this.calibNumReg.TabIndex = 41;
            this.calibNumReg.Text = "2";
            // 
            // calibModBusRegAddress
            // 
            this.calibModBusRegAddress.Location = new System.Drawing.Point(9, 139);
            this.calibModBusRegAddress.Name = "calibModBusRegAddress";
            this.calibModBusRegAddress.Size = new System.Drawing.Size(78, 20);
            this.calibModBusRegAddress.TabIndex = 40;
            this.calibModBusRegAddress.Text = "529";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(90, 123);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 13);
            this.label21.TabIndex = 39;
            this.label21.Text = "NumData";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(6, 123);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 13);
            this.label22.TabIndex = 33;
            this.label22.Text = "DataAddress";
            // 
            // buttonAddCalibRequest
            // 
            this.buttonAddCalibRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddCalibRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCalibRequest.Location = new System.Drawing.Point(9, 223);
            this.buttonAddCalibRequest.Name = "buttonAddCalibRequest";
            this.buttonAddCalibRequest.Size = new System.Drawing.Size(161, 26);
            this.buttonAddCalibRequest.TabIndex = 1;
            this.buttonAddCalibRequest.Text = "Add Request";
            this.buttonAddCalibRequest.UseVisualStyleBackColor = true;
            this.buttonAddCalibRequest.Click += new System.EventHandler(this.buttonAddCalibRequest_Click);
            // 
            // calibModBusFun
            // 
            this.calibModBusFun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.calibModBusFun.FormattingEnabled = true;
            this.calibModBusFun.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.calibModBusFun.Location = new System.Drawing.Point(118, 88);
            this.calibModBusFun.Name = "calibModBusFun";
            this.calibModBusFun.Size = new System.Drawing.Size(52, 21);
            this.calibModBusFun.TabIndex = 31;
            this.calibModBusFun.Text = "3";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(3, 27);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(108, 13);
            this.label23.TabIndex = 3;
            this.label23.Text = "Voltmeter address";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(4, 93);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 13);
            this.label24.TabIndex = 32;
            this.label24.Text = "Function";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(190, 145);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(198, 25);
            this.label15.TabIndex = 67;
            this.label15.Text = "Table calibration data";
            // 
            // calibGrid
            // 
            this.calibGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calibGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.Column2});
            this.calibGrid.Location = new System.Drawing.Point(9, 176);
            this.calibGrid.Name = "calibGrid";
            this.calibGrid.ReadOnly = true;
            this.calibGrid.RowHeadersVisible = false;
            this.calibGrid.Size = new System.Drawing.Size(561, 331);
            this.calibGrid.TabIndex = 66;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 40F;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Current voltmeter";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Current MBB";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 200F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Code MBB";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "dA";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox8.Controls.Add(this.label20);
            this.groupBox8.Controls.Add(this.numTempPoint);
            this.groupBox8.Controls.Add(this.label18);
            this.groupBox8.Controls.Add(this.numGlobalPoint);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox8.Location = new System.Drawing.Point(238, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(175, 75);
            this.groupBox8.TabIndex = 65;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Num points";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(12, 43);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 25);
            this.label20.TabIndex = 50;
            this.label20.Text = "Temp:";
            // 
            // numTempPoint
            // 
            this.numTempPoint.AutoSize = true;
            this.numTempPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numTempPoint.Location = new System.Drawing.Point(92, 43);
            this.numTempPoint.Name = "numTempPoint";
            this.numTempPoint.Size = new System.Drawing.Size(23, 25);
            this.numTempPoint.TabIndex = 49;
            this.numTempPoint.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(12, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 25);
            this.label18.TabIndex = 48;
            this.label18.Text = "Global:";
            // 
            // numGlobalPoint
            // 
            this.numGlobalPoint.AutoSize = true;
            this.numGlobalPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numGlobalPoint.Location = new System.Drawing.Point(92, 18);
            this.numGlobalPoint.Name = "numGlobalPoint";
            this.numGlobalPoint.Size = new System.Drawing.Size(23, 25);
            this.numGlobalPoint.TabIndex = 42;
            this.numGlobalPoint.Text = "0";
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox10.Controls.Add(this.calibMBBCode);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox10.Location = new System.Drawing.Point(236, 94);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(177, 38);
            this.groupBox10.TabIndex = 61;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Current measurement code";
            // 
            // calibMBBCode
            // 
            this.calibMBBCode.AutoSize = true;
            this.calibMBBCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calibMBBCode.Location = new System.Drawing.Point(10, 17);
            this.calibMBBCode.Name = "calibMBBCode";
            this.calibMBBCode.Size = new System.Drawing.Size(39, 16);
            this.calibMBBCode.TabIndex = 46;
            this.calibMBBCode.Text = "0.000";
            // 
            // buttonAddPoint
            // 
            this.buttonAddPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddPoint.Enabled = false;
            this.buttonAddPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPoint.Location = new System.Drawing.Point(343, 588);
            this.buttonAddPoint.Name = "buttonAddPoint";
            this.buttonAddPoint.Size = new System.Drawing.Size(103, 25);
            this.buttonAddPoint.TabIndex = 52;
            this.buttonAddPoint.Text = "Add new point";
            this.buttonAddPoint.UseVisualStyleBackColor = true;
            this.buttonAddPoint.Click += new System.EventHandler(this.buttonAddPoint_Click);
            // 
            // checkBoxSelAddMode
            // 
            this.checkBoxSelAddMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxSelAddMode.AutoSize = true;
            this.checkBoxSelAddMode.Checked = true;
            this.checkBoxSelAddMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSelAddMode.Location = new System.Drawing.Point(344, 565);
            this.checkBoxSelAddMode.Name = "checkBoxSelAddMode";
            this.checkBoxSelAddMode.Size = new System.Drawing.Size(95, 17);
            this.checkBoxSelAddMode.TabIndex = 53;
            this.checkBoxSelAddMode.Text = "Auto add point";
            this.checkBoxSelAddMode.UseVisualStyleBackColor = true;
            this.checkBoxSelAddMode.CheckedChanged += new System.EventHandler(this.checkBoxSelAddMode_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(470, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 53);
            this.button1.TabIndex = 54;
            this.button1.Text = "Clear chart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 636);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxSelAddMode);
            this.Controls.Add(this.buttonAddPoint);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Modbus Master monitor";
            ((System.ComponentModel.ISupportInitialize)(this.chartI_N)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartF_N)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartI_F)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalibData)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calibGrid)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_START;
        private System.Windows.Forms.ComboBox comboBox_SelPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_STOP;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_SPEED;
        private System.Windows.Forms.ComboBox comboBox_SelSpeed;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartI_N;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTimeRequest;
        private System.Windows.Forms.TextBox textBoxTimeout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTimeout;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxDevAddress;
        private System.Windows.Forms.TextBox textBoxNumData;
        private System.Windows.Forms.TextBox textBoxDataAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddRequest;
        private System.Windows.Forms.ComboBox comboBoxFunction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelCurrentVal;
        private System.Windows.Forms.Label labelCurrenName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelFreqVal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartF_N;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartI_F;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonAddPoint;
        private System.Windows.Forms.CheckBox checkBoxSelAddMode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.Label labelCurrentCode;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBoxCurrenMes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonAddCalib;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridViewCalibData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Current;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label labelNumPoints;
        private System.Windows.Forms.Button buttonSaveCalib;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView calibGrid;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label numGlobalPoint;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label calibMBBCode;
        private System.Windows.Forms.Button buttonRemoveCalibPoint;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox calibVoltAddres;
        private System.Windows.Forms.TextBox calibNumReg;
        private System.Windows.Forms.TextBox calibModBusRegAddress;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button buttonAddCalibRequest;
        private System.Windows.Forms.ComboBox calibModBusFun;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox calibMBBAddress;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label kLineKoef;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label bLineKoef;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.CheckBox buttonStopCalib;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.CheckBox buttonStartCalib;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox calibNumPoinCalib;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label numTempPoint;
        private System.Windows.Forms.Label label18;
    }
}

