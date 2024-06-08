namespace FestasInfantis.WinApp.ModuloAluguel
{
    public interface IRepositorioAluguel
    {
        void Cadastrar(Aluguel novoAluguel);
        bool Editar(int id, Aluguel aluguelEditado);
        bool Excluir(int id);
        Aluguel SelecionarPorId(int idSelecionado);
        List<Aluguel> SelecionarTodos();
        List<Aluguel> SelecionarAlugueisPorPeriodo(DateTime dataInicio, DateTime dataTermino);
    }
}
