namespace FestasInfantis.WinApp.ModuloItem
{
    public partial class ListagemItemControl : UserControl
    {
        public ListagemItemControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Item> itemTema)
        {
            //listItemTema.Items.Clear();

            //foreach (ItemTema itemTema in itemTema)
            //    listItemTema.Items.Add(itemTema);
        }

        public Item ObterRegistroSelecionado()
        {
            if (listItemTema.SelectedItem == null)
                return null;

            return (Item)listItemTema.SelectedItem;
        }
    }
}
