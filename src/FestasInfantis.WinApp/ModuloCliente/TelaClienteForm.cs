using System.Text.RegularExpressions;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class TelaClienteForm : Form
    {
        private Cliente cliente;
        private IRepositorioCliente repositorioCliente;
        private bool modoEdicao;

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

        public TelaClienteForm(IRepositorioCliente repositorioCliente, bool modoEdicao = false)
        {
            InitializeComponent();

            this.repositorioCliente = repositorioCliente;
            this.modoEdicao = modoEdicao;

            if (modoEdicao)
            {
                this.Text = "Editar Cliente";
            }
            else
            {
                int proximoId = repositorioCliente.ObterProximoId();
                txtId.Text = proximoId.ToString();
            }

            txtNome.Leave += TxtNome_Leave;
            txtCpf.Leave += TxtCpf_Leave;
            txtTelefone.Leave += TxtTelefone_Leave;
        }

        private void TxtNome_Leave(object sender, EventArgs e)
        {
            if (!ValidarNome(txtNome.Text))
            {
                MessageBox.Show("O nome deve conter apenas letras e ter 3 caracteres ou mais.");
                txtNome.Focus();
            }
        }

        private void TxtCpf_Leave(object sender, EventArgs e)
        {
            if (!ValidarCpf(txtCpf.Text))
            {
                MessageBox.Show("O CPF deve ter 11 dígitos e conter apenas números. \nExemplo: 12345678900 ou 123.456.789-00");
                txtCpf.Focus();
            }
        }

        private void TxtTelefone_Leave(object sender, EventArgs e)
        {
            if (!ValidarTelefone(txtTelefone.Text))
            {
                MessageBox.Show("O telefone deve ter 11 dígitos e conter apenas números. \nExemplo: 49 98875-1234 ou 49988751234");
                txtTelefone.Focus();
            }
        }

        private string RemoverCaracteresNaoNumericos(string texto)
        {
            return Regex.Replace(texto, @"\D", "");
        }

        private bool ValidarNome(string nome)
        {
            if (nome.Length < 3)
            {
                return false;
            }

            if (Regex.IsMatch(nome, @"\d"))
            {
                return false;
            }

            return true;
        }

        private bool ValidarCpf(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11 || Regex.IsMatch(cpf, @"\D"))
            {
                return false;
            }

            return true;
        }

        private bool ValidarTelefone(string telefone)
        {
            telefone = telefone.Replace(" ", "").Replace("-", "");

            if (telefone.Length != 11 || Regex.IsMatch(telefone, @"\D"))
            {
                return false;
            }

            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = RemoverCaracteresNaoNumericos(txtCpf.Text);
            string telefone = RemoverCaracteresNaoNumericos(txtTelefone.Text);

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