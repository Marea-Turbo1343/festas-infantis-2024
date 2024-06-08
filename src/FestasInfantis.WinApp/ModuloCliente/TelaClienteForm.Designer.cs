namespace FestasInfantis.WinApp.ModuloCliente
{
    partial class TelaClienteForm
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
            gpCliente = new GroupBox();
            txtTelefone = new TextBox();
            txtCpf = new TextBox();
            txtNome = new TextBox();
            lblTelefone = new Label();
            lblId = new Label();
            lblCpf = new Label();
            txtId = new TextBox();
            lblNome = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            gpCliente.SuspendLayout();
            SuspendLayout();
            // 
            // gpCliente
            // 
            gpCliente.Controls.Add(txtTelefone);
            gpCliente.Controls.Add(txtCpf);
            gpCliente.Controls.Add(txtNome);
            gpCliente.Controls.Add(lblTelefone);
            gpCliente.Controls.Add(lblId);
            gpCliente.Controls.Add(lblCpf);
            gpCliente.Controls.Add(txtId);
            gpCliente.Controls.Add(lblNome);
            gpCliente.Location = new Point(9, 11);
            gpCliente.Margin = new Padding(3, 2, 3, 2);
            gpCliente.Name = "gpCliente";
            gpCliente.Padding = new Padding(3, 2, 3, 2);
            gpCliente.Size = new Size(406, 133);
            gpCliente.TabIndex = 11;
            gpCliente.TabStop = false;
            gpCliente.Text = "Cliente";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(69, 99);
            txtTelefone.Margin = new Padding(3, 2, 3, 2);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(324, 23);
            txtTelefone.TabIndex = 34;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(69, 72);
            txtCpf.Margin = new Padding(3, 2, 3, 2);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(324, 23);
            txtCpf.TabIndex = 34;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(69, 45);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(324, 23);
            txtNome.TabIndex = 34;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.BackColor = SystemColors.ButtonFace;
            lblTelefone.Font = new Font("Segoe UI", 10F);
            lblTelefone.Location = new Point(6, 100);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(62, 19);
            lblTelefone.TabIndex = 27;
            lblTelefone.Text = "Telefone:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 10F);
            lblId.Location = new Point(44, 19);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 19);
            lblId.TabIndex = 26;
            lblId.Text = "Id:";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.BackColor = SystemColors.ButtonFace;
            lblCpf.Font = new Font("Segoe UI", 10F);
            lblCpf.Location = new Point(32, 73);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(36, 19);
            lblCpf.TabIndex = 27;
            lblCpf.Text = "CPF:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(69, 18);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(73, 23);
            txtId.TabIndex = 25;
            txtId.TabStop = false;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = SystemColors.ButtonFace;
            lblNome.Font = new Font("Segoe UI", 10F);
            lblNome.Location = new Point(19, 46);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(49, 19);
            lblNome.TabIndex = 27;
            lblNome.Text = "Nome:";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(340, 149);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 35);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(259, 149);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 35);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 191);
            Controls.Add(gpCliente);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaClienteForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Cliente";
            gpCliente.ResumeLayout(false);
            gpCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpCliente;
        private TextBox txtTelefone;
        private TextBox txtNome;
        private Label lblTelefone;
        private Label lblId;
        private Label lblCpf;
        private TextBox txtId;
        private Label lblNome;
        private Button btnCancelar;
        private Button btnSalvar;
        private TextBox txtCpf;
    }
}