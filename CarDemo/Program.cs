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
            Car rafael = new Car("Rafael");
            Console.WriteLine(rafael);
            double distance = 100;
            Console.WriteLine($"Driving {distance}km");
            rafael.Drive(distance);
            Console.WriteLine(rafael);

            distance = 300;
            Console.WriteLine($"Driving {distance}km");
            rafael.Drive(distance);
            Console.WriteLine(rafael);

            double fuel = 10;
            Console.WriteLine($"Refueling {fuel}L");
            rafael.Refuel(fuel);
            Console.WriteLine(rafael);
        }
    }

    class Car
    {
        string name;
        public double odometer { get; private set; }
        public double Fuel { get; private set; } //litre
        const double EFFICIENCY = 10.2;          //km per litre
        public Car(string name, double fuel = 40, double odometer = 15)
        {
            this.name = name;
            Fuel = fuel;
            this.odometer = odometer;
        }
        public void Drive(double km, int minutes = 0)
        {
            Fuel -= km / EFFICIENCY;
            odometer += km;
        }
        public void Refuel(double amount)
        {
            Fuel += amount;
        }
        public void Odometer(double amount)
        {
            odometer += amount;
        }
        public override string ToString()
        {
            return $"{name} ({odometer}) {Fuel:F2}L";
        }
    }
}
