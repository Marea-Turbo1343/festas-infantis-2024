﻿using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloItem;
using FestasInfantis.WinApp.ModuloTema;
using System.ComponentModel;
using System.Reflection;
using static FestasInfantis.WinApp.ModuloAluguel.Aluguel;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        private Aluguel aluguel;
        private IRepositorioAluguel repositorioAluguel;

        public Aluguel Aluguel
        {
            set
            {
                txtId.Text = value.Id.ToString();
                cmbCliente.SelectedItem = value.Cliente;
                cmbTema.SelectedItem = value.Tema;
                cmbEntrada.SelectedItem = value.Entrada;
                txtQtdEmp.Text = value.QuantidadeEmprestimos.ToString();
                txtEndereco.Text = value.EnderecoFesta;
                txtDataFesta.Value = value.DataFesta;
                txtHoraInicio.Value = value.HoraInicio;
                txtHoraTermino.Value = value.HoraTermino;
                txtDescDisp.Text = value.DescontoDisponibilizado.ToString();
                txtValorTotal.Text = value.ValorTotal.ToString();
            }
            get
            {
                return aluguel;
            }
        }

        public TelaAluguelForm(IRepositorioAluguel repositorioAluguel)
        {
            InitializeComponent();

            this.repositorioAluguel = repositorioAluguel;
            this.aluguel = new Aluguel();

            cmbEntrada.Items.Add(GetDescription(Aluguel.PorcentagemEntrada._40porcento));
            cmbEntrada.Items.Add(GetDescription(Aluguel.PorcentagemEntrada._50porcento));

            txtDataFesta.ValueChanged += txtDataFesta_ValueChanged;

            int proximoId = repositorioAluguel.ObterProximoId();
            txtId.Text = proximoId.ToString();

            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            cmbTema.SelectedIndexChanged += cmbTema_SelectedIndexChanged;

            txtHoraInicio.ValueChanged += txtHoraInicio_ValueChanged;
            txtHoraTermino.ValueChanged += txtHoraTermino_ValueChanged;

            cmbEntrada.SelectedIndexChanged += cmbEntrada_SelectedIndexChanged;
        }

        private void txtHoraInicio_ValueChanged(object sender, EventArgs e)
        {
            if (txtHoraInicio.Value > txtHoraTermino.Value)
            {
                MessageBox.Show("O horário de início não pode ser posterior ao horário de término.", "Horário inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoraInicio.Value = txtHoraTermino.Value.AddHours(-1);
            }
        }

        private void txtHoraTermino_ValueChanged(object sender, EventArgs e)
        {
            if (txtHoraTermino.Value < txtHoraInicio.Value)
            {
                MessageBox.Show("O horário de término não pode ser anterior ao horário de início.", "Horário inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoraTermino.Value = txtHoraInicio.Value.AddHours(1);
            }
        }

        private string GetDescription(Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());

            return Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is not DescriptionAttribute attribute ? value.ToString() : attribute.Description;
        }

        private void AtualizarValores()
        {
            if (aluguel.Cliente != null && aluguel.Tema != null)
            {
                decimal valorTotal = aluguel.CalcularValorTotal();
                txtValorTotal.Text = valorTotal.ToString();

                decimal valorEntrada = valorTotal * (decimal)aluguel.Entrada / 100;

                decimal valorAPagar = valorTotal - valorEntrada;
                txtValorPagar.Text = valorAPagar.ToString();
            }
            else
            {
                txtValorTotal.Text = "0";
                txtValorPagar.Text = "0";
            }
        }

        private void cmbEntrada_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedItem != null && aluguel.Cliente != null && cmbTema.SelectedItem != null)
            {
                decimal valorTotal = aluguel.CalcularValorTotal();
                txtValorTotal.Text = valorTotal.ToString();

                decimal valorEntrada = valorTotal * (decimal)aluguel.Entrada / 100;

                decimal valorAPagar = valorTotal - valorEntrada;
                txtValorPagar.Text = valorAPagar.ToString();
            }
            AtualizarValores();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)cmbCliente.SelectedItem;

            txtQtdEmp.Text = clienteSelecionado.ContadorDeAlugueis.ToString();

            ConfiguracaoDesconto configuracaoDesconto = new ConfiguracaoDesconto(true);
            decimal descontoDisponibilizado = configuracaoDesconto.CalcularDesconto(clienteSelecionado.ContadorDeAlugueis);
            txtDescDisp.Text = descontoDisponibilizado.ToString();

            aluguel.Cliente = clienteSelecionado;

            if (cmbTema.SelectedItem != null)
            {
                decimal valorTotal = aluguel.CalcularValorTotal();
                txtValorTotal.Text = valorTotal.ToString();

                decimal valorEntrada = valorTotal * (decimal)aluguel.Entrada / 100;

                decimal valorAPagar = valorTotal - valorEntrada;
                txtValorPagar.Text = valorAPagar.ToString();
            }
            else
            {
                txtValorTotal.Text = "0";
                txtValorPagar.Text = "0";
            }
            AtualizarValores();
        }

        private void cmbTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tema temaSelecionado = (Tema)cmbTema.SelectedItem;

            if (temaSelecionado.Itens.Count == 0)
            {
                MessageBox.Show("Este Tema não contém itens, por favor escolha outro tema.", "Tema sem itens", MessageBoxButtons.OK, MessageBoxIcon.Error);
                aluguel.Tema = temaSelecionado;
                return;
            }

            decimal valorTotal;
            if (cmbCliente.SelectedItem != null && aluguel.Cliente != null)
            {
                valorTotal = aluguel.CalcularValorTotal();
            }
            else
            {
                valorTotal = temaSelecionado.ValorTotal;
            }
            txtValorTotal.Text = valorTotal.ToString();

            listItensAluguel.Items.Clear();
            foreach (Item item in temaSelecionado.Itens)
            {
                listItensAluguel.Items.Add(item);
            }

            aluguel.Tema = temaSelecionado;
            AtualizarValores();
        }


        private void txtDataFesta_ValueChanged(object sender, EventArgs e)
        {
            if (txtDataFesta.Value.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("A data da festa deve ser de amanhã em diante.", "Data da festa inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataFesta.Value = DateTime.Now.Date.AddDays(1);
            }
        }

        public void CarregarClientes(List<Cliente> clientes)
        {
            cmbCliente.Items.Clear();

            foreach (Cliente c in clientes)
                cmbCliente.Items.Add(c);
        }

        public void CarregarTemas(List<Tema> temas)
        {
            cmbTema.Items.Clear();

            foreach (Tema t in temas)
                cmbTema.Items.Add(t);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)cmbCliente.SelectedItem;
            Tema tema = (Tema)cmbTema.SelectedItem;

            PorcentagemEntrada porcentagemEntrada = (PorcentagemEntrada)Enum.Parse(typeof(PorcentagemEntrada), cmbEntrada.SelectedItem.ToString());

            int quantidadeEmprestimos = int.Parse(txtQtdEmp.Text);
            string enderecoFesta = txtEndereco.Text;
            DateTime dataFesta = txtDataFesta.Value;
            DateTime horaInicio = txtHoraInicio.Value;
            DateTime horaTermino = txtHoraTermino.Value;
            decimal descontoTotal = decimal.Parse(txtDescDisp.Text);
            decimal valorTotal = decimal.Parse(txtValorTotal.Text);

            ConfiguracaoDesconto configuracaoDesconto = new ConfiguracaoDesconto(true);
            decimal descontoDisponibilizado = configuracaoDesconto.CalcularDesconto(quantidadeEmprestimos);

            valorTotal -= descontoDisponibilizado;

            aluguel = new Aluguel(cliente, tema, porcentagemEntrada, quantidadeEmprestimos, descontoDisponibilizado, enderecoFesta, dataFesta, horaInicio, horaTermino, valorTotal, tema.Itens);
        }
    }
}