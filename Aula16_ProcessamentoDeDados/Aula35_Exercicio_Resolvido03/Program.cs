using System;

namespace Aula35_Exercicio_Resolvido03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            string[] vet;
            vet = Console.ReadLine().Split(' ');

            
            a = int.Parse(vet[0]);
            
            b = int.Parse(vet[1]);
            
            c = int.Parse(vet[2]);

            if(a < b && a < c)
            {
                Console.WriteLine("MENOR = " + a);
            }
            else if (b < a && b < c)
            {
                Console.WriteLine("MENOR = " + b);
            }
            else if (c < a && c < b)
            {
                Console.WriteLine("MENOR = " + c);
            }
            else
            {
                Console.WriteLine("MENOR = " + a);
            }

        }
    }
}
