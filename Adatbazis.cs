using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace tagdij_winform_crud
{

    internal class Adatbazis
    {
        MySqlConnection _connection;
        MySqlCommand _command;
        public Adatbazis()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Database = "tagdij";
            builder.Password = "";
            _connection = new MySqlConnection(builder.ConnectionString);
            _command = _connection.CreateCommand();
            try
            {
                KapcsNyit();
                KapcsZar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private void KapcsZar()
        {
            if (_connection.State != System.Data.ConnectionState.Closed)
            {
                _connection.Close();
            }
        }

        private void KapcsNyit()
        {
            if (_connection.State != System.Data.ConnectionState.Open)
            {
                _connection.Open();
            }
        }
        internal List<Ugyfel> GetAllugyfel()
        {
            List<Ugyfel> ugyfelek = new List<Ugyfel>();
            _command.CommandText = "SELECT * FROM ugyfel GROUP BY ugyfel.nev ORDER BY ugyfel.azon ASC;";
            KapcsNyit();
            using (MySqlDataReader dr = _command.ExecuteReader())
            {
                while (dr.Read())
                {
                    Ugyfel ugyfelek1 = new Ugyfel(dr.GetInt32("azon"), dr.GetString("nev"), dr.GetDateTime("szuldatum"),dr.GetInt32("irszam"), dr.GetString("orsz"));
                    ugyfelek.Add(ugyfelek1);
                }
            }
            KapcsZar();
            return ugyfelek;
        }
        public void Create(int azon,int osszeg)
        {

            _command.CommandText = "INSERT INTO `befiz`(`azon`, `datum`, `osszeg`) VALUES (@azon,@datum,@osszeg)";
            try
            {
                _command.Parameters.Clear();
                _command.Parameters.AddWithValue("@azon", azon);
                _command.Parameters.AddWithValue("@datum", DateTime.Now);
                _command.Parameters.AddWithValue("@osszeg", osszeg);
            }
            catch (Exception)
            {

                throw;
            }
           
            KapcsNyit();
            _command.ExecuteNonQuery();
            MessageBox.Show("Sikeres rögzítés", "Rögzítve", MessageBoxButtons.OK, MessageBoxIcon.Information);
            KapcsZar();

        }

    }
}
