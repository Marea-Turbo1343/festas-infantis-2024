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
            txtDesconto.Text = aluguel.ConfiguracaoDesconto.ToString();
            txtValorDesconto.Text = aluguel.ValorDesconto.ToString();
            txtDesconto.Text = $"{aluguel.ConfiguracaoDesconto}%";
            txtValorDesconto.Text = $"R${aluguel.ValorDesconto}";
        }
    }
}
