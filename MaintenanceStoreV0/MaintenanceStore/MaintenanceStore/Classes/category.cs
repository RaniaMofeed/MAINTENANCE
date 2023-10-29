using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace MaintenanceStore.Classes
{
    class category
    {
        readonly DataAccessLayer.DAL dal = new DataAccessLayer.DAL();


        public void Insert(string br_name_category, string descrption_d, string cat_groub)
        {
            MySqlParameter[] param = new MySqlParameter[3];

            param[0] = new MySqlParameter("CATEGORY_NAME", MySqlDbType.VarChar, 200)
            {
                Value = br_name_category
            };

            param[1] = new MySqlParameter("DESCRIPTION", MySqlDbType.VarChar,200)
            {
                Value = descrption_d
            };
            param[2] = new MySqlParameter("groub", MySqlDbType.VarChar,200)
            {
                Value = cat_groub
            };

            dal.Open();
            dal.ExecuteCommand("insert_category", param);
            dal.Close();
        }
        public void Update(string name_category, string descrption_u, string cat_groub, int CAT_ID)
        {
            MySqlParameter[] param = new MySqlParameter[4];

            param[0] = new MySqlParameter("CATEGORY_NAME", MySqlDbType.VarChar, 200)
            {
                Value = name_category
            };

            param[1] = new MySqlParameter("DESCRIPTION", MySqlDbType.VarChar,200)
            {
                Value = descrption_u
            };

            param[2] = new MySqlParameter("groub", MySqlDbType.VarChar,200)
            {
                Value = cat_groub
            };
             param[3] = new MySqlParameter("CATEGORY_ID", MySqlDbType.Int32)
            {
                Value = CAT_ID
            };


            dal.Open();
            dal.ExecuteCommand("update_category", param);
            dal.Close();
        }//update
        public DataTable Search()
        {
            // _ = select add datat in table category..!!
            DataTable dt = dal.SelectData("search_gategory");
            dal.Close();
            return dt;
        }
        public void Delete(int br_id_v)
        {
            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("CATEGORY_ID", MySqlDbType.Int32)
            {
                Value = br_id_v
            };
            dal.SelectData("delete_category", param);
            dal.Close();
        }
        

    }
}
