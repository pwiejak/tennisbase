namespace KortyTenisowe
{
    partial class ZaplanujMeczForm
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
            this.rlbZawodnik1 = new Telerik.WinControls.UI.RadLabel();
            this.rlbZawodnik2 = new Telerik.WinControls.UI.RadLabel();
            this.rDDLZawodnik1 = new Telerik.WinControls.UI.RadDropDownList();
            this.rDDLZawodnik2 = new Telerik.WinControls.UI.RadDropDownList();
            this.rbtZaplanuj = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rlbZawodnik1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbZawodnik2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLZawodnik1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLZawodnik2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtZaplanuj)).BeginInit();
            this.SuspendLayout();
            // 
            // rlbZawodnik1
            // 
            this.rlbZawodnik1.Location = new System.Drawing.Point(39, 28);
            this.rlbZawodnik1.Name = "rlbZawodnik1";
            this.rlbZawodnik1.Size = new System.Drawing.Size(67, 16);
            this.rlbZawodnik1.TabIndex = 0;
            this.rlbZawodnik1.Text = "Zawodnik 1.";
            // 
            // rlbZawodnik2
            // 
            this.rlbZawodnik2.Location = new System.Drawing.Point(39, 84);
            this.rlbZawodnik2.Name = "rlbZawodnik2";
            this.rlbZawodnik2.Size = new System.Drawing.Size(67, 16);
            this.rlbZawodnik2.TabIndex = 1;
            this.rlbZawodnik2.Text = "Zawodnik 2.";
            // 
            // rDDLZawodnik1
            // 
            this.rDDLZawodnik1.Location = new System.Drawing.Point(151, 28);
            this.rDDLZawodnik1.Name = "rDDLZawodnik1";
            this.rDDLZawodnik1.Size = new System.Drawing.Size(133, 22);
            this.rDDLZawodnik1.TabIndex = 2;
            this.rDDLZawodnik1.Text = "Zawodnik 1.";
            // 
            // rDDLZawodnik2
            // 
            this.rDDLZawodnik2.Location = new System.Drawing.Point(151, 84);
            this.rDDLZawodnik2.Name = "rDDLZawodnik2";
            this.rDDLZawodnik2.Size = new System.Drawing.Size(133, 22);
            this.rDDLZawodnik2.TabIndex = 3;
            this.rDDLZawodnik2.Text = "Zawodnik 2.";
            // 
            // rbtZaplanuj
            // 
            this.rbtZaplanuj.Location = new System.Drawing.Point(39, 132);
            this.rbtZaplanuj.Name = "rbtZaplanuj";
            this.rbtZaplanuj.Size = new System.Drawing.Size(245, 24);
            this.rbtZaplanuj.TabIndex = 4;
            this.rbtZaplanuj.Text = "Zaplanuj i wyślij powiadomienia";
            // 
            // ZaplanujMeczForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(323, 168);
            this.Controls.Add(this.rbtZaplanuj);
            this.Controls.Add(this.rDDLZawodnik2);
            this.Controls.Add(this.rDDLZawodnik1);
            this.Controls.Add(this.rlbZawodnik2);
            this.Controls.Add(this.rlbZawodnik1);
            this.Name = "ZaplanujMeczForm";
            this.Text = "Zaplanuj mecz";
            ((System.ComponentModel.ISupportInitialize)(this.rlbZawodnik1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbZawodnik2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLZawodnik1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLZawodnik2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtZaplanuj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel rlbZawodnik1;
        private Telerik.WinControls.UI.RadLabel rlbZawodnik2;
        private Telerik.WinControls.UI.RadDropDownList rDDLZawodnik1;
        private Telerik.WinControls.UI.RadDropDownList rDDLZawodnik2;
        private Telerik.WinControls.UI.RadButton rbtZaplanuj;

    }
}