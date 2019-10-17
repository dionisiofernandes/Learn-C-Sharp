using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Static_Class_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount); // atributos sobre a classe e não relacionado directamente com cada um dos atribuidos.

            Song Kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Kashmir.getSongCount());


            Console.ReadLine();

        }
    }
}
