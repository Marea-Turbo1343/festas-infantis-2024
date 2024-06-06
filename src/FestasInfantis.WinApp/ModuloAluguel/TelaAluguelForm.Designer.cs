namespace FestasInfantis.WinApp.ModuloAluguel
{
    partial class TelaAluguelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtQtdEmp = new TextBox();
            lblQtdEmprestimos = new Label();
            lblDescontoCliente = new Label();
            txtDescontoMax = new TextBox();
            label1 = new Label();
            txtDescontoMin = new TextBox();
            labelDesconto = new Label();
            txtDescontoCliente = new TextBox();
            lblHoraTermino = new Label();
            lblHoraInicial = new Label();
            txtHoraTermino = new DateTimePicker();
            txtHoraInicial = new DateTimePicker();
            txtPreco = new TextBox();
            lblValorFinal = new Label();
            txtTema = new ComboBox();
            lblTema = new Label();
            txtPagamento = new ComboBox();
            lblFormapgto = new Label();
            txtEndereco = new TextBox();
            labelEndereco = new Label();
            txtEntrada = new ComboBox();
            txtData = new DateTimePicker();
            txtCliente = new ComboBox();
            lblEntrada = new Label();
            lblData = new Label();
            lblCliente = new Label();
            groupAlugueis = new GroupBox();
            listItemsAlugueis = new ListBox();
            lblId = new Label();
            txtId = new TextBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            groupAlugueis.SuspendLayout();
            SuspendLayout();
            // 
            // txtQtdEmp
            // 
            txtQtdEmp.Location = new Point(175, 129);
            txtQtdEmp.Margin = new Padding(3, 2, 3, 2);
            txtQtdEmp.Name = "txtQtdEmp";
            txtQtdEmp.ReadOnly = true;
            txtQtdEmp.Size = new Size(49, 23);
            txtQtdEmp.TabIndex = 70;
            txtQtdEmp.TabStop = false;
            // 
            // lblQtdEmprestimos
            // 
            lblQtdEmprestimos.AutoSize = true;
            lblQtdEmprestimos.Location = new Point(9, 132);
            lblQtdEmprestimos.Name = "lblQtdEmprestimos";
            lblQtdEmprestimos.Size = new Size(160, 15);
            lblQtdEmprestimos.TabIndex = 69;
            lblQtdEmprestimos.Text = "Quantidade de empréstimos:";
            // 
            // lblDescontoCliente
            // 
            lblDescontoCliente.AutoSize = true;
            lblDescontoCliente.Location = new Point(26, 159);
            lblDescontoCliente.Name = "lblDescontoCliente";
            lblDescontoCliente.Size = new Size(143, 15);
            lblDescontoCliente.TabIndex = 68;
            lblDescontoCliente.Text = "Desconto disponibilizado:";
            // 
            // txtDescontoMax
            // 
            txtDescontoMax.Location = new Point(421, 322);
            txtDescontoMax.Margin = new Padding(3, 2, 3, 2);
            txtDescontoMax.Name = "txtDescontoMax";
            txtDescontoMax.ReadOnly = true;
            txtDescontoMax.Size = new Size(70, 23);
            txtDescontoMax.TabIndex = 66;
            txtDescontoMax.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 325);
            label1.Name = "label1";
            label1.Size = new Size(164, 15);
            label1.TabIndex = 67;
            label1.Text = "Desconto máximo disponível:";
            // 
            // txtDescontoMin
            // 
            txtDescontoMin.Location = new Point(175, 322);
            txtDescontoMin.Margin = new Padding(3, 2, 3, 2);
            txtDescontoMin.Name = "txtDescontoMin";
            txtDescontoMin.ReadOnly = true;
            txtDescontoMin.Size = new Size(70, 23);
            txtDescontoMin.TabIndex = 65;
            txtDescontoMin.TabStop = false;
            // 
            // labelDesconto
            // 
            labelDesconto.AutoSize = true;
            labelDesconto.Location = new Point(7, 325);
            labelDesconto.Name = "labelDesconto";
            labelDesconto.Size = new Size(162, 15);
            labelDesconto.TabIndex = 64;
            labelDesconto.Text = "Desconto mínimo disponível:";
            // 
            // txtDescontoCliente
            // 
            txtDescontoCliente.Location = new Point(175, 156);
            txtDescontoCliente.Margin = new Padding(3, 2, 3, 2);
            txtDescontoCliente.Name = "txtDescontoCliente";
            txtDescontoCliente.ReadOnly = true;
            txtDescontoCliente.Size = new Size(49, 23);
            txtDescontoCliente.TabIndex = 63;
            txtDescontoCliente.TabStop = false;
            // 
            // lblHoraTermino
            // 
            lblHoraTermino.AutoSize = true;
            lblHoraTermino.Location = new Point(58, 273);
            lblHoraTermino.Name = "lblHoraTermino";
            lblHoraTermino.Size = new Size(111, 15);
            lblHoraTermino.TabIndex = 62;
            lblHoraTermino.Text = "Horário de término:";
            // 
            // lblHoraInicial
            // 
            lblHoraInicial.AutoSize = true;
            lblHoraInicial.Location = new Point(71, 244);
            lblHoraInicial.Name = "lblHoraInicial";
            lblHoraInicial.Size = new Size(98, 15);
            lblHoraInicial.TabIndex = 61;
            lblHoraInicial.Text = "Horário de início:";
            // 
            // txtHoraTermino
            // 
            txtHoraTermino.CustomFormat = "HH:mm";
            txtHoraTermino.Format = DateTimePickerFormat.Custom;
            txtHoraTermino.Location = new Point(175, 267);
            txtHoraTermino.Name = "txtHoraTermino";
            txtHoraTermino.ShowUpDown = true;
            txtHoraTermino.Size = new Size(49, 23);
            txtHoraTermino.TabIndex = 47;
            // 
            // txtHoraInicial
            // 
            txtHoraInicial.CustomFormat = "HH:mm";
            txtHoraInicial.Format = DateTimePickerFormat.Custom;
            txtHoraInicial.Location = new Point(175, 238);
            txtHoraInicial.Name = "txtHoraInicial";
            txtHoraInicial.ShowUpDown = true;
            txtHoraInicial.Size = new Size(49, 23);
            txtHoraInicial.TabIndex = 46;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(175, 349);
            txtPreco.Margin = new Padding(3, 2, 3, 2);
            txtPreco.Name = "txtPreco";
            txtPreco.ReadOnly = true;
            txtPreco.Size = new Size(260, 23);
            txtPreco.TabIndex = 53;
            txtPreco.TabStop = false;
            // 
            // lblValorFinal
            // 
            lblValorFinal.AutoSize = true;
            lblValorFinal.Location = new Point(89, 352);
            lblValorFinal.Name = "lblValorFinal";
            lblValorFinal.Size = new Size(80, 15);
            lblValorFinal.TabIndex = 58;
            lblValorFinal.Text = "Valor Total R$:";
            // 
            // txtTema
            // 
            txtTema.FormattingEnabled = true;
            txtTema.Location = new Point(175, 75);
            txtTema.Margin = new Padding(3, 2, 3, 2);
            txtTema.Name = "txtTema";
            txtTema.Size = new Size(260, 23);
            txtTema.TabIndex = 42;
            // 
            // lblTema
            // 
            lblTema.AutoSize = true;
            lblTema.Location = new Point(131, 78);
            lblTema.Name = "lblTema";
            lblTema.Size = new Size(38, 15);
            lblTema.TabIndex = 54;
            lblTema.Text = "Tema:";
            // 
            // txtPagamento
            // 
            txtPagamento.FormattingEnabled = true;
            txtPagamento.Location = new Point(175, 295);
            txtPagamento.Margin = new Padding(3, 2, 3, 2);
            txtPagamento.Name = "txtPagamento";
            txtPagamento.Size = new Size(142, 23);
            txtPagamento.TabIndex = 50;
            // 
            // lblFormapgto
            // 
            lblFormapgto.AutoSize = true;
            lblFormapgto.Location = new Point(45, 301);
            lblFormapgto.Name = "lblFormapgto";
            lblFormapgto.Size = new Size(124, 15);
            lblFormapgto.TabIndex = 51;
            lblFormapgto.Text = "Forma de pagamento:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(175, 183);
            txtEndereco.Margin = new Padding(3, 2, 3, 2);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(260, 23);
            txtEndereco.TabIndex = 52;
            // 
            // labelEndereco
            // 
            labelEndereco.AutoSize = true;
            labelEndereco.Location = new Point(64, 186);
            labelEndereco.Name = "labelEndereco";
            labelEndereco.Size = new Size(105, 15);
            labelEndereco.TabIndex = 49;
            labelEndereco.Text = "Endereço da Festa:";
            // 
            // txtEntrada
            // 
            txtEntrada.FormattingEnabled = true;
            txtEntrada.Location = new Point(175, 102);
            txtEntrada.Margin = new Padding(3, 2, 3, 2);
            txtEntrada.Name = "txtEntrada";
            txtEntrada.Size = new Size(79, 23);
            txtEntrada.TabIndex = 48;
            // 
            // txtData
            // 
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(175, 210);
            txtData.Margin = new Padding(3, 2, 3, 2);
            txtData.Name = "txtData";
            txtData.Size = new Size(95, 23);
            txtData.TabIndex = 45;
            // 
            // txtCliente
            // 
            txtCliente.FormattingEnabled = true;
            txtCliente.Location = new Point(175, 44);
            txtCliente.Margin = new Padding(3, 2, 3, 2);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(260, 23);
            txtCliente.TabIndex = 44;
            // 
            // lblEntrada
            // 
            lblEntrada.AutoSize = true;
            lblEntrada.Location = new Point(29, 105);
            lblEntrada.Name = "lblEntrada";
            lblEntrada.Size = new Size(140, 15);
            lblEntrada.TabIndex = 43;
            lblEntrada.Text = "Porcentagem de entrada:";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(89, 216);
            lblData.Name = "lblData";
            lblData.Size = new Size(80, 15);
            lblData.TabIndex = 41;
            lblData.Text = "Data da Festa:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(122, 47);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 40;
            lblCliente.Text = "Cliente:";
            // 
            // groupAlugueis
            // 
            groupAlugueis.Controls.Add(listItemsAlugueis);
            groupAlugueis.Controls.Add(lblId);
            groupAlugueis.Controls.Add(txtId);
            groupAlugueis.Controls.Add(txtPreco);
            groupAlugueis.Controls.Add(txtDescontoMax);
            groupAlugueis.Controls.Add(lblValorFinal);
            groupAlugueis.Controls.Add(txtQtdEmp);
            groupAlugueis.Controls.Add(label1);
            groupAlugueis.Controls.Add(lblCliente);
            groupAlugueis.Controls.Add(txtDescontoMin);
            groupAlugueis.Controls.Add(lblQtdEmprestimos);
            groupAlugueis.Controls.Add(labelDesconto);
            groupAlugueis.Controls.Add(txtCliente);
            groupAlugueis.Controls.Add(lblHoraTermino);
            groupAlugueis.Controls.Add(lblDescontoCliente);
            groupAlugueis.Controls.Add(lblHoraInicial);
            groupAlugueis.Controls.Add(txtPagamento);
            groupAlugueis.Controls.Add(txtTema);
            groupAlugueis.Controls.Add(lblFormapgto);
            groupAlugueis.Controls.Add(txtHoraTermino);
            groupAlugueis.Controls.Add(txtEndereco);
            groupAlugueis.Controls.Add(labelEndereco);
            groupAlugueis.Controls.Add(lblTema);
            groupAlugueis.Controls.Add(txtHoraInicial);
            groupAlugueis.Controls.Add(txtEntrada);
            groupAlugueis.Controls.Add(lblEntrada);
            groupAlugueis.Controls.Add(txtDescontoCliente);
            groupAlugueis.Controls.Add(lblData);
            groupAlugueis.Controls.Add(txtData);
            groupAlugueis.Location = new Point(12, 11);
            groupAlugueis.Margin = new Padding(3, 2, 3, 2);
            groupAlugueis.Name = "groupAlugueis";
            groupAlugueis.Padding = new Padding(3, 2, 3, 2);
            groupAlugueis.Size = new Size(525, 521);
            groupAlugueis.TabIndex = 73;
            groupAlugueis.TabStop = false;
            groupAlugueis.Text = "Aluguéis";
            // 
            // listItemsAlugueis
            // 
            listItemsAlugueis.FormattingEnabled = true;
            listItemsAlugueis.ItemHeight = 15;
            listItemsAlugueis.Location = new Point(6, 376);
            listItemsAlugueis.Margin = new Padding(3, 2, 3, 2);
            listItemsAlugueis.Name = "listItemsAlugueis";
            listItemsAlugueis.Size = new Size(513, 139);
            listItemsAlugueis.TabIndex = 35;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(149, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 26;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(175, 17);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(79, 23);
            txtId.TabIndex = 25;
            txtId.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(462, 537);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 35);
            btnCancelar.TabIndex = 72;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(381, 537);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 35);
            btnSalvar.TabIndex = 71;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 581);
            Controls.Add(groupAlugueis);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaAluguelForm";
            ShowIcon = false;
            Text = "Cadastrar Aluguel";
            groupAlugueis.ResumeLayout(false);
            groupAlugueis.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtQtdEmp;
        private Label lblQtdEmprestimos;
        private Label lblDescontoCliente;
        private TextBox txtDescontoMax;
        private Label label1;
        private TextBox txtDescontoMin;
        private Label labelDesconto;
        private TextBox txtDescontoCliente;
        private Label lblHoraTermino;
        private Label lblHoraInicial;
        private DateTimePicker txtHoraTermino;
        private DateTimePicker txtHoraInicial;
        private TextBox txtPreco;
        private Label lblValorFinal;
        private ComboBox txtTema;
        private Label lblTema;
        private ComboBox txtPagamento;
        private Label lblFormapgto;
        private TextBox txtEndereco;
        private Label labelEndereco;
        private ComboBox txtEntrada;
        private DateTimePicker txtData;
        private ComboBox txtCliente;
        private Label lblEntrada;
        private Label lblData;
        private Label lblCliente;
        private GroupBox groupAlugueis;
        private ListBox listItemsAlugueis;
        private Label lblId;
        private TextBox txtId;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}