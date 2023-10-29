using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace MaintenanceStore.Interface.Forms
{
    public partial class Add : Form
    {
        private Home home;
        public Add()
        {
            InitializeComponent();
        }
        public Add(Home home)
        {
            this.home = home;
            InitializeComponent();
        }

        private void Add_Store_Click(object sender, EventArgs e)
        {
               edit addstore = new edit(this);
                addstore.Show();
                this.Hide();


        }

        private void Add_Category_Click(object sender, EventArgs e)
        {
            addCategory addCategory = new addCategory(this);
            addCategory.Show();
            this.Hide();

        }

        private void Add_Source_Click(object sender, EventArgs e)
        {
            adddSourceplace adddSourceplace = new adddSourceplace(this);
            adddSourceplace.Show();
            this.Hide();
        }

        private void Add_Department_Click(object sender, EventArgs e)
        {
            addsites add_Department = new addsites(this);
            add_Department.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.home.Show();
            this.Close();
        }
    }
}
//MySql.Data.MySqlClient.MySqlException: 'Unable to connect to any of the specified MySQL hosts.'
//MySql.Data.MySqlClient.MySqlException: 'Duplicate entry '5-4' for key 'Duplicate''

