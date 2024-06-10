using FestasInfantis.WinApp.ModuloAluguel;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class TelaVerAlugueisForm : Form
    {
        private IRepositorioAluguel repositorioAluguel;
        private int idCliente;
    
        public TelaVerAlugueisForm(IRepositorioAluguel repositorioAluguel, int idCliente)
        {
            InitializeComponent();
    
            this.repositorioAluguel = repositorioAluguel;
            this.idCliente = idCliente;
    
            CarregarAlugueis();
        }
    
        private void CarregarAlugueis()
        {
            //List<Aluguel> alugueisDoCliente = repositorioAluguel.SelecionarPorCliente(idCliente);

            //listViewAlugueis.Items.Clear();
    
            //foreach (Aluguel aluguel in alugueisDoCliente)
            //{
            //    ListViewItem item = new ListViewItem(aluguel.Id.ToString());
            //    item.SubItems.Add(aluguel.Tema);
            //    item.SubItems.Add(aluguel.Valor.ToString());
            //    item.SubItems.Add(aluguel.DataFesta.ToString());
            //    item.SubItems.Add(aluguel.StatusPago ? "Pago" : "Não pago");
            //    if (aluguel.StatusPago)
            //        item.SubItems.Add(aluguel.DataPagamento.ToString());
    
            //    listAlugueis.Items.Add(item);
            //}
        }
    }
}