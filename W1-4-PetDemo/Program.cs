using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //instatiating the objects
            Pet p = new Pet("Garfield", 5);
            //printing the objects
            Console.WriteLine(p);
            string name = "John";
            Console.WriteLine($"Setting owner to {name}");
            p.SetOwner(name);
            Console.WriteLine(p);
            string trick = "Shake hands";
            Console.WriteLine($"Adding trick {trick}");
            p.AddTricks(trick);
            Console.WriteLine(p);
            trick = "Eating lasagna";
            Console.WriteLine($"Adding trick {trick}");
            p.AddTricks(trick);
            Console.WriteLine(p);

        }
    }
}
