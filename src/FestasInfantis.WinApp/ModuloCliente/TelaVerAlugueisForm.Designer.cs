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
            gpAlugueis = new GroupBox();
            listViewAlugueis = new ListView();
            txtNome = new TextBox();
            lblId = new Label();
            txtId = new TextBox();
            lblNome = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            gpAlugueis.SuspendLayout();
            SuspendLayout();
            // 
            // gpAlugueis
            // 
            gpAlugueis.Controls.Add(listViewAlugueis);
            gpAlugueis.Controls.Add(txtNome);
            gpAlugueis.Controls.Add(lblId);
            gpAlugueis.Controls.Add(txtId);
            gpAlugueis.Controls.Add(lblNome);
            gpAlugueis.Location = new Point(12, 11);
            gpAlugueis.Margin = new Padding(3, 2, 3, 2);
            gpAlugueis.Name = "gpAlugueis";
            gpAlugueis.Padding = new Padding(3, 2, 3, 2);
            gpAlugueis.Size = new Size(525, 251);
            gpAlugueis.TabIndex = 14;
            gpAlugueis.TabStop = false;
            gpAlugueis.Text = "Aluguéis";
            // 
            // listViewAlugueis
            // 
            listViewAlugueis.Location = new Point(6, 75);
            listViewAlugueis.Name = "listViewAlugueis";
            listViewAlugueis.Size = new Size(513, 171);
            listViewAlugueis.TabIndex = 2;
            listViewAlugueis.UseCompatibleStateImageBehavior = false;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(57, 47);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(330, 23);
            txtNome.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 10F);
            lblId.Location = new Point(32, 19);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 19);
            lblId.TabIndex = 26;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(57, 18);
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
            lblNome.Location = new Point(7, 46);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(49, 19);
            lblNome.TabIndex = 27;
            lblNome.Text = "Nome:";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(462, 267);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 35);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(381, 267);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 35);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // TelaVerAlugueisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 314);
            Controls.Add(gpAlugueis);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaVerAlugueisForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualizando aluguéis";
            gpAlugueis.ResumeLayout(false);
            gpAlugueis.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpAlugueis;
        private TextBox txtNome;
        private Label lblId;
        private TextBox txtId;
        private Label lblNome;
        private Button btnCancelar;
        private Button btnSalvar;
        private ListView listViewAlugueis;
    }
}