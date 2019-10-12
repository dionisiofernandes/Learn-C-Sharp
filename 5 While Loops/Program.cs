using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            //While Valida a contição e enquanto esta for verdade, executa o codigo dentro das {}

            int index = 1;
            while (index <=500)
            {
                Console.WriteLine(index);
                index++;
            }
            Console.ReadLine();

            //Do while executa o codigo dentro das {} antes de validar a condição

            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 600);
             Console.ReadLine();





        }
    }
}
