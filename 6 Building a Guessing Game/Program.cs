using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Building_a_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            string secretWord = "Maria";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess!=secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Quem é a moçinha mais linda do mundo?? ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true; // bool flag
                }
            }


            if (outOfGuesses)
            {
                Console.WriteLine("Já te foste!");
            }
            else
            {
                Console.Write("Boa, acertaste no nome da menina!");
            }
            

            Console.ReadLine();
        }
    }
}
