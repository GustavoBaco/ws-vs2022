using System;

namespace Aula_49_ExercicioResolvido_1078
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entrada de um número inteiro.
            int N,cont,multi;
            cont = 0;
            N = int.Parse(Console.ReadLine());

            //Processamento para efetuação da tabuada.
            for (int i = 0; i <10; i++)
            {
                if ( N >= 2 && N <= 1000)
                {
                    cont = cont + 1;
                    multi = N * cont;

                    Console.WriteLine(cont + " x " + N + " = " + multi);
                }
                else
                {

                }
               

            }

        }
    }
}
