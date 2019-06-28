using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2_5_Lab5PetDemo2
{
    class Program
    {
        static void Main(string[] args)
        {

            Pet pet1 = new Pet("Rex",9,"Brown Labrador");
            Pet pet2 = new Pet("Rufus",4,"Great Dane");
            Pet pet3 = new Pet("Napoleon",7,"lazy Cat");
            Pet pet4 = new Pet("Zezinho",6,"black Cat");

            pet1.Train();
            pet3.SetOwner("Rafael");
            pet4.SetOwner("Josy");
            pet2.SetOwner("Rafael & Josy");
            string[] petName = new string[] {pet1.ToString(), pet2.ToString(), pet3.ToString(), pet4.ToString() };

            for (int i= 0;i< 4;i++)
            {
                Console.WriteLine(petName[i]);
            }
            

        }
    }

    class Pet
    {
        public string Name { get; private set; }
        public string Owner { get; private set; }
        public int Age { get; private set; }
        public string Description { get; private set; }
        public bool IsHouseTrained { get; private set; }

        public Pet(string name, int age, string description)
        {
            this.Name = name;
            this.Owner = "no one";
            this.Age = age;
            this.Description = description;
            this.IsHouseTrained = false;
        }

        public override string ToString()
        {
            return $"{Name}, {Age} years old, {Description}, my owner is {Owner} and {(IsHouseTrained == true ? "I am trained" : "I am not trained")}";
        }

        public void SetOwner(string owner)
        {
            this.Owner = owner;
        }

        public void Train()
        {
            this.IsHouseTrained = true;
        }
    }
}
