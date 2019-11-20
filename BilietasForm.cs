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
    public partial class BilietasForm : Form
    {
        Renginys renginys;
        int vartotojo_id;
        public BilietasForm()
        {
            InitializeComponent();
        }

        private void BilietasForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonPirkti_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `bilietai`(`renginio_id`, `vartotojo_id`, `vieta`, `eile`, `kiekis`) VALUES (@renginio_id, @vartotojo_id, @vieta, @eile, @kiekis)", db.getConnection());

            command.Parameters.Add("@renginio_id", MySqlDbType.VarChar).Value = renginys.RenginioId;
            command.Parameters.Add("@vartotojo_id", MySqlDbType.VarChar).Value = vartotojo_id;
            command.Parameters.Add("@vieta", MySqlDbType.VarChar).Value = Convert.ToInt32(listBoxVieta.GetItemText(listBoxVieta.SelectedItem));
            command.Parameters.Add("@eile", MySqlDbType.VarChar).Value = Convert.ToInt32(listBoxEile.GetItemText(listBoxEile.SelectedItem));
            command.Parameters.Add("@kiekis", MySqlDbType.VarChar).Value = Convert.ToInt32(listBoxKiekis.GetItemText(listBoxKiekis.SelectedItem));


            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Bilietas nupirkas ir išsiustas jums į El.paštą!", "Bilietas nupirktas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERROR");
            }

        }


        public void setRenginioId(int id)
        {
            renginys = new Renginys(id);
            labelRenginioPavadinimas.Text = renginys.Pavadinimas;
        }

        public void setVartotojoId(int id)
        {
            vartotojo_id = id;
        }

        private void labelRenginioPavadinimas_Click(object sender, EventArgs e)
        {

        }

        private void labelKlausimas_Click(object sender, EventArgs e)
        {

        }

        private void listBoxEile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
