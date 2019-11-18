namespace RenginiuBilietai3
{
    partial class Registration
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
            this.textBoxVardas = new System.Windows.Forms.TextBox();
            this.textBoxPavarde = new System.Windows.Forms.TextBox();
            this.textBoxPastas = new System.Windows.Forms.TextBox();
            this.textBoxSlapyvardis = new System.Windows.Forms.TextBox();
            this.textBoxSlaptazodis = new System.Windows.Forms.TextBox();
            this.textBoxPakartotiSlaptazodi = new System.Windows.Forms.TextBox();
            this.buttonRegistracija = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "REGISTRACIJA";
            // 
            // textBoxVardas
            // 
            this.textBoxVardas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVardas.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxVardas.Location = new System.Drawing.Point(92, 83);
            this.textBoxVardas.Multiline = true;
            this.textBoxVardas.Name = "textBoxVardas";
            this.textBoxVardas.Size = new System.Drawing.Size(289, 50);
            this.textBoxVardas.TabIndex = 200;
            this.textBoxVardas.Text = "Vardas";
            this.textBoxVardas.Enter += new System.EventHandler(this.textBoxVardas_Enter);
            this.textBoxVardas.Leave += new System.EventHandler(this.textBoxVardas_Leave);
            // 
            // textBoxPavarde
            // 
            this.textBoxPavarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPavarde.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPavarde.Location = new System.Drawing.Point(713, 83);
            this.textBoxPavarde.Multiline = true;
            this.textBoxPavarde.Name = "textBoxPavarde";
            this.textBoxPavarde.Size = new System.Drawing.Size(289, 50);
            this.textBoxPavarde.TabIndex = 200;
            this.textBoxPavarde.Text = "Pavardė";
            this.textBoxPavarde.Enter += new System.EventHandler(this.textBoxPavarde_Enter);
            this.textBoxPavarde.Leave += new System.EventHandler(this.textBoxPavarde_Leave);
            // 
            // textBoxPastas
            // 
            this.textBoxPastas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPastas.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPastas.Location = new System.Drawing.Point(201, 161);
            this.textBoxPastas.Multiline = true;
            this.textBoxPastas.Name = "textBoxPastas";
            this.textBoxPastas.Size = new System.Drawing.Size(621, 50);
            this.textBoxPastas.TabIndex = 200;
            this.textBoxPastas.Text = "El.paštas";
            this.textBoxPastas.Enter += new System.EventHandler(this.textBoxPastas_Enter);
            // 
            // textBoxSlapyvardis
            // 
            this.textBoxSlapyvardis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSlapyvardis.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxSlapyvardis.Location = new System.Drawing.Point(201, 251);
            this.textBoxSlapyvardis.Multiline = true;
            this.textBoxSlapyvardis.Name = "textBoxSlapyvardis";
            this.textBoxSlapyvardis.Size = new System.Drawing.Size(621, 50);
            this.textBoxSlapyvardis.TabIndex = 200;
            this.textBoxSlapyvardis.Text = "Slapyvardis";
            this.textBoxSlapyvardis.Enter += new System.EventHandler(this.textBoxSlapyvardis_Enter);
            // 
            // textBoxSlaptazodis
            // 
            this.textBoxSlaptazodis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSlaptazodis.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxSlaptazodis.Location = new System.Drawing.Point(201, 339);
            this.textBoxSlaptazodis.Name = "textBoxSlaptazodis";
            this.textBoxSlaptazodis.Size = new System.Drawing.Size(621, 44);
            this.textBoxSlaptazodis.TabIndex = 200;
            this.textBoxSlaptazodis.Text = "Slaptažodis";
            this.textBoxSlaptazodis.TextChanged += new System.EventHandler(this.textBoxSlaptazodis_TextChanged);
            this.textBoxSlaptazodis.Enter += new System.EventHandler(this.textBoxSlaptazodis_Enter);
            // 
            // textBoxPakartotiSlaptazodi
            // 
            this.textBoxPakartotiSlaptazodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPakartotiSlaptazodi.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPakartotiSlaptazodi.Location = new System.Drawing.Point(201, 422);
            this.textBoxPakartotiSlaptazodi.Name = "textBoxPakartotiSlaptazodi";
            this.textBoxPakartotiSlaptazodi.Size = new System.Drawing.Size(621, 44);
            this.textBoxPakartotiSlaptazodi.TabIndex = 200;
            this.textBoxPakartotiSlaptazodi.Text = "Pakartoti slaptažodį";
            this.textBoxPakartotiSlaptazodi.TextChanged += new System.EventHandler(this.textBoxPakartotiSlaptazodi_TextChanged);
            this.textBoxPakartotiSlaptazodi.Enter += new System.EventHandler(this.textBoxPakartotiSlaptazodi_Enter);
            // 
            // buttonRegistracija
            // 
            this.buttonRegistracija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistracija.Location = new System.Drawing.Point(163, 499);
            this.buttonRegistracija.Name = "buttonRegistracija";
            this.buttonRegistracija.Size = new System.Drawing.Size(707, 51);
            this.buttonRegistracija.TabIndex = 10;
            this.buttonRegistracija.Text = "REGISTRUOTIS";
            this.buttonRegistracija.UseVisualStyleBackColor = true;
            this.buttonRegistracija.Click += new System.EventHandler(this.buttonRegistracija_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(779, 566);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 20);
            this.label2.TabIndex = 201;
            this.label2.Text = "Susikurėte paskyra? Prisijunkite!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 606);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRegistracija);
            this.Controls.Add(this.textBoxPakartotiSlaptazodi);
            this.Controls.Add(this.textBoxSlaptazodis);
            this.Controls.Add(this.textBoxSlapyvardis);
            this.Controls.Add(this.textBoxPastas);
            this.Controls.Add(this.textBoxPavarde);
            this.Controls.Add(this.textBoxVardas);
            this.Controls.Add(this.label1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVardas;
        private System.Windows.Forms.TextBox textBoxPavarde;
        private System.Windows.Forms.TextBox textBoxPastas;
        private System.Windows.Forms.TextBox textBoxSlapyvardis;
        private System.Windows.Forms.TextBox textBoxSlaptazodis;
        private System.Windows.Forms.TextBox textBoxPakartotiSlaptazodi;
        private System.Windows.Forms.Button buttonRegistracija;
        private System.Windows.Forms.Label label2;
    }
}