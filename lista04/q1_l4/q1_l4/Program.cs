using System;

namespace Questao01_l4
{
    class Program
    {
        static void Main(string[] args)
        {
            impares_ate_n(8);
        }

        static void impares_ate_n(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
            }
        }
        static void pares_ate_n(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}