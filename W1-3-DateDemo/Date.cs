using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDemo
{
    class Date
    {
        //field (all private)
        int year;
        int month;
        int day;
        string[] monthString = new string[] {"January","February","March","April","May","June","July","August","September","October","November","December"};

        //Constructor (normally take enough arguments to set all the fields)
        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
        //override
        public override string ToString()
        {

            //return $"{day:d2} / {month:d2} / {year}";
            //printing month as string, not integer.
            return $"{day:d2} / {monthString[month-1]:d2} / {year}";

        }

        #region OVERLOADING_Methods
        //All methods with the same name are called OVERLOADING - good for inserting different types of data
        //to the class... Console.WriteLine is an OVERLOADING because you insert int, float, string, to the 
        //Console.WriteLine Class....
        public void Add (int days)
        {
            day += days;
            Normalize();
        }
        public void Add(int months, int days)
        {
            day += days;
            month += months;
            Normalize();
        }
        public void Add (Date other)
        {
            year += other.year;
            month += other.month;
            day += other.day;
            Normalize();
        }
        #endregion

        #region UTILITY_Methods
        //This is a utility method - it is private and is for internal use of the class
        //normalize the day and month field to the standards of calendars.
        private void Normalize()
        {
            while (day>30)
            {
                day -= 30;
                month++;
            }
            while (month>12)
            {
                month -= 12;
                year++;
            }
        }
        #endregion
    }
}
