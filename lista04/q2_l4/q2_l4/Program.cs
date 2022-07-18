using System;

namespace Questao05_l4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um inteiro para saber seu fatorial:");
            int n = int.Parse(Console.ReadLine());
            int fat = 1;
         
            for (; n >= 1; n--)
            {
                fat *= n;
            }

            Console.WriteLine(fat);
        }
    

    }
}