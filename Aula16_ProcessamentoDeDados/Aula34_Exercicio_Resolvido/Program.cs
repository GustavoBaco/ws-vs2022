using System;
using System.Globalization;

namespace Aula34_Exercicio_Resolvido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c,delta,x1,x2;
            string[] vet;

            vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2) - (4 * a * (c));
            if (delta > 0)
            {
                if (a > 0)
                {
                    x1 = ((b*(-1)) + Math.Sqrt(delta)) / (2 * a);
                    x2 = ((b*(-1)) - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("R1 = "+x1.ToString("F5",CultureInfo.InvariantCulture));
                    Console.WriteLine("R2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Impossivel calcular");
                }
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }
        }
    }
}
