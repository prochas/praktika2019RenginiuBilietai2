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
    public partial class PrisijungimasForm : Form
    {

        public int vartotojoId;

        public PrisijungimasForm()
        {
            InitializeComponent();
        }

        private void buttonPrisijungimas_Click(object sender, EventArgs e)
        {

            User vartotojas = new User();
            bool loggedIn = vartotojas.Login(textBoxPavadinimas.Text, textBoxSlaptazodis.Text);
            if (loggedIn)
            {
                this.Hide();
                MainForm pagrindinis = new MainForm();
                pagrindinis.setVartotojoId(vartotojas.PrisijungimoID);
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
