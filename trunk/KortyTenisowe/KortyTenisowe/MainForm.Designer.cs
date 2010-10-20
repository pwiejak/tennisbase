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
            this.tcMainForm = new System.Windows.Forms.TabControl();
            this.tabKorty = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPracownicy = new System.Windows.Forms.TabPage();
            this.btDodajPracownika = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Kalendarz = new System.Windows.Forms.MonthCalendar();
            this.dgKorty = new System.Windows.Forms.DataGridView();
            this.ColumnGodziny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKort1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKort2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKort3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKort4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcMainForm.SuspendLayout();
            this.tabKorty.SuspendLayout();
            this.tabPracownicy.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKorty)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMainForm
            // 
            this.tcMainForm.Controls.Add(this.tabKorty);
            this.tcMainForm.Controls.Add(this.tabPage2);
            this.tcMainForm.Controls.Add(this.tabPracownicy);
            this.tcMainForm.Location = new System.Drawing.Point(12, 27);
            this.tcMainForm.Name = "tcMainForm";
            this.tcMainForm.SelectedIndex = 0;
            this.tcMainForm.Size = new System.Drawing.Size(804, 421);
            this.tcMainForm.TabIndex = 0;
            // 
            // tabKorty
            // 
            this.tabKorty.Controls.Add(this.dgKorty);
            this.tabKorty.Controls.Add(this.Kalendarz);
            this.tabKorty.Location = new System.Drawing.Point(4, 22);
            this.tabKorty.Name = "tabKorty";
            this.tabKorty.Padding = new System.Windows.Forms.Padding(3);
            this.tabKorty.Size = new System.Drawing.Size(796, 395);
            this.tabKorty.TabIndex = 0;
            this.tabKorty.Text = "Korty";
            this.tabKorty.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(796, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPracownicy
            // 
            this.tabPracownicy.Controls.Add(this.btDodajPracownika);
            this.tabPracownicy.Location = new System.Drawing.Point(4, 22);
            this.tabPracownicy.Name = "tabPracownicy";
            this.tabPracownicy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPracownicy.Size = new System.Drawing.Size(736, 227);
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
            this.menuStrip1.Size = new System.Drawing.Size(824, 24);
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
            // Kalendarz
            // 
            this.Kalendarz.Location = new System.Drawing.Point(0, 0);
            this.Kalendarz.Name = "Kalendarz";
            this.Kalendarz.TabIndex = 0;
            this.Kalendarz.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Kalendarz_DateChanged);
            // 
            // dgKorty
            // 
            this.dgKorty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKorty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnGodziny,
            this.ColumnKort1,
            this.ColumnKort2,
            this.ColumnKort3,
            this.ColumnKort4});
            this.dgKorty.Location = new System.Drawing.Point(192, 19);
            this.dgKorty.Name = "dgKorty";
            this.dgKorty.Size = new System.Drawing.Size(500, 310);
            this.dgKorty.TabIndex = 1;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 460);
            this.Controls.Add(this.tcMainForm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Korty Tenisowe";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tcMainForm.ResumeLayout(false);
            this.tabKorty.ResumeLayout(false);
            this.tabPracownicy.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKorty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMainForm;
        private System.Windows.Forms.TabPage tabKorty;
        private System.Windows.Forms.TabPage tabPage2;
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
    }
}