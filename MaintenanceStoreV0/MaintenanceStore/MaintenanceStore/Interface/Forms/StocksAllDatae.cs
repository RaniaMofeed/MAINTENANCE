using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaintenanceStore.Classes;
using MaintenanceStore.Interface.Forms;
using MySql.Data.MySqlClient;

namespace MaintenanceStore
{
    public partial class Stock : Form

    {
        private Home home;
        private static readonly Classes.StocksData stor = new Classes.StocksData();
        readonly Classes.StocksData BR = stor;
        private static readonly Classes.category Cat = new Classes.category();
        readonly Classes.category category = Cat;
        private static readonly Classes.Product Prod = new Classes.Product();
        readonly Classes.Product product = Prod;
        private static readonly Classes.Store stock = new Classes.Store();
        readonly Classes.Store st = stock;


        void enabletext(bool option1, bool option2, bool option41, bool option42)
        {
            barcode.Enabled = option1;
            productlist.Enabled = option2;
            cmbCategoryName.Enabled = option41;
            cmbStoreList.Enabled = option42;

        }
        void Check()
        {
            if (option3.Checked)
            {
                if (categoryName.Checked == true && Storec.Checked == false)
                {
                    enabletext(false, false, true, false);
                }
                else if (categoryName.Checked == false && Storec.Checked == true)
                {
                    enabletext(false, false, false, true);
                }

                else if (categoryName.Checked == false && Storec.Checked == false)
                {
                    enabletext(false, false, false, false);

                }
                else
                {
                    enabletext(false, false, true, true);
                }

            }

           
        }//option3 check
       
        public Stock()
        {
            InitializeComponent();

        }
        private void loadCategoryList()
        {
            try
            {
                DataTable dt = category.Search();
                cmbCategoryName.DisplayMember = "Category_name";
                cmbCategoryName.ValueMember = "ID";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                cmbCategoryName.DataSource = ds.Tables[0];
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        } //loadCategoryList
        private void loadStockList()
        {
            try
            {
                DataTable dtStores = st.Search();
                cmbStoreList.DisplayMember = "Store_name";
                cmbStoreList.ValueMember = "ID";
                DataSet ds = new DataSet();
                ds.Tables.Add(dtStores);
                cmbStoreList.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//loadStockList
        public void loadproductlist()
        {
            try
            {
                DataTable dtproduct = Prod.Search("");
                productlist.DisplayMember = "product_name";
                productlist.ValueMember = "ID";
                DataSet ds = new DataSet();
                ds.Tables.Add(dtproduct);
                productlist.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//LoadproductData
        public void Delete(int id)
        {
            // Todo  query sequence
            product.Delete(id);
            SearchGrid();
        }//Delet_Fun
        public void SearchGrid()
        {
            string state = "";
            string condv = state;
            DataTable dt = BR.Search(condv);
            Fill_grid(dt);
        }//LoadData
        public void Fill_grid(DataTable dt)
        {
            dataGridView1.DataSource = dt;
            totalQty.Text = dt.Compute("Sum(QTY)", String.Empty).ToString();
            totalrecord.Text = dt.Rows.Count.ToString();
        }
        public Stock(Home home)
        {
            this.home = home;
            InitializeComponent();

        }
        private void Stock_Load(object sender, EventArgs e)
        {
            enabletext(false, false, false, false);
            totalQty.Enabled = false;
            totalTable.Enabled = false;
            totalrecord.Enabled = false;
            this.SearchGrid();
            this.loadCategoryList();
            this.loadStockList();
            this.loadproductlist();
            totalTable.Text = BR.total();
        }//STOCK LOAD DATA 
        private void cmbCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoryName.SelectedItem != null)
            {
                int categoryIDSelected = Convert.ToInt32(cmbCategoryName.SelectedValue);

                try
                {
                    //parameter search
                    DataTable dt = product.Search("And Category = " + categoryIDSelected);

                    DataSet ds = new DataSet();
                    ds.Tables.Add(dt);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }//option4
        private void button14_Click(object sender, EventArgs e)
        {
            DataTable dt;
            int categoryIDSelected = Convert.ToInt32(cmbCategoryName.SelectedValue);
            int storeIDSelected = Convert.ToInt32(cmbStoreList.SelectedValue);
            int productIDselected = Convert.ToInt32(productlist.SelectedValue);
            if (alldata.Checked)
            {
                dt = BR.Search(" ");
            }
            else if (option1.Checked)
            {
                if (barcode.Text == "")
                {
                    MessageBox.Show("Please Enter Value");
                    dt = BR.Search(" ");
                }
                else
                {

                    dt = BR.Search("And products.Code = '" + barcode.Text + "'");
                }

            }//barcode
            else if (option2.Checked)
            {
                dt = BR.Search("And products.ID = " + productIDselected);//table name
            }//product
            else
            {
                if (categoryName.Checked && Storec.Checked)
                {

                    dt = BR.Search("And category.ID = " + categoryIDSelected + " and store.ID = " + storeIDSelected);
                }
                else if (categoryName.Checked)
                {

                    dt = BR.Search("And category.ID = " + categoryIDSelected);
                }
                else if (Storec.Checked)
                {

                    dt = BR.Search("And Stock_id = " + storeIDSelected);
                }
                else
                {
                    MessageBox.Show("Please check Any option");
                    dt = BR.Search(" ");
                }

            }//
            this.Fill_grid(dt);
        }// DATA ReTRIVE
        private void clearcondition_Click(object sender, EventArgs e)
        {
            barcode.Text = "";
        }//clear condition
        //OPTIONS.......................................................
        private void alldata_MouseUp(object sender, MouseEventArgs e)
        {
            enabletext(false, false, false, false);
        }
        private void option1_MouseUp(object sender, MouseEventArgs e)
        {
            enabletext(true, false, false, false);
        }
        private void option2_MouseUp(object sender, MouseEventArgs e)
        {
            enabletext(false, true, false, false);
        }
        private void option3_MouseUp(object sender, MouseEventArgs e)
        {
            Check();

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show("product is Selected");
        }// TO VIEW PRODUCT
        private void AddSpearpart_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            addproduct addproduct = new addproduct(this, product);
            addproduct.Show();
            this.Hide();


        }//addproduct
        private void View_Click(object sender, EventArgs e)
        {

            Product product = new Product();
            int qty = 0;
            if (this.dataGridView1.SelectedRows[0].Cells[8].Value.ToString() != "")
            {
                qty = int.Parse(this.dataGridView1.SelectedRows[0].Cells[8].Value.ToString());
            }
         //  product.ID_product = int.Parse(this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            product.productname = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            product.code = this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            product.brand = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            product.category = this.dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            product.group = this.dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            product.store = this.dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            product.qty = qty;
            product.Description = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Productview viewpro = new Productview(product, this);
            viewpro.Show();
            this.Hide();
        }//View
        private void delete_Click(object sender, EventArgs e)
        {

            if (ID.Text == "")
            {
                MessageBox.Show("Please Select Row to Delete");
            }
            else
            {
                if (MessageBox.Show("Do you want to delete this record?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Delete(int.Parse(ID.Text));
                    MessageBox.Show("Delete Successfully");
                }
            }
            SearchGrid();
            loadproductlist();

        }//DELETE
        private void update_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ID_product = int.Parse(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            product.productname = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            product.code = this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            product.brand = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            product.category = this.dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            product.group = this.dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            product.Description = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            addproduct adpro = new addproduct(this,product);
            adpro.Show();
            this.Hide();
        }//update
        private void Print_Click(object sender, EventArgs e)
        {
           if(dataGridView1.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();

                xcelApp.Visible = true;
            }
        }//report
        private void exit_Click(object sender, EventArgs e)
        {
            this.home.Show();
            this.Close();
        }//exit form
        private void categoryName_CheckedChanged(object sender, EventArgs e)
        {
            Check();
        }
        private void Storec_CheckedChanged(object sender, EventArgs e)
        {
            Check();
        }

      
    }
}
