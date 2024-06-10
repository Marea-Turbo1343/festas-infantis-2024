namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaDescontoForm : Form
    {
        public ConfiguracaoDesconto configuracaoDesconto = null!;

        public ConfiguracaoDesconto ConfiguracaoDesconto
        {
            set
            {
                numDesconto.Value = value.PorcentagemDesconto;
                numDescontoMax.Value = value.PorcentagemMaxima;
            }
            get
            {
                return configuracaoDesconto;
            }
        }

        public TelaDescontoForm(ConfiguracaoDesconto configuracaoDesconto)
        {
            InitializeComponent();
            numDesconto.KeyPress += NumDesconto_KeyPress;
            numDescontoMax.KeyPress += NumDescontoMax_KeyPress;

            numDesconto.Minimum = 1;
            numDesconto.Maximum = 100;
            numDescontoMax.Minimum = 1;
            numDescontoMax.Maximum = 100;

            numDesconto.Value = configuracaoDesconto.PorcentagemDesconto;
            numDescontoMax.Value = configuracaoDesconto.PorcentagemMaxima;
        }

        private void NumDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("Por gentileza, insira apenas números neste campo!");
            }

            if ((e.KeyChar == ',') && ((sender as NumericUpDown).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void NumDescontoMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("Por gentileza, insira apenas números neste campo!");
            }

            if ((e.KeyChar == ',') && ((sender as NumericUpDown).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            decimal porcentagemDesconto = numDesconto.Value;
            decimal porcentagemMaxima = numDescontoMax.Value;

            configuracaoDesconto = new ConfiguracaoDesconto()
            {
                PorcentagemDesconto = porcentagemDesconto,
                PorcentagemMaxima = porcentagemMaxima
            };

            bool isValid = configuracaoDesconto.Validar();

            if (!isValid)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Por gentileza, a porcentagem de desconto deve ser menor que a porcentagem máxima!");
                DialogResult = DialogResult.None;
            }
        }
    }
}