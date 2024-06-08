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

        private void ConfigurarTelaPrincipal(ControladorBase controladorSelecionado)
        {
            lblTipoCadastro.Text = controladorSelecionado.TipoCadastro;

            ConfigurarToolBox(controladorSelecionado);
            ConfigurarListagem(controladorSelecionado);
        }

        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdicionar.Enabled = controladorSelecionado.HabilitarBtnAdicionar();
            btnEditar.Enabled = controladorSelecionado.HabilitarBtnEditar();
            btnExcluir.Enabled = controladorSelecionado.HabilitarBtnExcluir();
            btnFiltrar.Enabled = controladorSelecionado.HabilitarBtnFiltrar();
            btnAdicionarItens.Enabled = controladorSelecionado.HabilitarBtnAdicionarItens();
            btnVisualizarAlugueis.Enabled = controladorSelecionado.HabilitarBtnVisualizarAlugueis();
            btnConcluirAluguel.Enabled = controladorSelecionado.HabilitarBtnConcluirAluguel();
            btnConfigurarDescontos.Enabled = controladorSelecionado.HabilitarBtnConfigurarDescontos();
        }

        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemCliente = controladorSelecionado.ObterListagem();
            listagemCliente.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagemCliente);
        }

        private void btnConfigurarDescontos_Click(object sender, EventArgs e)
        {
            if (controlador is ControladorAluguel control)

                control.ConfigurarDesconto();
        }
    }
}