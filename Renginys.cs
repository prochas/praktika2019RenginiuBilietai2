using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace RenginiuBilietai3
{
    class Renginys
    {
        public Renginys(int id)
        {
            RenginioId = id;
            setData();
        }
        public int RenginioId { get; set; }
        public string Pavadinimas { get; set; }
        public string Aprasymas { get; set; }
        public decimal Kaina { get; set; }
        public string Vieta { get; set; }
        public string Data { get; set; }


        public void setData()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `renginiai` WHERE `renginio_id` = @id", db.getConnection());

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = RenginioId;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];

                Pavadinimas = row["pavadinimas"].ToString();
                Aprasymas = row["aprasymas"].ToString();
                Kaina = Convert.ToDecimal(row["kaina"].ToString());
                Vieta = row["vieta"].ToString();
                Data = row["data"].ToString();

            }
        }
    }
}
