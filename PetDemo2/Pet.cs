using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDemo2
{
    class Pet
    {
        //declaring the PUBLIC variables and setting them as public to be read - method like declaration.
        public string Name { get; private set; }
        public string Owner { get; private set; }
        public int Age { get; private set; }
        public string Description { get; private set; }
        public bool IsHouseTrained { get; private set; }

        //Load into all fields
        public Pet(string name, int age, string description)
        {
            Name = name;
            Age = age;
            Description = description;
            Owner = "No one";
            IsHouseTrained = false;
        }

        //override method
        public override string ToString()
        {
            return $"I am {Name}, I am {Age}yrs old, my owner is {Owner}. I am {Description} and I am {(IsHouseTrained ? "trained" : "not trained")} in house.";
        }
        public void SetOwner(string owner)
        {
            Owner = owner;
        }
        public void Train()
        {
            IsHouseTrained = true;
        }



    }
}
