using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3DateDemo
{
    class Date
    {
        private int Year;
        private int Month;
        private int Day;
        string[] monthString = new string[] { "Jannuary", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        public Date(int year, int month, int day)
        {
            this.Year = year;
            this.Month = month;
            this.Day = day;
        }

        public void SetDate(int year, int month, int day)
        {
            this.Year = year;
            this.Month = month;
            this.Day = day;
        }

        public override string ToString()
        {
            return $"{monthString[Month - 1]} / {Day} / {Year}";
        }

        public void Add(int days)
        {
            this.Day += days;
            Normalize();
        }

        public void Add(int months, int days)
        {
            this.Month += months; this.Day += days;
            Normalize();
        }

        public void Add(Date other)
        {
            this.Year += other.Year;
            this.Month += other.Month;
            this.Day += other.Day;
            Normalize();
        }
        private void Normalize()
        {
            int verifyNormalization;
            do
            {
                verifyNormalization = 0;

                if (this.Month == 2)
                {
                    //while (this.Day > 28)  ///// ver esse cara, se coloca 29 ou 28
                    //{
                        if (this.Month == 2 && (((this.Year % 4 == 0) && (this.Year % 100 != 0)) || (this.Year % 400 == 0)))
                        {
                            NormalizeFebruary("yes");
                            verifyNormalization++;
                            break;
                        }
                        else if (this.Month == 2 && !(((this.Year % 4 == 0) && (this.Year % 100 != 0)) || (this.Year % 400 == 0)))
                        {
                            NormalizeFebruary("no");
                            verifyNormalization++;
                            break;
                        }
                    //}
                }
                else if (this.Month == 4 || this.Month == 6 || this.Month == 9 || this.Month == 11)
                {
                    while (this.Day > 30)
                    {
                        this.Day -= 30;
                        this.Month++;
                        verifyNormalization++;
                        break;
                    }
                }
                else if (this.Month == 1 || this.Month == 3 || this.Month == 5 || this.Month == 7 || this.Month == 8 || this.Month == 10 || this.Month == 12)
                {
                    while (this.Day > 31)
                    {
                        this.Day -= 31;
                        this.Month++;
                        verifyNormalization++;
                        break;
                    }
                }
                if (this.Month > 12)
                {
                    this.Month -= 12;
                    this.Year++;
                    verifyNormalization++;
                }
            } while (verifyNormalization != 0);
        }

        private void NormalizeFebruary(string leapYear)
        {
            if (leapYear == "yes")
            {
                if (this.Day > 29)
                {
                    this.Day -= 29;
                    this.Month++;
                }
            }
            else if (leapYear=="no")
            {
                if (this.Day > 28)
                {
                    this.Day -= 28;
                    this.Month++;
                }
            }
        }
    }
}