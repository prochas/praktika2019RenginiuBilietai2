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
    public partial class AprasymasForm : Form
    {
        public AprasymasForm()
        {


            InitializeComponent();
        }


        public void setAprasymas(string aprasymas)
        {
            labelAprasymas.Text = aprasymas;
        }
    }
}
