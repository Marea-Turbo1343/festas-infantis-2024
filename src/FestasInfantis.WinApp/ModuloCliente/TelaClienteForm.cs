namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class TelaClienteForm : Form
    {
        private Cliente cliente;
        public Cliente Cliente
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
                txtTelefone.Text = value.Telefone;
                txtCpf.Text = value.Cpf;
            }
            get
            {
                return cliente;
            }
        }

        public TelaClienteForm()
        {
            InitializeComponent();
        }    

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string telefone = txtTelefone.Text;
            string cpf = txtCpf.Text;

            cliente = new Cliente(nome, telefone, cpf);

            List<string> erros = cliente.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}