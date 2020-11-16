using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public class Person : IRunnable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public byte Age { get; set; }
        public Person(int id, string name, decimal salary, byte age)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Age = age;
        }


        public void Run()
        {
            Console.WriteLine("Person is running!");
        }
        public override string ToString()
        {
            return $"{Id} {Name} {Salary} {Age}";
        }
    }
}
