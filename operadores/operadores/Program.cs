using System;

namespace Operadores
{
    class Bhaskara
    {
        static void Main(string[] args)
        {
            double a = 1.0, b = -3.0, c = -4;

            double delta = Math.Pow(b, 2.0) - 4 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);

            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
      
            string equacao = $"{a}x² {b}x {c} = 0";

            Console.WriteLine($"{equacao}\ndelta = {delta}\nx1 = {x1} \nx2 = {x2}");
        }
    }
}