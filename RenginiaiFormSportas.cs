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
    public partial class RenginiaiFormSportas : Form
    {
        Renginys Renginys4;
        Renginys Renginys5;
        Renginys Renginys6;

        public int vartotojoId;


        public RenginiaiFormSportas()
        {
            InitializeComponent();

            Renginys4 = new Renginys(4);

            labelPavadinimas4.Text = Renginys4.Pavadinimas;
            labelAprasymas4.Text = Renginys4.Aprasymas;
            labelData4.Text = Renginys4.Data;
            labelKaina4.Text = Renginys4.Kaina.ToString();
            labelVieta4.Text = Renginys4.Vieta;

            Renginys5 = new Renginys(5);

            labelPavadinimas5.Text = Renginys5.Pavadinimas;
            labelAprasymas5.Text = Renginys5.Aprasymas;
            labelData5.Text = Renginys5.Data;
            labelKaina5.Text = Renginys5.Kaina.ToString();
            labelVieta5.Text = Renginys5.Vieta;

            Renginys6 = new Renginys(6);

            labelPavadinimas6.Text = Renginys6.Pavadinimas;
            labelAprasymas6.Text = Renginys6.Aprasymas;
            labelData6.Text = Renginys6.Data;
            labelKaina6.Text = Renginys6.Kaina.ToString();
            labelVieta6.Text = Renginys6.Vieta;


        }

        private void buttonTeatras_Click(object sender, EventArgs e)
        {
            this.Hide();

            RenginiaiForm renginiaiTeatras = new RenginiaiForm();
            renginiaiTeatras.Show();
        }

        private void buttonAprasymas1_Click(object sender, EventArgs e)
        {
            AprasymasForm aprasymas4 = new AprasymasForm();

            aprasymas4.setAprasymas(Renginys4.Aprasymas);

            aprasymas4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AprasymasForm aprasymas5 = new AprasymasForm();

            aprasymas5.setAprasymas(Renginys5.Aprasymas);

            aprasymas5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AprasymasForm aprasymas6 = new AprasymasForm();

            aprasymas6.setAprasymas(Renginys6.Aprasymas);

            aprasymas6.Show();
        }

        

        private void pictureBoxPirkti1_Click(object sender, EventArgs e)
        {
            BilietasForm bilietasForm = new BilietasForm();
            bilietasForm.setRenginioId(4);
            bilietasForm.setVartotojoId(vartotojoId);
            bilietasForm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            BilietasForm bilietasForm = new BilietasForm();
            bilietasForm.setRenginioId(5);
            bilietasForm.setVartotojoId(vartotojoId);
            bilietasForm.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            BilietasForm bilietasForm = new BilietasForm();
            bilietasForm.setRenginioId(6);
            bilietasForm.setVartotojoId(vartotojoId);
            bilietasForm.Show();
        }

        public void setVartotojoId(int id)
        {
            vartotojoId = id;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainForm pagrindinisForma = new MainForm();

            pagrindinisForma.Show();
        }
    }
}
