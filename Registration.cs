using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RenginiuBilietai3
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void textBoxVardas_Enter(object sender, EventArgs e)
        {
            String fname = textBoxVardas.Text;
            if (fname.Equals("Vardas"))
            {
                textBoxVardas.Text = "";
                textBoxVardas.ForeColor = Color.Black;
            }
        }

        private void textBoxVardas_Leave(object sender, EventArgs e)
        {

        }

        private void textBoxPavarde_Enter(object sender, EventArgs e)
        {
            String lastname = textBoxPavarde.Text;
            if (lastname.Equals("Pavardė"))
            {
                textBoxPavarde.Text = "";
                textBoxPavarde.ForeColor = Color.Black;
            }
        }

        private void textBoxPavarde_Leave(object sender, EventArgs e)
        {

        }

        private void textBoxPastas_Enter(object sender, EventArgs e)
        {
            String pastas = textBoxPastas.Text;
            if (pastas.Equals("El.paštas"))
            {
                textBoxPastas.Text = "";
                textBoxPastas.ForeColor = Color.Black;
            }
        }

        private void textBoxSlapyvardis_Enter(object sender, EventArgs e)
        {
            String slapyvardis = textBoxSlapyvardis.Text;
            if (slapyvardis.Equals("Slapyvardis"))
            {
                textBoxSlapyvardis.Text = "";
                textBoxSlapyvardis.ForeColor = Color.Black;
            }
        }

        private void textBoxSlaptazodis_Enter(object sender, EventArgs e)
        {
            String slaptazodis = textBoxSlaptazodis.Text;
            if (slaptazodis.Equals("Slaptažodis"))
            {
                textBoxSlaptazodis.Text = "";
                textBoxSlaptazodis.UseSystemPasswordChar = true;
                textBoxSlaptazodis.ForeColor = Color.Black;
            }
        }

        private void textBoxPakartotiSlaptazodi_Enter(object sender, EventArgs e)
        {
            String pSlaptazodi = textBoxPakartotiSlaptazodi.Text;
            if (pSlaptazodi.Equals("Pakartoti slaptažodį"))
            {
                textBoxPakartotiSlaptazodi.Text = "";
                textBoxPakartotiSlaptazodi.UseSystemPasswordChar = true;
                textBoxPakartotiSlaptazodi.ForeColor = Color.Black;
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void textBoxSlaptazodis_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegistracija_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`Vardas`, `Pavarde`, `email`, `username`, `password`) VALUES (@fn, @ln, @email, @usn, @pass)", db.getConnection());

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = textBoxVardas.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = textBoxPavarde.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxPastas.Text;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxSlapyvardis.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxSlaptazodis.Text;


            db.openConnection();

            // check if the textboxes contains the default values 
            if (!checkTextBoxesValues())
            {
                // check if the password equal the confirm password
                if (textBoxSlaptazodis.Text.Equals(textBoxPakartotiSlaptazodi.Text))
                {
                    // check if this username already exists
                    if (checkUsername())
                    {
                        MessageBox.Show("Šis slapyvardis jau yra užimtas", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // execute the query
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Paskyra sukurta!", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Blogas patvirtinimo slaptažodis", "Password Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Užpildykite visus laukus", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }


            db.closeConnection();
        }

        private void textBoxPakartotiSlaptazodi_TextChanged(object sender, EventArgs e)
        {

        }

        public Boolean checkUsername()
        {
            DB db = new DB();

            String username = textBoxSlapyvardis.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            //-------------------

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Boolean checkTextBoxesValues()
        {
            String vardas = textBoxVardas.Text;
            String pavarde = textBoxPavarde.Text;
            String pastas = textBoxPastas.Text;
            String slapyvardis = textBoxSlapyvardis.Text;
            String slaptazodis = textBoxSlaptazodis.Text;

            if (vardas.Equals("Vardas") || pavarde.Equals("Pavardė") ||
                pastas.Equals("El.paštas") || slapyvardis.Equals("Slapyvardis")
                || slaptazodis.Equals("Slaptažodis"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 prisijungimas = new Form1();
            prisijungimas.Show();
        }
    }

}

