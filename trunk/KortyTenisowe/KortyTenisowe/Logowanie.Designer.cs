namespace KortyTenisowe
{
    partial class Logowanie
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
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.btLogowanie = new System.Windows.Forms.Button();
            this.label1Logowanie = new System.Windows.Forms.Label();
            this.tbHaslo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(32, 70);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(273, 20);
            this.tbLogin.TabIndex = 0;
            this.tbLogin.Text = "Login...";
            this.tbLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbLogin_MouseClick);
            // 
            // btLogowanie
            // 
            this.btLogowanie.Location = new System.Drawing.Point(119, 151);
            this.btLogowanie.Name = "btLogowanie";
            this.btLogowanie.Size = new System.Drawing.Size(75, 23);
            this.btLogowanie.TabIndex = 2;
            this.btLogowanie.Text = "Zatwierdź";
            this.btLogowanie.UseVisualStyleBackColor = true;
            this.btLogowanie.Click += new System.EventHandler(this.btLogowanie_Click);
            // 
            // label1Logowanie
            // 
            this.label1Logowanie.AutoSize = true;
            this.label1Logowanie.Location = new System.Drawing.Point(29, 33);
            this.label1Logowanie.Name = "label1Logowanie";
            this.label1Logowanie.Size = new System.Drawing.Size(165, 13);
            this.label1Logowanie.TabIndex = 2;
            this.label1Logowanie.Text = "Podaj nazwę użytkownika i hasło";
            // 
            // tbHaslo
            // 
            this.tbHaslo.Location = new System.Drawing.Point(32, 107);
            this.tbHaslo.Name = "tbHaslo";
            this.tbHaslo.Size = new System.Drawing.Size(273, 20);
            this.tbHaslo.TabIndex = 1;
            this.tbHaslo.Text = "Hasło...";
            this.tbHaslo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbHaslo_MouseClick);
            this.tbHaslo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbHaslo_KeyDown);
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 262);
            this.Controls.Add(this.tbHaslo);
            this.Controls.Add(this.label1Logowanie);
            this.Controls.Add(this.btLogowanie);
            this.Controls.Add(this.tbLogin);
            this.Name = "Logowanie";
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Button btLogowanie;
        private System.Windows.Forms.Label label1Logowanie;
        private System.Windows.Forms.TextBox tbHaslo;
    }
}

