using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel;
using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public class ControladorCliente : ControladorBase, IControladorVisualizarAlugueis
    {
        private IRepositorioCliente repositorioCliente;
        private IRepositorioAluguel repositorioAluguel;
        private TabelaClienteControl tabelaCliente;

        public ControladorCliente(IRepositorioCliente repositorioCliente, IRepositorioAluguel repositorioAluguel)
        {
            this.repositorioCliente = repositorioCliente;
            this.repositorioAluguel = repositorioAluguel;
        }

        public override string TipoCadastro { get { return "Clientes"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo cliente"; } }

        public override string ToolTipEditar { get { return "Editar um cliente existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um cliente existente"; } }

        public string ToolTipVisualizarAlugueis => "Visualizar aluguéis do cliente";

        public void AtualizarListagem()
        {
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();

            tabelaCliente.AtualizarRegistros(clientes);

            TelaPrincipalForm.Instancia?.AtualizarRodape(ObterTextoRodape(clientes));
        }

        private static string ObterTextoRodape(List<Cliente> clientes)
        {
            if (clientes.Count == 0)
                return "Nenhum cliente cadastrado até o momento!";
            else if (clientes.Count == 1)
                return "Exibindo 1 cliente";

            return $"Exibindo {clientes.Count} clientes.";
        }

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

        public void VisualizarAlugueis()
        {
            int idSelecionado = tabelaCliente.ObterRegistroSelecionado();

            Cliente clienteSelecionado = repositorioCliente.SelecionarPorId(idSelecionado);

            if (clienteSelecionado == null)
            {
                MessageBox.Show("Não é possível realizar esta ação sem um registro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TelaVerAlugueisForm telaVerAlugueis = new TelaVerAlugueisForm(repositorioAluguel, clienteSelecionado.Id);
            telaVerAlugueis.ShowDialog();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaCliente == null)
                tabelaCliente = new TabelaClienteControl();

            CarregarClientes();

            AtualizarListagem();

            return tabelaCliente;
        }
    }
}