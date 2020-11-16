using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    public struct Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

        public Book(int id, string title, string author, decimal price)
        {
            
            Title = title;
            Author = author;
            Price = price;
            Id = id;
        }

        public override string ToString()
        {
            return $"{Title} {Author} {Price}$";
        }

        public void Read()
        {
            Console.WriteLine("Reading...");
        }
        public void Read(int page)
        {
            Console.WriteLine($"Reading page number {page}");
        }
        private int GenerateId()
        {
            return new Random().Next();
        }
    }
    public struct Magazine
    {
        private int _magazine_number;
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

        public Magazine(int magNumber, int id, string title, string author, decimal price)
        {
            _magazine_number = magNumber;
            Title = title;
            Author = author;
            Price = price;
            Id = id;
        }
    }

}
