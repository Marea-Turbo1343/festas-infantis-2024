using FestasInfantis.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloItem;
using FestasInfantis.WinApp.ModuloTema;
using System.ComponentModel;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class Aluguel : EntidadeBase
    {
        public Cliente Cliente { get; set; }
        public Tema Tema { get; set; }
        public PorcentagemEntrada Entrada { get; set; }
        public int QuantidadeEmprestimos { get; set; }
        public decimal DescontoDisponibilizado { get; set; }
        public string EnderecoFesta { get; set; }
        public DateTime DataFesta { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraTermino { get; set; }
        public DateTime DataPagamento { get; set; }
        public decimal ValorTotal { get; set; }
        public List<Item> ItensAlugueis { get; set; }
        public bool PagamentoConcluido { get => DataPagamento != null; }

        public Aluguel()
        {
        }

        public Aluguel(
            Cliente cliente,
            Tema tema,
            PorcentagemEntrada entrada,
            int quantidadeEmprestimos,
            decimal descontoDisponibilizado,
            string enderecoFesta,
            DateTime dataFesta,
            DateTime horaInicio,
            DateTime horaTermino,
            decimal valorTotal,
            List<Item> itensAlugueis
        )
        {
            Cliente = cliente;
            Tema = tema;
            Entrada = entrada;
            QuantidadeEmprestimos = quantidadeEmprestimos;
            DescontoDisponibilizado = descontoDisponibilizado;
            EnderecoFesta = enderecoFesta;
            DataFesta = dataFesta;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
            decimal valorDoDesconto = (DescontoDisponibilizado / 100) * valorTotal;
            ValorTotal = valorTotal - valorDoDesconto;
            ItensAlugueis = itensAlugueis;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (Cliente == null)
                erros.Add("O campo \"cliente\" é obrigatório");

            if (Tema == null)
                erros.Add("O campo \"tema\" é obrigatório");

            if (string.IsNullOrEmpty(EnderecoFesta.Trim()))
                erros.Add("O campo \"endereço da festa\" é obrigatório");

            if (HoraInicio > HoraTermino)
                erros.Add("A hora de início não pode ser depois da hora de término.");

            if (HoraTermino < HoraInicio)
                erros.Add("A hora de término não pode ser antes da hora de início.");

            return erros;
        }

        public enum PorcentagemEntrada
        {
            [Description("40%")] _40porcento = 40,
            [Description("50%")] _50porcento = 50,
        }

        public decimal CalcularValorTotal()
        {
            if (Tema != null)
            {
                decimal valorDoDesconto = (DescontoDisponibilizado / 100) * Tema.ValorTotal;
                return Tema.ValorTotal - valorDoDesconto;
            }
            else
            {
                return 0;
            }
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Aluguel atualizado = (Aluguel)novoRegistro;

            Cliente = atualizado.Cliente;
            Tema = atualizado.Tema;
            Entrada = atualizado.Entrada;
            QuantidadeEmprestimos = atualizado.QuantidadeEmprestimos;
            DescontoDisponibilizado = atualizado.DescontoDisponibilizado;
            EnderecoFesta = atualizado.EnderecoFesta;
            DataFesta = atualizado.DataFesta;
            HoraInicio = atualizado.HoraInicio;
            HoraTermino = atualizado.HoraTermino;
            ValorTotal = atualizado.ValorTotal;
            ItensAlugueis = atualizado.ItensAlugueis;
        }

        public override string ToString()
        {
            string nomeCliente = Cliente == null ? string.Empty : Cliente.Nome;
            string nomeTema = Tema == null ? string.Empty : Tema.Nome;

            return $"Id: {Id}, Cliente: {nomeCliente}, Tema: {nomeTema}, Data da Festa: {DataFesta.ToShortDateString()}, Início: {HoraInicio.ToString(@"hh\:mm")}, Término: {HoraTermino.ToString(@"hh\:mm")}, Valor Total: {ValorTotal}";
        }
    }
}