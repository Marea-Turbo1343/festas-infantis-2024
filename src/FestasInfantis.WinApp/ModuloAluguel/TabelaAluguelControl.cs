using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TabelaAluguelControl : UserControl
    {
        public TabelaAluguelControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Aluguel> alugueis)
        {
            grid.Rows.Clear();

            foreach (Aluguel a in alugueis)
                grid.Rows.Add(
                    a.Id,
                    a.Cliente.Nome,
                    a.Tema.Nome,
                    a.DataFesta.ToShortDateString(),
                    a.HoraInicio.ToString(@"hh\:mm"),
                    a.HoraTermino.ToString(@"hh\:mm"),
                    a.ValorTotal);
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Cliente", HeaderText = "Cliente" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Tema", HeaderText = "Tema" },
                new DataGridViewTextBoxColumn { DataPropertyName = "DataFesta", HeaderText = "Data da Festa" },
                new DataGridViewTextBoxColumn { DataPropertyName = "HoraInicio", HeaderText = "Começa às" },
                new DataGridViewTextBoxColumn { DataPropertyName = "HoraTermino", HeaderText = "Termina às" },
                new DataGridViewTextBoxColumn { DataPropertyName = "ValorTotal", HeaderText = "Valor Total" },
                        };
        }
    }
}