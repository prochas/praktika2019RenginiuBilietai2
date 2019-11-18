using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace RenginiuBilietai3
{
    abstract class Prisijungimas
    {
        private int PrisijungimoID;
        private string VartotojoVardas;
        private string Slaptazodis;
        private bool Ijungtas;
        abstract public string LoginTable { get; }


        public bool Login(string username, string password)
        {

            DB db = new DB();

            string slapyvardis = username;
            string slaptazodis = password;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn and `password` = @pass", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = slapyvardis;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = slaptazodis;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
                //

            }
           
            return false;
        }
        public bool Logout()
        {
            return true;
        }

    }
}
