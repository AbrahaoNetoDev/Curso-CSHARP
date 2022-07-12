using System;
using System.Globalization;

namespace If_Else_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Cachorro quente = R$ 4.00
            //2 XSalada = R$ 4.50
            //3 XBacon = 5.00
            //4 Torrada simples = 2.00
            //5 Refrigerante = 1.50

            string[] valor = Console.ReadLine().Split(' ');
            int cod = Convert.ToInt32(valor[0]);
            int quant = Convert.ToInt32(valor[1]);

            double soma;
            if (cod == 1)
            {
                soma = quant * 4.0;
            }
            else if (cod == 2)
            {
                soma = quant * 4.5;
            }
            else if (cod == 3)
            {
                soma = quant * 5.0;
            }
            else if (cod == 4)
            {
                soma = quant * 2.0;
            }
            else
            {
                soma = quant * 1.5;
            }

            Console.WriteLine("Total: " + "R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
