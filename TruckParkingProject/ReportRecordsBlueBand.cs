namespace TruckParkingDataAnalysis
{
    public class BlueBandReportRecord
    {
        private byte _sensorNumber;
        private byte _spaceNumber;
        private int _enterYear;
        private byte _enterMonth;
        private byte _enterDay;
        private byte _enterHour;
        private byte _enterMinute;
        private byte _enterSecond;
        private int _exitYear;
        private byte _exitMonth;
        private byte _exitDay;
        private byte _exitHour;
        private byte _exitMinute;
        private byte _exitSecond;
        private int _enterHourTimeStamp;
        private int _enterDayTimeStamp;
        private int _enterMonthTimeStamp;
        private int _exitHourTimeStamp;
        private int _exitDayTimeStamp;
        private int _exitMonthTimeStamp;

        public BlueBandReportRecord()
        {
            _sensorNumber = SensorNumber;
            _spaceNumber = SpaceNumber;
            _enterYear = EnterYear;
            _enterMonth = EnterMonth;
            _enterDay = EnterDay;
            _enterMinute = EnterMinute;
            _enterSecond = EnterSecond;
            _exitYear = ExitYear;
            _exitMonth = ExitMonth;
            _exitDay = ExitDay;
            _exitHour = ExitHour;
            _exitMinute = ExitMinute;
            _enterSecond = ExitSecond;
            _enterHourTimeStamp = EnterHourTimeStamp;
            _enterDayTimeStamp = EnterDayTimeStamp;
            _enterMonthTimeStamp = EnterMonthTimeStamp;
            _exitHourTimeStamp = ExitHourTimeStamp;
            _exitDayTimeStamp = ExitDayTimeStamp;
            _exitMonthTimeStamp = ExitMonthTimeStamp;
        }

        public byte SensorNumber
        {
            get
            {
                return _sensorNumber;
            }

            set
            {
                _sensorNumber = value;
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

        public int ExitYear
        {
            get
            {
                return _exitYear;
            }

            set
            {
                _exitYear = value;
            }
        }

        public byte ExitMonth
        {
            get
            {
                return _exitMonth;
            }

            set
            {
                _exitMonth = value;
            }
        }

        public byte ExitDay
        {
            get
            {
                return _exitDay;
            }

            set
            {
                _exitDay = value;
            }
        }

        public byte ExitHour
        {
            get
            {
                return _exitHour;
            }

            set
            {
                _exitHour = value;
            }
        }

        public byte ExitMinute
        {
            get
            {
                return _exitMinute;
            }

            set
            {
                _exitMinute = value;
            }
        }

        public byte ExitSecond
        {
            get
            {
                return _exitSecond;
            }

            set
            {
                _exitSecond = value;
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

        public int ExitHourTimeStamp
        {
            get
            {
                return _exitHourTimeStamp;
            }

            set
            {
                _exitHourTimeStamp = value;
            }
        }

        public int ExitDayTimeStamp
        {
            get
            {
                return _exitDayTimeStamp;
            }

            set
            {
                _exitDayTimeStamp = value;
            }
        }

        public int ExitMonthTimeStamp
        {
            get
            {
                return _exitMonthTimeStamp;
            }

            set
            {
                _exitMonthTimeStamp = value;
            }
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
    }
}
