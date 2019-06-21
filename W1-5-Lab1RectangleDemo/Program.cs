using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1W01RectangleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 8, width = 5;
            RectangleExercise rectangle = new RectangleExercise(length, width);
            Console.WriteLine(rectangle);
            Console.WriteLine("Area: "+rectangle.GetArea());

            rectangle = new RectangleExercise(length=5, width=3);
            Console.WriteLine(rectangle);
            Console.WriteLine("Area: "+rectangle.GetArea());

            length = 20;width = 10;
            RectangleExercise rectangle2 = new RectangleExercise(length, width);
            Console.WriteLine(rectangle2);
            Console.WriteLine("Area: " + rectangle2.GetArea());
        }
    }
}
