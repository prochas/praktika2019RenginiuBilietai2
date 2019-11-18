using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenginiuBilietai3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPrisijungimas_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            string slapyvardis = textBoxPavadinimas.Text;
            string slaptazodis = textBoxSlaptazodis.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn and `password` = @pass", db.getConnection() );

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = slapyvardis;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = slaptazodis;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                this.Hide();
                MainForm pagrindinis = new MainForm();
                pagrindinis.Show();
            }

        }

        private void labelRegistracija_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registracijosforma = new Registration();
            registracijosforma.Show();
        }
    }
}
