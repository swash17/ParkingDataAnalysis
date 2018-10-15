using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace TruckParkingDataAnalysis
{
    class FileIO
    {
        private static List<TruckParkingRecord> _recordList;
        private static List<SensysRecord> _sensysRecordList;
        private static List<IPsensRecord> _iPsensRecordList;
        private static List<CivicSmartRecordOld> _civicSmartRecordListOld;
        private static List<CivicSmartRecord> _civicSmartRecordList;
        private static List<BlueBandRecord> _blueBandRecordList;
        private static List<BlueBandReportRecord> _blueBandReportRecordList;
        public FileIO()
        {
            _recordList = RecordList;
            _sensysRecordList = SensysRecordList;
            _iPsensRecordList = IPsensRecordList;
            _civicSmartRecordListOld = CivicSmartRecordListOld;
            _civicSmartRecordList = CivicSmartRecordList;
            _blueBandRecordList = BlueBandRecordList;
            _blueBandReportRecordList = BlueBandReportRecordList;
        }

        public static List<TruckParkingRecord> RecordList
        {
            get
            {
                return _recordList;
            }

            set
            {
                _recordList = value;
            }
        }

        public static List<SensysRecord> SensysRecordList
        {
            get
            {
                return _sensysRecordList;
            }

            set
            {
                _sensysRecordList = value;
            }
        }

        public static List<IPsensRecord> IPsensRecordList
        {
            get
            {
                return _iPsensRecordList;
            }

            set
            {
                _iPsensRecordList = value;
            }
        }

        public static List<CivicSmartRecordOld> CivicSmartRecordListOld
        {
            get
            {
                return _civicSmartRecordListOld;
            }

            set
            {
                _civicSmartRecordListOld = value;
            }
        }

        public static List<CivicSmartRecord> CivicSmartRecordList
        {
            get
            {
                return _civicSmartRecordList;
            }

            set
            {
                _civicSmartRecordList = value;
            }
        }

        public static List<BlueBandRecord> BlueBandRecordList
        {
            get
            {
                return _blueBandRecordList;
            }

            set
            {
                _blueBandRecordList = value;
            }
        }

        public static List<BlueBandReportRecord> BlueBandReportRecordList
        {
            get
            {
                return _blueBandReportRecordList;
            }

            set
            {
                _blueBandReportRecordList = value;
            }
        }

        public static List<TruckParkingRecord> ReadTruckParkingDataFile(string fileName)
        {
            string fileNameOnly = Path.GetFileName(fileName);
            string ParkingRecord;
            string[] ParkingRecordArr = new string[60];
            int checkIndex = 0;
            bool SkipRecord;
            byte NumberOfHeaderLines = 4;
            RecordList = new List<TruckParkingRecord>();

            StreamReader sr = new StreamReader(fileName);

            //Read header line of .csv file 
            for (int i = 0; i < NumberOfHeaderLines; i++)
                sr.ReadLine();

            while ((ParkingRecord = sr.ReadLine()) != null)  // read a line of text
            {
                SkipRecord = false;
                TruckParkingRecord NewRecord = new TruckParkingRecord();
                ParkingRecordArr = ParkingRecord.Split(',');  //parse the record into fields, based on comma delimitation
                if(ParkingRecordArr[0] == "")
                {
                    SkipRecord = true;
                }
                if (SkipRecord == false)
                {
                    string DateInfo = ParkingRecordArr[0];
                    string[] DateInfoArr = DateInfo.Split('-', '/');
                    NewRecord.Date = ParkingRecordArr[0];
                    NewRecord.Month = Convert.ToByte(DateInfoArr[0]);
                    NewRecord.Day = Convert.ToByte(DateInfoArr[1]);
                    NewRecord.Year = Convert.ToInt32(DateInfoArr[2]);
                    string TimeInfo = "";

                    if (ParkingRecordArr[3] != "")
                    {
                        TimeInfo = ParkingRecordArr[3];
                        NewRecord.IsComingIn = true;
                    }
                    else if (ParkingRecordArr[3] == "" && ParkingRecordArr[4] != "")
                    {
                        TimeInfo = ParkingRecordArr[4];
                        NewRecord.IsComingIn = false;
                    }
                    string[] TimeInfoArr = TimeInfo.Split(':');
                    NewRecord.Time = TimeInfo;
                    NewRecord.Hour = Convert.ToByte(TimeInfoArr[0]);
                    NewRecord.Minute = Convert.ToByte(TimeInfoArr[1]);
                    NewRecord.Second = Convert.ToByte(TimeInfoArr[2]);
                    NewRecord.HourTimeStamp = Convert.ToInt32(NewRecord.Hour * 3600 + NewRecord.Minute * 60 + NewRecord.Second);

                    NewRecord.DayTimeStamp = Convert.ToInt32(NewRecord.Day * 86400 + NewRecord.Hour * 3600 + NewRecord.Minute * 60 + NewRecord.Second);
                    NewRecord.MonthTimeStamp = Convert.ToInt32(NewRecord.Month*2678400+NewRecord.Day * 86400 + NewRecord.Hour * 3600 + NewRecord.Minute * 60 + NewRecord.Second);
                    //one month=31 days
                    NewRecord.TruckID = Convert.ToInt32(ParkingRecordArr[1]);
                    NewRecord.SpaceNumber = Convert.ToByte(ParkingRecordArr[2]);
                    NewRecord.Class = Convert.ToByte(ParkingRecordArr[5]);
                    NewRecord.Alignment = Convert.ToString(ParkingRecordArr[6]);
                    NewRecord.TruckLabel = Convert.ToString(ParkingRecordArr[7]);
                    checkIndex++;
                    RecordList.Add(NewRecord);
                }

            }
            return RecordList;

        }


        public static List<IPsensRecord> ReadIPsensDataFile(string fileName)
        {
            string fileNameOnly = Path.GetFileName(fileName);
            string ParkingRecord;
            string[] ParkingRecordArr = new string[60];

            bool SkipRecord;
            byte NumberOfHeaderLines = 1;
            IPsensRecordList = new List<IPsensRecord>();

            StreamReader sr = new StreamReader(fileName);

            //Read header line of .csv file 
            for (int i = 0; i < NumberOfHeaderLines; i++)
                sr.ReadLine();

            while ((ParkingRecord = sr.ReadLine()) != null)  // read a line of text
            {
                SkipRecord = false;
                IPsensRecord NewRecord = new IPsensRecord();
                ParkingRecordArr = ParkingRecord.Split(',');  //parse the record into fields, based on comma delimitation

                if (SkipRecord == false)
                {
                    NewRecord.SpaceNumber = Convert.ToByte(ParkingRecordArr[3]);
                    string EnterDateTime = ParkingRecordArr[5];
                    string[] EnterDateTimeInfoArr = EnterDateTime.Split('/',' ',':');
                    NewRecord.EnterMonth = Convert.ToByte(EnterDateTimeInfoArr[0]); 
                    NewRecord.EnterDay = Convert.ToByte(EnterDateTimeInfoArr[1]);
                    NewRecord.EnterYear = Convert.ToInt32(EnterDateTimeInfoArr[2]);
                    //NewRecord.EnterHour = Convert.ToByte(EnterDateTimeInfoArr[3]);
                    if (EnterDateTimeInfoArr[6] == "AM")
                    {
                        if(Convert.ToByte(EnterDateTimeInfoArr[3]) == 12) // 12:00-1:00 AM
                        {
                            NewRecord.EnterHour = Convert.ToByte(Convert.ToByte(EnterDateTimeInfoArr[3])-12);
                        }else
                        {
                            NewRecord.EnterHour = Convert.ToByte(EnterDateTimeInfoArr[3]);
                        }
                        
                    }
                    else
                    {
                        if (Convert.ToByte(EnterDateTimeInfoArr[3]) == 12) // 12:00-1:00 PM
                        {
                            NewRecord.EnterHour = Convert.ToByte(EnterDateTimeInfoArr[3]);
                        }else
                        {
                            NewRecord.EnterHour = Convert.ToByte(Convert.ToByte(EnterDateTimeInfoArr[3]) + 12);
                        }        
                    }

                    NewRecord.EnterMinute = Convert.ToByte(EnterDateTimeInfoArr[4]);
                    NewRecord.EnterSecond = Convert.ToByte(EnterDateTimeInfoArr[5]);
                    string ExistDateTime = ParkingRecordArr[7];
                    string[] ExistDateTimeInfoArr = ExistDateTime.Split('/', ' ',':');
                    NewRecord.ExistMonth = Convert.ToByte(ExistDateTimeInfoArr[0]);
                    NewRecord.ExistDay = Convert.ToByte(ExistDateTimeInfoArr[1]);
                    NewRecord.ExistYear = Convert.ToInt32(ExistDateTimeInfoArr[2]);
                    //NewRecord.ExistHour = Convert.ToByte(ExistDateTimeInfoArr[3]);
                    if (ExistDateTimeInfoArr[6] == "AM")
                    {
                        if (Convert.ToByte(ExistDateTimeInfoArr[3]) == 12) // 12:00-1:00 AM
                        {
                            NewRecord.ExistHour = Convert.ToByte(Convert.ToByte(ExistDateTimeInfoArr[3]) - 12);
                        }
                        else
                        {
                            NewRecord.ExistHour = Convert.ToByte(ExistDateTimeInfoArr[3]);
                        }
                    }
                    else
                    {
                        if (Convert.ToByte(ExistDateTimeInfoArr[3]) == 12) // 12:00-1:00 PM
                        {
                            NewRecord.ExistHour = Convert.ToByte(ExistDateTimeInfoArr[3]);
                        }
                        else
                        {
                            NewRecord.ExistHour = Convert.ToByte(Convert.ToByte(ExistDateTimeInfoArr[3]) + 12);
                        }
                    }
                    NewRecord.ExistMinute = Convert.ToByte(ExistDateTimeInfoArr[4]);
                    NewRecord.ExistSecond = Convert.ToByte(ExistDateTimeInfoArr[5]);

                    NewRecord.EnterHourTimeStamp = Convert.ToInt32(NewRecord.EnterHour * 3600 + NewRecord.EnterMinute * 60 + NewRecord.EnterSecond);
                    NewRecord.EnterDayTimeStamp = Convert.ToInt32(NewRecord.EnterDay * 86400 + NewRecord.EnterHour * 3600 + NewRecord.EnterMinute * 60 + NewRecord.EnterSecond);
                    NewRecord.EnterMonthTimeStamp = Convert.ToInt32(NewRecord.EnterMonth * 2678400 + NewRecord.EnterDay * 86400 + NewRecord.EnterHour * 3600 + NewRecord.EnterMinute * 60 + NewRecord.EnterSecond);

                    NewRecord.ExistHourTimeStamp = Convert.ToInt32(NewRecord.ExistHour * 3600 + NewRecord.ExistMinute * 60 + NewRecord.ExistSecond);
                    NewRecord.ExistDayTimeStamp = Convert.ToInt32(NewRecord.ExistDay * 86400 + NewRecord.ExistHour * 3600 + NewRecord.ExistMinute * 60 + NewRecord.ExistSecond);
                    NewRecord.ExistMonthTimeStamp = Convert.ToInt32(NewRecord.ExistMonth * 2678400 + NewRecord.ExistDay * 86400 + NewRecord.ExistHour * 3600 + NewRecord.ExistMinute * 60 + NewRecord.ExistSecond);
                    //one month=31 days (August)

                    IPsensRecordList.Add(NewRecord);
                }

            }
            return IPsensRecordList;

        }

        public static List<BlueBandRecord> ReadBlueBandDataFile(string fileName)
        {
            string fileNameOnly = Path.GetFileName(fileName);
            string ParkingRecord;
            string[] ParkingRecordArr = new string[60];

            bool SkipRecord;
            byte NumberOfHeaderLines = 1;
            BlueBandRecordList = new List<BlueBandRecord>();

            StreamReader sr = new StreamReader(fileName);

            //Read header line of .csv file 
            for (int i = 0; i < NumberOfHeaderLines; i++)
                sr.ReadLine();

            while ((ParkingRecord = sr.ReadLine()) != null)  // read a line of text
            {
                SkipRecord = false;
                BlueBandRecord NewRecord = new BlueBandRecord();
                ParkingRecordArr = ParkingRecord.Split(',');  //parse the record into fields, based on comma delimitation

                if (SkipRecord == false)
                {
                    NewRecord.Year = Convert.ToInt16(ParkingRecordArr[0]);
                    NewRecord.Month = Convert.ToByte(ParkingRecordArr[1]);
                    NewRecord.Day = Convert.ToByte(ParkingRecordArr[2]);
                    NewRecord.Hour = Convert.ToByte(ParkingRecordArr[3]);
                    NewRecord.Minute = Convert.ToByte(ParkingRecordArr[4]);
                    string[] second = ParkingRecordArr[5].Split('.');
                    NewRecord.Second = Convert.ToByte(second[0]);
                    NewRecord.SensorAddress = ParkingRecordArr[6];
                    if(NewRecord.SensorAddress == "A0:E6:F8:2C:D2:A5")
                    {
                        NewRecord.SpaceNumber = 1;
                        NewRecord.SensorID = 1;                        
                    }
                    else if (NewRecord.SensorAddress == "A0:E6:F8:2B:32:A5")
                    {
                        NewRecord.SpaceNumber = 1;
                        NewRecord.SensorID = 2;
                    }
                    else if (NewRecord.SensorAddress == "A0:E6:F8:2B:2F:D0")
                    {
                        NewRecord.SpaceNumber = 2;
                        NewRecord.SensorID = 3;
                    }
                    else if (NewRecord.SensorAddress == "A0:E6:F8:2B:32:91")
                    {
                        NewRecord.SpaceNumber = 2;
                        NewRecord.SensorID = 4;
                    }
                    else if (NewRecord.SensorAddress == "A0:E6:F8:2C:D0:F9")
                    {
                        NewRecord.SpaceNumber = 3;
                        NewRecord.SensorID = 5;
                    }
                    else if (NewRecord.SensorAddress == "A0:E6:F8:2C:C4:55")
                    {
                        NewRecord.SpaceNumber = 3;
                        NewRecord.SensorID = 6;
                    }
                    else if (NewRecord.SensorAddress == "A0:E6:F8:2B:2F:BE")
                    {
                        NewRecord.SpaceNumber = 4;
                        NewRecord.SensorID = 7;
                    }
                    else if (NewRecord.SensorAddress == "A0:E6:F8:2C:D0:F3")
                    {
                        NewRecord.SpaceNumber = 4;
                        NewRecord.SensorID = 8;
                    }
                    else if (NewRecord.SensorAddress == "A0:E6:F8:2C:D2:9E")
                    {
                        NewRecord.SpaceNumber = 5;
                        NewRecord.SensorID = 9;
                    }
                    else if (NewRecord.SensorAddress == "A0:E6:F8:2B:32:97")
                    {
                        NewRecord.SpaceNumber = 5;
                        NewRecord.SensorID = 10;
                    }
                    //Dec 28
                    //else if (NewRecord.SensorAddress == "A0:E6:F8:2C:D0:D5")
                    //{
                    //    NewRecord.SpaceNumber = 5;
                    //    NewRecord.SensorID = 10;
                    //}
                    else if (NewRecord.SensorAddress == "A0:E6:F8:2B:32:9E")
                    {
                        NewRecord.SpaceNumber = 6;
                        NewRecord.SensorID = 11;
                    }
                    //Dec 28
                    //else if (NewRecord.SensorAddress == "A0:E6:F8:2C:D0:F8")
                    //{
                    //    NewRecord.SpaceNumber = 6;
                    //    NewRecord.SensorID = 11;
                    //}
                    else if (NewRecord.SensorAddress == "A0:E6:F8:2B:32:9B")
                    {
                        NewRecord.SpaceNumber = 6;
                        NewRecord.SensorID = 12;
                    }
                    //Dec 28
                    //else if (NewRecord.SensorAddress == "A0:E6:F8:2C:C4:4D")
                    //{
                    //    NewRecord.SpaceNumber = 6;
                    //    NewRecord.SensorID = 12;
                    //}
                    else if (NewRecord.SensorAddress == "A0:E6:F8:2C:D2:CD")
                    {
                        NewRecord.SpaceNumber = 7;
                        NewRecord.SensorID = 13;
                    }
                    else if (NewRecord.SensorAddress == "A0:E6:F8:2C:D0:CD")
                    {
                        NewRecord.SpaceNumber = 7;
                        NewRecord.SensorID = 14;
                    }
                    else if (NewRecord.SensorAddress == "A0:E6:F8:2B:2F:A4")
                    {
                        NewRecord.SpaceNumber = 8;
                        NewRecord.SensorID = 15;
                    }
                    else if (NewRecord.SensorAddress == "A0:E6:F8:2C:D0:F1")
                    {
                        NewRecord.SpaceNumber = 8;
                        NewRecord.SensorID = 16;
                    }
                    else if (NewRecord.SensorAddress == "A0:E6:F8:2B:2F:DC")
                    {
                        NewRecord.SpaceNumber = 9;
                        NewRecord.SensorID = 17;
                    }
                    else if (NewRecord.SensorAddress == "A0:E6:F8:2B:2F:C7")
                    {
                        NewRecord.SpaceNumber = 9;
                        NewRecord.SensorID = 18;
                    }
                    //10th Jan Dec 28
                    //else if (NewRecord.SensorAddress == "A0:E6:F8:2C:D0:E1")
                    //{
                    //    NewRecord.SpaceNumber = 9;
                    //    NewRecord.SensorID = 18;
                    //}
                    else if (NewRecord.SensorAddress == "A0:E6:F8:2B:32:9F")
                    {
                        NewRecord.SpaceNumber = 10;
                        NewRecord.SensorID = 19;
                    }
                    else if (NewRecord.SensorAddress == "A0:E6:F8:2C:C4:53")
                    {
                        NewRecord.SpaceNumber = 10;
                        NewRecord.SensorID = 20;
                    }
                    else
                    {
                        MessageBox.Show(NewRecord.SensorAddress.ToString() + "are not matching for the current system.");
                        break;
                    }

                    string[] EventInfo = ParkingRecordArr[7].Split(':');
                    if(EventInfo[3] == " OCC")
                    {
                        NewRecord.ParkingStatus = 0; //out
                    }
                    else
                    {
                        NewRecord.ParkingStatus = 1; //in
                    }
  

                    NewRecord.HourTimeStamp = Convert.ToInt32(NewRecord.Hour * 3600 + NewRecord.Minute * 60 + NewRecord.Second);
                    NewRecord.DayTimeStamp = Convert.ToInt32(NewRecord.Day * 86400 + NewRecord.Hour * 3600 + NewRecord.Minute * 60 + NewRecord.Second);
                    NewRecord.MonthTimeStamp = Convert.ToInt32(NewRecord.Month * 2678400 + NewRecord.Day * 86400 + NewRecord.Hour * 3600 + NewRecord.Minute * 60 + NewRecord.Second);

                    BlueBandRecordList.Add(NewRecord);
                }

            }
            return BlueBandRecordList;

        }

        public static List<BlueBandReportRecord> ReadBlueBandReportDataFile(string fileName)
        {
            string fileNameOnly = Path.GetFileName(fileName);
            string ParkingRecord;
            string[] ParkingRecordArr = new string[60];

            bool SkipRecord;
            byte NumberOfHeaderLines = 1;
            BlueBandReportRecordList = new List<BlueBandReportRecord>();

            StreamReader sr = new StreamReader(fileName);

            //Read header line of .csv file 
            for (int i = 0; i < NumberOfHeaderLines; i++)
                sr.ReadLine();

            while ((ParkingRecord = sr.ReadLine()) != null)  // read a line of text
            {
                SkipRecord = false;
                BlueBandReportRecord NewRecord = new BlueBandReportRecord();
                ParkingRecordArr = ParkingRecord.Split(',');  //parse the record into fields, based on comma delimitation

                if (SkipRecord == false)
                {
                    string[] EntryTimeArr = ParkingRecordArr[0].Split('-','T',':','.');
                    NewRecord.EnterYear = Convert.ToInt16(EntryTimeArr[0]);
                    NewRecord.EnterMonth = Convert.ToByte(EntryTimeArr[1]);
                    NewRecord.EnterDay = Convert.ToByte(EntryTimeArr[2]);
                    NewRecord.EnterHour = Convert.ToByte(EntryTimeArr[3]);
                    NewRecord.EnterMinute = Convert.ToByte(EntryTimeArr[4]);
                    NewRecord.EnterSecond = Convert.ToByte(EntryTimeArr[5]);

                    string[] ExitTimeArr = ParkingRecordArr[1].Split('-', 'T', ':', '.');
                    NewRecord.ExitYear = Convert.ToInt16(ExitTimeArr[0]);
                    NewRecord.ExitMonth = Convert.ToByte(ExitTimeArr[1]);
                    NewRecord.ExitDay = Convert.ToByte(ExitTimeArr[2]);
                    NewRecord.ExitHour = Convert.ToByte(ExitTimeArr[3]);
                    NewRecord.ExitMinute = Convert.ToByte(ExitTimeArr[4]);
                    NewRecord.ExitSecond = Convert.ToByte(ExitTimeArr[5]);

                    string[] LaneArr = ParkingRecordArr[3].Split('.');
                    NewRecord.SpaceNumber = Convert.ToByte(LaneArr[0]);
                    NewRecord.SensorNumber = Convert.ToByte(LaneArr[1]);

                    NewRecord.EnterHourTimeStamp = Convert.ToInt32(NewRecord.EnterHour * 3600 + NewRecord.EnterMinute * 60 + NewRecord.EnterSecond);
                    NewRecord.EnterDayTimeStamp = Convert.ToInt32(NewRecord.EnterDay * 86400 + NewRecord.EnterHour * 3600 + NewRecord.EnterMinute * 60 + NewRecord.EnterSecond);
                    NewRecord.EnterMonthTimeStamp = Convert.ToInt32(NewRecord.EnterMonth * 2678400 + NewRecord.EnterDay * 86400 + NewRecord.EnterHour * 3600 + NewRecord.EnterMinute * 60 + NewRecord.EnterSecond);

                    NewRecord.ExitHourTimeStamp = Convert.ToInt32(NewRecord.ExitHour * 3600 + NewRecord.ExitDay * 60 + NewRecord.ExitSecond);
                    NewRecord.ExitDayTimeStamp = Convert.ToInt32(NewRecord.ExitDay * 86400 + NewRecord.ExitHour * 3600 + NewRecord.ExitMinute * 60 + NewRecord.ExitSecond);
                    NewRecord.ExitMonthTimeStamp = Convert.ToInt32(NewRecord.ExitMonth * 2678400 + NewRecord.ExitDay * 86400 + NewRecord.ExitHour * 3600 + NewRecord.ExitMinute * 60 + NewRecord.ExitSecond);

                    BlueBandReportRecordList.Add(NewRecord);
                }

            }
            return BlueBandReportRecordList;

        }
        public static List<CivicSmartRecord> ReadCivicSmartDataFile(string fileName)
        {   
            string fileNameOnly = Path.GetFileName(fileName);
            string ParkingRecord;
            string[] ParkingRecordArr = new string[60];

            bool SkipRecord;
            byte NumberOfHeaderLines = 1;
            CivicSmartRecordList = new List<CivicSmartRecord>();
            StreamReader sr = new StreamReader(fileName);

            //Read header line of .csv file 
            for (int i = 0; i < NumberOfHeaderLines; i++)
                sr.ReadLine();

            while ((ParkingRecord = sr.ReadLine()) != null)  // read a line of text
            {
                SkipRecord = false;
                CivicSmartRecord NewRecord = new CivicSmartRecord();
                ParkingRecordArr = ParkingRecord.Split(',');  //parse the record into fields, based on comma delimitation
                if (SkipRecord == false)
                {
                    NewRecord.MeterID = Convert.ToInt32(ParkingRecordArr[3]);
                    NewRecord.SensorStatus = ParkingRecordArr[1];
                    if(NewRecord.SensorStatus == "Vacant")
                    {
                        NewRecord.ParkingStatus = 0;
                        
                    }
                    else if (NewRecord.SensorStatus == "Occupied")
                    {
                        NewRecord.ParkingStatus = 1;
                    }
                    NewRecord.SensorID = NewRecord.MeterID - 32000;
                    if (NewRecord.MeterID == 32001 || NewRecord.MeterID == 32002)
                    {
                        NewRecord.SpaceNumber = 11;
                    }
                    else if (NewRecord.MeterID == 32003 || NewRecord.MeterID == 32004)
                    {
                        NewRecord.SpaceNumber = 12;
                    }
                    else if (NewRecord.MeterID == 32005 || NewRecord.MeterID == 32006)
                    {
                        NewRecord.SpaceNumber = 13;
                    }
                    else if (NewRecord.MeterID == 32007 || NewRecord.MeterID == 32008)
                    {
                        NewRecord.SpaceNumber = 14;
                    }
                    else if (NewRecord.MeterID == 32009 || NewRecord.MeterID == 32010)
                    {
                        NewRecord.SpaceNumber = 15;
                    }
                    else if (NewRecord.MeterID == 32011 || NewRecord.MeterID == 32012)
                    {
                        NewRecord.SpaceNumber = 16;
                    }
                    else if (NewRecord.MeterID == 32013 || NewRecord.MeterID == 32014)
                    {
                        NewRecord.SpaceNumber = 17;
                    }
                    else if (NewRecord.MeterID == 32015 || NewRecord.MeterID == 32016)
                    {
                        NewRecord.SpaceNumber = 18;
                    }
                    else if (NewRecord.MeterID == 32017 || NewRecord.MeterID == 32018)
                    {
                        NewRecord.SpaceNumber = 19;
                    }
                    else if (NewRecord.MeterID == 32019 || NewRecord.MeterID == 32020)
                    {
                        NewRecord.SpaceNumber = 20;
                    }
                    string DateTime = ParkingRecordArr[2];
                    string[] DateTimeInfoArr = DateTime.Split('/', ' ', ':');
                    NewRecord.Day = Convert.ToByte(DateTimeInfoArr[0]);
                    NewRecord.Month = Convert.ToByte(DateTimeInfoArr[1]);             
                    NewRecord.Year = Convert.ToInt32(DateTimeInfoArr[2]);
                    NewRecord.Hour = Convert.ToByte(DateTimeInfoArr[3]);
                    NewRecord.Minute = Convert.ToByte(DateTimeInfoArr[4]);
                    NewRecord.Second = Convert.ToByte(DateTimeInfoArr[5]);

                    NewRecord.HourTimeStamp = Convert.ToInt32(NewRecord.Hour * 3600 + NewRecord.Minute * 60 + NewRecord.Second);
                    NewRecord.DayTimeStamp = Convert.ToInt32(NewRecord.Day * 86400 + NewRecord.Hour * 3600 + NewRecord.Minute * 60 + NewRecord.Second);
                    NewRecord.MonthTimeStamp = Convert.ToInt32(NewRecord.Month * 2678400 + NewRecord.Day * 86400 + NewRecord.Hour * 3600 + NewRecord.Minute * 60 + NewRecord.Second);

                    //one month=31 days (August)

                    CivicSmartRecordList.Add(NewRecord);
                }
            }
            return CivicSmartRecordList;
        }
        public static List<CivicSmartRecordOld> ReadCivicSmartDataFileOld(string fileName)
        {
            string fileNameOnly = Path.GetFileName(fileName);
            string ParkingRecord;
            string[] ParkingRecordArr = new string[60];

            bool SkipRecord;
            byte NumberOfHeaderLines = 1;
            CivicSmartRecordListOld = new List<CivicSmartRecordOld>();

            StreamReader sr = new StreamReader(fileName);

            //Read header line of .csv file 
            for (int i = 0; i < NumberOfHeaderLines; i++)
                sr.ReadLine();

            while ((ParkingRecord = sr.ReadLine()) != null)  // read a line of text
            {
                SkipRecord = false;
                CivicSmartRecordOld NewRecord = new CivicSmartRecordOld();
                ParkingRecordArr = ParkingRecord.Split(',');  //parse the record into fields, based on comma delimitation

                if (SkipRecord == false)
                {
                    string Sensor = ParkingRecordArr[1];
                    string[] SensorInfoArr = Sensor.Split(' ');
                    NewRecord.SensorNumber = Convert.ToByte(SensorInfoArr[1]);
                    if(NewRecord.SensorNumber == 1 || NewRecord.SensorNumber == 2)
                    {
                        NewRecord.SpaceNumber = 11;
                    }
                    else if (NewRecord.SensorNumber == 3 || NewRecord.SensorNumber == 4)
                    {
                        NewRecord.SpaceNumber = 12;
                    }
                    else if (NewRecord.SensorNumber == 5 || NewRecord.SensorNumber == 6)
                    {
                        NewRecord.SpaceNumber = 13;
                    }
                    else if (NewRecord.SensorNumber == 7 || NewRecord.SensorNumber == 8)
                    {
                        NewRecord.SpaceNumber = 14;
                    }
                    else if (NewRecord.SensorNumber == 9 || NewRecord.SensorNumber == 10)
                    {
                        NewRecord.SpaceNumber = 15;
                    }
                    else if (NewRecord.SensorNumber == 11 || NewRecord.SensorNumber == 12)
                    {
                        NewRecord.SpaceNumber = 16;
                    }
                    else if (NewRecord.SensorNumber == 13 || NewRecord.SensorNumber == 14)
                    {
                        NewRecord.SpaceNumber = 17;
                    }
                    else if (NewRecord.SensorNumber == 15 || NewRecord.SensorNumber == 16)
                    {
                        NewRecord.SpaceNumber = 18;
                    }
                    else if (NewRecord.SensorNumber == 17 || NewRecord.SensorNumber == 18)
                    {
                        NewRecord.SpaceNumber = 19;

                    }
                    else if (NewRecord.SensorNumber == 19 || NewRecord.SensorNumber == 20)
                    {
                        NewRecord.SpaceNumber = 20;
                    }
                    string EnterDateTime = ParkingRecordArr[0];
                    string[] EnterDateTimeInfoArr = EnterDateTime.Split('/', ' ', ':');
                    NewRecord.EnterMonth = Convert.ToByte(EnterDateTimeInfoArr[0]);
                    NewRecord.EnterDay = Convert.ToByte(EnterDateTimeInfoArr[1]);
                    NewRecord.EnterYear = Convert.ToInt32(EnterDateTimeInfoArr[2]);
                    NewRecord.EnterHour = Convert.ToByte(EnterDateTimeInfoArr[3]);
                    NewRecord.EnterMinute = Convert.ToByte(EnterDateTimeInfoArr[4]);
                    NewRecord.EnterSecond = Convert.ToByte(EnterDateTimeInfoArr[5]);
                    string ExistDateTime = ParkingRecordArr[9];
                    string[] ExistDateTimeInfoArr = ExistDateTime.Split('/', ' ', ':');
                    NewRecord.ExitMonth = Convert.ToByte(ExistDateTimeInfoArr[0]);
                    NewRecord.ExitDay = Convert.ToByte(ExistDateTimeInfoArr[1]);
                    NewRecord.ExitYear = Convert.ToInt32(ExistDateTimeInfoArr[2]);
                    NewRecord.ExitHour = Convert.ToByte(ExistDateTimeInfoArr[3]);
                    NewRecord.ExitMinute = Convert.ToByte(ExistDateTimeInfoArr[4]);
                    NewRecord.ExitSecond = Convert.ToByte(ExistDateTimeInfoArr[5]);

                    NewRecord.EnterHourTimeStamp = Convert.ToInt32(NewRecord.EnterHour * 3600 + NewRecord.EnterMinute * 60 + NewRecord.EnterSecond);
                    NewRecord.EnterDayTimeStamp = Convert.ToInt32(NewRecord.EnterDay * 86400 + NewRecord.EnterHour * 3600 + NewRecord.EnterMinute * 60 + NewRecord.EnterSecond);
                    NewRecord.EnterMonthTimeStamp = Convert.ToInt32(NewRecord.EnterMonth * 2678400 + NewRecord.EnterDay * 86400 + NewRecord.EnterHour * 3600 + NewRecord.EnterMinute * 60 + NewRecord.EnterSecond);

                    NewRecord.ExitHourTimeStamp = Convert.ToInt32(NewRecord.ExitHour * 3600 + NewRecord.ExitMinute * 60 + NewRecord.ExitSecond);
                    NewRecord.ExitDayTimeStamp = Convert.ToInt32(NewRecord.ExitDay * 86400 + NewRecord.ExitHour * 3600 + NewRecord.ExitMinute * 60 + NewRecord.ExitSecond);
                    NewRecord.ExitMonthTimeStamp = Convert.ToInt32(NewRecord.ExitMonth * 2678400 + NewRecord.ExitDay * 86400 + NewRecord.ExitHour * 3600 + NewRecord.ExitMinute * 60 + NewRecord.ExitSecond);
                    //one month=31 days (August)

                    CivicSmartRecordListOld.Add(NewRecord);
                }

            }
            return CivicSmartRecordListOld;

        }
        public static List<SensysRecord> ReadSensysDataFile(string fileName)
        {
            string fileNameOnly = Path.GetFileName(fileName);
            string ParkingRecord;
            string[] ParkingRecordArr = new string[60];

            bool SkipRecord;
            byte NumberOfHeaderLines = 1;
            SensysRecordList = new List<SensysRecord>();

            StreamReader sr = new StreamReader(fileName);

            //Read header line of .csv file 
            for (int i = 0; i < NumberOfHeaderLines; i++)
                sr.ReadLine();

            while ((ParkingRecord = sr.ReadLine()) != null)  // read a line of text
            {
                SkipRecord = false;
                SensysRecord NewRecord = new SensysRecord();
                ParkingRecordArr = ParkingRecord.Split(',');  //parse the record into fields, based on comma delimitation

                if (SkipRecord == false)
                {
                    string DateInfo = ParkingRecordArr[0];
                    string[] DateInfoArr = DateInfo.Split(' ',':');
                    byte month = 0;
                    if (DateInfoArr[1] == "Aug")
                    {
                        month = 8;
                    }
                    else if(DateInfoArr[1] == "Sep")
                    {
                        month = 9;
                    }
                    else if(DateInfoArr[1] == "Oct")
                    {
                        month = 10;
                    }
                    else if(DateInfoArr[1] == "Nov")
                    {
                        month = 11;
                    }
                    else if(DateInfoArr[1] == "Dec")
                    {
                        month = 12;
                    }
                    NewRecord.Month = month;
                    NewRecord.Day = Convert.ToByte(DateInfoArr[3]);
                    NewRecord.Hour = Convert.ToByte(DateInfoArr[4]);
                    NewRecord.Minute = Convert.ToByte(DateInfoArr[5]);
                    NewRecord.Second = Convert.ToByte(DateInfoArr[6]);
                    NewRecord.Year = Convert.ToInt32(DateInfoArr[7]);
                    NewRecord.Space1A = Convert.ToInt16(ParkingRecordArr[2]);
                    NewRecord.Space1B = Convert.ToInt16(ParkingRecordArr[3]);
                    NewRecord.Space1C = Convert.ToInt16(ParkingRecordArr[4]);
                    NewRecord.Space2A = Convert.ToInt16(ParkingRecordArr[5]);
                    NewRecord.Space2B = Convert.ToInt16(ParkingRecordArr[6]);
                    NewRecord.Space2C = Convert.ToInt16(ParkingRecordArr[7]);
                    NewRecord.Space3A = Convert.ToInt16(ParkingRecordArr[8]);
                    NewRecord.Space3B = Convert.ToInt16(ParkingRecordArr[9]);
                    NewRecord.Space3C = Convert.ToInt16(ParkingRecordArr[10]);
                    NewRecord.Space4A = Convert.ToInt16(ParkingRecordArr[11]);
                    NewRecord.Space4B = Convert.ToInt16(ParkingRecordArr[12]);
                    NewRecord.Space4C = Convert.ToInt16(ParkingRecordArr[13]);
                    NewRecord.Space5A = Convert.ToInt16(ParkingRecordArr[14]);
                    NewRecord.Space5B = Convert.ToInt16(ParkingRecordArr[15]);
                    NewRecord.Space5C = Convert.ToInt16(ParkingRecordArr[16]);
                    NewRecord.Space6A = Convert.ToInt16(ParkingRecordArr[17]);
                    NewRecord.Space6B = Convert.ToInt16(ParkingRecordArr[18]);
                    NewRecord.Space6C = Convert.ToInt16(ParkingRecordArr[19]);
                    NewRecord.Space7A = Convert.ToInt16(ParkingRecordArr[20]);
                    NewRecord.Space7B = Convert.ToInt16(ParkingRecordArr[21]);
                    NewRecord.Space7C = Convert.ToInt16(ParkingRecordArr[22]);
                    NewRecord.Space8A = Convert.ToInt16(ParkingRecordArr[23]);
                    NewRecord.Space8B = Convert.ToInt16(ParkingRecordArr[24]);
                    NewRecord.Space8C = Convert.ToInt16(ParkingRecordArr[25]);
                    NewRecord.Space9A = Convert.ToInt16(ParkingRecordArr[26]);
                    NewRecord.Space9B = Convert.ToInt16(ParkingRecordArr[27]);
                    NewRecord.Space9C = Convert.ToInt16(ParkingRecordArr[28]);
                    NewRecord.Space10A = Convert.ToInt16(ParkingRecordArr[29]);
                    NewRecord.Space10B = Convert.ToInt16(ParkingRecordArr[30]);
                    NewRecord.Space10C = Convert.ToInt16(ParkingRecordArr[31]);
                    NewRecord.HourTimeStamp = Convert.ToInt32(NewRecord.Hour * 3600 + NewRecord.Minute * 60 + NewRecord.Second);

                    NewRecord.DayTimeStamp = Convert.ToInt32(NewRecord.Day * 86400 + NewRecord.Hour * 3600 + NewRecord.Minute * 60 + NewRecord.Second);
                    NewRecord.MonthTimeStamp = Convert.ToInt32(NewRecord.Month * 2678400 + NewRecord.Day * 86400 + NewRecord.Hour * 3600 + NewRecord.Minute * 60 + NewRecord.Second);
                    //one month=31 days

                    SensysRecordList.Add(NewRecord);
                }

            }
            return SensysRecordList;

        }
        public static void WriteOutputs(string filename, List<List<int[,]>> timeStampRecordsImport)
        {
            List<List<int[,]>> timeStampRecords = new List<List<int[,]>>();
            //List<TruckParkingRecord> Records = new List<TruckParkingRecord>();
            timeStampRecords = timeStampRecordsImport;
            byte NumOfSpots = 10; //default
            StreamWriter sw = new StreamWriter(filename);
            sw.Write("Date, Time, Space1,Space2,Space3,Space4,Space5,Space6,Space7,Space8,Space9,Space10");
            sw.WriteLine();
            int totRecords = timeStampRecords[0].Count();
            double Month = new int();
            double Day = new int();
            double Hour = new int();
            double Minute = new int();
            double Second = new int();
            for (int RecordsNum = 0; RecordsNum < totRecords; RecordsNum++)
            {
                Month = Math.Floor((double)timeStampRecords[0][RecordsNum][0, 0] / 2678400);
                Day = Math.Floor((double)(timeStampRecords[0][RecordsNum][0, 0] - Month * 2678400) / 86400);
                Hour = Math.Floor((double)(timeStampRecords[0][RecordsNum][0, 0] - Month * 2678400 - Day * 86400) / 3600);
                Minute = Math.Floor((double)(timeStampRecords[0][RecordsNum][0, 0] - Month * 2678400 - Day * 86400 - Hour * 3600) / 60);
                Second = (double)(timeStampRecords[0][RecordsNum][0, 0] - Month * 2678400 - Day * 86400 - Hour * 3600 - Minute * 60);
                sw.Write(Day.ToString() + "/" + Month.ToString() + "/16");
                sw.Write(",");
                sw.Write(Hour.ToString() + ":" + Minute.ToString() + ":" + Second.ToString());
                sw.Write(",");
                for (int SpotsNum = 0; SpotsNum < NumOfSpots; SpotsNum++)
                {
                    sw.Write(timeStampRecords[SpotsNum][RecordsNum][0, 1].ToString());
                    sw.Write(",");
                }
                sw.WriteLine();
            }
            
            //    for (int SpotsNum = 0; SpotsNum < NumOfSpots; SpotsNum++)
            //{
            //    for (int RecordsNum = 0; RecordsNum < totRecords; RecordsNum++)
            //    {
            //        Month = Math.Floor((double)timeStampRecords[SpotsNum][RecordsNum][0, 0]/ 2678400);
            //        Day = Math.Floor((double)(timeStampRecords[SpotsNum][RecordsNum][0, 0] - Month * 2678400) / 86400);
            //        Hour = Math.Floor((double)(timeStampRecords[SpotsNum][RecordsNum][0, 0] - Month * 2678400-Day*86400) / 3600);
            //        Minute = Math.Floor((double)(timeStampRecords[SpotsNum][RecordsNum][0, 0] - Month * 2678400 - Day * 86400-Hour*3600) / 60);
            //        Second = Math.Floor((double)(timeStampRecords[SpotsNum][RecordsNum][0, 0] - Month * 2678400 - Day * 86400 - Hour * 3600-Minute*60) / 60);
            //        sw.Write(Day.ToString()+"/"+Month.ToString()+"/16");
            //        sw.Write(",");
            //        sw.Write(Hour.ToString()+":"+Minute.ToString()+":"+Second.ToString());
            //        sw.Write(",");
            //        sw.Write((SpotsNum+1).ToString());
            //        sw.Write(",");
            //        sw.Write(timeStampRecords[SpotsNum][RecordsNum][0, 1].ToString());
            //        sw.WriteLine();

            //    }

            //}

            sw.Close();
        }
        public static void WriteTimeStamps(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            sw.Write("Time");
            sw.WriteLine();
            for(int hour =0; hour <24; hour++)
            {
                for(int minute = 0; minute <60; minute++)
                {
                    sw.Write(hour.ToString() + ":" + minute.ToString());
                    sw.Write(",");
                    sw.WriteLine();
                }
            }

            sw.Close();
        }
        public static void WriteOutPutTimeStamps(string filename, List<List<int[,]>> timeStampRecordsImport, List<List<int[,]>> civicSmartImport )
        {
            List<List<int[,]>> timeStampRecords = new List<List<int[,]>>();
            List<List<int[,]>> civicSmartStatus = new List<List<int[,]>>();
            timeStampRecords = timeStampRecordsImport;
            civicSmartStatus = civicSmartImport;
            StreamWriter sw = new StreamWriter(filename);
            sw.Write("Date, Time, Video,CivicSmart,Wrong");
            sw.WriteLine();
            int totRecords = timeStampRecords[0].Count();
            double Month = new int();
            double Day = new int();
            double Hour = new int();
            double Minute = new int();
            double Second = new int();
            for (int RecordsNum = 0; RecordsNum < totRecords; RecordsNum++)
            {
                Month = Math.Floor((double)timeStampRecords[0][RecordsNum][0, 0] / 2678400);
                Day = Math.Floor((double)(timeStampRecords[0][RecordsNum][0, 0] - Month * 2678400) / 86400);
                Hour = Math.Floor((double)(timeStampRecords[0][RecordsNum][0, 0] - Month * 2678400 - Day * 86400) / 3600);
                Minute = Math.Floor((double)(timeStampRecords[0][RecordsNum][0, 0] - Month * 2678400 - Day * 86400 - Hour * 3600) / 60);
                Second = (double)(timeStampRecords[0][RecordsNum][0, 0] - Month * 2678400 - Day * 86400 - Hour * 3600 - Minute * 60);

                sw.Write(Day.ToString() + "/" + Month.ToString() + "/16");
                sw.Write(",");
                sw.Write(Hour.ToString() + ":" + Minute.ToString() + ":" + Second.ToString());
                sw.Write(",");
                sw.Write(timeStampRecords[6][RecordsNum][0, 1].ToString());
                sw.Write(",");
                sw.Write(civicSmartStatus[6][RecordsNum][0, 1].ToString());
                sw.Write(",");
                if(timeStampRecords[6][RecordsNum][0, 1] == civicSmartStatus[6][RecordsNum][0, 1])
                {
                    sw.Write("");
                    sw.Write(",");
                }
                else
                {
                    sw.Write(1.ToString());
                    sw.Write(",");
                }
                
                sw.WriteLine();
            }

            sw.Close();
        }

    }
}
