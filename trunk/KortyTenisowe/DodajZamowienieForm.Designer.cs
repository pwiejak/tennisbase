namespace KortyTenisowe
{
    partial class DodajZamowienieForm
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
            this.rlbPrzyjeto = new Telerik.WinControls.UI.RadLabel();
            this.rlbKlient = new Telerik.WinControls.UI.RadLabel();
            this.rlbUsluga = new Telerik.WinControls.UI.RadLabel();
            this.rDDLKlient = new Telerik.WinControls.UI.RadDropDownList();
            this.rDDLUsluga = new Telerik.WinControls.UI.RadDropDownList();
            this.rDTPDataPrzyj = new Telerik.WinControls.UI.RadDateTimePicker();
            this.rbtOK = new Telerik.WinControls.UI.RadButton();
            this.rbtAnuluj = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rlbPrzyjeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbKlient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbUsluga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLKlient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLUsluga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDTPDataPrzyj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtAnuluj)).BeginInit();
            this.SuspendLayout();
            // 
            // rlbPrzyjeto
            // 
            this.rlbPrzyjeto.Location = new System.Drawing.Point(12, 12);
            this.rlbPrzyjeto.Name = "rlbPrzyjeto";
            this.rlbPrzyjeto.Size = new System.Drawing.Size(50, 16);
            this.rlbPrzyjeto.TabIndex = 0;
            this.rlbPrzyjeto.Text = "Przyjęto:";
            // 
            // rlbKlient
            // 
            this.rlbKlient.Location = new System.Drawing.Point(12, 51);
            this.rlbKlient.Name = "rlbKlient";
            this.rlbKlient.Size = new System.Drawing.Size(38, 16);
            this.rlbKlient.TabIndex = 1;
            this.rlbKlient.Text = "Klient:";
            // 
            // rlbUsluga
            // 
            this.rlbUsluga.Location = new System.Drawing.Point(12, 88);
            this.rlbUsluga.Name = "rlbUsluga";
            this.rlbUsluga.Size = new System.Drawing.Size(45, 16);
            this.rlbUsluga.TabIndex = 1;
            this.rlbUsluga.Text = "Usluga:";
            // 
            // rDDLKlient
            // 
            this.rDDLKlient.Location = new System.Drawing.Point(103, 51);
            this.rDDLKlient.Name = "rDDLKlient";
            this.rDDLKlient.ShowImageInEditorArea = true;
            this.rDDLKlient.Size = new System.Drawing.Size(185, 21);
            this.rDDLKlient.TabIndex = 2;
            // 
            // rDDLUsluga
            // 
            this.rDDLUsluga.Location = new System.Drawing.Point(103, 88);
            this.rDDLUsluga.Name = "rDDLUsluga";
            this.rDDLUsluga.ShowImageInEditorArea = true;
            this.rDDLUsluga.Size = new System.Drawing.Size(185, 21);
            this.rDDLUsluga.TabIndex = 3;
            // 
            // rDTPDataPrzyj
            // 
            this.rDTPDataPrzyj.Culture = new System.Globalization.CultureInfo("pl-PL");
            this.rDTPDataPrzyj.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.rDTPDataPrzyj.Location = new System.Drawing.Point(103, 12);
            this.rDTPDataPrzyj.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.rDTPDataPrzyj.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.rDTPDataPrzyj.Name = "rDTPDataPrzyj";
            this.rDTPDataPrzyj.NullDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.rDTPDataPrzyj.Size = new System.Drawing.Size(185, 20);
            this.rDTPDataPrzyj.TabIndex = 4;
            this.rDTPDataPrzyj.TabStop = false;
            this.rDTPDataPrzyj.Value = new System.DateTime(2011, 1, 18, 15, 9, 16, 115);
            // 
            // rbtOK
            // 
            this.rbtOK.Location = new System.Drawing.Point(12, 140);
            this.rbtOK.Name = "rbtOK";
            this.rbtOK.Size = new System.Drawing.Size(130, 24);
            this.rbtOK.TabIndex = 5;
            this.rbtOK.Text = "OK";
            this.rbtOK.Click += new System.EventHandler(this.rbtOK_Click);
            // 
            // rbtAnuluj
            // 
            this.rbtAnuluj.Location = new System.Drawing.Point(158, 140);
            this.rbtAnuluj.Name = "rbtAnuluj";
            this.rbtAnuluj.Size = new System.Drawing.Size(130, 24);
            this.rbtAnuluj.TabIndex = 6;
            this.rbtAnuluj.Text = "Anuluj";
            this.rbtAnuluj.Click += new System.EventHandler(this.rbtAnuluj_Click);
            // 
            // DodajZamowienieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 185);
            this.Controls.Add(this.rbtAnuluj);
            this.Controls.Add(this.rbtOK);
            this.Controls.Add(this.rDTPDataPrzyj);
            this.Controls.Add(this.rDDLUsluga);
            this.Controls.Add(this.rDDLKlient);
            this.Controls.Add(this.rlbKlient);
            this.Controls.Add(this.rlbUsluga);
            this.Controls.Add(this.rlbPrzyjeto);
            this.Name = "DodajZamowienieForm";
            this.Text = "Dodaj zamowienie";
            ((System.ComponentModel.ISupportInitialize)(this.rlbPrzyjeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbKlient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbUsluga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLKlient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLUsluga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDTPDataPrzyj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtAnuluj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel rlbPrzyjeto;
        private Telerik.WinControls.UI.RadLabel rlbKlient;
        private Telerik.WinControls.UI.RadLabel rlbUsluga;
        private Telerik.WinControls.UI.RadDropDownList rDDLKlient;
        private Telerik.WinControls.UI.RadDropDownList rDDLUsluga;
        private Telerik.WinControls.UI.RadDateTimePicker rDTPDataPrzyj;
        private Telerik.WinControls.UI.RadButton rbtOK;
        private Telerik.WinControls.UI.RadButton rbtAnuluj;
    }
}