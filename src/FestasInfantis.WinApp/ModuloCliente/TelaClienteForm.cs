using System.Text.RegularExpressions;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class TelaClienteForm : Form
    {
        private Cliente cliente;
        private IRepositorioCliente repositorioCliente;

        public Cliente Cliente
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
                txtCpf.Text = value.Cpf;
                txtTelefone.Text = value.Telefone;
            }
            get
            {
                return cliente;
            }
        }

        public TelaClienteForm(IRepositorioCliente repositorioCliente)
        {
            InitializeComponent();

            this.repositorioCliente = repositorioCliente;

            int proximoId = repositorioCliente.ObterProximoId();
            txtId.Text = proximoId.ToString();
        }

        private bool ValidarNome(string nome)
        {
            if (nome.Length < 3)
            {
                MessageBox.Show("O nome deve ter 3 caracteres ou mais.");
                return false;
            }

            if (Regex.IsMatch(nome, @"\d"))
            {
                MessageBox.Show("O nome deve conter apenas letras.");
                return false;
            }

            return true;
        }

        private bool ValidarCpf(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11 || Regex.IsMatch(cpf, @"\D"))
            {
                MessageBox.Show("O CPF deve ter 11 dígitos e conter apenas números. \nExemplo: 12345678900 ou 123.456.789-00");
                return false;
            }

            return true;
        }

        private bool ValidarTelefone(string telefone)
        {
            telefone = telefone.Replace(" ", "").Replace("-", "");

            if (telefone.Length != 11 || Regex.IsMatch(telefone, @"\D"))
            {
                MessageBox.Show("O telefone deve ter 11 dígitos e conter apenas números. \nExemplo: 49 98875-1234 ou 49988751234");
                return false;
            }

            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;
            string telefone = txtTelefone.Text;

            if (!ValidarNome(nome) || !ValidarCpf(cpf) || !ValidarTelefone(telefone))
            {
                DialogResult = DialogResult.None;
                return;
            }

            cliente = new Cliente(nome, cpf, telefone);

            List<string> erros = cliente.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
            else
            {
                int proximoId = repositorioCliente.ObterProximoId();
                txtId.Text = proximoId.ToString();
            }
        }
    }
}