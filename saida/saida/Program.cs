using System;
using System.Globalization;

namespace Saidas
{
    class Program
    {
        static void Main(string[] args)
        {
            char gen = 'F';
            int age = 32;
            double saldo = 10.8632;
            string nome = "Maria";

            Console.Write(gen); // Write é o line sem o \n automático
            Console.WriteLine(nome);
            Console.WriteLine(saldo);
            Console.WriteLine($"Idade:  {age}");
            Console.WriteLine(saldo.ToString("F2")); // representa o número
                                                     // de casas desejado para o double ou float
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
            // Código acima para imprimir com ponto

            //Saídas com PlaceHolders:
            Console.WriteLine("{0} tem {1} anos e {2:F2} de saldo.", nome, age, saldo);

            // Saídas com Interpolação:
            Console.WriteLine($"{nome} tem {age} anos e R$ {saldo:F2} na conta.");

            // Saídas com Concatenação:
            Console.WriteLine(nome + " tem " + age + " anos .");
        }
    }
}