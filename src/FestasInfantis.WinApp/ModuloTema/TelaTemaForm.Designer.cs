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
            groupTemas = new GroupBox();
            btnDeletarItem = new Button();
            btnAdicionarItem = new Button();
            numValor = new NumericUpDown();
            txtTema = new TextBox();
            cmbItens = new ComboBox();
            listBoxItensTema = new ListBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtId = new TextBox();
            labelNome = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            groupTemas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
            SuspendLayout();
            // 
            // groupTemas
            // 
            groupTemas.Controls.Add(btnDeletarItem);
            groupTemas.Controls.Add(btnAdicionarItem);
            groupTemas.Controls.Add(numValor);
            groupTemas.Controls.Add(txtTema);
            groupTemas.Controls.Add(cmbItens);
            groupTemas.Controls.Add(listBoxItensTema);
            groupTemas.Controls.Add(label4);
            groupTemas.Controls.Add(label2);
            groupTemas.Controls.Add(label1);
            groupTemas.Controls.Add(txtId);
            groupTemas.Controls.Add(labelNome);
            groupTemas.Location = new Point(11, 12);
            groupTemas.Margin = new Padding(3, 2, 3, 2);
            groupTemas.Name = "groupTemas";
            groupTemas.Padding = new Padding(3, 2, 3, 2);
            groupTemas.Size = new Size(455, 310);
            groupTemas.TabIndex = 8;
            groupTemas.TabStop = false;
            groupTemas.Text = "Temas";
            // 
            // btnDeletarItem
            // 
            btnDeletarItem.Location = new Point(18, 176);
            btnDeletarItem.Margin = new Padding(3, 2, 3, 2);
            btnDeletarItem.Name = "btnDeletarItem";
            btnDeletarItem.Size = new Size(82, 22);
            btnDeletarItem.TabIndex = 37;
            btnDeletarItem.Text = "Deletar";
            btnDeletarItem.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.Location = new Point(18, 149);
            btnAdicionarItem.Margin = new Padding(3, 2, 3, 2);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.Size = new Size(82, 22);
            btnAdicionarItem.TabIndex = 36;
            btnAdicionarItem.Text = "Adicionar";
            btnAdicionarItem.UseVisualStyleBackColor = true;
            // 
            // numValor
            // 
            numValor.Enabled = false;
            numValor.Location = new Point(107, 112);
            numValor.Margin = new Padding(3, 2, 3, 2);
            numValor.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numValor.Name = "numValor";
            numValor.ReadOnly = true;
            numValor.Size = new Size(78, 23);
            numValor.TabIndex = 35;
            // 
            // txtTema
            // 
            txtTema.Location = new Point(107, 56);
            txtTema.Margin = new Padding(3, 2, 3, 2);
            txtTema.Name = "txtTema";
            txtTema.Size = new Size(330, 23);
            txtTema.TabIndex = 34;
            // 
            // cmbItens
            // 
            cmbItens.FormattingEnabled = true;
            cmbItens.Location = new Point(106, 85);
            cmbItens.Margin = new Padding(3, 2, 3, 2);
            cmbItens.Name = "cmbItens";
            cmbItens.Size = new Size(330, 23);
            cmbItens.TabIndex = 33;
            // 
            // listBoxItensTema
            // 
            listBoxItensTema.FormattingEnabled = true;
            listBoxItensTema.ItemHeight = 15;
            listBoxItensTema.Location = new Point(105, 149);
            listBoxItensTema.Name = "listBoxItensTema";
            listBoxItensTema.Size = new Size(331, 139);
            listBoxItensTema.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(37, 112);
            label4.Name = "label4";
            label4.Size = new Size(43, 19);
            label4.TabIndex = 29;
            label4.Text = "Valor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(40, 86);
            label2.Name = "label2";
            label2.Size = new Size(40, 19);
            label2.TabIndex = 28;
            label2.Text = "Item:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(56, 24);
            label1.Name = "label1";
            label1.Size = new Size(24, 19);
            label1.TabIndex = 26;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(106, 23);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(79, 23);
            txtId.TabIndex = 25;
            txtId.TabStop = false;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.BackColor = SystemColors.ButtonFace;
            labelNome.Font = new Font("Segoe UI", 10F);
            labelNome.Location = new Point(36, 57);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(44, 19);
            labelNome.TabIndex = 27;
            labelNome.Text = "Tema:";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(391, 327);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 35);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(310, 327);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 35);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // TelaTema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 374);
            Controls.Add(groupTemas);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaTema";
            ShowIcon = false;
            Text = "TelaTema";
            groupTemas.ResumeLayout(false);
            groupTemas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numValor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupTemas;
        private Button btnDeletarItem;
        private Button btnAdicionarItem;
        private NumericUpDown numValor;
        private TextBox txtTema;
        private ComboBox cmbItens;
        private ListBox listBoxItensTema;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtId;
        private Label labelNome;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}