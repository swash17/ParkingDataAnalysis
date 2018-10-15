namespace TruckParkingDataAnalysis
{
    public class BlueBandRecord
    {
        private byte _sensorID;
        private string _sensorAddress;
        private int _spaceNumber;
        private int _year;
        private byte _parkingStatus;
        private byte _month;
        private byte _day;
        private byte _hour;
        private byte _minute;
        private byte _second;
        private int _hourTimeStamp;
        private int _dayTimeStamp;
        private int _monthTimeStamp;
        public BlueBandRecord()
        {
            _sensorAddress = SensorAddress;
            _sensorID = SensorID;
            _spaceNumber = SpaceNumber;
            _year = Year;
            _parkingStatus = ParkingStatus;
            _month = Month;
            _day = Day;
            _hour = Hour;
            _minute = Minute;
            _second = Second;
            _hourTimeStamp = HourTimeStamp;
            _dayTimeStamp = DayTimeStamp;
            _monthTimeStamp = MonthTimeStamp;

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


        public int SpaceNumber
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

        public byte ParkingStatus
        {
            get
            {
                return _parkingStatus;
            }

            set
            {
                _parkingStatus = value;
            }
        }

        public byte SensorID
        {
            get
            {
                return _sensorID;
            }

            set
            {
                _sensorID = value;
            }
        }

        public string SensorAddress
        {
            get
            {
                return _sensorAddress;
            }

            set
            {
                _sensorAddress = value;
            }
        }
    }

}
