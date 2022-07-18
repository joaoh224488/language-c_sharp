using System;
using System.Globalization;

namespace Questao05_l2
{
    class Program
    {
        static void Main(string[] args)
        {

            int cod;
            int quantidade;
            string nome;
            double preco;
            double valor_produto;

            double soma = 0;
            bool continuar = true;
            
            while (continuar)
            {
                Console.WriteLine("Digite o código produto e a quantidade: ");
                string[] vet = Console.ReadLine().Split(" ");

                cod = int.Parse(vet[0]);
                quantidade = int.Parse(vet[1]);

                switch (cod)
                {
                    case 1:
                        nome = "Cachorro quente";
                        preco = 4.00;
                        break;
                    case 2:
                        nome = "X-Salada";
                        preco = 4.50;
                        break;
                    case 3:
                        nome = "X-Bacon";
                        preco = 5.00;
                        break;
                    case 4:
                        nome = "Torrada Simples";
                        preco = 2.00;
                        break;
                    case 5:
                        nome = "Refrigerante";
                        preco = 1.50;
                        break;
                    default:
                        nome = " ";
                        preco = 0;
                        break;
                }

                valor_produto = quantidade * preco;
                Console.WriteLine($"O valor de {quantidade} produto(s) de código {cod}, isto é {nome}, foi R$ {valor_produto.ToString("F2")}");

                soma += valor_produto;

                Console.WriteLine("Continuar? s/n");

                string resp = Console.ReadLine();


                if (resp == "s")
                {
                    continuar = true;
                }
                else
                {
                    continuar = false;
                }
            }
            Console.WriteLine($"O total deu R$ {soma.ToString("F2")}");

        }
    }
}