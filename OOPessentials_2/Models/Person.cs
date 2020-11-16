using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPessentials_2
{
    public class Person
    {

        protected sbyte _age;

        public string Name { get; set; } = default;
        public string Surname { get; set; } = default;
        public sbyte Age
        {
            get { return _age; }
            set
            {
                if (value > 0 && value < 100)
                {
                    _age = value;
                }
            }

        }





        public Person(string name, string surname, sbyte age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public Person()
        {

        }
        public string SayHello()
        {
            return "Hello, dear!";
        }
        public virtual void GetFullInfo()
        {
            Console.Write($"Name:{Name}\nSurname:{Surname}\nAge:{Age}") ;
        }
    }
}
