using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;


namespace Delegates2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person(1, "Albert", 10000, 28),
                new Person(2, "Ali", 1000, 9),
                new Person(3, "Omar", 505, 9),
                new Person(4, "Ulviyye", 450, 20),
                new Person(5, "Farhad", 450, 24),
            };
            Database<Person> peopleData = new Database<Person>(people);

            var collection = peopleData.Find(p => p.Salary == 420);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
