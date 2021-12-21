using System;
using System.Globalization;

namespace Aula20_ExercicioResolvido_Secao03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a lagura do terreno: ");
            double L = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o comprimento do terreno: ");
            double C = double.Parse(Console.ReadLine());
            double area = L * C;
            Console.WriteLine("Informe o valor do metro quadrado de um terreno: ");
            double VlrArea = double.Parse(Console.ReadLine());
            double VlrTerreno = area * VlrArea;
            Console.WriteLine("Área = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor do terreno = " + VlrTerreno.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
