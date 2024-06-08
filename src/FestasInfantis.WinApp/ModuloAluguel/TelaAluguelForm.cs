using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        private Aluguel aluguel;
        public Aluguel Aluguel
        {
            set
            {
                txtId.Text = value.Id.ToString();
                cmbCliente.SelectedItem = value.Cliente;
                cmbTema.SelectedItem = value.Tema;
                cmbEntrada.SelectedItem = value.PorcentagemEntrada;
                txtQtdEmp.Text = value.QuantidadeEmprestimos.ToString();
                txtDescontoCliente.Text = value.DescontoDisponibilizado.ToString();
                txtEndereco.Text = value.EnderecoFesta;
                txtDataFesta.Value = value.DataFesta;
                txtHoraInicio.Value = value.HoraInicio;
                txtHoraTermino.Value = value.HoraTermino;
                txtDescontoDisponivel.Text = value.DescontoTotal.ToString();
                txtValorTotal.Text = value.ValorTotal.ToString();
            }
            get
            {
                return aluguel;
            }
        }

        public TelaAluguelForm()
        {
            InitializeComponent();
        }

        public void CarregarClientes(List<Cliente> clientes)
        {
            cmbCliente.Items.Clear();

            foreach (Cliente c in clientes)
                cmbCliente.Items.Add(c);
        }

        public void CarregarTemas(List<Tema> temas)
        {
            cmbTema.Items.Clear();

            foreach (Tema t in temas)
                cmbTema.Items.Add(t);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)cmbCliente.SelectedItem;
            Tema tema = (Tema)cmbTema.SelectedItem;
            int porcentagemEntrada = (int)cmbEntrada.SelectedItem;
            int quantidadeEmprestimos = int.Parse(txtQtdEmp.Text);
            decimal descontoDisponibilizado = decimal.Parse(txtDescontoCliente.Text);
            string enderecoFesta = txtEndereco.Text;
            DateTime dataFesta = txtDataFesta.Value;
            DateTime horaInicio = txtHoraInicio.Value;
            DateTime horaTermino = txtHoraTermino.Value;
            decimal descontoTotal = decimal.Parse(txtDescontoDisponivel.Text);
            decimal valorTotal = decimal.Parse(txtValorTotal.Text);

            aluguel = new Aluguel(cliente, tema, porcentagemEntrada, quantidadeEmprestimos, descontoDisponibilizado, enderecoFesta, dataFesta, horaInicio, horaTermino, descontoTotal, valorTotal, tema.Itens);
        }
    }
}
