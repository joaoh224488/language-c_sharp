using System;
using System.Globalization;

namespace exercicio_de_aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o seu nome completo:");
            string nome_completo = Console.ReadLine();
            Console.WriteLine($"Nome: {nome_completo}");

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int q_quartos = int.Parse(Console.ReadLine());
            Console.WriteLine($"Quantidade de quartos: {q_quartos}");

            Console.WriteLine("Entre com o preço de um produto:");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Preço:  {price.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("Entre com o seu último nome, idade e altura (mesma linha)");

            string[] vet = Console.ReadLine().Split(' ');
            string last_name = vet[0];
            int nova_idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine($"{last_name} {nova_idade} {altura.ToString("F2",CultureInfo.InvariantCulture)}");






        }
    }
}