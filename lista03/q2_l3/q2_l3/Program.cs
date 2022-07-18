using System;

namespace Questao02_l3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int n1 = int.Parse(vet[0]);
                int n2 = int.Parse(vet[1]);

                if (n1 == 0 || n2 == 0)
                {
                    break;
                }
                quadrante(n1, n2);
            }
        }
        static void quadrante(int n1, int n2)
        {
            if (n1 > 0 && n2 > 0)
            {
                Console.WriteLine("Primeiro");
            }
            else if (n1 < 0 && n2 > 0){
                Console.WriteLine("Segundo");
            }
            else if (n1 < 0 && n2 < 0)
            {
                Console.WriteLine("Terceiro");
            }
            else if (n1 >0 && n2 < 0)
            {
                Console.WriteLine("Quarto");
            }
        }
    }
}