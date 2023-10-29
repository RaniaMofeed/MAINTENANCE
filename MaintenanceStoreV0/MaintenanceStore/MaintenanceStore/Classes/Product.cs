using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace MaintenanceStore.Classes
{
  public  class Product

    {
        //todo  parameter
        public int ID_product;
        public String productname;
        public String code;
        public String brand;
        public String category;
        public String group;
        public String store;
        public int qty;
        public String Description;

        readonly DataAccessLayer.DAL dal = new DataAccessLayer.DAL();
        public void Insert(string pro_name, string pro_brand, string pro_des, string pro_code, int pro_category)
        {
            MySqlParameter[] param = new MySqlParameter[5];

            param[0] = new MySqlParameter("product_name", MySqlDbType.VarChar, 200)
            {
                Value = pro_name
            };
            param[1] = new MySqlParameter("Brand", MySqlDbType.VarChar, 200)
            {
                Value = pro_brand
            };
            param[2] = new MySqlParameter("Description", MySqlDbType.VarChar, 200)
            {
                Value = pro_des
            };
            param[3] = new MySqlParameter("Code", MySqlDbType.VarChar, 200)
            {
                Value = pro_code
            };

            param[4] = new MySqlParameter("Category", MySqlDbType.Int32)
            {
                Value = pro_category
            };



            dal.Open();
            dal.ExecuteCommand("insert_product", param);
            dal.Close();
        }
        public void Update(string pro_name, string pro_brand, string pro_des, string pro_code, int pro_category, int br_id_vr)
        {
            MySqlParameter[] param = new MySqlParameter[6];

            param[0] = new MySqlParameter("product_name", MySqlDbType.VarChar, 200)
            {
                Value = pro_name
            };
            param[1] = new MySqlParameter("brand", MySqlDbType.VarChar, 200)
            {
                Value = pro_brand
            };
            param[2] = new MySqlParameter("Description", MySqlDbType.VarChar, 200)
            {
                Value = pro_des
            };
            param[3] = new MySqlParameter("code", MySqlDbType.VarChar, 200)
            {
                Value = pro_code
            };

            param[4] = new MySqlParameter("category", MySqlDbType.Int32)
            {
                Value = pro_category
            };

            param[5] = new MySqlParameter("product_ID", MySqlDbType.Int32)
            {
                Value = br_id_vr
            };


            dal.Open();
            dal.ExecuteCommand("update_product", param);
            dal.Close();
        }
        public DataTable Search(string cond_v)
        {
            MySqlParameter[] param = new MySqlParameter[1];


            param[0] = new MySqlParameter("cond_v", MySqlDbType.Text)
            {
                Value = cond_v
            };
            // _ = new DataTable();
            DataTable dt = dal.SelectData("search_product", param);
            dal.Close();
            return dt;
        }
        public void Delete(int br_id_v)
        {
            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("product_ID", MySqlDbType.Int32)
            {
                Value = br_id_v
            };
            dal.SelectData("delete_product", param);
            dal.Close();
        }

    }
}
