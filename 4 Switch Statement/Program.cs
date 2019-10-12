using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDay(5));

            Console.ReadLine();
        }

        static string GetDay(int dayNum)
        {
            string dayname;

            switch (dayNum)
            {
                case 0:
                    dayname = "Domingo";
                    break;
                case 1:
                    dayname = "Segunda-feira";
                    break;
                case 2:
                    dayname = "Terça-feira";
                    break;
                case 3:
                    dayname = "Quarta-feira";
                    break;
                case 4:
                    dayname = "Quinta-feira";
                    break;
                case 5:
                    dayname = "Sexta-feira";
                    break;
                case 6:
                    dayname = "Sabado";
                    break;
                default:
                    dayname = "Dia inválido!";
                    break;
            }



            return dayname;

        }

    }
}
