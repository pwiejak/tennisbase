namespace KortyTenisowe
{
    partial class DodajKlasyfikacjeForm
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
            this.rlbTurniej = new Telerik.WinControls.UI.RadLabel();
            this.rlbMiejsce = new Telerik.WinControls.UI.RadLabel();
            this.rlbZawodnik = new Telerik.WinControls.UI.RadLabel();
            this.rlbPunkty = new Telerik.WinControls.UI.RadLabel();
            this.rDDLTurniej = new Telerik.WinControls.UI.RadDropDownList();
            this.rDDLZawodnik = new Telerik.WinControls.UI.RadDropDownList();
            this.rtbMiejsce = new Telerik.WinControls.UI.RadTextBox();
            this.rtbPunkty = new Telerik.WinControls.UI.RadTextBox();
            this.rbtOK = new Telerik.WinControls.UI.RadButton();
            this.rbtAnuluj = new Telerik.WinControls.UI.RadButton();
            this.rcbCzyGeneralna = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.rlbTurniej)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbMiejsce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbZawodnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbPunkty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLTurniej)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLZawodnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbMiejsce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbPunkty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtAnuluj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbCzyGeneralna)).BeginInit();
            this.SuspendLayout();
            // 
            // rlbTurniej
            // 
            this.rlbTurniej.Location = new System.Drawing.Point(12, 12);
            this.rlbTurniej.Name = "rlbTurniej";
            this.rlbTurniej.Size = new System.Drawing.Size(44, 16);
            this.rlbTurniej.TabIndex = 0;
            this.rlbTurniej.Text = "Turniej:";
            // 
            // rlbMiejsce
            // 
            this.rlbMiejsce.Location = new System.Drawing.Point(12, 44);
            this.rlbMiejsce.Name = "rlbMiejsce";
            this.rlbMiejsce.Size = new System.Drawing.Size(48, 16);
            this.rlbMiejsce.TabIndex = 1;
            this.rlbMiejsce.Text = "Miejsce:";
            // 
            // rlbZawodnik
            // 
            this.rlbZawodnik.Location = new System.Drawing.Point(12, 78);
            this.rlbZawodnik.Name = "rlbZawodnik";
            this.rlbZawodnik.Size = new System.Drawing.Size(58, 16);
            this.rlbZawodnik.TabIndex = 1;
            this.rlbZawodnik.Text = "Zawodnik:";
            // 
            // rlbPunkty
            // 
            this.rlbPunkty.Location = new System.Drawing.Point(12, 114);
            this.rlbPunkty.Name = "rlbPunkty";
            this.rlbPunkty.Size = new System.Drawing.Size(44, 16);
            this.rlbPunkty.TabIndex = 1;
            this.rlbPunkty.Text = "Punkty:";
            // 
            // rDDLTurniej
            // 
            this.rDDLTurniej.Location = new System.Drawing.Point(97, 12);
            this.rDDLTurniej.Name = "rDDLTurniej";
            this.rDDLTurniej.Size = new System.Drawing.Size(195, 22);
            this.rDDLTurniej.TabIndex = 1;
            this.rDDLTurniej.Text = "Turniej";
            // 
            // rDDLZawodnik
            // 
            this.rDDLZawodnik.Location = new System.Drawing.Point(97, 78);
            this.rDDLZawodnik.Name = "rDDLZawodnik";
            this.rDDLZawodnik.Size = new System.Drawing.Size(195, 22);
            this.rDDLZawodnik.TabIndex = 2;
            this.rDDLZawodnik.Text = "Zawodnik";
            // 
            // rtbMiejsce
            // 
            this.rtbMiejsce.Location = new System.Drawing.Point(97, 44);
            this.rtbMiejsce.Name = "rtbMiejsce";
            this.rtbMiejsce.Size = new System.Drawing.Size(195, 20);
            this.rtbMiejsce.TabIndex = 3;
            this.rtbMiejsce.TabStop = false;
            // 
            // rtbPunkty
            // 
            this.rtbPunkty.Location = new System.Drawing.Point(97, 114);
            this.rtbPunkty.Name = "rtbPunkty";
            this.rtbPunkty.Size = new System.Drawing.Size(195, 20);
            this.rtbPunkty.TabIndex = 2;
            this.rtbPunkty.TabStop = false;
            // 
            // rbtOK
            // 
            this.rbtOK.Location = new System.Drawing.Point(12, 204);
            this.rbtOK.Name = "rbtOK";
            this.rbtOK.Size = new System.Drawing.Size(137, 24);
            this.rbtOK.TabIndex = 4;
            this.rbtOK.Text = "OK";
            // 
            // rbtAnuluj
            // 
            this.rbtAnuluj.Location = new System.Drawing.Point(155, 204);
            this.rbtAnuluj.Name = "rbtAnuluj";
            this.rbtAnuluj.Size = new System.Drawing.Size(137, 24);
            this.rbtAnuluj.TabIndex = 5;
            this.rbtAnuluj.Text = "Anuluj";
            this.rbtAnuluj.Click += new System.EventHandler(this.rbtAnuluj_Click);
            // 
            // rcbCzyGeneralna
            // 
            this.rcbCzyGeneralna.Location = new System.Drawing.Point(12, 158);
            this.rcbCzyGeneralna.Name = "rcbCzyGeneralna";
            this.rcbCzyGeneralna.Size = new System.Drawing.Size(220, 18);
            this.rcbCzyGeneralna.TabIndex = 6;
            this.rcbCzyGeneralna.Text = "Turniej liczony do klasyfikacji generalnej";
            // 
            // DodajKlasyfikacjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(306, 244);
            this.Controls.Add(this.rcbCzyGeneralna);
            this.Controls.Add(this.rbtAnuluj);
            this.Controls.Add(this.rbtOK);
            this.Controls.Add(this.rlbPunkty);
            this.Controls.Add(this.rlbZawodnik);
            this.Controls.Add(this.rlbMiejsce);
            this.Controls.Add(this.rtbPunkty);
            this.Controls.Add(this.rtbMiejsce);
            this.Controls.Add(this.rDDLZawodnik);
            this.Controls.Add(this.rDDLTurniej);
            this.Controls.Add(this.rlbTurniej);
            this.Name = "DodajKlasyfikacjeForm";
            this.Text = "Dodaj klasyfikację";
            ((System.ComponentModel.ISupportInitialize)(this.rlbTurniej)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbMiejsce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbZawodnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbPunkty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLTurniej)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLZawodnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbMiejsce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbPunkty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtAnuluj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbCzyGeneralna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel rlbTurniej;
        private Telerik.WinControls.UI.RadLabel rlbMiejsce;
        private Telerik.WinControls.UI.RadLabel rlbZawodnik;
        private Telerik.WinControls.UI.RadLabel rlbPunkty;
        private Telerik.WinControls.UI.RadDropDownList rDDLTurniej;
        private Telerik.WinControls.UI.RadDropDownList rDDLZawodnik;
        private Telerik.WinControls.UI.RadTextBox rtbMiejsce;
        private Telerik.WinControls.UI.RadTextBox rtbPunkty;
        private Telerik.WinControls.UI.RadButton rbtOK;
        private Telerik.WinControls.UI.RadButton rbtAnuluj;
        private Telerik.WinControls.UI.RadCheckBox rcbCzyGeneralna;
    }
}