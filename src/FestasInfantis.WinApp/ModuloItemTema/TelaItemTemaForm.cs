namespace FestasInfantis.WinApp.ModuloItemTema
{
    public partial class TelaItemTemaForm : Form
    {
        private ItemTema itemTema;

        public ItemTema ItemTema
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtTitulo.Text = value.Titulo;
                txtPreco.Value = value.Valor;
                chkAtivo.Checked = value.Ativo;
            }
            get
            {
                return itemTema;
            }
        }

        public TelaItemTemaForm()
        {
            InitializeComponent();
            //this.ConfigurarDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            decimal preco = txtPreco.Value;
            bool ativo = chkAtivo.Checked;

            itemTema = new ItemTema(titulo, preco, ativo);

            List<string> erros = itemTema.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
