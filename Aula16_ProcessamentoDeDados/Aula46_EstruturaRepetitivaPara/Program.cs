using System;

namespace Aula46_EstruturaRepetitivaPara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, x, soma;

            N = int.Parse(Console.ReadLine());
            soma = 0;
            for (int i=1 ; i <=N; i++ ) // i++ = i= i+i
            {
                x = int.Parse(Console.ReadLine());
                soma = soma + x;
            }
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
