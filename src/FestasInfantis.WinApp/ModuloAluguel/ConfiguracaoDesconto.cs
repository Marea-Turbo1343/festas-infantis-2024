namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class ConfiguracaoDesconto
    {
        public decimal PorcentagemDesconto { get; set; }
        public decimal PorcentagemMaxima { get; set; }

        public ConfiguracaoDesconto(bool padrao)
        {
            if (padrao)
            {
                PorcentagemDesconto = 3M;
                PorcentagemMaxima = 30M;
            }
        }

        public ConfiguracaoDesconto()
        {
        }

        public void EditarDesconto(ConfiguracaoDesconto configuracaoDesconto)
        {
            PorcentagemMaxima = configuracaoDesconto.PorcentagemMaxima;
        }

        public bool Validar()
        {
            if (PorcentagemDesconto >= PorcentagemMaxima)
            {
                return false;
            }

            return true;
        }

        public decimal CalcularDesconto(int quantidadeEmprestimos)
        {
            decimal desconto = PorcentagemDesconto * quantidadeEmprestimos;

            if (desconto > PorcentagemMaxima)
            {
                return PorcentagemMaxima;
            }

            return desconto;
        }
    }
}