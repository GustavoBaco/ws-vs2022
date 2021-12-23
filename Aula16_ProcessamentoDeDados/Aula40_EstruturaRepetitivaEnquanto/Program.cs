using System;

namespace Aula40_EstruturaRepetitivaEnquanto_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x,soma;

            x = int.Parse(Console.ReadLine());
            soma = 0;
            while (x != 0) // Enquanto a condição for verdadeira, entra no laço de repetição. Quando for falso,pula fora do laço.
            {
                soma = soma + x;
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(soma); ;
            Console.ReadLine();
        }
    }
}
