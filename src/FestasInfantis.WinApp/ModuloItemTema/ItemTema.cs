using FestasInfantis.ConsoleApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloItemTema
{
    public class ItemTema : EntidadeBase
    {
        public string Titulo { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }


        public ItemTema(string titulo, decimal valor, bool ativo)
        {
            Valor = valor;
            Titulo = titulo;
            Ativo = ativo;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Titulo.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            if (Valor < 0)
                erros.Add("Por gentileza, informe um valor positivo!");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            ItemTema atualizado = (ItemTema)novoRegistro;

            Titulo = atualizado.Titulo;
            Valor = atualizado.Valor;
            Ativo = atualizado.Ativo;
        }

        public override string ToString()
        {
            return $"{Titulo} R${Valor}";
        }
    }
}
