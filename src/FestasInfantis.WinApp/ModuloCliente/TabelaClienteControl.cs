using FestasInfantis.WinApp.Compartilhado;
using System.Text.RegularExpressions;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class TabelaClienteControl : UserControl
    {
        public TabelaClienteControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());
            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        private string RemoverCaracteresNaoNumericos(string texto)
        {
            return Regex.Replace(texto, @"\D", "");
        }

        internal void AtualizarRegistros(List<Cliente> clientes)
        {
            grid.Rows.Clear();

            foreach (Cliente c in clientes)
            {
                string cpfLimpo = RemoverCaracteresNaoNumericos(c.Cpf);
                string cpfFormatado = Convert.ToUInt64(cpfLimpo).ToString(@"000\.000\.000\-00");
                string telefoneLimpo = RemoverCaracteresNaoNumericos(c.Telefone);
                string telefoneFormatado = Convert.ToUInt64(telefoneLimpo).ToString(@"(00) 00000\-0000");
                grid.Rows.Add(c.Id, c.Nome.ToTitleCase(), cpfFormatado, telefoneFormatado, c.ContadorDeAlugueis);
            }
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" },
                new DataGridViewTextBoxColumn { DataPropertyName = "CPF", HeaderText = "CPF" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone" },
                new DataGridViewTextBoxColumn { DataPropertyName = "ContadorDeAlugueis", HeaderText = "Qtd de Aluguéis" }
                        };
        }
    }
}