namespace FestasInfantis.WinApp.ModuloItem
{
    public partial class TelaItemTemaForm : Form
    {
        private ItemTema item;

        public ItemTema Item
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
                return item;
            }
        }

        public TelaItemTemaForm()
        {
            InitializeComponent();
            //this.ConfigurarDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            item = new Item
            {
                Id = Convert.ToInt32(txtId.Text),
                Titulo = txtTitulo.Text,
                Valor = txtPreco.Value,
                Ativo = chkAtivo.Checked
            };

            this.DialogResult = DialogResult.OK;
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            decimal preco = txtPreco.Value;
            bool ativo = chkAtivo.Checked;

            item = new Item(titulo, preco, ativo);

            var erros = itemTema.Validar();

            if (txtId.Text != "")
                itemTema.Id = Convert.ToInt32(txtId.Text);

            if (erros.Any())
            {
                TelaPrincipalForm.TelaPrincipal!.AlterarLabelRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
        }
    }
}
