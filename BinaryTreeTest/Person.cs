using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeTest
{
    public class Person : IComparable<Person>
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private int age;
        public int Age { get { return age; } set { age = value; } }

        private string hairColor;
        public string HairColor { get { return hairColor; } set { hairColor = value; } }

        public Person(string name, int age, string hairColor)
        {
            this.name = name;
            this.age = age;
            this.hairColor = hairColor;
        }
        int IComparable<Person>.CompareTo(Person aPerson)
        {
            if (aPerson == null) return 1;

            if (aPerson.Name == this.Name)
            {
                return this.Age.CompareTo(aPerson.Age);
            }
            return this.Name.CompareTo(aPerson.Name);
        }
    }
}
