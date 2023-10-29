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
    public partial class add_product : Form
    {
        private Add add;
        public add_product()
        {
            InitializeComponent();
        }
        public add_product(Add add)
        {
            this.add = add;
            InitializeComponent();
        }

      
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
