namespace KortyTenisowe
{
    partial class MainForm
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn81 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn82 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn83 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn84 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn85 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn86 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn87 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn88 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.tcMainForm = new System.Windows.Forms.TabControl();
            this.tabKorty = new System.Windows.Forms.TabPage();
            this.rtbInformacja = new System.Windows.Forms.RichTextBox();
            this.dgKorty = new System.Windows.Forms.DataGridView();
            this.ColumnGodziny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKort1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKort2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKort3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKort4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kalendarz = new System.Windows.Forms.MonthCalendar();
            this.tabSprzet = new System.Windows.Forms.TabPage();
            this.rgvSprzet = new Telerik.WinControls.UI.RadGridView();
            this.rDDLKategorie = new Telerik.WinControls.UI.RadDropDownList();
            this.rbtDodajNowy = new Telerik.WinControls.UI.RadButton();
            this.tabPracownicy = new System.Windows.Forms.TabPage();
            this.btDodajPracownika = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbNowyTyp = new Telerik.WinControls.UI.RadButton();
            this.tabMagazyn = new System.Windows.Forms.TabPage();
            this.rgvMagazyn = new Telerik.WinControls.UI.RadGridView();
            this.rddlKategorieMagazyn = new Telerik.WinControls.UI.RadDropDownList();
            this.tcMainForm.SuspendLayout();
            this.tabKorty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKorty)).BeginInit();
            this.tabSprzet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvSprzet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLKategorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtDodajNowy)).BeginInit();
            this.tabPracownicy.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbNowyTyp)).BeginInit();
            this.tabMagazyn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvMagazyn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddlKategorieMagazyn)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMainForm
            // 
            this.tcMainForm.Controls.Add(this.tabKorty);
            this.tcMainForm.Controls.Add(this.tabSprzet);
            this.tcMainForm.Controls.Add(this.tabMagazyn);
            this.tcMainForm.Controls.Add(this.tabPracownicy);
            this.tcMainForm.Location = new System.Drawing.Point(12, 27);
            this.tcMainForm.Name = "tcMainForm";
            this.tcMainForm.SelectedIndex = 0;
            this.tcMainForm.Size = new System.Drawing.Size(804, 435);
            this.tcMainForm.TabIndex = 0;
            // 
            // tabKorty
            // 
            this.tabKorty.BackColor = System.Drawing.Color.AliceBlue;
            this.tabKorty.Controls.Add(this.rtbInformacja);
            this.tabKorty.Controls.Add(this.dgKorty);
            this.tabKorty.Controls.Add(this.Kalendarz);
            this.tabKorty.Location = new System.Drawing.Point(4, 22);
            this.tabKorty.Name = "tabKorty";
            this.tabKorty.Padding = new System.Windows.Forms.Padding(3);
            this.tabKorty.Size = new System.Drawing.Size(796, 410);
            this.tabKorty.TabIndex = 0;
            this.tabKorty.Text = "Korty";
            // 
            // rtbInformacja
            // 
            this.rtbInformacja.Location = new System.Drawing.Point(15, 191);
            this.rtbInformacja.Name = "rtbInformacja";
            this.rtbInformacja.ReadOnly = true;
            this.rtbInformacja.Size = new System.Drawing.Size(122, 125);
            this.rtbInformacja.TabIndex = 2;
            this.rtbInformacja.Text = "";
            // 
            // dgKorty
            // 
            this.dgKorty.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgKorty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKorty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnGodziny,
            this.ColumnKort1,
            this.ColumnKort2,
            this.ColumnKort3,
            this.ColumnKort4});
            this.dgKorty.Location = new System.Drawing.Point(192, 9);
            this.dgKorty.Name = "dgKorty";
            this.dgKorty.Size = new System.Drawing.Size(484, 376);
            this.dgKorty.TabIndex = 1;
            this.dgKorty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKorty_CellClick);
            this.dgKorty.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKorty_CellDoubleClick);
            // 
            // ColumnGodziny
            // 
            this.ColumnGodziny.Frozen = true;
            this.ColumnGodziny.HeaderText = "Godz.";
            this.ColumnGodziny.Name = "ColumnGodziny";
            this.ColumnGodziny.ReadOnly = true;
            this.ColumnGodziny.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnGodziny.Width = 40;
            // 
            // ColumnKort1
            // 
            this.ColumnKort1.HeaderText = "Kort 1";
            this.ColumnKort1.Name = "ColumnKort1";
            // 
            // ColumnKort2
            // 
            this.ColumnKort2.HeaderText = "Kort 2";
            this.ColumnKort2.Name = "ColumnKort2";
            // 
            // ColumnKort3
            // 
            this.ColumnKort3.HeaderText = "Kort 3";
            this.ColumnKort3.Name = "ColumnKort3";
            // 
            // ColumnKort4
            // 
            this.ColumnKort4.HeaderText = "Kort 4";
            this.ColumnKort4.Name = "ColumnKort4";
            // 
            // Kalendarz
            // 
            this.Kalendarz.Location = new System.Drawing.Point(0, 9);
            this.Kalendarz.Name = "Kalendarz";
            this.Kalendarz.TabIndex = 0;
            this.Kalendarz.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Kalendarz_DateChanged);
            // 
            // tabSprzet
            // 
            this.tabSprzet.BackColor = System.Drawing.Color.Transparent;
            this.tabSprzet.Controls.Add(this.rbNowyTyp);
            this.tabSprzet.Controls.Add(this.rgvSprzet);
            this.tabSprzet.Controls.Add(this.rDDLKategorie);
            this.tabSprzet.Controls.Add(this.rbtDodajNowy);
            this.tabSprzet.Location = new System.Drawing.Point(4, 22);
            this.tabSprzet.Name = "tabSprzet";
            this.tabSprzet.Padding = new System.Windows.Forms.Padding(3);
            this.tabSprzet.Size = new System.Drawing.Size(796, 409);
            this.tabSprzet.TabIndex = 1;
            this.tabSprzet.Text = "Sprzet";
            // 
            // rgvSprzet
            // 
            this.rgvSprzet.Location = new System.Drawing.Point(173, 17);
            // 
            // rgvSprzet
            // 
            gridViewTextBoxColumn81.FormatString = "";
            gridViewTextBoxColumn81.HeaderText = "Nr";
            gridViewTextBoxColumn81.Name = "Id";
            gridViewTextBoxColumn82.FormatString = "";
            gridViewTextBoxColumn82.HeaderText = "Marka";
            gridViewTextBoxColumn82.Name = "Marka";
            gridViewTextBoxColumn82.Width = 100;
            gridViewTextBoxColumn83.FormatString = "";
            gridViewTextBoxColumn83.HeaderText = "Model";
            gridViewTextBoxColumn83.Name = "Model";
            gridViewTextBoxColumn83.Width = 100;
            gridViewTextBoxColumn84.FormatString = "";
            gridViewTextBoxColumn84.HeaderText = "Opis";
            gridViewTextBoxColumn84.Name = "Opis";
            gridViewTextBoxColumn84.Width = 300;
            this.rgvSprzet.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn81,
            gridViewTextBoxColumn82,
            gridViewTextBoxColumn83,
            gridViewTextBoxColumn84});
            this.rgvSprzet.Name = "rgvSprzet";
            this.rgvSprzet.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.rgvSprzet.ReadOnly = true;
            // 
            // 
            // 
            this.rgvSprzet.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.rgvSprzet.Size = new System.Drawing.Size(569, 367);
            this.rgvSprzet.TabIndex = 3;
            this.rgvSprzet.Text = "Sprzet";
            // 
            // rDDLKategorie
            // 
            this.rDDLKategorie.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rDDLKategorie.Location = new System.Drawing.Point(6, 47);
            this.rDDLKategorie.Name = "rDDLKategorie";
            this.rDDLKategorie.Size = new System.Drawing.Size(130, 20);
            this.rDDLKategorie.TabIndex = 2;
            this.rDDLKategorie.Text = "Kategoria";
            this.rDDLKategorie.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.rDDLKategorie_SelectedIndexChanged);
            // 
            // rbtDodajNowy
            // 
            this.rbtDodajNowy.Location = new System.Drawing.Point(6, 17);
            this.rbtDodajNowy.Name = "rbtDodajNowy";
            this.rbtDodajNowy.Size = new System.Drawing.Size(130, 24);
            this.rbtDodajNowy.TabIndex = 1;
            this.rbtDodajNowy.Text = "Dodaj nowy";
            this.rbtDodajNowy.Click += new System.EventHandler(this.rbtDodajNowy_Click);
            // 
            // tabPracownicy
            // 
            this.tabPracownicy.Controls.Add(this.btDodajPracownika);
            this.tabPracownicy.Location = new System.Drawing.Point(4, 22);
            this.tabPracownicy.Name = "tabPracownicy";
            this.tabPracownicy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPracownicy.Size = new System.Drawing.Size(796, 410);
            this.tabPracownicy.TabIndex = 2;
            this.tabPracownicy.Text = "Pracownicy";
            this.tabPracownicy.UseVisualStyleBackColor = true;
            // 
            // btDodajPracownika
            // 
            this.btDodajPracownika.Location = new System.Drawing.Point(15, 33);
            this.btDodajPracownika.Name = "btDodajPracownika";
            this.btDodajPracownika.Size = new System.Drawing.Size(109, 23);
            this.btDodajPracownika.TabIndex = 0;
            this.btDodajPracownika.Text = "Dodaj Pracownika";
            this.btDodajPracownika.UseVisualStyleBackColor = true;
            this.btDodajPracownika.Click += new System.EventHandler(this.btDodajPracownika_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zakończToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // rbNowyTyp
            // 
            this.rbNowyTyp.Location = new System.Drawing.Point(6, 360);
            this.rbNowyTyp.Name = "rbNowyTyp";
            this.rbNowyTyp.Size = new System.Drawing.Size(130, 24);
            this.rbNowyTyp.TabIndex = 0;
            this.rbNowyTyp.Text = "Dodaj nową kategorię";
            this.rbNowyTyp.Click += new System.EventHandler(this.rbNowyTyp_Click);
            // 
            // tabMagazyn
            // 
            this.tabMagazyn.BackColor = System.Drawing.Color.AliceBlue;
            this.tabMagazyn.Controls.Add(this.rddlKategorieMagazyn);
            this.tabMagazyn.Controls.Add(this.rgvMagazyn);
            this.tabMagazyn.Location = new System.Drawing.Point(4, 22);
            this.tabMagazyn.Name = "tabMagazyn";
            this.tabMagazyn.Padding = new System.Windows.Forms.Padding(3);
            this.tabMagazyn.Size = new System.Drawing.Size(796, 410);
            this.tabMagazyn.TabIndex = 3;
            this.tabMagazyn.Text = "Magazyn";
            // 
            // rgvMagazyn
            // 
            this.rgvMagazyn.Location = new System.Drawing.Point(173, 17);
            // 
            // rgvMagazyn
            // 
            gridViewTextBoxColumn85.FormatString = "";
            gridViewTextBoxColumn85.HeaderText = "Nr";
            gridViewTextBoxColumn85.Name = "Id";
            gridViewTextBoxColumn86.FormatString = "";
            gridViewTextBoxColumn86.HeaderText = "Marka";
            gridViewTextBoxColumn86.Name = "Marka";
            gridViewTextBoxColumn86.Width = 100;
            gridViewTextBoxColumn87.FormatString = "";
            gridViewTextBoxColumn87.HeaderText = "Model";
            gridViewTextBoxColumn87.Name = "Model";
            gridViewTextBoxColumn87.Width = 100;
            gridViewTextBoxColumn88.FormatString = "";
            gridViewTextBoxColumn88.HeaderText = "Opis";
            gridViewTextBoxColumn88.Name = "Opis";
            gridViewTextBoxColumn88.Width = 300;
            this.rgvMagazyn.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn85,
            gridViewTextBoxColumn86,
            gridViewTextBoxColumn87,
            gridViewTextBoxColumn88});
            this.rgvMagazyn.Name = "rgvMagazyn";
            this.rgvMagazyn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.rgvMagazyn.ReadOnly = true;
            // 
            // 
            // 
            this.rgvMagazyn.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.rgvMagazyn.Size = new System.Drawing.Size(569, 367);
            this.rgvMagazyn.TabIndex = 4;
            this.rgvMagazyn.Text = "Magazyn";
            // 
            // rddlKategorieMagazyn
            // 
            this.rddlKategorieMagazyn.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rddlKategorieMagazyn.Location = new System.Drawing.Point(6, 47);
            this.rddlKategorieMagazyn.Name = "rddlKategorieMagazyn";
            this.rddlKategorieMagazyn.Size = new System.Drawing.Size(130, 20);
            this.rddlKategorieMagazyn.TabIndex = 5;
            this.rddlKategorieMagazyn.Text = "Kategoria";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 490);
            this.Controls.Add(this.tcMainForm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Korty Tenisowe";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tcMainForm.ResumeLayout(false);
            this.tabKorty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgKorty)).EndInit();
            this.tabSprzet.ResumeLayout(false);
            this.tabSprzet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvSprzet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLKategorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtDodajNowy)).EndInit();
            this.tabPracownicy.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbNowyTyp)).EndInit();
            this.tabMagazyn.ResumeLayout(false);
            this.tabMagazyn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvMagazyn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddlKategorieMagazyn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMainForm;
        private System.Windows.Forms.TabPage tabKorty;
        private System.Windows.Forms.TabPage tabSprzet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPracownicy;
        private System.Windows.Forms.Button btDodajPracownika;
        private System.Windows.Forms.DataGridView dgKorty;
        private System.Windows.Forms.MonthCalendar Kalendarz;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGodziny;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKort1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKort2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKort3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKort4;
        private System.Windows.Forms.RichTextBox rtbInformacja;
        private Telerik.WinControls.UI.RadButton rbtDodajNowy;
        private Telerik.WinControls.UI.RadDropDownList rDDLKategorie;
        private Telerik.WinControls.UI.RadGridView rgvSprzet;
        private Telerik.WinControls.UI.RadButton rbNowyTyp;
        private System.Windows.Forms.TabPage tabMagazyn;
        private Telerik.WinControls.UI.RadGridView rgvMagazyn;
        private Telerik.WinControls.UI.RadDropDownList rddlKategorieMagazyn;
    }
}