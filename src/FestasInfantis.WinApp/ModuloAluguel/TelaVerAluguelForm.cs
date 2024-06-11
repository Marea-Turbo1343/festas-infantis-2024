namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaVerAluguelForm : Form
    {
        public TelaVerAluguelForm(Aluguel aluguel)
        {
            InitializeComponent();

            txtId.Text = aluguel.Id.ToString();
            txtCliente.Text = aluguel.Cliente.Nome;
            txtTelefone.Text = aluguel.Cliente.Telefone;
            txtEndereco.Text = aluguel.EnderecoFesta;
            txtTema.Text = aluguel.Tema.Nome;
            txtEntrada.Text = aluguel.Entrada.ToString() + "%";
            txtValorEntrada.Text = aluguel.ValorEntrada.ToString();
            txtDesconto.Text = $"{aluguel.ConfiguracaoDesconto}%";
            txtValorDesconto.Text = $"R${aluguel.ValorDesconto}";
            txtEmAberto.Text = aluguel.FestaJaAconteceu ? "Sim" : "Não";
            txtPago.Text = aluguel.PagamentoConcluido ? "Sim" : "Não";
            txtValor.Text = aluguel.ValorTotal.ToString();
            txtDataFesta.Text = aluguel.DataFesta.ToShortDateString();
            txtHoraInicio.Text = aluguel.HoraInicio.ToString(@"hh\:mm");
            txtHoraTermino.Text = aluguel.HoraTermino.ToString(@"hh\:mm");
            txtDebito.Text = aluguel.Debito.ToString();
        }
    }
}
