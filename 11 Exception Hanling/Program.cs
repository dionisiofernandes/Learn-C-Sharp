using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Exception_Hanling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter another nmber: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }

            catch(DivideByZeroException e)
            {
                Console.WriteLine("Mas tás parvo?? " + e.Message);
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            finally // é sempre executado mesmo apesar de erros
            {
                Console.WriteLine("Esta Terminou");
            }

            Console.ReadLine();
        }
    }
}
