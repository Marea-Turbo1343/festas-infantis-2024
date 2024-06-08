using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        private Tema tema;
        public Tema Tema
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
                listBoxItensTema.Items.Clear();
                foreach (var item in value.Itens)
                {
                    listBoxItensTema.Items.Add($"{item.Descricao} R${item.Valor}");
                }
            }
            get
            {
                return tema;
            }
        }

        public TelaTemaForm()
        {
            InitializeComponent();
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            Item itemSelecionado = (Item)cmbItens.SelectedItem;
            tema.Itens.Add(itemSelecionado);
            listBoxItensTema.Items.Add($"{itemSelecionado.Descricao} R${itemSelecionado.Valor}");
        }

        private void btnDeletarItem_Click(object sender, EventArgs e)
        {
            int indexSelecionado = listBoxItensTema.SelectedIndex;
            if (indexSelecionado != -1)
            {
                tema.Itens.RemoveAt(indexSelecionado);
                listBoxItensTema.Items.RemoveAt(indexSelecionado);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            tema = new Tema(nome);

            List<string> erros = tema.Validar();

            if (erros.Count > 0)
            {
                MessageBox.Show(erros[0]);
                DialogResult = DialogResult.None;
            }
        }
    }
}