using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeDemo
{
    enum TimeFormat {Mil, Hour12, Hour24 };
    class Time
    {
        static TimeFormat TIME_FORMAT = TimeFormat.Hour12;
        public int Hour { get; private set; }
        public int Minute { get; private set; }
        public Time (int hour=0, int minute=0)
        {
            if (hour < 0 || hour > 23) hour = 0;
            Hour = hour;
            if (minute < 0 || minute > 59) minute = 0;
            Minute = minute;
        }
        public override string ToString()
        {
            switch (TIME_FORMAT)
            {
                case TimeFormat.Mil:
                    return $"{Hour:D2}{Minute:D2}";
                case TimeFormat.Hour24:
                    return $"{Hour:D2}:{Minute:D2}";
                default: //Hour12 is the default
                    return $"{Hour % 12}:{Minute:D2} {(Hour < 12 ? "AM" : "PM")}";
            }
        }
        public static void SetFormat(TimeFormat format)
        {
            TIME_FORMAT = format;
        }
    }
}
