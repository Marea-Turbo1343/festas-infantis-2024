namespace FestasInfantis.WinApp.ModuloAluguel
{
    partial class TelaEncerrarAluguelForm
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
            txtValorTotal = new ComboBox();
            labelValorTotal = new Label();
            btnCancelar = new Button();
            btnEncerrar = new Button();
            txtDebito = new ComboBox();
            labelDebito = new Label();
            txtValorEntrada = new ComboBox();
            labelValorEntrada = new Label();
            txtId = new TextBox();
            lblId = new Label();
            txtTema = new ComboBox();
            labelTema = new Label();
            txtCliente = new ComboBox();
            labelCliente = new Label();
            gpBoxEncerrarAluguel = new GroupBox();
            gpBoxEncerrarAluguel.SuspendLayout();
            SuspendLayout();
            // 
            // txtValorTotal
            // 
            txtValorTotal.Enabled = false;
            txtValorTotal.FormattingEnabled = true;
            txtValorTotal.Location = new Point(89, 106);
            txtValorTotal.Margin = new Padding(3, 2, 3, 2);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(77, 23);
            txtValorTotal.TabIndex = 52;
            // 
            // labelValorTotal
            // 
            labelValorTotal.AutoSize = true;
            labelValorTotal.Location = new Point(19, 109);
            labelValorTotal.Name = "labelValorTotal";
            labelValorTotal.Size = new Size(64, 15);
            labelValorTotal.TabIndex = 51;
            labelValorTotal.Text = "Valor Total:";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(327, 212);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 46);
            btnCancelar.TabIndex = 50;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEncerrar
            // 
            btnEncerrar.DialogResult = DialogResult.OK;
            btnEncerrar.Location = new Point(247, 212);
            btnEncerrar.Name = "btnEncerrar";
            btnEncerrar.Size = new Size(75, 46);
            btnEncerrar.TabIndex = 49;
            btnEncerrar.Text = "Encerrar";
            btnEncerrar.UseVisualStyleBackColor = true;
            // 
            // txtDebito
            // 
            txtDebito.Enabled = false;
            txtDebito.FormattingEnabled = true;
            txtDebito.Location = new Point(89, 160);
            txtDebito.Margin = new Padding(3, 2, 3, 2);
            txtDebito.Name = "txtDebito";
            txtDebito.Size = new Size(77, 23);
            txtDebito.TabIndex = 48;
            // 
            // labelDebito
            // 
            labelDebito.AutoSize = true;
            labelDebito.Location = new Point(38, 163);
            labelDebito.Name = "labelDebito";
            labelDebito.Size = new Size(45, 15);
            labelDebito.TabIndex = 47;
            labelDebito.Text = "Débito:";
            // 
            // txtValorEntrada
            // 
            txtValorEntrada.Enabled = false;
            txtValorEntrada.FormattingEnabled = true;
            txtValorEntrada.Location = new Point(89, 133);
            txtValorEntrada.Margin = new Padding(3, 2, 3, 2);
            txtValorEntrada.Name = "txtValorEntrada";
            txtValorEntrada.Size = new Size(77, 23);
            txtValorEntrada.TabIndex = 46;
            // 
            // labelValorEntrada
            // 
            labelValorEntrada.AutoSize = true;
            labelValorEntrada.Location = new Point(33, 136);
            labelValorEntrada.Name = "labelValorEntrada";
            labelValorEntrada.Size = new Size(50, 15);
            labelValorEntrada.TabIndex = 45;
            labelValorEntrada.Text = "Entrada:";
            // 
            // txtId
            // 
            txtId.Location = new Point(89, 21);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(77, 23);
            txtId.TabIndex = 44;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(63, 24);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 43;
            lblId.Text = "Id:";
            // 
            // txtTema
            // 
            txtTema.Enabled = false;
            txtTema.FormattingEnabled = true;
            txtTema.Location = new Point(89, 52);
            txtTema.Margin = new Padding(3, 2, 3, 2);
            txtTema.Name = "txtTema";
            txtTema.Size = new Size(295, 23);
            txtTema.TabIndex = 42;
            // 
            // labelTema
            // 
            labelTema.AutoSize = true;
            labelTema.Location = new Point(45, 55);
            labelTema.Name = "labelTema";
            labelTema.Size = new Size(38, 15);
            labelTema.TabIndex = 41;
            labelTema.Text = "Tema:";
            // 
            // txtCliente
            // 
            txtCliente.Enabled = false;
            txtCliente.FormattingEnabled = true;
            txtCliente.Location = new Point(89, 79);
            txtCliente.Margin = new Padding(3, 2, 3, 2);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(295, 23);
            txtCliente.TabIndex = 40;
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(36, 82);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(47, 15);
            labelCliente.TabIndex = 39;
            labelCliente.Text = "Cliente:";
            // 
            // gpBoxEncerrarAluguel
            // 
            gpBoxEncerrarAluguel.Controls.Add(txtValorTotal);
            gpBoxEncerrarAluguel.Controls.Add(txtId);
            gpBoxEncerrarAluguel.Controls.Add(labelValorTotal);
            gpBoxEncerrarAluguel.Controls.Add(labelCliente);
            gpBoxEncerrarAluguel.Controls.Add(txtCliente);
            gpBoxEncerrarAluguel.Controls.Add(labelTema);
            gpBoxEncerrarAluguel.Controls.Add(txtDebito);
            gpBoxEncerrarAluguel.Controls.Add(txtTema);
            gpBoxEncerrarAluguel.Controls.Add(labelDebito);
            gpBoxEncerrarAluguel.Controls.Add(lblId);
            gpBoxEncerrarAluguel.Controls.Add(txtValorEntrada);
            gpBoxEncerrarAluguel.Controls.Add(labelValorEntrada);
            gpBoxEncerrarAluguel.Location = new Point(12, 12);
            gpBoxEncerrarAluguel.Name = "gpBoxEncerrarAluguel";
            gpBoxEncerrarAluguel.Size = new Size(390, 194);
            gpBoxEncerrarAluguel.TabIndex = 53;
            gpBoxEncerrarAluguel.TabStop = false;
            gpBoxEncerrarAluguel.Text = "Encerrar";
            // 
            // TelaEncerrarAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 267);
            Controls.Add(btnCancelar);
            Controls.Add(btnEncerrar);
            Controls.Add(gpBoxEncerrarAluguel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaEncerrarAluguelForm";
            ShowIcon = false;
            Text = "Encerrar aluguel";
            gpBoxEncerrarAluguel.ResumeLayout(false);
            gpBoxEncerrarAluguel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox txtValorTotal;
        private Label labelValorTotal;
        private Button btnCancelar;
        private Button btnEncerrar;
        private ComboBox txtDebito;
        private Label labelDebito;
        private ComboBox txtValorEntrada;
        private Label labelValorEntrada;
        private TextBox txtId;
        private Label lblId;
        private ComboBox txtTema;
        private Label labelTema;
        private ComboBox txtCliente;
        private Label labelCliente;
        private GroupBox gpBoxEncerrarAluguel;
    }
}