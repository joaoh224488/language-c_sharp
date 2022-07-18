using System;
using System.Globalization;

namespace Questao08_l2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu salário:  ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double soma = 0.0;

            if (salario < 0)
            {
                Console.WriteLine("Erro!");
                return;
            }
            else if (salario > 0 && salario <= 2000.0)
            {
                Console.WriteLine("Isento.");
                return;
            }
            else if (salario > 2000.0)
            {
                if (salario <= 3000)
                {
                    salario -= 2000;
                    soma += salario  * 8.0 / 100;
                }
                else if (salario <= 4500)
                {
                    soma += 1000 * 8.0 / 100;
                    salario -= 3000;
                    soma += salario * 18.0 / 100;
                }
                else if (salario > 4500)
                {
                    soma += 1000 * 8.0 / 100;
                    salario -= 3000;

                    soma += 1500 * 18.0 / 100;
                    salario -= 1500;

                    soma += salario * 28.0 / 100;

                }
              
            }
            Console.WriteLine($"R$ {soma.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}