using System;
using System.Collections.Generic;

namespace treinar
{
    class Program
    {
        static void Main(string[] args)
        {
            //01 - Percorrer o array e exibir quais são os pares e impares.

            //02 - Retorna uma lista de números positivos, negativos.

            //03 - Retornar números múltiplos de 11.

            //04 - Retorna os numeros pares negativos.

            //05 - Retornar os números impares positivos.

            //06 - Informe se a posição corrente é maior que a proxima posição.

            //07 - Informe qual é o maior valor da lista.

            //08 - Informe qual é o menor valor impar da lista.

            //09 - Informe o menor valor par positivo.

            //10 - Informe o maior valor impar negativo.


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

            //var valores = new Int32[20] { -15, -2, 21, -8, 59, -81, 3, 4, -36, 7, 5, 92, -1, -78, -9, -59, 82, -3, -46, 38 };

            //int menorValor = 100;

            //for (int i = 0; i < valores.Length; i++)
            //{
            //    if (valores[i] < menorValor && valores[i] % 2 != 0)
            //    {
            //        menorValor = valores[i];
            //    }

            //    for ( int j = i + 1; j < valores.Length; j++)
            //    {
            //        if (valores[j] < menorValor && valores[j] % 2 != 0)
            //        {
            //            menorValor = valores[j];
            //        }
            //    }
            //}

            //Console.WriteLine("Menor valor: " + menorValor);

            //var valores = new Int32[20] { -15, -2, 21, -8, 59, -81, 3, 4, -36, 7, 5, 92, -1, -78, -9, -59, 82, -3, -46, 38 };

            //int menorValor = 100;

            //for (int i = 0; i < valores.Length; i++)
            //{
            //    if (valores[i] < menorValor && valores[i] % 2 == 0 && valores[i] > 0)
            //    {
            //        menorValor = valores[i];
            //    }
            //}

            //Console.WriteLine("Menor valor: " + menorValor);

            var valores = new Int32[20] { -15, -2, 21, -8, 59, -81, 3, 4, -36, 7, 5, 92, -1, -78, -9, -59, 82, -3, -46, 38 };

            int maiorValor = -100;

            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] > maiorValor && valores[i] % 2 != 0 && valores[i] < 0)
                {
                    maiorValor = valores[i];
                }
            }

            Console.WriteLine("Maior valor: " + maiorValor);
        }
    }
}

