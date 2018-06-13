namespace BackupProject
{
    partial class Accueil
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
            this.ajouter_sauv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ajouter_sauv
            // 
            this.ajouter_sauv.Location = new System.Drawing.Point(67, 82);
            this.ajouter_sauv.Name = "ajouter_sauv";
            this.ajouter_sauv.Size = new System.Drawing.Size(110, 23);
            this.ajouter_sauv.TabIndex = 0;
            this.ajouter_sauv.Text = "Ajouter Sauvegarde";
            this.ajouter_sauv.UseVisualStyleBackColor = true;
            this.ajouter_sauv.Click += new System.EventHandler(this.ajouter_sauvClick);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.ajouter_sauv);
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackupProject";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ajouter_sauv;
    }
}