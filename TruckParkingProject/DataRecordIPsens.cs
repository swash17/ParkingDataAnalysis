namespace TruckParkingDataAnalysis
{
    public class IPsensRecord
    {
        private byte _spaceNumber;
        private int _enterYear;
        private byte _enterMonth;
        private byte _enterDay;
        private byte _enterHour;
        private byte _enterMinute;
        private byte _enterSecond;
        private int _existYear;
        private byte _existMonth;
        private byte _existDay;
        private byte _existHour;
        private byte _existMinute;
        private byte _existSecond;
        private int _enterHourTimeStamp;
        private int _enterDayTimeStamp;
        private int _enterMonthTimeStamp;
        private int _existHourTimeStamp;
        private int _existDayTimeStamp;
        private int _existMonthTimeStamp;


        public IPsensRecord()
        {
            _spaceNumber = SpaceNumber;
            _enterYear = EnterYear;
            _enterMonth = EnterMonth;
            _enterDay = EnterDay;
            _enterMinute = EnterMinute;
            _enterSecond = EnterSecond;
            _existYear = ExistYear;
            _existMonth = ExistMonth;
            _existDay = ExistDay;
            _existHour = ExistHour;
            _existMinute = ExistMinute;
            _enterSecond = ExistSecond;
            _enterHourTimeStamp = EnterHourTimeStamp;
            _enterDayTimeStamp = EnterDayTimeStamp;
            _enterMonthTimeStamp = EnterMonthTimeStamp;
            _existHourTimeStamp = ExistHourTimeStamp;
            _existDayTimeStamp = ExistDayTimeStamp;
            _existMonthTimeStamp = ExistMonthTimeStamp;
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

        public int EnterYear
        {
            get
            {
                return _enterYear;
            }

            set
            {
                _enterYear = value;
            }
        }


        public byte EnterDay
        {
            get
            {
                return _enterDay;
            }

            set
            {
                _enterDay = value;
            }
        }

        public byte EnterHour
        {
            get
            {
                return _enterHour;
            }

            set
            {
                _enterHour = value;
            }
        }

        public byte EnterMinute
        {
            get
            {
                return _enterMinute;
            }

            set
            {
                _enterMinute = value;
            }
        }

        public byte EnterSecond
        {
            get
            {
                return _enterSecond;
            }

            set
            {
                _enterSecond = value;
            }
        }

        public int ExistYear
        {
            get
            {
                return _existYear;
            }

            set
            {
                _existYear = value;
            }
        }

        public byte ExistMonth
        {
            get
            {
                return _existMonth;
            }

            set
            {
                _existMonth = value;
            }
        }

        public byte ExistDay
        {
            get
            {
                return _existDay;
            }

            set
            {
                _existDay = value;
            }
        }

        public byte ExistHour
        {
            get
            {
                return _existHour;
            }

            set
            {
                _existHour = value;
            }
        }

        public byte ExistMinute
        {
            get
            {
                return _existMinute;
            }

            set
            {
                _existMinute = value;
            }
        }

        public byte ExistSecond
        {
            get
            {
                return _existSecond;
            }

            set
            {
                _existSecond = value;
            }
        }

        public byte EnterMonth
        {
            get
            {
                return _enterMonth;
            }

            set
            {
                _enterMonth = value;
            }
        }
        public int EnterHourTimeStamp
        {
            get
            {
                return _enterHourTimeStamp;
            }

            set
            {
                _enterHourTimeStamp = value;
            }
        }

        public int EnterDayTimeStamp
        {
            get
            {
                return _enterDayTimeStamp;
            }

            set
            {
                _enterDayTimeStamp = value;
            }
        }

        public int EnterMonthTimeStamp
        {
            get
            {
                return _enterMonthTimeStamp;
            }

            set
            {
                _enterMonthTimeStamp = value;
            }
        }

        public int ExistHourTimeStamp
        {
            get
            {
                return _existHourTimeStamp;
            }

            set
            {
                _existHourTimeStamp = value;
            }
        }

        public int ExistDayTimeStamp
        {
            get
            {
                return _existDayTimeStamp;
            }

            set
            {
                _existDayTimeStamp = value;
            }
        }

        public int ExistMonthTimeStamp
        {
            get
            {
                return _existMonthTimeStamp;
            }

            set
            {
                _existMonthTimeStamp = value;
            }
        }
    }
}
