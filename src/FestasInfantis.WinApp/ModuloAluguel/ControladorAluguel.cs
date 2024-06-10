using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloItem;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        private IRepositorioAluguel repositorioAluguel;
        private IRepositorioCliente repositorioCliente;
        private IRepositorioTema repositorioTema;
        private IRepositorioItem repositorioItem;
        private TabelaAluguelControl tabelaAluguel;

        public ControladorAluguel(IRepositorioAluguel repositorioAluguel, IRepositorioCliente repositorioCliente, IRepositorioTema repositorioTema, IRepositorioItem repositorioItem)
        {
            this.repositorioAluguel = repositorioAluguel;
            this.repositorioCliente = repositorioCliente;
            this.repositorioTema = repositorioTema;
            this.repositorioItem = repositorioItem;
        }

        public override string TipoCadastro { get { return "Aluguéis"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo aluguel"; } }

        public override string ToolTipEditar { get { return "Editar um aluguel existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um aluguel existente"; } }

        public string ToolTipFiltrar => "Filtrar aluguéis";

        public string ToolTipVisualizarAlugueis => "Visualizar aluguéis";

        public string ToolTipConcluirAluguel => "Concluir aluguel";

        public string ToolTipConfigurarDesconto => "Configurar desconto";

        public void AtualizarListagem()
        {
            List<Aluguel> alugueis = repositorioAluguel.SelecionarTodos();

            tabelaAluguel?.AtualizarRegistros(alugueis);

            TelaPrincipalForm.Instancia?.AtualizarRodape(ObterTextoRodape(alugueis));
        }

        private static string ObterTextoRodape(List<Aluguel> alugueis)
        {
            if (alugueis.Count == 0)
                return "Nenhum aluguel cadastrado até o momento!";
            else if (alugueis.Count == 1)
                return "Exibindo 1 aluguel";

            return $"Exibindo {alugueis.Count} aluguéis";
        }

        public override void Adicionar()
        {
            TelaAluguelForm telaAluguel = new TelaAluguelForm(repositorioAluguel);

            List<Cliente> clientesCadastrados = repositorioCliente.SelecionarTodos();
            List<Tema> temasCadastrados = repositorioTema.SelecionarTodos();

            telaAluguel.CarregarClientes(clientesCadastrados);
            telaAluguel.CarregarTemas(temasCadastrados);

            DialogResult resultado = telaAluguel.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Aluguel novoAluguel = telaAluguel.Aluguel;

            if (repositorioAluguel.SelecionarTodos().Any(a => a.Cliente == novoAluguel.Cliente && a.DataFesta > DateTime.Now))
            {
                MessageBox.Show("O cliente selecionado possui um aluguel em aberto. É preciso pagar o aluguel em aberto antes de realizar um novo.", "Cliente com aluguel em aberto", MessageBoxButtons.OK, MessageBoxIcon.Error);

                TelaEncerrarAluguelForm telaEncerrarAluguel = new TelaEncerrarAluguelForm();
                telaEncerrarAluguel.ShowDialog();

                return;
            }

            if (repositorioAluguel.SelecionarTodos().Any(a => a.Tema == novoAluguel.Tema && a.DataFesta > DateTime.Now))
            {
                MessageBox.Show("O tema selecionado já está alugado por outro cliente.", "Tema já alugado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (novoAluguel.Entrada != Aluguel.PorcentagemEntrada._40porcento && novoAluguel.Entrada != Aluguel.PorcentagemEntrada._50porcento)
            {
                MessageBox.Show("A porcentagem de entrada deve ser 40% ou 50%.", "Porcentagem de entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(novoAluguel.EnderecoFesta))
            {
                MessageBox.Show("O endereço da festa deve estar preenchido.", "Endereço da festa vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (novoAluguel.DataFesta <= DateTime.Now)
            {
                MessageBox.Show("A data da festa deve ser de amanhã em diante.", "Data da festa inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (novoAluguel.HoraInicio >= novoAluguel.HoraTermino)
            {
                MessageBox.Show("O horário de início não pode ser depois do horário de término.", "Horário inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (novoAluguel.ValorTotal != novoAluguel.ValorTotal - novoAluguel.DescontoDisponibilizado)
            {
                MessageBox.Show("O valor total deve estar com o desconto já calculado.", "Valor total inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            repositorioAluguel.Cadastrar(novoAluguel);

            CarregarAlugueis();

            TelaPrincipalForm.Instancia.Temporizador($"O registro \"{novoAluguel.Cliente.Nome}\" foi criado com sucesso!");
        }


        public override void Editar()
        {
            TelaAluguelForm telaAluguel = new TelaAluguelForm(repositorioAluguel);

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

            TelaPrincipalForm.Instancia.Temporizador($"O registro \"{aluguelEditado.Cliente.Nome}\" foi editado com sucesso!");
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

            TelaPrincipalForm.Instancia.Temporizador($"O registro \"{aluguelSelecionado.Cliente.Nome}\" foi excluído com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaAluguel == null)
                tabelaAluguel = new TabelaAluguelControl();

            CarregarAlugueis();

            AtualizarListagem();

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