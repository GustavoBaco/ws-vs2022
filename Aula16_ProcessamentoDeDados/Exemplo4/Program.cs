using System;

namespace Exemplo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double resultado;

            a = 5;
            b = 2;

            resultado = (double) a / b; //A linguagem vai truncar a casas decimais, para converter preciso fazer o casting.

            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}
