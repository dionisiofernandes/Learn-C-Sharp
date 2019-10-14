using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Building_an_Exponent_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetPow(3, 2));
            Console.ReadLine();
        }

        static int GetPow(int basenum, int pownum)
        {
            int result =1;

            for (int i=0; i<pownum; i++) // loop quantas vezes quanto o powNum
            {
                result = result * basenum;
            }

            return result;
        }

    }
}
