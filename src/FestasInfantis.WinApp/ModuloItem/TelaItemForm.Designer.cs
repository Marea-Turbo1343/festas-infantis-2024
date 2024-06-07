namespace FestasInfantis.WinApp.ModuloItem
{
    partial class TelaItemForm
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
            gpItem = new GroupBox();
            txtId = new TextBox();
            lblId = new Label();
            txtValor = new TextBox();
            txtDescricao = new TextBox();
            lblValor = new Label();
            lblDescricao = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            gpItem.SuspendLayout();
            SuspendLayout();
            // 
            // gpItem
            // 
            gpItem.Controls.Add(txtId);
            gpItem.Controls.Add(lblId);
            gpItem.Controls.Add(txtValor);
            gpItem.Controls.Add(txtDescricao);
            gpItem.Controls.Add(lblValor);
            gpItem.Controls.Add(lblDescricao);
            gpItem.Location = new Point(12, 11);
            gpItem.Margin = new Padding(3, 2, 3, 2);
            gpItem.Name = "gpItem";
            gpItem.Padding = new Padding(3, 2, 3, 2);
            gpItem.Size = new Size(247, 107);
            gpItem.TabIndex = 6;
            gpItem.TabStop = false;
            gpItem.Text = "Item";
            // 
            // txtId
            // 
            txtId.Location = new Point(72, 20);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(60, 23);
            txtId.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(46, 23);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 17;
            lblId.Text = "Id:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(72, 74);
            txtValor.Margin = new Padding(3, 2, 3, 2);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(166, 23);
            txtValor.TabIndex = 1;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(72, 47);
            txtDescricao.Margin = new Padding(3, 2, 3, 2);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(166, 23);
            txtDescricao.TabIndex = 1;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(30, 77);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(36, 15);
            lblValor.TabIndex = 11;
            lblValor.Text = "Valor:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(5, 50);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 10;
            lblDescricao.Text = "Descricao:";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(184, 123);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 35);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(103, 123);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 35);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // TelaItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 169);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(gpItem);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaItemForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Item";
            gpItem.ResumeLayout(false);
            gpItem.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpItem;
        private Button btnCancelar;
        private Button btnSalvar;
        private TextBox txtId;
        private Label lblId;
        private TextBox txtDescricao;
        private Label lblValor;
        private Label lblDescricao;
        private TextBox txtValor;
    }
}