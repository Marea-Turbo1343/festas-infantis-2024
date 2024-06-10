using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class ControladorItem : ControladorBase
    {
        private IRepositorioItem repositorioItem;
        private TabelaItemControl tabelaItem;

        public ControladorItem(IRepositorioItem repositorio)
        {
            repositorioItem = repositorio;
        }

        public override string TipoCadastro { get { return "Itens"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo item"; } }

        public override string ToolTipEditar { get { return "Editar um item existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um item existente"; } }

        public void AtualizarListagem()
        {
            List<Item> itens = repositorioItem.SelecionarTodos();

            tabelaItem.AtualizarRegistros(itens);

            TelaPrincipalForm.Instancia?.AtualizarRodape(ObterTextoRodape(itens));
        }

        private static string ObterTextoRodape(List<Item> itens)
        {
            if (itens.Count == 0)
                return "Nenhum item cadastrado até o momento!";
            else if (itens.Count == 1)
                return "Exibindo 1 item";

            return $"Exibindo {itens.Count} itens.";
        }

        public override void Adicionar()
        {
            TelaItemForm telaItem = new TelaItemForm(repositorioItem);

            DialogResult resultado = telaItem.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Item novoItem = telaItem.Item;

            repositorioItem.Cadastrar(novoItem);

            CarregarItens();

            TelaPrincipalForm.Instancia.Temporizador($"O registro \"{novoItem.Descricao}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaItemForm telaItem = new TelaItemForm(repositorioItem);

            int idSelecionado = tabelaItem.ObterRegistroSelecionado();
            Item itemSelecionado =
                repositorioItem.SelecionarPorId(idSelecionado);

            if (itemSelecionado == null)
            {
                MessageBox.Show("Não é possível realizar esta ação sem um registro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            telaItem.Item = itemSelecionado;

            DialogResult resultado = telaItem.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Item itemEditado = telaItem.Item;

            repositorioItem.Editar(itemSelecionado.Id, itemEditado);

            CarregarItens();

            TelaPrincipalForm.Instancia.Temporizador($"O registro \"{itemEditado.Descricao}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaItem.ObterRegistroSelecionado();

            Item itemSelecionado = repositorioItem.SelecionarPorId(idSelecionado);

            if (itemSelecionado == null)
            {
                MessageBox.Show("Não é possível realizar esta ação sem um registro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resposta = MessageBox.Show($"Você deseja realmente excluir o registro \"{itemSelecionado.Descricao}\"?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes)
                return;

            repositorioItem.Excluir(itemSelecionado.Id);

            CarregarItens();

            TelaPrincipalForm.Instancia.Temporizador($"O registro \"{itemSelecionado.Descricao}\" foi excluído com sucesso!");
        }

        private void CarregarItens()
        {
            List<Item> itens = repositorioItem.SelecionarTodos();

            tabelaItem.AtualizarRegistros(itens);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaItem == null)
                tabelaItem = new TabelaItemControl();

            CarregarItens();

            AtualizarListagem();

            return tabelaItem;
        }
    }
}