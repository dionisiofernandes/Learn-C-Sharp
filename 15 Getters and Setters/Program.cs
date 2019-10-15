using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Getters_and_Setters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG");
            Movie shreck = new Movie("Shrek", "Adam Adamson", "PG");
            Console.WriteLine(avengers.Rating);

            Console.ReadLine();
        }
    }
}
