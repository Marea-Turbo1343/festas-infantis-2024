using FestasInfantis.WinApp.ModuloCliente;
using System.Globalization;

namespace FestasInfantis.WinApp.ModuloItem
{
    public partial class TelaItemForm : Form
    {
        private Item item;
        private IRepositorioItem repositorioItem;
        private bool modoEdicao;

        public Item Item
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtDescricao.Text = value.Descricao;
                txtValor.Text = value.Valor.ToString();
            }
            get
            {
                return item;
            }
        }

        public TelaItemForm(IRepositorioItem repositorioItem, bool modoEdicao = false)
        {
            InitializeComponent();
            txtValor.KeyPress += TxtValor_KeyPress;

            this.repositorioItem = repositorioItem;
            this.modoEdicao = modoEdicao;

            if (modoEdicao)
            {
                this.Text = "Editar Item";
            }
            else
            {
                int proximoId = repositorioItem.ObterProximoId();
                txtId.Text = proximoId.ToString();
            }
        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("Por gentileza, insira apenas números neste campo!");
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;
            decimal valor;

            if (!decimal.TryParse(txtValor.Text, NumberStyles.Any, new CultureInfo("pt-BR"), out valor))
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Por gentileza, informe um valor numérico!");
                DialogResult = DialogResult.None;
                return;
            }

            if (item == null)
            {
                item = new Item();
            }

            item.Descricao = descricao;
            item.Valor = valor;

            List<string> erros = item.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
            else
            {
                if (modoEdicao)
                {
                    repositorioItem.Editar(item.Id, item);
                }
                else
                {
                    int proximoId = repositorioItem.ObterProximoId();
                    item.Id = proximoId;
                    repositorioItem.Cadastrar(item);
                }
            }
        }
    }
}