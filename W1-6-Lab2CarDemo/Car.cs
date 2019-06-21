using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02CarDemo
{
    class Car
    {
        private int Year;
        private string Manufacturer;
        private string Model;
        private bool isDrivable;
        private double Price;

        public Car(int year, string manufacturer, string model, double price, bool isDrivable = true)
        {
            this.Year = year;
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = price;
            this.isDrivable = isDrivable;
        }
        public override string ToString()
        {
            return $"{Year}, {Manufacturer} {Model}, Price: {Price:C} and {(isDrivable == true ? "Good condition" : "Bad Condition - can´t drive")}";
        }
    }
}
