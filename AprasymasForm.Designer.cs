namespace RenginiuBilietai3
{
    partial class AprasymasForm
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
            this.labelAprasymas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAprasymas
            // 
            this.labelAprasymas.AutoSize = true;
            this.labelAprasymas.Location = new System.Drawing.Point(418, 140);
            this.labelAprasymas.Name = "labelAprasymas";
            this.labelAprasymas.Size = new System.Drawing.Size(65, 20);
            this.labelAprasymas.TabIndex = 0;
            this.labelAprasymas.Text = "Tekstas";
            // 
            // AprasymasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 462);
            this.Controls.Add(this.labelAprasymas);
            this.Name = "AprasymasForm";
            this.Text = "AprasymasForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAprasymas;
    }
}