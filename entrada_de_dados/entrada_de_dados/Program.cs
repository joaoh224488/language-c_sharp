using System;

namespace Ent
{
    class Entradas
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:    ");
            string frase = Console.ReadLine(); // lê uma linha inteira
            Console.WriteLine($"Você digitou {frase}");

            Console.WriteLine("Digite mais três frases:  ");

            string x, y, z;

            x = Console.ReadLine();
            y = Console.ReadLine();
            z = Console.ReadLine();

            Console.WriteLine($"x:   {x}");
            Console.WriteLine($"y:   {y}");
            Console.WriteLine($"z:   {z}");

            // Separando palavra por palavra

            Console.WriteLine("Digite outra frase: ");

            string[] vet = Console.ReadLine().Split(' ');

            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine($"p1 : {p1}");
            Console.WriteLine($"p2 : {p2}");
            Console.WriteLine($"p3 : {p3}");
        }

    }
}