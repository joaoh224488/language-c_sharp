using System;

namespace Questao01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            int primeiro = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:  ");
            int segundo = int.Parse(Console.ReadLine());

            Console.WriteLine($"SOMA = {primeiro + segundo}");
        }
    }
}