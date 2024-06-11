namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaFiltroAluguelForm : Form
    {
        public TelaFiltroAluguelForm()
        {
            InitializeComponent();

            groupBoxDatas.Enabled = false;
        }

        public FiltroAluguelEnum ObterStatus()
        {
            if (rdobtnConcluidos.Checked == true)
            {
                return FiltroAluguelEnum.Concluidos;
            }
            else if (rdobtnAberto.Checked == true)
            {
                return FiltroAluguelEnum.Aberto;
            }
            else if (rdobtnTodos.Checked == true)
            {
                return FiltroAluguelEnum.Todos;
            }
            else
            {
                return FiltroAluguelEnum.Data;
            }
        }

        public DateTime ObterDataInicial()
        {
            return txtDataInicial.Value;
        }

        public DateTime ObterDataFinal()
        {
            return txtDataFinal.Value;
        }

        private void CboxVisualizarPorData_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxDatas.Enabled = !groupBoxDatas.Enabled;

            rdobtnAberto.Checked = false;

            rdobtnConcluidos.Checked = false;

            rdobtnTodos.Checked = false;
        }

        internal bool FiltrarPorData()
        {
            return cboxVisualizarPorData.Checked;
        }

        private void RadiobtnTodos_CheckedChanged(object sender, EventArgs e)
        {
            cboxVisualizarPorData.Checked = false;
        }

        private void RadiobtnAberto_CheckedChanged(object sender, EventArgs e)
        {
            cboxVisualizarPorData.Checked = false;
        }

        private void RadiobtnConcluidos_CheckedChanged(object sender, EventArgs e)
        {
            cboxVisualizarPorData.Checked = false;
        }
    }
}