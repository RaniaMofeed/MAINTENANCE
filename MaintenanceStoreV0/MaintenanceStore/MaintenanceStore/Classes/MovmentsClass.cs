using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace MaintenanceStore.Classes
{
    public class MovmentsClass
    {
       
        public int mov_id;
        public String code;
        public String productname;
        public String category;
        public String store;
        public String Description;
        public int qty_stock;
        public String in_out;
        public String Date;
        public String depart;
        public String source;
        public int qty_added;
        public String Notes;

        readonly DataAccessLayer.DAL dal = new DataAccessLayer.DAL();
        public void Insert(int stock_mov, int? sites_mov, int? source_mov, string In_OuT, int QTY_mov, DateTime date_mov,String Notes) 
        {
            MySqlParameter[] param = new MySqlParameter[7];

            param[0] = new MySqlParameter("comproduct_id", MySqlDbType.Int32)
            {
                Value = stock_mov
            };
             param[1] = new MySqlParameter("sites_id", MySqlDbType.Int32)
            {
                Value = sites_mov
             };
             param[2] = new MySqlParameter("source_id", MySqlDbType.Int32)
             {
                 Value = source_mov
             };
             param[3] = new MySqlParameter("In_OuT", MySqlDbType.Enum)
            {
                Value = In_OuT
             };
             param[4] = new MySqlParameter("QTY", MySqlDbType.Int32)
            {
                Value = QTY_mov
             };

             param[5] = new MySqlParameter("date_m", MySqlDbType.Date)
            {
                Value = date_mov.ToString("yyyy-MM-dd")
            };
             param[6] = new MySqlParameter("Notes", MySqlDbType.String)
            {
                Value = Notes
            };

            dal.Open();
            dal.ExecuteCommand("insert_movement", param);
            dal.Close();
        }//insert_movement
        public DataTable Search(string cond_v)
        {
            MySqlParameter[] param = new MySqlParameter[1];


            param[0] = new MySqlParameter("cond_v", MySqlDbType.Text)
            {
                Value = cond_v
            };
            // _ = new DataTable();
            DataTable dt = dal.SelectData("search_movement", param);
            dal.Close();
            return dt;
        }//search_movement
        public void Insertcom(int QTY_st, int Product_idst, int Stock_idst)
        {
            MySqlParameter[] param = new MySqlParameter[3];

            param[0] = new MySqlParameter("QTY", MySqlDbType.Int32)
            {
                Value = QTY_st
            };

            param[1] = new MySqlParameter("Product_id", MySqlDbType.Int32)
            {
                Value = Product_idst
            };
            param[2] = new MySqlParameter("Stock_id", MySqlDbType.Int32)
            {
                Value = Stock_idst
            };



            dal.Open();
            dal.ExecuteCommand("insert_comproduct", param);
            dal.Close();
        }//insertcomproduct
        public void Update(int QTY_st, int Product_idst, int Stock_idst, int br_id_vr)
        {
            MySqlParameter[] param = new MySqlParameter[4];

            param[0] = new MySqlParameter("QTY", MySqlDbType.Int32)
            {
                Value = QTY_st
            };

            param[1] = new MySqlParameter("Product_id", MySqlDbType.Int32)
            {
                Value = Product_idst
            };

            param[2] = new MySqlParameter("Stock_id", MySqlDbType.Int32)
            {
                Value = Stock_idst
            };
            param[3] = new MySqlParameter("com_proID", MySqlDbType.Int32)
            {
                Value = br_id_vr
            };


            dal.Open();
            dal.ExecuteCommand("update_comproduct", param);
            dal.Close();
        }//updateComproduct
        public string total()
        {
            DataTable dt = dal.SelectData("totalRec_movment");
            dal.Close();
            DataRow row = dt.Rows[0];
            return row["count(ID)"].ToString();
        }//total record 
        public int LASTID()
        {
            DataTable dt = dal.SelectData("lastID");
            dal.Close();
            DataRow row = dt.Rows[0];
            return (int)row["id"];
        }
    }
}
