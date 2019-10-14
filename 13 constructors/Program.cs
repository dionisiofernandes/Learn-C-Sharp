using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);        // book object

            Book book2 = new Book("Lord of the Reings", "Lord of the Reings", 700);        // book object

            Console.WriteLine(book2.title);

            Console.ReadLine();
        }
    }
}
