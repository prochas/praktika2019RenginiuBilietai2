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
    public partial class MainForm : Form
    {

       public int vartotojoId;
        public MainForm()
        {
            InitializeComponent();
        }

        private void labelPavadinimasMain_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelAtsijungti_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrisijungimasForm form1 = new PrisijungimasForm();
            form1.Show();
        }

        private void labelTeatras_Click(object sender, EventArgs e)
        {

        }

        private void buttonNaujametineAprasymas_Click(object sender, EventArgs e)
        {

         //  Aprasymas1.BringToFront();

        }

        private void pictureBoxNaujametinis_Click(object sender, EventArgs e)
        {
            this.Hide();

            RenginiaiForm renginiai = new RenginiaiForm();
            renginiai.Show();
        }

        public void setVartotojoId(int id)
        {
            vartotojoId = id;
        }

        private void pictureBoxKakeMake_Click(object sender, EventArgs e)
        {
            this.Hide();

            RenginiaiForm renginiai = new RenginiaiForm();
            renginiai.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();

            RenginiaiForm renginiai = new RenginiaiForm();
            renginiai.Show();
        }

        private void buttonSportas_Click(object sender, EventArgs e)
        {
            panelMainSportas.BringToFront();
            panelMainTeatras.Visible = false;
            panelMainSportas.Visible = true;
            

        }

        private void buttonTeatras_Click(object sender, EventArgs e)
        {
            panelMainTeatras.Visible = true;
            panelMainSportas.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        { 
            this.Hide();
            RenginiaiFormSportas renginiai = new RenginiaiFormSportas();
            renginiai.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();

            RenginiaiFormSportas renginiai = new RenginiaiFormSportas();

            renginiai.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();

            RenginiaiFormSportas renginiai = new RenginiaiFormSportas();
            renginiai.Show();
        }

        private void panelMainSportas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonKrepselis_Click(object sender, EventArgs e)
        {
            this.Hide();

            KrepselisForm krepselis = new KrepselisForm();
            krepselis.Show();
        }
    }
}
