using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloItemTema
{
    public partial class ListagemItemTemaControl : UserControl
    {
        public ListagemItemTemaControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<ItemTema> itemTema)
        {
            listItemTema.Items.Clear();

            foreach (ItemTema itemTema in itemTema)
                listItemTema.Items.Add(itemTema);
        }

        public ItemTema ObterRegistroSelecionado()
        {
            if (listItemTema.SelectedItem == null)
                return null;

            return (ItemTema)listItemTema.SelectedItem;
        }
    }
}
