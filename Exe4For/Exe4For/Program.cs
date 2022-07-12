using System;
using System.Globalization;

namespace Exe4For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com um número: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                int x = int.Parse(line[0]);
                int y = int.Parse(line[1]);

                if (y == 0)
                {
                    Console.WriteLine("Divisão impossivel");
                }
                else
                {
                    double divisao = (double)x / y;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                    
                }
                
            }
        }
    }
}
