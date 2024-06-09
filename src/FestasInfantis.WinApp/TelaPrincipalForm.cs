using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloItem;
using FestasInfantis.WinApp.ModuloTema;
using FestasInfantis.WinApp.ModuloAluguel;

namespace FestasInfantis.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        ControladorBase controlador;

        ContextoDados contexto;

        IRepositorioCliente repositorioCliente;
        IRepositorioItem repositorioItem;
        IRepositorioTema repositorioTema;
        IRepositorioAluguel repositorioAluguel;

        public static TelaPrincipalForm Instancia { get; private set; }

        public TelaPrincipalForm()
        {
            InitializeComponent();

            lblTipoCadastro.Text = string.Empty;
            Instancia = this;

            contexto = new ContextoDados(carregarDados: true);

            repositorioCliente = new RepositorioClienteEmArquivo(contexto);
            repositorioItem = new RepositorioItemEmArquivo(contexto);
            repositorioTema = new RepositorioTemaEmArquivo(contexto);
            repositorioAluguel = new RepositorioAluguelEmArquivo(contexto);
        }

        public void AtualizarRodape(string texto)
        {
            lblRodape.Text = texto;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCliente(repositorioCliente);

            ConfigurarTelaPrincipal(controlador);
        }

        private void itensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorItem(repositorioItem);

            ConfigurarTelaPrincipal(controlador);
        }

        private void temasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTema(repositorioTema);

            ConfigurarTelaPrincipal(controlador);
        }

        private void alugueisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorAluguel(repositorioAluguel, repositorioCliente, repositorioTema);

            ConfigurarTelaPrincipal(controlador);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
        }

        private void btnAdicionarItens_Click(object sender, EventArgs e)
        {
        }

        private void btnVisualizarAlugueis_Click(object sender, EventArgs e)
        {
        }

        private void btnConcluirAluguel_Click(object sender, EventArgs e)
        {
        }

        private void btnConfigurarDescontos_Click(object sender, EventArgs e)
        {
        }


        private void ConfigurarTelaPrincipal(ControladorBase controladorSelecionado)
        {
            lblTipoCadastro.Text = controladorSelecionado.TipoCadastro;

            ConfigurarToolBox(controladorSelecionado);
            ConfigurarListagem(controladorSelecionado);
        }

        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;

            if (controladorSelecionado is IControladorFiltravel controladorFiltravel)
                btnFiltrar.ToolTipText = controladorFiltravel.ToolTipFiltrar;

            if (controladorSelecionado is IControladorAdicionarItens controladorAdicionavel)
                btnAdicionarItens.ToolTipText = controladorAdicionavel.ToolTipAdicionarItens;

            if (controladorSelecionado is IControladorVisualizarAlugueis controladorVisualizavel)
                btnVisualizarAlugueis.ToolTipText = controladorVisualizavel.ToolTipVisualizarAlugueis;

            if (controladorSelecionado is IControladorConcluirAluguel controladorConcluivel)
                btnConcluirAluguel.ToolTipText = controladorConcluivel.ToolTipConcluirAluguel;

            if (controladorSelecionado is IControladorConfigurarDescontos controladorConfiguravel)
                btnConfigurarDescontos.ToolTipText = controladorConfiguravel.ToolTipConfigurarDescontos;
        }

        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdicionar.Enabled = controladorSelecionado is ControladorBase;
            btnEditar.Enabled = controladorSelecionado is ControladorBase;
            btnExcluir.Enabled = controladorSelecionado is ControladorBase;

            btnFiltrar.Enabled = controladorSelecionado is IControladorFiltravel;
            btnAdicionarItens.Enabled = controladorSelecionado is IControladorAdicionarItens;
            btnVisualizarAlugueis.Enabled = controladorSelecionado is IControladorVisualizarAlugueis;
            btnConcluirAluguel.Enabled = controladorSelecionado is IControladorConcluirAluguel;
            btnConfigurarDescontos.Enabled = controladorSelecionado is IControladorConfigurarDescontos;

            ConfigurarToolTips(controladorSelecionado);
        }

        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemCliente = controladorSelecionado.ObterListagem();
            listagemCliente.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagemCliente);
        }
    }
}