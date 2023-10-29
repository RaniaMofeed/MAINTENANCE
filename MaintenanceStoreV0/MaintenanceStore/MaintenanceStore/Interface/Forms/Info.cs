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
    public partial class Info : Form
    {
        private Home home;
        public Info()
        {
            InitializeComponent();
        }
        public Info(Home home)
        {
            this.home = home;
            InitializeComponent();
        }
        private void close(object sender, EventArgs e)
        {
            this.home.Show();
            this.Close();
        }
    }
}
