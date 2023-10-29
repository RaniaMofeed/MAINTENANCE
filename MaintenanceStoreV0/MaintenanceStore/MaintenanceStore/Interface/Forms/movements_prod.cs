using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class movements_prod : Form
    {
        private static readonly Classes.Product Prod = new Classes.Product();
        readonly Classes.Product product = Prod;
        private static readonly Classes.StocksData stor = new Classes.StocksData();
        readonly Classes.StocksData BR = stor;
        private static readonly Classes.Store stock = new Classes.Store();
        readonly Classes.Store st = stock;
        private static readonly Classes.Dep dep = new Classes.Dep();
        readonly Classes.Dep de = dep;
        private static readonly Classes.Source_place source = new Classes.Source_place();
        readonly Classes.Source_place so = source;
        private static readonly Classes.MovmentsClass movments = new Classes.MovmentsClass();
        readonly Classes.MovmentsClass mov = movments;
        private Movements movements;
        private DataRow returnedProduct;
        private DataRow returnedStore;


        public movements_prod()
        {
            InitializeComponent();
        }//CONSTRACTOR 
        public movements_prod(Movements movements)
        {
            this.movements = movements;
            InitializeComponent();
        }//CONSTRACTOR WITH DATA 
        //load all listes
        void Loadreturnedid()
        {
            DataTable dt;
            dt = stor.Search("And Stock_id = '" + Cmbstorelist.SelectedValue + "' And Product_id='" + returnedProduct["ID"] + "'");
            if (dt.Rows.Count > 0)
            {
                returnedStore = dt.Rows[0];
                qtyav.Text = returnedStore["QTY"].ToString();
            }
            else
            {
                qtyav.Text = "0";
            }
        }//Loadreturnedid
        private void loadproductlist()
        {
            try
            {
                DataTable dtproduct = Prod.Search("");
                cmdproductname.DisplayMember = "product_name";
                cmdproductname.ValueMember = "ID";
                returnedProduct = dtproduct.Rows[0];
                DataSet ds = new DataSet();
                ds.Tables.Add(dtproduct);
                cmdproductname.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//loadproduct
        private void loadStockList()
        {
            try
            {
                returnedStore = null;
                DataTable dtStores = st.Search();
                Cmbstorelist.DisplayMember = "Store_name";
                Cmbstorelist.ValueMember = "ID";
                DataSet ds = new DataSet();
                ds.Tables.Add(dtStores);
                Cmbstorelist.DataSource = ds.Tables[0];
                Cmbstorelist.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//loadStockList
        private void loadDepList()
        {
            try
            {
                DataTable dtStores = de.Search();
                cmdtofrom.DisplayMember = "Dep_name";
                cmdtofrom.ValueMember = "ID";
                DataSet ds = new DataSet();
                ds.Tables.Add(dtStores);
                cmdtofrom.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//load department
        private void loadSourceList()
        {
            try
            {
                DataTable dtStores = so.Search();
                SourcePlace.DisplayMember = "source_place";
                SourcePlace.ValueMember = "ID";
                DataSet ds = new DataSet();
                ds.Tables.Add(dtStores);
                SourcePlace.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//load sourceplace
        void updatecom(int QTYcomt, int Product_id, int Stock_id, int br_id) => mov.Update(QTYcomt, Product_id, Stock_id, br_id);//updatecomproduct
        void insrtcom(int QTY, int Product_id, int Stock_id) => mov.Insertcom(QTY, Product_id, Stock_id);//insertcomproduct
        void insertmov(int stock_mov, int? Dep_mov, int? source_mov, string In_OuT, int QTY_mov, DateTime date_mov, string notes) => mov.Insert(stock_mov, Dep_mov, source_mov, In_OuT, QTY_mov, date_mov, notes);//insertmovments
        //__________________________________________________________
        private void movements_prod_Load(object sender, EventArgs e)
        {
            loadproductlist();
            loadStockList();
            loadDepList();
            loadSourceList();
            //   Loadreturnedid();
            SourcePlace.Enabled = false;
        }//load
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                string message = "Please Enter Only Digital Number";
                string title = "Error";
                MessageBox.Show(message, title);
            }
        }//ONLY QTY BE DIGITAL
         //_____________________________________________________________________________________________
         //Actions
        private void Import_CheckedChanged(object sender, EventArgs e)
        {
            if (Import.Checked == true)
            {
                cmdproductname.SelectedIndex = 0;
                //loadStockList();
                Cmbstorelist.SelectedIndex = 0;
            }
            else
            {
                cmdproductname.SelectedIndex = 1;
            }

        }//change
        private void code_KeyDown(object sender, KeyEventArgs e)
        { //13 its mean must make Enter
            if (e.KeyValue == 13)
            {
                DataTable dt;
                dt = Prod.Search("And products.Code = '" + code.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    returnedProduct = dt.Rows[0];
                    cmdproductname.SelectedValue = Convert.ToInt32(returnedProduct["ID"]);

                }
                else
                {
                    MessageBox.Show("This product doesn't exist");
                    code.Text = "";

                }
                description.Text = returnedProduct["Description"].ToString();

            }//CODE_IMPORT   
            ///_________________________________________________________________________
        }//code Enter
        private void cmdproductname_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList stockIDs = new ArrayList();
            DataTable dt = Prod.Search("And products.ID = '" + cmdproductname.SelectedValue + "'");
            if (dt.Rows.Count > 0)
            {
                returnedProduct = dt.Rows[0];
                cmdproductname.SelectedValue = Convert.ToInt32(returnedProduct["ID"]);

            }
            category.Text = returnedProduct["Category_name"].ToString();
            code.Text = returnedProduct["Code"].ToString();
            description.Text = returnedProduct["Description"].ToString();
            //________________________________________________________________________________
            if (Export.Checked)
            {
                DataTable dtStore = stor.Search("and Product_id = " + cmdproductname.SelectedValue);
                if (dtStore.Rows.Count > 0)
                {
                    foreach (DataRow row in dtStore.Rows)
                    {
                        stockIDs.Add(row["Stock_id"].ToString());
                    }

                    string stockIDsString = string.Join(",", (string[])stockIDs.ToArray(Type.GetType("System.String")));
                    DataTable dtStock = st.SearchstoreData("and id in (" + stockIDsString + ")");
                    Cmbstorelist.DisplayMember = "Store_name";
                    Cmbstorelist.ValueMember = "ID";
                    DataSet ds = new DataSet();
                    ds.Tables.Add(dtStock);
                    Cmbstorelist.DataSource = ds.Tables[0];
                }
                else
                {
                    Cmbstorelist.DisplayMember = "";
                    Cmbstorelist.ValueMember = "";
                    Cmbstorelist.DataSource = null;
                }
            }//export
            else
            {
                loadStockList();
            }

        }//productload 
        private void Cmbstorelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loadreturnedid();
        }//Cmbstorelist_SelectedIndexChanged
        //__________________________________________________________________________________________________
        private void department_MouseUp(object sender, MouseEventArgs e)
        {
            loadDepList();
            SourcePlace.Enabled = false;
            cmdtofrom.Enabled = true;
        }//WHEN CHECK DEPARTMENT;
        private void source_place_MouseUp(object sender, MouseEventArgs e)
        {
            loadSourceList();
            cmdtofrom.Enabled = false;
            SourcePlace.Enabled = true;
        }//WHEN CHECK SOURCEPLACE;
        private void Supmit2_Click(object sender, EventArgs e)
        {

            int? deprtID = null;
            int? sourceID = null;
            if (department.Checked)
            {
                deprtID = Convert.ToInt32(cmdtofrom.SelectedValue);

            }
            else
            {
                sourceID = Convert.ToInt32(SourcePlace.SelectedValue);
            }

            if (qty.Text == "")
            {
                MessageBox.Show("Please Enter QTY.");

            }
            else if (returnedStore == null)
            {
                try
                {
                    insrtcom(int.Parse(qty.Text), Convert.ToInt32(cmdproductname.SelectedValue), Convert.ToInt32(Cmbstorelist.SelectedValue));
                    insertmov(mov.LASTID(), deprtID, sourceID,
                        "IN", Convert.ToInt32(qty.Text), DateTime.Parse(dateTimePicker1.Text), notes.Text);
                    MessageBox.Show("Successfuly Movement");
                    movements.Show();
                    movements.SearchGrid();
                    this.Close();
                }
                catch (MySqlException ex)
                {
                    if (ex.ToString().Contains("Duplicate"))
                    {
                        MessageBox.Show("Duplicate entry");
                    }
                }
            }
            else if (Import.Checked)
            {

                updatecom(int.Parse(qty.Text) + Convert.ToInt32(returnedStore["QTY"]), Convert.ToInt32(cmdproductname.SelectedValue),
                Convert.ToInt32(Cmbstorelist.SelectedValue), Convert.ToInt32(returnedStore["comproductID"]));
                insertmov(Convert.ToInt32(returnedStore["comproductID"]), deprtID, sourceID,
                "IN", Convert.ToInt32(qty.Text), DateTime.Parse(dateTimePicker1.Text), notes.Text);
                MessageBox.Show("Successfuly Movement");
                movements.Show();
                movements.SearchGrid();
                this.Close();
            }
            else if (Export.Checked)
            {
                int between = Convert.ToInt32(returnedStore["QTY"]) - int.Parse(qty.Text);
                if(between<0)
                {
                    MessageBox.Show("NOT enoUgh QTY.");
                }
                else
                {
                    updatecom(between, Convert.ToInt32(cmdproductname.SelectedValue),
                    Convert.ToInt32(Cmbstorelist.SelectedValue), Convert.ToInt32(returnedStore["comproductID"]));
                    insertmov(Convert.ToInt32(returnedStore["comproductID"]), deprtID,
                    sourceID, "OUT", Convert.ToInt32(qty.Text), DateTime.Parse(dateTimePicker1.Text), notes.Text);
                    MessageBox.Show("Successfuly Movement");
                    movements.Show();
                    movements.SearchGrid();
                    this.Close();
                }
               
            }
            // MessageBox.Show(returnedStore["comproductID"].ToString());
         
        }//Supmit
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            movements.Show();
            movements.SearchGrid();
            this.Close();
        }//exit
    }
}



