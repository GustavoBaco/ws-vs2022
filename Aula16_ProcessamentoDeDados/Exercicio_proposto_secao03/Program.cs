using System;
using System.Globalization;

namespace Exercicio_proposto_secao03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa ? ");
            int qtd_quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o preço do produto:");
            double vlrProduto = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe seu último nome, idade e altura (na mesma linha): ");
            string [] vet = Console.ReadLine().Split(' ');
            string sobrenome =  vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2],CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(nome);
            Console.WriteLine(qtd_quartos);
            Console.WriteLine(vlrProduto);
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
