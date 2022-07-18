using System;

namespace Questao03_l2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números");

            string[] vet = Console.ReadLine().Split(" ");

            int n1 = int.Parse(vet[0]);
            int n2 = int.Parse(vet[1]);

            
            if (n1 % n2 == 0 || n2 % n1 == 0)
            {
                Console.WriteLine($"{n1} e {n2} são múltiplos");
            }
            else
            {
                Console.WriteLine($"{n1} e {n2} não são múltiplos");
            }
           
    
        }
    }
}