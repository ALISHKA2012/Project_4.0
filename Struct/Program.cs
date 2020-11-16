using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book
            {
                Title = "Harry Poter,",
                Author = "Jim KewRowling,",
                Price = 15
            };
            book.Read();
            book.Read(20);
            Console.WriteLine(book.ToString());

            Console.ReadLine();
        }
    }
}
