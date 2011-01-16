namespace KortyTenisowe
{
    partial class ZaplanowaneMeczeForm
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
            this.rgvZaplanowaneMecze = new Telerik.WinControls.UI.RadGridView();
            this.rbtUsunMecz = new Telerik.WinControls.UI.RadButton();
            this.rDDLTurniej = new Telerik.WinControls.UI.RadDropDownList();
            this.rlbTurniej = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.rgvZaplanowaneMecze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtUsunMecz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLTurniej)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbTurniej)).BeginInit();
            this.SuspendLayout();
            // 
            // rgvZaplanowaneMecze
            // 
            this.rgvZaplanowaneMecze.Location = new System.Drawing.Point(159, 12);
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.Width = 70;
            gridViewTextBoxColumn2.HeaderText = "Zawodnik 1.";
            gridViewTextBoxColumn2.Name = "Zawodnik 1.";
            gridViewTextBoxColumn2.Width = 250;
            gridViewTextBoxColumn3.HeaderText = "vs";
            gridViewTextBoxColumn3.Name = "vs";
            gridViewTextBoxColumn4.HeaderText = "Zawodnik 2.";
            gridViewTextBoxColumn4.Name = "Zawodnik2";
            gridViewTextBoxColumn4.Width = 250;
            this.rgvZaplanowaneMecze.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.rgvZaplanowaneMecze.Name = "rgvZaplanowaneMecze";
            this.rgvZaplanowaneMecze.ReadOnly = true;
            this.rgvZaplanowaneMecze.Size = new System.Drawing.Size(639, 328);
            this.rgvZaplanowaneMecze.TabIndex = 0;
            this.rgvZaplanowaneMecze.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgvZaplanowaneMecze_CellClick);
            // 
            // rbtUsunMecz
            // 
            this.rbtUsunMecz.Location = new System.Drawing.Point(12, 316);
            this.rbtUsunMecz.Name = "rbtUsunMecz";
            this.rbtUsunMecz.Size = new System.Drawing.Size(130, 24);
            this.rbtUsunMecz.TabIndex = 1;
            this.rbtUsunMecz.Text = "Usuń mecz";
            this.rbtUsunMecz.Click += new System.EventHandler(this.rbtUsunMecz_Click);
            // 
            // rDDLTurniej
            // 
            this.rDDLTurniej.Location = new System.Drawing.Point(12, 34);
            this.rDDLTurniej.Name = "rDDLTurniej";
            this.rDDLTurniej.Size = new System.Drawing.Size(141, 22);
            this.rDDLTurniej.TabIndex = 2;
            this.rDDLTurniej.Text = "Turniej";
            this.rDDLTurniej.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.rDDLTurniej_SelectedIndexChanged);
            // 
            // rlbTurniej
            // 
            this.rlbTurniej.Location = new System.Drawing.Point(12, 12);
            this.rlbTurniej.Name = "rlbTurniej";
            this.rlbTurniej.Size = new System.Drawing.Size(84, 16);
            this.rlbTurniej.TabIndex = 3;
            this.rlbTurniej.Text = "Wybierz turniej:";
            // 
            // ZaplanowaneMeczeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 354);
            this.Controls.Add(this.rlbTurniej);
            this.Controls.Add(this.rDDLTurniej);
            this.Controls.Add(this.rbtUsunMecz);
            this.Controls.Add(this.rgvZaplanowaneMecze);
            this.Name = "ZaplanowaneMeczeForm";
            this.Text = "ZaplanowaneMeczeForm";
            ((System.ComponentModel.ISupportInitialize)(this.rgvZaplanowaneMecze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtUsunMecz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDDLTurniej)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbTurniej)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvZaplanowaneMecze;
        private Telerik.WinControls.UI.RadButton rbtUsunMecz;
        private Telerik.WinControls.UI.RadDropDownList rDDLTurniej;
        private Telerik.WinControls.UI.RadLabel rlbTurniej;
    }
}