namespace BackupProject
{
    partial class Sauvegarde
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
            this.btn_sauv_terminer = new System.Windows.Forms.Button();
            this.btn_sauv_annuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_sauv_terminer
            // 
            this.btn_sauv_terminer.Location = new System.Drawing.Point(797, 526);
            this.btn_sauv_terminer.Name = "btn_sauv_terminer";
            this.btn_sauv_terminer.Size = new System.Drawing.Size(75, 23);
            this.btn_sauv_terminer.TabIndex = 0;
            this.btn_sauv_terminer.Text = "Terminer";
            this.btn_sauv_terminer.UseVisualStyleBackColor = true;
            // 
            // btn_sauv_annuler
            // 
            this.btn_sauv_annuler.Location = new System.Drawing.Point(716, 526);
            this.btn_sauv_annuler.Name = "btn_sauv_annuler";
            this.btn_sauv_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_sauv_annuler.TabIndex = 1;
            this.btn_sauv_annuler.Text = "Annuler";
            this.btn_sauv_annuler.UseVisualStyleBackColor = true;
            this.btn_sauv_annuler.Click += new System.EventHandler(this.btn_sauv_annuler_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(530, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 500);
            this.label1.TabIndex = 2;
            // 
            // Sauvegarde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sauv_annuler);
            this.Controls.Add(this.btn_sauv_terminer);
            this.Name = "Sauvegarde";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sauvegarde";
            this.Load += new System.EventHandler(this.Sauvegarde_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sauv_terminer;
        private System.Windows.Forms.Button btn_sauv_annuler;
        private System.Windows.Forms.Label label1;
    }
}