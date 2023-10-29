using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace MaintenanceStore.Classes
{
    class Store
    {
        readonly DataAccessLayer.DAL dal = new DataAccessLayer.DAL();

        public void Insert(string br_name_store, string descrption_store, string adminstrator)
        {
            MySqlParameter[] param = new MySqlParameter[3];

            param[0] = new MySqlParameter("Store_name", MySqlDbType.VarChar, 200)
            {
                Value = br_name_store
            };

            param[1] = new MySqlParameter("DESCRIPTION", MySqlDbType.VarChar, 200)
            {
                Value = descrption_store
            };
            param[2] = new MySqlParameter("adminstrator", MySqlDbType.VarChar, 200)
            {
                Value = adminstrator
            };

            dal.Open();
            dal.ExecuteCommand("insert_Store", param);
            dal.Close();
        }
        public void Update(string name_store, string descrption_store, string admistrator, int store_ID)
        {
            MySqlParameter[] param = new MySqlParameter[4];

            param[0] = new MySqlParameter("Store_name", MySqlDbType.VarChar, 200)
            {
                Value = name_store
            };

            param[1] = new MySqlParameter("DESCRIPTION", MySqlDbType.VarChar, 200)
            {
                Value = descrption_store
            };

            param[2] = new MySqlParameter("Adminstrator", MySqlDbType.VarChar,200)
            {
                Value = admistrator
            };
            param[3] = new MySqlParameter("Store_ID", MySqlDbType.Int32)
            {
                Value = store_ID
            };


            dal.Open();
            dal.ExecuteCommand("update_store", param);
            dal.Close();
        }
        public DataTable Search()
        {
            // _ = select add datat in table category..!!
            DataTable dt = dal.SelectData("search_store");
            dal.Close();
            return dt;
        }
   
        public void Delete(int br_id_v)
        {
            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("Store_ID", MySqlDbType.Int32)
            {
                Value = br_id_v
            };
            dal.SelectData("delete_store", param);
            dal.Close();
        }
        public DataTable SearchstoreData(string cond_v)
        {
            MySqlParameter[] param = new MySqlParameter[1];


            param[0] = new MySqlParameter("cond_v", MySqlDbType.Text)
            {
                Value = cond_v
            };
            // _ = new DataTable();
            DataTable dt = dal.SelectData("Search_StoreData", param);
            dal.Close();
            return dt;
        }//SearchStore data



    }
}
