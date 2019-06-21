using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet("Garfield", 5, "lazy cat");
            Console.WriteLine(pet);
            pet.SetOwner("Jon");
            Console.WriteLine(pet);
            pet.Train();
            Console.WriteLine(pet);

            Pet pet2 = new Pet("Beethoven", 2, "dog");
            pet2.SetOwner("Jon");

            Pet pet3 = new Pet("Ole Yeller", 2, "collie");
            pet3.Train();

            Pet pet4 = new Pet("Marmaduque", 4, "great dane");

            //create a list of pet objects.
            List<Pet> pets = new List<Pet>() { pet, pet2, pet3, pet4 };

            Console.WriteLine("\nAll the pets:");
            foreach (Pet p in pets)
            {
                Console.WriteLine(p);
            }

            string owner = "Jon";
            Console.WriteLine($"All the pets owned by {owner}");
            foreach (Pet p in pets)
            {
                if (p.Owner==owner)
                {
                    Console.WriteLine(p);
                }

            }
        }

    }
}
