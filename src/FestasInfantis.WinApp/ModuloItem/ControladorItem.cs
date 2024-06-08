using FestasInfantis.WinApp.Compartilhado;

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

        public override void Adicionar()
        {
            TelaItemForm telaItem = new TelaItemForm();

            DialogResult resultado = telaItem.ShowDialog();

            // guardas = bloquear momentos em que a aplicação toma um "caminho triste"
            if (resultado != DialogResult.OK)
                return;

            Item novoItem = telaItem.Item;

            repositorioItem.Cadastrar(novoItem);

            CarregarItens();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoItem.Descricao}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaItemForm telaItem = new TelaItemForm();

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

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{itemEditado.Descricao}\" foi editado com sucesso!");
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

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{itemSelecionado.Descricao}\" foi excluído com sucesso!");
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

            return tabelaItem;
        }

        public override bool HabilitarBtnAdicionar() { return true; }
        public override bool HabilitarBtnEditar() { return true; }
        public override bool HabilitarBtnExcluir() { return true; }
        public override bool HabilitarBtnFiltrar() { return false; }
        public override bool HabilitarBtnAdicionarItens() { return false; }
        public override bool HabilitarBtnVisualizarAlugueis() { return false; }
        public override bool HabilitarBtnConcluirAluguel() { return false; }
        public override bool HabilitarBtnConfigurarDescontos() { return false; }
    }
}