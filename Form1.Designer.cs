namespace RenginiuBilietai3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPavadinimas = new System.Windows.Forms.TextBox();
            this.textBoxSlaptazodis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPrisijungimas = new System.Windows.Forms.Button();
            this.labelRegistracija = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "USER LOGIN";
            // 
            // textBoxPavadinimas
            // 
            this.textBoxPavadinimas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPavadinimas.Location = new System.Drawing.Point(202, 109);
            this.textBoxPavadinimas.Multiline = true;
            this.textBoxPavadinimas.Name = "textBoxPavadinimas";
            this.textBoxPavadinimas.Size = new System.Drawing.Size(494, 50);
            this.textBoxPavadinimas.TabIndex = 2;
            // 
            // textBoxSlaptazodis
            // 
            this.textBoxSlaptazodis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSlaptazodis.Location = new System.Drawing.Point(202, 224);
            this.textBoxSlaptazodis.Name = "textBoxSlaptazodis";
            this.textBoxSlaptazodis.Size = new System.Drawing.Size(494, 44);
            this.textBoxSlaptazodis.TabIndex = 3;
            this.textBoxSlaptazodis.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // buttonPrisijungimas
            // 
            this.buttonPrisijungimas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrisijungimas.Location = new System.Drawing.Point(178, 310);
            this.buttonPrisijungimas.Name = "buttonPrisijungimas";
            this.buttonPrisijungimas.Size = new System.Drawing.Size(550, 58);
            this.buttonPrisijungimas.TabIndex = 6;
            this.buttonPrisijungimas.Text = "LOGIN";
            this.buttonPrisijungimas.UseVisualStyleBackColor = true;
            this.buttonPrisijungimas.Click += new System.EventHandler(this.buttonPrisijungimas_Click);
            // 
            // labelRegistracija
            // 
            this.labelRegistracija.AutoSize = true;
            this.labelRegistracija.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRegistracija.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistracija.Location = new System.Drawing.Point(559, 404);
            this.labelRegistracija.Name = "labelRegistracija";
            this.labelRegistracija.Size = new System.Drawing.Size(331, 20);
            this.labelRegistracija.TabIndex = 7;
            this.labelRegistracija.Text = "Dar neturite paskyros? Užsiregistruokite";
            this.labelRegistracija.Click += new System.EventHandler(this.labelRegistracija_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 442);
            this.Controls.Add(this.labelRegistracija);
            this.Controls.Add(this.buttonPrisijungimas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSlaptazodis);
            this.Controls.Add(this.textBoxPavadinimas);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPavadinimas;
        private System.Windows.Forms.TextBox textBoxSlaptazodis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPrisijungimas;
        private System.Windows.Forms.Label labelRegistracija;
    }
}

