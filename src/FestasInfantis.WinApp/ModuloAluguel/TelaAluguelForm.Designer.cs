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
            lblHoraTermino = new Label();
            lblHoraInicio = new Label();
            txtHoraTermino = new DateTimePicker();
            txtHoraInicio = new DateTimePicker();
            txtValorTotal = new TextBox();
            lblValorTotal = new Label();
            cmbTema = new ComboBox();
            lblTema = new Label();
            lblEndereco = new Label();
            cmbEntrada = new ComboBox();
            txtDataFesta = new DateTimePicker();
            cmbCliente = new ComboBox();
            lblEntrada = new Label();
            lblDataFesta = new Label();
            lblCliente = new Label();
            gpAlugueis = new GroupBox();
            listItensAluguel = new ListBox();
            lblId = new Label();
            txtId = new TextBox();
            txtDescDisp = new TextBox();
            lblDescDisp = new Label();
            txtEndereco = new TextBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            lblValorPagar = new Label();
            txtValorPagar = new TextBox();
            gpAlugueis.SuspendLayout();
            SuspendLayout();
            // 
            // txtQtdEmp
            // 
            txtQtdEmp.Location = new Point(175, 125);
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
            lblQtdEmprestimos.Location = new Point(9, 128);
            lblQtdEmprestimos.Name = "lblQtdEmprestimos";
            lblQtdEmprestimos.Size = new Size(160, 15);
            lblQtdEmprestimos.TabIndex = 69;
            lblQtdEmprestimos.Text = "Quantidade de empréstimos:";
            // 
            // lblHoraTermino
            // 
            lblHoraTermino.AutoSize = true;
            lblHoraTermino.Location = new Point(58, 269);
            lblHoraTermino.Name = "lblHoraTermino";
            lblHoraTermino.Size = new Size(111, 15);
            lblHoraTermino.TabIndex = 62;
            lblHoraTermino.Text = "Horário de término:";
            // 
            // lblHoraInicio
            // 
            lblHoraInicio.AutoSize = true;
            lblHoraInicio.Location = new Point(71, 240);
            lblHoraInicio.Name = "lblHoraInicio";
            lblHoraInicio.Size = new Size(98, 15);
            lblHoraInicio.TabIndex = 61;
            lblHoraInicio.Text = "Horário de início:";
            // 
            // txtHoraTermino
            // 
            txtHoraTermino.CustomFormat = "HH:mm";
            txtHoraTermino.Format = DateTimePickerFormat.Custom;
            txtHoraTermino.Location = new Point(175, 263);
            txtHoraTermino.Name = "txtHoraTermino";
            txtHoraTermino.ShowUpDown = true;
            txtHoraTermino.Size = new Size(49, 23);
            txtHoraTermino.TabIndex = 47;
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.CustomFormat = "HH:mm";
            txtHoraInicio.Format = DateTimePickerFormat.Custom;
            txtHoraInicio.Location = new Point(175, 234);
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.ShowUpDown = true;
            txtHoraInicio.Size = new Size(49, 23);
            txtHoraInicio.TabIndex = 46;
            // 
            // txtValorTotal
            // 
            txtValorTotal.Location = new Point(175, 291);
            txtValorTotal.Margin = new Padding(3, 2, 3, 2);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.ReadOnly = true;
            txtValorTotal.Size = new Size(95, 23);
            txtValorTotal.TabIndex = 53;
            txtValorTotal.TabStop = false;
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Location = new Point(89, 294);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(80, 15);
            lblValorTotal.TabIndex = 58;
            lblValorTotal.Text = "Valor Total R$:";
            // 
            // cmbTema
            // 
            cmbTema.FormattingEnabled = true;
            cmbTema.Location = new Point(175, 71);
            cmbTema.Margin = new Padding(3, 2, 3, 2);
            cmbTema.Name = "cmbTema";
            cmbTema.Size = new Size(260, 23);
            cmbTema.TabIndex = 42;
            // 
            // lblTema
            // 
            lblTema.AutoSize = true;
            lblTema.Location = new Point(131, 74);
            lblTema.Name = "lblTema";
            lblTema.Size = new Size(38, 15);
            lblTema.TabIndex = 54;
            lblTema.Text = "Tema:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(64, 182);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(105, 15);
            lblEndereco.TabIndex = 49;
            lblEndereco.Text = "Endereço da Festa:";
            // 
            // cmbEntrada
            // 
            cmbEntrada.FormattingEnabled = true;
            cmbEntrada.Location = new Point(175, 98);
            cmbEntrada.Margin = new Padding(3, 2, 3, 2);
            cmbEntrada.Name = "cmbEntrada";
            cmbEntrada.Size = new Size(79, 23);
            cmbEntrada.TabIndex = 48;
            // 
            // txtDataFesta
            // 
            txtDataFesta.Format = DateTimePickerFormat.Short;
            txtDataFesta.Location = new Point(175, 206);
            txtDataFesta.Margin = new Padding(3, 2, 3, 2);
            txtDataFesta.Name = "txtDataFesta";
            txtDataFesta.Size = new Size(95, 23);
            txtDataFesta.TabIndex = 45;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(175, 44);
            cmbCliente.Margin = new Padding(3, 2, 3, 2);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(260, 23);
            cmbCliente.TabIndex = 44;
            // 
            // lblEntrada
            // 
            lblEntrada.AutoSize = true;
            lblEntrada.Location = new Point(29, 101);
            lblEntrada.Name = "lblEntrada";
            lblEntrada.Size = new Size(140, 15);
            lblEntrada.TabIndex = 43;
            lblEntrada.Text = "Porcentagem de entrada:";
            // 
            // lblDataFesta
            // 
            lblDataFesta.AutoSize = true;
            lblDataFesta.Location = new Point(89, 212);
            lblDataFesta.Name = "lblDataFesta";
            lblDataFesta.Size = new Size(80, 15);
            lblDataFesta.TabIndex = 41;
            lblDataFesta.Text = "Data da Festa:";
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
            // gpAlugueis
            // 
            gpAlugueis.Controls.Add(listItensAluguel);
            gpAlugueis.Controls.Add(lblId);
            gpAlugueis.Controls.Add(txtId);
            gpAlugueis.Controls.Add(txtValorPagar);
            gpAlugueis.Controls.Add(lblValorPagar);
            gpAlugueis.Controls.Add(txtValorTotal);
            gpAlugueis.Controls.Add(lblValorTotal);
            gpAlugueis.Controls.Add(txtDescDisp);
            gpAlugueis.Controls.Add(txtQtdEmp);
            gpAlugueis.Controls.Add(lblDescDisp);
            gpAlugueis.Controls.Add(lblCliente);
            gpAlugueis.Controls.Add(lblQtdEmprestimos);
            gpAlugueis.Controls.Add(cmbCliente);
            gpAlugueis.Controls.Add(lblHoraTermino);
            gpAlugueis.Controls.Add(lblHoraInicio);
            gpAlugueis.Controls.Add(cmbTema);
            gpAlugueis.Controls.Add(txtHoraTermino);
            gpAlugueis.Controls.Add(txtEndereco);
            gpAlugueis.Controls.Add(lblEndereco);
            gpAlugueis.Controls.Add(lblTema);
            gpAlugueis.Controls.Add(txtHoraInicio);
            gpAlugueis.Controls.Add(cmbEntrada);
            gpAlugueis.Controls.Add(lblEntrada);
            gpAlugueis.Controls.Add(lblDataFesta);
            gpAlugueis.Controls.Add(txtDataFesta);
            gpAlugueis.Location = new Point(12, 11);
            gpAlugueis.Margin = new Padding(3, 2, 3, 2);
            gpAlugueis.Name = "gpAlugueis";
            gpAlugueis.Padding = new Padding(3, 2, 3, 2);
            gpAlugueis.Size = new Size(525, 505);
            gpAlugueis.TabIndex = 73;
            gpAlugueis.TabStop = false;
            gpAlugueis.Text = "Aluguéis";
            // 
            // listItensAluguel
            // 
            listItensAluguel.FormattingEnabled = true;
            listItensAluguel.ItemHeight = 15;
            listItensAluguel.Location = new Point(6, 345);
            listItensAluguel.Margin = new Padding(3, 2, 3, 2);
            listItensAluguel.Name = "listItensAluguel";
            listItensAluguel.Size = new Size(513, 154);
            listItensAluguel.TabIndex = 35;
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
            // txtDescDisp
            // 
            txtDescDisp.Location = new Point(175, 152);
            txtDescDisp.Margin = new Padding(3, 2, 3, 2);
            txtDescDisp.Name = "txtDescDisp";
            txtDescDisp.ReadOnly = true;
            txtDescDisp.Size = new Size(49, 23);
            txtDescDisp.TabIndex = 70;
            txtDescDisp.TabStop = false;
            // 
            // lblDescDisp
            // 
            lblDescDisp.AutoSize = true;
            lblDescDisp.Location = new Point(52, 155);
            lblDescDisp.Name = "lblDescDisp";
            lblDescDisp.Size = new Size(117, 15);
            lblDescDisp.TabIndex = 69;
            lblDescDisp.Text = "Desconto disponível:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(175, 179);
            txtEndereco.Margin = new Padding(3, 2, 3, 2);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(260, 23);
            txtEndereco.TabIndex = 52;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(462, 521);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 35);
            btnCancelar.TabIndex = 75;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(381, 521);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 35);
            btnSalvar.TabIndex = 74;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblValorPagar
            // 
            lblValorPagar.AutoSize = true;
            lblValorPagar.Location = new Point(75, 321);
            lblValorPagar.Name = "lblValorPagar";
            lblValorPagar.Size = new Size(94, 15);
            lblValorPagar.TabIndex = 58;
            lblValorPagar.Text = "Valor a pagar R$:";
            // 
            // txtValorPagar
            // 
            txtValorPagar.Location = new Point(175, 318);
            txtValorPagar.Margin = new Padding(3, 2, 3, 2);
            txtValorPagar.Name = "txtValorPagar";
            txtValorPagar.ReadOnly = true;
            txtValorPagar.Size = new Size(95, 23);
            txtValorPagar.TabIndex = 53;
            txtValorPagar.TabStop = false;
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 565);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(gpAlugueis);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaAluguelForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Aluguel";
            gpAlugueis.ResumeLayout(false);
            gpAlugueis.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtQtdEmp;
        private Label lblQtdEmprestimos;
        private Label lblDescontoDisponivel;
        private TextBox txtDescontoDisponivel;
        private TextBox txtDescDisp;
        private Label lblDescDisp;
        private Label lblHoraTermino;
        private Label lblHoraInicio;
        private DateTimePicker txtHoraTermino;
        private DateTimePicker txtHoraInicio;
        private TextBox txtValorTotal;
        private Label lblValorTotal;
        private ComboBox cmbTema;
        private Label lblTema;
        private Label lblEndereco;
        private ComboBox cmbEntrada;
        private DateTimePicker txtDataFesta;
        private ComboBox cmbCliente;
        private Label lblEntrada;
        private Label lblDataFesta;
        private Label lblCliente;
        private GroupBox gpAlugueis;
        private ListBox listItensAluguel;
        private Label lblId;
        private TextBox txtId;
        private Button btnCancelar;
        private Button btnSalvar;
        private TextBox txtEndereco;
        private TextBox txtValorPagar;
        private Label lblValorPagar;
    }
}