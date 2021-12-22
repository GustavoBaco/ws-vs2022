using System;
using System.Globalization;

namespace Exercicio_1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioFixo, totalReceber, vendasEfetuadas;

            nome = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            vendasEfetuadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalReceber = vendasEfetuadas * 15 / 100 + salarioFixo;

            Console.WriteLine("TOTAL = R$ " + totalReceber.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
