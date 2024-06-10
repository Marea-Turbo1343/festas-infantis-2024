using FestasInfantis.ConsoleApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class Item : EntidadeBase
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public Item()
        {
        }

        public Item(string descricao, decimal valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (Descricao!.Trim().Length < 5)
                erros.Add("Por gentileza, informe uma descrição maior do que cinco caracteres!");

            if (Valor <= 0)
            {
                erros.Add("Por gentileza, informe um valor maior do que 0!");
            }

            return erros;
        }

        public override string ToString()
        {
            return $"{Descricao} R${Valor}";
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Item atualizado = (Item)novoRegistro;

            Descricao = atualizado.Descricao;
            Valor = atualizado.Valor;
        }
    }
}