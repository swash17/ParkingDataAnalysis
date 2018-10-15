using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckParkingDataAnalysis
{
    public enum DataType
    {
        Video = 1,
        IPsens = 2,
        Sensys = 3,
        CivicSmart = 4,
        BlueBand =5,
        BlueBandReport =6
    }
    public class TruckParkingRecord
    {
        private byte _spaceNumber;
        private string _date;
        private string _time;
        private int _year;
        private byte _month;
        private byte _day;
        private byte _hour;
        private byte _minute;
        private byte _second;
        private byte _class; // 4: truck with closed trailer; 3: truck with flat bed trailer; 2: truck with vehicle trailer; 1: truck with no trailer, 0: other
        private bool _isComingIn; //true:in, false: out
        private string _alignment;
        private string _truckLabel;
        private int _hourTimeStamp;
        private int _dayTimeStamp;
        private int _monthTimeStamp;
        private int _truckID;

        
        public TruckParkingRecord()
        {
            _spaceNumber = SpaceNumber;
            _date = Date;
            _time = Time;
            _year = Year;
            _month = Month;
            _day = Day;
            _hour = Hour;
            _minute = Minute;
            _second = Second;
            _class = Class;
            _isComingIn = IsComingIn;
            _alignment = Alignment;
            _truckLabel = TruckLabel;
            _hourTimeStamp = HourTimeStamp;
            _dayTimeStamp = DayTimeStamp;
            _monthTimeStamp = MonthTimeStamp;
            _truckID = TruckID;
        }

        public byte SpaceNumber
        {
            get
            {
                return _spaceNumber;
            }

            set
            {
                _spaceNumber = value;
            }
        }

        public byte Month
        {
            get
            {
                return _month;
            }

            set
            {
                _month = value;
            }
        }

        public byte Day
        {
            get
            {
                return _day;
            }

            set
            {
                _day = value;
            }
        }

        public byte Hour
        {
            get
            {
                return _hour;
            }

            set
            {
                _hour = value;
            }
        }

        public byte Minute
        {
            get
            {
                return _minute;
            }

            set
            {
                _minute = value;
            }
        }

        public byte Second
        {
            get
            {
                return _second;
            }

            set
            {
                _second = value;
            }
        }

        public string Date
        {
            get
            {
                return _date;
            }

            set
            {
                _date = value;
            }
        }

        public byte Class
        {
            get
            {
                return _class;
            }

            set
            {
                _class = value;
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }

            set
            {
                _year = value;
            }
        }

        public bool IsComingIn
        {
            get
            {
                return _isComingIn;
            }

            set
            {
                _isComingIn = value;
            }
        }

        public string Alignment
        {
            get
            {
                return _alignment;
            }

            set
            {
                _alignment = value;
            }
        }

        public string TruckLabel
        {
            get
            {
                return _truckLabel;
            }

            set
            {
                _truckLabel = value;
            }
        }

        public string Time
        {
            get
            {
                return _time;
            }

            set
            {
                _time = value;
            }
        }

        public int HourTimeStamp
        {
            get
            {
                return _hourTimeStamp;
            }

            set
            {
                _hourTimeStamp = value;
            }
        }

        public int DayTimeStamp
        {
            get
            {
                return _dayTimeStamp;
            }

            set
            {
                _dayTimeStamp = value;
            }
        }

        public int MonthTimeStamp
        {
            get
            {
                return _monthTimeStamp;
            }

            set
            {
                _monthTimeStamp = value;
            }
        }

        public int TruckID
        {
            get
            {
                return _truckID;
            }

            set
            {
                _truckID = value;
            }
        }
    }
}
