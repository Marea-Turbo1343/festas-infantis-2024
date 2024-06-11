using FestasInfantis.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloItem;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class Aluguel : EntidadeBase
    {
        public Cliente Cliente { get; set; }
        public Tema Tema { get; set; }
        public PorcentagemEntrada Entrada { get; set; }
        public int QuantidadeEmprestimos { get; set; }
        public ConfiguracaoDesconto ConfiguracaoDesconto { get; set; }
        public string EnderecoFesta { get; set; }
        public DateTime DataFesta { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraTermino { get; set; }
        public DateTime DataPagamento { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorEntrada { get; set; }
        public decimal Debito { get; set; }
        public decimal PorcentagemDesconto { get; set; }
        public decimal ValorDesconto { get; set; }
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
            ConfiguracaoDesconto configuracaoDesconto,
            string enderecoFesta,
            DateTime dataFesta,
            DateTime horaInicio,
            DateTime horaTermino,
            decimal valorTotal,
            decimal valorEntrada,
            decimal debito,
            List<Item> itensAlugueis
        )
        {
            Cliente = cliente;
            Tema = tema;
            Entrada = entrada;
            QuantidadeEmprestimos = quantidadeEmprestimos;
            ConfiguracaoDesconto = configuracaoDesconto;
            EnderecoFesta = enderecoFesta;
            DataFesta = dataFesta;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
            ValorTotal = CalcularValorTotal(ConfiguracaoDesconto);
            ValorEntrada = CalcularValorEntrada(ValorTotal, Entrada);
            Debito = CalcularDebito(Entrada, ValorTotal);
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

        public decimal CalcularValorTotal(ConfiguracaoDesconto valorDesconto)
        {
            decimal valorDesc = valorDesconto.PorcentagemDesconto;

            decimal valorDescMaximo = valorDesconto.PorcentagemMaxima;

            decimal desconto = Cliente!.ContadorDeAlugueis * valorDesc;

            if (desconto >= valorDescMaximo)
            {
                desconto = valorDescMaximo;
            }

            PorcentagemDesconto = desconto;

            return Math.Round(ObterValorTotal(desconto), 2);
        }

        public static decimal CalcularValorEntrada(decimal valorTotal, PorcentagemEntrada porcentagemDeEntrada)
        {
            decimal porcentagem = (int)porcentagemDeEntrada;

            decimal valorEntrada = valorTotal * (porcentagem / 100);

            return Math.Round(valorEntrada, 2);
        }

        public static decimal CalcularDebito(PorcentagemEntrada porcentagemDeEntrada, decimal valorTotal)
        {
            decimal porcentagem = (int)porcentagemDeEntrada / 100m;
            decimal valorEntrada = valorTotal * porcentagem;

            if (porcentagemDeEntrada == PorcentagemEntrada._40porcento || porcentagemDeEntrada == PorcentagemEntrada._50porcento)
            {
                return valorTotal - valorEntrada;
            }
            else
            {
                throw new Exception("A porcentagem de entrada deve ser 40% ou 50%.");
            }
        }

        public void ConcluirAluguel()
        {
            DataPagamento = DateTime.Now;
            Debito = 0;
        }

        public decimal ObterValorTotal(decimal desconto)
        {
            if (Tema == null) return 0;

            decimal valorTema = Tema.ValorTotal;

            ValorDesconto = valorTema * (desconto / 100);

            valorTema -= ValorDesconto;

            return valorTema;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Aluguel atualizado = (Aluguel)novoRegistro;

            Cliente = atualizado.Cliente;
            Tema = atualizado.Tema;
            Entrada = atualizado.Entrada;
            QuantidadeEmprestimos = atualizado.QuantidadeEmprestimos;
            ConfiguracaoDesconto = atualizado.ConfiguracaoDesconto;
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