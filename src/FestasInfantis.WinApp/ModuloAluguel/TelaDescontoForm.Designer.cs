namespace FestasInfantis.WinApp.ModuloAluguel
{
    partial class TelaDescontoForm
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
            groupBox1 = new GroupBox();
            numDesconto = new NumericUpDown();
            numDescontoMax = new NumericUpDown();
            lblPorcentagemMaxima = new Label();
            lblPorcentagemDesconto = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDesconto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDescontoMax).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numDesconto);
            groupBox1.Controls.Add(numDescontoMax);
            groupBox1.Controls.Add(lblPorcentagemMaxima);
            groupBox1.Controls.Add(lblPorcentagemDesconto);
            groupBox1.Location = new Point(12, 11);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(197, 74);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Desconto";
            // 
            // numDesconto
            // 
            numDesconto.Location = new Point(145, 16);
            numDesconto.Margin = new Padding(3, 2, 3, 2);
            numDesconto.Name = "numDesconto";
            numDesconto.Size = new Size(44, 23);
            numDesconto.TabIndex = 1;
            // 
            // numDescontoMax
            // 
            numDescontoMax.Location = new Point(145, 43);
            numDescontoMax.Margin = new Padding(3, 2, 3, 2);
            numDescontoMax.Name = "numDescontoMax";
            numDescontoMax.Size = new Size(44, 23);
            numDescontoMax.TabIndex = 1;
            // 
            // lblPorcentagemMaxima
            // 
            lblPorcentagemMaxima.AutoSize = true;
            lblPorcentagemMaxima.Location = new Point(12, 45);
            lblPorcentagemMaxima.Name = "lblPorcentagemMaxima";
            lblPorcentagemMaxima.Size = new Size(127, 15);
            lblPorcentagemMaxima.TabIndex = 6;
            lblPorcentagemMaxima.Text = "Porcentagem máxima:";
            // 
            // lblPorcentagemDesconto
            // 
            lblPorcentagemDesconto.AutoSize = true;
            lblPorcentagemDesconto.Location = new Point(6, 18);
            lblPorcentagemDesconto.Name = "lblPorcentagemDesconto";
            lblPorcentagemDesconto.Size = new Size(133, 15);
            lblPorcentagemDesconto.TabIndex = 6;
            lblPorcentagemDesconto.Text = "Porcentagem desconto:";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(141, 89);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(68, 34);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(67, 89);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(68, 34);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // TelaDescontoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(218, 131);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaDescontoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configurar Desconto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDesconto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDescontoMax).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private NumericUpDown numDescontoMax;
        private NumericUpDown numDescontoMin;
        private Label lblPorcentagemDesconto;
        private Button btnCancelar;
        private Button btnSalvar;
        private NumericUpDown numDesconto;
        private Label lblPorcentagemMaxima;
    }
}