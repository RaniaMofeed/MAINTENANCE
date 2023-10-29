using MaintenanceStore.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaintenanceStore.Interface.Forms
{

    public partial class addproduct : Form
    {
        private static readonly Classes.category Cat = new Classes.category();
        readonly Classes.category ca = Cat;
        private static readonly Classes.Product Prod = new Classes.Product();
        readonly Classes.Product product = Prod;
        private MaintenanceStore.Stock stock;
        private Product product2;
        public addproduct(MaintenanceStore.Stock stock, Product product)
        {
            this.product2 = product;
            this.stock = stock;
            InitializeComponent();
        }
        private void loadCategoryList()
        {
            try
            {
                DataTable dt = ca.Search();
                Cmbcategorylist.DisplayMember = "Category_name";
                Cmbcategorylist.ValueMember = "ID";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                Cmbcategorylist.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void insertdata()
        {

            product.Insert(nameSpare.Text, brand.Text, description.Text, Code.Text, Convert.ToInt32(Cmbcategorylist.SelectedValue));
        }// insert data
        private void UpdateData(string name, string brand, string des, string code, int category, int id_vr)
        {
            product.Update(name, brand, des, code, category, id_vr);
        }// update data
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                string message = "Please Enter Only Gigital Number";
                string title = "Error";
                MessageBox.Show(message, title);
            }
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.stock.Show();
            this.stock.SearchGrid();
            this.Close();
        }
        private void addproduct_Load(object sender, EventArgs e)
        {
            loadCategoryList();
            ID.Text = product2.ID_product.ToString();
            nameSpare.Text = product2.productname;
            Code.Text = product2.code;
            brand.Text = product2.brand;
            Cmbcategorylist.Text = product2.category;
            description.Text = product2.Description;
        }//LOOOOOOOOOOOAD
        private void Supmit_Click(object sender, EventArgs e)
        {
            int categoryIDSelected = Convert.ToInt32(Cmbcategorylist.SelectedValue);

            if (nameSpare.Text == "")
            {
                MessageBox.Show("Please Enter Values in Name Product");
            }
            else if (Code.Text == "")
            {
                MessageBox.Show("Please Enter Values in Code Product");
            }
            else if (categoryIDSelected == 0)
            {
                MessageBox.Show("Please Select Category");
            }

             else if (ID.Text == "0")
             {
                 insertdata();
                 MessageBox.Show("your data  is added");////
                 this.stock.Show();
                 this.stock.SearchGrid();
                 this.stock.loadproductlist();
                 this.Close();
             }
             else
             {
                 UpdateData(nameSpare.Text, brand.Text, description.Text, Code.Text, categoryIDSelected, int.Parse(ID.Text));
                 MessageBox.Show("your data  is Updated");////
                 this.stock.Show();
                 this.stock.SearchGrid();
                 this.stock.loadproductlist();
                 this.Close();
             }
        }

    }

}

