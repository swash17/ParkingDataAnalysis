namespace TruckParkingDataAnalysis
{
    partial class frmParkingRecords
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabDataViewer = new System.Windows.Forms.TabControl();
            this.tabRecordList = new System.Windows.Forms.TabPage();
            this.dgvTruckRecords = new System.Windows.Forms.DataGridView();
            this.colRecordID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTruckID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpaceNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInOrOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSecond = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlignment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTruckLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCharts = new System.Windows.Forms.TabPage();
            this.grpStatistics = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumTrucks = new System.Windows.Forms.TextBox();
            this.lblNumTrucks = new System.Windows.Forms.Label();
            this.txtAverageParkingTime = new System.Windows.Forms.TextBox();
            this.txtAverageOccupancy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAverageOccupancy = new System.Windows.Forms.Label();
            this.grpChartTypes = new System.Windows.Forms.GroupBox();
            this.cboChartTypes = new System.Windows.Forms.ComboBox();
            this.btnViewOutput = new System.Windows.Forms.Button();
            this.grpTimeSpecification = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
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
            this.updnSecond = new System.Windows.Forms.NumericUpDown();
            this.updnHour = new System.Windows.Forms.NumericUpDown();
            this.updnMinute = new System.Windows.Forms.NumericUpDown();
            this.updnYear = new System.Windows.Forms.NumericUpDown();
            this.updnDay = new System.Windows.Forms.NumericUpDown();
            this.updnMonth = new System.Windows.Forms.NumericUpDown();
            this.btnSpecifiedChart = new System.Windows.Forms.Button();
            this.panelChartControl = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabDataViewer.SuspendLayout();
            this.tabRecordList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTruckRecords)).BeginInit();
            this.tabCharts.SuspendLayout();
            this.grpStatistics.SuspendLayout();
            this.grpChartTypes.SuspendLayout();
            this.grpTimeSpecification.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.updnSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDataViewer
            // 
            this.tabDataViewer.Controls.Add(this.tabRecordList);
            this.tabDataViewer.Controls.Add(this.tabCharts);
            this.tabDataViewer.Location = new System.Drawing.Point(1, 0);
            this.tabDataViewer.Margin = new System.Windows.Forms.Padding(2);
            this.tabDataViewer.Name = "tabDataViewer";
            this.tabDataViewer.SelectedIndex = 0;
            this.tabDataViewer.Size = new System.Drawing.Size(1178, 652);
            this.tabDataViewer.TabIndex = 23;
            this.tabDataViewer.SelectedIndexChanged += new System.EventHandler(this.tabDataViewer_SelectedIndexChanged);
            // 
            // tabRecordList
            // 
            this.tabRecordList.Controls.Add(this.dgvTruckRecords);
            this.tabRecordList.Location = new System.Drawing.Point(4, 22);
            this.tabRecordList.Margin = new System.Windows.Forms.Padding(2);
            this.tabRecordList.Name = "tabRecordList";
            this.tabRecordList.Padding = new System.Windows.Forms.Padding(2);
            this.tabRecordList.Size = new System.Drawing.Size(1170, 626);
            this.tabRecordList.TabIndex = 0;
            this.tabRecordList.Text = "Record List";
            this.tabRecordList.UseVisualStyleBackColor = true;
            // 
            // dgvTruckRecords
            // 
            this.dgvTruckRecords.AllowDrop = true;
            this.dgvTruckRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTruckRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRecordID,
            this.colTruckID,
            this.colSpaceNum,
            this.colInOrOut,
            this.colDate,
            this.colYear,
            this.colMonth,
            this.colDay,
            this.colTime,
            this.colHour,
            this.colMinute,
            this.colSecond,
            this.colVehType,
            this.colAlignment,
            this.colTruckLabel});
            this.dgvTruckRecords.Location = new System.Drawing.Point(0, 0);
            this.dgvTruckRecords.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTruckRecords.Name = "dgvTruckRecords";
            this.dgvTruckRecords.RowTemplate.Height = 24;
            this.dgvTruckRecords.Size = new System.Drawing.Size(1166, 622);
            this.dgvTruckRecords.TabIndex = 1;
            // 
            // colRecordID
            // 
            this.colRecordID.HeaderText = "Record ID";
            this.colRecordID.Name = "colRecordID";
            this.colRecordID.ReadOnly = true;
            this.colRecordID.Width = 85;
            // 
            // colTruckID
            // 
            this.colTruckID.HeaderText = "Truck ID";
            this.colTruckID.Name = "colTruckID";
            this.colTruckID.ReadOnly = true;
            this.colTruckID.Width = 80;
            // 
            // colSpaceNum
            // 
            this.colSpaceNum.HeaderText = "Space #";
            this.colSpaceNum.Name = "colSpaceNum";
            this.colSpaceNum.ReadOnly = true;
            this.colSpaceNum.Width = 80;
            // 
            // colInOrOut
            // 
            this.colInOrOut.HeaderText = "In/Out";
            this.colInOrOut.Name = "colInOrOut";
            this.colInOrOut.ReadOnly = true;
            this.colInOrOut.Width = 50;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 70;
            // 
            // colYear
            // 
            this.colYear.HeaderText = "Year";
            this.colYear.Name = "colYear";
            this.colYear.ReadOnly = true;
            this.colYear.Width = 50;
            // 
            // colMonth
            // 
            this.colMonth.HeaderText = "Month";
            this.colMonth.Name = "colMonth";
            this.colMonth.ReadOnly = true;
            this.colMonth.Width = 50;
            // 
            // colDay
            // 
            this.colDay.HeaderText = "Day";
            this.colDay.Name = "colDay";
            this.colDay.ReadOnly = true;
            this.colDay.Width = 50;
            // 
            // colTime
            // 
            this.colTime.HeaderText = "Time";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            this.colTime.Width = 70;
            // 
            // colHour
            // 
            this.colHour.HeaderText = "Hour";
            this.colHour.Name = "colHour";
            this.colHour.ReadOnly = true;
            this.colHour.Width = 50;
            // 
            // colMinute
            // 
            this.colMinute.HeaderText = "Minute";
            this.colMinute.Name = "colMinute";
            this.colMinute.ReadOnly = true;
            this.colMinute.Width = 50;
            // 
            // colSecond
            // 
            this.colSecond.HeaderText = "Second";
            this.colSecond.Name = "colSecond";
            this.colSecond.ReadOnly = true;
            this.colSecond.Width = 50;
            // 
            // colVehType
            // 
            this.colVehType.HeaderText = "VehType";
            this.colVehType.Name = "colVehType";
            this.colVehType.ReadOnly = true;
            this.colVehType.Width = 70;
            // 
            // colAlignment
            // 
            this.colAlignment.HeaderText = "Alighment";
            this.colAlignment.Name = "colAlignment";
            this.colAlignment.ReadOnly = true;
            this.colAlignment.Width = 150;
            // 
            // colTruckLabel
            // 
            this.colTruckLabel.HeaderText = "Truck Label";
            this.colTruckLabel.Name = "colTruckLabel";
            this.colTruckLabel.ReadOnly = true;
            this.colTruckLabel.Width = 150;
            // 
            // tabCharts
            // 
            this.tabCharts.Controls.Add(this.grpStatistics);
            this.tabCharts.Controls.Add(this.grpChartTypes);
            this.tabCharts.Controls.Add(this.btnViewOutput);
            this.tabCharts.Controls.Add(this.grpTimeSpecification);
            this.tabCharts.Controls.Add(this.btnSpecifiedChart);
            this.tabCharts.Controls.Add(this.panelChartControl);
            this.tabCharts.Location = new System.Drawing.Point(4, 22);
            this.tabCharts.Margin = new System.Windows.Forms.Padding(2);
            this.tabCharts.Name = "tabCharts";
            this.tabCharts.Padding = new System.Windows.Forms.Padding(2);
            this.tabCharts.Size = new System.Drawing.Size(1170, 626);
            this.tabCharts.TabIndex = 1;
            this.tabCharts.Text = "Charts";
            this.tabCharts.UseVisualStyleBackColor = true;
            // 
            // grpStatistics
            // 
            this.grpStatistics.Controls.Add(this.label3);
            this.grpStatistics.Controls.Add(this.label2);
            this.grpStatistics.Controls.Add(this.txtNumTrucks);
            this.grpStatistics.Controls.Add(this.lblNumTrucks);
            this.grpStatistics.Controls.Add(this.txtAverageParkingTime);
            this.grpStatistics.Controls.Add(this.txtAverageOccupancy);
            this.grpStatistics.Controls.Add(this.label1);
            this.grpStatistics.Controls.Add(this.lblAverageOccupancy);
            this.grpStatistics.Location = new System.Drawing.Point(19, 413);
            this.grpStatistics.Name = "grpStatistics";
            this.grpStatistics.Size = new System.Drawing.Size(286, 153);
            this.grpStatistics.TabIndex = 27;
            this.grpStatistics.TabStop = false;
            this.grpStatistics.Text = "Statistics";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "min";
            // 
            // txtNumTrucks
            // 
            this.txtNumTrucks.Location = new System.Drawing.Point(135, 23);
            this.txtNumTrucks.Name = "txtNumTrucks";
            this.txtNumTrucks.ReadOnly = true;
            this.txtNumTrucks.Size = new System.Drawing.Size(49, 20);
            this.txtNumTrucks.TabIndex = 25;
            // 
            // lblNumTrucks
            // 
            this.lblNumTrucks.AutoSize = true;
            this.lblNumTrucks.Location = new System.Drawing.Point(11, 26);
            this.lblNumTrucks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumTrucks.Name = "lblNumTrucks";
            this.lblNumTrucks.Size = new System.Drawing.Size(95, 13);
            this.lblNumTrucks.TabIndex = 24;
            this.lblNumTrucks.Text = "Number of Trucks:";
            // 
            // txtAverageParkingTime
            // 
            this.txtAverageParkingTime.Location = new System.Drawing.Point(134, 88);
            this.txtAverageParkingTime.Name = "txtAverageParkingTime";
            this.txtAverageParkingTime.ReadOnly = true;
            this.txtAverageParkingTime.Size = new System.Drawing.Size(50, 20);
            this.txtAverageParkingTime.TabIndex = 23;
            // 
            // txtAverageOccupancy
            // 
            this.txtAverageOccupancy.Location = new System.Drawing.Point(134, 55);
            this.txtAverageOccupancy.Name = "txtAverageOccupancy";
            this.txtAverageOccupancy.ReadOnly = true;
            this.txtAverageOccupancy.Size = new System.Drawing.Size(50, 20);
            this.txtAverageOccupancy.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Average Parking Time:";
            // 
            // lblAverageOccupancy
            // 
            this.lblAverageOccupancy.AutoSize = true;
            this.lblAverageOccupancy.Location = new System.Drawing.Point(10, 58);
            this.lblAverageOccupancy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAverageOccupancy.Name = "lblAverageOccupancy";
            this.lblAverageOccupancy.Size = new System.Drawing.Size(108, 13);
            this.lblAverageOccupancy.TabIndex = 20;
            this.lblAverageOccupancy.Text = "Average Occupancy:";
            // 
            // grpChartTypes
            // 
            this.grpChartTypes.Controls.Add(this.cboChartTypes);
            this.grpChartTypes.Location = new System.Drawing.Point(19, 31);
            this.grpChartTypes.Margin = new System.Windows.Forms.Padding(2);
            this.grpChartTypes.Name = "grpChartTypes";
            this.grpChartTypes.Padding = new System.Windows.Forms.Padding(2);
            this.grpChartTypes.Size = new System.Drawing.Size(165, 65);
            this.grpChartTypes.TabIndex = 25;
            this.grpChartTypes.TabStop = false;
            this.grpChartTypes.Text = "Chart Types";
            // 
            // cboChartTypes
            // 
            this.cboChartTypes.FormattingEnabled = true;
            this.cboChartTypes.Items.AddRange(new object[] {
            "Exact Time Chart",
            "Interval Trucks Chart",
            "Interval Ocuppancy Chart",
            "Timeline Chart"});
            this.cboChartTypes.Location = new System.Drawing.Point(11, 28);
            this.cboChartTypes.Margin = new System.Windows.Forms.Padding(2);
            this.cboChartTypes.Name = "cboChartTypes";
            this.cboChartTypes.Size = new System.Drawing.Size(126, 21);
            this.cboChartTypes.TabIndex = 13;
            this.cboChartTypes.Text = "Exact Time Chart";
            this.cboChartTypes.SelectedIndexChanged += new System.EventHandler(this.cboChartTypes_SelectedIndexChanged);
            // 
            // btnViewOutput
            // 
            this.btnViewOutput.Location = new System.Drawing.Point(26, 365);
            this.btnViewOutput.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewOutput.Name = "btnViewOutput";
            this.btnViewOutput.Size = new System.Drawing.Size(133, 30);
            this.btnViewOutput.TabIndex = 26;
            this.btnViewOutput.Text = "Time Stamp Records";
            this.btnViewOutput.UseVisualStyleBackColor = true;
            this.btnViewOutput.Click += new System.EventHandler(this.btnViewOutput_Click);
            // 
            // grpTimeSpecification
            // 
            this.grpTimeSpecification.Controls.Add(this.lblDate);
            this.grpTimeSpecification.Controls.Add(this.lblTime);
            this.grpTimeSpecification.Controls.Add(this.grpIntervalSpecification);
            this.grpTimeSpecification.Controls.Add(this.updnSecond);
            this.grpTimeSpecification.Controls.Add(this.updnHour);
            this.grpTimeSpecification.Controls.Add(this.updnMinute);
            this.grpTimeSpecification.Controls.Add(this.updnYear);
            this.grpTimeSpecification.Controls.Add(this.updnDay);
            this.grpTimeSpecification.Controls.Add(this.updnMonth);
            this.grpTimeSpecification.Location = new System.Drawing.Point(19, 122);
            this.grpTimeSpecification.Margin = new System.Windows.Forms.Padding(2);
            this.grpTimeSpecification.Name = "grpTimeSpecification";
            this.grpTimeSpecification.Padding = new System.Windows.Forms.Padding(2);
            this.grpTimeSpecification.Size = new System.Drawing.Size(286, 195);
            this.grpTimeSpecification.TabIndex = 24;
            this.grpTimeSpecification.TabStop = false;
            this.grpTimeSpecification.Text = "Time Specification";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(11, 15);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(73, 13);
            this.lblDate.TabIndex = 21;
            this.lblDate.Text = "Date (M/D/Y)";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(11, 51);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(68, 13);
            this.lblTime.TabIndex = 20;
            this.lblTime.Text = "Time (h/m/s)";
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
            this.grpIntervalSpecification.Location = new System.Drawing.Point(7, 89);
            this.grpIntervalSpecification.Margin = new System.Windows.Forms.Padding(2);
            this.grpIntervalSpecification.Name = "grpIntervalSpecification";
            this.grpIntervalSpecification.Padding = new System.Windows.Forms.Padding(2);
            this.grpIntervalSpecification.Size = new System.Drawing.Size(268, 98);
            this.grpIntervalSpecification.TabIndex = 14;
            this.grpIntervalSpecification.TabStop = false;
            this.grpIntervalSpecification.Text = "Interval Specification";
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
            20,
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
            8,
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
            20,
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
            8,
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
            10,
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
            // updnSecond
            // 
            this.updnSecond.Location = new System.Drawing.Point(119, 67);
            this.updnSecond.Margin = new System.Windows.Forms.Padding(2);
            this.updnSecond.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.updnSecond.Name = "updnSecond";
            this.updnSecond.Size = new System.Drawing.Size(33, 20);
            this.updnSecond.TabIndex = 7;
            this.updnSecond.ValueChanged += new System.EventHandler(this.updnSecond_ValueChanged);
            // 
            // updnHour
            // 
            this.updnHour.Location = new System.Drawing.Point(14, 67);
            this.updnHour.Margin = new System.Windows.Forms.Padding(2);
            this.updnHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.updnHour.Name = "updnHour";
            this.updnHour.Size = new System.Drawing.Size(33, 20);
            this.updnHour.TabIndex = 6;
            this.updnHour.ValueChanged += new System.EventHandler(this.updnHour_ValueChanged);
            // 
            // updnMinute
            // 
            this.updnMinute.Location = new System.Drawing.Point(66, 67);
            this.updnMinute.Margin = new System.Windows.Forms.Padding(2);
            this.updnMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.updnMinute.Name = "updnMinute";
            this.updnMinute.Size = new System.Drawing.Size(33, 20);
            this.updnMinute.TabIndex = 8;
            this.updnMinute.ValueChanged += new System.EventHandler(this.updnMinute_ValueChanged);
            // 
            // updnYear
            // 
            this.updnYear.Location = new System.Drawing.Point(119, 32);
            this.updnYear.Margin = new System.Windows.Forms.Padding(2);
            this.updnYear.Name = "updnYear";
            this.updnYear.Size = new System.Drawing.Size(33, 20);
            this.updnYear.TabIndex = 12;
            this.updnYear.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.updnYear.ValueChanged += new System.EventHandler(this.updnYear_ValueChanged);
            // 
            // updnDay
            // 
            this.updnDay.Location = new System.Drawing.Point(66, 32);
            this.updnDay.Margin = new System.Windows.Forms.Padding(2);
            this.updnDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.updnDay.Name = "updnDay";
            this.updnDay.Size = new System.Drawing.Size(33, 20);
            this.updnDay.TabIndex = 10;
            this.updnDay.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updnDay.ValueChanged += new System.EventHandler(this.updnDay_ValueChanged);
            // 
            // updnMonth
            // 
            this.updnMonth.Location = new System.Drawing.Point(14, 32);
            this.updnMonth.Margin = new System.Windows.Forms.Padding(2);
            this.updnMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.updnMonth.Name = "updnMonth";
            this.updnMonth.Size = new System.Drawing.Size(33, 20);
            this.updnMonth.TabIndex = 11;
            this.updnMonth.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.updnMonth.ValueChanged += new System.EventHandler(this.updnMonth_ValueChanged);
            // 
            // btnSpecifiedChart
            // 
            this.btnSpecifiedChart.Location = new System.Drawing.Point(26, 332);
            this.btnSpecifiedChart.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpecifiedChart.Name = "btnSpecifiedChart";
            this.btnSpecifiedChart.Size = new System.Drawing.Size(133, 28);
            this.btnSpecifiedChart.TabIndex = 23;
            this.btnSpecifiedChart.Text = "Display Chart";
            this.btnSpecifiedChart.UseVisualStyleBackColor = true;
            this.btnSpecifiedChart.Click += new System.EventHandler(this.btnSpecifiedChart_Click);
            // 
            // panelChartControl
            // 
            this.panelChartControl.Location = new System.Drawing.Point(310, 24);
            this.panelChartControl.Name = "panelChartControl";
            this.panelChartControl.Size = new System.Drawing.Size(751, 542);
            this.panelChartControl.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(948, 512);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(142, 74);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // frmParkingRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 663);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.tabDataViewer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmParkingRecords";
            this.Text = "Parking Records";
            this.tabDataViewer.ResumeLayout(false);
            this.tabRecordList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTruckRecords)).EndInit();
            this.tabCharts.ResumeLayout(false);
            this.grpStatistics.ResumeLayout(false);
            this.grpStatistics.PerformLayout();
            this.grpChartTypes.ResumeLayout(false);
            this.grpTimeSpecification.ResumeLayout(false);
            this.grpTimeSpecification.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.updnSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDataViewer;
        private System.Windows.Forms.TabPage tabRecordList;
        private System.Windows.Forms.TabPage tabCharts;
        private System.Windows.Forms.GroupBox grpChartTypes;
        private System.Windows.Forms.ComboBox cboChartTypes;
        private System.Windows.Forms.Button btnViewOutput;
        private System.Windows.Forms.GroupBox grpTimeSpecification;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.GroupBox grpIntervalSpecification;
        private System.Windows.Forms.Label lblIntervalEnd;
        private System.Windows.Forms.Label lblIntervalStart;
        private System.Windows.Forms.NumericUpDown updnEndSecond;
        private System.Windows.Forms.NumericUpDown updnStartMinute;
        private System.Windows.Forms.NumericUpDown updnStartSecond;
        private System.Windows.Forms.NumericUpDown updnEndHour;
        private System.Windows.Forms.NumericUpDown updnStartHour;
        private System.Windows.Forms.NumericUpDown updnEndMinute;
        private System.Windows.Forms.NumericUpDown updnSecond;
        private System.Windows.Forms.NumericUpDown updnHour;
        private System.Windows.Forms.NumericUpDown updnMinute;
        private System.Windows.Forms.NumericUpDown updnYear;
        private System.Windows.Forms.NumericUpDown updnDay;
        private System.Windows.Forms.NumericUpDown updnMonth;
        private System.Windows.Forms.Button btnSpecifiedChart;
        private System.Windows.Forms.Panel panelChartControl;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dgvTruckRecords;
        private System.Windows.Forms.NumericUpDown updnEndDay;
        private System.Windows.Forms.NumericUpDown updnEndMonth;
        private System.Windows.Forms.NumericUpDown updnStartDay;
        private System.Windows.Forms.NumericUpDown updnStartMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTruckID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpaceNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInOrOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinute;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSecond;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlignment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTruckLabel;
        private System.Windows.Forms.GroupBox grpStatistics;
        private System.Windows.Forms.TextBox txtAverageParkingTime;
        private System.Windows.Forms.TextBox txtAverageOccupancy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAverageOccupancy;
        private System.Windows.Forms.TextBox txtNumTrucks;
        private System.Windows.Forms.Label lblNumTrucks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}