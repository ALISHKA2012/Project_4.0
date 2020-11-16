using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person(1, "Albert", 10000, 17),
                new Person(3, "Ali", 1000, 9),
                new Person(2, "Omar", 500, 6),
            };
            int[] numbers = { 5, 23, 55, 6, 3, 58, 12 };

            Database<Person> database = new Database<Person>(people);

            Array.Sort(numbers); 
            
            Database<int> database2 = new Database<int>(numbers.ToList());

          

            ShowData(database2);
            Console.Read();
        }
       
        private static void ShowData(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
