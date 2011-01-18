namespace KortyTenisowe
{
    partial class DodajZawodnikaDoTurniejuForm
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
            this.rDDLTurniej = new Telerik.WinControls.UI.RadDropDownList();
            this.rDDLZawodnik = new Telerik.WinControls.UI.RadDropDownList();
            this.rbtOK = new Telerik.WinControls.UI.RadButton();
            this.rbtAnuluj = new Telerik.WinControls.UI.RadButton();
            this.rlbTurniej = new Telerik.WinControls.UI.RadLabel();
            this.rlbZawodnik = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLTurniej)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLZawodnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtAnuluj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbTurniej)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbZawodnik)).BeginInit();
            this.SuspendLayout();
            // 
            // rDDLTurniej
            // 
            this.rDDLTurniej.Location = new System.Drawing.Point(75, 12);
            this.rDDLTurniej.Name = "rDDLTurniej";
            this.rDDLTurniej.ShowImageInEditorArea = true;
            this.rDDLTurniej.Size = new System.Drawing.Size(250, 21);
            this.rDDLTurniej.TabIndex = 0;
            this.rDDLTurniej.Text = "Turniej";
            // 
            // rDDLZawodnik
            // 
            this.rDDLZawodnik.Location = new System.Drawing.Point(75, 58);
            this.rDDLZawodnik.Name = "rDDLZawodnik";
            this.rDDLZawodnik.ShowImageInEditorArea = true;
            this.rDDLZawodnik.Size = new System.Drawing.Size(250, 21);
            this.rDDLZawodnik.TabIndex = 1;
            this.rDDLZawodnik.Text = "Zawodnik";
            // 
            // rbtOK
            // 
            this.rbtOK.Location = new System.Drawing.Point(12, 119);
            this.rbtOK.Name = "rbtOK";
            this.rbtOK.Size = new System.Drawing.Size(148, 24);
            this.rbtOK.TabIndex = 2;
            this.rbtOK.Text = "OK";
            this.rbtOK.Click += new System.EventHandler(this.rbtOK_Click);
            // 
            // rbtAnuluj
            // 
            this.rbtAnuluj.Location = new System.Drawing.Point(179, 119);
            this.rbtAnuluj.Name = "rbtAnuluj";
            this.rbtAnuluj.Size = new System.Drawing.Size(146, 24);
            this.rbtAnuluj.TabIndex = 3;
            this.rbtAnuluj.Text = "Anuluj";
            this.rbtAnuluj.Click += new System.EventHandler(this.rbtAnuluj_Click);
            // 
            // rlbTurniej
            // 
            this.rlbTurniej.Location = new System.Drawing.Point(12, 12);
            this.rlbTurniej.Name = "rlbTurniej";
            this.rlbTurniej.Size = new System.Drawing.Size(44, 16);
            this.rlbTurniej.TabIndex = 5;
            this.rlbTurniej.Text = "Turniej:";
            // 
            // rlbZawodnik
            // 
            this.rlbZawodnik.Location = new System.Drawing.Point(12, 58);
            this.rlbZawodnik.Name = "rlbZawodnik";
            this.rlbZawodnik.Size = new System.Drawing.Size(55, 16);
            this.rlbZawodnik.TabIndex = 6;
            this.rlbZawodnik.Text = "Zawodnik";
            // 
            // DodajZawodnikaDoTurniejuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 170);
            this.Controls.Add(this.rlbZawodnik);
            this.Controls.Add(this.rlbTurniej);
            this.Controls.Add(this.rbtAnuluj);
            this.Controls.Add(this.rbtOK);
            this.Controls.Add(this.rDDLZawodnik);
            this.Controls.Add(this.rDDLTurniej);
            this.Name = "DodajZawodnikaDoTurniejuForm";
            this.Text = "Dodaj zawodnika do turnieju";
            ((System.ComponentModel.ISupportInitialize)(this.rDDLTurniej)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLZawodnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtAnuluj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbTurniej)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbZawodnik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList rDDLTurniej;
        private Telerik.WinControls.UI.RadDropDownList rDDLZawodnik;
        private Telerik.WinControls.UI.RadButton rbtOK;
        private Telerik.WinControls.UI.RadButton rbtAnuluj;
        private Telerik.WinControls.UI.RadLabel rlbTurniej;
        private Telerik.WinControls.UI.RadLabel rlbZawodnik;
    }
}