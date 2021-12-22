using System;
using System.Globalization;

namespace Aula33_Exercicio_Resolvido01_EstruturaCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double N1, N2, sum;

            Console.WriteLine("Informe a primeira nota do aluno: ");
            N1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a segunda nota do aluno: ");
            N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            sum = N1 + N2;

            if (sum < 60.00)
            {
                Console.WriteLine("Nota final = " + sum.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno Reprovado!");
            }
            else
            {
                Console.WriteLine("Nota final = " + sum.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno Aprovado!");
            }

        }
    }
}
