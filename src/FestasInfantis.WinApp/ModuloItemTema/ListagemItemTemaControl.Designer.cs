namespace FestasInfantis.WinApp.ModuloItemTema
{
    partial class ListagemItemTemaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listItemTema = new ListBox();
            SuspendLayout();
            // 
            // listItemTema
            // 
            listItemTema.FormattingEnabled = true;
            listItemTema.ItemHeight = 15;
            listItemTema.Location = new Point(0, 0);
            listItemTema.Name = "listItemTema";
            listItemTema.Size = new Size(382, 244);
            listItemTema.TabIndex = 0;
            // 
            // ListagemItemTemaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listItemTema);
            Name = "ListagemItemTemaControl";
            Size = new Size(382, 243);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listItemTema;
    }
}
