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
    public partial class edit : Form
    {
        private Add add;
        private static readonly Classes.Store stock = new Classes.Store();
        readonly Classes.Store BR = stock;
        public edit()
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
                storename.Enabled = false;
                description.Enabled = false;
                adminstrator.Enabled = false;

            }
            else if (En == "enable")
            {
                storename.Enabled = true;
                description.Enabled = true;
                adminstrator.Enabled = true;

            }
            else
            {
                storename.Text = " ";
                adminstrator.Text = " ";
                description.Text = " ";

            }
        }  //ENABLE AND DISAPLE
        public void update(String name, String des, String adm, int id)
        {
            // Todo  query sequence
            BR.Update(name, des, adm, id);
            SearchGrid();
        }//Update_Fun
        public void Delete(int id)
        {
            // Todo  query sequence
            BR.Delete(id);
            SearchGrid();
        }//Delet_Fun       
        public void adddata(String name, String des, String adm)
        {
            // Todo  query sequence
            BR.Insert(name, des, adm);
            SearchGrid();
        }//Insert_Fun
        public void Fill_grid(DataTable dt)
        {
            dataGridView1.DataSource = dt;
            totalrecord.Text = dt.Rows.Count.ToString();
        }
        private void addstore_Load(object sender, EventArgs e)
        {

            totalrecord.Enabled = false;
            Enabletext("disenable");
            this.SearchGrid();
        }
        public edit(Add add2)
        {
            this.add = add2;
            InitializeComponent();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //exit form ;
            this.add.Show();
            this.Close();
        }//Exit
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            storename.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            description.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            adminstrator.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
          //  adminstrator.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }
        private void button11_Click(object sender, EventArgs e)
        {
            //update
            if (ID.Text == "")
            {
                MessageBox.Show("Please Select Row to Update");
            }
            else
            {
                update(storename.Text, description.Text, adminstrator.Text, int.Parse(ID.Text));
                Enabletext("clear");
                Enabletext("disenable");
                MessageBox.Show("Your data Updated");

            }

        } //Update
        private void addst_Click(object sender, EventArgs e)
        {
            //add
            if (storename.Text == "" & description.Text == "" & adminstrator.Text == "")
            {
                MessageBox.Show("Please Enter values");
            }
            else
            {
                adddata(storename.Text, description.Text, adminstrator.Text);
                MessageBox.Show("Add successfully");
                Enabletext("clear");
                Enabletext("disenable");
            }


        } //Insert
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
        }//Delete
        private void button1_Click(object sender, EventArgs e)
        {
            Enabletext("enable");
        }//Enable to Edit

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
    
    }
}

