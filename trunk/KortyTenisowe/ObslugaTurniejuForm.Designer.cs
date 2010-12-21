namespace KortyTenisowe
{
    partial class ObslugaTurniejuForm
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.rgvTurnieje = new Telerik.WinControls.UI.RadGridView();
            this.rbtDodajZawodnika = new Telerik.WinControls.UI.RadButton();
            this.rbtEdytujZawodnika = new Telerik.WinControls.UI.RadButton();
            this.rbtUsunZawodnika = new Telerik.WinControls.UI.RadButton();
            this.rbtZaplanujMecz = new Telerik.WinControls.UI.RadButton();
            this.rDDLWybierzTurniej = new Telerik.WinControls.UI.RadDropDownList();
            this.rlbWybierzTurniej = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.rgvTurnieje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtDodajZawodnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtEdytujZawodnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtUsunZawodnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtZaplanujMecz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLWybierzTurniej)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbWybierzTurniej)).BeginInit();
            this.SuspendLayout();
            // 
            // rgvTurnieje
            // 
            this.rgvTurnieje.Location = new System.Drawing.Point(213, 12);
            // 
            // rgvTurnieje
            // 
            gridViewTextBoxColumn9.HeaderText = "ID";
            gridViewTextBoxColumn9.Name = "Id";
            gridViewTextBoxColumn9.Width = 85;
            gridViewTextBoxColumn10.HeaderText = "Imię";
            gridViewTextBoxColumn10.Name = "Imie";
            gridViewTextBoxColumn10.Width = 100;
            gridViewTextBoxColumn11.HeaderText = "Nazwisko";
            gridViewTextBoxColumn11.Name = "Nazwisko";
            gridViewTextBoxColumn11.Width = 165;
            gridViewTextBoxColumn12.HeaderText = "Telefon kontaktowy";
            gridViewTextBoxColumn12.Name = "Telefon";
            gridViewTextBoxColumn12.Width = 250;
            this.rgvTurnieje.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12});
            this.rgvTurnieje.Name = "rgvTurnieje";
            this.rgvTurnieje.ReadOnly = true;
            this.rgvTurnieje.Size = new System.Drawing.Size(618, 326);
            this.rgvTurnieje.TabIndex = 0;
            this.rgvTurnieje.Text = "Obsługa Turnieju";
            // 
            // rbtDodajZawodnika
            // 
            this.rbtDodajZawodnika.Location = new System.Drawing.Point(27, 86);
            this.rbtDodajZawodnika.Name = "rbtDodajZawodnika";
            this.rbtDodajZawodnika.Size = new System.Drawing.Size(161, 24);
            this.rbtDodajZawodnika.TabIndex = 2;
            this.rbtDodajZawodnika.Text = "Dodaj zawodnika";
            this.rbtDodajZawodnika.Click += new System.EventHandler(this.rbtDodajZawodnika_Click);
            // 
            // rbtEdytujZawodnika
            // 
            this.rbtEdytujZawodnika.Location = new System.Drawing.Point(27, 116);
            this.rbtEdytujZawodnika.Name = "rbtEdytujZawodnika";
            this.rbtEdytujZawodnika.Size = new System.Drawing.Size(161, 24);
            this.rbtEdytujZawodnika.TabIndex = 3;
            this.rbtEdytujZawodnika.Text = "Edytuj zawodnika";
            // 
            // rbtUsunZawodnika
            // 
            this.rbtUsunZawodnika.Location = new System.Drawing.Point(27, 146);
            this.rbtUsunZawodnika.Name = "rbtUsunZawodnika";
            this.rbtUsunZawodnika.Size = new System.Drawing.Size(161, 24);
            this.rbtUsunZawodnika.TabIndex = 3;
            this.rbtUsunZawodnika.Text = "Usuń Zawodnika";
            this.rbtUsunZawodnika.Click += new System.EventHandler(this.rbtUsunZawodnika_Click);
            // 
            // rbtZaplanujMecz
            // 
            this.rbtZaplanujMecz.Location = new System.Drawing.Point(27, 314);
            this.rbtZaplanujMecz.Name = "rbtZaplanujMecz";
            this.rbtZaplanujMecz.Size = new System.Drawing.Size(161, 24);
            this.rbtZaplanujMecz.TabIndex = 3;
            this.rbtZaplanujMecz.Text = "Zaplanuj mecz";
            this.rbtZaplanujMecz.Click += new System.EventHandler(this.rbtZaplanujMecz_Click);
            // 
            // rDDLWybierzTurniej
            // 
            this.rDDLWybierzTurniej.Location = new System.Drawing.Point(27, 34);
            this.rDDLWybierzTurniej.Name = "rDDLWybierzTurniej";
            this.rDDLWybierzTurniej.Size = new System.Drawing.Size(161, 22);
            this.rDDLWybierzTurniej.TabIndex = 3;
            this.rDDLWybierzTurniej.Text = "Turniej";
            // 
            // rlbWybierzTurniej
            // 
            this.rlbWybierzTurniej.Location = new System.Drawing.Point(27, 12);
            this.rlbWybierzTurniej.Name = "rlbWybierzTurniej";
            this.rlbWybierzTurniej.Size = new System.Drawing.Size(88, 16);
            this.rlbWybierzTurniej.TabIndex = 4;
            this.rlbWybierzTurniej.Text = "Wybierz Turniej:";
            // 
            // ObslugaTurniejuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 347);
            this.Controls.Add(this.rlbWybierzTurniej);
            this.Controls.Add(this.rbtEdytujZawodnika);
            this.Controls.Add(this.rbtZaplanujMecz);
            this.Controls.Add(this.rbtUsunZawodnika);
            this.Controls.Add(this.rDDLWybierzTurniej);
            this.Controls.Add(this.rbtDodajZawodnika);
            this.Controls.Add(this.rgvTurnieje);
            this.Name = "ObslugaTurniejuForm";
            this.Text = "Obsługa Turnieju";
            ((System.ComponentModel.ISupportInitialize)(this.rgvTurnieje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtDodajZawodnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtEdytujZawodnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtUsunZawodnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtZaplanujMecz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLWybierzTurniej)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbWybierzTurniej)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvTurnieje;
        private Telerik.WinControls.UI.RadButton rbtDodajZawodnika;
        private Telerik.WinControls.UI.RadButton rbtEdytujZawodnika;
        private Telerik.WinControls.UI.RadButton rbtUsunZawodnika;
        private Telerik.WinControls.UI.RadButton rbtZaplanujMecz;
        private Telerik.WinControls.UI.RadDropDownList rDDLWybierzTurniej;
        private Telerik.WinControls.UI.RadLabel rlbWybierzTurniej;
    }
}