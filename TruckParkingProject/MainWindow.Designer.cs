namespace TruckParkingDataAnalysis
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDataFolder = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnReadVideoFiles = new System.Windows.Forms.Button();
            this.TruckDataOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.btnParkingRecords = new System.Windows.Forms.Button();
            this.grpIntervalSpecification = new System.Windows.Forms.GroupBox();
            this.updnEndDay = new System.Windows.Forms.NumericUpDown();
            this.updnEndMonth = new System.Windows.Forms.NumericUpDown();
            this.updnStartDay = new System.Windows.Forms.NumericUpDown();
            this.updnStartMonth = new System.Windows.Forms.NumericUpDown();
            this.lblIntervalEnd = new System.Windows.Forms.Label();
            this.lblIntervalStart = new System.Windows.Forms.Label();
            this.updnEndSecond = new System.Windows.Forms.NumericUpDown();
            this.updnStartMinute = new System.Windows.Forms.NumericUpDown();
            this.updnStartSecond = new System.Windows.Forms.NumericUpDown();
            this.updnEndHour = new System.Windows.Forms.NumericUpDown();
            this.updnStartHour = new System.Windows.Forms.NumericUpDown();
            this.updnEndMinute = new System.Windows.Forms.NumericUpDown();
            this.lblRecordInterval = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updnSpaceEndNum = new System.Windows.Forms.NumericUpDown();
            this.updnSpaceStartNum = new System.Windows.Forms.NumericUpDown();
            this.btnReadIPsensFiles = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIPsensFolder = new System.Windows.Forms.Label();
            this.btnReadSensysFiles = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSensysFolder = new System.Windows.Forms.Label();
            this.btnReadCivicSmartFiles = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCivicSmartFolder = new System.Windows.Forms.Label();
            this.grpAccuracyTest = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtNumEvents = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOccupancyCompare = new System.Windows.Forms.Button();
            this.txtOccupancyAccuracy = new System.Windows.Forms.TextBox();
            this.lblOccupancyAccuracy = new System.Windows.Forms.Label();
            this.txtRange = new System.Windows.Forms.TextBox();
            this.lblRange = new System.Windows.Forms.Label();
            this.btnEventCompare = new System.Windows.Forms.Button();
            this.txtEventAccuracy = new System.Windows.Forms.TextBox();
            this.lblEventAccuracy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.lblTimeDifference = new System.Windows.Forms.Label();
            this.txtTimeDifference = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnReadBlueBandFile = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblBlueBandFolder = new System.Windows.Forms.Label();
            this.txtOffsetBlueBand = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnReadBlueBandReport = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblBlueBandReportFolder = new System.Windows.Forms.Label();
            this.grpIntervalSpecification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnEndDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnEndMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnStartDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnStartMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnEndSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnStartMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnStartSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnEndHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnStartHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnEndMinute)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnSpaceEndNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnSpaceStartNum)).BeginInit();
            this.grpAccuracyTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDataFolder
            // 
            this.lblDataFolder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDataFolder.Location = new System.Drawing.Point(185, 12);
            this.lblDataFolder.Name = "lblDataFolder";
            this.lblDataFolder.Size = new System.Drawing.Size(548, 25);
            this.lblDataFolder.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Video Data Folder:";
            // 
            // btnReadVideoFiles
            // 
            this.btnReadVideoFiles.Location = new System.Drawing.Point(751, 12);
            this.btnReadVideoFiles.Name = "btnReadVideoFiles";
            this.btnReadVideoFiles.Size = new System.Drawing.Size(86, 25);
            this.btnReadVideoFiles.TabIndex = 47;
            this.btnReadVideoFiles.Text = "Read File";
            this.btnReadVideoFiles.UseVisualStyleBackColor = true;
            this.btnReadVideoFiles.Click += new System.EventHandler(this.btnReadVideoFiles_Click);
            // 
            // TruckDataOpenFile
            // 
            this.TruckDataOpenFile.FileName = "openFileDialog1";
            // 
            // btnParkingRecords
            // 
            this.btnParkingRecords.Location = new System.Drawing.Point(478, 308);
            this.btnParkingRecords.Margin = new System.Windows.Forms.Padding(2);
            this.btnParkingRecords.Name = "btnParkingRecords";
            this.btnParkingRecords.Size = new System.Drawing.Size(197, 24);
            this.btnParkingRecords.TabIndex = 49;
            this.btnParkingRecords.Text = "Display Parking Records and Charts";
            this.btnParkingRecords.UseVisualStyleBackColor = true;
            this.btnParkingRecords.Click += new System.EventHandler(this.btnParkingLot_Click);
            // 
            // grpIntervalSpecification
            // 
            this.grpIntervalSpecification.Controls.Add(this.updnEndDay);
            this.grpIntervalSpecification.Controls.Add(this.updnEndMonth);
            this.grpIntervalSpecification.Controls.Add(this.updnStartDay);
            this.grpIntervalSpecification.Controls.Add(this.updnStartMonth);
            this.grpIntervalSpecification.Controls.Add(this.lblIntervalEnd);
            this.grpIntervalSpecification.Controls.Add(this.lblIntervalStart);
            this.grpIntervalSpecification.Controls.Add(this.updnEndSecond);
            this.grpIntervalSpecification.Controls.Add(this.updnStartMinute);
            this.grpIntervalSpecification.Controls.Add(this.updnStartSecond);
            this.grpIntervalSpecification.Controls.Add(this.updnEndHour);
            this.grpIntervalSpecification.Controls.Add(this.updnStartHour);
            this.grpIntervalSpecification.Controls.Add(this.updnEndMinute);
            this.grpIntervalSpecification.Location = new System.Drawing.Point(32, 268);
            this.grpIntervalSpecification.Margin = new System.Windows.Forms.Padding(2);
            this.grpIntervalSpecification.Name = "grpIntervalSpecification";
            this.grpIntervalSpecification.Padding = new System.Windows.Forms.Padding(2);
            this.grpIntervalSpecification.Size = new System.Drawing.Size(258, 98);
            this.grpIntervalSpecification.TabIndex = 50;
            this.grpIntervalSpecification.TabStop = false;
            this.grpIntervalSpecification.Text = "Record Interval";
            // 
            // updnEndDay
            // 
            this.updnEndDay.Location = new System.Drawing.Point(59, 66);
            this.updnEndDay.Margin = new System.Windows.Forms.Padding(2);
            this.updnEndDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.updnEndDay.Name = "updnEndDay";
            this.updnEndDay.Size = new System.Drawing.Size(33, 20);
            this.updnEndDay.TabIndex = 25;
            this.updnEndDay.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.updnEndDay.ValueChanged += new System.EventHandler(this.updnEndDay_ValueChanged);
            // 
            // updnEndMonth
            // 
            this.updnEndMonth.Location = new System.Drawing.Point(7, 66);
            this.updnEndMonth.Margin = new System.Windows.Forms.Padding(2);
            this.updnEndMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.updnEndMonth.Name = "updnEndMonth";
            this.updnEndMonth.Size = new System.Drawing.Size(33, 20);
            this.updnEndMonth.TabIndex = 26;
            this.updnEndMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updnEndMonth.ValueChanged += new System.EventHandler(this.updnEndMonth_ValueChanged);
            // 
            // updnStartDay
            // 
            this.updnStartDay.Location = new System.Drawing.Point(59, 30);
            this.updnStartDay.Margin = new System.Windows.Forms.Padding(2);
            this.updnStartDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.updnStartDay.Name = "updnStartDay";
            this.updnStartDay.Size = new System.Drawing.Size(33, 20);
            this.updnStartDay.TabIndex = 22;
            this.updnStartDay.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.updnStartDay.ValueChanged += new System.EventHandler(this.updnStartDay_ValueChanged);
            // 
            // updnStartMonth
            // 
            this.updnStartMonth.Location = new System.Drawing.Point(7, 30);
            this.updnStartMonth.Margin = new System.Windows.Forms.Padding(2);
            this.updnStartMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.updnStartMonth.Name = "updnStartMonth";
            this.updnStartMonth.Size = new System.Drawing.Size(33, 20);
            this.updnStartMonth.TabIndex = 23;
            this.updnStartMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updnStartMonth.ValueChanged += new System.EventHandler(this.updnStartMonth_ValueChanged);
            // 
            // lblIntervalEnd
            // 
            this.lblIntervalEnd.AutoSize = true;
            this.lblIntervalEnd.Location = new System.Drawing.Point(4, 51);
            this.lblIntervalEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIntervalEnd.Name = "lblIntervalEnd";
            this.lblIntervalEnd.Size = new System.Drawing.Size(91, 13);
            this.lblIntervalEnd.TabIndex = 20;
            this.lblIntervalEnd.Text = "End (M/D/h/m/s)";
            // 
            // lblIntervalStart
            // 
            this.lblIntervalStart.AutoSize = true;
            this.lblIntervalStart.Location = new System.Drawing.Point(4, 15);
            this.lblIntervalStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIntervalStart.Name = "lblIntervalStart";
            this.lblIntervalStart.Size = new System.Drawing.Size(94, 13);
            this.lblIntervalStart.TabIndex = 19;
            this.lblIntervalStart.Text = "Start (M/D/h/m/s)";
            // 
            // updnEndSecond
            // 
            this.updnEndSecond.Location = new System.Drawing.Point(216, 66);
            this.updnEndSecond.Margin = new System.Windows.Forms.Padding(2);
            this.updnEndSecond.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.updnEndSecond.Name = "updnEndSecond";
            this.updnEndSecond.Size = new System.Drawing.Size(33, 20);
            this.updnEndSecond.TabIndex = 14;
            this.updnEndSecond.ValueChanged += new System.EventHandler(this.updnEndSecond_ValueChanged);
            // 
            // updnStartMinute
            // 
            this.updnStartMinute.Location = new System.Drawing.Point(163, 30);
            this.updnStartMinute.Margin = new System.Windows.Forms.Padding(2);
            this.updnStartMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.updnStartMinute.Name = "updnStartMinute";
            this.updnStartMinute.Size = new System.Drawing.Size(33, 20);
            this.updnStartMinute.TabIndex = 17;
            this.updnStartMinute.ValueChanged += new System.EventHandler(this.updnStartMinute_ValueChanged);
            // 
            // updnStartSecond
            // 
            this.updnStartSecond.Location = new System.Drawing.Point(216, 30);
            this.updnStartSecond.Margin = new System.Windows.Forms.Padding(2);
            this.updnStartSecond.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.updnStartSecond.Name = "updnStartSecond";
            this.updnStartSecond.Size = new System.Drawing.Size(33, 20);
            this.updnStartSecond.TabIndex = 16;
            this.updnStartSecond.ValueChanged += new System.EventHandler(this.updnStartSecond_ValueChanged);
            // 
            // updnEndHour
            // 
            this.updnEndHour.Location = new System.Drawing.Point(111, 66);
            this.updnEndHour.Margin = new System.Windows.Forms.Padding(2);
            this.updnEndHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.updnEndHour.Name = "updnEndHour";
            this.updnEndHour.Size = new System.Drawing.Size(33, 20);
            this.updnEndHour.TabIndex = 13;
            this.updnEndHour.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.updnEndHour.ValueChanged += new System.EventHandler(this.updnEndHour_ValueChanged);
            // 
            // updnStartHour
            // 
            this.updnStartHour.Location = new System.Drawing.Point(111, 30);
            this.updnStartHour.Margin = new System.Windows.Forms.Padding(2);
            this.updnStartHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.updnStartHour.Name = "updnStartHour";
            this.updnStartHour.Size = new System.Drawing.Size(33, 20);
            this.updnStartHour.TabIndex = 18;
            this.updnStartHour.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.updnStartHour.ValueChanged += new System.EventHandler(this.updnStartHour_ValueChanged);
            // 
            // updnEndMinute
            // 
            this.updnEndMinute.Location = new System.Drawing.Point(163, 66);
            this.updnEndMinute.Margin = new System.Windows.Forms.Padding(2);
            this.updnEndMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.updnEndMinute.Name = "updnEndMinute";
            this.updnEndMinute.Size = new System.Drawing.Size(33, 20);
            this.updnEndMinute.TabIndex = 15;
            this.updnEndMinute.ValueChanged += new System.EventHandler(this.updnEndMinute_ValueChanged);
            // 
            // lblRecordInterval
            // 
            this.lblRecordInterval.AutoSize = true;
            this.lblRecordInterval.Location = new System.Drawing.Point(29, 379);
            this.lblRecordInterval.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecordInterval.Name = "lblRecordInterval";
            this.lblRecordInterval.Size = new System.Drawing.Size(330, 26);
            this.lblRecordInterval.TabIndex = 51;
            this.lblRecordInterval.Text = "(Specify the start and end time of the studied parking interval, will be \r\nused i" +
    "n the developement of charts and calculation of statistics.)\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.updnSpaceEndNum);
            this.groupBox1.Controls.Add(this.updnSpaceStartNum);
            this.groupBox1.Location = new System.Drawing.Point(337, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 98);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Space Numbers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "End #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Start #";
            // 
            // updnSpaceEndNum
            // 
            this.updnSpaceEndNum.Location = new System.Drawing.Point(49, 66);
            this.updnSpaceEndNum.Margin = new System.Windows.Forms.Padding(2);
            this.updnSpaceEndNum.Name = "updnSpaceEndNum";
            this.updnSpaceEndNum.Size = new System.Drawing.Size(33, 20);
            this.updnSpaceEndNum.TabIndex = 25;
            this.updnSpaceEndNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.updnSpaceEndNum.ValueChanged += new System.EventHandler(this.updnSpaceEndNum_ValueChanged);
            // 
            // updnSpaceStartNum
            // 
            this.updnSpaceStartNum.Location = new System.Drawing.Point(49, 30);
            this.updnSpaceStartNum.Margin = new System.Windows.Forms.Padding(2);
            this.updnSpaceStartNum.Name = "updnSpaceStartNum";
            this.updnSpaceStartNum.Size = new System.Drawing.Size(33, 20);
            this.updnSpaceStartNum.TabIndex = 24;
            this.updnSpaceStartNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updnSpaceStartNum.ValueChanged += new System.EventHandler(this.updnSpaceStartNum_ValueChanged);
            // 
            // btnReadIPsensFiles
            // 
            this.btnReadIPsensFiles.Location = new System.Drawing.Point(751, 130);
            this.btnReadIPsensFiles.Name = "btnReadIPsensFiles";
            this.btnReadIPsensFiles.Size = new System.Drawing.Size(86, 25);
            this.btnReadIPsensFiles.TabIndex = 55;
            this.btnReadIPsensFiles.Text = "Read File";
            this.btnReadIPsensFiles.UseVisualStyleBackColor = true;
            this.btnReadIPsensFiles.Click += new System.EventHandler(this.btnReadIPsensFiles_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "IPsens Data Folder:";
            // 
            // lblIPsensFolder
            // 
            this.lblIPsensFolder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIPsensFolder.Location = new System.Drawing.Point(185, 131);
            this.lblIPsensFolder.Name = "lblIPsensFolder";
            this.lblIPsensFolder.Size = new System.Drawing.Size(548, 25);
            this.lblIPsensFolder.TabIndex = 53;
            // 
            // btnReadSensysFiles
            // 
            this.btnReadSensysFiles.Location = new System.Drawing.Point(751, 174);
            this.btnReadSensysFiles.Name = "btnReadSensysFiles";
            this.btnReadSensysFiles.Size = new System.Drawing.Size(86, 25);
            this.btnReadSensysFiles.TabIndex = 58;
            this.btnReadSensysFiles.Text = "Read File";
            this.btnReadSensysFiles.UseVisualStyleBackColor = true;
            this.btnReadSensysFiles.Click += new System.EventHandler(this.btnReadSensysFiles_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Sensys Data Folder:";
            // 
            // lblSensysFolder
            // 
            this.lblSensysFolder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSensysFolder.Location = new System.Drawing.Point(185, 177);
            this.lblSensysFolder.Name = "lblSensysFolder";
            this.lblSensysFolder.Size = new System.Drawing.Size(548, 25);
            this.lblSensysFolder.TabIndex = 56;
            // 
            // btnReadCivicSmartFiles
            // 
            this.btnReadCivicSmartFiles.Location = new System.Drawing.Point(751, 216);
            this.btnReadCivicSmartFiles.Name = "btnReadCivicSmartFiles";
            this.btnReadCivicSmartFiles.Size = new System.Drawing.Size(86, 25);
            this.btnReadCivicSmartFiles.TabIndex = 61;
            this.btnReadCivicSmartFiles.Text = "Read File";
            this.btnReadCivicSmartFiles.UseVisualStyleBackColor = true;
            this.btnReadCivicSmartFiles.Click += new System.EventHandler(this.btnReadCivicSmartFiles_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "CivicSmart Data Folder:";
            // 
            // lblCivicSmartFolder
            // 
            this.lblCivicSmartFolder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCivicSmartFolder.Location = new System.Drawing.Point(185, 217);
            this.lblCivicSmartFolder.Name = "lblCivicSmartFolder";
            this.lblCivicSmartFolder.Size = new System.Drawing.Size(548, 25);
            this.lblCivicSmartFolder.TabIndex = 59;
            // 
            // grpAccuracyTest
            // 
            this.grpAccuracyTest.Controls.Add(this.btnClear);
            this.grpAccuracyTest.Controls.Add(this.label8);
            this.grpAccuracyTest.Controls.Add(this.txtDuration);
            this.grpAccuracyTest.Controls.Add(this.txtNumEvents);
            this.grpAccuracyTest.Controls.Add(this.label6);
            this.grpAccuracyTest.Controls.Add(this.btnOccupancyCompare);
            this.grpAccuracyTest.Controls.Add(this.txtOccupancyAccuracy);
            this.grpAccuracyTest.Controls.Add(this.lblOccupancyAccuracy);
            this.grpAccuracyTest.Controls.Add(this.txtRange);
            this.grpAccuracyTest.Controls.Add(this.lblRange);
            this.grpAccuracyTest.Controls.Add(this.btnEventCompare);
            this.grpAccuracyTest.Controls.Add(this.txtEventAccuracy);
            this.grpAccuracyTest.Controls.Add(this.lblEventAccuracy);
            this.grpAccuracyTest.Location = new System.Drawing.Point(32, 446);
            this.grpAccuracyTest.Name = "grpAccuracyTest";
            this.grpAccuracyTest.Size = new System.Drawing.Size(719, 119);
            this.grpAccuracyTest.TabIndex = 62;
            this.grpAccuracyTest.TabStop = false;
            this.grpAccuracyTest.Text = "Accuracy Tests";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(637, 56);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(69, 25);
            this.btnClear.TabIndex = 73;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "Duration (h)";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(367, 83);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.ReadOnly = true;
            this.txtDuration.Size = new System.Drawing.Size(51, 20);
            this.txtDuration.TabIndex = 71;
            // 
            // txtNumEvents
            // 
            this.txtNumEvents.Location = new System.Drawing.Point(367, 40);
            this.txtNumEvents.Name = "txtNumEvents";
            this.txtNumEvents.ReadOnly = true;
            this.txtNumEvents.Size = new System.Drawing.Size(51, 20);
            this.txtNumEvents.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "# of Events";
            // 
            // btnOccupancyCompare
            // 
            this.btnOccupancyCompare.Location = new System.Drawing.Point(140, 79);
            this.btnOccupancyCompare.Name = "btnOccupancyCompare";
            this.btnOccupancyCompare.Size = new System.Drawing.Size(118, 25);
            this.btnOccupancyCompare.TabIndex = 68;
            this.btnOccupancyCompare.Text = "Occupancy Compare";
            this.btnOccupancyCompare.UseVisualStyleBackColor = true;
            this.btnOccupancyCompare.Click += new System.EventHandler(this.btnOccupancyCompare_Click);
            // 
            // txtOccupancyAccuracy
            // 
            this.txtOccupancyAccuracy.Location = new System.Drawing.Point(557, 83);
            this.txtOccupancyAccuracy.Name = "txtOccupancyAccuracy";
            this.txtOccupancyAccuracy.ReadOnly = true;
            this.txtOccupancyAccuracy.Size = new System.Drawing.Size(51, 20);
            this.txtOccupancyAccuracy.TabIndex = 67;
            // 
            // lblOccupancyAccuracy
            // 
            this.lblOccupancyAccuracy.AutoSize = true;
            this.lblOccupancyAccuracy.Location = new System.Drawing.Point(424, 86);
            this.lblOccupancyAccuracy.Name = "lblOccupancyAccuracy";
            this.lblOccupancyAccuracy.Size = new System.Drawing.Size(127, 13);
            this.lblOccupancyAccuracy.TabIndex = 66;
            this.lblOccupancyAccuracy.Text = "Occupancy Accuracy (%)";
            // 
            // txtRange
            // 
            this.txtRange.Location = new System.Drawing.Point(74, 40);
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(41, 20);
            this.txtRange.TabIndex = 65;
            this.txtRange.Text = "90";
            this.txtRange.TextChanged += new System.EventHandler(this.txtRange_TextChanged);
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(16, 43);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(53, 13);
            this.lblRange.TabIndex = 64;
            this.lblRange.Text = "Range (s)";
            // 
            // btnEventCompare
            // 
            this.btnEventCompare.Location = new System.Drawing.Point(140, 37);
            this.btnEventCompare.Name = "btnEventCompare";
            this.btnEventCompare.Size = new System.Drawing.Size(118, 25);
            this.btnEventCompare.TabIndex = 63;
            this.btnEventCompare.Text = "Events Compare";
            this.btnEventCompare.UseVisualStyleBackColor = true;
            this.btnEventCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // txtEventAccuracy
            // 
            this.txtEventAccuracy.Location = new System.Drawing.Point(557, 40);
            this.txtEventAccuracy.Name = "txtEventAccuracy";
            this.txtEventAccuracy.ReadOnly = true;
            this.txtEventAccuracy.Size = new System.Drawing.Size(51, 20);
            this.txtEventAccuracy.TabIndex = 3;
            // 
            // lblEventAccuracy
            // 
            this.lblEventAccuracy.AutoSize = true;
            this.lblEventAccuracy.Location = new System.Drawing.Point(451, 43);
            this.lblEventAccuracy.Name = "lblEventAccuracy";
            this.lblEventAccuracy.Size = new System.Drawing.Size(100, 13);
            this.lblEventAccuracy.TabIndex = 1;
            this.lblEventAccuracy.Text = "Event Accuracy (%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(840, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Offset";
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(881, 220);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(39, 20);
            this.txtOffset.TabIndex = 64;
            this.txtOffset.Text = "120";
            this.txtOffset.TextChanged += new System.EventHandler(this.txtOffset_TextChanged);
            // 
            // lblTimeDifference
            // 
            this.lblTimeDifference.AutoSize = true;
            this.lblTimeDifference.Location = new System.Drawing.Point(840, 183);
            this.lblTimeDifference.Name = "lblTimeDifference";
            this.lblTimeDifference.Size = new System.Drawing.Size(79, 13);
            this.lblTimeDifference.TabIndex = 65;
            this.lblTimeDifference.Text = "TimeDifference";
            // 
            // txtTimeDifference
            // 
            this.txtTimeDifference.Location = new System.Drawing.Point(925, 180);
            this.txtTimeDifference.Name = "txtTimeDifference";
            this.txtTimeDifference.Size = new System.Drawing.Size(39, 20);
            this.txtTimeDifference.TabIndex = 66;
            this.txtTimeDifference.Text = "14400";
            this.txtTimeDifference.TextChanged += new System.EventHandler(this.txtTimeDifference_TextChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(788, 541);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 24);
            this.button1.TabIndex = 67;
            this.button1.Text = "TimeStamp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(892, 541);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 24);
            this.button2.TabIndex = 68;
            this.button2.Text = "OutPut";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReadBlueBandFile
            // 
            this.btnReadBlueBandFile.Location = new System.Drawing.Point(751, 53);
            this.btnReadBlueBandFile.Name = "btnReadBlueBandFile";
            this.btnReadBlueBandFile.Size = new System.Drawing.Size(86, 25);
            this.btnReadBlueBandFile.TabIndex = 71;
            this.btnReadBlueBandFile.Text = "Read File";
            this.btnReadBlueBandFile.UseVisualStyleBackColor = true;
            this.btnReadBlueBandFile.Click += new System.EventHandler(this.btnReadBlueBandFile_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "BLUE-BAND Raw Data Folder:";
            // 
            // lblBlueBandFolder
            // 
            this.lblBlueBandFolder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBlueBandFolder.Location = new System.Drawing.Point(185, 54);
            this.lblBlueBandFolder.Name = "lblBlueBandFolder";
            this.lblBlueBandFolder.Size = new System.Drawing.Size(548, 25);
            this.lblBlueBandFolder.TabIndex = 69;
            // 
            // txtOffsetBlueBand
            // 
            this.txtOffsetBlueBand.Location = new System.Drawing.Point(895, 75);
            this.txtOffsetBlueBand.Name = "txtOffsetBlueBand";
            this.txtOffsetBlueBand.Size = new System.Drawing.Size(39, 20);
            this.txtOffsetBlueBand.TabIndex = 73;
            this.txtOffsetBlueBand.Text = "30";
            this.txtOffsetBlueBand.TextChanged += new System.EventHandler(this.txtOffsetBlueBand_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(854, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 72;
            this.label11.Text = "Offset";
            // 
            // btnReadBlueBandReport
            // 
            this.btnReadBlueBandReport.Location = new System.Drawing.Point(751, 89);
            this.btnReadBlueBandReport.Name = "btnReadBlueBandReport";
            this.btnReadBlueBandReport.Size = new System.Drawing.Size(86, 25);
            this.btnReadBlueBandReport.TabIndex = 76;
            this.btnReadBlueBandReport.Text = "Read File";
            this.btnReadBlueBandReport.UseVisualStyleBackColor = true;
            this.btnReadBlueBandReport.Click += new System.EventHandler(this.btnReadBlueBandReport_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 13);
            this.label12.TabIndex = 75;
            this.label12.Text = "BLUE-BAND Report Data Folder:";
            // 
            // lblBlueBandReportFolder
            // 
            this.lblBlueBandReportFolder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBlueBandReportFolder.Location = new System.Drawing.Point(185, 90);
            this.lblBlueBandReportFolder.Name = "lblBlueBandReportFolder";
            this.lblBlueBandReportFolder.Size = new System.Drawing.Size(548, 25);
            this.lblBlueBandReportFolder.TabIndex = 74;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 573);
            this.Controls.Add(this.btnReadBlueBandReport);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblBlueBandReportFolder);
            this.Controls.Add(this.txtOffsetBlueBand);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnReadBlueBandFile);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblBlueBandFolder);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTimeDifference);
            this.Controls.Add(this.lblTimeDifference);
            this.Controls.Add(this.txtOffset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpAccuracyTest);
            this.Controls.Add(this.btnReadCivicSmartFiles);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCivicSmartFolder);
            this.Controls.Add(this.btnReadSensysFiles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSensysFolder);
            this.Controls.Add(this.btnReadIPsensFiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblIPsensFolder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRecordInterval);
            this.Controls.Add(this.grpIntervalSpecification);
            this.Controls.Add(this.btnParkingRecords);
            this.Controls.Add(this.btnReadVideoFiles);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblDataFolder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "Truck Parking Data";
            this.grpIntervalSpecification.ResumeLayout(false);
            this.grpIntervalSpecification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnEndDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnEndMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnStartDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnStartMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnEndSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnStartMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnStartSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnEndHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnStartHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnEndMinute)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnSpaceEndNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnSpaceStartNum)).EndInit();
            this.grpAccuracyTest.ResumeLayout(false);
            this.grpAccuracyTest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataFolder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnReadVideoFiles;
        private System.Windows.Forms.OpenFileDialog TruckDataOpenFile;
        private System.Windows.Forms.Button btnParkingRecords;
        private System.Windows.Forms.GroupBox grpIntervalSpecification;
        private System.Windows.Forms.NumericUpDown updnEndDay;
        private System.Windows.Forms.NumericUpDown updnEndMonth;
        private System.Windows.Forms.NumericUpDown updnStartDay;
        private System.Windows.Forms.NumericUpDown updnStartMonth;
        private System.Windows.Forms.Label lblIntervalEnd;
        private System.Windows.Forms.Label lblIntervalStart;
        private System.Windows.Forms.NumericUpDown updnEndSecond;
        private System.Windows.Forms.NumericUpDown updnStartMinute;
        private System.Windows.Forms.NumericUpDown updnStartSecond;
        private System.Windows.Forms.NumericUpDown updnEndHour;
        private System.Windows.Forms.NumericUpDown updnStartHour;
        private System.Windows.Forms.NumericUpDown updnEndMinute;
        private System.Windows.Forms.Label lblRecordInterval;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown updnSpaceEndNum;
        private System.Windows.Forms.NumericUpDown updnSpaceStartNum;
        private System.Windows.Forms.Button btnReadIPsensFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIPsensFolder;
        private System.Windows.Forms.Button btnReadSensysFiles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSensysFolder;
        private System.Windows.Forms.Button btnReadCivicSmartFiles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCivicSmartFolder;
        private System.Windows.Forms.GroupBox grpAccuracyTest;
        private System.Windows.Forms.Label lblEventAccuracy;
        private System.Windows.Forms.TextBox txtEventAccuracy;
        private System.Windows.Forms.Button btnEventCompare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOffset;
        private System.Windows.Forms.Label lblTimeDifference;
        private System.Windows.Forms.TextBox txtTimeDifference;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRange;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.TextBox txtOccupancyAccuracy;
        private System.Windows.Forms.Label lblOccupancyAccuracy;
        private System.Windows.Forms.Button btnOccupancyCompare;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtNumEvents;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnReadBlueBandFile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBlueBandFolder;
        private System.Windows.Forms.TextBox txtOffsetBlueBand;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnReadBlueBandReport;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblBlueBandReportFolder;
    }
}

