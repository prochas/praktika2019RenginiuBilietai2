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
            this.listBoxKiekis = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKlausimas
            // 
            this.labelKlausimas.AutoSize = true;
            this.labelKlausimas.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKlausimas.Location = new System.Drawing.Point(394, 9);
            this.labelKlausimas.Name = "labelKlausimas";
            this.labelKlausimas.Size = new System.Drawing.Size(239, 30);
            this.labelKlausimas.TabIndex = 0;
            this.labelKlausimas.Text = "Bilieto pirkimas";
            this.labelKlausimas.Click += new System.EventHandler(this.labelKlausimas_Click);
            // 
            // buttonPirkti
            // 
            this.buttonPirkti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPirkti.Location = new System.Drawing.Point(814, 397);
            this.buttonPirkti.Name = "buttonPirkti";
            this.buttonPirkti.Size = new System.Drawing.Size(170, 45);
            this.buttonPirkti.TabIndex = 1;
            this.buttonPirkti.Text = "Pirkti";
            this.buttonPirkti.UseVisualStyleBackColor = true;
            this.buttonPirkti.Click += new System.EventHandler(this.buttonPirkti_Click);
            // 
            // labelRenginioPavadinimas
            // 
            this.labelRenginioPavadinimas.AutoSize = true;
            this.labelRenginioPavadinimas.Location = new System.Drawing.Point(40, 104);
            this.labelRenginioPavadinimas.Name = "labelRenginioPavadinimas";
            this.labelRenginioPavadinimas.Size = new System.Drawing.Size(164, 20);
            this.labelRenginioPavadinimas.TabIndex = 2;
            this.labelRenginioPavadinimas.Text = "Renginio pavadinimas";
            this.labelRenginioPavadinimas.Click += new System.EventHandler(this.labelRenginioPavadinimas_Click);
            // 
            // listBoxEile
            // 
            this.listBoxEile.FormattingEnabled = true;
            this.listBoxEile.ItemHeight = 20;
            this.listBoxEile.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.listBoxEile.Location = new System.Drawing.Point(256, 195);
            this.listBoxEile.Name = "listBoxEile";
            this.listBoxEile.Size = new System.Drawing.Size(86, 184);
            this.listBoxEile.TabIndex = 3;
            this.listBoxEile.SelectedIndexChanged += new System.EventHandler(this.listBoxEile_SelectedIndexChanged);
            // 
            // listBoxVieta
            // 
            this.listBoxVieta.FormattingEnabled = true;
            this.listBoxVieta.ItemHeight = 20;
            this.listBoxVieta.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.listBoxVieta.Location = new System.Drawing.Point(44, 195);
            this.listBoxVieta.Name = "listBoxVieta";
            this.listBoxVieta.Size = new System.Drawing.Size(97, 184);
            this.listBoxVieta.TabIndex = 4;
            // 
            // listBoxKiekis
            // 
            this.listBoxKiekis.FormattingEnabled = true;
            this.listBoxKiekis.ItemHeight = 20;
            this.listBoxKiekis.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.listBoxKiekis.Location = new System.Drawing.Point(496, 195);
            this.listBoxKiekis.Name = "listBoxKiekis";
            this.listBoxKiekis.Size = new System.Drawing.Size(97, 184);
            this.listBoxKiekis.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pasirinkite vietą:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pasirinkite eilę:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pasirinkite bilietų kiekį:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Renginio pavadinimas:";
            // 
            // BilietasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 454);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxKiekis);
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
        private System.Windows.Forms.ListBox listBoxKiekis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}