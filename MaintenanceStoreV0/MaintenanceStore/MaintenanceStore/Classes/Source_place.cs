using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace MaintenanceStore.Classes
{
    class Source_place
    {
        readonly DataAccessLayer.DAL dal = new DataAccessLayer.DAL();

        public void Insert(string name_source, string descrption_source)
        {
            MySqlParameter[] param = new MySqlParameter[2];

            param[0] = new MySqlParameter("source_name", MySqlDbType.VarChar, 200)
            {
                Value = name_source
            };

            param[1] = new MySqlParameter("Description", MySqlDbType.VarChar, 200)
            {
                Value = descrption_source
            };

            dal.Open();
            dal.ExecuteCommand("insert_source", param);
            dal.Close();
        }
        public void Update(string name_source, string descrption_source, int source_ID)
        {
            MySqlParameter[] param = new MySqlParameter[3];

            param[0] = new MySqlParameter("source_NAME", MySqlDbType.VarChar, 200)
            {
                Value = name_source
            };

            param[1] = new MySqlParameter("DESCRIPTION", MySqlDbType.VarChar, 200)
            {
                Value = descrption_source
            };

            param[2] = new MySqlParameter("source_ID", MySqlDbType.Int32)
            {
                Value = source_ID
            };


            dal.Open();
            dal.ExecuteCommand("update_source", param);
            dal.Close();
        }
        public DataTable Search()
        {
            // _ = select add datat in table category..!!
            DataTable dt = dal.SelectData("search_source");
            dal.Close();
            return dt;
        }
        public void Delete(int br_id_v)
        {
            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("SOURCE_ID", MySqlDbType.Int32)
            {
                Value = br_id_v
            };
            dal.SelectData("delete_source", param);
            dal.Close();
        }
       


    }
}
