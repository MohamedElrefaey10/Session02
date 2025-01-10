using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02
{
    #region 2.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

    #endregion
    internal struct Person
    {

        private string name;
        private int age;
        public Person(string Name, int Age)
        {
            name = Name;
            age = Age;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = Name;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value < 0 ? 20 : value;
            }

        }
        public override string ToString()
        {
            return $"Name : {Name}\nAge : {Age}";
        }
    }
}
