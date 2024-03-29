﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment03
{
    class Time
    {
        public int Hours { get; }
        public int Minutes { get; }
        public int Seconds { get; }

        public Time(int hours, int minutes, int seconds = 0) {
            this.Hours      = hours;
            this.Minutes    = minutes;
            this.Seconds    = seconds;
        }

        public override string ToString()
        {
            return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
        }

        public static bool operator !=(Time leftSide, Time rightSide)
        {
            return !(leftSide == rightSide);
        }

        public static bool operator ==(Time leftSide, Time rightSide)
        {
            int difference, fifteenMinutesToSeconds;
            FindDifferenceAndMinuteToSeconds(leftSide, rightSide, out difference, out fifteenMinutesToSeconds);

            if (difference > fifteenMinutesToSeconds)
            {
                return false;
            }

            return true;
        }
        private static void FindDifferenceAndMinuteToSeconds(Time leftSide, Time rightSide, out int difference, out int fifteenMinutesToSeconds)
        {
            int leftSideToSecond = leftSide.convertTimeToSeconds();
            int rightSideToSecond = rightSide.convertTimeToSeconds();
            difference = Math.Abs(leftSideToSecond - rightSideToSecond);
            fifteenMinutesToSeconds = new Time(0, 15, 0).convertTimeToSeconds();
        }
        private int convertTimeToSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }
    }
}
