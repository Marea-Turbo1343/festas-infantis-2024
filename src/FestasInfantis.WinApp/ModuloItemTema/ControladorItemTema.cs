using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloItemTema
{
    public class ControladorItemTema : ControladorBase
    {
        private RepositorioItemTema RepositorioItemTema;
        private TabelaItemTemaControl tabelaItemTema;

        public ControladorItemTema(TelaItemTema telaItemTema, RepositorioItem repositorioItem)
        {
            this.telaItemTema = telaItemTema;
            this.repositorioItem = repositorioItem;
        }

        public void Adicionar()
        {
            telaItemTema.Item = new ItemTema(0, "", true);
            telaItemTema.ShowDialog();
            if (telaItemTema.DialogResult == DialogResult.OK)
            {
                repositorioItem.Adicionar(telaItemTema.Item);
            }
        }

        public void Editar()
        {
            telaItemTema.Item = repositorioItem.SelecionarPorId(telaItemTema.Item.Id);
            telaItemTema.ShowDialog();
            if (telaItemTema.DialogResult == DialogResult.OK)
            {
                repositorioItem.Editar(telaItemTema.Item);
            }
        }

        public void Excluir()
        {
            repositorioItem.Excluir(telaItemTema.Item);
        }

        public void Filtrar()
        {
            telaItemTema.Item = repositorioItem.SelecionarPorId(telaItemTema.Item.Id);
        }
    }
}
