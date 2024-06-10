namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaVerTemaForm : Form
    {
        public TelaVerTemaForm(Tema tema)
        {
            InitializeComponent();

            AtualizarInformacoes(tema);
        }

        private void AtualizarInformacoes(Tema tema)
        {
            if (tema == null)
            {
                MessageBox.Show("O tema selecionado não foi encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtId.Text = tema.Id.ToString();
            txtTema.Text = tema.Nome!.ToString();
            txtValorTotal.Text = tema.ValorTotal.ToString();

            listBoxItensTema.DataSource = tema.Itens;
        }
    }
}