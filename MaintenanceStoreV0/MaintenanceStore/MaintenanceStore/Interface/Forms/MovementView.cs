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
    public partial class MovementView : Form
    {
        private MovmentsClass movmentsClass;
        private MaintenanceStore.Interface.Forms.Movements movement;

        public MovementView(MovmentsClass movmentsClass, Movements movement)
        {
            this.movmentsClass = movmentsClass;
            this.movement = movement;
            InitializeComponent();
        } 
        public MovementView()
        {
            InitializeComponent();
        }
        private void MovementView_Load(object sender, EventArgs e)
        {
            code.Text = movmentsClass.code;
            product_name.Text = movmentsClass.productname;
            category.Text = movmentsClass.category;
            store.Text = movmentsClass.store;
            description.Text = movmentsClass.Description;
            qtyinstock.Text = movmentsClass.qty_stock.ToString();
            in_out.Text = movmentsClass.in_out;
            date.Text = movmentsClass.Date;
            qtyadded.Text = movmentsClass.qty_added.ToString();
            notes.Text = movmentsClass.Notes;
            Dep.Text = movmentsClass.depart;
            source.Text = movmentsClass.source;
        }//load 
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.movement.Show();
            this.movement.SearchGrid();
            this.Close();
        }//eixt
    }
}
