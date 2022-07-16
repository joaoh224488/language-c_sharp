using System;

namespace testes
{
    class program
    {
        static void Main(string[] args)
        {
            float numero_flutuante = 8.9f;
            double outro = 8.9;
            object obj1 = "Teste com string"; // Tipo genérico do C#
            object obj2 = 3.5;

            decimal maior = decimal.MaxValue; // Dá pra puxar o MaxValue ou MinValue
                                              // de qualquer tipo assim

            Console.WriteLine($"Número float:    {numero_flutuante}");
            Console.WriteLine($"Número double:   {outro}");
            Console.WriteLine($"Print do obj1:   {obj1}");
            Console.WriteLine($"Print do obj2    {obj2}");
            Console.WriteLine($"Maior número possível em c# {maior}");
        }
    }
}