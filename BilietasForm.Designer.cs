namespace RenginiuBilietai3
{
    partial class BilietasForm
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
            this.labelKlausimas = new System.Windows.Forms.Label();
            this.buttonPirkti = new System.Windows.Forms.Button();
            this.labelRenginioPavadinimas = new System.Windows.Forms.Label();
            this.listBoxEile = new System.Windows.Forms.ListBox();
            this.listBoxVieta = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelKlausimas
            // 
            this.labelKlausimas.AutoSize = true;
            this.labelKlausimas.Location = new System.Drawing.Point(462, 9);
            this.labelKlausimas.Name = "labelKlausimas";
            this.labelKlausimas.Size = new System.Drawing.Size(114, 20);
            this.labelKlausimas.TabIndex = 0;
            this.labelKlausimas.Text = "Bilieto pirkimas";
            // 
            // buttonPirkti
            // 
            this.buttonPirkti.Location = new System.Drawing.Point(863, 387);
            this.buttonPirkti.Name = "buttonPirkti";
            this.buttonPirkti.Size = new System.Drawing.Size(82, 45);
            this.buttonPirkti.TabIndex = 1;
            this.buttonPirkti.Text = "Pirkti";
            this.buttonPirkti.UseVisualStyleBackColor = true;
            this.buttonPirkti.Click += new System.EventHandler(this.buttonPirkti_Click);
            // 
            // labelRenginioPavadinimas
            // 
            this.labelRenginioPavadinimas.AutoSize = true;
            this.labelRenginioPavadinimas.Location = new System.Drawing.Point(36, 92);
            this.labelRenginioPavadinimas.Name = "labelRenginioPavadinimas";
            this.labelRenginioPavadinimas.Size = new System.Drawing.Size(164, 20);
            this.labelRenginioPavadinimas.TabIndex = 2;
            this.labelRenginioPavadinimas.Text = "Renginio pavadinimas";
            // 
            // listBoxEile
            // 
            this.listBoxEile.FormattingEnabled = true;
            this.listBoxEile.ItemHeight = 20;
            this.listBoxEile.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.listBoxEile.Location = new System.Drawing.Point(40, 195);
            this.listBoxEile.Name = "listBoxEile";
            this.listBoxEile.Size = new System.Drawing.Size(86, 104);
            this.listBoxEile.TabIndex = 3;
            // 
            // listBoxVieta
            // 
            this.listBoxVieta.FormattingEnabled = true;
            this.listBoxVieta.ItemHeight = 20;
            this.listBoxVieta.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.listBoxVieta.Location = new System.Drawing.Point(196, 195);
            this.listBoxVieta.Name = "listBoxVieta";
            this.listBoxVieta.Size = new System.Drawing.Size(97, 104);
            this.listBoxVieta.TabIndex = 4;
            // 
            // BilietasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 454);
            this.Controls.Add(this.listBoxVieta);
            this.Controls.Add(this.listBoxEile);
            this.Controls.Add(this.labelRenginioPavadinimas);
            this.Controls.Add(this.buttonPirkti);
            this.Controls.Add(this.labelKlausimas);
            this.Name = "BilietasForm";
            this.Text = "BilietasForm";
            this.Load += new System.EventHandler(this.BilietasForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKlausimas;
        private System.Windows.Forms.Button buttonPirkti;
        private System.Windows.Forms.Label labelRenginioPavadinimas;
        private System.Windows.Forms.ListBox listBoxEile;
        private System.Windows.Forms.ListBox listBoxVieta;
    }
}