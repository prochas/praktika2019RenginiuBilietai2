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
    public partial class BilietasForm : Form
    {
        Renginys renginys;
        public BilietasForm()
        {
            InitializeComponent();
        }

        private void BilietasForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonPirkti_Click(object sender, EventArgs e)
        {

        }


        public void setRenginioId(int id)
        {
            renginys = new Renginys(id);
            labelRenginioPavadinimas.Text = renginys.Pavadinimas;
        }
    }
}
