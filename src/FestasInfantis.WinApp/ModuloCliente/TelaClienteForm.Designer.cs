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
            groupTemas = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            txtTema = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            labelNome = new Label();
            lblEndereco = new Label();
            textBox3 = new TextBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            groupTemas.SuspendLayout();
            SuspendLayout();
            // 
            // groupTemas
            // 
            groupTemas.Controls.Add(textBox3);
            groupTemas.Controls.Add(textBox2);
            groupTemas.Controls.Add(textBox1);
            groupTemas.Controls.Add(lblEndereco);
            groupTemas.Controls.Add(txtTema);
            groupTemas.Controls.Add(label3);
            groupTemas.Controls.Add(label1);
            groupTemas.Controls.Add(label2);
            groupTemas.Controls.Add(txtId);
            groupTemas.Controls.Add(labelNome);
            groupTemas.Location = new Point(12, 11);
            groupTemas.Margin = new Padding(3, 2, 3, 2);
            groupTemas.Name = "groupTemas";
            groupTemas.Padding = new Padding(3, 2, 3, 2);
            groupTemas.Size = new Size(406, 160);
            groupTemas.TabIndex = 11;
            groupTemas.TabStop = false;
            groupTemas.Text = "Cliente";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(73, 99);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(324, 23);
            textBox2.TabIndex = 34;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(73, 72);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(324, 23);
            textBox1.TabIndex = 34;
            // 
            // txtTema
            // 
            txtTema.Location = new Point(73, 45);
            txtTema.Margin = new Padding(3, 2, 3, 2);
            txtTema.Name = "txtTema";
            txtTema.Size = new Size(324, 23);
            txtTema.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(10, 100);
            label3.Name = "label3";
            label3.Size = new Size(62, 19);
            label3.TabIndex = 27;
            label3.Text = "Telefone:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(48, 19);
            label1.Name = "label1";
            label1.Size = new Size(24, 19);
            label1.TabIndex = 26;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(36, 73);
            label2.Name = "label2";
            label2.Size = new Size(36, 19);
            label2.TabIndex = 27;
            label2.Text = "CPF:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(73, 18);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(73, 23);
            txtId.TabIndex = 25;
            txtId.TabStop = false;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.BackColor = SystemColors.ButtonFace;
            labelNome.Font = new Font("Segoe UI", 10F);
            labelNome.Location = new Point(23, 46);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(49, 19);
            labelNome.TabIndex = 27;
            labelNome.Text = "Nome:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.BackColor = SystemColors.ButtonFace;
            lblEndereco.Font = new Font("Segoe UI", 10F);
            lblEndereco.Location = new Point(4, 127);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(68, 19);
            lblEndereco.TabIndex = 27;
            lblEndereco.Text = "Endereço:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(73, 126);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(324, 23);
            textBox3.TabIndex = 34;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(343, 176);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 35);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(262, 176);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 35);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 221);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(groupTemas);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaClienteForm";
            ShowIcon = false;
            Text = "Cadastro de Cliente";
            Load += TelaClienteForm_Load;
            groupTemas.ResumeLayout(false);
            groupTemas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupTemas;
        private TextBox textBox2;
        private TextBox txtTema;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox txtId;
        private Label labelNome;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label lblEndereco;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}