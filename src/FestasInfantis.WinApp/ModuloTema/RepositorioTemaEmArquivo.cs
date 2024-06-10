using FestasInfantis.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel;
using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class RepositorioTemaEmArquivo : RepositorioBaseEmArquivo<Tema>, IRepositorioTema
    {
        public RepositorioTemaEmArquivo(ContextoDados contexto) : base(contexto)
        {
            if (contexto.Temas.Any())
                contadorId = contexto.Temas.Max(t => t.Id) + 1;
        }

        protected override List<Tema> ObterRegistros()
        {
            return contexto.Temas;
        }

        public override bool Excluir(int id)
        {
            Tema tema = SelecionarPorId(id);

            List<Aluguel> alugueisRelacionados =
                contexto.Alugueis.FindAll(a => a.Tema.Id == tema.Id);

            foreach (Aluguel a in alugueisRelacionados)
                a.Tema = null;

            return base.Excluir(id);
        }

        public int ObterProximoId()
        {
            if (contexto.Temas.Any())
                return contexto.Temas.Max(c => c.Id) + 1;
            else
                return 1;
        }

        public Tema AdicionarItens(int id, Tema tema)
        {
            throw new NotImplementedException();
        }
    }
}