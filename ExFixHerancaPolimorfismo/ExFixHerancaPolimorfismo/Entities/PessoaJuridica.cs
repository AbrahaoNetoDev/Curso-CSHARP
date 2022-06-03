using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFixHerancaPolimorfismo.Entities
{
    class PessoaJuridica : Contribuinte
    {
        public int NumFuncionarios { get; set; }

        public PessoaJuridica()
        {

        }

        public PessoaJuridica(string nome, double rendaAnual, int numFuncionarios) : base(nome, rendaAnual)
        {
            NumFuncionarios = numFuncionarios;
        }

        public override double Taxa()
        {
            if (NumFuncionarios < 10)
            {
                return RendaAnual * 016;
            }
            else
            {
                return RendaAnual * 0.14;
            }
        }
    }
}
