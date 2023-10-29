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
using MySql.Data.MySqlClient;

namespace MaintenanceStore.Interface.Forms
{
    public partial class addCategory : Form
    {
        private Add add;
        private static readonly Classes.category category = new Classes.category();
        readonly Classes.category BR = category;
        public addCategory()
        {
            InitializeComponent();
        }   
        public void SearchGrid()
        {
           
            DataTable dt = BR.Search();
            Fill_grid(dt);
        }
        void Enabletext(String En)
        {

            if (En == "disenable")
            {
                categoryname.Enabled = false;
                groub.Enabled = false;
                Description.Enabled = false;

            }
            else if (En == "enable")
            {
                categoryname.Enabled = true;
                groub.Enabled = true;
                Description.Enabled = true;

            }
            else
            {
                categoryname.Text = " ";
                groub.Text = " ";
                Description.Text = " ";

            }
        }  //ENABLE AND DISAPLE
        public void update(String name,String des, String groub, int id)
        {
            // Todo  query sequence
            BR.Update(name,des, groub, id);
            SearchGrid();
        }//Update_Fun
        public void Delete(int id)
        {
            // Todo  query sequence
            BR.Delete(id);
            SearchGrid();
        }//Delet_Fun       
        public void adddata(String name, String des, String groub)
        {
            // Todo  query sequence
            BR.Insert(name, des,groub);
            SearchGrid();
        }//Insert_Fun
        public void Fill_grid(DataTable dt)
        {
            dataGridView1.DataSource = dt;
           totalrecordcategory.Text = dt.Rows.Count.ToString();
        }//fillgride
        private void addCategory_Load(object sender, EventArgs e)
        {

            totalrecordcategory.Enabled = false;
            categoryname.Enabled = false;
            Enabletext("disenable");
            this.SearchGrid();
        }//load data
        public addCategory(Add add)
        {
            this.add = add;
            InitializeComponent();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.add.Show();
            this.Close();

        }//exit
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            categoryname.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Description.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            groub.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Enabletext("enable");
        }//edit
        private void button11_Click(object sender, EventArgs e)
        {
            //update
            if (ID.Text == "")
            {
                MessageBox.Show("Please Select Row to Update");
            }
            else
            {
                update(categoryname.Text, Description.Text, groub.Text, int.Parse(ID.Text));
                Enabletext("clear");
                Enabletext("disenable");
                MessageBox.Show("Your data Updated");

            }
        }//update
        private void button13_Click(object sender, EventArgs e)
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
                    Enabletext("clear");
                    Enabletext("disenable");
                }
            }
            SearchGrid();
        }//delete
        private void addcat_Click(object sender, EventArgs e)
        {
            //add
            if (categoryname.Text == "" & Description.Text == "" & groub.Text == "")
            {
                MessageBox.Show("Please Enter values");
            }
            else
            {
                adddata(categoryname.Text, Description.Text, groub.Text);
                MessageBox.Show("Add successfully");
                Enabletext("clear");
                Enabletext("disenable");
            }
        }//insrtcategory

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
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
    }//Report

        private void groub_KeyPress(object sender, KeyPressEventArgs e)
        {//  e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                string message = "Please Enter Only CHAR.";
                string title = "Error";
                MessageBox.Show(message, title);
            }
        }
    }
}
