using System;

namespace ExeFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com um valor? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine(N);
        }
    }
}
