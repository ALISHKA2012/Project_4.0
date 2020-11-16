using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPessentials_2
{
    public class Worker : Person
    {
        public Worker()
        {
                
        }

        public Worker(decimal salary, string name, string surname, sbyte age ):base(name, surname, age)
        {
            Salary = salary;
            
        }



        private decimal _salary;

        public decimal Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value > 0)
                {
                    _salary = value;
                }
            }
        }

        public override void GetFullInfo()
        {
            base.GetFullInfo();
            Console.WriteLine($"\nSalary:{Salary}");
        }
        public override string ToString()
        {
            return $" \nName:{Name} \nSurname:{Surname} \nAge:{Age} \nSalary:{Salary} ";

        }
    }
}
