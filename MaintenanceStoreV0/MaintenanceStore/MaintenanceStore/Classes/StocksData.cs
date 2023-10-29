using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceStore.Classes
{
    //comproduct
    class StocksData
    {
      readonly DataAccessLayer.DAL dal = new DataAccessLayer.DAL();
        public DataTable Search(string cond_v)
        {
            MySqlParameter[] param = new MySqlParameter[1];
           

            param[0] = new MySqlParameter("cond_v", MySqlDbType.Text)
            {
                Value = cond_v
            };
           // _ = new DataTable();
            DataTable dt = dal.SelectData("Search_StocksData", param);
            dal.Close();
            return dt;
        }//Search_StocksData
        public string total()
        {
            DataTable dt = dal.SelectData("total_qty_store");
            dal.Close();
            DataRow row = dt.Rows[0];
            return row["count(id)"].ToString();
        }//total record


    }
}
