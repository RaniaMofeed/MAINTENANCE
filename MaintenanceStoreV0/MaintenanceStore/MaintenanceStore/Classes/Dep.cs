using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace MaintenanceStore.Classes
{
    class Dep
    {
        readonly DataAccessLayer.DAL dal = new DataAccessLayer.DAL();

        public void Insert(string name_Dep, string descrption_dep)
        {
            MySqlParameter[] param = new MySqlParameter[2];

            param[0] = new MySqlParameter("Dep_name", MySqlDbType.VarChar, 200)
            {
                Value = name_Dep
            };

            param[1] = new MySqlParameter("DESCRIPTION", MySqlDbType.VarChar, 200)
            {
                Value = descrption_dep
            };

            dal.Open();
            dal.ExecuteCommand("insert_dep", param);
            dal.Close();
        }
        public void Update(string name_dep, string descrption_dep, int dep_ID)
        {
            MySqlParameter[] param = new MySqlParameter[3];

            param[0] = new MySqlParameter("Dep_name", MySqlDbType.VarChar, 200)
            {
                Value = name_dep
            };

            param[1] = new MySqlParameter("Description", MySqlDbType.VarChar, 200)
            {
                Value = descrption_dep
            };

            param[2] = new MySqlParameter("Dep_ID", MySqlDbType.Int32)
            {
                Value = dep_ID
            };


            dal.Open();
            dal.ExecuteCommand("update_dep", param);
            dal.Close();
        }
        public DataTable Search()
        {
            // _ = select add datat in table category..!!
            DataTable dt = dal.SelectData("search_dep");
            dal.Close();
            return dt;
        }
        public void Delete(int br_id_v)
        {
            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("Dep_ID", MySqlDbType.Int32)
            {
                Value = br_id_v
            };
            dal.SelectData("delete_dep", param);
            dal.Close();
        }
      

    }
}
