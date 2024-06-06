namespace FestasInfantis.WinApp.ModuloCliente
{
    partial class TelaVerAlugueisForm
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
            groupAlugueis = new GroupBox();
            listAlugueis = new ListBox();
            txtTema = new TextBox();
            label1 = new Label();
            txtId = new TextBox();
            labelNome = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            groupAlugueis.SuspendLayout();
            SuspendLayout();
            // 
            // groupAlugueis
            // 
            groupAlugueis.Controls.Add(listAlugueis);
            groupAlugueis.Controls.Add(txtTema);
            groupAlugueis.Controls.Add(label1);
            groupAlugueis.Controls.Add(txtId);
            groupAlugueis.Controls.Add(labelNome);
            groupAlugueis.Location = new Point(12, 11);
            groupAlugueis.Margin = new Padding(3, 2, 3, 2);
            groupAlugueis.Name = "groupAlugueis";
            groupAlugueis.Padding = new Padding(3, 2, 3, 2);
            groupAlugueis.Size = new Size(525, 251);
            groupAlugueis.TabIndex = 14;
            groupAlugueis.TabStop = false;
            groupAlugueis.Text = "Aluguéis";
            // 
            // listAlugueis
            // 
            listAlugueis.FormattingEnabled = true;
            listAlugueis.ItemHeight = 15;
            listAlugueis.Location = new Point(6, 75);
            listAlugueis.Margin = new Padding(3, 2, 3, 2);
            listAlugueis.Name = "listAlugueis";
            listAlugueis.Size = new Size(513, 169);
            listAlugueis.TabIndex = 35;
            // 
            // txtTema
            // 
            txtTema.Location = new Point(57, 47);
            txtTema.Margin = new Padding(3, 2, 3, 2);
            txtTema.Name = "txtTema";
            txtTema.Size = new Size(330, 23);
            txtTema.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(32, 19);
            label1.Name = "label1";
            label1.Size = new Size(24, 19);
            label1.TabIndex = 26;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(57, 18);
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
            labelNome.Location = new Point(7, 46);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(49, 19);
            labelNome.TabIndex = 27;
            labelNome.Text = "Nome:";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(462, 267);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 35);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(381, 267);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 35);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // TelaVerAlugueisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 314);
            Controls.Add(groupAlugueis);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaVerAlugueisForm";
            ShowIcon = false;
            Text = "Visualizando aluguéis";
            groupAlugueis.ResumeLayout(false);
            groupAlugueis.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupAlugueis;
        private TextBox txtTema;
        private Label label1;
        private TextBox txtId;
        private Label labelNome;
        private Button btnCancelar;
        private Button btnSalvar;
        private ListBox listAlugueis;
    }
}