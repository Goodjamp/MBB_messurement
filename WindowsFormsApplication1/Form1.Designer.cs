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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.buttonStartCollect = new System.Windows.Forms.RadioButton();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonStopCollect = new System.Windows.Forms.RadioButton();
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
            this.lableNumTempPoint = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lableNumGlobalPoint = new System.Windows.Forms.Label();
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
            this.button_START.Location = new System.Drawing.Point(12, 165);
            this.button_START.Margin = new System.Windows.Forms.Padding(4);
            this.button_START.Name = "button_START";
            this.button_START.Size = new System.Drawing.Size(104, 32);
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
            this.comboBox_SelPort.Location = new System.Drawing.Point(12, 57);
            this.comboBox_SelPort.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_SelPort.Name = "comboBox_SelPort";
            this.comboBox_SelPort.Size = new System.Drawing.Size(103, 24);
            this.comboBox_SelPort.TabIndex = 2;
            this.comboBox_SelPort.Text = "COM23";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM";
            // 
            // button_STOP
            // 
            this.button_STOP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_STOP.Enabled = false;
            this.button_STOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_STOP.Location = new System.Drawing.Point(124, 165);
            this.button_STOP.Margin = new System.Windows.Forms.Padding(4);
            this.button_STOP.Name = "button_STOP";
            this.button_STOP.Size = new System.Drawing.Size(103, 32);
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
            this.label6.Location = new System.Drawing.Point(1189, 780);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 29;
            // 
            // label_SPEED
            // 
            this.label_SPEED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_SPEED.AutoSize = true;
            this.label_SPEED.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_SPEED.Location = new System.Drawing.Point(120, 37);
            this.label_SPEED.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SPEED.Name = "label_SPEED";
            this.label_SPEED.Size = new System.Drawing.Size(59, 17);
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
            this.comboBox_SelSpeed.Location = new System.Drawing.Point(124, 57);
            this.comboBox_SelSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_SelSpeed.Name = "comboBox_SelSpeed";
            this.comboBox_SelSpeed.Size = new System.Drawing.Size(103, 24);
            this.comboBox_SelSpeed.TabIndex = 31;
            this.comboBox_SelSpeed.Text = "9600";
            // 
            // chartI_N
            // 
            this.chartI_N.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Interval = 5D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chartI_N.ChartAreas.Add(chartArea1);
            this.chartI_N.Location = new System.Drawing.Point(4, 4);
            this.chartI_N.Margin = new System.Windows.Forms.Padding(4);
            this.chartI_N.Name = "chartI_N";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.MarkerBorderColor = System.Drawing.Color.Red;
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.MarkerSize = 2;
            series1.Name = "Series1";
            this.chartI_N.Series.Add(series1);
            this.chartI_N.Size = new System.Drawing.Size(1093, 626);
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
            this.groupBox1.Location = new System.Drawing.Point(1140, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(236, 215);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection paramiters";
            // 
            // textBoxTimeRequest
            // 
            this.textBoxTimeRequest.Location = new System.Drawing.Point(124, 119);
            this.textBoxTimeRequest.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTimeRequest.Name = "textBoxTimeRequest";
            this.textBoxTimeRequest.Size = new System.Drawing.Size(103, 22);
            this.textBoxTimeRequest.TabIndex = 41;
            this.textBoxTimeRequest.Text = "500";
            // 
            // textBoxTimeout
            // 
            this.textBoxTimeout.Location = new System.Drawing.Point(12, 119);
            this.textBoxTimeout.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTimeout.Name = "textBoxTimeout";
            this.textBoxTimeout.Size = new System.Drawing.Size(103, 22);
            this.textBoxTimeout.TabIndex = 40;
            this.textBoxTimeout.Text = "1000";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(120, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "TIMREQUES";
            // 
            // labelTimeout
            // 
            this.labelTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTimeout.AutoSize = true;
            this.labelTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeout.Location = new System.Drawing.Point(8, 100);
            this.labelTimeout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimeout.Name = "labelTimeout";
            this.labelTimeout.Size = new System.Drawing.Size(77, 17);
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
            this.groupBox2.Location = new System.Drawing.Point(1140, 254);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(236, 215);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Request paramiters";
            // 
            // textBoxDevAddress
            // 
            this.textBoxDevAddress.Location = new System.Drawing.Point(12, 58);
            this.textBoxDevAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDevAddress.Name = "textBoxDevAddress";
            this.textBoxDevAddress.Size = new System.Drawing.Size(103, 22);
            this.textBoxDevAddress.TabIndex = 41;
            this.textBoxDevAddress.Text = "1";
            // 
            // textBoxNumData
            // 
            this.textBoxNumData.Location = new System.Drawing.Point(124, 119);
            this.textBoxNumData.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumData.Name = "textBoxNumData";
            this.textBoxNumData.Size = new System.Drawing.Size(103, 22);
            this.textBoxNumData.TabIndex = 41;
            this.textBoxNumData.Text = "6";
            // 
            // textBoxDataAddress
            // 
            this.textBoxDataAddress.Location = new System.Drawing.Point(12, 119);
            this.textBoxDataAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDataAddress.Name = "textBoxDataAddress";
            this.textBoxDataAddress.Size = new System.Drawing.Size(103, 22);
            this.textBoxDataAddress.TabIndex = 40;
            this.textBoxDataAddress.Text = "529";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(120, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "NumData";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "DataAddress";
            // 
            // buttonAddRequest
            // 
            this.buttonAddRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddRequest.Location = new System.Drawing.Point(12, 165);
            this.buttonAddRequest.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddRequest.Name = "buttonAddRequest";
            this.buttonAddRequest.Size = new System.Drawing.Size(215, 32);
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
            this.comboBoxFunction.Location = new System.Drawing.Point(124, 57);
            this.comboBoxFunction.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFunction.Name = "comboBoxFunction";
            this.comboBoxFunction.Size = new System.Drawing.Size(103, 24);
            this.comboBoxFunction.TabIndex = 31;
            this.comboBoxFunction.Text = "3";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "DevAddress";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(120, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Function";
            // 
            // labelCurrentVal
            // 
            this.labelCurrentVal.AutoSize = true;
            this.labelCurrentVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentVal.Location = new System.Drawing.Point(57, 34);
            this.labelCurrentVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentVal.Name = "labelCurrentVal";
            this.labelCurrentVal.Size = new System.Drawing.Size(76, 29);
            this.labelCurrentVal.TabIndex = 40;
            this.labelCurrentVal.Text = "0.000";
            // 
            // labelCurrenName
            // 
            this.labelCurrenName.AutoSize = true;
            this.labelCurrenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrenName.Location = new System.Drawing.Point(11, 34);
            this.labelCurrenName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrenName.Name = "labelCurrenName";
            this.labelCurrenName.Size = new System.Drawing.Size(34, 29);
            this.labelCurrenName.TabIndex = 41;
            this.labelCurrenName.Text = "I=";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(153, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 29);
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
            this.groupBox3.Location = new System.Drawing.Point(237, 682);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(212, 86);
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
            this.groupBox4.Location = new System.Drawing.Point(33, 682);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(193, 86);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Frequency";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(141, 34);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 29);
            this.label9.TabIndex = 44;
            this.label9.Text = "Hz";
            // 
            // labelFreqVal
            // 
            this.labelFreqVal.AutoSize = true;
            this.labelFreqVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFreqVal.Location = new System.Drawing.Point(55, 34);
            this.labelFreqVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFreqVal.Name = "labelFreqVal";
            this.labelFreqVal.Size = new System.Drawing.Size(76, 29);
            this.labelFreqVal.TabIndex = 42;
            this.labelFreqVal.Text = "0.000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(8, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 29);
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
            this.tabControl1.Location = new System.Drawing.Point(16, 9);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1116, 666);
            this.tabControl1.TabIndex = 50;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chartI_N);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1108, 637);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "I=f(N)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartF_N);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1108, 637);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "F=f(N)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartF_N
            // 
            this.chartF_N.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.Interval = 5D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chartF_N.ChartAreas.Add(chartArea2);
            this.chartF_N.Location = new System.Drawing.Point(5, 4);
            this.chartF_N.Margin = new System.Windows.Forms.Padding(4);
            this.chartF_N.Name = "chartF_N";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.MarkerBorderColor = System.Drawing.Color.Red;
            series2.MarkerColor = System.Drawing.Color.Red;
            series2.MarkerSize = 2;
            series2.Name = "Series1";
            this.chartF_N.Series.Add(series2);
            this.chartF_N.Size = new System.Drawing.Size(1093, 626);
            this.chartF_N.TabIndex = 37;
            this.chartF_N.Text = "chartData";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chartI_F);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1108, 637);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "I=f(F)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chartI_F
            // 
            this.chartI_F.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.AxisX.Interval = 5D;
            chartArea3.AxisX.Maximum = 150D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.Name = "ChartArea1";
            this.chartI_F.ChartAreas.Add(chartArea3);
            this.chartI_F.Location = new System.Drawing.Point(5, 4);
            this.chartI_F.Margin = new System.Windows.Forms.Padding(4);
            this.chartI_F.Name = "chartI_F";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.MarkerBorderColor = System.Drawing.Color.Red;
            series3.MarkerColor = System.Drawing.Color.Red;
            series3.MarkerSize = 2;
            series3.Name = "Series1";
            this.chartI_F.Series.Add(series3);
            this.chartI_F.Size = new System.Drawing.Size(1093, 626);
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
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1108, 637);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Calib with voltage source";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(89, 138);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(255, 29);
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
            this.dataGridViewCalibData.Location = new System.Drawing.Point(12, 172);
            this.dataGridViewCalibData.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCalibData.Name = "dataGridViewCalibData";
            this.dataGridViewCalibData.ReadOnly = true;
            this.dataGridViewCalibData.RowHeadersVisible = false;
            this.dataGridViewCalibData.Size = new System.Drawing.Size(459, 454);
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
            this.groupBox7.Location = new System.Drawing.Point(564, 10);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(119, 68);
            this.groupBox7.TabIndex = 58;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Num points";
            // 
            // labelNumPoints
            // 
            this.labelNumPoints.AutoSize = true;
            this.labelNumPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumPoints.Location = new System.Drawing.Point(23, 21);
            this.labelNumPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumPoints.Name = "labelNumPoints";
            this.labelNumPoints.Size = new System.Drawing.Size(76, 29);
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
            this.groupBox6.Location = new System.Drawing.Point(340, 7);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(195, 70);
            this.groupBox6.TabIndex = 55;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Current messurement ";
            // 
            // textBoxCurrenMes
            // 
            this.textBoxCurrenMes.Location = new System.Drawing.Point(55, 28);
            this.textBoxCurrenMes.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCurrenMes.Name = "textBoxCurrenMes";
            this.textBoxCurrenMes.Size = new System.Drawing.Size(85, 24);
            this.textBoxCurrenMes.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(144, 26);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 29);
            this.label12.TabIndex = 45;
            this.label12.Text = "A";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(8, 26);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 29);
            this.label14.TabIndex = 41;
            this.label14.Text = "I=";
            // 
            // buttonSaveCalib
            // 
            this.buttonSaveCalib.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveCalib.Location = new System.Drawing.Point(168, 85);
            this.buttonSaveCalib.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveCalib.Name = "buttonSaveCalib";
            this.buttonSaveCalib.Size = new System.Drawing.Size(149, 28);
            this.buttonSaveCalib.TabIndex = 57;
            this.buttonSaveCalib.Text = "SAVE";
            this.buttonSaveCalib.UseVisualStyleBackColor = true;
            this.buttonSaveCalib.Click += new System.EventHandler(this.buttonSaveCalib_Click);
            // 
            // buttonAddCalib
            // 
            this.buttonAddCalib.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCalib.Location = new System.Drawing.Point(12, 85);
            this.buttonAddCalib.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddCalib.Name = "buttonAddCalib";
            this.buttonAddCalib.Size = new System.Drawing.Size(147, 28);
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
            this.groupBox5.Location = new System.Drawing.Point(12, 10);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(305, 68);
            this.groupBox5.TabIndex = 51;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Current measurement code";
            // 
            // labelCurrentCode
            // 
            this.labelCurrentCode.AutoSize = true;
            this.labelCurrentCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentCode.Location = new System.Drawing.Point(37, 30);
            this.labelCurrentCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentCode.Name = "labelCurrentCode";
            this.labelCurrentCode.Size = new System.Drawing.Size(49, 20);
            this.labelCurrentCode.TabIndex = 46;
            this.labelCurrentCode.Text = "0.000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(8, 23);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 29);
            this.label13.TabIndex = 41;
            this.label13.Text = "I=";
            // 
            // buttonRestore
            // 
            this.buttonRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRestore.Location = new System.Drawing.Point(211, 27);
            this.buttonRestore.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(87, 28);
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
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(1108, 637);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Calib with voltmeter";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox9.Controls.Add(this.buttonStartCollect);
            this.groupBox9.Controls.Add(this.buttonCalc);
            this.groupBox9.Controls.Add(this.buttonStopCollect);
            this.groupBox9.Controls.Add(this.buttonRemoveCalibPoint);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox9.Location = new System.Drawing.Point(12, 7);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox9.Size = new System.Drawing.Size(267, 152);
            this.groupBox9.TabIndex = 70;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Calib processing";
            // 
            // buttonStartCollect
            // 
            this.buttonStartCollect.Appearance = System.Windows.Forms.Appearance.Button;
            this.buttonStartCollect.AutoSize = true;
            this.buttonStartCollect.BackColor = System.Drawing.Color.Yellow;
            this.buttonStartCollect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStartCollect.Location = new System.Drawing.Point(8, 55);
            this.buttonStartCollect.Name = "buttonStartCollect";
            this.buttonStartCollect.Size = new System.Drawing.Size(96, 28);
            this.buttonStartCollect.TabIndex = 72;
            this.buttonStartCollect.Text = "Start collect";
            this.buttonStartCollect.UseVisualStyleBackColor = false;
            this.buttonStartCollect.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // buttonCalc
            // 
            this.buttonCalc.BackColor = System.Drawing.Color.Lime;
            this.buttonCalc.Enabled = false;
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalc.Location = new System.Drawing.Point(148, 22);
            this.buttonCalc.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(105, 60);
            this.buttonCalc.TabIndex = 65;
            this.buttonCalc.Text = "Calc";
            this.buttonCalc.UseVisualStyleBackColor = false;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonStopCollect
            // 
            this.buttonStopCollect.Appearance = System.Windows.Forms.Appearance.Button;
            this.buttonStopCollect.AutoSize = true;
            this.buttonStopCollect.BackColor = System.Drawing.Color.Yellow;
            this.buttonStopCollect.Checked = true;
            this.buttonStopCollect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStopCollect.Location = new System.Drawing.Point(8, 22);
            this.buttonStopCollect.Name = "buttonStopCollect";
            this.buttonStopCollect.Size = new System.Drawing.Size(96, 28);
            this.buttonStopCollect.TabIndex = 71;
            this.buttonStopCollect.TabStop = true;
            this.buttonStopCollect.Text = "Stop collect";
            this.buttonStopCollect.UseVisualStyleBackColor = false;
            this.buttonStopCollect.CheckedChanged += new System.EventHandler(this.buttonStopCallect_CheckedChanged);
            // 
            // buttonRemoveCalibPoint
            // 
            this.buttonRemoveCalibPoint.BackColor = System.Drawing.Color.Red;
            this.buttonRemoveCalibPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveCalibPoint.Location = new System.Drawing.Point(8, 108);
            this.buttonRemoveCalibPoint.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveCalibPoint.Name = "buttonRemoveCalibPoint";
            this.buttonRemoveCalibPoint.Size = new System.Drawing.Size(245, 28);
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
            this.groupBox12.Location = new System.Drawing.Point(592, 7);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox12.Size = new System.Drawing.Size(168, 152);
            this.groupBox12.TabIndex = 69;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Line paramiters";
            // 
            // bLineKoef
            // 
            this.bLineKoef.AutoSize = true;
            this.bLineKoef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bLineKoef.Location = new System.Drawing.Point(49, 100);
            this.bLineKoef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bLineKoef.Name = "bLineKoef";
            this.bLineKoef.Size = new System.Drawing.Size(42, 20);
            this.bLineKoef.TabIndex = 48;
            this.bLineKoef.Text = "NaN";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.Location = new System.Drawing.Point(8, 94);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(42, 29);
            this.label29.TabIndex = 47;
            this.label29.Text = "b=";
            // 
            // kLineKoef
            // 
            this.kLineKoef.AutoSize = true;
            this.kLineKoef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kLineKoef.Location = new System.Drawing.Point(49, 47);
            this.kLineKoef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kLineKoef.Name = "kLineKoef";
            this.kLineKoef.Size = new System.Drawing.Size(42, 20);
            this.kLineKoef.TabIndex = 46;
            this.kLineKoef.Text = "NaN";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.Location = new System.Drawing.Point(8, 41);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 29);
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
            this.groupBox11.Location = new System.Drawing.Point(832, 7);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox11.Size = new System.Drawing.Size(236, 315);
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
            this.calibNumPoinCalib.Location = new System.Drawing.Point(15, 228);
            this.calibNumPoinCalib.Margin = new System.Windows.Forms.Padding(4);
            this.calibNumPoinCalib.Name = "calibNumPoinCalib";
            this.calibNumPoinCalib.Size = new System.Drawing.Size(211, 24);
            this.calibNumPoinCalib.TabIndex = 45;
            this.calibNumPoinCalib.Text = "10";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(11, 208);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(195, 17);
            this.label17.TabIndex = 44;
            this.label17.Text = "Num point for one current";
            // 
            // calibMBBAddress
            // 
            this.calibMBBAddress.Location = new System.Drawing.Point(157, 68);
            this.calibMBBAddress.Margin = new System.Windows.Forms.Padding(4);
            this.calibMBBAddress.Name = "calibMBBAddress";
            this.calibMBBAddress.Size = new System.Drawing.Size(68, 22);
            this.calibMBBAddress.TabIndex = 43;
            this.calibMBBAddress.Text = "1";
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(4, 73);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(120, 17);
            this.label25.TabIndex = 42;
            this.label25.Text = "Device address";
            // 
            // calibVoltAddres
            // 
            this.calibVoltAddres.Location = new System.Drawing.Point(157, 28);
            this.calibVoltAddres.Margin = new System.Windows.Forms.Padding(4);
            this.calibVoltAddres.Name = "calibVoltAddres";
            this.calibVoltAddres.Size = new System.Drawing.Size(68, 22);
            this.calibVoltAddres.TabIndex = 41;
            this.calibVoltAddres.Text = "2";
            // 
            // calibNumReg
            // 
            this.calibNumReg.Location = new System.Drawing.Point(124, 171);
            this.calibNumReg.Margin = new System.Windows.Forms.Padding(4);
            this.calibNumReg.Name = "calibNumReg";
            this.calibNumReg.Size = new System.Drawing.Size(103, 22);
            this.calibNumReg.TabIndex = 41;
            this.calibNumReg.Text = "6";
            // 
            // calibModBusRegAddress
            // 
            this.calibModBusRegAddress.Location = new System.Drawing.Point(12, 171);
            this.calibModBusRegAddress.Margin = new System.Windows.Forms.Padding(4);
            this.calibModBusRegAddress.Name = "calibModBusRegAddress";
            this.calibModBusRegAddress.Size = new System.Drawing.Size(103, 22);
            this.calibModBusRegAddress.TabIndex = 40;
            this.calibModBusRegAddress.Text = "529";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(120, 151);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 17);
            this.label21.TabIndex = 39;
            this.label21.Text = "NumData";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(8, 151);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(101, 17);
            this.label22.TabIndex = 33;
            this.label22.Text = "DataAddress";
            // 
            // buttonAddCalibRequest
            // 
            this.buttonAddCalibRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddCalibRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCalibRequest.Location = new System.Drawing.Point(12, 274);
            this.buttonAddCalibRequest.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddCalibRequest.Name = "buttonAddCalibRequest";
            this.buttonAddCalibRequest.Size = new System.Drawing.Size(215, 32);
            this.buttonAddCalibRequest.TabIndex = 1;
            this.buttonAddCalibRequest.Text = "START CALIB";
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
            this.calibModBusFun.Location = new System.Drawing.Point(157, 108);
            this.calibModBusFun.Margin = new System.Windows.Forms.Padding(4);
            this.calibModBusFun.Name = "calibModBusFun";
            this.calibModBusFun.Size = new System.Drawing.Size(68, 24);
            this.calibModBusFun.TabIndex = 31;
            this.calibModBusFun.Text = "3";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(4, 33);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(140, 17);
            this.label23.TabIndex = 3;
            this.label23.Text = "Voltmeter address";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(5, 114);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(70, 17);
            this.label24.TabIndex = 32;
            this.label24.Text = "Function";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(253, 178);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(255, 29);
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
            this.calibGrid.Location = new System.Drawing.Point(12, 217);
            this.calibGrid.Margin = new System.Windows.Forms.Padding(4);
            this.calibGrid.Name = "calibGrid";
            this.calibGrid.ReadOnly = true;
            this.calibGrid.RowHeadersVisible = false;
            this.calibGrid.Size = new System.Drawing.Size(748, 407);
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
            this.groupBox8.Controls.Add(this.lableNumTempPoint);
            this.groupBox8.Controls.Add(this.label18);
            this.groupBox8.Controls.Add(this.lableNumGlobalPoint);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox8.Location = new System.Drawing.Point(317, 7);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox8.Size = new System.Drawing.Size(233, 92);
            this.groupBox8.TabIndex = 65;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Num points";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(16, 53);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 29);
            this.label20.TabIndex = 50;
            this.label20.Text = "Temp:";
            // 
            // lableNumTempPoint
            // 
            this.lableNumTempPoint.AutoSize = true;
            this.lableNumTempPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableNumTempPoint.Location = new System.Drawing.Point(123, 53);
            this.lableNumTempPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableNumTempPoint.Name = "lableNumTempPoint";
            this.lableNumTempPoint.Size = new System.Drawing.Size(27, 29);
            this.lableNumTempPoint.TabIndex = 49;
            this.lableNumTempPoint.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(16, 22);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 29);
            this.label18.TabIndex = 48;
            this.label18.Text = "Global:";
            // 
            // lableNumGlobalPoint
            // 
            this.lableNumGlobalPoint.AutoSize = true;
            this.lableNumGlobalPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableNumGlobalPoint.Location = new System.Drawing.Point(123, 22);
            this.lableNumGlobalPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableNumGlobalPoint.Name = "lableNumGlobalPoint";
            this.lableNumGlobalPoint.Size = new System.Drawing.Size(27, 29);
            this.lableNumGlobalPoint.TabIndex = 42;
            this.lableNumGlobalPoint.Text = "0";
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox10.Controls.Add(this.calibMBBCode);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox10.Location = new System.Drawing.Point(314, 112);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox10.Size = new System.Drawing.Size(236, 47);
            this.groupBox10.TabIndex = 61;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Current measurement code";
            // 
            // calibMBBCode
            // 
            this.calibMBBCode.AutoSize = true;
            this.calibMBBCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calibMBBCode.Location = new System.Drawing.Point(13, 21);
            this.calibMBBCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.calibMBBCode.Name = "calibMBBCode";
            this.calibMBBCode.Size = new System.Drawing.Size(49, 20);
            this.calibMBBCode.TabIndex = 46;
            this.calibMBBCode.Text = "0.000";
            // 
            // buttonAddPoint
            // 
            this.buttonAddPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddPoint.Enabled = false;
            this.buttonAddPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPoint.Location = new System.Drawing.Point(457, 724);
            this.buttonAddPoint.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddPoint.Name = "buttonAddPoint";
            this.buttonAddPoint.Size = new System.Drawing.Size(137, 31);
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
            this.checkBoxSelAddMode.Location = new System.Drawing.Point(459, 695);
            this.checkBoxSelAddMode.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxSelAddMode.Name = "checkBoxSelAddMode";
            this.checkBoxSelAddMode.Size = new System.Drawing.Size(122, 21);
            this.checkBoxSelAddMode.TabIndex = 53;
            this.checkBoxSelAddMode.Text = "Auto add point";
            this.checkBoxSelAddMode.UseVisualStyleBackColor = true;
            this.checkBoxSelAddMode.CheckedChanged += new System.EventHandler(this.checkBoxSelAddMode_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(627, 695);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 65);
            this.button1.TabIndex = 54;
            this.button1.Text = "Clear chart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 783);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label lableNumGlobalPoint;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox calibNumPoinCalib;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lableNumTempPoint;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RadioButton buttonStopCollect;
        private System.Windows.Forms.RadioButton buttonStartCollect;
    }
}

