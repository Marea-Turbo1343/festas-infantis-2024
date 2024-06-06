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
            groupTemas = new GroupBox();
            listBoxItensTema = new ListBox();
            label2 = new Label();
            label1 = new Label();
            txtId = new TextBox();
            labelNome = new Label();
            txtNr = new TextBox();
            txtPreco = new TextBox();
            btnFechar = new Button();
            groupTemas.SuspendLayout();
            SuspendLayout();
            // 
            // groupTemas
            // 
            groupTemas.Controls.Add(txtPreco);
            groupTemas.Controls.Add(txtNr);
            groupTemas.Controls.Add(listBoxItensTema);
            groupTemas.Controls.Add(label2);
            groupTemas.Controls.Add(label1);
            groupTemas.Controls.Add(txtId);
            groupTemas.Controls.Add(labelNome);
            groupTemas.Location = new Point(12, 11);
            groupTemas.Margin = new Padding(3, 2, 3, 2);
            groupTemas.Name = "groupTemas";
            groupTemas.Padding = new Padding(3, 2, 3, 2);
            groupTemas.Size = new Size(382, 294);
            groupTemas.TabIndex = 11;
            groupTemas.TabStop = false;
            groupTemas.Text = "Tema";
            // 
            // listBoxItensTema
            // 
            listBoxItensTema.FormattingEnabled = true;
            listBoxItensTema.ItemHeight = 15;
            listBoxItensTema.Location = new Point(6, 103);
            listBoxItensTema.Name = "listBoxItensTema";
            listBoxItensTema.Size = new Size(370, 184);
            listBoxItensTema.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(6, 76);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 28;
            label2.Text = "Preço:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(28, 20);
            label1.Name = "label1";
            label1.Size = new Size(24, 19);
            label1.TabIndex = 26;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(54, 20);
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
            labelNome.Location = new Point(8, 48);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(44, 19);
            labelNome.TabIndex = 27;
            labelNome.Text = "Tema:";
            // 
            // txtNr
            // 
            txtNr.Location = new Point(54, 47);
            txtNr.Margin = new Padding(3, 2, 3, 2);
            txtNr.Name = "txtNr";
            txtNr.ReadOnly = true;
            txtNr.Size = new Size(110, 23);
            txtNr.TabIndex = 31;
            txtNr.TabStop = false;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(54, 75);
            txtPreco.Margin = new Padding(3, 2, 3, 2);
            txtPreco.Name = "txtPreco";
            txtPreco.ReadOnly = true;
            txtPreco.Size = new Size(110, 23);
            txtPreco.TabIndex = 32;
            txtPreco.TabStop = false;
            // 
            // btnFechar
            // 
            btnFechar.DialogResult = DialogResult.OK;
            btnFechar.Location = new Point(312, 309);
            btnFechar.Margin = new Padding(3, 2, 3, 2);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(82, 34);
            btnFechar.TabIndex = 12;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // TelaVerTema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 351);
            Controls.Add(btnFechar);
            Controls.Add(groupTemas);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaVerTema";
            ShowIcon = false;
            Text = "Visualizando Tema";
            groupTemas.ResumeLayout(false);
            groupTemas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupTemas;
        private ListBox listBoxItensTema;
        private Label label2;
        private Label label1;
        private TextBox txtId;
        private Label labelNome;
        private TextBox txtPreco;
        private TextBox txtNr;
        private Button btnFechar;
    }
}