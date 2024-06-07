using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloItem;
using FestasInfantis.WinApp.ModuloTema;
using FestasInfantis.WinApp.ModuloAluguel;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace FestasInfantis.WinApp.Compartilhado
{
    public class ContextoDados
    {
        public List<Cliente> Clientes { get; set; }
        //public List<Compromisso> Compromissos { get; set; }
        //public List<Tarefa> Tarefas { get; set; }
        //public List<Categoria> Categorias { get; set; }
        //public List<Despesa> Despesas { get; set; }

        private string caminho = $"C:\\temp\\eAgenda\\dados.json";

        public ContextoDados()
        {
            Clientes = new List<Cliente>();

            //Compromissos = new List<Compromisso>();

            //Tarefas = new List<Tarefa>();

            //Categorias = new List<Categoria>();

            //Despesas = new List<Despesa>();
        }

        public ContextoDados(bool carregarDados) : this()
        {
            if (carregarDados)
                CarregarDados();
        }

        public void Gravar()
        {
            FileInfo arquivo = new FileInfo(caminho);

            arquivo.Directory.Create();

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve
            };

            byte[] registrosEmBytes = JsonSerializer.SerializeToUtf8Bytes(this, options);

            File.WriteAllBytes(caminho, registrosEmBytes);
        }

        protected void CarregarDados()
        {
            FileInfo arquivo = new FileInfo(caminho);

            if (!arquivo.Exists)
                return;

            byte[] registrosEmBytes = File.ReadAllBytes(caminho);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };

            ContextoDados ctx = JsonSerializer.Deserialize<ContextoDados>(registrosEmBytes, options);

            if (ctx == null) return;

            Clientes = ctx.Clientes;

            //Compromissos = ctx.Compromissos;

            //Tarefas = ctx.Tarefas;

            //Categorias = ctx.Categorias;

            //Despesas = ctx.Despesas;
        }
    }
}