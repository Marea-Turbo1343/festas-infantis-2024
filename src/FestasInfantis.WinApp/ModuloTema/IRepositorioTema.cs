﻿using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public interface IRepositorioTema
    {
        void Cadastrar(Tema novoTema);
        bool Editar(int id, Tema temaEditado);
        bool Excluir(int id);
        Tema SelecionarPorId(int idSelecionado);
        int ObterProximoId();
        Tema AdicionarItens(int id, Tema tema);
        List<Tema> SelecionarTodos();
    }
}