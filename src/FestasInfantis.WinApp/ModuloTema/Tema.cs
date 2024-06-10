using FestasInfantis.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class Tema : EntidadeBase
    {
        public string Nome { get; set; }
        public List<Item> Itens { get; set; }
        public decimal ValorTotal { get => CalcularValorTotal(); }

        public Tema()
        {
            Itens = new List<Item>();
        }

        public Tema(string nome)
        {
            Nome = nome;
            Itens = new List<Item>();
        }

        public decimal CalcularValorTotal()
        {
            return Itens == null || Itens.Count == 0 ? 0 : Itens.Sum(i => i.Valor);
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (Nome.Trim().Length < 3)
                erros.Add("Por gentileza, informe um nome de tema com mais de três caracteres!");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Tema atualizado = (Tema)novoRegistro;

            Nome = atualizado.Nome;
            Itens = atualizado.Itens;
        }
    }
}