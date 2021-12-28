using System;

namespace Aula66_ExercicioResolvido01_Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] A;
            int N = int.Parse(Console.ReadLine());
            A = new int[N, N];

            for(int i = 0; i < N; i++)
            {
                string [] s = Console.ReadLine().Split(' ');
                for (int j = 0; j<N; j++)
                {
                    A[i,j] = int.Parse(s[j]);
                }
            }
            Console.WriteLine("Diagonal Pricipal: ");
            for(int i = 0; i < N; i++)
            {
                Console.Write(A[i, i] + " ");
            }
            Console.WriteLine();

            int cont = 0; 
            for(int i = 0; i <N; i++)
            {
                for (int j = 0;j<N; j++)
                {
                    if (A[i,j] < 0)
                    {
                        cont++;
                    }
                }
            }
            Console.WriteLine("Quantidade de negativos = " + cont);
        }
    }
}
