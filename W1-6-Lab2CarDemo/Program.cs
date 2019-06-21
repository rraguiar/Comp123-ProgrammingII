using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02CarDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            Car car1 = new Car(2007, "Toyota", "Corola", 2500);
            Car car2 = new Car(1997, "Toyota", "Corola", 399, false);
            Car car3 = new Car(2018, "Nissan", "Rogue", 25000, true);
            Car car4 = new Car(1978, "Pontiac", "Firebird", 50000, true);
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            cars.Add(car4);

            foreach (Car item in cars)
                Console.WriteLine(item);
        }
    }
}
