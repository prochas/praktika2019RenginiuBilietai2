using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenginiuBilietai3
{
    public partial class Aprasymas1Bak : UserControl
    {
        public Aprasymas1Bak()
        {
            InitializeComponent();
        }

        private void Aprasymas1_Load(object sender, EventArgs e)
        {
            
        }
        
        public void setAprasymas(string aprasymas)
        {
            labelAprasymas.Text = aprasymas;
        }
    }
}
