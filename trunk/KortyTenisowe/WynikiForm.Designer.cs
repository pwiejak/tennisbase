namespace KortyTenisowe
{
    partial class WynikiForm
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
            this.rlbWybierzTurniej = new Telerik.WinControls.UI.RadLabel();
            this.rlbSzukajNazwiska = new Telerik.WinControls.UI.RadLabel();
            this.rgvWyniki = new Telerik.WinControls.UI.RadGridView();
            this.rbtDodajWynik = new Telerik.WinControls.UI.RadButton();
            this.rbtEdytujWynik = new Telerik.WinControls.UI.RadButton();
            this.rbtUsunWynik = new Telerik.WinControls.UI.RadButton();
            this.rDDLWybierzTurniej = new Telerik.WinControls.UI.RadDropDownList();
            this.rtbSzukajNazwiska = new Telerik.WinControls.UI.RadTextBox();
            this.rbtSzukaj = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rlbWybierzTurniej)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbSzukajNazwiska)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvWyniki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtDodajWynik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtEdytujWynik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtUsunWynik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLWybierzTurniej)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbSzukajNazwiska)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtSzukaj)).BeginInit();
            this.SuspendLayout();
            // 
            // rlbWybierzTurniej
            // 
            this.rlbWybierzTurniej.Location = new System.Drawing.Point(12, 28);
            this.rlbWybierzTurniej.Name = "rlbWybierzTurniej";
            this.rlbWybierzTurniej.Size = new System.Drawing.Size(84, 16);
            this.rlbWybierzTurniej.TabIndex = 0;
            this.rlbWybierzTurniej.Text = "Wybierz turniej:";
            // 
            // rlbSzukajNazwiska
            // 
            this.rlbSzukajNazwiska.Location = new System.Drawing.Point(300, 28);
            this.rlbSzukajNazwiska.Name = "rlbSzukajNazwiska";
            this.rlbSzukajNazwiska.Size = new System.Drawing.Size(93, 16);
            this.rlbSzukajNazwiska.TabIndex = 1;
            this.rlbSzukajNazwiska.Text = "Szukaj nazwiska:";
            // 
            // rgvWyniki
            // 
            this.rgvWyniki.Location = new System.Drawing.Point(12, 56);
            this.rgvWyniki.Name = "rgvWyniki";
            this.rgvWyniki.ReadOnly = true;
            this.rgvWyniki.Size = new System.Drawing.Size(771, 294);
            this.rgvWyniki.TabIndex = 2;
            // 
            // rbtDodajWynik
            // 
            this.rbtDodajWynik.Location = new System.Drawing.Point(29, 356);
            this.rbtDodajWynik.Name = "rbtDodajWynik";
            this.rbtDodajWynik.Size = new System.Drawing.Size(208, 24);
            this.rbtDodajWynik.TabIndex = 3;
            this.rbtDodajWynik.Text = "Dodaj wynik";
            this.rbtDodajWynik.Click += new System.EventHandler(this.rbtDodajWynik_Click);
            // 
            // rbtEdytujWynik
            // 
            this.rbtEdytujWynik.Location = new System.Drawing.Point(300, 356);
            this.rbtEdytujWynik.Name = "rbtEdytujWynik";
            this.rbtEdytujWynik.Size = new System.Drawing.Size(208, 24);
            this.rbtEdytujWynik.TabIndex = 4;
            this.rbtEdytujWynik.Text = "Edytuj wynik";
            // 
            // rbtUsunWynik
            // 
            this.rbtUsunWynik.Location = new System.Drawing.Point(581, 356);
            this.rbtUsunWynik.Name = "rbtUsunWynik";
            this.rbtUsunWynik.Size = new System.Drawing.Size(202, 24);
            this.rbtUsunWynik.TabIndex = 4;
            this.rbtUsunWynik.Text = "Usuń wynik";
            this.rbtUsunWynik.Click += new System.EventHandler(this.rbtUsunWynik_Click);
            // 
            // rDDLWybierzTurniej
            // 
            this.rDDLWybierzTurniej.Location = new System.Drawing.Point(99, 28);
            this.rDDLWybierzTurniej.Name = "rDDLWybierzTurniej";
            this.rDDLWybierzTurniej.Size = new System.Drawing.Size(176, 22);
            this.rDDLWybierzTurniej.TabIndex = 4;
            this.rDDLWybierzTurniej.Text = "Turniej";
            // 
            // rtbSzukajNazwiska
            // 
            this.rtbSzukajNazwiska.Location = new System.Drawing.Point(396, 28);
            this.rtbSzukajNazwiska.Name = "rtbSzukajNazwiska";
            this.rtbSzukajNazwiska.Size = new System.Drawing.Size(226, 20);
            this.rtbSzukajNazwiska.TabIndex = 5;
            this.rtbSzukajNazwiska.TabStop = false;
            this.rtbSzukajNazwiska.Text = "Nazwisko";
            // 
            // rbtSzukaj
            // 
            this.rbtSzukaj.Location = new System.Drawing.Point(642, 26);
            this.rbtSzukaj.Name = "rbtSzukaj";
            this.rbtSzukaj.Size = new System.Drawing.Size(141, 22);
            this.rbtSzukaj.TabIndex = 6;
            this.rbtSzukaj.Text = "Szukaj";
            // 
            // WynikiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(795, 392);
            this.Controls.Add(this.rbtSzukaj);
            this.Controls.Add(this.rbtEdytujWynik);
            this.Controls.Add(this.rbtUsunWynik);
            this.Controls.Add(this.rtbSzukajNazwiska);
            this.Controls.Add(this.rDDLWybierzTurniej);
            this.Controls.Add(this.rbtDodajWynik);
            this.Controls.Add(this.rgvWyniki);
            this.Controls.Add(this.rlbSzukajNazwiska);
            this.Controls.Add(this.rlbWybierzTurniej);
            this.Name = "WynikiForm";
            this.Text = "Wyniki poszczególnych spotkań";
            ((System.ComponentModel.ISupportInitialize)(this.rlbWybierzTurniej)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbSzukajNazwiska)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvWyniki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtDodajWynik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtEdytujWynik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtUsunWynik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLWybierzTurniej)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbSzukajNazwiska)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtSzukaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel rlbWybierzTurniej;
        private Telerik.WinControls.UI.RadLabel rlbSzukajNazwiska;
        private Telerik.WinControls.UI.RadGridView rgvWyniki;
        private Telerik.WinControls.UI.RadButton rbtDodajWynik;
        private Telerik.WinControls.UI.RadButton rbtEdytujWynik;
        private Telerik.WinControls.UI.RadButton rbtUsunWynik;
        private Telerik.WinControls.UI.RadDropDownList rDDLWybierzTurniej;
        private Telerik.WinControls.UI.RadTextBox rtbSzukajNazwiska;
        private Telerik.WinControls.UI.RadButton rbtSzukaj;
    }
}