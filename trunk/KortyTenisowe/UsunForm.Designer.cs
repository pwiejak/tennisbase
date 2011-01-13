namespace KortyTenisowe
{
    partial class UsunForm
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
            this.rlbUsun = new Telerik.WinControls.UI.RadLabel();
            this.rbtTak = new Telerik.WinControls.UI.RadButton();
            this.rbtNie = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rlbUsun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtTak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtNie)).BeginInit();
            this.SuspendLayout();
            // 
            // rlbUsun
            // 
            this.rlbUsun.Location = new System.Drawing.Point(95, 12);
            this.rlbUsun.Name = "rlbUsun";
            this.rlbUsun.Size = new System.Drawing.Size(100, 16);
            this.rlbUsun.TabIndex = 0;
            this.rlbUsun.Text = "Czy jesteś pewny?";
            // 
            // rbtTak
            // 
            this.rbtTak.Location = new System.Drawing.Point(12, 45);
            this.rbtTak.Name = "rbtTak";
            this.rbtTak.Size = new System.Drawing.Size(130, 24);
            this.rbtTak.TabIndex = 1;
            this.rbtTak.Text = "Tak";
            this.rbtTak.Click += new System.EventHandler(this.rbtTak_Click);
            // 
            // rbtNie
            // 
            this.rbtNie.Location = new System.Drawing.Point(149, 45);
            this.rbtNie.Name = "rbtNie";
            this.rbtNie.Size = new System.Drawing.Size(130, 24);
            this.rbtNie.TabIndex = 2;
            this.rbtNie.Text = "Nie";
            this.rbtNie.Click += new System.EventHandler(this.rbtNie_Click);
            // 
            // UsunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(291, 89);
            this.Controls.Add(this.rbtNie);
            this.Controls.Add(this.rbtTak);
            this.Controls.Add(this.rlbUsun);
            this.Name = "UsunForm";
            this.Text = "Usuwanie danych";
            ((System.ComponentModel.ISupportInitialize)(this.rlbUsun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtTak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtNie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel rlbUsun;
        private Telerik.WinControls.UI.RadButton rbtTak;
        private Telerik.WinControls.UI.RadButton rbtNie;
    }
}