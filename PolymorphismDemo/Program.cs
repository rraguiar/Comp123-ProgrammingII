using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    class Program
    {
        static void Main(string[] args)
        {//although Shape is an abstract is can be used as a reference type
         //any child class of Shape is also a Shape
            List<Shape> shapes = new List<Shape>();

            shapes.Add(new Square(2));
            shapes.Add(new Rectangle(2, 3));
            shapes.Add(new Circle(2));
            shapes.Add(new Triangle(4, 6));
            shapes.Add(new Ellipse(2, 3));
            shapes.Add(new Diamond(2, 3));

            shapes.Add(new Square(5));
            shapes.Add(new Rectangle(5, 4));
            shapes.Add(new Circle(1));
            shapes.Add(new Triangle(7, 8));

            foreach (var s in shapes)
            {
                Console.WriteLine(s);
            }

        }
    }
}
