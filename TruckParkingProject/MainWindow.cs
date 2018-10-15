using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TruckParkingDataAnalysis
{
    public partial class MainWindow : Form
    {
        byte IntervalStartMonth = 1;
        byte IntervalStartDay = 10;
        byte IntervalStartHour = 21;
        byte IntervalStartMinute = 0;
        byte IntervalStartSecond = 0;
        byte IntervalEndMonth = 1;
        byte IntervalEndDay = 11;
        byte IntervalEndHour = 9;
        byte IntervalEndMinute = 0;
        byte IntervalEndSecond = 0;
        byte SpaceStartNum = 1;
        byte SpaceEndNum = 10;
        DataType DataInputType = DataType.Video;
        double EventAccuracy = 0;
        double OccupancyAccuracy = 0;
        int OffsetValue = 120;
        int OffsetValueBlueBand = 30;
        int TimeDifference = 14400; //4h
        int Range = 90;
        int NumEvents = 0;
        int Duration = 0;
        private static string SourceDir = "";
        private static List<TruckParkingRecord> TruckRecords = new List<TruckParkingRecord>();
        private static List<SensysRecord> SensysRecords = new List<SensysRecord>();
        private static List<CivicSmartRecord> CivicSmartRecords = new List<CivicSmartRecord>();
        //private static List<CivicSmartRecordOld> CivicSmartRecordsOld = new List<CivicSmartRecordOld>();
        private static List<IPsensRecord> IPsensRecords = new List<IPsensRecord>();
        private static List<BlueBandRecord> BlueBandRecords = new List<BlueBandRecord>();
        private static List<BlueBandReportRecord> BlueBandReportRecords = new List<BlueBandReportRecord>();
        int StartTimeStamp = 0;
        int EndTimeStamp = 0;

        List<List<double>> InTimeListsAllSpots = new List<List<double>>();
        List<List<double>> OutTimeListsAllSpots = new List<List<double>>();
        List<double> InTimes;
        List<double> OutTimes;
        List<int[,]> timeStampRecordsBySpace; //First MonthTimeStamp, Second 1:parking, 0: no parking
        List<List<int[,]>> timeStampRecords = new List<List<int[,]>>();

        List<int[,]> SensysEventTimeList;
        List<List<int[,]>> SensysEventTimeLists = new List<List<int[,]>>();
        List<int[,]> SensysOccupancyList;
        List<List<int[,]>> SensysOccupancyLists = new List<List<int[,]>>(); 
        List<int[,]> SensysInOutPairList;
        List<List<int[,]>> SensysInOutPairLists = new List<List<int[,]>>();// [,]: first enter time, second exist time
        List<int[,]> SensysTimeStampList;
        List<List<int[,]>> SensysTimeStampLists = new List<List<int[,]>>();
        List<CivicSmartRecord> CivicSmartSensorList;
        List<BlueBandRecord> BlueBandSensorList;
        List<List<CivicSmartRecord>> CivicSmartSensorLists = new List<List<CivicSmartRecord>>();
        List<List<BlueBandRecord>> BlueBandSensorLists = new List<List<BlueBandRecord>>();
        List<int[,]> CivicSmartEventTimeList;
        List<int[,]> BlueBandEventTimeList;
        List<List<int[,]>> CivicSmartEventTimeLists = new List<List<int[,]>>();
        List<List<int[,]>> BlueBandEventTimeLists = new List<List<int[,]>>();
        List<int[,]> CivicSmartInOutPairList;
        List<int[,]> BlueBandInOutPairList;
        List<List<int[,]>> CivicSmartInOutPairLists = new List<List<int[,]>>();// [,]: first enter time, second exist time
        List<List<int[,]>> BlueBandInOutPairLists = new List<List<int[,]>>();// [,]: first enter time, second exist time
        List<int[,]> CivicSmartTimeStampList;
        List<int[,]> BlueBandTimeStampList;
        List<List<int[,]>> CivicSmartTimeStampLists = new List<List<int[,]>>();
        List<List<int[,]>> BlueBandTimeStampLists = new List<List<int[,]>>();
        List<int[,]> CivicSmartSpaceStatusList;
        List<int[,]> BlueBandSpaceStatusList;
        List<List<int[,]>> CivicSmartSpaceStatusLists = new List<List<int[,]>>();
        List<List<int[,]>> BlueBandSpaceStatusLists = new List<List<int[,]>>();
        List<int[,]> IPsensOccupancyTimeList;
        List<List<int[,]>> IPsensOccupancyTimeLists = new List<List<int[,]>>();
        List<int[,]> BlueBandOccupancyTimeList;
        List<List<int[,]>> BlueBandOccupancyTimeLists = new List<List<int[,]>>();
        List<int[,]> SensysSpaceStatusList;
        List<List<int[,]>> SensysSpaceStatusLists = new List<List<int[,]>>();


        public MainWindow()
        {
            InitializeComponent();
            GetStudiedInterval();
            CalculateIntervalTimeStamp();
        }
        private void CalculateIntervalTimeStamp()
        {                      
            StartTimeStamp = IntervalStartMonth * 2678400 + IntervalStartDay * 86400 + IntervalStartHour * 3600 + IntervalStartMinute * 60 + IntervalStartSecond; 
            EndTimeStamp = IntervalEndMonth * 2678400 + IntervalEndDay * 86400 + IntervalEndHour * 3600 + IntervalEndMinute * 60 + IntervalEndSecond; 
        }

        private void btnSelectDataFolder_Click(object sender, EventArgs e)
        {

        }

       


        private void btnParkingLot_Click(object sender, EventArgs e)
        {
            //frmParkingLot ParkingLotForm = new frmParkingLot(FileIO_Output.RecordList);
            //ParkingLotForm.Show();
            GetStudiedInterval();
            frmParkingRecords OverallCharts = new frmParkingRecords(TruckRecords, SensysRecords, IntervalStartMonth, IntervalStartDay, IntervalStartHour, IntervalStartMinute, IntervalStartSecond, IntervalEndMonth, IntervalEndDay, IntervalEndHour, IntervalEndMinute, IntervalEndSecond, SpaceStartNum, SpaceEndNum, DataInputType);
            OverallCharts.Show();
            
        }

        private void updnStartMonth_ValueChanged(object sender, EventArgs e)
        {
            IntervalStartMonth = Convert.ToByte(updnStartMonth.Value);
            CalculateIntervalTimeStamp();
        }

        private void updnStartDay_ValueChanged(object sender, EventArgs e)
        {
            IntervalStartDay = Convert.ToByte(updnStartDay.Value);
            CalculateIntervalTimeStamp();
        }

        private void updnStartHour_ValueChanged(object sender, EventArgs e)
        {
            IntervalStartHour = Convert.ToByte(updnStartHour.Value);
            CalculateIntervalTimeStamp();
        }

        private void updnStartMinute_ValueChanged(object sender, EventArgs e)
        {
            IntervalStartMinute = Convert.ToByte(updnStartMinute.Value);
            CalculateIntervalTimeStamp();
        }

        private void updnStartSecond_ValueChanged(object sender, EventArgs e)
        {
            IntervalStartSecond = Convert.ToByte(updnStartSecond.Value);
            CalculateIntervalTimeStamp();
        }

        private void updnEndMonth_ValueChanged(object sender, EventArgs e)
        {
            IntervalEndMonth = Convert.ToByte(updnEndMonth.Value);
            CalculateIntervalTimeStamp();
        }

        private void updnEndDay_ValueChanged(object sender, EventArgs e)
        {
            IntervalEndDay = Convert.ToByte(updnEndDay.Value);
            CalculateIntervalTimeStamp();
        }

        private void updnEndHour_ValueChanged(object sender, EventArgs e)
        {
            IntervalEndHour = Convert.ToByte(updnEndHour.Value);
            CalculateIntervalTimeStamp();
        }

        private void updnEndMinute_ValueChanged(object sender, EventArgs e)
        {
            IntervalEndMinute = Convert.ToByte(updnEndMinute.Value);
            CalculateIntervalTimeStamp();
        }

        private void updnEndSecond_ValueChanged(object sender, EventArgs e)
        {
            IntervalEndSecond = Convert.ToByte(updnEndSecond.Value);
            CalculateIntervalTimeStamp();
        }

        private void updnSpaceStartNum_ValueChanged(object sender, EventArgs e)
        {
            SpaceStartNum = Convert.ToByte(updnSpaceStartNum.Value);
        }

        private void updnSpaceEndNum_ValueChanged(object sender, EventArgs e)
        {
            SpaceEndNum = Convert.ToByte(updnSpaceEndNum.Value);
        }
        private void btnReadVideoFiles_Click(object sender, EventArgs e)
        {
            //this.TruckDataFolderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
            //TruckDataFolderBrowser.ShowDialog();
            //SourceDir = TruckDataFolderBrowser.SelectedPath;
            try
            {
                //this.TruckDataOpenFile.InitialDirectory = @"D:\";
                this.TruckDataOpenFile.InitialDirectory = @"C: \Users\w.sun2014\OneDrive - University of Florida\OD\Projects\TruckParking\Truck\Accuracy Tests";
                TruckDataOpenFile.ShowDialog();
                SourceDir = TruckDataOpenFile.FileName;

                lblDataFolder.Text = SourceDir;
                TruckRecords = FileIO.ReadTruckParkingDataFile(SourceDir);
                DataInputType = DataType.Video;
            }
            catch (Exception)
            {
                MessageBox.Show("Please load a correct csv. file.", "Input Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnReadIPsensFiles_Click(object sender, EventArgs e)
        {
            try
            {
                //this.TruckDataOpenFile.InitialDirectory = @"D:\";
                this.TruckDataOpenFile.InitialDirectory = @"C: \Users\w.sun2014\OneDrive - University of Florida\OD\Projects\TruckParking\Truck\Accuracy Tests";
                TruckDataOpenFile.ShowDialog();
                SourceDir = TruckDataOpenFile.FileName;

                lblIPsensFolder.Text = SourceDir;
                IPsensRecords = FileIO.ReadIPsensDataFile(SourceDir);
                DataInputType = DataType.IPsens;
            }
            catch (Exception)
            {
                MessageBox.Show("Please load a correct csv. file.", "Input Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadSensysFiles_Click(object sender, EventArgs e)
        {
            try
            {
                //this.TruckDataOpenFile.InitialDirectory = @"D:\";
                this.TruckDataOpenFile.InitialDirectory = @"C: \Users\w.sun2014\OneDrive - University of Florida\OD\Projects\TruckParking\Truck\Accuracy Tests";
                TruckDataOpenFile.ShowDialog();
                SourceDir = TruckDataOpenFile.FileName;

                lblSensysFolder.Text = SourceDir;
                SensysRecords = FileIO.ReadSensysDataFile(SourceDir);
                DataInputType = DataType.Sensys;
            }
            catch (Exception)
            {
                MessageBox.Show("Please load a correct csv. file.", "Input Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadCivicSmartFiles_Click(object sender, EventArgs e)
        {
            try
            {
                //this.TruckDataOpenFile.InitialDirectory = @"D:\";
                this.TruckDataOpenFile.InitialDirectory = @"C: \Users\w.sun2014\OneDrive - University of Florida\OD\Projects\TruckParking\Truck\Accuracy Tests";
                TruckDataOpenFile.ShowDialog();
                SourceDir = TruckDataOpenFile.FileName;

                lblCivicSmartFolder.Text = SourceDir;
                CivicSmartRecords = FileIO.ReadCivicSmartDataFile(SourceDir);
                DataInputType = DataType.CivicSmart;
            }
            catch (Exception)
            {
                MessageBox.Show("Please load a correct csv. file.", "Input Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if(DataInputType == DataType.IPsens)
            {
                GetEventAccuracyIPsens();
                
            }
            else if (DataInputType == DataType.CivicSmart)
            {
                //GetEventAccuracyCivicSmart();
                GetEventAccuracyCivicSmartRawData();
            }
            else if (DataInputType == DataType.Sensys)
            {
                GetSensysEventTimeLists();
                GetEventAccuracySensys();
            }
            else if (DataInputType == DataType.BlueBand)
            {
                GetEventAccuracyBlueBand();
            }
            else if(DataInputType == DataType.BlueBandReport)
            {
                GetEventAccuracyBlueBandReport();
            }
            txtEventAccuracy.Text = EventAccuracy.ToString();
            txtNumEvents.Text = NumEvents.ToString();
        }

        private void GetEventAccuracyBlueBandReport()
        {
            int StartMonthTimeStamp = IntervalStartMonth * 2678400 + IntervalStartDay * 86400 + IntervalStartHour * 3600 + IntervalStartMinute * 60 + IntervalStartSecond;
            int TotalEventCorrected = 0;

            for (int spaceNum = SpaceStartNum; spaceNum <= SpaceEndNum; spaceNum++)
            {
                for (int n = 0; n < TruckRecords.Count(); n++)
                {
                    int EventCorrected = 0;
                    if (TruckRecords[n].SpaceNumber == spaceNum)
                    {
                        if (TruckRecords[n].IsComingIn == true)
                        {
                            for (int m = 0; m < BlueBandReportRecords.Count(); m++)
                            {
                                if (BlueBandReportRecords[m].SpaceNumber == spaceNum)
                                {
                                    if (BlueBandReportRecords[m].EnterMonthTimeStamp + OffsetValueBlueBand <= TruckRecords[n].MonthTimeStamp + Range && BlueBandReportRecords[m].EnterMonthTimeStamp + OffsetValueBlueBand >= TruckRecords[n].MonthTimeStamp - Range)
                                    {
                                        EventCorrected = 1;
                                        break;
                                    }
                                }
                            }
                        }
                        else if (TruckRecords[n].IsComingIn == false)
                        {
                            for (int m = 0; m < BlueBandReportRecords.Count(); m++)
                            {
                                if (BlueBandReportRecords[m].SpaceNumber == spaceNum)
                                {
                                    if (BlueBandReportRecords[m].ExitMonthTimeStamp + OffsetValueBlueBand <= TruckRecords[n].MonthTimeStamp + Range && BlueBandReportRecords[m].ExitMonthTimeStamp + OffsetValueBlueBand >= TruckRecords[n].MonthTimeStamp - Range)
                                    {
                                        EventCorrected = 1;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    TotalEventCorrected += EventCorrected;
                }

            }
            EventAccuracy = Math.Round((double)TotalEventCorrected / (double)TruckRecords.Count(), 4) * 100;
            NumEvents = TruckRecords.Count();

        }
        private void GetEventAccuracyIPsens()
        {
            int StartMonthTimeStamp = IntervalStartMonth * 2678400 + IntervalStartDay * 86400 + IntervalStartHour * 3600 + IntervalStartMinute * 60 + IntervalStartSecond;
            int TotalEventCorrected = 0;

            for (int spaceNum =SpaceStartNum; spaceNum <= SpaceEndNum; spaceNum ++)
            {       
                for (int n = 0; n < TruckRecords.Count(); n++)
                {
                    int EventCorrected = 0;
                    if(TruckRecords[n].SpaceNumber == spaceNum)
                    {
                        if(TruckRecords[n].IsComingIn == true)
                        {
                            if(TruckRecords[n].MonthTimeStamp == StartMonthTimeStamp)
                            {
                                for (int m = 0; m < IPsensRecords.Count(); m++)
                                {
                                    if(IPsensRecords[m].SpaceNumber == spaceNum)
                                    {
                                        if(IPsensRecords[m].EnterMonthTimeStamp <= TruckRecords[n].MonthTimeStamp)
                                        {
                                            EventCorrected=1;
                                            break;
                                        }
                                    }
           
                                }
                            }
                            else
                            {
                                for (int m = 0; m < IPsensRecords.Count(); m++)
                                {
                                    if (IPsensRecords[m].SpaceNumber == spaceNum)
                                    {
                                        if (IPsensRecords[m].EnterMonthTimeStamp <= TruckRecords[n].MonthTimeStamp + Range && IPsensRecords[m].EnterMonthTimeStamp >= TruckRecords[n].MonthTimeStamp - Range)
                                        {
                                            EventCorrected=1;
                                            break;
                                        }
                                    }
                                }
                            }   
                        }
                        else if(TruckRecords[n].IsComingIn == false)
                        {
                            for (int m = 0; m < IPsensRecords.Count(); m++)
                            {
                                if (IPsensRecords[m].SpaceNumber == spaceNum)
                                {
                                    if (IPsensRecords[m].ExistMonthTimeStamp <= TruckRecords[n].MonthTimeStamp + Range && IPsensRecords[m].ExistMonthTimeStamp >= TruckRecords[n].MonthTimeStamp - Range)
                                    {
                                        EventCorrected=1;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    TotalEventCorrected += EventCorrected;
                }
                
            }
            EventAccuracy = Math.Round((double)TotalEventCorrected / (double)TruckRecords.Count(),4)*100;
            NumEvents = TruckRecords.Count();


        }

        private void GetEventAccuracyBlueBand()
        {

            int StartMonthTimeStamp = IntervalStartMonth * 2678400 + IntervalStartDay * 86400 + IntervalStartHour * 3600 + IntervalStartMinute * 60 + IntervalStartSecond;
            int TotalEventCorrected = 0;
            for (int spaceNum = SpaceStartNum; spaceNum <= SpaceEndNum; spaceNum++)
            {
                for (int n = 0; n < TruckRecords.Count(); n++)
                {
                    int EventCorrected = 0;
                    if (TruckRecords[n].SpaceNumber == spaceNum)
                    {
                        if (TruckRecords[n].IsComingIn == true)
                        {
                            for (int m = 0; m < BlueBandRecords.Count(); m++)
                            {
                                if (BlueBandRecords[m].SpaceNumber == (11- spaceNum) && BlueBandRecords[m].ParkingStatus == 1)
                                {
                                    if (BlueBandRecords[m].MonthTimeStamp + OffsetValueBlueBand <= TruckRecords[n].MonthTimeStamp + Range && BlueBandRecords[m].MonthTimeStamp + OffsetValueBlueBand >= TruckRecords[n].MonthTimeStamp - Range)
                                    {
                                        EventCorrected = 1;
                                    }
                                }
                            }
                        }
                        else if (TruckRecords[n].IsComingIn == false)
                        {
                            for (int m = 0; m < BlueBandRecords.Count(); m++)
                            {
                                if (BlueBandRecords[m].SpaceNumber == (11- spaceNum) && BlueBandRecords[m].ParkingStatus == 0)
                                {
                                    if (BlueBandRecords[m].MonthTimeStamp + OffsetValueBlueBand <= TruckRecords[n].MonthTimeStamp + Range && BlueBandRecords[m].MonthTimeStamp + OffsetValueBlueBand >= TruckRecords[n].MonthTimeStamp - Range)
                                    {
                                        EventCorrected = 1;
                                    }
                                }
                            }
                        }
                    }
                    TotalEventCorrected += EventCorrected;
                }
            }
            EventAccuracy = Math.Round((double)TotalEventCorrected / (double)TruckRecords.Count(), 4) * 100;
            NumEvents = TruckRecords.Count();
        }
        private void GetEventAccuracyCivicSmartRawData()
        {
            int StartMonthTimeStamp = IntervalStartMonth * 2678400 + IntervalStartDay * 86400 + IntervalStartHour * 3600 + IntervalStartMinute * 60 + IntervalStartSecond;
            int TotalEventCorrected = 0;
            for (int spaceNum = SpaceStartNum; spaceNum <= SpaceEndNum; spaceNum++)
            {
                for (int n = 0; n < TruckRecords.Count(); n++)
                {
                    int EventCorrected = 0;
                    if (TruckRecords[n].SpaceNumber == spaceNum)
                    {
                        if (TruckRecords[n].IsComingIn == true)
                        {
                            for (int m = 0; m < CivicSmartRecords.Count(); m++)
                            {
                                if (CivicSmartRecords[m].SpaceNumber == spaceNum && CivicSmartRecords[m].ParkingStatus ==1)
                                {
                                    if (CivicSmartRecords[m].MonthTimeStamp + OffsetValue <= TruckRecords[n].MonthTimeStamp + Range && CivicSmartRecords[m].MonthTimeStamp + OffsetValue >= TruckRecords[n].MonthTimeStamp - Range)
                                    {
                                        EventCorrected = 1;
                                    }
                                }
                            }
                        }
                        else if (TruckRecords[n].IsComingIn == false)
                        {
                            for (int m = 0; m < CivicSmartRecords.Count(); m++)
                            {
                                if (CivicSmartRecords[m].SpaceNumber == spaceNum && CivicSmartRecords[m].ParkingStatus == 0)
                                {
                                    if (CivicSmartRecords[m].MonthTimeStamp + OffsetValue <= TruckRecords[n].MonthTimeStamp + Range && CivicSmartRecords[m].MonthTimeStamp + OffsetValue >= TruckRecords[n].MonthTimeStamp - Range)
                                    {
                                        EventCorrected = 1;
                                    }
                                }
                            }
                        }
                    }
                    TotalEventCorrected += EventCorrected;
                }
            }
            EventAccuracy = Math.Round((double)TotalEventCorrected / (double)TruckRecords.Count(), 4) * 100;
            NumEvents = TruckRecords.Count();
        }
  
        private void GetEventAccuracySensys()
        {
            int StartMonthTimeStamp = IntervalStartMonth * 2678400 + IntervalStartDay * 86400 + IntervalStartHour * 3600 + IntervalStartMinute * 60 + IntervalStartSecond;
            int TotalEventCorrected = 0;
            for (int n = 0; n < TruckRecords.Count(); n++)
            {
                int EventCorrected = 0;
                for (int sensorNum = 3 * (TruckRecords[n].SpaceNumber - 1); sensorNum < TruckRecords[n].SpaceNumber * 3 - 1; sensorNum++)
                {
                    if (TruckRecords[n].IsComingIn == true)
                    {
                        if (TruckRecords[n].MonthTimeStamp == StartMonthTimeStamp)
                        {
                            for (int m = 0; m < SensysEventTimeLists[sensorNum].Count(); m++)
                            {
                                if (SensysEventTimeLists[sensorNum][0][0, 1] == 1)
                                {
                                    EventCorrected = 1;
                                }
                            }
                        }
                        else
                        {
                            for (int m = 0; m < SensysEventTimeLists[sensorNum].Count(); m++)
                            {
                                if (SensysEventTimeLists[sensorNum][m][0, 1] == 1)
                                {
                                    if (SensysEventTimeLists[sensorNum][m][0, 0] <= TruckRecords[n].MonthTimeStamp + Range && SensysEventTimeLists[sensorNum][m][0, 0] >= TruckRecords[n].MonthTimeStamp - Range)
                                    {
                                        EventCorrected = 1;
                                    }
                                }
                            }
                        }
                    }
                    else if(TruckRecords[n].IsComingIn == false)
                    {
                        for (int m = 0; m < SensysEventTimeLists[sensorNum].Count(); m++)
                        {
                            if (SensysEventTimeLists[sensorNum][m][0, 1] == 0)
                            {
                                if (SensysEventTimeLists[sensorNum][m][0, 0] <= TruckRecords[n].MonthTimeStamp + Range && SensysEventTimeLists[sensorNum][m][0, 0] >= TruckRecords[n].MonthTimeStamp - Range)
                                {
                                    EventCorrected = 1;
                                }
                            }
                        }
                    }

                }
                TotalEventCorrected += EventCorrected;
            }

            EventAccuracy = Math.Round((double)TotalEventCorrected / (double)TruckRecords.Count(), 4) * 100;
            NumEvents = TruckRecords.Count();
        }


        private void txtOffset_TextChanged(object sender, EventArgs e)
        {
            OffsetValue = Convert.ToInt32(txtOffset.Text);
        }


        private void GetSensysEventTimeLists()
        {
            SensysEventTimeLists.Clear();
            int RecordsTot = SensysRecords.Count();
            int[,] eventTime;
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space1A != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp -TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space1A;
                SensysEventTimeList.Add(eventTime);
            }          
            for (int n = 1; n < RecordsTot; n++) //no need to use n =0, as they all start with -1
            {
                
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space1A != SensysRecords[n - 1].Space1A)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space1A;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);

            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space1B != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space1B;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++) 
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space1B != SensysRecords[n - 1].Space1B)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space1B;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);

            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space1C != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space1C;
                SensysEventTimeList.Add(eventTime);
            }  
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space1C != SensysRecords[n - 1].Space1C)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space1C;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space2A != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space2A;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space2A != SensysRecords[n - 1].Space2A)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space2A;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space2B != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space2B;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space2B != SensysRecords[n - 1].Space2B)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space2B;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space2C != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space2C;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space2C != SensysRecords[n - 1].Space2C)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space2C;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space3A != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space3A;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space3A != SensysRecords[n - 1].Space3A)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space3A;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space3B != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space3B;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space3B != SensysRecords[n - 1].Space3B)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space3B;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space3C != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space3C;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space3C != SensysRecords[n - 1].Space3C)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space3C;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space4A != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space4A;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space4A != SensysRecords[n - 1].Space4A)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space4A;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space4B != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space4B;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space4B != SensysRecords[n - 1].Space4B)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space4B;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space4C != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space4C;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space4C != SensysRecords[n - 1].Space4C)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space4C;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space5A != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space5A;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space5A != SensysRecords[n - 1].Space5A)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space5A;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space5B != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space5B;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space5B != SensysRecords[n - 1].Space5B)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space5B;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space5C != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space5C;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space5C != SensysRecords[n - 1].Space5C)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space5C;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space6A != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space6A;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space6A != SensysRecords[n - 1].Space6A)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space6A;
                    SensysEventTimeList.Add(eventTime);
                }

            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space6B != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space6B;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space6B != SensysRecords[n - 1].Space6B)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space6B;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space6C != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space6C;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space6C != SensysRecords[n - 1].Space6C)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space6C;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space7A != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space7A;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space7A != SensysRecords[n - 1].Space7A)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space7A;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space7B != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space7B;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space7B != SensysRecords[n - 1].Space7B)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space7B;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space7C != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space7C;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space7C != SensysRecords[n - 1].Space7C)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space7C;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space8A != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space8A;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space8A != SensysRecords[n - 1].Space8A)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space8A;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space8B != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space8B;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space8B != SensysRecords[n - 1].Space8B)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space8B;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space8C != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space8C;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space8C != SensysRecords[n - 1].Space8C)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space8C;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space9A != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space9A;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space9A != SensysRecords[n - 1].Space9A)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space9A;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space9B != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space9B;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space9B != SensysRecords[n - 1].Space9B)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space9B;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space9C != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space9C;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space9C != SensysRecords[n - 1].Space9C)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space9C;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space10A != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space10A;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space10A != SensysRecords[n - 1].Space10A)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space10A;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space10B != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space10B;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space10B != SensysRecords[n - 1].Space10B)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space10B;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            SensysEventTimeList = new List<int[,]>();
            if (SensysRecords[0].Space10C != -1)
            {
                eventTime = new int[1, 2];
                eventTime[0, 0] = SensysRecords[0].MonthTimeStamp - TimeDifference;
                eventTime[0, 1] = SensysRecords[0].Space10C;
                SensysEventTimeList.Add(eventTime);
            }
            for (int n = 1; n < RecordsTot; n++)
            {
                eventTime = new int[1, 2];
                if (SensysRecords[n].Space10C != SensysRecords[n - 1].Space10C)
                {
                    eventTime[0, 0] = SensysRecords[n].MonthTimeStamp - TimeDifference;
                    eventTime[0, 1] = SensysRecords[n].Space10C;
                    SensysEventTimeList.Add(eventTime);
                }
            }
            SensysEventTimeLists.Add(SensysEventTimeList);
            
        }

        private void GetOccupancyListsBlueBandReport()
        {
            int[,] eventTime;
            int totalRecords = BlueBandReportRecords.Count();
            BlueBandOccupancyTimeLists.Clear();
            for (int spaceIndex = 0; spaceIndex < 10; spaceIndex++)
            {
                BlueBandOccupancyTimeList = new List<int[,]>();
                for (int timeStamp = StartTimeStamp; timeStamp <= EndTimeStamp; timeStamp++)
                {
                    eventTime = new int[1, 2];
                    eventTime[0, 0] = timeStamp;
                    eventTime[0, 1] = 0;
                    for (int recordIndex = 0; recordIndex < totalRecords; recordIndex++)
                    {
                        if (BlueBandReportRecords[recordIndex].SpaceNumber == spaceIndex + 1)
                        {
                            if (timeStamp >= BlueBandReportRecords[recordIndex].EnterMonthTimeStamp + OffsetValueBlueBand && timeStamp < BlueBandReportRecords[recordIndex].ExitMonthTimeStamp + OffsetValueBlueBand)
                            {
                                eventTime[0, 1] = 1;
                                break;
                            }
                        }
                    }
                    BlueBandOccupancyTimeList.Add(eventTime);
                }
                BlueBandOccupancyTimeLists.Add(BlueBandOccupancyTimeList);
            }
        }

        private void GetOccupancyListsIPsens()
        {
            int[,] eventTime;
            int totalRecords = IPsensRecords.Count();
            IPsensOccupancyTimeLists.Clear();
            for(int spaceIndex=0; spaceIndex <10;spaceIndex++)
            {
                IPsensOccupancyTimeList = new List<int[,]>();
                for(int timeStamp = StartTimeStamp; timeStamp <= EndTimeStamp; timeStamp++)
                {
                    eventTime = new int[1, 2];
                    eventTime[0, 0] = timeStamp;
                    eventTime[0, 1] = 0;
                    for (int recordIndex =0; recordIndex<totalRecords;recordIndex++)
                    {
                        if(IPsensRecords[recordIndex].SpaceNumber == spaceIndex + 1)
                        {
                            if(timeStamp >=IPsensRecords[recordIndex].EnterMonthTimeStamp && timeStamp < IPsensRecords[recordIndex].ExistMonthTimeStamp)
                            {
                                eventTime[0, 1] = 1;
                                break;
                            }
                        }
                    }
                    IPsensOccupancyTimeList.Add(eventTime);
                }
                IPsensOccupancyTimeLists.Add(IPsensOccupancyTimeList);
            }
        }
        private void txtTimeDifference_TextChanged(object sender, EventArgs e)
        {
            TimeDifference = Convert.ToInt32(txtTimeDifference.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.InitialDirectory = System.Windows.Forms.Application.StartupPath;

            saveFileDialog.Filter = "Results Files (*.csv)|*.csv|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                FileIO.WriteTimeStamps(saveFileDialog.FileName);
            }
        }

        private void txtRange_TextChanged(object sender, EventArgs e)
        {
            if(txtRange.Text != "")
            {
                Range = Convert.ToInt32(txtRange.Text);
            }
            
        }
        private void GetStudiedInterval()
        {
            IntervalStartMonth = Convert.ToByte(updnStartMonth.Value);
            IntervalEndMonth = Convert.ToByte(updnEndMonth.Value);
            IntervalStartDay = Convert.ToByte(updnStartDay.Value);
            IntervalEndDay = Convert.ToByte(updnEndDay.Value);
            IntervalStartMinute = Convert.ToByte(updnStartMinute.Value);
            IntervalEndMinute = Convert.ToByte(updnEndMinute.Value);
            CalculateIntervalTimeStamp();
        }
        private void btnOccupancyCompare_Click(object sender, EventArgs e)
        {
            GetStudiedInterval();
            GetInOutTimeLists();
            GetTimeStampRecordsVideo();
            if (DataInputType == DataType.IPsens)
            {
                GetOccupancyListsIPsens();
                GetOccupancyAccuracyIPsens();
            }
            else if (DataInputType == DataType.CivicSmart)
            {
                GetCivicSmartSensorLists();
                GetCivicSmartEventTimeLists();
                GetCivicSmartInOutPairsLists();
                GetCivicSmartTimeStampLists();
                GetCivicSmartSpaceStatus();
                GetOccupancyAccuracyCivicSmart();
            }
            else if (DataInputType == DataType.Sensys)
            {
                GetSensysEventTimeLists();
                GetSensysOccupancyLists();
                GetSensysInOutPairsLists();
                GetSensysTimeStampLists();
                GetSensysSpaceStatus();
                GetOccupancyAccuracySensys();
            }
            else if(DataInputType == DataType.BlueBand)
            {
                GetBlueBandSensorLists();
                GetBlueBandEventTimeLists();
                GetBlueBandInOutPairsLists();
                GetBlueBandTimeStampLists();
                GetBlueBandSpaceStatus();
                GetOccupancyAccuracyBlueBand();
            }
            else if(DataInputType == DataType.BlueBandReport)
            {
                GetOccupancyListsBlueBandReport();
                GetOccupancyAccuracyBlueBandReport();
            }
            txtOccupancyAccuracy.Text = OccupancyAccuracy.ToString();
            Duration = (IntervalEndDay - IntervalStartDay) * 24 + IntervalEndHour - IntervalStartHour;
            txtDuration.Text = Duration.ToString();
            
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
                            InTimes.Add(CalculateMonthTimeStamp(TruckRecords[RecordNum].Month, TruckRecords[RecordNum].Day, TruckRecords[RecordNum].Hour, TruckRecords[RecordNum].Minute, TruckRecords[RecordNum].Second));
                        }
                        else if (TruckRecords[RecordNum].IsComingIn == false)
                        {
                            OutTimes.Add(CalculateMonthTimeStamp(TruckRecords[RecordNum].Month, TruckRecords[RecordNum].Day, TruckRecords[RecordNum].Hour, TruckRecords[RecordNum].Minute, TruckRecords[RecordNum].Second));
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
            for (int space = 0; space < 10; space++)
            {
                timeStampRecordsBySpace = new List<int[,]>();
                for (int timeStamp = StartTimeStamp; timeStamp <= EndTimeStamp; timeStamp++) //Every one minute //Change to second 30Aug
                {
                    stampRecord = new int[1, 2];
                    stampRecord[0, 0] = timeStamp;
                    for (int NumInOut = 0; NumInOut < OutTimeListsAllSpots[space].Count; NumInOut++)
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
        private void GetOccupancyAccuracyBlueBandReport()
        {
            int numRecords = timeStampRecords[0].Count();
            double totalStatus = numRecords * 10;
            double totalCorrectStatus = 0;
            List<double> AccuracyList = new List<double>();
            for (int space = 0; space < 10; space++)
            {
                double accuracy = 0;
                double correctStatus = 0;
                for (int timeStampIndex = 0; timeStampIndex < numRecords; timeStampIndex++)
                {
                    if (timeStampRecords[space][timeStampIndex][0, 1] == BlueBandOccupancyTimeLists[space][timeStampIndex][0, 1])
                    {
                        correctStatus++;
                    }
                }
                accuracy = Math.Round(correctStatus / numRecords * 100, 4);
                totalCorrectStatus = totalCorrectStatus + correctStatus;
                AccuracyList.Add(accuracy);
            }
            OccupancyAccuracy = Math.Round(totalCorrectStatus / totalStatus * 100, 2);

        }
        private void GetOccupancyAccuracyIPsens()
        {
            int numRecords = timeStampRecords[0].Count();
            double totalStatus = numRecords * 10;
            double totalCorrectStatus = 0;
            List<double> AccuracyList = new List<double>();
            for (int space = 0; space < 10; space++)
            {
                double accuracy = 0;
                double correctStatus = 0;
                for (int timeStampIndex = 0; timeStampIndex < numRecords; timeStampIndex++)
                {
                    if (timeStampRecords[space][timeStampIndex][0, 1] == IPsensOccupancyTimeLists[space][timeStampIndex][0, 1])
                    {
                        correctStatus++;
                    }
                }
                accuracy = Math.Round(correctStatus / numRecords * 100, 4);
                totalCorrectStatus = totalCorrectStatus + correctStatus;
                AccuracyList.Add(accuracy);
            }
            OccupancyAccuracy = Math.Round(totalCorrectStatus / totalStatus * 100, 2);

        }
      
        private void GetSensysSpaceStatus()
        {
            int numRecords = SensysTimeStampLists[0].Count();
            SensysSpaceStatusLists.Clear();
            for(int spaceIndex =0; spaceIndex <10;spaceIndex++)
            {
                SensysSpaceStatusList = new List<int[,]>();
                for (int timeStampIndex =0; timeStampIndex<numRecords;timeStampIndex ++)
                {
                    int spaceStatus = 0;
                    int[,] statusTime = new int[1, 2];
                    statusTime[0, 0] = SensysTimeStampLists[0][timeStampIndex][0, 0];

                    for (int sensorIndex = spaceIndex * 3; sensorIndex < (spaceIndex + 1) * 3; sensorIndex++)
                    {
                        spaceStatus = spaceStatus + SensysTimeStampLists[sensorIndex][timeStampIndex][0, 1];
                    }
                    if(spaceStatus == 0)
                    {
                        statusTime[0, 1] = 0;
                    }
                    else
                    {
                        statusTime[0, 1] = 1;
                    }
                    SensysSpaceStatusList.Add(statusTime);
                }
                SensysSpaceStatusLists.Add(SensysSpaceStatusList);
            }
        }
        private void GetSensysOccupancyLists()
        {
            SensysOccupancyLists.Clear();
            int[,] occupancyTime;
            for (int sensorIndex = 0; sensorIndex < 30; sensorIndex++)
            {
                SensysOccupancyList = new List<int[,]>();
                if (SensysEventTimeLists[sensorIndex][0][0, 1] == 1)
                {
                    occupancyTime = new int[1, 2];
                    occupancyTime[0, 0] = StartTimeStamp;
                    occupancyTime[0, 1] = 1;
                    SensysOccupancyList.Add(occupancyTime);
                } 
                for (int eventIndex = 1; eventIndex < SensysEventTimeLists[sensorIndex].Count; eventIndex++)
                {
                    
                    if (SensysEventTimeLists[sensorIndex][eventIndex][0, 1] != -1)
                    {
                        if (SensysEventTimeLists[sensorIndex][eventIndex][0, 1] == 1 && SensysEventTimeLists[sensorIndex][eventIndex - 1][0, 1] != -1)
                        {

                            if (eventIndex != SensysEventTimeLists[sensorIndex].Count - 1)
                            {
                                occupancyTime = new int[1, 2];
                                occupancyTime[0, 0] = SensysEventTimeLists[sensorIndex][eventIndex][0, 0];
                                occupancyTime[0, 1] = SensysEventTimeLists[sensorIndex][eventIndex][0, 1];
                                SensysOccupancyList.Add(occupancyTime);
                            }
                            else
                            {
                                occupancyTime = new int[1, 2];
                                occupancyTime[0, 0] = SensysEventTimeLists[sensorIndex][eventIndex][0, 0];
                                occupancyTime[0, 1] = SensysEventTimeLists[sensorIndex][eventIndex][0, 1];
                                SensysOccupancyList.Add(occupancyTime);
                                occupancyTime = new int[1, 2];
                                occupancyTime[0, 0] = EndTimeStamp;
                                occupancyTime[0, 1] = 0;
                                SensysOccupancyList.Add(occupancyTime);
                            }
                            
                        }
                        else if(SensysEventTimeLists[sensorIndex][eventIndex][0, 1] == 1 && SensysEventTimeLists[sensorIndex][eventIndex - 1][0, 1] == -1)
                        {
                            if (eventIndex == SensysEventTimeLists[sensorIndex].Count - 1)
                            {
                                occupancyTime = new int[1, 2];
                                occupancyTime[0, 0] = EndTimeStamp;
                                occupancyTime[0, 1] = 0;
                                SensysOccupancyList.Add(occupancyTime);
                            }
                            
                        }
                        else if (SensysEventTimeLists[sensorIndex][eventIndex][0, 1] == 0 && SensysEventTimeLists[sensorIndex][eventIndex - 1][0, 1] != -1)
                        {
                            occupancyTime = new int[1, 2];
                            occupancyTime[0, 0] = SensysEventTimeLists[sensorIndex][eventIndex][0, 0];
                            occupancyTime[0, 1] = SensysEventTimeLists[sensorIndex][eventIndex][0, 1];
                            SensysOccupancyList.Add(occupancyTime);
                        }
                    }
                }

                SensysOccupancyLists.Add(SensysOccupancyList);
            }
        }
        private void GetSensysInOutPairsLists()
        {
            SensysInOutPairLists.Clear();
            for(int sensorIndex = 0; sensorIndex <30;sensorIndex++)
            {
                SensysInOutPairList = new List<int[,]>();
                for (int eventIndex = 0; eventIndex < SensysOccupancyLists[sensorIndex].Count(); eventIndex += 2)
                {
                    int[,] InOutTimeStamp = new int[1, 2];
                    InOutTimeStamp[0,0] = SensysOccupancyLists[sensorIndex][eventIndex][0, 0]; //in
                    InOutTimeStamp[0,1] = SensysOccupancyLists[sensorIndex][eventIndex+1][0, 0]; //out
                    SensysInOutPairList.Add(InOutTimeStamp);
                }
                SensysInOutPairLists.Add(SensysInOutPairList);
            }
        }
        private void GetSensysTimeStampLists()
        {
            SensysTimeStampLists.Clear();
            for(int sensorIndex =0; sensorIndex <30; sensorIndex++)
            {
                SensysTimeStampList = new List<int[,]>();
                for(int timeStamp = StartTimeStamp; timeStamp <= EndTimeStamp; timeStamp++)
                {
                    int[,] eventTime = new int[1, 2];
                    eventTime[0, 0] = timeStamp;
                    eventTime[0, 1] = 0;
                    for (int pairIndex = 0; pairIndex < SensysInOutPairLists[sensorIndex].Count; pairIndex++)
                    {
                        if(timeStamp >= SensysInOutPairLists[sensorIndex][pairIndex][0,0] && timeStamp <= SensysInOutPairLists[sensorIndex][pairIndex][0, 1])
                        {
                            eventTime[0, 1] = 1;
                            break;
                        }

                    }
                    SensysTimeStampList.Add(eventTime);
                }
                SensysTimeStampLists.Add(SensysTimeStampList);
            }

        }
        private void GetOccupancyAccuracySensys()
        {
            int numRecords = timeStampRecords[0].Count();
            double totalStatus = numRecords * 10;
            double totalCorrectStatus = 0;
            List<double> AccuracyList = new List<double>();
            for (int space = 0; space < 10; space++)
            {
                double accuracy = 0;
                double correctStatus = 0;
                for (int timeStampIndex = 0; timeStampIndex < numRecords; timeStampIndex++)
                {
                    if (timeStampRecords[space][timeStampIndex][0, 1] == SensysSpaceStatusLists[space][timeStampIndex][0, 1])
                    {
                        correctStatus++;
                    }
                }
                accuracy = Math.Round(correctStatus / numRecords * 100, 4);
                totalCorrectStatus = totalCorrectStatus + correctStatus;
                AccuracyList.Add(accuracy);
            }
            OccupancyAccuracy = Math.Round(totalCorrectStatus / totalStatus * 100, 2);
        }
        private void GetCivicSmartSensorLists()
        {
            CivicSmartSensorLists.Clear();
            int RecordsTot = CivicSmartRecords.Count();
            for(int sensorIndex = 0; sensorIndex < 20; sensorIndex++)
            {
                CivicSmartSensorList = new List<CivicSmartRecord>();
                for(int recordIndex =0; recordIndex <RecordsTot;recordIndex++)
                {
                    if(CivicSmartRecords[recordIndex].SensorID == sensorIndex + 1)
                    {
                        CivicSmartSensorList.Add(CivicSmartRecords[recordIndex]);
                    }
                }
                CivicSmartSensorLists.Add(CivicSmartSensorList);
            }
        }
        private void GetBlueBandSensorLists()
        {
            BlueBandSensorLists.Clear();
            int RecordsTot = BlueBandRecords.Count();
            for (int sensorIndex = 0; sensorIndex < 20; sensorIndex++)
            {
                BlueBandSensorList = new List<BlueBandRecord>();
                for (int recordIndex = 0; recordIndex < RecordsTot; recordIndex++)
                {
                    if (BlueBandRecords[recordIndex].SensorID == sensorIndex + 1)
                    {
                        BlueBandSensorList.Add(BlueBandRecords[recordIndex]);
                    }
                }
                BlueBandSensorLists.Add(BlueBandSensorList);
            }
        }
        private void GetCivicSmartEventTimeLists()
        {
            CivicSmartEventTimeLists.Clear();
            for(int sensorIndex =0; sensorIndex <20; sensorIndex++)
            {
                
                int[,] eventTime;
                CivicSmartEventTimeList = new List<int[,]>();
                if (CivicSmartSensorLists[sensorIndex][0].ParkingStatus == 0)
                {
                    eventTime = new int[1, 2];
                    eventTime[0, 0] = StartTimeStamp;
                    eventTime[0, 1] = 1;
                    CivicSmartEventTimeList.Add(eventTime);

                    eventTime = new int[1, 2];
                    eventTime[0, 0] = CivicSmartSensorLists[sensorIndex][0].MonthTimeStamp+OffsetValue;
                    eventTime[0, 1] = CivicSmartSensorLists[sensorIndex][0].ParkingStatus;
                    CivicSmartEventTimeList.Add(eventTime);
                }
                else if (CivicSmartSensorLists[sensorIndex][0].ParkingStatus == 1)
                {
                    eventTime = new int[1, 2];
                    eventTime[0, 0] = CivicSmartSensorLists[sensorIndex][0].MonthTimeStamp+ OffsetValue;
                    eventTime[0, 1] = CivicSmartSensorLists[sensorIndex][0].ParkingStatus;
                    CivicSmartEventTimeList.Add(eventTime);
                }


                for (int n = 1; n < CivicSmartSensorLists[sensorIndex].Count; n++) //no need to use n =0, as they all start with -1
                {

                    eventTime = new int[1, 2];
                    if (CivicSmartSensorLists[sensorIndex][n].ParkingStatus != CivicSmartSensorLists[sensorIndex][n - 1].ParkingStatus)
                    {
                        eventTime[0, 0] = CivicSmartSensorLists[sensorIndex][n].MonthTimeStamp+ OffsetValue;
                        eventTime[0, 1] = CivicSmartSensorLists[sensorIndex][n].ParkingStatus;
                        CivicSmartEventTimeList.Add(eventTime);
                    }
                    
                }
                eventTime = new int[1, 2];
                if (CivicSmartSensorLists[sensorIndex][CivicSmartSensorLists[sensorIndex].Count - 1].ParkingStatus == 1)
                {
                    eventTime[0, 0] = EndTimeStamp;
                    eventTime[0, 1] = 0;
                    CivicSmartEventTimeList.Add(eventTime);
                }
                CivicSmartEventTimeLists.Add(CivicSmartEventTimeList);
            }
            
        }
        private void GetBlueBandEventTimeLists()
        {
            BlueBandEventTimeLists.Clear();
            for (int sensorIndex = 0; sensorIndex < 20; sensorIndex++)
            {
                int[,] eventTime;
                BlueBandEventTimeList = new List<int[,]>();

                if(BlueBandSensorLists[sensorIndex].Count != 0)
                {
                    if (BlueBandSensorLists[sensorIndex][0].ParkingStatus == 0)
                    {
                        eventTime = new int[1, 2];
                        eventTime[0, 0] = StartTimeStamp;
                        eventTime[0, 1] = 1;
                        BlueBandEventTimeList.Add(eventTime);

                        eventTime = new int[1, 2];
                        eventTime[0, 0] = BlueBandSensorLists[sensorIndex][0].MonthTimeStamp + OffsetValueBlueBand;
                        eventTime[0, 1] = BlueBandSensorLists[sensorIndex][0].ParkingStatus;
                        BlueBandEventTimeList.Add(eventTime);
                    }
                    else if (BlueBandSensorLists[sensorIndex][0].ParkingStatus == 1)
                    {
                        eventTime = new int[1, 2];
                        eventTime[0, 0] = BlueBandSensorLists[sensorIndex][0].MonthTimeStamp + OffsetValueBlueBand;
                        eventTime[0, 1] = BlueBandSensorLists[sensorIndex][0].ParkingStatus;
                        BlueBandEventTimeList.Add(eventTime);
                    }
                    for (int n = 1; n < BlueBandSensorLists[sensorIndex].Count; n++)
                    {

                        eventTime = new int[1, 2];
                        if (BlueBandSensorLists[sensorIndex][n].ParkingStatus != BlueBandSensorLists[sensorIndex][n - 1].ParkingStatus)
                        {
                            eventTime[0, 0] = BlueBandSensorLists[sensorIndex][n].MonthTimeStamp + OffsetValueBlueBand;
                            eventTime[0, 1] = BlueBandSensorLists[sensorIndex][n].ParkingStatus;
                            BlueBandEventTimeList.Add(eventTime);
                        }

                    }
                    eventTime = new int[1, 2];
                    if (BlueBandSensorLists[sensorIndex][BlueBandSensorLists[sensorIndex].Count - 1].ParkingStatus == 1)
                    {
                        eventTime[0, 0] = EndTimeStamp;
                        eventTime[0, 1] = 0;
                        BlueBandEventTimeList.Add(eventTime);
                    }
                }
              
                BlueBandEventTimeLists.Add(BlueBandEventTimeList);
            }

        }

        private void GetCivicSmartInOutPairsLists()
        {
            CivicSmartInOutPairLists.Clear();
            for (int sensorIndex = 0; sensorIndex < 20; sensorIndex++)
            {
                CivicSmartInOutPairList = new List<int[,]>();
                for (int eventIndex = 0; eventIndex < CivicSmartEventTimeLists[sensorIndex].Count(); eventIndex += 2)
                {
                    int[,] InOutTimeStamp = new int[1, 2];
                    InOutTimeStamp[0, 0] = CivicSmartEventTimeLists[sensorIndex][eventIndex][0, 0]; //in
                    InOutTimeStamp[0, 1] = CivicSmartEventTimeLists[sensorIndex][eventIndex + 1][0, 0]; //out
                    CivicSmartInOutPairList.Add(InOutTimeStamp);
                }
                CivicSmartInOutPairLists.Add(CivicSmartInOutPairList);
            }
        }

        private void GetBlueBandInOutPairsLists()
        {
            BlueBandInOutPairLists.Clear();
            for (int sensorIndex = 0; sensorIndex < 20; sensorIndex++)
            {

                BlueBandInOutPairList = new List<int[,]>();
                if(BlueBandEventTimeLists[sensorIndex].Count != 0)
                {
                    for (int eventIndex = 0; eventIndex < BlueBandEventTimeLists[sensorIndex].Count(); eventIndex += 2)
                    {
                        int[,] InOutTimeStamp = new int[1, 2];
                        InOutTimeStamp[0, 0] = BlueBandEventTimeLists[sensorIndex][eventIndex][0, 0]; //in
                        InOutTimeStamp[0, 1] = BlueBandEventTimeLists[sensorIndex][eventIndex + 1][0, 0]; //out
                        BlueBandInOutPairList.Add(InOutTimeStamp);
                    }
                }
                
                BlueBandInOutPairLists.Add(BlueBandInOutPairList);
            }
        }
        private void GetCivicSmartTimeStampLists()
        {
            CivicSmartTimeStampLists.Clear();
            for (int sensorIndex = 0; sensorIndex < 20; sensorIndex++)
            {
                CivicSmartTimeStampList = new List<int[,]>();
                for (int timeStamp = StartTimeStamp; timeStamp <= EndTimeStamp; timeStamp++)
                {
                    int[,] eventTime = new int[1, 2];
                    eventTime[0, 0] = timeStamp;
                    eventTime[0, 1] = 0;
                    for (int pairIndex = 0; pairIndex < CivicSmartInOutPairLists[sensorIndex].Count; pairIndex++)
                    {
                        if (timeStamp >= CivicSmartInOutPairLists[sensorIndex][pairIndex][0, 0] && timeStamp <= CivicSmartInOutPairLists[sensorIndex][pairIndex][0, 1])
                        {
                            eventTime[0, 1] = 1;
                            break;
                        }

                    }
                    CivicSmartTimeStampList.Add(eventTime);
                }
                CivicSmartTimeStampLists.Add(CivicSmartTimeStampList);
            }
        }

        private void GetBlueBandTimeStampLists()
        {
            BlueBandTimeStampLists.Clear();
            for (int sensorIndex = 0; sensorIndex < 20; sensorIndex++)
            {
                BlueBandTimeStampList = new List<int[,]>();
                if(BlueBandInOutPairLists[sensorIndex].Count != 0) //has events
                {
                    for (int timeStamp = StartTimeStamp; timeStamp <= EndTimeStamp; timeStamp++)
                    {
                        int[,] eventTime = new int[1, 2];
                        eventTime[0, 0] = timeStamp;
                        eventTime[0, 1] = 0;
                        for (int pairIndex = 0; pairIndex < BlueBandInOutPairLists[sensorIndex].Count; pairIndex++)
                        {
                            if (timeStamp >= BlueBandInOutPairLists[sensorIndex][pairIndex][0, 0] && timeStamp <= BlueBandInOutPairLists[sensorIndex][pairIndex][0, 1])
                            {
                                eventTime[0, 1] = 1;
                                break;
                            }

                        }
                        BlueBandTimeStampList.Add(eventTime);
                    }
                }
                else //sensor has no events, then consider the sensor status as not occupied
                {
                    for (int timeStamp = StartTimeStamp; timeStamp <= EndTimeStamp; timeStamp++)
                    {
                        int[,] eventTime = new int[1, 2];
                        eventTime[0, 0] = timeStamp;
                        eventTime[0, 1] = 0;
                        BlueBandTimeStampList.Add(eventTime);
                    }
                }
                
                BlueBandTimeStampLists.Add(BlueBandTimeStampList);
            }
        }
        private void GetCivicSmartSpaceStatus()
        {
            int numRecords = CivicSmartTimeStampLists[0].Count();
            CivicSmartSpaceStatusLists.Clear();
            for (int spaceIndex = 0; spaceIndex < 10; spaceIndex++)
            {
                CivicSmartSpaceStatusList = new List<int[,]>();
                for (int timeStampIndex = 0; timeStampIndex < numRecords; timeStampIndex++)
                {
                    int spaceStatus = 0;
                    int[,] statusTime = new int[1, 2];
                    statusTime[0, 0] = CivicSmartTimeStampLists[0][timeStampIndex][0, 0];

                    for (int sensorIndex = spaceIndex * 2; sensorIndex < (spaceIndex + 1) * 2; sensorIndex++)
                    {
                        spaceStatus = spaceStatus + CivicSmartTimeStampLists[sensorIndex][timeStampIndex][0, 1];
                    }
                    if (spaceStatus == 0)
                    {
                        statusTime[0, 1] = 0;
                    }
                    else
                    {
                        statusTime[0, 1] = 1;
                    }
                    CivicSmartSpaceStatusList.Add(statusTime);
                }
                CivicSmartSpaceStatusLists.Add(CivicSmartSpaceStatusList);
            }
        }
        private void GetBlueBandSpaceStatus()
        {
            int numRecords = BlueBandTimeStampLists[0].Count();
            BlueBandSpaceStatusLists.Clear();
            for (int spaceIndex = 0; spaceIndex < 10; spaceIndex++)
            {
                BlueBandSpaceStatusList = new List<int[,]>();
                for (int timeStampIndex = 0; timeStampIndex < numRecords; timeStampIndex++)
                {
                    int spaceStatus = 0;
                    int[,] statusTime = new int[1, 2];
                    statusTime[0, 0] = BlueBandTimeStampLists[0][timeStampIndex][0, 0];

                    for (int sensorIndex = spaceIndex * 2; sensorIndex < (spaceIndex + 1) * 2; sensorIndex++)
                    {
                        spaceStatus = spaceStatus + BlueBandTimeStampLists[sensorIndex][timeStampIndex][0, 1];
                    }
                    if (spaceStatus == 0)
                    {
                        statusTime[0, 1] = 0;
                    }
                    else
                    {
                        statusTime[0, 1] = 1;
                    }
                    BlueBandSpaceStatusList.Add(statusTime);
                }
                BlueBandSpaceStatusLists.Add(BlueBandSpaceStatusList);
            }
        }
        private void GetOccupancyAccuracyCivicSmart()
        {
            int numRecords = timeStampRecords[0].Count();
            double totalStatus = numRecords * 10;
            double totalCorrectStatus = 0;
            List<double> AccuracyList = new List<double>();
            for (int space = 0; space < 10; space++)
            {
                double accuracy = 0;
                double correctStatus = 0;
                for (int timeStampIndex = 0; timeStampIndex < numRecords; timeStampIndex++)
                {
                    if (timeStampRecords[space][timeStampIndex][0, 1] == CivicSmartSpaceStatusLists[space][timeStampIndex][0, 1])
                    {
                        correctStatus++;
                    }
                }
                accuracy = Math.Round(correctStatus / numRecords * 100, 4);
                totalCorrectStatus = totalCorrectStatus + correctStatus;
                AccuracyList.Add(accuracy);
            }
            OccupancyAccuracy = Math.Round(totalCorrectStatus / totalStatus * 100, 2);
        }

        private void GetOccupancyAccuracyBlueBand()
        {
            int numRecords = timeStampRecords[0].Count();
            double totalStatus = numRecords * 10;
            double totalCorrectStatus = 0;
            List<double> AccuracyList = new List<double>();
            for (int space = 0; space < 10; space++)
            {
                double accuracy = 0;
                double correctStatus = 0;
                for (int timeStampIndex = 0; timeStampIndex < numRecords; timeStampIndex++)
                {
                    if (timeStampRecords[space][timeStampIndex][0, 1] == BlueBandSpaceStatusLists[9-space][timeStampIndex][0, 1])
                    {
                        correctStatus++;
                    }
                }
                accuracy = Math.Round(correctStatus / numRecords * 100, 4);
                totalCorrectStatus = totalCorrectStatus + correctStatus;
                AccuracyList.Add(accuracy);
            }
            OccupancyAccuracy = Math.Round(totalCorrectStatus / totalStatus * 100, 2);
        }
        private int CalculateMonthTimeStamp(byte month, byte day, byte hour, byte minute, byte second)
        {
            int timeStamp = Convert.ToInt32(month * 2678400 + day * 86400 + hour * 3600 + minute * 60 + second);
            return timeStamp;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            NumEvents = 0;
            Duration = 0;
            txtNumEvents.Clear();
            txtDuration.Clear();
            txtEventAccuracy.Clear();
            txtOccupancyAccuracy.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.InitialDirectory = System.Windows.Forms.Application.StartupPath;

            saveFileDialog.Filter = "Results Files (*.csv)|*.csv|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                FileIO.WriteOutPutTimeStamps(saveFileDialog.FileName, timeStampRecords, CivicSmartSpaceStatusLists);
            }
        }

        private void btnReadBlueBandFile_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.TruckDataOpenFile.InitialDirectory = @"C: \Users\w.sun2014\OneDrive - University of Florida\OD\Projects\TruckParking\Truck\Accuracy Tests";
                TruckDataOpenFile.ShowDialog();
                SourceDir = TruckDataOpenFile.FileName;
                lblBlueBandFolder.Text = SourceDir;
                BlueBandRecords = FileIO.ReadBlueBandDataFile(SourceDir);
                DataInputType = DataType.BlueBand;


            }
            catch (Exception)
            {
                MessageBox.Show("Please load a correct csv. file.", "Input Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtOffsetBlueBand_TextChanged(object sender, EventArgs e)
        {
            OffsetValueBlueBand = Convert.ToInt32(txtOffsetBlueBand.Text);
        }

        private void btnReadBlueBandReport_Click(object sender, EventArgs e)
        {
            try
            {
                this.TruckDataOpenFile.InitialDirectory = @"C: \Users\w.sun2014\OneDrive - University of Florida\OD\Projects\TruckParking\Truck\Accuracy Tests";
                TruckDataOpenFile.ShowDialog();
                SourceDir = TruckDataOpenFile.FileName;
                lblBlueBandFolder.Text = SourceDir;
                BlueBandReportRecords = FileIO.ReadBlueBandReportDataFile(SourceDir);
                DataInputType = DataType.BlueBandReport;

            }
            catch (Exception)
            {
                MessageBox.Show("Please load a correct csv. file.", "Input Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
