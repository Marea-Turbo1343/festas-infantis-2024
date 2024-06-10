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

            listViewAlugueis.Items.Clear(); // Limpa a lista antes de adicionar novos itens

            foreach (Aluguel aluguel in alugueis)
            {
                // Cria um novo item de lista com as informações do aluguel
                ListViewItem item = new ListViewItem(new string[]
                {
            aluguel.Tema.Nome, // Substitua pelo campo correto do tema do aluguel
            aluguel.DataFesta.ToString(), // Substitua pelo campo correto da data da festa
            aluguel.PagamentoConcluido ? "Aluguel Concluido" : "Aluguel em Andamento"
                });

                // Adiciona o item à ListView
                listViewAlugueis.Items.Add(item);
            }
        }
    }
}