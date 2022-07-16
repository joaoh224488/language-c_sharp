using System;
using System.Globalization;

namespace Questao05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Código, número de peças e preço da peça 1");
            string[] vet1 = Console.ReadLine().Split(", ");
            Console.WriteLine("Código, número de peças e preço da peça 2");
            string[] vet2 = Console.ReadLine().Split(", ");

            int cod1 = int.Parse(vet1[0]);
            int cod2 = int.Parse(vet2[0]);

            int n1 = int.Parse(vet1[1]);
            int n2 = int.Parse(vet2[1]);

            double price1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);
            double price2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            Console.WriteLine($"VALOR A PAGAR: R$ {((price1 * n1) + (price2 * n2)).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}