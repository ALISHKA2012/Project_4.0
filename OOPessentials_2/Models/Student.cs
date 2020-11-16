using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPessentials_2
{
    public class Student : Person
    {
  
        public Student(string name, string surname, sbyte age, byte mark):base(name, surname, age)
        {
            Mark = mark;
        }
        private byte _mark;


        public byte Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                if (value > 0 && value <= 5)
                {
                    _mark = value;
                }
            }
        }
        public override void GetFullInfo()
        {
            base.GetFullInfo();
            Console.WriteLine("\nMark:"+Mark);
        }
    }
}
