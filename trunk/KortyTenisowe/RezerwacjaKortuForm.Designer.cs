namespace KortyTenisowe
{
    partial class RezerwacjaKortuForm
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
            this.components = new System.ComponentModel.Container();
            this.lData = new System.Windows.Forms.Label();
            this.rbJednorazowa = new System.Windows.Forms.RadioButton();
            this.rbStala = new System.Windows.Forms.RadioButton();
            this.lbIloscGodzin = new System.Windows.Forms.Label();
            this.cbIloscGodzin = new System.Windows.Forms.ComboBox();
            this.cbKlienci = new System.Windows.Forms.ComboBox();
            this.lnKlient = new System.Windows.Forms.Label();
            this.btDodajKlienta = new System.Windows.Forms.Button();
            this.btRezerwuj = new System.Windows.Forms.Button();
            this.inzynierka1EntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inzynierka1EntitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lData
            // 
            this.lData.AutoSize = true;
            this.lData.Location = new System.Drawing.Point(23, 19);
            this.lData.Name = "lData";
            this.lData.Size = new System.Drawing.Size(112, 13);
            this.lData.TabIndex = 0;
            this.lData.Text = "Rezerwacja na dzien: ";
            // 
            // rbJednorazowa
            // 
            this.rbJednorazowa.AutoSize = true;
            this.rbJednorazowa.Location = new System.Drawing.Point(26, 53);
            this.rbJednorazowa.Name = "rbJednorazowa";
            this.rbJednorazowa.Size = new System.Drawing.Size(88, 17);
            this.rbJednorazowa.TabIndex = 1;
            this.rbJednorazowa.TabStop = true;
            this.rbJednorazowa.Text = "Jednorazowa";
            this.rbJednorazowa.UseVisualStyleBackColor = true;
            // 
            // rbStala
            // 
            this.rbStala.AutoSize = true;
            this.rbStala.Location = new System.Drawing.Point(132, 53);
            this.rbStala.Name = "rbStala";
            this.rbStala.Size = new System.Drawing.Size(51, 17);
            this.rbStala.TabIndex = 2;
            this.rbStala.TabStop = true;
            this.rbStala.Text = "Stała";
            this.rbStala.UseVisualStyleBackColor = true;
            // 
            // lbIloscGodzin
            // 
            this.lbIloscGodzin.AutoSize = true;
            this.lbIloscGodzin.Location = new System.Drawing.Point(23, 89);
            this.lbIloscGodzin.Name = "lbIloscGodzin";
            this.lbIloscGodzin.Size = new System.Drawing.Size(63, 13);
            this.lbIloscGodzin.TabIndex = 4;
            this.lbIloscGodzin.Text = "Ilość godzin";
            // 
            // cbIloscGodzin
            // 
            this.cbIloscGodzin.FormattingEnabled = true;
            this.cbIloscGodzin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbIloscGodzin.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbIloscGodzin.Location = new System.Drawing.Point(132, 89);
            this.cbIloscGodzin.Name = "cbIloscGodzin";
            this.cbIloscGodzin.Size = new System.Drawing.Size(121, 21);
            this.cbIloscGodzin.TabIndex = 6;
            // 
            // cbKlienci
            // 
            this.cbKlienci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKlienci.FormattingEnabled = true;
            this.cbKlienci.Location = new System.Drawing.Point(87, 131);
            this.cbKlienci.Name = "cbKlienci";
            this.cbKlienci.Size = new System.Drawing.Size(166, 21);
            this.cbKlienci.TabIndex = 7;
            // 
            // lnKlient
            // 
            this.lnKlient.AutoSize = true;
            this.lnKlient.Location = new System.Drawing.Point(23, 136);
            this.lnKlient.Name = "lnKlient";
            this.lnKlient.Size = new System.Drawing.Size(33, 13);
            this.lnKlient.TabIndex = 8;
            this.lnKlient.Text = "Klient";
            // 
            // btDodajKlienta
            // 
            this.btDodajKlienta.Location = new System.Drawing.Point(259, 129);
            this.btDodajKlienta.Name = "btDodajKlienta";
            this.btDodajKlienta.Size = new System.Drawing.Size(135, 23);
            this.btDodajKlienta.TabIndex = 9;
            this.btDodajKlienta.Text = "Dodaj nowego klienta";
            this.btDodajKlienta.UseVisualStyleBackColor = true;
            this.btDodajKlienta.Click += new System.EventHandler(this.btDodajKlienta_Click);
            // 
            // btRezerwuj
            // 
            this.btRezerwuj.Location = new System.Drawing.Point(178, 199);
            this.btRezerwuj.Name = "btRezerwuj";
            this.btRezerwuj.Size = new System.Drawing.Size(75, 23);
            this.btRezerwuj.TabIndex = 10;
            this.btRezerwuj.Text = "Rezerwuj";
            this.btRezerwuj.UseVisualStyleBackColor = true;
            this.btRezerwuj.Click += new System.EventHandler(this.btRezerwuj_Click);
            // 
            // inzynierka1EntitiesBindingSource
            // 
            this.inzynierka1EntitiesBindingSource.DataSource = typeof(KortyTenisowe.Inzynierka1Entities);
            // 
            // RezerwacjaKortuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 248);
            this.Controls.Add(this.btRezerwuj);
            this.Controls.Add(this.btDodajKlienta);
            this.Controls.Add(this.lnKlient);
            this.Controls.Add(this.cbKlienci);
            this.Controls.Add(this.cbIloscGodzin);
            this.Controls.Add(this.lbIloscGodzin);
            this.Controls.Add(this.rbStala);
            this.Controls.Add(this.rbJednorazowa);
            this.Controls.Add(this.lData);
            this.Name = "RezerwacjaKortuForm";
            this.Text = "RezerwacjaKortuForm";
            ((System.ComponentModel.ISupportInitialize)(this.inzynierka1EntitiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lData;
        private System.Windows.Forms.RadioButton rbJednorazowa;
        private System.Windows.Forms.RadioButton rbStala;
        private System.Windows.Forms.Label lbIloscGodzin;
        private System.Windows.Forms.ComboBox cbIloscGodzin;
        private System.Windows.Forms.ComboBox cbKlienci;
        private System.Windows.Forms.Label lnKlient;
        private System.Windows.Forms.Button btDodajKlienta;
        private System.Windows.Forms.Button btRezerwuj;
        private System.Windows.Forms.BindingSource inzynierka1EntitiesBindingSource;
    }
}