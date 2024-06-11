using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel;
using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase, IControladorAdicionarItens
    {
        private IRepositorioTema repositorioTema;
        private IRepositorioItem repositorioItens;
        private IRepositorioAluguel repositorioAluguel;
        private TabelaTemaControl tabelaTema;

        public ControladorTema(IRepositorioTema repositorioTema, IRepositorioItem repositorioItens, IRepositorioAluguel repositorioAluguel)
        {
            this.repositorioTema = repositorioTema;
            this.repositorioItens = repositorioItens;
            this.repositorioAluguel = repositorioAluguel;
        }

        public override string TipoCadastro { get { return "Temas"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo tema"; } }

        public override string ToolTipEditar { get { return "Editar um tema existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um tema existente"; } }

        public string ToolTipAdicionarItens => "Adicionar Itens no Tema";

        private void VisualizarDetalhesTema(int id)
        {
            int idSelecionado = tabelaTema.ObterRegistroSelecionado();
            Tema temaSelecionado = repositorioTema.SelecionarPorId(idSelecionado);

            var telaVisualizarDetalhesTema = new TelaVerTemaForm(temaSelecionado);
            telaVisualizarDetalhesTema.ShowDialog();
        }

        public void AtualizarListagem()
        {
            List<Tema> temas = repositorioTema.SelecionarTodos();

            tabelaTema?.AtualizarRegistros(temas);

            TelaPrincipalForm.Instancia?.AtualizarRodape(ObterTextoRodape(temas));
        }

        private static string ObterTextoRodape(List<Tema> temas)
        {
            if (temas.Count == 0)
                return "Nenhum tema cadastrado até o momento!";
            else if (temas.Count == 1)
                return "Exibindo 1 tema";

            return $"Exibindo {temas.Count} temas.";
        }

        public void VisualizarTemaSelecionado()
        {
            int idSelecionado = tabelaTema.ObterRegistroSelecionado();

            Tema temaSelecionado = repositorioTema.SelecionarPorId(idSelecionado);

            TelaVerTemaForm telaVerTema = new TelaVerTemaForm(temaSelecionado);
            telaVerTema.ShowDialog();
        }

        public override void Adicionar()
        {
            TelaTemaForm telaTema = new(repositorioItens.SelecionarTodos(), repositorioTema, repositorioAluguel);

            DialogResult resultado = telaTema.ShowDialog();

            if (resultado != DialogResult.OK)   
                return;

            Tema novoTema = telaTema.Tema;

            if (repositorioTema.SelecionarTodos().Any(t => t.Nome == novoTema.Nome))
            {
                MessageBox.Show("O tema informado já está cadastrado", "Tema já cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Item item in novoTema.Itens)
                {
                    foreach (Tema tema in repositorioTema.SelecionarTodos())
                    {
                        if (tema.Itens.Contains(item))
                        {
                            MessageBox.Show($"O item {item.Descricao} já está vinculado ao tema {tema.Nome}", "Item já vinculado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                repositorioTema.Cadastrar(novoTema);

                TelaPrincipalForm.Instancia.Temporizador($"O registro \"{novoTema.Nome}\" foi criado com sucesso!");
            }
        }

        public override void Editar()
        {
            int idSelecionado = tabelaTema.ObterRegistroSelecionado();

            Tema temaSelecionado = repositorioTema.SelecionarPorId(idSelecionado);

            if (temaSelecionado == null)
            {
                MessageBox.Show("Não é possível realizar esta ação sem um registro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (repositorioAluguel.SelecionarTodos().Any(a => a.Tema.Id == temaSelecionado.Id && a.PagamentoConcluido == false))
            {
                MessageBox.Show("Não é possível editar um tema que está vinculado a um aluguel não finalizado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Item> itens = repositorioItens.SelecionarTodos();

            TelaTemaForm telaTema = new TelaTemaForm(repositorioItens.SelecionarTodos(), repositorioTema, repositorioAluguel, true);
            telaTema.Tema = temaSelecionado;

            DialogResult resultado = telaTema.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Tema temaEditado = telaTema.Tema;

            repositorioTema.Editar(temaSelecionado.Id, temaEditado);

            CarregarTemas();

            TelaPrincipalForm.Instancia.Temporizador($"O registro \"{temaEditado.Nome}\" foi editado com sucesso!");
        }

        public void AdicionarItens()
        {
            int idSelecionado = tabelaTema.ObterRegistroSelecionado();
            Tema temaSelecionado = repositorioTema.SelecionarPorId(idSelecionado);

            if (temaSelecionado == null)
            {
                MessageBox.Show("Não é possível realizar esta ação sem um registro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (repositorioAluguel.SelecionarTodos().Any(a => a.Tema.Id == temaSelecionado.Id && a.PagamentoConcluido == false))
            {
                MessageBox.Show("Não é possível adicionar itens a um tema que está vinculado a um aluguel não finalizado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Item> itens = repositorioItens.SelecionarTodos();

            TelaAdicionarItensForm telaAdicionarItens = new TelaAdicionarItensForm(temaSelecionado, itens, repositorioTema, repositorioAluguel);

            DialogResult resultado = telaAdicionarItens.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            temaSelecionado = telaAdicionarItens.TemaAtualizado;

            repositorioTema.Editar(temaSelecionado.Id, temaSelecionado);

            CarregarTemas();

            TelaPrincipalForm.Instancia.Temporizador($"Itens foram adicionados ao registro \"{temaSelecionado.Nome}\" com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaTema.ObterRegistroSelecionado();

            Tema temaSelecionado = repositorioTema.SelecionarPorId(idSelecionado);

            if (temaSelecionado == null)
            {
                MessageBox.Show("Não é possível realizar esta ação sem um registro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (repositorioAluguel.SelecionarTodos().Any(a => a.Tema.Id == temaSelecionado.Id && a.PagamentoConcluido == false))
            {
                MessageBox.Show("Não é possível excluir um tema que está vinculado a um aluguel em andamento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (temaSelecionado.Itens.Count > 0)
            {
                MessageBox.Show("Não é possível excluir um tema que ainda tem itens vinculados. Remova todos os itens deste tema antes de excluí-lo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resposta = MessageBox.Show($"Você deseja realmente excluir o registro \"{temaSelecionado.Nome}\"?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes)
                return;

            repositorioTema.Excluir(temaSelecionado.Id);

            CarregarTemas();

            TelaPrincipalForm.Instancia.Temporizador($"O registro \"{temaSelecionado.Nome}\" foi excluído com sucesso!");
        }

        private void CarregarTemas()
        {
            List<Tema> temas = repositorioTema.SelecionarTodos();

            tabelaTema.AtualizarRegistros(temas);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaTema == null)
                tabelaTema = new TabelaTemaControl();

            CarregarTemas();

            AtualizarListagem();

            return tabelaTema;
        }
    }
}