 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //create the objects
            Time a = new Time(9, 35);
            Console.WriteLine(a);

            Time b = new Time(18, 5);
            Console.WriteLine(b);

            Time c = new Time(28, 500);
            Console.WriteLine(c);

            Time d = new Time(10);
            Console.WriteLine(d);

            //create a list to store the objects
            List<Time> times = new List<Time>() { a, b, c, d };

            //display all the objects
            Console.WriteLine("\n\nNormal time format");
            foreach (Time t in times)
            {
                Console.WriteLine(t);
            }

            //change the format of the output
            Console.WriteLine("\n\nMilitary time format");
            //SetFormat(TimeFormat) is a class member, so you need the type to access it
            Time.SetFormat(TimeFormat.Mil);
            //again display all the objects
            foreach (Time t in times)
            {
                Console.WriteLine(t);
            }

            //change the format of the output
            Console.WriteLine("\n\n24 hour time format");
            Time.SetFormat(TimeFormat.Hour24);
            foreach (Time t in times)
            {
                Console.WriteLine(t);
            }
        }
    }
}
