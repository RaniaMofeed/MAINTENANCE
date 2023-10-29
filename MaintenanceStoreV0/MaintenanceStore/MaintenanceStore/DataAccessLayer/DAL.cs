using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MaintenanceStore.DataAccessLayer
{
    class DAL
    {
        public static MySqlConnection con;
        //string strPath = ".Default\\Software\\PetraSoft\\Employees\\CurrentVersion\\MySQL\\DBServer\\Settings\\Employees";


        //  Constructor
        public DAL()
        {
            con = new MySqlConnection("Server=localhost;Database=mainteancestor;uid=root;pwd=;convert zero datetime=True");
        }
        public void Open()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        // method to close connection
        public void Close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        // Method to read data from database 
        public DataTable SelectData(string stored_procedure, MySqlParameter[] param = null)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_procedure;
            cmd.Connection = con;
            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);

            }
            catch (MySqlException ex)
            {
                if (ex.ToString().Contains("Unable to connect to any of the specified MySQL hosts"))
                {
                    MessageBox.Show("Unable to connect Please turn On Xampp");
                }
            }
            return dt;
        }

        // Method to Insert , update , delete to database 

        public void ExecuteCommand(string stored_procedure, MySqlParameter[] param)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_procedure;
            cmd.Connection = con;
            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }
            cmd.ExecuteNonQuery();
        }
    }

}
