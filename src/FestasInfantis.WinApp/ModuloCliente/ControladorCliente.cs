namespace FestasInfantis.WinApp.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {
        private IRepositorioCliente repositorioCliente;
        private TabelaClienteControl tabelaCliente;

        public ControladorCliente(IRepositorioCliente repositorio)
        {
            repositorioCliente = repositorio;
        }

        public override string TipoCadastro { get { return "Clientes"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo cliente"; } }

        public override string ToolTipEditar { get { return "Editar um cliente existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um cliente existente"; } }

        public string ToolTipVisualizarAlugueis => "Visualizar aluguéis do cliente";

        public override void Adicionar()
        {
            TelaClienteForm telaCliente = new TelaClienteForm(repositorioCliente);

            DialogResult resultado = telaCliente.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Cliente novoCliente = telaCliente.Cliente;

            repositorioCliente.Cadastrar(novoCliente);

            CarregarClientes();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoCliente.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaClienteForm telaCliente = new TelaClienteForm(repositorioCliente);

            int idSelecionado = tabelaCliente.ObterRegistroSelecionado();

            Cliente clienteSelecionado = repositorioCliente.SelecionarPorId(idSelecionado);

            if (clienteSelecionado == null)
            {
                MessageBox.Show("Não é possível realizar esta ação sem um registro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            telaCliente.Cliente = clienteSelecionado;

            DialogResult resultado = telaCliente.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Cliente clienteEditado = telaCliente.Cliente;

            repositorioCliente.Editar(clienteSelecionado.Id, clienteEditado);

            CarregarClientes();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{clienteEditado.Nome}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaCliente.ObterRegistroSelecionado();

            Cliente clienteSelecionado = repositorioCliente.SelecionarPorId(idSelecionado);

            if (clienteSelecionado == null)
            {
                MessageBox.Show("Não é possível realizar esta ação sem um registro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resposta = MessageBox.Show($"Você deseja realmente excluir o registro \"{clienteSelecionado.Nome}\"?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes)
                return;

            repositorioCliente.Excluir(clienteSelecionado.Id);

            CarregarClientes();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{clienteSelecionado.Nome}\" foi excluído com sucesso!");
        }

        private void CarregarClientes()
        {
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();

            tabelaCliente.AtualizarRegistros(clientes);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaCliente == null)
                tabelaCliente = new TabelaClienteControl();

            CarregarClientes();

            return tabelaCliente;
        }
    }
}