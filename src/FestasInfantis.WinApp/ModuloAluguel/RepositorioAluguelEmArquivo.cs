using FestasInfantis.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class RepositorioAluguelEmArquivo : RepositorioBaseEmArquivo<Aluguel>, IRepositorioAluguel
    {
        readonly ConfiguracaoDesconto configuracaoDescontos;

        public RepositorioAluguelEmArquivo(ContextoDados contexto) : base(contexto)
        {
            configuracaoDescontos = contexto.ConfiguracaoDesconto;

            if (contexto.Alugueis.Any())
                contadorId = contexto.Alugueis.Max(a => a.Id) + 1;
        }

        protected override List<Aluguel> ObterRegistros()
        {
            return contexto.Alugueis;
        }

        public List<Aluguel> SelecionarAlugueisAberto()
        {
            return ObterRegistros().FindAll(x => x.DataFesta > DateTime.Now);
        }

        public List<Aluguel> SelecionarAlugueisConcluidos()
        {
            return ObterRegistros().FindAll(x => x.PagamentoConcluido == true);
        }

        public List<Aluguel> SelecionarAlugueisPorPeriodo(DateTime dataInicio, DateTime dataTermino)
        {
            return ObterRegistros()
                .FindAll(a => a.DataFesta.Date >= dataInicio.Date && a.DataFesta.Date <= dataTermino.Date);
        }

        public ConfiguracaoDesconto SelecionarConfiguracaoDesconto()
        {
            return configuracaoDescontos;
        }

        public int ObterProximoId()
        {
            if (contexto.Alugueis.Any())
                return contexto.Alugueis.Max(c => c.Id) + 1;
            else
                return 1;
        }

        public void SalvarDesconto(ConfiguracaoDesconto configuracaoDesconto)
        {
            contexto.ConfiguracaoDesconto = configuracaoDesconto;
            contexto.Gravar();
        }

        public List<Aluguel> SelecionarPorCliente(int idCliente)
        {
            throw new NotImplementedException();
        }
    }
}