using System;
using System.Globalization;

namespace Exercicio_areaDoCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine());
            double n = 3.14159;
            double area = n * Math.Pow(raio, 2);

            Console.WriteLine("A="+area.ToString("F4",CultureInfo.InvariantCulture));
        }
    }
}
