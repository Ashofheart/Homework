using System;
using System.IO.Pipes;
using System.Reflection.Metadata.Ecma335;

namespace Program
{
    class Angle
    {
        public override string ToString()
        {
            return $"{an}°";
        }
        public Angle() { }
        private int an;
        public int AN { get { return an; } set { an = (360 + (value % 360)) % 360; } }
        public double rad()
        {
            return (this.an * Math.PI / 180);
        }
        public double sin()
        {
            return Math.Sin(an * 1.0);
        }
        public static bool operator ==(Angle a, Angle b)
        {
            return a.AN == b.AN;
        }
        public static bool operator !=(Angle a, Angle b)
        {
            return a.AN != b.AN;
        }
        public static Angle operator +(Angle a, Angle b)
        {
            return new Angle {AN = a.AN + b.AN };
        }
        public static Angle operator -(Angle a, Angle b)
        {
            return new Angle { AN = a.AN - b.AN };
        }
        public static Angle operator *(Angle a, Angle b)
        {
            return new Angle { AN = a.AN * b.AN };
        }
        public static Angle operator /(Angle a, Angle b)
        {
            return new Angle { AN = a.AN / b.AN };
        }
    }
    class Date
    {
        public override string ToString()
        {
            return $"{_day}:{_month}:{_year}";
        }
        int _day = 0;
        int _month = 0;
        int _year = 0;
        public bool is_vis()
        {
            return _year % 4 == 0;
        }
        public int how_days()
        {
            if (_month == 1)
            {
                return 28 + Convert.ToInt32(this.is_vis());
            }
            if (month >= 0 && month <= 6)
            {
                if (month % 2 == 0)
                {
                    return 31;
                }
                return 30;
            }
            if (month % 2 == 1)
            {
                return 31;
            }
            return 30;
        }
        public int day { 
            get 
            {
                return _day;
            }
            set
            {
                while (value >= how_days())
                {
                    _month++;
                    value -= how_days();
                }
                _day = value;
            }
        }
        public int month 
        {
            get
            {
                return _month;
            }
            set
            {
                _month = value % 12;
                year = _year + (value / 12);
                if (day >= how_days())
                {
                    day = how_days() - 1;
                }
            }
        }
        public int year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
                if (_year == 1 && _day == 29)
                {
                    _day--;
                }
            }
        }
        public static Date operator +(Date d1, Date d2)
        {
            return new Date { year = d1.year + d2.year, month = d1.month + d2.month, day = d1.day + d2.day };
        }
    }
}