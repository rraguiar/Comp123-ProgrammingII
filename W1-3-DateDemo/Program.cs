using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an object (instantiating the object)
            Date d = new Date(2019, 05, 10);
            //printing the object
            Console.WriteLine(d);
            
            int days = 25, months = 6, years = 2;

            //testing the Add (int) method - adding days
            Console.WriteLine($"Adding {days} days");
            d.Add(days);
            Console.WriteLine(d);

            //testing the Add (int, int) method - adding days and months - other Add method - 
            Console.WriteLine($"Adding {months} months {days} days");
            d.Add(months, days);
            Console.WriteLine(d);

            //creating another object to use the last method
            Date d1 = new Date(years, months, days);
            
            //testing the Add (int, int) method - adding days and months - other Add method - 
            Console.WriteLine($"Adding {d1}");
            d.Add(d1);
            Console.WriteLine(d);
        }
    }
}
