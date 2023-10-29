using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using ZXing.QrCode.Internal;
using ZXing.Multi;

namespace MaintenanceStore
{
    public partial class Barcode : Form
    {
        private const int default_height = 60;
        private const int default_width = 60;
        private Home home;
        private int height;
        private int width;
        public Barcode(Home home)
        {
            this.home = home;
            this.height = 60;
            this.width = 300;
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Enter  your  Code !", "Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (radioButton2.Checked && (H.Text == "" || W.Text == ""))
            {
                MessageBox.Show("Please Enter Height and Width !", "Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (radioButton2.Checked)
            {
                this.height = int.Parse(H.Text);
                this.width = int.Parse(W.Text);
            }

            BarcodeWriter writer = new BarcodeWriter()
            {

                Format = BarcodeFormat.CODE_128,

                Options = new QrCodeEncodingOptions
                {
                    DisableECI = true,
                    CharacterSet = "UTF-8",
                    Height = this.height,
                    Width = this.width,
                    PureBarcode = false,
                    Margin = 0,
                    GS1Format = true,
                    ErrorCorrection = ErrorCorrectionLevel.H,
                    //        Font = new Font(FontFamily.GenericSansSerif,
                    //12.0F, FontStyle.Bold)

                },

            };

            var bitmap = writer.Write(textBox1.Text + textBox2.Text);

                pictureBox2.Image = bitmap;
        }//create
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = textBox1.Text + textBox2.Text;
            dialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(pictureBox2.Image);
                  bmp.Save(dialog.FileName);
            }
        }//save
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }//chektext
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }//check_num
        private void pictureBox4_Click(object sender, EventArgs e)
        {
          
            this.home.Show();
            this.Close();

        }//exit
        private void H_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void W_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            H.Enabled = false;
            W.Enabled = false;

            this.height = default_height;
            this.width = default_width;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            H.Enabled = true;
            W.Enabled = true;
        }
       
    }
    
}
