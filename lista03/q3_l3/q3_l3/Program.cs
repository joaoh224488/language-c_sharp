using System;

namespace Questa003_l3
{
    class Program
    {
        static void Main(string[] args)
        {
            int q1 = 0, q2 = 0, q3 = 0;
            
            int cod = 0;

            while (cod != 4)
            {

             
                Console.WriteLine("Digite o código da compra:   ");
                cod = int.Parse(Console.ReadLine());
            

                if (cod == 1)
                {
                    q1++;
                }
                else if (cod == 2)
                {
                    q2++;
                }
                else if (cod == 3)
                {
                    q3++;
                }
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Álcool {q1}");
            Console.WriteLine($"Gasolina {q2}");
            Console.WriteLine($"Diesel {q3}");


        }
    }
}