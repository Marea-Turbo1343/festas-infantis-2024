using FestasInfantis.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class RepositorioItemEmArquivo : RepositorioBaseEmArquivo<Item>, IRepositorioItem
    {
        public RepositorioItemEmArquivo(ContextoDados contexto) : base(contexto)
        {
            if (contexto.Itens.Any())
                contadorId = contexto.Itens.Max(i => i.Id) + 1;
        }

        protected override List<Item> ObterRegistros()
        {
            return contexto.Itens;
        }

        public int ObterProximoId()
        {
            if (contexto.Itens.Any())
                return contexto.Itens.Max(c => c.Id) + 1;
            else
                return 1;
        }

        public override bool Excluir(int id)
        {
            Item item = SelecionarPorId(id);

            List<Tema> temasRelacionados =
                contexto.Temas.FindAll(t => t.Itens.Contains(item));

            foreach (Tema t in temasRelacionados)
                t.Itens.Remove(item);

            return base.Excluir(id);
        }
    }
}