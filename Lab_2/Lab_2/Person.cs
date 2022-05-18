using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Person
    {
        protected string name;
        protected int age;

        public string Name
        {
            get => name;
            set { name = value; }
        }

        public int Age
        {
            get => age;
            set
            {
                if (value > 0)
                {
                    age = value;
                }
            }
        }

        public int GetAge()
        {
            return age;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override bool Equals(object obj)
        {
            if(obj != null && obj.GetType() == this.GetType())
            {
                Person other = obj as Person;
                if(other.Name.Equals(this.Name) && other.Age == this.Age)
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return "Name: " + Name + "\nAge: " + Age + "\n";
        }
    }
}
