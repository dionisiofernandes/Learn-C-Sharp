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
            Console.WriteLine("Ele Disse: " + disse + " ... e foi só isto!");


            //Trabalhando com Strings
            Console.WriteLine(disse.ToUpper()); //converte para capital
            Console.WriteLine(disse.ToLower()); //converte para lowercase
            Console.WriteLine(disse.Contains("coisas")); // Valida se coisas está contido na variavel
            Console.WriteLine(disse[0]); //Devolve o primeiro caracter contdo na String (index)
            Console.WriteLine(disse.IndexOf("nada")); // Devolve a posição de "nada" dentro da string - Caso =-1 significa que nao está presente.
            Console.WriteLine(disse.Substring(5, 4)); // devolde os 4 caracteres iniciando na 4ª posição da string

            //Trabalhando com Numeros
            Console.WriteLine(2 + 1); //Adição
            Console.WriteLine(5 - 1); //Subtração
            Console.WriteLine(5 * 1); //Multiplicação
            Console.WriteLine(5 / 2); //Divisão
            Console.WriteLine(5 % 2); // Modulo 

            Console.WriteLine(5 / 2); // Embora decimal, vai devolver uma int qunado são 2 ints
            Console.WriteLine(5 / 2.0); // vai devolver uma decimal qunado são pelo menos uma decimal

            int num = 6; // define a int =6
            num++;  // incrementa a int em +1 
            Console.WriteLine(num);

            // usando o metodo Math

            Console.WriteLine(Math.Abs(-40)); // devolve o valor abloluto (neste caso 40)
            Console.WriteLine(Math.Pow(3, 2)); // potencia (equivale 3^2)
            Console.WriteLine(Math.Sqrt(36)); // raiz quadrada de 36
            Console.WriteLine(Math.Max(4, 90)); // devolve o valor maior 
            Console.WriteLine(Math.Min(4, 90)); // devolve o valor minimo

            // Converter Strings para numeros
            Console.WriteLine("45" + "23"); // Apenas vai contatenar as 2 strings.

            int num2 = Convert.ToInt32("45"); // coverte a string "45" para o num 45
            Console.WriteLine(num2 + 5);    // Adiciona 5 ao valor de num2

            Console.Write("Enter your number: ");
            decimal num01 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter another number: ");
            decimal num02 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(num01 + num02);

            //Arrays 
            int[] luckyNumbers = { 4, 8, 10, 15, 18, 22 }; //decralrar e atribuir valores ao arrays
            Console.WriteLine(luckyNumbers[0]); // devolve o valor donindex 0 no array.
            luckyNumbers[2] = 50; // atualiza o valor do index 2 (10 no caso acima) para 50

            string[] friends = new string[5]; // cria uma array vazio que consegue comportar 5 valores
            friends[0] = "Jim"; // Assigna a string no valor do index 0
            friends[1] = "Tim"; // Assigna a string no valor do index 1
            friends[2] = "Pim"; // Assigna a string no valor do index 2
            friends[3] = "Lim"; // Assigna a string no valor do index 3
            friends[4] = "Xim"; // Assigna a string no valor do index 4

            //Metodos

            SayHi("Mike"); // Chama o metodo e executa-o - A string é passada para o metodo. - Chama-se caller

            //IF statements

            bool isMale = true;
            bool isTall = true;

            if (isMale && !isTall) // %% - Operador And. // || - Operador Or. 

            {
                Console.WriteLine("You are Male! and Tall");
            } else

            {
                Console.WriteLine("You are not Male or Tall or Both");
            }

            //Is statements Comparações
            // No projeto Learn ConsoleApp

            //Para pausar e ver os resultados
            Console.ReadLine();

        }

        static void SayHi(string name)
        {

            Console.WriteLine("Hello " + name);

        }

 

}
}
