using System;
using System.Globalization;

namespace Dados2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome as informações:    ");

            string[] vet = Console.ReadLine().Split(' ');

            string nome = vet[0];
            char gen = char.Parse(vet[1]);
            int age = int.Parse(vet[2]);
            double height = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Gênero: {gen}");
            Console.WriteLine($"Idade:  {age}");
            Console.WriteLine($"Altura: {height.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}