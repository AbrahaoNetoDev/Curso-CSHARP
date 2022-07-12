using System;
using System.Collections.Generic;

namespace treinar
{
    class Program
    {
        static void Main(string[] args)
        {
            //var valores = new Int32[20] { -15, -2, 21, -8, 59, -81, 3, 4, -36, 7, 5, 92, -1, -78, -9, -59, 82, -3, -46, 38 };

            //for (int i = 0; i < valores.Length; i++)
            //{
            //    if (valores[i] % 2 == 0)
            //    {
            //        Console.WriteLine(valores[i] + " PAR");
            //    }
            //    else
            //    {
            //        Console.WriteLine(valores[i] + " IMPAR");
            //    }
            //}

            //var valores = new Int32[20] { -15, -2, 21, -8, 59, -81, 3, 4, -36, 7, 5, 92, -1, -78, -9, -59, 82, -3, -46, 38 };
            //var listaPositivo = new List<Int32>();
            //var listaNegativo = new List<Int32>();

            //for (int i = 0; i < valores.Length; i++)
            //{
            //    if (valores[i] > 0)
            //    {
            //        listaPositivo.Add(valores[i]);
            //    }
            //    else
            //    {
            //        listaNegativo.Add(valores[i]);
            //    }
            //}

            //for (int i = 0; i < listaPositivo.Count; i++)
            //{
            //    Console.Write(listaPositivo[i] + ", ");
            //}

            //Console.WriteLine("");

            //for (int i =0; i < listaNegativo.Count; i++)
            //{
            //    Console.Write(listaNegativo[i] + ", ");
            //}





            //var valores = new Int32[20] { -15, -2, 21, -8, 59, -81, 3, 4, -36, 7, 5, 92, -1, -78, -9, -59, 82, -3, -46, 38 };

            //for (int i = 0; i < valores.Length; i++)
            //{
            //    if (valores[i] % 11 == 0)
            //    {
            //        Console.WriteLine(valores[i]);
            //    }
            //}

            //var valores = new Int32[20] { -15, -2, 21, -8, 59, -81, 3, 4, -36, 7, 5, 92, -1, -78, -9, -59, 82, -3, -46, 38 };

            //for (int i = 0; i < valores.Length; i++)
            //{
            //    if (valores[i] % 2 == 0 && valores[i] < 0)
            //    {
            //        Console.WriteLine(valores[i] + " PAR NEGATIVO");
            //    }
            //}

            //var valores = new Int32[20] { -15, -2, 21, -8, 59, -81, 3, 4, -36, 7, 5, 92, -1, -78, -9, -59, 82, -3, -46, 38 };

            //for (int i = 0; i < valores.Length; i++)
            //{
            //    if (valores[i] % 2 != 0 && valores[i] > 0)
            //    {
            //        Console.WriteLine(valores[i] + " IMPAR POSITIVO");
            //    }
            //}

            //var valores = new Int32[20] { -15, -2, 21, -8, 59, -81, 3, 4, -36, 7, 5, 92, -1, -78, -9, -59, 82, -3, -46, 38 };

            //for (int i = 0; i < valores.Length; i++)
            //{
            //    if (i + 1 >= valores.Length)
            //    {
            //        return;
            //    }

            //    if (valores[i] > valores[i +1])
            //    {
            //        Console.WriteLine("Sim: " + valores[i] + " | " + valores[i + 1]);
            //    }
            //}

            //var valores = new Int32[20] { -15, -2, 21, -8, 59, -81, 3, 4, -36, 7, 5, 92, -1, -78, -9, -59, 82, -3, -46, 38 };

            //int maiorValor = 0;

            //for (int i = 0; i < valores.Length; i++)
            //{
            //    if (valores[i] > maiorValor)
            //    {
            //        maiorValor = valores[i];
            //    }

            //    for (int j = i + 1; j < valores.Length; j++)
            //    {
            //        if (valores[j] > maiorValor)
            //        {
            //            maiorValor = valores[j];
            //        }
            //    }
            //}

            //Console.WriteLine("Maior valor: " + maiorValor);

            var valores = new Int32[20] { -15, -2, 21, -8, 59, -81, 3, 4, -36, 7, 5, 92, -1, -78, -9, -59, 82, -3, -46, 38 };

            int menorValor = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] < menorValor && valores[i] % 2 != 0)
                {
                    menorValor = valores[i];
                }

                for ( int j = i + 1; j < valores.Length; j++)
                {
                    if (valores[j] < menorValor && valores[j] % 2 != 0)
                    {
                        menorValor = valores[j];
                    }
                }
            }

            Console.WriteLine("Menor valor: " + menorValor);
        }
    }
}
