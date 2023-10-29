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
    public partial class Productview : Form
    {

         private Product product;
         private MaintenanceStore.Stock stock ;
        
        public Productview(Product product,MaintenanceStore.Stock stock)
        {
            this.product = product;
            this.stock = stock;
            InitializeComponent();
        }


        private void exit_Click(object sender, EventArgs e)
        { 
            this.stock.Show();
            this.stock.SearchGrid();
            this.Close();
        }

        private void Productview_Load(object sender, EventArgs e)
        {
            nameSpare.Text = product.productname;
            Code.Text = product.code;
            brand.Text = product.brand;
            category.Text = product.category;
            group.Text = product.group;
            description.Text = product.Description;
            store.Text = product.store;
            qty.Text =  product.qty.ToString();
        }
    }
}
