using ExFixHerancaPolimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExFixHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler os dados de N contribuintes (N fornecido pelo usuário), os quais
            podem ser pessoa física ou pessoa jurídica, e depois mostrar o valor do imposto pago por cada um,
            bem como o total de imposto arrecadado.
            Os dados de pessoa física são: nome, renda anual e gastos com saúde. Os dados de pessoa jurídica
            são nome, renda anual e número de funcionários. As regras para cálculo de imposto são as
            seguintes:
            Pessoa física: pessoas cuja renda foi abaixo de 20000.00 pagam 15% de imposto. Pessoas com
            renda de 20000.00 em diante pagam 25% de imposto. Se a pessoa teve gastos com saúde, 50%
            destes gastos são abatidos no imposto.
            Exemplo: uma pessoa cuja renda foi 50000.00 e teve 2000.00 em gastos com saúde, o imposto
            fica: (50000 * 25%) - (2000 * 50%) = 11500.00
            Pessoa jurídica: pessoas jurídicas pagam 16% de imposto. Porém, se a empresa possuir mais de 10
            funcionários, ela paga 14% de imposto.
            Exemplo: uma empresa cuja renda foi 400000.00 e possui 25 funcionários, o imposto fica:
            400000 * 14% = 56000.00
             */

            List<Contribuinte> list = new List<Contribuinte>();

            Console.Write("Entre com o número de contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do Contribuinte #{i}: ");
                Console.Write("Pessoa Fisica ou Pessoa Juridica (f / j)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda Anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'f')
                {
                    Console.Write("Despesas de saúde: ");
                    double despesasSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(nome, rendaAnual, despesasSaude));
                }
                else
                {
                    Console.Write("Número de Funcionarios: ");
                    int numFunc = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PessoaJuridica(nome, rendaAnual, numFunc));
         
                }

            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("IMPOSTOS PAGOS: ");
            foreach (Contribuinte contr in list)
            {
                double tx = contr.Taxa();
                Console.WriteLine(contr.Nome + ": $ " + tx.ToString("F2", CultureInfo.InvariantCulture));
                sum += tx;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXAS: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
