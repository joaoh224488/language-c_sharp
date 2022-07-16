using System;
using System.Globalization;

namespace Questao04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número do funcionário:   ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Número de horas trabalhadas:   ");
            double horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor da hora:   ");
            double per_hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"NUMBER =  {number}");
            Console.WriteLine($"SALARY = U$ {(horas * per_hour).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}