namespace KortyTenisowe
{
    partial class DodajKlientaForm
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
            this.rbUzytkownik = new System.Windows.Forms.RadioButton();
            this.rbTrener = new System.Windows.Forms.RadioButton();
            this.lbNazwisko = new System.Windows.Forms.Label();
            this.lbImie = new System.Windows.Forms.Label();
            this.lbTelefon = new System.Windows.Forms.Label();
            this.tbNazwisko = new System.Windows.Forms.TextBox();
            this.tbImie = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.btDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbUzytkownik
            // 
            this.rbUzytkownik.AutoSize = true;
            this.rbUzytkownik.Location = new System.Drawing.Point(22, 32);
            this.rbUzytkownik.Name = "rbUzytkownik";
            this.rbUzytkownik.Size = new System.Drawing.Size(80, 17);
            this.rbUzytkownik.TabIndex = 0;
            this.rbUzytkownik.TabStop = true;
            this.rbUzytkownik.Text = "Uzytkownik";
            this.rbUzytkownik.UseVisualStyleBackColor = true;
            // 
            // rbTrener
            // 
            this.rbTrener.AutoSize = true;
            this.rbTrener.Location = new System.Drawing.Point(108, 32);
            this.rbTrener.Name = "rbTrener";
            this.rbTrener.Size = new System.Drawing.Size(56, 17);
            this.rbTrener.TabIndex = 1;
            this.rbTrener.TabStop = true;
            this.rbTrener.Text = "Trener";
            this.rbTrener.UseVisualStyleBackColor = true;
            // 
            // lbNazwisko
            // 
            this.lbNazwisko.AutoSize = true;
            this.lbNazwisko.Location = new System.Drawing.Point(19, 68);
            this.lbNazwisko.Name = "lbNazwisko";
            this.lbNazwisko.Size = new System.Drawing.Size(53, 13);
            this.lbNazwisko.TabIndex = 2;
            this.lbNazwisko.Text = "Nazwisko";
            // 
            // lbImie
            // 
            this.lbImie.AutoSize = true;
            this.lbImie.Location = new System.Drawing.Point(19, 92);
            this.lbImie.Name = "lbImie";
            this.lbImie.Size = new System.Drawing.Size(26, 13);
            this.lbImie.TabIndex = 3;
            this.lbImie.Text = "Imie";
            // 
            // lbTelefon
            // 
            this.lbTelefon.AutoSize = true;
            this.lbTelefon.Location = new System.Drawing.Point(19, 114);
            this.lbTelefon.Name = "lbTelefon";
            this.lbTelefon.Size = new System.Drawing.Size(59, 13);
            this.lbTelefon.TabIndex = 4;
            this.lbTelefon.Text = "Nr telefonu";
            // 
            // tbNazwisko
            // 
            this.tbNazwisko.Location = new System.Drawing.Point(108, 65);
            this.tbNazwisko.Name = "tbNazwisko";
            this.tbNazwisko.Size = new System.Drawing.Size(160, 20);
            this.tbNazwisko.TabIndex = 5;
            // 
            // tbImie
            // 
            this.tbImie.Location = new System.Drawing.Point(108, 89);
            this.tbImie.Name = "tbImie";
            this.tbImie.Size = new System.Drawing.Size(160, 20);
            this.tbImie.TabIndex = 6;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(108, 111);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(160, 20);
            this.tbTelefon.TabIndex = 7;
            // 
            // btDodaj
            // 
            this.btDodaj.Location = new System.Drawing.Point(108, 148);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(75, 23);
            this.btDodaj.TabIndex = 8;
            this.btDodaj.Text = "Dodaj";
            this.btDodaj.UseVisualStyleBackColor = true;
            this.btDodaj.Click += new System.EventHandler(this.btDodaj_Click);
            // 
            // DodajKlientaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 200);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbImie);
            this.Controls.Add(this.tbNazwisko);
            this.Controls.Add(this.lbTelefon);
            this.Controls.Add(this.lbImie);
            this.Controls.Add(this.lbNazwisko);
            this.Controls.Add(this.rbTrener);
            this.Controls.Add(this.rbUzytkownik);
            this.Name = "DodajKlientaForm";
            this.Text = "DodajKlientaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbUzytkownik;
        private System.Windows.Forms.RadioButton rbTrener;
        private System.Windows.Forms.Label lbNazwisko;
        private System.Windows.Forms.Label lbImie;
        private System.Windows.Forms.Label lbTelefon;
        private System.Windows.Forms.TextBox tbNazwisko;
        private System.Windows.Forms.TextBox tbImie;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Button btDodaj;
    }
}