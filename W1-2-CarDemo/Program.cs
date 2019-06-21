using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car(2007, "Honda", "CR-V", 5_799.99, true);
            Console.WriteLine(c1);
            c1 = new Car (2018, "Nissan", "Qashqai", 24_799.99, true);
            Console.WriteLine(c1);
            c1 = new Car (1998, "Toyota", "Corola", 799.99, false);
            Console.WriteLine(c1);
            Console.WriteLine(new Car (2010, "Ford", "F150", 1_300, true));
        }
    }
}
