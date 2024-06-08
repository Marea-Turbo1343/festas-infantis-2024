namespace FestasInfantis.WinApp.ModuloTema
{
    partial class TelaVerTema
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
            txtValorTotal = new TextBox();
            txtTema = new TextBox();
            listBoxItensTema = new ListBox();
            lblValorTotal = new Label();
            lblId = new Label();
            txtId = new TextBox();
            lblTema = new Label();
            btnFechar = new Button();
            gpTema.SuspendLayout();
            SuspendLayout();
            // 
            // gpTema
            // 
            gpTema.Controls.Add(txtValorTotal);
            gpTema.Controls.Add(txtTema);
            gpTema.Controls.Add(listBoxItensTema);
            gpTema.Controls.Add(lblValorTotal);
            gpTema.Controls.Add(lblId);
            gpTema.Controls.Add(txtId);
            gpTema.Controls.Add(lblTema);
            gpTema.Location = new Point(12, 11);
            gpTema.Margin = new Padding(3, 2, 3, 2);
            gpTema.Name = "gpTema";
            gpTema.Padding = new Padding(3, 2, 3, 2);
            gpTema.Size = new Size(382, 294);
            gpTema.TabIndex = 11;
            gpTema.TabStop = false;
            gpTema.Text = "Tema";
            // 
            // txtValorTotal
            // 
            txtValorTotal.Location = new Point(88, 75);
            txtValorTotal.Margin = new Padding(3, 2, 3, 2);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.ReadOnly = true;
            txtValorTotal.Size = new Size(110, 23);
            txtValorTotal.TabIndex = 2;
            txtValorTotal.TabStop = false;
            // 
            // txtTema
            // 
            txtTema.Location = new Point(88, 48);
            txtTema.Margin = new Padding(3, 2, 3, 2);
            txtTema.Name = "txtTema";
            txtTema.ReadOnly = true;
            txtTema.Size = new Size(110, 23);
            txtTema.TabIndex = 1;
            txtTema.TabStop = false;
            // 
            // listBoxItensTema
            // 
            listBoxItensTema.FormattingEnabled = true;
            listBoxItensTema.ItemHeight = 15;
            listBoxItensTema.Location = new Point(6, 103);
            listBoxItensTema.Name = "listBoxItensTema";
            listBoxItensTema.Size = new Size(370, 184);
            listBoxItensTema.TabIndex = 3;
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.BackColor = SystemColors.ButtonFace;
            lblValorTotal.Font = new Font("Segoe UI", 10F);
            lblValorTotal.Location = new Point(6, 76);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(76, 19);
            lblValorTotal.TabIndex = 28;
            lblValorTotal.Text = "Valor Total:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 10F);
            lblId.Location = new Point(58, 22);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 19);
            lblId.TabIndex = 26;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(88, 21);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(79, 23);
            txtId.TabIndex = 0;
            txtId.TabStop = false;
            // 
            // lblTema
            // 
            lblTema.AutoSize = true;
            lblTema.BackColor = SystemColors.ButtonFace;
            lblTema.Font = new Font("Segoe UI", 10F);
            lblTema.Location = new Point(38, 49);
            lblTema.Name = "lblTema";
            lblTema.Size = new Size(44, 19);
            lblTema.TabIndex = 27;
            lblTema.Text = "Tema:";
            // 
            // btnFechar
            // 
            btnFechar.DialogResult = DialogResult.OK;
            btnFechar.Location = new Point(312, 309);
            btnFechar.Margin = new Padding(3, 2, 3, 2);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(82, 34);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // TelaVerTema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 351);
            Controls.Add(btnFechar);
            Controls.Add(gpTema);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaVerTema";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualizando Tema";
            gpTema.ResumeLayout(false);
            gpTema.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpTema;
        private ListBox listBoxItensTema;
        private Label lblValorTotal;
        private Label lblId;
        private TextBox txtId;
        private Label lblTema;
        private TextBox txtValorTotal;
        private TextBox txtTema;
        private Button btnFechar;
    }
}