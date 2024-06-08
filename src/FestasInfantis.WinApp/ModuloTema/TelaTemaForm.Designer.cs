namespace FestasInfantis.WinApp.ModuloTema
{
    partial class TelaTemaForm
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
            gpTema = new GroupBox();
            btnDeletarItem = new Button();
            btnAdicionarItem = new Button();
            numValor = new NumericUpDown();
            txtNome = new TextBox();
            cmbItens = new ComboBox();
            listBoxItensTema = new ListBox();
            lblValor = new Label();
            lblItem = new Label();
            lblId = new Label();
            txtId = new TextBox();
            lblNome = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            gpTema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
            SuspendLayout();
            // 
            // gpTema
            // 
            gpTema.Controls.Add(btnDeletarItem);
            gpTema.Controls.Add(btnAdicionarItem);
            gpTema.Controls.Add(numValor);
            gpTema.Controls.Add(txtNome);
            gpTema.Controls.Add(cmbItens);
            gpTema.Controls.Add(listBoxItensTema);
            gpTema.Controls.Add(lblValor);
            gpTema.Controls.Add(lblItem);
            gpTema.Controls.Add(lblId);
            gpTema.Controls.Add(txtId);
            gpTema.Controls.Add(lblNome);
            gpTema.Location = new Point(11, 12);
            gpTema.Margin = new Padding(3, 2, 3, 2);
            gpTema.Name = "gpTema";
            gpTema.Padding = new Padding(3, 2, 3, 2);
            gpTema.Size = new Size(397, 267);
            gpTema.TabIndex = 8;
            gpTema.TabStop = false;
            gpTema.Text = "Tema";
            // 
            // btnDeletarItem
            // 
            btnDeletarItem.Location = new Point(7, 162);
            btnDeletarItem.Margin = new Padding(3, 2, 3, 2);
            btnDeletarItem.Name = "btnDeletarItem";
            btnDeletarItem.Size = new Size(72, 22);
            btnDeletarItem.TabIndex = 5;
            btnDeletarItem.Text = "Deletar";
            btnDeletarItem.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.Location = new Point(7, 136);
            btnAdicionarItem.Margin = new Padding(3, 2, 3, 2);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.Size = new Size(72, 22);
            btnAdicionarItem.TabIndex = 4;
            btnAdicionarItem.Text = "Adicionar";
            btnAdicionarItem.UseVisualStyleBackColor = true;
            // 
            // numValor
            // 
            numValor.Enabled = false;
            numValor.Location = new Point(51, 103);
            numValor.Margin = new Padding(3, 2, 3, 2);
            numValor.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numValor.Name = "numValor";
            numValor.ReadOnly = true;
            numValor.Size = new Size(78, 23);
            numValor.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(51, 47);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(243, 23);
            txtNome.TabIndex = 1;
            // 
            // cmbItens
            // 
            cmbItens.FormattingEnabled = true;
            cmbItens.Location = new Point(51, 76);
            cmbItens.Margin = new Padding(3, 2, 3, 2);
            cmbItens.Name = "cmbItens";
            cmbItens.Size = new Size(243, 23);
            cmbItens.TabIndex = 2;
            // 
            // listBoxItensTema
            // 
            listBoxItensTema.FormattingEnabled = true;
            listBoxItensTema.ItemHeight = 15;
            listBoxItensTema.Location = new Point(85, 136);
            listBoxItensTema.Name = "listBoxItensTema";
            listBoxItensTema.Size = new Size(305, 124);
            listBoxItensTema.TabIndex = 6;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.BackColor = SystemColors.ButtonFace;
            lblValor.Font = new Font("Segoe UI", 10F);
            lblValor.Location = new Point(6, 103);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(43, 19);
            lblValor.TabIndex = 29;
            lblValor.Text = "Valor:";
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.BackColor = SystemColors.ButtonFace;
            lblItem.Font = new Font("Segoe UI", 10F);
            lblItem.Location = new Point(9, 77);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(40, 19);
            lblItem.TabIndex = 28;
            lblItem.Text = "Item:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 10F);
            lblId.Location = new Point(25, 21);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 19);
            lblId.TabIndex = 26;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(51, 20);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(79, 23);
            txtId.TabIndex = 0;
            txtId.TabStop = false;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = SystemColors.ButtonFace;
            lblNome.Font = new Font("Segoe UI", 10F);
            lblNome.Location = new Point(0, 48);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(49, 19);
            lblNome.TabIndex = 27;
            lblNome.Text = "Nome:";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(333, 284);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 35);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(252, 284);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 35);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // TelaTemaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 327);
            Controls.Add(gpTema);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaTemaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Tema";
            gpTema.ResumeLayout(false);
            gpTema.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numValor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpTema;
        private Button btnDeletarItem;
        private Button btnAdicionarItem;
        private NumericUpDown numValor;
        private TextBox txtNome;
        private ComboBox cmbItens;
        private ListBox listBoxItensTema;
        private Label lblValor;
        private Label lblItem;
        private Label lblId;
        private TextBox txtId;
        private Label lblNome;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}