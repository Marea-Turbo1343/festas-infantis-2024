namespace FestasInfantis.WinApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string TipoCadastro { get; }

        public abstract string ToolTipAdicionar { get; }
        public abstract string ToolTipEditar { get; }
        public abstract string ToolTipExcluir { get; }

        public abstract UserControl ObterListagem();

        public abstract void Adicionar();
        public abstract void Editar();
        public abstract void Excluir();

        public virtual bool HabilitarBtnAdicionar() { return true; }
        public virtual bool HabilitarBtnEditar() { return true; }
        public virtual bool HabilitarBtnExcluir() { return true; }
        public virtual bool HabilitarBtnFiltrar() { return false; }
        public virtual bool HabilitarBtnAdicionarItens() { return false; }
        public virtual bool HabilitarBtnVisualizarAlugueis() { return false; }
        public virtual bool HabilitarBtnConcluirAluguel() { return false; }
        public virtual bool HabilitarBtnConfigurarDescontos() { return false; }
    }
}