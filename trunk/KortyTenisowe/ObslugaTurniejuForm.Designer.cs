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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.rgvZawodnicy = new Telerik.WinControls.UI.RadGridView();
            this.rbtDodajZawodnika = new Telerik.WinControls.UI.RadButton();
            this.rbtEdytujZawodnika = new Telerik.WinControls.UI.RadButton();
            this.rbtUsunZawodnika = new Telerik.WinControls.UI.RadButton();
            this.rbtZaplanujMecz = new Telerik.WinControls.UI.RadButton();
            this.rDDLWybierzTurniej = new Telerik.WinControls.UI.RadDropDownList();
            this.rlbWybierzTurniej = new Telerik.WinControls.UI.RadLabel();
            this.rbtZaplanowaneMecze = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rgvZawodnicy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtDodajZawodnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtEdytujZawodnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtUsunZawodnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtZaplanujMecz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLWybierzTurniej)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbWybierzTurniej)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtZaplanowaneMecze)).BeginInit();
            this.SuspendLayout();
            // 
            // rgvZawodnicy
            // 
            this.rgvZawodnicy.Location = new System.Drawing.Point(213, 12);
            // 
            // rgvZawodnicy
            // 
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.Width = 85;
            gridViewTextBoxColumn2.HeaderText = "Imię";
            gridViewTextBoxColumn2.Name = "Imie";
            gridViewTextBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.HeaderText = "Nazwisko";
            gridViewTextBoxColumn3.Name = "Nazwisko";
            gridViewTextBoxColumn3.Width = 165;
            gridViewTextBoxColumn4.HeaderText = "Telefon kontaktowy";
            gridViewTextBoxColumn4.Name = "Telefon";
            gridViewTextBoxColumn4.Width = 250;
            this.rgvZawodnicy.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.rgvZawodnicy.Name = "rgvZawodnicy";
            this.rgvZawodnicy.ReadOnly = true;
            this.rgvZawodnicy.Size = new System.Drawing.Size(618, 326);
            this.rgvZawodnicy.TabIndex = 0;
            this.rgvZawodnicy.Text = "Obsługa Turnieju";
            this.rgvZawodnicy.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgvZawodnicy_CellClick);
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
            this.rbtEdytujZawodnika.Click += new System.EventHandler(this.rbtEdytujZawodnika_Click);
            // 
            // rbtUsunZawodnika
            // 
            this.rbtUsunZawodnika.Location = new System.Drawing.Point(27, 146);
            this.rbtUsunZawodnika.Name = "rbtUsunZawodnika";
            this.rbtUsunZawodnika.Size = new System.Drawing.Size(161, 24);
            this.rbtUsunZawodnika.TabIndex = 3;
            this.rbtUsunZawodnika.Text = "Usuń zawodnika";
            this.rbtUsunZawodnika.Click += new System.EventHandler(this.rbtUsunZawodnika_Click);
            // 
            // rbtZaplanujMecz
            // 
            this.rbtZaplanujMecz.Location = new System.Drawing.Point(27, 281);
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
            this.rDDLWybierzTurniej.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.rDDLWybierzTurniej_SelectedIndexChanged);
            // 
            // rlbWybierzTurniej
            // 
            this.rlbWybierzTurniej.Location = new System.Drawing.Point(27, 12);
            this.rlbWybierzTurniej.Name = "rlbWybierzTurniej";
            this.rlbWybierzTurniej.Size = new System.Drawing.Size(88, 16);
            this.rlbWybierzTurniej.TabIndex = 4;
            this.rlbWybierzTurniej.Text = "Wybierz Turniej:";
            // 
            // rbtZaplanowaneMecze
            // 
            this.rbtZaplanowaneMecze.Location = new System.Drawing.Point(27, 311);
            this.rbtZaplanowaneMecze.Name = "rbtZaplanowaneMecze";
            this.rbtZaplanowaneMecze.Size = new System.Drawing.Size(161, 24);
            this.rbtZaplanowaneMecze.TabIndex = 5;
            this.rbtZaplanowaneMecze.Text = "Zaplanowane mecze";
            this.rbtZaplanowaneMecze.Click += new System.EventHandler(this.rbtZaplanowaneMecze_Click);
            // 
            // ObslugaTurniejuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(843, 347);
            this.Controls.Add(this.rbtZaplanowaneMecze);
            this.Controls.Add(this.rlbWybierzTurniej);
            this.Controls.Add(this.rbtEdytujZawodnika);
            this.Controls.Add(this.rbtZaplanujMecz);
            this.Controls.Add(this.rbtUsunZawodnika);
            this.Controls.Add(this.rDDLWybierzTurniej);
            this.Controls.Add(this.rbtDodajZawodnika);
            this.Controls.Add(this.rgvZawodnicy);
            this.Name = "ObslugaTurniejuForm";
            this.Text = "Obsługa Turnieju";
            ((System.ComponentModel.ISupportInitialize)(this.rgvZawodnicy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtDodajZawodnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtEdytujZawodnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtUsunZawodnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtZaplanujMecz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLWybierzTurniej)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbWybierzTurniej)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtZaplanowaneMecze)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvZawodnicy;
        private Telerik.WinControls.UI.RadButton rbtDodajZawodnika;
        private Telerik.WinControls.UI.RadButton rbtEdytujZawodnika;
        private Telerik.WinControls.UI.RadButton rbtUsunZawodnika;
        private Telerik.WinControls.UI.RadButton rbtZaplanujMecz;
        private Telerik.WinControls.UI.RadDropDownList rDDLWybierzTurniej;
        private Telerik.WinControls.UI.RadLabel rlbWybierzTurniej;
        private Telerik.WinControls.UI.RadButton rbtZaplanowaneMecze;
    }
}