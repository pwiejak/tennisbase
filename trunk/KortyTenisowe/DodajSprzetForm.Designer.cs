namespace KortyTenisowe
{
    partial class DodajSprzetForm
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
            this.cbKategoria = new System.Windows.Forms.ComboBox();
            this.lbMarka = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.lbOpis = new System.Windows.Forms.Label();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.rbtDodaj = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rbtDodaj)).BeginInit();
            this.SuspendLayout();
            // 
            // cbKategoria
            // 
            this.cbKategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategoria.FormattingEnabled = true;
            this.cbKategoria.Location = new System.Drawing.Point(25, 24);
            this.cbKategoria.Name = "cbKategoria";
            this.cbKategoria.Size = new System.Drawing.Size(177, 21);
            this.cbKategoria.TabIndex = 0;
            // 
            // lbMarka
            // 
            this.lbMarka.AutoSize = true;
            this.lbMarka.Location = new System.Drawing.Point(22, 65);
            this.lbMarka.Name = "lbMarka";
            this.lbMarka.Size = new System.Drawing.Size(37, 13);
            this.lbMarka.TabIndex = 1;
            this.lbMarka.Text = "Marka";
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Location = new System.Drawing.Point(22, 117);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(36, 13);
            this.lbModel.TabIndex = 2;
            this.lbModel.Text = "Model";
            // 
            // lbOpis
            // 
            this.lbOpis.AutoSize = true;
            this.lbOpis.Location = new System.Drawing.Point(22, 171);
            this.lbOpis.Name = "lbOpis";
            this.lbOpis.Size = new System.Drawing.Size(28, 13);
            this.lbOpis.TabIndex = 3;
            this.lbOpis.Text = "Opis";
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(25, 81);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(177, 20);
            this.tbMarka.TabIndex = 4;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(25, 133);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(177, 20);
            this.tbModel.TabIndex = 5;
            // 
            // tbOpis
            // 
            this.tbOpis.Location = new System.Drawing.Point(25, 187);
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.Size = new System.Drawing.Size(177, 20);
            this.tbOpis.TabIndex = 6;
            // 
            // rbtDodaj
            // 
            this.rbtDodaj.Location = new System.Drawing.Point(46, 223);
            this.rbtDodaj.Name = "rbtDodaj";
            this.rbtDodaj.Size = new System.Drawing.Size(130, 24);
            this.rbtDodaj.TabIndex = 8;
            this.rbtDodaj.Text = "Dodaj";
            this.rbtDodaj.Click += new System.EventHandler(this.rbtDodaj_Click);
            // 
            // DodajSprzetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 259);
            this.Controls.Add(this.rbtDodaj);
            this.Controls.Add(this.tbOpis);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbMarka);
            this.Controls.Add(this.lbOpis);
            this.Controls.Add(this.lbModel);
            this.Controls.Add(this.lbMarka);
            this.Controls.Add(this.cbKategoria);
            this.Name = "DodajSprzetForm";
            this.Text = "DodajSprzetForm";
            ((System.ComponentModel.ISupportInitialize)(this.rbtDodaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKategoria;
        private System.Windows.Forms.Label lbMarka;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.Label lbOpis;
        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbOpis;
        private Telerik.WinControls.UI.RadButton rbtDodaj;
    }
}