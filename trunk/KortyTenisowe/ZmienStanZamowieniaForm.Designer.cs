namespace KortyTenisowe
{
    partial class ZmienStanZamowieniaForm
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
            this.rlbStan = new Telerik.WinControls.UI.RadLabel();
            this.rDDLStan = new Telerik.WinControls.UI.RadDropDownList();
            this.rbtOK = new Telerik.WinControls.UI.RadButton();
            this.rbtAnuluj = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rlbStan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLStan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtAnuluj)).BeginInit();
            this.SuspendLayout();
            // 
            // rlbStan
            // 
            this.rlbStan.Location = new System.Drawing.Point(12, 22);
            this.rlbStan.Name = "rlbStan";
            this.rlbStan.Size = new System.Drawing.Size(41, 16);
            this.rlbStan.TabIndex = 0;
            this.rlbStan.Text = "Status:";
            // 
            // rDDLStan
            // 
            this.rDDLStan.Location = new System.Drawing.Point(75, 17);
            this.rDDLStan.Name = "rDDLStan";
            this.rDDLStan.ShowImageInEditorArea = true;
            this.rDDLStan.Size = new System.Drawing.Size(197, 21);
            this.rDDLStan.TabIndex = 1;
            // 
            // rbtOK
            // 
            this.rbtOK.Location = new System.Drawing.Point(12, 62);
            this.rbtOK.Name = "rbtOK";
            this.rbtOK.Size = new System.Drawing.Size(130, 24);
            this.rbtOK.TabIndex = 2;
            this.rbtOK.Text = "OK";
            this.rbtOK.Click += new System.EventHandler(this.rbtOK_Click);
            // 
            // rbtAnuluj
            // 
            this.rbtAnuluj.Location = new System.Drawing.Point(148, 62);
            this.rbtAnuluj.Name = "rbtAnuluj";
            this.rbtAnuluj.Size = new System.Drawing.Size(130, 24);
            this.rbtAnuluj.TabIndex = 3;
            this.rbtAnuluj.Text = "Anuluj";
            this.rbtAnuluj.Click += new System.EventHandler(this.rbtAnuluj_Click);
            // 
            // ZmienStanZamowieniaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 98);
            this.Controls.Add(this.rbtAnuluj);
            this.Controls.Add(this.rbtOK);
            this.Controls.Add(this.rDDLStan);
            this.Controls.Add(this.rlbStan);
            this.Name = "ZmienStanZamowieniaForm";
            this.Text = "Zmień status zamowienia";
            ((System.ComponentModel.ISupportInitialize)(this.rlbStan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLStan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtAnuluj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel rlbStan;
        private Telerik.WinControls.UI.RadDropDownList rDDLStan;
        private Telerik.WinControls.UI.RadButton rbtOK;
        private Telerik.WinControls.UI.RadButton rbtAnuluj;
    }
}