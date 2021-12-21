using System;
using System.Globalization;

namespace Aula24_ExercicioResolvido2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b, a, perimetro, diagonal,area;
            b = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = b * a;
            perimetro = ((2 * b) + (2 * a));
            diagonal = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("Área = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = "+diagonal.ToString("F4",CultureInfo.InvariantCulture));
        }
    }
}
