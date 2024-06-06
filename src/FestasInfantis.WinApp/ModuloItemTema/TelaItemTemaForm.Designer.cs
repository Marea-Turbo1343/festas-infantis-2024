namespace FestasInfantis.WinApp.ModuloItemTema
{
    partial class TelaItemTemaForm
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
            groupTemas = new GroupBox();
            lblAtivo = new Label();
            txtId = new TextBox();
            lblId = new Label();
            txtPreco = new NumericUpDown();
            txtTitulo = new TextBox();
            chkAtivo = new CheckBox();
            lblPreco = new Label();
            lblTitulo = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            groupTemas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPreco).BeginInit();
            SuspendLayout();
            // 
            // groupTemas
            // 
            groupTemas.Controls.Add(lblAtivo);
            groupTemas.Controls.Add(txtId);
            groupTemas.Controls.Add(lblId);
            groupTemas.Controls.Add(txtPreco);
            groupTemas.Controls.Add(txtTitulo);
            groupTemas.Controls.Add(chkAtivo);
            groupTemas.Controls.Add(lblPreco);
            groupTemas.Controls.Add(lblTitulo);
            groupTemas.Location = new Point(12, 11);
            groupTemas.Margin = new Padding(3, 2, 3, 2);
            groupTemas.Name = "groupTemas";
            groupTemas.Padding = new Padding(3, 2, 3, 2);
            groupTemas.Size = new Size(240, 128);
            groupTemas.TabIndex = 6;
            groupTemas.TabStop = false;
            groupTemas.Text = "Temas";
            // 
            // lblAtivo
            // 
            lblAtivo.AutoSize = true;
            lblAtivo.Location = new Point(18, 100);
            lblAtivo.Name = "lblAtivo";
            lblAtivo.Size = new Size(38, 15);
            lblAtivo.TabIndex = 19;
            lblAtivo.Text = "Ativo:";
            // 
            // txtId
            // 
            txtId.Location = new Point(62, 20);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(60, 23);
            txtId.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(36, 23);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 17;
            lblId.Text = "Id:";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(62, 74);
            txtPreco.Margin = new Padding(3, 2, 3, 2);
            txtPreco.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(72, 23);
            txtPreco.TabIndex = 2;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(62, 47);
            txtTitulo.Margin = new Padding(3, 2, 3, 2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(166, 23);
            txtTitulo.TabIndex = 1;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(62, 101);
            chkAtivo.Margin = new Padding(3, 2, 3, 2);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(15, 14);
            chkAtivo.TabIndex = 3;
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(16, 76);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(40, 15);
            lblPreco.TabIndex = 11;
            lblPreco.Text = "Preço:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(16, 50);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(40, 15);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "Titulo:";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(177, 144);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 35);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(96, 144);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 35);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // TelaItemTemaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 187);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(groupTemas);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaItemTemaForm";
            ShowIcon = false;
            Text = "Cadastro de Item";
            groupTemas.ResumeLayout(false);
            groupTemas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPreco).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupTemas;
        private Button btnCancelar;
        private Button btnSalvar;
        private TextBox txtId;
        private Label lblId;
        private NumericUpDown txtPreco;
        private TextBox txtTitulo;
        private CheckBox chkAtivo;
        private Label lblPreco;
        private Label lblTitulo;
        private Label lblAtivo;
    }
}