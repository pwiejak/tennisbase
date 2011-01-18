namespace KortyTenisowe
{
    partial class WynikiForm
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.rlbWybierzTurniej = new Telerik.WinControls.UI.RadLabel();
            this.rgvWyniki = new Telerik.WinControls.UI.RadGridView();
            this.rbtDodajWynik = new Telerik.WinControls.UI.RadButton();
            this.rbtEdytujWynik = new Telerik.WinControls.UI.RadButton();
            this.rbtUsunWynik = new Telerik.WinControls.UI.RadButton();
            this.rDDLWybierzTurniej = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.rlbWybierzTurniej)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvWyniki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtDodajWynik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtEdytujWynik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtUsunWynik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLWybierzTurniej)).BeginInit();
            this.SuspendLayout();
            // 
            // rlbWybierzTurniej
            // 
            this.rlbWybierzTurniej.Location = new System.Drawing.Point(12, 28);
            this.rlbWybierzTurniej.Name = "rlbWybierzTurniej";
            this.rlbWybierzTurniej.Size = new System.Drawing.Size(84, 16);
            this.rlbWybierzTurniej.TabIndex = 0;
            this.rlbWybierzTurniej.Text = "Wybierz turniej:";
            // 
            // rgvWyniki
            // 
            this.rgvWyniki.Location = new System.Drawing.Point(12, 56);
            // 
            // rgvWyniki
            // 
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.Width = 70;
            gridViewTextBoxColumn2.HeaderText = "Zawodnik 1.";
            gridViewTextBoxColumn2.Name = "Zawodnik 1.";
            gridViewTextBoxColumn2.Width = 150;
            gridViewTextBoxColumn3.HeaderText = "vs";
            gridViewTextBoxColumn3.Name = "vs";
            gridViewTextBoxColumn4.HeaderText = "Zawodnik 2.";
            gridViewTextBoxColumn4.Name = "Zawodnik2";
            gridViewTextBoxColumn4.Width = 150;
            gridViewTextBoxColumn5.HeaderText = "Set1";
            gridViewTextBoxColumn5.Name = "Set1";
            gridViewTextBoxColumn5.Width = 70;
            gridViewTextBoxColumn6.HeaderText = "Set2";
            gridViewTextBoxColumn6.Name = "Set2";
            gridViewTextBoxColumn6.Width = 70;
            gridViewTextBoxColumn7.HeaderText = "Set3";
            gridViewTextBoxColumn7.Name = "Set3";
            gridViewTextBoxColumn7.Width = 70;
            gridViewTextBoxColumn8.HeaderText = "Set4";
            gridViewTextBoxColumn8.Name = "Set4";
            gridViewTextBoxColumn8.Width = 70;
            gridViewTextBoxColumn9.HeaderText = "Set5";
            gridViewTextBoxColumn9.Name = "Set5";
            gridViewTextBoxColumn9.Width = 70;
            this.rgvWyniki.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9});
            this.rgvWyniki.Name = "rgvWyniki";
            this.rgvWyniki.ReadOnly = true;
            this.rgvWyniki.Size = new System.Drawing.Size(777, 294);
            this.rgvWyniki.TabIndex = 2;
            this.rgvWyniki.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgvWyniki_CellClick);
            // 
            // rbtDodajWynik
            // 
            this.rbtDodajWynik.Location = new System.Drawing.Point(12, 356);
            this.rbtDodajWynik.Name = "rbtDodajWynik";
            this.rbtDodajWynik.Size = new System.Drawing.Size(208, 24);
            this.rbtDodajWynik.TabIndex = 3;
            this.rbtDodajWynik.Text = "Dodaj wynik";
            this.rbtDodajWynik.Click += new System.EventHandler(this.rbtDodajWynik_Click);
            // 
            // rbtEdytujWynik
            // 
            this.rbtEdytujWynik.Location = new System.Drawing.Point(300, 356);
            this.rbtEdytujWynik.Name = "rbtEdytujWynik";
            this.rbtEdytujWynik.Size = new System.Drawing.Size(208, 24);
            this.rbtEdytujWynik.TabIndex = 4;
            this.rbtEdytujWynik.Text = "Edytuj wynik";
            this.rbtEdytujWynik.Click += new System.EventHandler(this.rbtEdytujWynik_Click);
            // 
            // rbtUsunWynik
            // 
            this.rbtUsunWynik.Location = new System.Drawing.Point(587, 356);
            this.rbtUsunWynik.Name = "rbtUsunWynik";
            this.rbtUsunWynik.Size = new System.Drawing.Size(202, 24);
            this.rbtUsunWynik.TabIndex = 4;
            this.rbtUsunWynik.Text = "Usuń wynik";
            this.rbtUsunWynik.Click += new System.EventHandler(this.rbtUsunWynik_Click);
            // 
            // rDDLWybierzTurniej
            // 
            this.rDDLWybierzTurniej.Location = new System.Drawing.Point(99, 28);
            this.rDDLWybierzTurniej.Name = "rDDLWybierzTurniej";
            this.rDDLWybierzTurniej.ShowImageInEditorArea = true;
            this.rDDLWybierzTurniej.Size = new System.Drawing.Size(176, 21);
            this.rDDLWybierzTurniej.TabIndex = 4;
            this.rDDLWybierzTurniej.Text = "Turniej";
            this.rDDLWybierzTurniej.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.rDDLWybierzTurniej_SelectedIndexChanged);
            // 
            // WynikiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(801, 392);
            this.Controls.Add(this.rbtEdytujWynik);
            this.Controls.Add(this.rbtUsunWynik);
            this.Controls.Add(this.rDDLWybierzTurniej);
            this.Controls.Add(this.rbtDodajWynik);
            this.Controls.Add(this.rgvWyniki);
            this.Controls.Add(this.rlbWybierzTurniej);
            this.Name = "WynikiForm";
            this.Text = "Wyniki poszczególnych spotkań";
            ((System.ComponentModel.ISupportInitialize)(this.rlbWybierzTurniej)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvWyniki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtDodajWynik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtEdytujWynik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtUsunWynik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLWybierzTurniej)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel rlbWybierzTurniej;
        private Telerik.WinControls.UI.RadGridView rgvWyniki;
        private Telerik.WinControls.UI.RadButton rbtDodajWynik;
        private Telerik.WinControls.UI.RadButton rbtEdytujWynik;
        private Telerik.WinControls.UI.RadButton rbtUsunWynik;
        private Telerik.WinControls.UI.RadDropDownList rDDLWybierzTurniej;
    }
}