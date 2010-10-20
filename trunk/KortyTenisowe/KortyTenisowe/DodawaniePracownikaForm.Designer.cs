namespace KortyTenisowe
{
    partial class DodawaniePracownikaForm
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
            this.tbNazwisko = new System.Windows.Forms.TextBox();
            this.tbImie = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.lbNazwisko = new System.Windows.Forms.Label();
            this.lbImie = new System.Windows.Forms.Label();
            this.lbTelefon = new System.Windows.Forms.Label();
            this.bAkceptuj = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbUprawnienia = new System.Windows.Forms.Label();
            this.rbUzytkownik = new System.Windows.Forms.RadioButton();
            this.rbAdministrator = new System.Windows.Forms.RadioButton();
            this.lbHaslo = new System.Windows.Forms.Label();
            this.tbHaslo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbNazwisko
            // 
            this.tbNazwisko.Location = new System.Drawing.Point(12, 27);
            this.tbNazwisko.Name = "tbNazwisko";
            this.tbNazwisko.Size = new System.Drawing.Size(280, 20);
            this.tbNazwisko.TabIndex = 0;
            // 
            // tbImie
            // 
            this.tbImie.Location = new System.Drawing.Point(12, 66);
            this.tbImie.Name = "tbImie";
            this.tbImie.Size = new System.Drawing.Size(280, 20);
            this.tbImie.TabIndex = 1;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(12, 105);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(280, 20);
            this.tbTelefon.TabIndex = 2;
            // 
            // lbNazwisko
            // 
            this.lbNazwisko.AutoSize = true;
            this.lbNazwisko.Location = new System.Drawing.Point(12, 11);
            this.lbNazwisko.Name = "lbNazwisko";
            this.lbNazwisko.Size = new System.Drawing.Size(53, 13);
            this.lbNazwisko.TabIndex = 3;
            this.lbNazwisko.Text = "Nazwisko";
            // 
            // lbImie
            // 
            this.lbImie.AutoSize = true;
            this.lbImie.Location = new System.Drawing.Point(12, 50);
            this.lbImie.Name = "lbImie";
            this.lbImie.Size = new System.Drawing.Size(26, 13);
            this.lbImie.TabIndex = 4;
            this.lbImie.Text = "Imie";
            // 
            // lbTelefon
            // 
            this.lbTelefon.AutoSize = true;
            this.lbTelefon.Location = new System.Drawing.Point(12, 89);
            this.lbTelefon.Name = "lbTelefon";
            this.lbTelefon.Size = new System.Drawing.Size(79, 13);
            this.lbTelefon.TabIndex = 5;
            this.lbTelefon.Text = "Numer telefonu";
            // 
            // bAkceptuj
            // 
            this.bAkceptuj.Location = new System.Drawing.Point(106, 272);
            this.bAkceptuj.Name = "bAkceptuj";
            this.bAkceptuj.Size = new System.Drawing.Size(75, 23);
            this.bAkceptuj.TabIndex = 6;
            this.bAkceptuj.Text = "Akceptuj";
            this.bAkceptuj.UseVisualStyleBackColor = true;
            this.bAkceptuj.Click += new System.EventHandler(this.bAkceptuj_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(15, 151);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(277, 20);
            this.tbLogin.TabIndex = 7;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(12, 128);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(87, 13);
            this.lbLogin.TabIndex = 8;
            this.lbLogin.Text = "Login w systemie";
            // 
            // lbUprawnienia
            // 
            this.lbUprawnienia.AutoSize = true;
            this.lbUprawnienia.Location = new System.Drawing.Point(12, 183);
            this.lbUprawnienia.Name = "lbUprawnienia";
            this.lbUprawnienia.Size = new System.Drawing.Size(98, 13);
            this.lbUprawnienia.TabIndex = 9;
            this.lbUprawnienia.Text = "Poziom Uprawnień:";
            // 
            // rbUzytkownik
            // 
            this.rbUzytkownik.AutoSize = true;
            this.rbUzytkownik.Location = new System.Drawing.Point(116, 181);
            this.rbUzytkownik.Name = "rbUzytkownik";
            this.rbUzytkownik.Size = new System.Drawing.Size(80, 17);
            this.rbUzytkownik.TabIndex = 10;
            this.rbUzytkownik.TabStop = true;
            this.rbUzytkownik.Text = "Użytkownik";
            this.rbUzytkownik.UseVisualStyleBackColor = true;
            // 
            // rbAdministrator
            // 
            this.rbAdministrator.AutoSize = true;
            this.rbAdministrator.Location = new System.Drawing.Point(207, 181);
            this.rbAdministrator.Name = "rbAdministrator";
            this.rbAdministrator.Size = new System.Drawing.Size(85, 17);
            this.rbAdministrator.TabIndex = 11;
            this.rbAdministrator.TabStop = true;
            this.rbAdministrator.Text = "Administrator";
            this.rbAdministrator.UseVisualStyleBackColor = true;
            // 
            // lbHaslo
            // 
            this.lbHaslo.AutoSize = true;
            this.lbHaslo.Location = new System.Drawing.Point(12, 214);
            this.lbHaslo.Name = "lbHaslo";
            this.lbHaslo.Size = new System.Drawing.Size(34, 13);
            this.lbHaslo.TabIndex = 12;
            this.lbHaslo.Text = "Haslo";
            // 
            // tbHaslo
            // 
            this.tbHaslo.Location = new System.Drawing.Point(15, 235);
            this.tbHaslo.Name = "tbHaslo";
            this.tbHaslo.Size = new System.Drawing.Size(270, 20);
            this.tbHaslo.TabIndex = 13;
            // 
            // DodawaniePracownikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 321);
            this.Controls.Add(this.tbHaslo);
            this.Controls.Add(this.lbHaslo);
            this.Controls.Add(this.rbAdministrator);
            this.Controls.Add(this.rbUzytkownik);
            this.Controls.Add(this.lbUprawnienia);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.bAkceptuj);
            this.Controls.Add(this.lbTelefon);
            this.Controls.Add(this.lbImie);
            this.Controls.Add(this.lbNazwisko);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbImie);
            this.Controls.Add(this.tbNazwisko);
            this.Name = "DodawaniePracownikaForm";
            this.Text = "Dodawanie Pracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNazwisko;
        private System.Windows.Forms.TextBox tbImie;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label lbNazwisko;
        private System.Windows.Forms.Label lbImie;
        private System.Windows.Forms.Label lbTelefon;
        private System.Windows.Forms.Button bAkceptuj;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbUprawnienia;
        private System.Windows.Forms.RadioButton rbUzytkownik;
        private System.Windows.Forms.RadioButton rbAdministrator;
        private System.Windows.Forms.Label lbHaslo;
        private System.Windows.Forms.TextBox tbHaslo;
    }
}