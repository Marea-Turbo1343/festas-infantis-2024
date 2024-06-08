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
            label1 = new Label();
            numDescontoMax = new NumericUpDown();
            numDescontoMin = new NumericUpDown();
            labelDesMin = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDescontoMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDescontoMin).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numDescontoMax);
            groupBox1.Controls.Add(numDescontoMin);
            groupBox1.Controls.Add(labelDesMin);
            groupBox1.Location = new Point(12, 11);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(268, 83);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Desconto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 49);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 10;
            label1.Text = "Desconto máximo: ";
            // 
            // numDescontoMax
            // 
            numDescontoMax.Location = new Point(124, 47);
            numDescontoMax.Margin = new Padding(3, 2, 3, 2);
            numDescontoMax.Name = "numDescontoMax";
            numDescontoMax.Size = new Size(134, 23);
            numDescontoMax.TabIndex = 9;
            // 
            // numDescontoMin
            // 
            numDescontoMin.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numDescontoMin.Location = new Point(124, 20);
            numDescontoMin.Margin = new Padding(3, 2, 3, 2);
            numDescontoMin.Name = "numDescontoMin";
            numDescontoMin.Size = new Size(134, 23);
            numDescontoMin.TabIndex = 8;
            // 
            // labelDesMin
            // 
            labelDesMin.AutoSize = true;
            labelDesMin.Location = new Point(11, 22);
            labelDesMin.Name = "labelDesMin";
            labelDesMin.Size = new Size(108, 15);
            labelDesMin.TabIndex = 6;
            labelDesMin.Text = "Desconto mínimo: ";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(212, 98);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(68, 34);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(138, 98);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(68, 34);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // TelaDescontoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 141);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaDescontoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configurar Desconto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDescontoMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDescontoMin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private NumericUpDown numDescontoMax;
        private NumericUpDown numDescontoMin;
        private Label labelDesMin;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}