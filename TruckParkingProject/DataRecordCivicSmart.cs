﻿namespace TruckParkingDataAnalysis
{
    public class CivicSmartRecord
    {
        private string _sensorStatus;
        private int _meterID;
        private int _sensorID;
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
        public CivicSmartRecord()
        {
            _sensorStatus = SensorStatus;
            _meterID = MeterID;
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
        public string SensorStatus
        {
            get
            {
                return _sensorStatus;
            }

            set
            {
                _sensorStatus = value;
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

        public int MeterID
        {
            get
            {
                return _meterID;
            }

            set
            {
                _meterID = value;
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

        public int SensorID
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
    }

}
