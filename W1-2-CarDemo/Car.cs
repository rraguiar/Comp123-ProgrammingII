using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDemo
{
    class Car
    {
        //field (all private)
        int year;
        string manufacturer;
        string model;
        bool isDrivable;
        double price;

        //Constructor (normally take enough arguments to set all the fields)
        public Car (int year, string manufacturer, string model, double price, bool isDrivable = true)
        {
            this.year = year; //"this" refers to object members.
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = price;
            this.isDrivable = isDrivable;
        }
        //override
        public override string ToString()
        {
            return $"{(year <= 2010 ? "Older model" : "Newer model")} {manufacturer} {model} {price:c} {(isDrivable?"Drivable":"Not drivable")}";
        }
    }
}
