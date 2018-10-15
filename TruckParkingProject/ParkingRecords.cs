using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace TruckParkingDataAnalysis
{
    public partial class frmParkingRecords : Form
    {
        public enum ChartTypes
        {
            ExactTimeChart = 1,
            IntervalTrucksChart = 2,
            IntervalOccupancyChart = 3,
            TimelineChart = 4
        }
        ChartTypes TypeOfChart = ChartTypes.ExactTimeChart;
        SwashStatistics_ChartingControl.ctrlDistributionDisplay ctrlDistributionDisplay1 = new SwashStatistics_ChartingControl.ctrlDistributionDisplay();
        List<TruckParkingRecord> TruckRecords = new List<TruckParkingRecord>();
        List<SensysRecord> SensysRecords = new List<SensysRecord>();
        List<double> xValueList = new List<double>();
        List<double> yValueList = new List<double>();
        List<double> xTimeLines;
        List<double> yTimeLines;
        List<List<double>> xTimeLineLists = new List<List<double>>();
        List<List<double>> yTimeLineLists = new List<List<double>>();
        int Year = 2016;
        byte Month = 8;
        byte Day = 20;
        byte Hour = 0;
        byte Minute = 0;
        byte Second = 0;
        byte SpaceNum = 0; 
        int TimeStamp = 0;
        int IntervalStartTimeStamp = 0;
        int IntervalEndTimeStamp = 0;
        byte IntervalStartMonth = 0;
        byte IntervalStartDay = 0;
        byte IntervalStartHour = 0;
        byte IntervalStartMinute = 0;
        byte IntervalStartSecond = 0;
        byte IntervalEndMonth = 0;
        byte IntervalEndDay = 0;
        byte IntervalEndHour = 0;
        byte IntervalEndMinute = 0;
        byte IntervalEndSecond = 0;
        byte SpaceStartNum = 0;
        byte SpaceEndNum = 0;
        int yInterval = 1;
        int yMax = 1;
        int yMin = 0;
        int xInterval = 1;
        int xMax = 1;
        int xMin = 0;
        List<List<double>> InTimeListsAllSpots = new List<List<double>>();
        List<List<double>> OutTimeListsAllSpots = new List<List<double>>();
        List<double> InTimes;
        List<double> OutTimes;
        List<int[,]> timeStampRecordsBySpace; //First MonthTimeStamp, Second 1:parking, 0: no parking
        List<List<int[,]>> timeStampRecords = new List<List<int[,]>>();
        string xAxisLabel = "";
        string yAxisLabel = "";
        string seriesName = "";
        double AverageOccupancy = new double();
        double AverageParkingTime = new double();
        int NumOfTrucks = new int();
        int StartTimeStamp = 0;
        int EndTimeStamp = 0;
        int MaxTruck=0;
        DataType DataInputType = DataType.Video;
        public frmParkingRecords(List<TruckParkingRecord> recordsImport, List<SensysRecord> sensysRecordsImport, byte StartMonthImport, byte StartDayImport, byte StartHourImport, byte StartMinuteImport, byte StartSecondImport, byte EndMonthImport, byte EndDayImport, byte EndHourImport, byte EndMinuteImport, byte EndSecondImport,byte StartNumImport, byte EndNumImport, DataType dataInputTypeImport)
        {
            InitializeComponent();
            DataInputType = dataInputTypeImport;
            TruckRecords = recordsImport;
            SensysRecords = sensysRecordsImport;
            if(DataInputType == DataType.Video)
            {
                LoadTruckRecords();
            }
             
            IntervalStartMonth = StartMonthImport;
            IntervalStartDay = StartDayImport;
            IntervalStartHour = StartHourImport;
            IntervalStartMinute = StartMinuteImport;
            IntervalStartSecond = StartSecondImport;
            IntervalEndMonth = EndMonthImport;
            IntervalEndDay = EndDayImport;
            IntervalEndHour = EndHourImport;
            IntervalEndMinute = EndMinuteImport;
            IntervalEndSecond = EndSecondImport;
            
            SpaceStartNum = StartNumImport;
            SpaceEndNum = EndNumImport;
            SpaceNum = (byte)(SpaceEndNum - SpaceStartNum + 1);
            StartTimeStamp = IntervalStartMonth * 2678400 + IntervalStartDay * 86400 + IntervalStartHour * 3600+ IntervalStartMinute*60+IntervalStartSecond; //Minute //Changed to second 30Aug
            EndTimeStamp = IntervalEndMonth * 2678400 + IntervalEndDay * 86400 + IntervalEndHour * 3600+IntervalEndMinute *60+ IntervalEndSecond; //Minute //Changed to second 30Aug
            if (DataInputType == DataType.Video)
            {
                GetInOutTimeLists();
                GetTimeStampRecordsVideo();
                GetBasicStatistics();
            }
            GetTimeStampRecordsSensys();
           
        }
        private void GetTimeStampRecordsSensys()
        {
            
        }
        private void GetInOutTimeListsSensys()
        {
            
        }
        private void GetInOutTimeLists()
        {
            InTimeListsAllSpots.Clear();
            OutTimeListsAllSpots.Clear();

            for (int Space = SpaceStartNum; Space <= SpaceEndNum; Space++)
            {
                InTimes = new List<double>();
                OutTimes = new List<double>();
                for (int RecordNum = 0; RecordNum < TruckRecords.Count; RecordNum++)
                {
                    if (TruckRecords[RecordNum].SpaceNumber == Space)
                    {
                        if (TruckRecords[RecordNum].IsComingIn == true)
                        {
                            InTimes.Add(CalculateMonthTimeStamp(TruckRecords[RecordNum].Month,TruckRecords[RecordNum].Day,TruckRecords[RecordNum].Hour, TruckRecords[RecordNum].Minute, TruckRecords[RecordNum].Second));
                        }
                        else if (TruckRecords[RecordNum].IsComingIn == false)
                        {
                            OutTimes.Add(CalculateMonthTimeStamp(TruckRecords[RecordNum].Month, TruckRecords[RecordNum].Day,TruckRecords[RecordNum].Hour, TruckRecords[RecordNum].Minute, TruckRecords[RecordNum].Second));
                        }
                    }
                }
                InTimeListsAllSpots.Add(InTimes);
                OutTimeListsAllSpots.Add(OutTimes);
            }
        }
        private void GetTimeStampRecordsVideo()
        {

            timeStampRecords.Clear();
            int[,] stampRecord;
            for (int space = 0; space < SpaceNum;space++)
            {
                timeStampRecordsBySpace = new List<int[,]>();
                for(int timeStamp =StartTimeStamp; timeStamp <= EndTimeStamp; timeStamp ++) //Every one minute //Change to second 30Aug
                {
                    stampRecord = new int[1, 2];
                    stampRecord[0, 0] = timeStamp;
                    for (int NumInOut=0; NumInOut < OutTimeListsAllSpots[space].Count;NumInOut++)
                    {
                        
                        if (timeStamp >= InTimeListsAllSpots[space][NumInOut] && timeStamp <= OutTimeListsAllSpots[space][NumInOut])
                        {
                            stampRecord[0, 1] = 1; //In
                            break;
                        }
                        else
                        {
                            stampRecord[0, 1] = 0; //Out
                        }
                        
                    }
                    timeStampRecordsBySpace.Add(stampRecord);

                }
                timeStampRecords.Add(timeStampRecordsBySpace);
            }
        }
        private void ChartSetting()
        {
            if (TypeOfChart == ChartTypes.ExactTimeChart)
            {
                GetInputExactTimeChart();
                yInterval = 1;
                yMax = 1;
                yMin = 0;
                xMin = SpaceStartNum -1;
                xInterval = 1;
                xMax = SpaceEndNum + 1; 
                seriesName = "Truck Parking Display";
                yAxisLabel = "Occupied";
                xAxisLabel = "Parking Space Number";

            }
            else if (TypeOfChart == ChartTypes.IntervalTrucksChart)
            {
                GetInputIntervalChart();
                yInterval = (int)MaxTruck/5;
                yMax = MaxTruck;
                yMin = 0;
                xMin = SpaceStartNum - 1;
                xInterval = 1;
                xMax = SpaceEndNum + 1;
                seriesName = "Truck Parking Display";
                yAxisLabel = "Number of Trucks Parked";
                xAxisLabel = "Parking Space Number";
            }
            else if (TypeOfChart == ChartTypes.IntervalOccupancyChart)
            {
                GetInputOccupancyChart();
                yInterval = 10;
                yMax = 100;
                yMin = 0;
                xMin = SpaceStartNum - 1;
                xInterval = 1;
                xMax = SpaceEndNum + 1;
                seriesName = "Truck Parking Display";
                yAxisLabel = "Percent of Time Occupied";
                xAxisLabel = "Parking Space Number";
            }
            else if (TypeOfChart == ChartTypes.TimelineChart)
            {
                GetInputTimelineChart();
                yInterval = 1;
                yMax = SpaceEndNum + 1;
                yMin = SpaceStartNum - 1;
                xMin = 0;
                xInterval = 4;
                xMax = 24+1; 
                seriesName = "Truck Parking Display";
                yAxisLabel = "Parking Space Number";
                xAxisLabel = "Timeline (h)";
            }
        }
        private void CreateChart()
        {
            ChartSetting();
            SwashStatistics_ChartingControl.ChartSettings newChartSettings = new SwashStatistics_ChartingControl.ChartSettings(xInterval, xInterval, xMin, xMax, yInterval, yInterval, yMin, yMax, xAxisLabel, yAxisLabel, true, false);
            Series newSeries = new Series(seriesName);
            if(TypeOfChart != ChartTypes.TimelineChart)
            {
                newSeries.ChartType = SeriesChartType.Column;
            }
            else
            {
                newSeries.ChartType = SeriesChartType.FastPoint;
            }

            newSeries.XAxisType = AxisType.Primary;
            newSeries.YAxisType = AxisType.Primary;
            //newSeries.IsVisibleInLegend = true;
            newSeries.BorderWidth = 3;
            newSeries.Color = Color.Blue;
            newSeries.IsValueShownAsLabel = true;
            newChartSettings.SetDataSeries(newSeries, xValueList, yValueList);
            newChartSettings.DataSeries.Add(newSeries);
            ctrlDistributionDisplay1.CreateChart(newChartSettings);
        }
        private void GetInputExactTimeChart()
        {
            xValueList.Clear();
            yValueList.Clear();
            TimeStamp = CalculateMonthTimeStamp(Month, Day, Hour, Minute, Second);
            int NumTimeStamps = timeStampRecords[0].Count();
            for (int Space = 0;Space < SpaceNum; Space++)
            {
                for(int timeStamp=0; timeStamp < NumTimeStamps;timeStamp++)
                {
                    if(timeStampRecords[Space][timeStamp][0,0] == TimeStamp)
                    {
                        xValueList.Add(Space + SpaceStartNum);
                        yValueList.Add(timeStampRecords[Space][timeStamp][0, 1]);
                    }
                }
            }
        }
        private void GetInputIntervalChart()
        {
            xValueList.Clear();
            yValueList.Clear();
            IntervalStartTimeStamp = CalculateMonthTimeStamp(IntervalStartMonth, IntervalStartDay,IntervalStartHour, IntervalStartMinute, IntervalStartSecond);
            IntervalEndTimeStamp = CalculateMonthTimeStamp(IntervalEndMonth,IntervalEndDay,IntervalEndHour, IntervalEndMinute, IntervalEndSecond);
            
            for (int Space = 0; Space < SpaceNum; Space++)
            {
                int yValue = 0;
                for (int numIn =0; numIn <InTimeListsAllSpots[Space].Count; numIn++)
                {
                    if(InTimeListsAllSpots[Space][numIn]>=IntervalStartTimeStamp&& InTimeListsAllSpots[Space][numIn] <= IntervalEndTimeStamp)
                    {
                        yValue++;
                    }
                }
                xValueList.Add(Space+SpaceStartNum);
                yValueList.Add(yValue);           
            }
            for(int n=0;n<yValueList.Count; n++)
            {
                if (yValueList[n] > MaxTruck)
                {
                    MaxTruck = (int)yValueList[n];
                }
            }
        }

 
        private void GetInputTimelineChart()
        {
            xValueList.Clear();
            yValueList.Clear();
            IntervalStartTimeStamp = CalculateMonthTimeStamp(Month, Day, 0, 0, 0);
            IntervalEndTimeStamp = CalculateMonthTimeStamp(Month, Day, 24, 0, 0);
            int TimeStampsNum = timeStampRecords[0].Count();
            for (int Space = 0; Space < SpaceNum; Space++)
            {
                for (int timeStamp = 0; timeStamp < TimeStampsNum; timeStamp++)
                {
                    if (timeStampRecords[Space][timeStamp][0, 0] >= IntervalStartTimeStamp && timeStampRecords[Space][timeStamp][0, 0] <= IntervalEndTimeStamp)
                    {
                        
                        if(timeStampRecords[Space][timeStamp][0, 1] == 1)
                        {
                            double TimeLineValue = Math.Round((timeStampRecords[Space][timeStamp][0, 0] - Month * 2678400.00 - Day * 86400.00) / 86400.00 * 24.00, 2); //Month = May !! Default
                            xValueList.Add(TimeLineValue);
                            yValueList.Add(Space + SpaceStartNum);
                        }                   
                    }
                }
            }
        }
        private void GetInputOccupancyChart()
        {
            xValueList.Clear();
            yValueList.Clear();
            IntervalStartTimeStamp = CalculateMonthTimeStamp(IntervalStartMonth, IntervalStartDay, IntervalStartHour, IntervalStartMinute, IntervalStartSecond);
            IntervalEndTimeStamp = CalculateMonthTimeStamp(IntervalEndMonth, IntervalEndDay, IntervalEndHour, IntervalEndMinute, IntervalEndSecond);
            double IntervalDiff = IntervalEndTimeStamp - IntervalStartTimeStamp;
            int TimeStampsNum = timeStampRecords[0].Count();
            for (int Space = 0; Space < SpaceNum; Space++)
            {
                double occupancyNum = 0; 
                for (int timeStamp =0;timeStamp<TimeStampsNum;timeStamp++)
                {
                    if(timeStampRecords[Space][timeStamp][0, 0]>= IntervalStartTimeStamp&& timeStampRecords[Space][timeStamp][0, 0]<= IntervalEndTimeStamp)
                    {
                        occupancyNum +=timeStampRecords[Space][timeStamp][0, 1];
                    }            
                }
                double occupancyValue = Math.Round((occupancyNum/IntervalDiff)*100,2); //Occupancy (percent)
                xValueList.Add(Space + SpaceStartNum);
                yValueList.Add(occupancyValue);
            }
        }
        private int CalculateMonthTimeStamp(byte month, byte day, byte hour, byte minute, byte second)
        {
            int timeStamp = Convert.ToInt32(month* 2678400+ day* 86400+hour * 3600 + minute * 60 + second);
            return timeStamp;
        }
        private int CalculateHourTimeStamp(byte hour, byte minute, byte second)
        {
            int timeStamp = Convert.ToInt32(hour * 3600 + minute * 60 + second);
            return timeStamp;
        }
        private void btnSpecifiedChart_Click(object sender, EventArgs e)
        {
            CreateChart();
        }

        private void updnHour_ValueChanged(object sender, EventArgs e)
        {
            Hour = Convert.ToByte(updnHour.Value);
        }

        private void updnMinute_ValueChanged(object sender, EventArgs e)
        {
            Minute = Convert.ToByte(updnMinute.Value);
        }

        private void updnSecond_ValueChanged(object sender, EventArgs e)
        {
            Second = Convert.ToByte(updnSecond.Value);
        }

        private void updnYear_ValueChanged(object sender, EventArgs e)
        {
            Year = Convert.ToByte(updnYear.Value);
        }

        private void updnMonth_ValueChanged(object sender, EventArgs e)
        {
            Month = Convert.ToByte(updnMonth.Value);
        }

        private void updnDay_ValueChanged(object sender, EventArgs e)
        {
            Day = Convert.ToByte(updnDay.Value);
        }

        private void cboChartTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChartTypes.SelectedIndex == 0)
            {
                TypeOfChart = ChartTypes.ExactTimeChart;
            }
            else if (cboChartTypes.SelectedIndex == 1)
            {
                TypeOfChart = ChartTypes.IntervalTrucksChart;
            }
            else if (cboChartTypes.SelectedIndex == 2)
            {
                TypeOfChart = ChartTypes.IntervalOccupancyChart;
            }
            else if (cboChartTypes.SelectedIndex == 3)
            {
                TypeOfChart = ChartTypes.TimelineChart;
            }
            SetControlStatus();
        }
        private void SetControlStatus()
        {
            if (TypeOfChart == ChartTypes.ExactTimeChart)
            {
                updnHour.Enabled = true;
                updnMinute.Enabled = true;
                updnSecond.Enabled = true;
                grpIntervalSpecification.Enabled = false;

            }
            else if (TypeOfChart == ChartTypes.IntervalTrucksChart)
            {
                updnHour.Enabled = false;
                updnMinute.Enabled = false;
                updnSecond.Enabled = false;
                grpIntervalSpecification.Enabled = true;
            }
            else if (TypeOfChart == ChartTypes.IntervalOccupancyChart)
            {
                updnHour.Enabled = false;
                updnMinute.Enabled = false;
                updnSecond.Enabled = false;
                grpIntervalSpecification.Enabled = true;
            }
            else if (TypeOfChart == ChartTypes.TimelineChart)
            {
                updnHour.Enabled = false;
                updnMinute.Enabled = false;
                updnSecond.Enabled = false;
                grpIntervalSpecification.Enabled = false;
            }
        }

        private void updnStartHour_ValueChanged(object sender, EventArgs e)
        {
            IntervalStartHour = Convert.ToByte(updnStartHour.Value);
        }

        private void updnStartMinute_ValueChanged(object sender, EventArgs e)
        {
            IntervalStartMinute = Convert.ToByte(updnStartMinute.Value);
        }

        private void updnStartSecond_ValueChanged(object sender, EventArgs e)
        {
            IntervalStartSecond = Convert.ToByte(updnStartSecond.Value);
        }

        private void updnEndHour_ValueChanged(object sender, EventArgs e)
        {
            IntervalEndHour = Convert.ToByte(updnEndHour.Value);
        }

        private void updnEndMinute_ValueChanged(object sender, EventArgs e)
        {
            IntervalEndMinute = Convert.ToByte(updnEndMinute.Value);
        }

        private void updnEndSecond_ValueChanged(object sender, EventArgs e)
        {
            IntervalEndSecond = Convert.ToByte(updnEndSecond.Value);
        }

        private void tabDataViewer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabDataViewer.SelectedTab == tabRecordList)
            {
                LoadTruckRecords();
            }
            else if (tabDataViewer.SelectedTab == tabCharts)
            {
                if(DataInputType == DataType.Video)
                {
                    panelChartControl.Controls.Add(ctrlDistributionDisplay1);
                    SetControlStatus();
                    CreateChart();
                }
                
            }
        }
        private void LoadTruckRecords()
        {
            dgvTruckRecords.Rows.Clear();

            int TotalVehs = TruckRecords.Count;
            int RowCounter = 0;
            string InOrOut = "";
            string VehType = "";
            dgvTruckRecords.Rows.Add(TotalVehs);

            foreach (TruckParkingRecord record in TruckRecords)
            {
                dgvTruckRecords.Rows[RowCounter].Cells[colRecordID.Name].Value = (RowCounter + 1).ToString();
                dgvTruckRecords.Rows[RowCounter].Cells[colTruckID.Name].Value = record.TruckID.ToString();
                dgvTruckRecords.Rows[RowCounter].Cells[colSpaceNum.Name].Value = record.SpaceNumber.ToString();
                if (record.IsComingIn == true)
                {
                    InOrOut = "In";
                }
                else
                {
                    InOrOut = "Out";
                }
                dgvTruckRecords.Rows[RowCounter].Cells[colInOrOut.Name].Value = InOrOut;
                dgvTruckRecords.Rows[RowCounter].Cells[colDate.Name].Value = record.Date.ToString();
                dgvTruckRecords.Rows[RowCounter].Cells[colYear.Name].Value = record.Year.ToString();
                dgvTruckRecords.Rows[RowCounter].Cells[colMonth.Name].Value = record.Month.ToString();
                dgvTruckRecords.Rows[RowCounter].Cells[colDay.Name].Value = record.Day.ToString();
                dgvTruckRecords.Rows[RowCounter].Cells[colTime.Name].Value = record.Time.ToString();
                dgvTruckRecords.Rows[RowCounter].Cells[colHour.Name].Value = record.Hour.ToString();
                dgvTruckRecords.Rows[RowCounter].Cells[colMinute.Name].Value = record.Minute.ToString();
                dgvTruckRecords.Rows[RowCounter].Cells[colSecond.Name].Value = record.Second.ToString();
                if (record.Class == 4)
                {
                    VehType = "Truck with closed trailer";
                }
                else if (record.Class == 3)
                {
                    VehType = "Truck with flat bed trailer";
                }
                else if (record.Class == 2)
                {
                    VehType = "Truck with vehicle trailer";
                }
                else if (record.Class == 1)
                {
                    VehType = "Truck with no trailer";
                }
                else
                {
                    VehType = "Other";
                }
                dgvTruckRecords.Rows[RowCounter].Cells[colVehType.Name].Value = VehType;
                dgvTruckRecords.Rows[RowCounter].Cells[colAlignment.Name].Value = record.Alignment;
                dgvTruckRecords.Rows[RowCounter].Cells[colTruckLabel.Name].Value = record.TruckLabel;
                RowCounter++;
            }


        }
        private void GetBasicStatistics()
        {
            getNumOfTrucks();
            txtNumTrucks.Text = NumOfTrucks.ToString();
            getAverageOccupancy();
            txtAverageOccupancy.Text = (AverageOccupancy*100).ToString();
            getAverageParkingTime();
            txtAverageParkingTime.Text = AverageParkingTime.ToString();

        }
        private void getNumOfTrucks()
        {
            int NumRecords = TruckRecords.Count();
            for (int RecordNum = 0; RecordNum < NumRecords; RecordNum++)
            {
                if (TruckRecords[RecordNum].TruckID >= NumOfTrucks )
                {
                    NumOfTrucks = TruckRecords[RecordNum].TruckID;
                }
            }
        }
        private void getAverageOccupancy()
        {
            int SumTimeStamp = 0;
            for (int n = 0; n < SpaceNum; n++)
            {
                int NumTimeStamp = timeStampRecords[n].Count();
                for (int m = 0; m < NumTimeStamp; m++)
                {
                    if (timeStampRecords[n][m][0, 1] == 1)
                    {
                        SumTimeStamp += 1;
                    }
                }
            }
            AverageOccupancy = Math.Round((double)SumTimeStamp / (double)(EndTimeStamp - StartTimeStamp), 4);
        }
        private void getAverageParkingTime()
        {
            int NumRecords = TruckRecords.Count();
            double SumParkingTimeTOT = 0;
            for (int n =0; n<NumOfTrucks; n++)
            {
                int inTimeStamp = 0;
                int outTimeStamp = 0;

                for (int RecordNum = 0; RecordNum < NumRecords; RecordNum++)
                {
                    if (TruckRecords[RecordNum].TruckID == n+1)
                    {
                        if (TruckRecords[RecordNum].IsComingIn == true)
                        {
                            inTimeStamp = TruckRecords[RecordNum].MonthTimeStamp; 
                        }
                        else if (TruckRecords[RecordNum].IsComingIn == false)
                        {
                            outTimeStamp = TruckRecords[RecordNum].MonthTimeStamp;
                        }

                    }
                }
                SumParkingTimeTOT += (outTimeStamp - inTimeStamp)/86400.00 *24.00*60.00;
            }
            AverageParkingTime = Math.Round (SumParkingTimeTOT / (double)NumOfTrucks,2);
            
        }

        private void btnViewOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.InitialDirectory = System.Windows.Forms.Application.StartupPath;

            saveFileDialog.Filter = "Results Files (*.csv)|*.csv|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                FileIO.WriteOutputs(saveFileDialog.FileName, timeStampRecords);                         
            }
        }

        private void updnStartMonth_ValueChanged(object sender, EventArgs e)
        {
            IntervalStartMonth = Convert.ToByte(updnStartMonth.Value);
        }

        private void updnStartDay_ValueChanged(object sender, EventArgs e)
        {
            IntervalStartDay = Convert.ToByte(updnStartDay.Value);
        }

        private void updnEndMonth_ValueChanged(object sender, EventArgs e)
        {
            IntervalEndMonth = Convert.ToByte(updnEndMonth.Value);
        }

        private void updnEndDay_ValueChanged(object sender, EventArgs e)
        {
            IntervalEndDay = Convert.ToByte(updnEndDay.Value);
        }

        //private void panelChartControl_MouseMove(object sender, MouseEventArgs e)
        //{
        //    ToolTip tooltip = new ToolTip();
        //    Point? clickPosition = null;
        //    if (clickPosition.HasValue && e.Location != clickPosition)
        //    {
        //        tooltip.RemoveAll();
        //        clickPosition = null;
        //    }
        //}
    }
}
