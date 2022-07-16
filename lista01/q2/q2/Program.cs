using System;
using System.Globalization;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            Console.WriteLine("Digite o valor do raio:  ");

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * Math.Pow(raio, 2.0);

            Console.WriteLine($"O Valor da área é {area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}