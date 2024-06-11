using FestasInfantis.WinApp.ModuloAluguel;
using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        private Tema tema;
        private List<Item> itens;
        private IRepositorioTema repositorioTema;
        private IRepositorioAluguel repositorioAluguel;
        private bool modoEdicao;

        public Tema Tema
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
                numValor.Value = value.ValorTotal;
                value.Itens!.ForEach(i => listBoxItensTema.Items.Add(i));
                itens = value.Itens;
            }
            get
            {
                return tema;
            }
        }

        public TelaTemaForm(List<Item> itens, IRepositorioTema repositorioTema, IRepositorioAluguel repositorioAluguel, bool modoEdicao = false)
        {
            InitializeComponent();

            this.itens = itens;
            this.repositorioTema = repositorioTema;
            this.repositorioAluguel = repositorioAluguel;
            this.modoEdicao = modoEdicao;

            if (modoEdicao)
            {
                this.Text = "Editar Tema";
            }
            else
            {
                int proximoId = repositorioTema.ObterProximoId();
                txtId.Text = proximoId.ToString();
            }

            CarregarItens();

            tema = new Tema("");
            tema.Itens = new List<Item>();
        }

        private void CarregarItens()
        {
            var todosOsTemas = repositorioTema.SelecionarTodos();

            var itensVinculados = todosOsTemas.SelectMany(t => t.Itens).ToList();

            var itensNaoVinculados = itens.Except(itensVinculados).ToList();

            cmbItens.DataSource = itensNaoVinculados;
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
                itens.Add(itemSelecionado);
                CarregarItens();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            tema.Nome = nome;
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