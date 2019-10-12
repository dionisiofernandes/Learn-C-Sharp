using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_For_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("Final do Loop while!");

            // definimos os 3 paramatros inicialiçação das variaveis, condições do loop e o que acontece a cada iteração do loop.

            for (int y = 1; y <= 5; y++) 
            {
                Console.WriteLine(y);
            }

            Console.WriteLine("Final do Loop For!");

            // Aqui usamos um array de numeros como base para o loop

            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

            for (int x = 0; x < luckyNumbers.Length; x++) 
            {
                Console.WriteLine(luckyNumbers[x]);
            }
            Console.WriteLine("Final do Loop For num array!");

            Console.ReadLine();
        }
    }
}
