using System;

namespace Questao02_l02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:    ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine($"{n} é par.");
            }
            else
            {
                Console.WriteLine($"{n} é ímpar.");
            }
        }
    }
}