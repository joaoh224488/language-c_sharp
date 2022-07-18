using System;

namespace Questao03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A:");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C:");
            int C = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de D:");
            int D = int.Parse(Console.ReadLine());

            int dif = (A * B - C * D);

            Console.WriteLine($"DIFERENCA = {dif}");  
        }
    }
}