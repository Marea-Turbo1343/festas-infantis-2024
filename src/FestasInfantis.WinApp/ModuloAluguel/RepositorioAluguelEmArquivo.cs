using FestasInfantis.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class RepositorioAluguelEmArquivo : RepositorioBaseEmArquivo<Aluguel>, IRepositorioAluguel
    {
        public RepositorioAluguelEmArquivo(ContextoDados contexto) : base(contexto)
        {
            if (contexto.Alugueis.Any())
                contadorId = contexto.Alugueis.Max(a => a.Id) + 1;
        }

        protected override List<Aluguel> ObterRegistros()
        {
            return contexto.Alugueis;
        }

        public List<Aluguel> SelecionarAlugueisPorPeriodo(DateTime dataInicio, DateTime dataTermino)
        {
            return ObterRegistros()
                .FindAll(a => a.DataFesta >= dataInicio && a.DataFesta <= dataTermino);
        }
    }
}
