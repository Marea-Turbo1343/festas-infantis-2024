using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloItemTema
{
    public partial class TabelaItemTemaControl : UserControl
    {
        public TabelaItemTemaControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<ItemTema> itemTema)
        {
            grid.Rows.Clear();

            foreach (ItemTema c in itemTema)
                grid.Rows.Add(c.Id, c.Titulo.ToTitleCase(), c.Ativo);
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Titulo", HeaderText = "Titulo" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Valor", HeaderText = "Valor" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Ativo", HeaderText = "Ativo" },
                        };
        }
    }
}