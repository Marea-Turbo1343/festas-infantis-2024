using FestasInfantis.WinApp.ModuloAluguel;
using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaAdicionarItensForm : Form
    {
        private Tema tema;
        private List<Item> itens;
        private IRepositorioTema repositorioTema;
        private IRepositorioAluguel repositorioAluguel;

        public TelaAdicionarItensForm(Tema tema, List<Item> itens, IRepositorioTema repositorioTema, IRepositorioAluguel repositorioAluguel)
        {
            InitializeComponent();

            this.tema = tema;
            this.itens = itens;
            this.repositorioTema = repositorioTema;
            this.repositorioAluguel = repositorioAluguel;

            txtId.Text = tema.Id.ToString();
            txtNome.Text = tema.Nome;
            txtId.ReadOnly = true;
            txtNome.ReadOnly = true;

            CarregarItens();
        }

        private void CarregarItens()
        {
            cmbItens.DataSource = itens.FindAll(i => true);
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            Item itemSelecionado = (Item)cmbItens.SelectedItem;

            if (itemSelecionado != null)
            {
                if (tema.Itens.Contains(itemSelecionado))
                {
                    MessageBox.Show("Item selecionado já pertence ao tema", "Item");
                }
                else
                {
                    foreach (Tema t in repositorioTema.SelecionarTodos())
                    {
                        if (t.Itens.Contains(itemSelecionado) && t.Id != tema.Id)
                        {
                            MessageBox.Show($"O item {itemSelecionado.Descricao} já está vinculado ao tema {t.Nome}", "Item já vinculado");
                            return;
                        }
                    }

                    tema.Itens.Add(itemSelecionado);
                    listBoxItensTema.Items.Add(itemSelecionado);
                    numValor.Value += itemSelecionado.Valor;
                }
            }
        }

        private void btnDeletarItem_Click(object sender, EventArgs e)
        {
            Item itemSelecionado = (Item)listBoxItensTema.SelectedItem;

            if (itemSelecionado != null)
            {
                if (repositorioAluguel.SelecionarTodos().Any(a => a.Tema.Id == tema.Id && a.PagamentoConcluido == false))
                {
                    MessageBox.Show("Não é possível remover um item de um tema que está vinculado a um aluguel não finalizado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                listBoxItensTema.Items.Remove(itemSelecionado);
                numValor.Value -= itemSelecionado.Valor;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tema.Itens = new List<Item>(listBoxItensTema.Items.Cast<Item>());

            List<string> erros = tema.Validar();

            if (erros.Count > 0)
            {
                MessageBox.Show(erros[0]);
                DialogResult = DialogResult.None;
            }
            else
            {
                repositorioTema.Editar(tema.Id, tema);
            }
        }
    }
}