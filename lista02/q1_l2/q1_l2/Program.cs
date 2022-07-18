using System;

namespace Questao01_l2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                Console.WriteLine($"{n} é positivo.");
            }
            else if (n < 0)
            {
                Console.WriteLine($"{n} é negativo");
            }
            else
            {
                Console.WriteLine("O número é 0.");
            }
        }
    }
}