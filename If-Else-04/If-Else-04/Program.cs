using System;

namespace If_Else_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(' ');
            int N1 = Convert.ToInt32(numeros[0]);
            int N2 = Convert.ToInt32(numeros[1]);

            if (N1 % N2 == 0 || N2 % N1 == 0)
            {
                Console.WriteLine("São multiplos");
            }
            else
            {
                Console.WriteLine("Não são multiplos");
            }
        }
    }
}
