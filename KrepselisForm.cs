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
    public partial class KrepselisForm : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;");
        MySqlCommand command;
        MySqlDataReader mdr;

        public KrepselisForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            string selectQuery = "SELECT * FROM tickets_db.bilietai WHERE vartotojo_id=" + int.Parse(textBoxId.Text);

            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                textBoxEile.Text = mdr.GetInt32("eile").ToString();
                textBoxVieta.Text = mdr.GetInt32("vieta").ToString();
                textBoxKiekis.Text = mdr.GetInt32("kiekis").ToString();
            }
            else
            {
                textBoxId.Text = "";
                textBoxEile.Text = "";
                textBoxVieta.Text = "";
                textBoxKiekis.Text = "";
                MessageBox.Show("Nera nurodyto ID");
            }
            connection.Close();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainForm pagrindinis = new MainForm();
            pagrindinis.Show();
        }
    }
}
