using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3DateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date(1031, 12, 03);
            //Date d2 = new Date(1000, 04, 28);
            //d1.Add(d2);
            //Console.WriteLine("Adding Date object:");
            //Console.WriteLine(d1);

            //for (int days = 10; days >= 0; days--)
            //{
            //    d1.SetDate(2012, 02, 25);
            //    d1.Add(days);
            //    Console.WriteLine(d1);
            //}


            d1.SetDate(2010, 05, 14);
            int month = 49;
            int day = 197;
            d1.Add(month, day);
            Console.WriteLine($"Adding {month} months and {day} days:");
            Console.WriteLine(d1);
        }
    }
}
