using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        private TabelaAluguelControl tabelaAluguel;

        private IRepositorioAluguel repositorioAluguel;
        private IRepositorioCliente repositorioCliente;
        private IRepositorioTema repositorioTema;

        public ControladorAluguel(IRepositorioAluguel repositorioAluguel, IRepositorioCliente repositorioCliente, IRepositorioTema repositorioTema)
        {
            this.repositorioAluguel = repositorioAluguel;
            this.repositorioCliente = repositorioCliente;
            this.repositorioTema = repositorioTema;
        }

        public override string TipoCadastro { get { return "Aluguéis"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo aluguel"; } }

        public override string ToolTipEditar { get { return "Editar um aluguel existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um aluguel existente"; } }

        public override void Adicionar()
        {
            TelaAluguelForm telaAluguel = new TelaAluguelForm();

            List<Cliente> clientesCadastrados = repositorioCliente.SelecionarTodos();
            List<Tema> temasCadastrados = repositorioTema.SelecionarTodos();

            telaAluguel.CarregarClientes(clientesCadastrados);
            telaAluguel.CarregarTemas(temasCadastrados);

            DialogResult resultado = telaAluguel.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Aluguel novoAluguel = telaAluguel.Aluguel;

            repositorioAluguel.Cadastrar(novoAluguel);

            CarregarAlugueis();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novoAluguel.Cliente.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaAluguelForm telaAluguel = new TelaAluguelForm();

            List<Cliente> clientesCadastrados = repositorioCliente.SelecionarTodos();
            List<Tema> temasCadastrados = repositorioTema.SelecionarTodos();

            telaAluguel.CarregarClientes(clientesCadastrados);
            telaAluguel.CarregarTemas(temasCadastrados);

            int idSelecionado = tabelaAluguel.ObterRegistroSelecionado();

            Aluguel aluguelSelecionado =
                repositorioAluguel.SelecionarPorId(idSelecionado);

            if (aluguelSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaAluguel.Aluguel = aluguelSelecionado;

            DialogResult resultado = telaAluguel.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Aluguel aluguelEditado = telaAluguel.Aluguel;

            repositorioAluguel.Editar(aluguelSelecionado.Id, aluguelEditado);

            CarregarAlugueis();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{aluguelEditado.Cliente.Nome}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaAluguel.ObterRegistroSelecionado();

            Aluguel aluguelSelecionado =
                repositorioAluguel.SelecionarPorId(idSelecionado);

            if (aluguelSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resultado = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{aluguelSelecionado.Cliente.Nome}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado != DialogResult.Yes)
                return;

            repositorioAluguel.Excluir(aluguelSelecionado.Id);

            CarregarAlugueis();

            TelaPrincipalForm
               .Instancia
               .AtualizarRodape($"O registro \"{aluguelSelecionado.Cliente.Nome}\" foi excluído com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaAluguel == null)
                tabelaAluguel = new TabelaAluguelControl();

            CarregarAlugueis();

            return tabelaAluguel;
        }

        private void CarregarAlugueis()
        {
            List<Aluguel> alugueis = repositorioAluguel.SelecionarTodos();

            tabelaAluguel.AtualizarRegistros(alugueis);
        }

        public void ConfigurarDesconto()
        {
            ConfiguracaoDesconto configuracaoDesconto = repositorioAluguel.SelecionarConfiguracaoDesconto();

            var telaDesconto = new TelaDescontoForm(configuracaoDesconto)
            {
                Text = "Configurar Desconto"
            };

            DialogResult result = telaDesconto.ShowDialog();

            if (result == DialogResult.OK)
            {
                configuracaoDesconto.EditarDesconto(telaDesconto.configuracaoDesconto);

                repositorioAluguel.SalvarDesconto(configuracaoDesconto);

            }
        }
    }
}