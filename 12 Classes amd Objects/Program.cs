using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Classes_amd_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();        // book object
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();        // book object
            book2.title = "Lord of the Reings";
            book2.author = "Tolkein";
            book2.pages = 700;


            Console.WriteLine(book1.pages);

            Console.ReadLine();
        }
    }
}
