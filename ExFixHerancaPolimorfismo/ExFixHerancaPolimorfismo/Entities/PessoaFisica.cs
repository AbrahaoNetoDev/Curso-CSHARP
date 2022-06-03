using ExFixHerancaPolimorfismo.Entities;

namespace ExFixHerancaPolimorfismo.Entities
{
    class PessoaFisica : Contribuinte
    {
        public double DespesasSaude { get; set; }

        public PessoaFisica()
        {

        }

        public PessoaFisica(string nome, double rendaAnual, double despesasSaude) : base(nome, rendaAnual)
        {
            DespesasSaude = despesasSaude;
        }

        public override double Taxa()
        {
            if (RendaAnual < 20000.00)
            {
                return RendaAnual * 0.15 - DespesasSaude * 0.5;
            }
            else
            {
                return RendaAnual * 0.25 - DespesasSaude * 0.5;
            }
        }
    }
}
