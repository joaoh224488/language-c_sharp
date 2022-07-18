using System;

namespace Questao04_l2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a hora inicial e a final de um jogo considerando apenas a parte inteira de cada horário.");
            string[] vet = Console.ReadLine().Split(' ');

            int hora_inicial = int.Parse(vet[0]);
            int hora_final = int.Parse(vet[1]);
            int dif;

            if (hora_inicial  < hora_final)
            {
                dif = hora_final - hora_inicial;
            }
            else
            {
                dif = (24 % hora_inicial)  + hora_final;
            }
            Console.WriteLine($"O jogo durou {dif} hora(s)");
        }
    }
}