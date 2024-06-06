using FestasInfantis.ConsoleApp.Compartilhado;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class Tema : EntidadeBase
    {
        public string Nome { get; set; }
        public List<Item> Itens { get; set; }
        public decimal ValorTotal {  get => CalcularValorTotal(); }

        public Tema (string tema, List<Item>itens)
        {
            this.Nome = tema;
            this.Itens = itens;
        }

        public override void Editar(Tema temaAtualizado)
        {
            this.Nome = temaAtualizado.Nome;
            this.Itens = temaAtualizado.Itens;

        }

        public override string[] Validar()
        {
            List<string> erros = new();

            if (Nome!.Trim().Length < 3)
            {
                erros.Add("Por gentileza, informe um nome com no mínimo cinco caracteres!");
            }

            if (ValorTotal == 0)
            {
                erros.Add("Não é possível cadastrar tema com valor igual a zero, por favor inclua algum item!");
            }

            return erros.ToArray();
        }

        public override string ToString()
        {
            return Nome.ToTitleCase();
        }

        public decimal CalcularValorTotal()
        {
            return Itens == null || Itens.Count == 0 ? 0 : Itens.Sum(i => i.Valor);
        }

        public override bool Equals(object? obj)
        {
            return obj is Tema tema &&
                   Id == tema.Id &&
                   Nome == tema.Nome &&
                   EqualityComparer<List<ItemTema>>.Default.Equals(Itens, tema.Itens) &&
                   ValorTotal == tema.ValorTotal;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Tema atualizado = (Tema)novoRegistro;

            Nome = atualizado.Nome;
            Itens = atualizado.Itens;
            ValorTotal = atualizado.ValorTotal;
        }
    }
}
