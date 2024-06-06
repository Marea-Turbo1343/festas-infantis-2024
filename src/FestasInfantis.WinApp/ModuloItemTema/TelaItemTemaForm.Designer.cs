namespace FestasInfantis.WinApp.ModuloItem
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
            groupTemas.Size = new Size(240, 157);
            groupTemas.TabIndex = 6;
            groupTemas.TabStop = false;
            groupTemas.Text = "Temas";
            // 
            // lblAtivo
            // 
            lblAtivo.AutoSize = true;
            lblAtivo.Location = new Point(17, 133);
            lblAtivo.Name = "lblAtivo";
            lblAtivo.Size = new Size(38, 15);
            lblAtivo.TabIndex = 19;
            lblAtivo.Text = "Ativo:";
            // 
            // txtId
            // 
            txtId.Location = new Point(68, 25);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(71, 23);
            txtId.TabIndex = 18;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(35, 28);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 17;
            lblId.Text = "Id:";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(68, 97);
            txtPreco.Margin = new Padding(3, 2, 3, 2);
            txtPreco.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(72, 23);
            txtPreco.TabIndex = 14;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(68, 60);
            txtTitulo.Margin = new Padding(3, 2, 3, 2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(165, 23);
            txtTitulo.TabIndex = 13;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(68, 134);
            chkAtivo.Margin = new Padding(3, 2, 3, 2);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(15, 14);
            chkAtivo.TabIndex = 12;
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(15, 99);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(56, 15);
            lblPreco.TabIndex = 11;
            lblPreco.Text = "Preço: R$";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(15, 63);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(40, 15);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "Titulo:";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(177, 173);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 35);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(96, 173);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 35);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // TelaItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 214);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(groupTemas);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaItemForm";
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