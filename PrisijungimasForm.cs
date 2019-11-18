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

        public PrisijungimasForm()
        {
            InitializeComponent();
        }

        private void buttonPrisijungimas_Click(object sender, EventArgs e)
        {

            User vartotojas = new User();
            bool loggedIn = vartotojas.Login(textBoxPavadinimas.Text, textBoxSlaptazodis.Text);
            if(loggedIn)
            {
                this.Hide();
                RenginiaiForm pagrindinis = new RenginiaiForm();
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
