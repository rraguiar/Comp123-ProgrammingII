using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDemo
{
    class Pet
    {
        string name, owner, tricks;
        int age;

        #region Constructor
        //load info into all fields
        public Pet (string name, int age, string owner="Unknown", string tricks="Unknown")
        {
            this.age = age;
            this.name = name;
            this.owner = owner;
            this.tricks = tricks;
        }
        #endregion

        #region Override
        public override string ToString()
        {
            return $"Hi my name is {name}, I am {age}yrs old, my owner is {owner} and my tricks are {tricks}";
            //return $"Pet name: {name}\nOwner: {owner}\nAge: {age}\nTricks: {tricks}";
        }
        #endregion

        #region OVERLOADING_Methods
        public void SetOwner(string owner)
        {
            this.owner = owner;
        }
        public void AddTricks (string tricks)
        {
            if (this.tricks=="Unknown")
            {
                this.tricks = tricks;
            }
            else
            {
                this.tricks += ", " + tricks;
            }
        }
        #endregion
    }
}
