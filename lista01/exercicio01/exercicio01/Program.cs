using System;
using System.Globalization;

namespace exercicio01
{
    class MostrarProdutos
    {
        static void Main(string[] args)

        {
            string produto01 = "Computador";
            string produto02 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100;
            double preco2 = 650.5;
            double medida = 53.234567;

            Console.WriteLine("Produtos:    ");
            Console.WriteLine($"{produto01}, cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{produto02}, cujo preço é $ {preco2:F2}\n");
            Console.WriteLine($"Registro:   {idade} anos de idade, código {codigo} e gênero: {genero}\n");
            Console.WriteLine($"Medida com 8 casas decimais:    {medida}");
            Console.WriteLine($"Arredondando com  três casas:   {medida:F3} ");
            Console.WriteLine($"Separador decimal invariant culture:    {medida.ToString("F3", CultureInfo.InvariantCulture)}");

        }


    }
}