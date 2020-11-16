using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OOPessentials_2
{
    class Program
    {

        static void Main(string[] args)
        {
            #region
            //Student student = new Student("Ali", "Rahimzada", 12, 9);
            //student.GetFullInfo();
            //WriteLine("--------------------------------");
            //Worker worker = new Worker(1000, "Ulviyye", "Rahimova", 30);
            //worker.GetFullInfo();
            //WriteLine("--------------------------------");
            //Person person = new Person("Farhad", "Rahimov", 33);
            //person.GetFullInfo();
            //WriteLine("--------------------------------");
            //Manager manager = new Manager("Sebine", "Orucova", 29, 1000,  worker.Name);
            //manager.Members = new List<Worker> { worker, new Worker { Salary = 1000,  Name = "Akif", Surname = "Orucov", Age = 60} };
            //manager.GetFullInfo();
            //WriteLine("--------------------------------");

            //ReadLine();
            #endregion

            Animal animal = new Cat();
            animal.Sound();

            ReadKey();
        }
    }
}
