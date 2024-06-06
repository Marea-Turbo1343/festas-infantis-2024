using FestasInfantis.ConsoleApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloItem
{
    internal class ItemTema : EntidadeBase<ItemTema>
    {
        public decimal Valor { get; set; }
        public string Titulo { get; set; }
        public bool Ativo { get; set; }


        public ItemTema(decimal valor, string titulo, bool ativo)
        {
            Valor = valor;
            Titulo = titulo;
            Ativo = ativo;
        }

        public override string[] Validar()
        {
            List<string> erros = new();

            if (Titulo!.Trim().Length < 3)
            {
                erros.Add("Por gentileza, informe um titulo maior do que três caracteres!");
            }
            if (Valor < 0)
            {
                erros.Add("Por gentileza, informe um valor positivo!");
            }

            return erros.ToArray();
        }

        public override string ToString()
        {
            return $"{Titulo} R${Valor}";
        }

        public override bool Equals(object? obj)
        {
            return obj is ItemTema tema &&
                   Valor == tema.Valor &&
                   Titulo == tema.Titulo;
        }

        public override void Editar(ItemTema entidade)
        {
            Valor = entidade.Valor;
            Titulo = entidade.Titulo;
            Ativo = entidade.Ativo;
        }
    }
}
