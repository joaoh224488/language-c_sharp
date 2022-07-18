using System;

namespace Questao01_l3
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 0;
            do
            {
                Console.WriteLine("Digite a senha:");
                senha = int.Parse(Console.ReadLine());
                if (senha == 2002)
                {
                    return;
                }
                Console.WriteLine("SENHA INVÁLIDA!");
                } while (true);
        }

        
        
    }
}