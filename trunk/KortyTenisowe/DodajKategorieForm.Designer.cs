namespace KortyTenisowe
{
    partial class DodajKategorieForm
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
            this.tbKategoria = new Telerik.WinControls.UI.RadTextBox();
            this.rbDodaj = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbKategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbDodaj)).BeginInit();
            this.SuspendLayout();
            // 
            // tbKategoria
            // 
            this.tbKategoria.Location = new System.Drawing.Point(29, 24);
            this.tbKategoria.Name = "tbKategoria";
            this.tbKategoria.Size = new System.Drawing.Size(170, 20);
            this.tbKategoria.TabIndex = 0;
            this.tbKategoria.TabStop = false;
            this.tbKategoria.Text = "Nazwa kategorii";
            // 
            // rbDodaj
            // 
            this.rbDodaj.Location = new System.Drawing.Point(47, 61);
            this.rbDodaj.Name = "rbDodaj";
            this.rbDodaj.Size = new System.Drawing.Size(130, 24);
            this.rbDodaj.TabIndex = 1;
            this.rbDodaj.Text = "Dodaj kategorię";
            this.rbDodaj.Click += new System.EventHandler(this.rbDodaj_Click);
            // 
            // DodajKategorieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 119);
            this.Controls.Add(this.rbDodaj);
            this.Controls.Add(this.tbKategoria);
            this.Name = "DodajKategorieForm";
            this.Text = "DodajKategorieForm";
            ((System.ComponentModel.ISupportInitialize)(this.tbKategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbDodaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox tbKategoria;
        private Telerik.WinControls.UI.RadButton rbDodaj;
    }
}