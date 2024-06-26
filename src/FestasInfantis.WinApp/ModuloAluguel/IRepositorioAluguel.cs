﻿namespace FestasInfantis.WinApp.ModuloAluguel
{
    public interface IRepositorioAluguel
    {
        void Cadastrar(Aluguel novoAluguel);
        bool Editar(int id, Aluguel aluguelEditado);
        bool Excluir(int id);
        Aluguel SelecionarPorId(int idSelecionado);
        List<Aluguel> SelecionarTodos();
        List<Aluguel> SelecionarAlugueisAberto();
        List<Aluguel> SelecionarAlugueisConcluidos();
        List<Aluguel> SelecionarAlugueisPorPeriodo(DateTime dataInicio, DateTime dataTermino);
        ConfiguracaoDesconto SelecionarConfiguracaoDesconto();
        int ObterProximoId();
        void SalvarDesconto(ConfiguracaoDesconto configuracaoDesconto);
        List<Aluguel> SelecionarPorCliente(int idCliente);
    }
}