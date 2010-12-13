namespace KortyTenisowe
{
    partial class PotwierdzenieForm
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
            this.rlblConfirm = new Telerik.WinControls.UI.RadLabel();
            this.rbtTak = new Telerik.WinControls.UI.RadButton();
            this.rbtNie = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rlblConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtTak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtNie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rlblConfirm
            // 
            this.rlblConfirm.Location = new System.Drawing.Point(27, 23);
            this.rlblConfirm.Name = "rlblConfirm";
            this.rlblConfirm.Size = new System.Drawing.Size(229, 18);
            this.rlblConfirm.TabIndex = 0;
            this.rlblConfirm.Text = "Czy na pewno chcesz usun¹æ ten przedmiot?";
            // 
            // rbtTak
            // 
            this.rbtTak.Location = new System.Drawing.Point(12, 47);
            this.rbtTak.Name = "rbtTak";
            this.rbtTak.Size = new System.Drawing.Size(130, 24);
            this.rbtTak.TabIndex = 1;
            this.rbtTak.Text = "Tak";
            this.rbtTak.Click += new System.EventHandler(this.rbtTak_Click);
            // 
            // rbtNie
            // 
            this.rbtNie.Location = new System.Drawing.Point(163, 47);
            this.rbtNie.Name = "rbtNie";
            this.rbtNie.Size = new System.Drawing.Size(130, 24);
            this.rbtNie.TabIndex = 2;
            this.rbtNie.Text = "Nie";
            this.rbtNie.Click += new System.EventHandler(this.rbtNie_Click);
            // 
            // PotwierdzenieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 113);
            this.Controls.Add(this.rbtNie);
            this.Controls.Add(this.rbtTak);
            this.Controls.Add(this.rlblConfirm);
            this.Name = "PotwierdzenieForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "PotwierdzenieForm";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.rlblConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtTak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtNie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel rlblConfirm;
        private Telerik.WinControls.UI.RadButton rbtTak;
        private Telerik.WinControls.UI.RadButton rbtNie;
    }
}

