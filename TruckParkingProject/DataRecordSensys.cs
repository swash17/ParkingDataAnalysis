using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckParkingDataAnalysis
{
    public class SensysRecord
    {
        private int _timeStamp;
        private string _dateTime;
        private int _year;
        private byte _month;
        private byte _day;
        private byte _hour;
        private byte _minute;
        private byte _second;
        private int _space1A;
        private int _space1B;
        private int _space1C;
        private int _space2A;
        private int _space2B;
        private int _space2C;
        private int _space3A;
        private int _space3B;
        private int _space3C;
        private int _space4A;
        private int _space4B;
        private int _space4C;
        private int _space5A;
        private int _space5B;
        private int _space5C;
        private int _space6A;
        private int _space6B;
        private int _space6C;
        private int _space7A;
        private int _space7B;
        private int _space7C;
        private int _space8A;
        private int _space8B;
        private int _space8C;
        private int _space9A;
        private int _space9B;
        private int _space9C;
        private int _space10A;
        private int _space10B;
        private int _space10C;
        private int _hourTimeStamp;
        private int _dayTimeStamp;
        private int _monthTimeStamp;

        public SensysRecord()
        {
            _timeStamp = TimeStamp;
            _dateTime = DateTime;
            _year = Year;
            _month = Month;
            _day = Day;
            _hour = Hour;
            _minute = Minute;
            _second = Second;
            _hourTimeStamp = HourTimeStamp;
            _dayTimeStamp = DayTimeStamp;
            _monthTimeStamp = MonthTimeStamp;
            _space1A = Space1A;
            _space1B = Space1B;
            _space1C = Space1C;
            _space2A = Space2A;
            _space2B = Space2B;
            _space2C = Space2C;
            _space3A = Space3A;
            _space3B = Space3B;
            _space3C = Space3C;
            _space4A = Space4A;
            _space4B = Space4B;
            _space4C = Space4C;
            _space5A = Space5A;
            _space5B = Space5B;
            _space5C = Space5C;
            _space6A = Space6A;
            _space6B = Space6B;
            _space6C = Space6C;
            _space7A = Space7A;
            _space7B = Space7B;
            _space7C = Space7C;
            _space8A = Space8A;
            _space8B = Space8B;
            _space8C = Space8C;
            _space9A = Space9A;
            _space9B = Space9B;
            _space9C = Space9C;
            _space10A = Space10A;
            _space10B = Space10B;
            _space10C = Space10C;
        }
        public int TimeStamp
        {
            get
            {
                return _timeStamp;
            }

            set
            {
                _timeStamp = value;
            }
        }

        public string DateTime
        {
            get
            {
                return _dateTime;
            }

            set
            {
                _dateTime = value;
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

        public int Space1A
        {
            get
            {
                return _space1A;
            }

            set
            {
                _space1A = value;
            }
        }

        public int Space1B
        {
            get
            {
                return _space1B;
            }

            set
            {
                _space1B = value;
            }
        }

        public int Space1C
        {
            get
            {
                return _space1C;
            }

            set
            {
                _space1C = value;
            }
        }

        public int Space2A
        {
            get
            {
                return _space2A;
            }

            set
            {
                _space2A = value;
            }
        }

        public int Space2B
        {
            get
            {
                return _space2B;
            }

            set
            {
                _space2B = value;
            }
        }

        public int Space2C
        {
            get
            {
                return _space2C;
            }

            set
            {
                _space2C = value;
            }
        }

        public int Space3A
        {
            get
            {
                return _space3A;
            }

            set
            {
                _space3A = value;
            }
        }

        public int Space3B
        {
            get
            {
                return _space3B;
            }

            set
            {
                _space3B = value;
            }
        }

        public int Space3C
        {
            get
            {
                return _space3C;
            }

            set
            {
                _space3C = value;
            }
        }

        public int Space4A
        {
            get
            {
                return _space4A;
            }

            set
            {
                _space4A = value;
            }
        }

        public int Space4B
        {
            get
            {
                return _space4B;
            }

            set
            {
                _space4B = value;
            }
        }

        public int Space4C
        {
            get
            {
                return _space4C;
            }

            set
            {
                _space4C = value;
            }
        }

        public int Space5A
        {
            get
            {
                return _space5A;
            }

            set
            {
                _space5A = value;
            }
        }

        public int Space5B
        {
            get
            {
                return _space5B;
            }

            set
            {
                _space5B = value;
            }
        }

        public int Space5C
        {
            get
            {
                return _space5C;
            }

            set
            {
                _space5C = value;
            }
        }

        public int Space6A
        {
            get
            {
                return _space6A;
            }

            set
            {
                _space6A = value;
            }
        }

        public int Space6B
        {
            get
            {
                return _space6B;
            }

            set
            {
                _space6B = value;
            }
        }

        public int Space6C
        {
            get
            {
                return _space6C;
            }

            set
            {
                _space6C = value;
            }
        }

        public int Space7A
        {
            get
            {
                return _space7A;
            }

            set
            {
                _space7A = value;
            }
        }

        public int Space7B
        {
            get
            {
                return _space7B;
            }

            set
            {
                _space7B = value;
            }
        }

        public int Space7C
        {
            get
            {
                return _space7C;
            }

            set
            {
                _space7C = value;
            }
        }

        public int Space8A
        {
            get
            {
                return _space8A;
            }

            set
            {
                _space8A = value;
            }
        }

        public int Space8B
        {
            get
            {
                return _space8B;
            }

            set
            {
                _space8B = value;
            }
        }

        public int Space8C
        {
            get
            {
                return _space8C;
            }

            set
            {
                _space8C = value;
            }
        }

        public int Space9A
        {
            get
            {
                return _space9A;
            }

            set
            {
                _space9A = value;
            }
        }

        public int Space9B
        {
            get
            {
                return _space9B;
            }

            set
            {
                _space9B = value;
            }
        }

        public int Space9C
        {
            get
            {
                return _space9C;
            }

            set
            {
                _space9C = value;
            }
        }

        public int Space10A
        {
            get
            {
                return _space10A;
            }

            set
            {
                _space10A = value;
            }
        }

        public int Space10B
        {
            get
            {
                return _space10B;
            }

            set
            {
                _space10B = value;
            }
        }

        public int Space10C
        {
            get
            {
                return _space10C;
            }

            set
            {
                _space10C = value;
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
    }
}
