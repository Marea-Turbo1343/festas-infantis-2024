using FestasInfantis.WinApp.ModuloAluguel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class TelaVerAlugueisForm : Form
    {
        public TelaVerAlugueisForm()
        {
            InitializeComponent();
        }
    }
}

//public partial class TelaVerAlugueisForm : Form
//{
//    private IRepositorioAluguel repositorioAluguel;
//    private int idCliente;

//    public TelaVerAlugueisForm(IRepositorioAluguel repositorioAluguel, int idCliente)
//    {
//        InitializeComponent();

//        this.repositorioAluguel = repositorioAluguel;
//        this.idCliente = idCliente;

//        CarregarAlugueis();
//    }

//    private void CarregarAlugueis()
//    {
//        // Obter os aluguéis para o cliente selecionado
//        List<Aluguel> alugueisDoCliente = repositorioAluguel.SelecionarPorCliente(idCliente);

//        // Limpar a listagem de aluguéis
//        listAlugueis.Items.Clear();

//        // Adicionar cada aluguel à listagem
//        foreach (Aluguel aluguel in alugueisDoCliente)
//        {
//            ListViewItem item = new ListViewItem(aluguel.Id.ToString());
//            item.SubItems.Add(aluguel.TemaAlugado);
//            item.SubItems.Add(aluguel.Valor.ToString());
//            item.SubItems.Add(aluguel.DataFesta.ToString());
//            item.SubItems.Add(aluguel.StatusPago ? "Pago" : "Não pago");
//            if (aluguel.StatusPago)
//                item.SubItems.Add(aluguel.DataPagamento.ToString());

//            listAlugueis.Items.Add(item);
//        }
//    }
//}

