namespace KortyTenisowe
{
    partial class ZmienIloscForm
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
            this.rlblAktualnaIlosc = new Telerik.WinControls.UI.RadLabel();
            this.rlblNowaIlosc = new Telerik.WinControls.UI.RadLabel();
            this.rtbIlosc = new Telerik.WinControls.UI.RadTextBox();
            this.rbtOK = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rlblAktualnaIlosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlblNowaIlosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbIlosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rlblAktualnaIlosc
            // 
            this.rlblAktualnaIlosc.Location = new System.Drawing.Point(30, 26);
            this.rlblAktualnaIlosc.Name = "rlblAktualnaIlosc";
            this.rlblAktualnaIlosc.Size = new System.Drawing.Size(81, 18);
            this.rlblAktualnaIlosc.TabIndex = 0;
            this.rlblAktualnaIlosc.Text = "Aktualna ilosc: ";
            // 
            // rlblNowaIlosc
            // 
            this.rlblNowaIlosc.Location = new System.Drawing.Point(30, 50);
            this.rlblNowaIlosc.Name = "rlblNowaIlosc";
            this.rlblNowaIlosc.Size = new System.Drawing.Size(119, 18);
            this.rlblNowaIlosc.TabIndex = 1;
            this.rlblNowaIlosc.Text = "Podaj now¹ iloœæ sztuk";
            // 
            // rtbIlosc
            // 
            this.rtbIlosc.Location = new System.Drawing.Point(165, 50);
            this.rtbIlosc.Name = "rtbIlosc";
            this.rtbIlosc.Size = new System.Drawing.Size(80, 20);
            this.rtbIlosc.TabIndex = 2;
            this.rtbIlosc.TabStop = false;
            // 
            // rbtOK
            // 
            this.rbtOK.Location = new System.Drawing.Point(74, 98);
            this.rbtOK.Name = "rbtOK";
            this.rbtOK.Size = new System.Drawing.Size(130, 24);
            this.rbtOK.TabIndex = 3;
            this.rbtOK.Text = "ZatwierdŸ";
            this.rbtOK.Click += new System.EventHandler(this.rbtOK_Click);
            // 
            // ZmienIloscForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 151);
            this.Controls.Add(this.rbtOK);
            this.Controls.Add(this.rtbIlosc);
            this.Controls.Add(this.rlblNowaIlosc);
            this.Controls.Add(this.rlblAktualnaIlosc);
            this.Name = "ZmienIloscForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ZmienIloscForm";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.rlblAktualnaIlosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlblNowaIlosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbIlosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel rlblAktualnaIlosc;
        private Telerik.WinControls.UI.RadLabel rlblNowaIlosc;
        private Telerik.WinControls.UI.RadTextBox rtbIlosc;
        private Telerik.WinControls.UI.RadButton rbtOK;
    }
}

