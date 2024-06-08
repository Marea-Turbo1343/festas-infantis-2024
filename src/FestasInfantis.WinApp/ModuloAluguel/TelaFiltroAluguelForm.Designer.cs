namespace FestasInfantis.WinApp.ModuloAluguel
{
    partial class TelaFiltroAluguelForm
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
            gpBoxFiltro = new GroupBox();
            radiobtnTodos = new RadioButton();
            radiobtnFuturo = new RadioButton();
            radiobtnPassados = new RadioButton();
            cboxVisualizarPorData = new CheckBox();
            groupBoxDatas = new GroupBox();
            txtDataInicial = new DateTimePicker();
            labelDataInicial = new Label();
            txtDataFinal = new DateTimePicker();
            labelDataFinal = new Label();
            btnCancelar = new Button();
            btnFiltrar = new Button();
            lblFiltroData = new Label();
            gpBoxFiltro.SuspendLayout();
            groupBoxDatas.SuspendLayout();
            SuspendLayout();
            // 
            // gpBoxFiltro
            // 
            gpBoxFiltro.Controls.Add(radiobtnTodos);
            gpBoxFiltro.Controls.Add(radiobtnFuturo);
            gpBoxFiltro.Controls.Add(radiobtnPassados);
            gpBoxFiltro.Location = new Point(15, 17);
            gpBoxFiltro.Name = "gpBoxFiltro";
            gpBoxFiltro.Size = new Size(171, 105);
            gpBoxFiltro.TabIndex = 19;
            gpBoxFiltro.TabStop = false;
            gpBoxFiltro.Text = "Filtro";
            // 
            // radiobtnTodos
            // 
            radiobtnTodos.AutoSize = true;
            radiobtnTodos.Location = new Point(6, 22);
            radiobtnTodos.Name = "radiobtnTodos";
            radiobtnTodos.Size = new Size(120, 19);
            radiobtnTodos.TabIndex = 4;
            radiobtnTodos.TabStop = true;
            radiobtnTodos.Text = "Todos os Aluguéis";
            radiobtnTodos.UseVisualStyleBackColor = true;
            // 
            // radiobtnFuturo
            // 
            radiobtnFuturo.AutoSize = true;
            radiobtnFuturo.Location = new Point(6, 47);
            radiobtnFuturo.Name = "radiobtnFuturo";
            radiobtnFuturo.Size = new Size(130, 19);
            radiobtnFuturo.TabIndex = 3;
            radiobtnFuturo.TabStop = true;
            radiobtnFuturo.Text = "Aluguéis em Aberto";
            radiobtnFuturo.UseVisualStyleBackColor = true;
            // 
            // radiobtnPassados
            // 
            radiobtnPassados.AutoSize = true;
            radiobtnPassados.Location = new Point(6, 72);
            radiobtnPassados.Name = "radiobtnPassados";
            radiobtnPassados.Size = new Size(134, 19);
            radiobtnPassados.TabIndex = 2;
            radiobtnPassados.TabStop = true;
            radiobtnPassados.Text = "Aluguéis Concluídos";
            radiobtnPassados.UseVisualStyleBackColor = true;
            // 
            // cboxVisualizarPorData
            // 
            cboxVisualizarPorData.AutoSize = true;
            cboxVisualizarPorData.Location = new Point(151, 135);
            cboxVisualizarPorData.Name = "cboxVisualizarPorData";
            cboxVisualizarPorData.Size = new Size(15, 14);
            cboxVisualizarPorData.TabIndex = 17;
            cboxVisualizarPorData.UseVisualStyleBackColor = true;
            // 
            // groupBoxDatas
            // 
            groupBoxDatas.Controls.Add(txtDataInicial);
            groupBoxDatas.Controls.Add(labelDataInicial);
            groupBoxDatas.Controls.Add(txtDataFinal);
            groupBoxDatas.Controls.Add(labelDataFinal);
            groupBoxDatas.Location = new Point(15, 156);
            groupBoxDatas.Name = "groupBoxDatas";
            groupBoxDatas.Size = new Size(171, 112);
            groupBoxDatas.TabIndex = 18;
            groupBoxDatas.TabStop = false;
            groupBoxDatas.Text = "Filtro por Data";
            // 
            // txtDataInicial
            // 
            txtDataInicial.CustomFormat = "dd/MM/yyyy";
            txtDataInicial.Format = DateTimePickerFormat.Custom;
            txtDataInicial.Location = new Point(6, 37);
            txtDataInicial.Name = "txtDataInicial";
            txtDataInicial.Size = new Size(95, 23);
            txtDataInicial.TabIndex = 10;
            // 
            // labelDataInicial
            // 
            labelDataInicial.AutoSize = true;
            labelDataInicial.Location = new Point(6, 19);
            labelDataInicial.Name = "labelDataInicial";
            labelDataInicial.Size = new Size(68, 15);
            labelDataInicial.TabIndex = 8;
            labelDataInicial.Text = "Data Inicial:";
            // 
            // txtDataFinal
            // 
            txtDataFinal.CustomFormat = "dd/MM/yyyy";
            txtDataFinal.Format = DateTimePickerFormat.Custom;
            txtDataFinal.Location = new Point(6, 81);
            txtDataFinal.Name = "txtDataFinal";
            txtDataFinal.Size = new Size(95, 23);
            txtDataFinal.TabIndex = 11;
            // 
            // labelDataFinal
            // 
            labelDataFinal.AutoSize = true;
            labelDataFinal.Location = new Point(6, 63);
            labelDataFinal.Name = "labelDataFinal";
            labelDataFinal.Size = new Size(62, 15);
            labelDataFinal.TabIndex = 9;
            labelDataFinal.Text = "Data Final:";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(120, 274);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(66, 35);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            btnFiltrar.DialogResult = DialogResult.OK;
            btnFiltrar.Location = new Point(49, 274);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(65, 35);
            btnFiltrar.TabIndex = 15;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // lblFiltroData
            // 
            lblFiltroData.AutoSize = true;
            lblFiltroData.Location = new Point(21, 134);
            lblFiltroData.Name = "lblFiltroData";
            lblFiltroData.Size = new Size(124, 15);
            lblFiltroData.TabIndex = 20;
            lblFiltroData.Text = "Deseja filtrar por data?";
            // 
            // TelaFiltroAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(200, 319);
            Controls.Add(lblFiltroData);
            Controls.Add(gpBoxFiltro);
            Controls.Add(cboxVisualizarPorData);
            Controls.Add(groupBoxDatas);
            Controls.Add(btnCancelar);
            Controls.Add(btnFiltrar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFiltroAluguelForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filtrar aluguéis";
            gpBoxFiltro.ResumeLayout(false);
            gpBoxFiltro.PerformLayout();
            groupBoxDatas.ResumeLayout(false);
            groupBoxDatas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gpBoxFiltro;
        private RadioButton radiobtnTodos;
        private RadioButton radiobtnFuturo;
        private RadioButton radiobtnPassados;
        private CheckBox cboxVisualizarPorData;
        private GroupBox groupBoxDatas;
        private DateTimePicker txtDataInicial;
        private Label labelDataInicial;
        private DateTimePicker txtDataFinal;
        private Label labelDataFinal;
        private Button btnCancelar;
        private Button btnFiltrar;
        private Label lblFiltroData;
    }
}