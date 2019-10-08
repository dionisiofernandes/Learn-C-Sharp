using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O que disse ele?");
            string disse = Console.ReadLine(); // define a strin pelo prompt da consola
            Console.WriteLine("Ele Disse: " + disse+ " ... e foi só isto!");
            
            
            //Trabalhando com Strings
            Console.WriteLine(disse.ToUpper()); //converte para capital
            Console.WriteLine(disse.ToLower()); //converte para lowercase
            Console.WriteLine(disse.Contains("coisas")); // Valida se coisas está contido na variavel
            Console.WriteLine(disse[0]); //Devolve o primeiro caracter contdo na String (index)
            Console.WriteLine(disse.IndexOf("nada")); // Devolve a posição de "nada" dentro da string - Caso =-1 significa que nao está presente.
            Console.WriteLine(disse.Substring(5,4)); // devolde os 4 caracteres iniciando na 4ª posição da string

            //Trabalhando com Numeros
            Console.WriteLine(2 + 1); //Adição
            Console.WriteLine(5 - 1); //Subtração
            Console.WriteLine(5 * 1); //Multiplicação
            Console.WriteLine(5 / 2); //Divisão
            Console.WriteLine(5 % 2); // Modulo 

            Console.WriteLine(5 / 2); // Embora decimal, vai devolver uma int.

            int num = 6; // define a int =6
            num++;  // incrementa a int em +1 
            Console.WriteLine(num);

            // usando o metodo Math

            Console.WriteLine(Math.Abs(-40)); // devolve o valor abloluto (neste caso 40)
            Console.WriteLine(Math.Pow(3, 2)); // potencia (equivale 3^2)
            Console.WriteLine(Math.Sqrt(36)); // raiz quadrada de 36
            Console.WriteLine(Math.Max(4, 90)); // devolve o valor maior 
            Console.WriteLine(Math.Min(4, 90)); // devolve o valor minimo







            //Para pausar e ver os resultados
            Console.ReadLine();

        }
    }
}
