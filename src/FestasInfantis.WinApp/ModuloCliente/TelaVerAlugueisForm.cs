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
            List<Aluguel> alugueis = repositorioAluguel.SelecionarPorCliente(idCliente);

            listViewAlugueis.Items.Clear();

            foreach (Aluguel aluguel in alugueis)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
            aluguel.Tema.Nome,
            aluguel.DataFesta.ToString(),
            aluguel.PagamentoConcluido ? "Aluguel Concluido" : "Aluguel em Andamento"
                });

                listViewAlugueis.Items.Add(item);
            }
        }
    }
}