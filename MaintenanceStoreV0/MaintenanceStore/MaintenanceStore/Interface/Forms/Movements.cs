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
using MaintenanceStore.Classes;
using MySql.Data.MySqlClient;

namespace MaintenanceStore.Interface.Forms
{
    public partial class Movements : Form
    {
        private Home home;

        private static readonly Classes.MovmentsClass movments = new Classes.MovmentsClass();
        readonly Classes.MovmentsClass BR = movments;

        private static readonly Classes.Source_place source = new Classes.Source_place();
        readonly Classes.Source_place sourc = source;

        private static readonly Classes.StocksData stor = new Classes.StocksData();
        readonly Classes.StocksData BR2 = stor;
        private static readonly Classes.category Cat = new Classes.category();
        readonly Classes.category category = Cat;
        private static readonly Classes.Product Prod = new Classes.Product();
        readonly Classes.Product product = Prod;
        private static readonly Classes.Store stock = new Classes.Store();
        readonly Classes.Store st = stock;
        private static readonly Classes.Dep dep = new Classes.Dep();
        readonly Classes.Dep de = dep;

        public Movements()
        {
            InitializeComponent();
        }
        private void loadStoreList()
        {
            try
            {
                DataTable dtStores = st.Search();
                cmbstorelist.DisplayMember = "Store_name";
                cmbstorelist.ValueMember = "ID";
                DataSet ds = new DataSet();
                ds.Tables.Add(dtStores);
                cmbstorelist.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        } //loadStoreList
        private void loaddepList()
        {
            try
            {
                DataTable dtStores = de.Search();
                cmbdepartlist.DisplayMember = "Dep_name";
                cmbdepartlist.ValueMember = "ID";
                DataSet ds = new DataSet();
                ds.Tables.Add(dtStores);
                cmbdepartlist.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        } //loaddepList
        private void loadproductList()
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

        } //loadproductList
        private void loadsourceList()
        {
            try
            {
                DataTable dtsource = source.Search();
                cmbsourcelist.DisplayMember = "source_place";
                cmbsourcelist.ValueMember = "ID";
                DataSet ds = new DataSet();
                ds.Tables.Add(dtsource);
                cmbsourcelist.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        } //loadSOURCELIST
        private void disun(bool option2,bool option3, bool option4, bool option5,bool option6,bool optopn7)
        {
            barcode.Enabled = option2;
            productlist.Enabled = option3;
            cmbstorelist.Enabled = option4;
            cmbdepartlist.Enabled = option5;
            cmbsourcelist.Enabled = option6;
            cmbInOut.Enabled = optopn7;

        }
        public void SearchGrid()
        {
            string state = "";
            string condv = state;
            DataTable dt = BR.Search(condv);
            Fill_grid(dt);
        }
        public void Fill_grid(DataTable dt)
        {
            dataGridView1.DataSource = dt;
            totalrecord.Text = dt.Rows.Count.ToString();
            totalQty.Text = dt.Compute("Sum(QtyInStore)", String.Empty).ToString();
            qtyadded.Text = dt.Compute("Sum(QtyAdded)", String.Empty).ToString();
        }
        public void LoadData()
        {
            SearchGrid();
            loadStoreList();
            loaddepList();
            loadproductList();
            loadsourceList();
            disun(false, false, false, false,false,false);
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;



        }
        public Movements(Home home )
        {
            this.home = home;
            InitializeComponent();
        }
        private void Movements_Load(object sender, EventArgs e)
        {
           totalrecord.Enabled = false;
            totalTable.Enabled = false;
            totalQty.Enabled = false;
            qtyadded.Enabled = false;
            this.LoadData();
           totalTable.Text = BR.total();
        }
        private void close(object sender, EventArgs e)
        {
            this.home.Show();
            this.Close();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            movements_prod movements_Prod = new movements_prod(this);
            movements_Prod.Show();
            this.Hide();

        }//add new movment
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
        }//Report
        private void button8_Click(object sender, EventArgs e)
        {
            barcode.Text = " ";
        }//Clear condition 
        private void option1_MouseUp(object sender, MouseEventArgs e)
        {
            disun(false, false, false, false, false,false);
        }
        private void option2_MouseUp(object sender, MouseEventArgs e)
        {
            disun(true, false, false, false, false,false);
        }
        private void option3_MouseUp(object sender, MouseEventArgs e)
        {
            disun(false, true, false, false, false,false);
        }
        private void option4_MouseUp(object sender, MouseEventArgs e)
        {
            disun(false, false, true, false, false,false);
        }
        private void option5_MouseUp(object sender, MouseEventArgs e)
        {
            disun(false, false, false, true, false,false);
        }
        private void option6_MouseUp(object sender, MouseEventArgs e)
        {
            disun(false, false, false, false, true, false);
        }
        private void option7_MouseUp(object sender, MouseEventArgs e)
        {
            disun(false, false, false, false, false, true);
        }
        private void View_Click(object sender, EventArgs e)
        {
            MovmentsClass movement = new MovmentsClass();
            movement.code = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            movement.productname = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            movement.category = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            movement.store = this.dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            movement.Description = this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            movement.qty_stock =int.Parse( this.dataGridView1.SelectedRows[0].Cells[12].Value.ToString());
            movement.in_out = this.dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            movement.Date = this.dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            movement.qty_added = int.Parse(this.dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
            movement.Notes = this.dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            movement.depart = this.dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            movement.source = this.dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            MovementView movementView = new MovementView(movement, this);
            movementView.Show();
            this.Hide();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            DataTable dt;      
            int productIDselected = Convert.ToInt32(productlist.SelectedValue);
            int StoreIDselected = Convert.ToInt32(cmbstorelist.SelectedValue);
            int DepIDselected = Convert.ToInt32(cmbdepartlist.SelectedValue);
            int SourceIDselected = Convert.ToInt32(cmbsourcelist.SelectedValue);
            if (option1.Checked)
            {
                if(datebetween.Checked==false)
                {
                    dt = BR.Search(" ");
                }
                else
                {
                    dt = BR.Search("And DATE BETWEEN '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "'");
                }

            }//alldata
            else if (option2.Checked)
            {
                if (barcode.Text == "")
                {
                    MessageBox.Show("Please Enter Value");
                    dt = BR.Search(" ");
                }
                else if (datebetween.Checked==true)
                {

                    dt = BR.Search("And products.Code = '" + barcode.Text + "'"+ "And DATE BETWEEN '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "'");
                    
                }
                else
                {
                    dt = BR.Search("And products.Code = '" + barcode.Text + "'");
                }
            }//barcode
            else if (option3.Checked)
            {
                if (datebetween.Checked==false)
                {
                    dt = BR.Search("And products.ID = " + productIDselected);//table name

                }
                else
                {
                        dt = BR.Search("And products.ID = '" + productIDselected + "'" + "And DATE BETWEEN '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "'");//table name
                    
                }

            }//product
            else if (option4.Checked)
            {
                if(datebetween.Checked==false)
                {
                    dt = BR.Search("And store.ID = " + StoreIDselected);//table name
                }
               else
                {
                    dt = BR.Search("And store.ID = '" + StoreIDselected + "'" + "And DATE BETWEEN '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "'");//table name
                }
            }//STORE
            else if (option5.Checked)
            {
                if (datebetween.Checked==false)
                {
                    dt = BR.Search("And department.ID = " + DepIDselected);//table name
                }
                else
                {
                    dt = BR.Search("And department.ID = '" + DepIDselected + "'" + "And DATE BETWEEN '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "'");//table name
                }
              

            }//department
            else if (option6.Checked)
            {
                if(datebetween.Checked==false)
                {
                    dt = BR.Search("And source.ID = " + SourceIDselected);//table name
                }
                else
                {
                    dt = BR.Search("And source.ID = '" + SourceIDselected + "'" + "And DATE BETWEEN '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "'");//table name
                }
               

            }//source
            else
            {
                if(datebetween.Checked==false)
                {
                    dt = BR.Search("And movements.ImpExp = '" + cmbInOut.Text + "'");
                }
                else
                {
                    dt = BR.Search("And movements.ImpExp = '" + cmbInOut.Text + "'"+ "And DATE BETWEEN '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "'");
                }
             
            }
            this.Fill_grid(dt);
        }//Data_Retrive
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show("product is Selected");
        }
        private void datebetween_CheckedChanged(object sender, EventArgs e)
        {
            if(datebetween.Checked==true)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }else
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }
    }
}
