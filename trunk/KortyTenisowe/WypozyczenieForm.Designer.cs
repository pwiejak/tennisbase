namespace KortyTenisowe
{
    partial class WypozyczenieForm
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
            this.dtpWypozyczenieStart = new System.Windows.Forms.DateTimePicker();
            this.rddlKlienci = new Telerik.WinControls.UI.RadDropDownList();
            this.rtbGodzinaStart = new Telerik.WinControls.UI.RadTextBox();
            this.dtpWypozyczenieEnd = new System.Windows.Forms.DateTimePicker();
            this.rlblStart = new Telerik.WinControls.UI.RadLabel();
            this.rlblOddanie = new Telerik.WinControls.UI.RadLabel();
            this.rlblGodziny = new Telerik.WinControls.UI.RadLabel();
            this.rtbGodzinaEnd = new Telerik.WinControls.UI.RadTextBox();
            this.rlblMyslnik = new Telerik.WinControls.UI.RadLabel();
            this.rbtZatwierdz = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rddlKlienci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbGodzinaStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlblStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlblOddanie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlblGodziny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbGodzinaEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlblMyslnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtZatwierdz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpWypozyczenieStart
            // 
            this.dtpWypozyczenieStart.Location = new System.Drawing.Point(12, 34);
            this.dtpWypozyczenieStart.Name = "dtpWypozyczenieStart";
            this.dtpWypozyczenieStart.Size = new System.Drawing.Size(200, 20);
            this.dtpWypozyczenieStart.TabIndex = 0;
            this.dtpWypozyczenieStart.ValueChanged += new System.EventHandler(this.dtpWypozyczenieStart_ValueChanged);
            // 
            // rddlKlienci
            // 
            this.rddlKlienci.Location = new System.Drawing.Point(118, 74);
            this.rddlKlienci.Name = "rddlKlienci";
            this.rddlKlienci.Size = new System.Drawing.Size(200, 20);
            this.rddlKlienci.TabIndex = 1;
            this.rddlKlienci.Text = "Klient";
            // 
            // rtbGodzinaStart
            // 
            this.rtbGodzinaStart.Location = new System.Drawing.Point(107, 137);
            this.rtbGodzinaStart.Name = "rtbGodzinaStart";
            this.rtbGodzinaStart.Size = new System.Drawing.Size(100, 20);
            this.rtbGodzinaStart.TabIndex = 2;
            this.rtbGodzinaStart.TabStop = false;
            this.rtbGodzinaStart.Text = "godz.";
            // 
            // dtpWypozyczenieEnd
            // 
            this.dtpWypozyczenieEnd.Location = new System.Drawing.Point(218, 34);
            this.dtpWypozyczenieEnd.Name = "dtpWypozyczenieEnd";
            this.dtpWypozyczenieEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpWypozyczenieEnd.TabIndex = 3;
            this.dtpWypozyczenieEnd.ValueChanged += new System.EventHandler(this.dtpWypozyczenieEnd_ValueChanged);
            // 
            // rlblStart
            // 
            this.rlblStart.Location = new System.Drawing.Point(12, 10);
            this.rlblStart.Name = "rlblStart";
            this.rlblStart.Size = new System.Drawing.Size(51, 18);
            this.rlblStart.TabIndex = 4;
            this.rlblStart.Text = "Poczπtek";
            // 
            // rlblOddanie
            // 
            this.rlblOddanie.Location = new System.Drawing.Point(218, 10);
            this.rlblOddanie.Name = "rlblOddanie";
            this.rlblOddanie.Size = new System.Drawing.Size(49, 18);
            this.rlblOddanie.TabIndex = 5;
            this.rlblOddanie.Text = "Oddanie";
            // 
            // rlblGodziny
            // 
            this.rlblGodziny.Location = new System.Drawing.Point(107, 113);
            this.rlblGodziny.Name = "rlblGodziny";
            this.rlblGodziny.Size = new System.Drawing.Size(129, 18);
            this.rlblGodziny.TabIndex = 6;
            this.rlblGodziny.Text = "Godziny (jeúli konieczne)";
            // 
            // rtbGodzinaEnd
            // 
            this.rtbGodzinaEnd.Location = new System.Drawing.Point(230, 139);
            this.rtbGodzinaEnd.Name = "rtbGodzinaEnd";
            this.rtbGodzinaEnd.Size = new System.Drawing.Size(100, 20);
            this.rtbGodzinaEnd.TabIndex = 7;
            this.rtbGodzinaEnd.TabStop = false;
            this.rtbGodzinaEnd.Text = "godz.";
            // 
            // rlblMyslnik
            // 
            this.rlblMyslnik.Location = new System.Drawing.Point(213, 137);
            this.rlblMyslnik.Name = "rlblMyslnik";
            this.rlblMyslnik.Size = new System.Drawing.Size(11, 18);
            this.rlblMyslnik.TabIndex = 8;
            this.rlblMyslnik.Text = "-";
            // 
            // rbtZatwierdz
            // 
            this.rbtZatwierdz.Location = new System.Drawing.Point(152, 177);
            this.rbtZatwierdz.Name = "rbtZatwierdz";
            this.rbtZatwierdz.Size = new System.Drawing.Size(130, 24);
            this.rbtZatwierdz.TabIndex = 9;
            this.rbtZatwierdz.Text = "Zatwierdü";
            this.rbtZatwierdz.Click += new System.EventHandler(this.rbtZatwierdz_Click);
            // 
            // WypozyczenieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 231);
            this.Controls.Add(this.rbtZatwierdz);
            this.Controls.Add(this.rlblMyslnik);
            this.Controls.Add(this.rtbGodzinaEnd);
            this.Controls.Add(this.rlblGodziny);
            this.Controls.Add(this.rlblOddanie);
            this.Controls.Add(this.rlblStart);
            this.Controls.Add(this.dtpWypozyczenieEnd);
            this.Controls.Add(this.rtbGodzinaStart);
            this.Controls.Add(this.rddlKlienci);
            this.Controls.Add(this.dtpWypozyczenieStart);
            this.Name = "WypozyczenieForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "WypozyczenieForm";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.rddlKlienci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbGodzinaStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlblStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlblOddanie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlblGodziny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbGodzinaEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlblMyslnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtZatwierdz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpWypozyczenieStart;
        private Telerik.WinControls.UI.RadDropDownList rddlKlienci;
        private Telerik.WinControls.UI.RadTextBox rtbGodzinaStart;
        private System.Windows.Forms.DateTimePicker dtpWypozyczenieEnd;
        private Telerik.WinControls.UI.RadLabel rlblStart;
        private Telerik.WinControls.UI.RadLabel rlblOddanie;
        private Telerik.WinControls.UI.RadLabel rlblGodziny;
        private Telerik.WinControls.UI.RadTextBox rtbGodzinaEnd;
        private Telerik.WinControls.UI.RadLabel rlblMyslnik;
        private Telerik.WinControls.UI.RadButton rbtZatwierdz;
    }
}

