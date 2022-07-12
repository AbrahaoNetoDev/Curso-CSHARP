using System;

namespace Exe6For
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ler um número inteiro N e calcular todos os seus divisores.
             */

            Console.Write("Digite um número para saber seus divisores: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
