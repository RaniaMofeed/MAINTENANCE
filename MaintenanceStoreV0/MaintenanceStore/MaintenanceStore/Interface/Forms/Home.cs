using MaintenanceStore.Interface.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaintenanceStore
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void Barcode_button(object sender, EventArgs e)
        {
            Barcode barcode = new Barcode(this);
            barcode.Show();
            this.Hide();

        }

       
        private void Store_button(object sender, EventArgs e)
        {
            Stock stock = new Stock(this);
            stock.Show();
            this.Hide();

        }

        private void aboutapp_button(object sender, EventArgs e)
        {
            Info info = new Info (this);
            info.Show();
            this.Hide();

        }

        private void movement_button(object sender, EventArgs e)
        {
            Movements movements = new Movements(this);
            movements.Show();
            this.Hide();
        }

        private void Adds_button(object sender, EventArgs e)
        {
            Add add = new Add(this);
            add.Show();
            this.Hide();
        }

        private void App_exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pic1_Click(object sender, EventArgs e)
        {

        }
        //private void timer1_Tick(object sender, EventArgs e)
        //{

        //    PictureBox[] Pics = { Pic1, Pic2, Pic3, Pic4, Pic5, Pic6 };

        //    bunifuTransition3.HideSync(Pics[i]);
        //    if (i > 3)
        //    {
        //        i = 0;
        //        bunifuTransition4.ShowSync(Pics[i]);
        //        return;
        //    }
        //    bunifuTransition3.ShowSync(Pics[i + 1]);
        //    i++;



        //    UserControl[] users = {  userControl21, userControl41, userControl11,info1 ,userControl31};
        //    bunifuTransition3.HideSync(users[i]);
        //    if (i > 3)
        //    {
        //        i = 0;
        //        bunifuTransition4.ShowSync(users[i]);
        //        return;
        //    }
        //    bunifuTransition3.ShowSync(users[i + 1]);
        //    i++;
    }     
}
