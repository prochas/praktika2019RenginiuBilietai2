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
    public partial class RenginiaiForm : Form
    {
        Renginys Renginys1;
        Renginys Renginys2;
        Renginys Renginys3;


        public RenginiaiForm()
        {
           
            InitializeComponent();

            Renginys1 = new Renginys(1);

            labelPavadinimas1.Text = Renginys1.Pavadinimas;
            labelAprasymas1.Text = Renginys1.Aprasymas;
            labelData1.Text = Renginys1.Data;
            labelKaina1.Text = Renginys1.Kaina.ToString();
            labelVieta1.Text = Renginys1.Vieta;

            Renginys2 = new Renginys(2);

            labelPavadinimas2.Text = Renginys2.Pavadinimas;
            labelAprasymas2.Text = Renginys2.Aprasymas;
            labelData2.Text = Renginys2.Data;
            labelKaina2.Text = Renginys2.Kaina.ToString();
            labelVieta2.Text = Renginys2.Vieta;

            Renginys3 = new Renginys(3);

            labelPavadinimas3.Text = Renginys3.Pavadinimas;
            labelAprasymas3.Text = Renginys3.Aprasymas;
            labelData3.Text = Renginys3.Data;
            labelKaina3.Text = Renginys3.Kaina.ToString();
            labelVieta3.Text = Renginys3.Vieta;



        }

        private void labelPavadinimas_Click(object sender, EventArgs e)
        {

        }

        private void buttonAprasymas1_Click(object sender, EventArgs e)
        {
            
            AprasymasForm aprasymas1 = new AprasymasForm();
            
            aprasymas1.setAprasymas(Renginys1.Aprasymas);

            aprasymas1.Show();


        }

        private void buttonAprasymas2_Click(object sender, EventArgs e)
        {
            AprasymasForm aprasymas2 = new AprasymasForm();

            aprasymas2.setAprasymas(Renginys2.Aprasymas);

            aprasymas2.Show();
        }

        private void buttonAprasymas3_Click(object sender, EventArgs e)
        {
            AprasymasForm aprasymas3 = new AprasymasForm();

            aprasymas3.setAprasymas(Renginys3.Aprasymas);

            aprasymas3.Show();
        }

        private void pictureBoxPirkti1_Click(object sender, EventArgs e)
        {
            BilietasForm bilietasForm = new BilietasForm();
            bilietasForm.setRenginioId(1);
            bilietasForm.Show();
        }
    }
}
