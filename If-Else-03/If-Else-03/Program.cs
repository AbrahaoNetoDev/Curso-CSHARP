using System;

namespace If_Else_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tempo = Console.ReadLine().Split(' ');
            int tempInicial = Convert.ToInt32(tempo[0]);
            int tempFinal = Convert.ToInt32(tempo[1]);

            int duracao;
            if (tempInicial < tempFinal)
            {
                duracao = tempFinal - tempInicial;
            }
            else
            {
                duracao = 24 - tempInicial + tempFinal;
            }

            Console.WriteLine("O JOGO DUROU " +  duracao + " HORA(S)");


        }
    }
}
