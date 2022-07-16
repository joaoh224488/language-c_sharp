using System;
using System.Globalization;

namespace Questao06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os valores de A, B e C separados por espaço:");
            string[] vet = Console.ReadLine().Split(' ');

            double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double pi = 3.14159;

            Console.WriteLine($"Área do triângulo formado por {A.ToString("F2", CultureInfo.InvariantCulture)} como base e {C.ToString("F2", CultureInfo.InvariantCulture)} como altura é {((A * C) / 2.0).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área do círculo de raio {C.ToString("F2", CultureInfo.InvariantCulture)} é {(pi * Math.Pow(C, 2.0)).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área do trapézio com bases {A.ToString("F2", CultureInfo.InvariantCulture)} e {B.ToString("F2", CultureInfo.InvariantCulture)} e altura {C.ToString("F2", CultureInfo.InvariantCulture)} é {(((A + B) * C) /2.0).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área do quadrado de lado {B.ToString("F2", CultureInfo.InvariantCulture)} é {(Math.Pow(B, 2.0)).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área do retângulo de lados {A.ToString("F2", CultureInfo.InvariantCulture)} e {B.ToString("F2", CultureInfo.InvariantCulture)} é {(A * B).ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}