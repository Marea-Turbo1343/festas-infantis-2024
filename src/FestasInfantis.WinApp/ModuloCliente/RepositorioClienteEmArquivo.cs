using FestasInfantis.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public class RepositorioClienteEmArquivo : RepositorioBaseEmArquivo<Cliente>, IRepositorioCliente
    {
        public RepositorioClienteEmArquivo(ContextoDados contexto) : base(contexto)
        {
            if (contexto.Clientes.Any())
                contadorId = contexto.Clientes.Max(c => c.Id) + 1;
        }

        protected override List<Cliente> ObterRegistros()
        {
            return contexto.Clientes;
        }

        public int ObterProximoId()
        {
            if (contexto.Clientes.Any())
                return contexto.Clientes.Max(c => c.Id) + 1;
            else
                return 1;
        }

        public List<Aluguel> BuscarAlugueisPorCliente(Cliente cliente)
        {
            return contexto.Alugueis.Where(i => i.Cliente!.Equals(cliente)).ToList();
        }

        public override bool Excluir(int id)
        {
            Cliente cliente = SelecionarPorId(id);

            List<Aluguel> alugueisRelacionados =
                contexto.Alugueis.FindAll(c => c.Cliente.Id == cliente.Id);

            foreach (Aluguel c in alugueisRelacionados)
                c.Cliente = null;

            return base.Excluir(id);
        }
    }
}
