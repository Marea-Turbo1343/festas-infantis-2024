using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TabelaTemaControl : UserControl
    {
        public TabelaTemaControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());
            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
            grid.CellDoubleClick += Grid_DoubleClick;
        }

        private void Grid_DoubleClick(object sender, DataGridViewCellEventArgs e)
{
            Tema temaSelecionado = (Tema)grid.CurrentRow.DataBoundItem;

            if (temaSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um tema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TelaVerTemaForm telaVerTema = new TelaVerTemaForm(temaSelecionado);
            telaVerTema.ShowDialog();
        }

        public void AtualizarRegistros(List<Tema> temas)
        {
            grid.DataSource = temas;
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
                        {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome do Tema" },
                new DataGridViewTextBoxColumn { DataPropertyName = "ValorTotal", HeaderText = "Valor Total" },
                        };
        }
    }
}