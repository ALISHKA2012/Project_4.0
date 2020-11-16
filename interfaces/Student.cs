using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public class Student : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("Student is running!");
        }
    }
}
