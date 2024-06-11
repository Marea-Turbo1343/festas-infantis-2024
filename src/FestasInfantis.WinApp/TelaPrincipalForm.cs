using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloItem;
using FestasInfantis.WinApp.ModuloTema;
using FestasInfantis.WinApp.ModuloAluguel;
using System.Diagnostics;

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

        public event Action TemporizadorTerminou;

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

        public void Temporizador(string mensagem)
        {
            AtualizarRodape(mensagem);

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000;
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                TemporizadorTerminou?.Invoke();
            };
            timer.Start();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCliente(repositorioCliente, repositorioAluguel);

            ConfigurarTelaPrincipal(controlador);
        }

        private void itensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorItem(repositorioItem);

            ConfigurarTelaPrincipal(controlador);
        }

        private void temasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTema(repositorioTema, repositorioItem, repositorioAluguel);

            ConfigurarTelaPrincipal(controlador);
        }

        private void alugueisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorAluguel(repositorioAluguel, repositorioCliente, repositorioTema, repositorioItem);

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
            if (controlador is IControladorFiltrar controladorFiltravel)
                controladorFiltravel.Filtrar();
        }

        private void btnAdicionarItens_Click(object sender, EventArgs e)
        {
            if (controlador is IControladorAdicionarItens controladorAdicionarItens)
                controladorAdicionarItens.AdicionarItens();
        }

        private void btnVisualizarAlugueis_Click(object sender, EventArgs e)
        {
            if (controlador is IControladorVisualizarAlugueis controladorVisualizarAlugueis)
                controladorVisualizarAlugueis.VisualizarAlugueis();
        }

        private void btnConcluirAluguel_Click(object sender, EventArgs e)
        {
            if (controlador is IControladorConcluirAluguel controladorConcluirAluguel)
                controladorConcluirAluguel.ConcluirAluguel();
        }

        private void btnConfigurarDescontos_Click(object sender, EventArgs e)
        {
            if (controlador is IControladorConfigurarDescontos controladorConfigurarDescontos)
                controladorConfigurarDescontos.ConfigurarDescontos();
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

            if (controladorSelecionado is IControladorFiltrar controladorFiltravel)
                btnFiltrar.ToolTipText = controladorFiltravel.ToolTipFiltrar;

            if (controladorSelecionado is IControladorAdicionarItens controladorAdicionarItens)
                btnAdicionarItens.ToolTipText = controladorAdicionarItens.ToolTipAdicionarItens;

            if (controladorSelecionado is IControladorVisualizarAlugueis controladorVisualizarAlugueis)
                btnVisualizarAlugueis.ToolTipText = controladorVisualizarAlugueis.ToolTipVisualizarAlugueis;

            if (controladorSelecionado is IControladorConcluirAluguel controladorConcluirAluguel)
                btnConcluirAluguel.ToolTipText = controladorConcluirAluguel.ToolTipConcluirAluguel;

            if (controladorSelecionado is IControladorConfigurarDescontos controladorConfigurarDescontos)
                btnConfigurarDescontos.ToolTipText = controladorConfigurarDescontos.ToolTipConfigurarDescontos;
        }

        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdicionar.Enabled = controladorSelecionado is ControladorBase;
            btnEditar.Enabled = controladorSelecionado is ControladorBase;
            btnExcluir.Enabled = controladorSelecionado is ControladorBase;

            btnFiltrar.Enabled = controladorSelecionado is IControladorFiltrar;
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