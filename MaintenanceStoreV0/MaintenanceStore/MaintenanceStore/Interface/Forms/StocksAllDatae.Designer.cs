
namespace MaintenanceStore
{
    partial class Stock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.AddSpearpart = new System.Windows.Forms.Button();
            this.clearcondition = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Storec = new System.Windows.Forms.CheckBox();
            this.categoryName = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productlist = new System.Windows.Forms.ComboBox();
            this.option3 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.alldata = new System.Windows.Forms.RadioButton();
            this.option2 = new System.Windows.Forms.RadioButton();
            this.option1 = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.barcode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbStoreList = new System.Windows.Forms.ComboBox();
            this.cmbCategoryName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalrecord = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.totalQty = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.totalTable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.AddSpearpart);
            this.panel1.Controls.Add(this.clearcondition);
            this.panel1.Controls.Add(this.View);
            this.panel1.Controls.Add(this.Print);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 75);
            this.panel1.TabIndex = 1;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.LightPink;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold);
            this.delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.delete.Image = global::MaintenanceStore.Properties.Resources.trash_icon1;
            this.delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.delete.Location = new System.Drawing.Point(662, 1);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(142, 72);
            this.delete.TabIndex = 104;
            this.delete.Text = "Delete";
            this.delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.LightCoral;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Modern No. 20", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.update.Image = global::MaintenanceStore.Properties.Resources.Text_edit_icon1;
            this.update.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.update.Location = new System.Drawing.Point(514, 2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(146, 72);
            this.update.TabIndex = 103;
            this.update.Text = "Update";
            this.update.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // AddSpearpart
            // 
            this.AddSpearpart.BackColor = System.Drawing.Color.LightCoral;
            this.AddSpearpart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddSpearpart.FlatAppearance.BorderSize = 0;
            this.AddSpearpart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSpearpart.Font = new System.Drawing.Font("Modern No. 20", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSpearpart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddSpearpart.Image = global::MaintenanceStore.Properties.Resources.Button_Add_icon__1_;
            this.AddSpearpart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddSpearpart.Location = new System.Drawing.Point(225, 0);
            this.AddSpearpart.Name = "AddSpearpart";
            this.AddSpearpart.Size = new System.Drawing.Size(142, 72);
            this.AddSpearpart.TabIndex = 102;
            this.AddSpearpart.Text = "Add Spear part";
            this.AddSpearpart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddSpearpart.UseVisualStyleBackColor = false;
            this.AddSpearpart.Click += new System.EventHandler(this.AddSpearpart_Click);
            // 
            // clearcondition
            // 
            this.clearcondition.BackColor = System.Drawing.Color.LightPink;
            this.clearcondition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearcondition.FlatAppearance.BorderSize = 0;
            this.clearcondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearcondition.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold);
            this.clearcondition.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearcondition.Image = global::MaintenanceStore.Properties.Resources.Clear_icon1;
            this.clearcondition.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clearcondition.Location = new System.Drawing.Point(945, 2);
            this.clearcondition.Name = "clearcondition";
            this.clearcondition.Size = new System.Drawing.Size(142, 72);
            this.clearcondition.TabIndex = 101;
            this.clearcondition.Text = "Clear . Con";
            this.clearcondition.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.clearcondition.UseVisualStyleBackColor = false;
            this.clearcondition.Click += new System.EventHandler(this.clearcondition_Click);
            // 
            // View
            // 
            this.View.BackColor = System.Drawing.Color.LightPink;
            this.View.Cursor = System.Windows.Forms.Cursors.Hand;
            this.View.FlatAppearance.BorderSize = 0;
            this.View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold);
            this.View.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.View.Image = global::MaintenanceStore.Properties.Resources.SEO_icon1;
            this.View.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.View.Location = new System.Drawing.Point(370, 1);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(142, 72);
            this.View.TabIndex = 99;
            this.View.Text = "View";
            this.View.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.View.UseVisualStyleBackColor = false;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.Color.LightCoral;
            this.Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Print.FlatAppearance.BorderSize = 0;
            this.Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold);
            this.Print.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Print.Image = global::MaintenanceStore.Properties.Resources.printer;
            this.Print.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Print.Location = new System.Drawing.Point(804, 1);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(142, 72);
            this.Print.TabIndex = 100;
            this.Print.Text = "Report";
            this.Print.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Print.UseVisualStyleBackColor = false;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.LightPink;
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button14.Image = global::MaintenanceStore.Properties.Resources.Open_folder_search_icon1;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button14.Location = new System.Drawing.Point(81, 0);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(142, 78);
            this.button14.TabIndex = 98;
            this.button14.Text = "Data Retrive";
            this.button14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MaintenanceStore.Properties.Resources.filled_box_64;
            this.pictureBox3.Location = new System.Drawing.Point(8, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(1109, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(48, 48);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.exit.TabIndex = 19;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Broadway", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(8, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Search Condition";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Storec);
            this.panel3.Controls.Add(this.categoryName);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.productlist);
            this.panel3.Controls.Add(this.option3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.alldata);
            this.panel3.Controls.Add(this.option2);
            this.panel3.Controls.Add(this.option1);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.barcode);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.cmbStoreList);
            this.panel3.Controls.Add(this.cmbCategoryName);
            this.panel3.Location = new System.Drawing.Point(4, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(426, 519);
            this.panel3.TabIndex = 57;
            // 
            // Storec
            // 
            this.Storec.AutoSize = true;
            this.Storec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Storec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Storec.Location = new System.Drawing.Point(10, 320);
            this.Storec.Name = "Storec";
            this.Storec.Size = new System.Drawing.Size(64, 20);
            this.Storec.TabIndex = 126;
            this.Storec.Text = "Store";
            this.Storec.UseVisualStyleBackColor = true;
            this.Storec.CheckedChanged += new System.EventHandler(this.Storec_CheckedChanged);
            // 
            // categoryName
            // 
            this.categoryName.AutoSize = true;
            this.categoryName.Checked = true;
            this.categoryName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.categoryName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryName.Location = new System.Drawing.Point(9, 285);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(135, 20);
            this.categoryName.TabIndex = 125;
            this.categoryName.Text = "Category Name";
            this.categoryName.UseVisualStyleBackColor = true;
            this.categoryName.CheckedChanged += new System.EventHandler(this.categoryName_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MaintenanceStore.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 385);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 124;
            this.pictureBox1.TabStop = false;
            // 
            // productlist
            // 
            this.productlist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.productlist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.productlist.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productlist.FormattingEnabled = true;
            this.productlist.ItemHeight = 23;
            this.productlist.Location = new System.Drawing.Point(141, 190);
            this.productlist.Name = "productlist";
            this.productlist.Size = new System.Drawing.Size(280, 31);
            this.productlist.TabIndex = 104;
            // 
            // option3
            // 
            this.option3.AutoSize = true;
            this.option3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.option3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3.ForeColor = System.Drawing.Color.Red;
            this.option3.Location = new System.Drawing.Point(10, 236);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(95, 24);
            this.option3.TabIndex = 103;
            this.option3.Text = "Option 3";
            this.option3.UseVisualStyleBackColor = true;
            this.option3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.option3_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 101;
            this.label6.Text = "Product_Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MaintenanceStore.Properties.Resources._3;
            this.pictureBox2.Location = new System.Drawing.Point(270, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 99;
            this.pictureBox2.TabStop = false;
            // 
            // alldata
            // 
            this.alldata.AutoSize = true;
            this.alldata.Checked = true;
            this.alldata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alldata.ForeColor = System.Drawing.Color.Red;
            this.alldata.Location = new System.Drawing.Point(93, 29);
            this.alldata.Name = "alldata";
            this.alldata.Size = new System.Drawing.Size(91, 24);
            this.alldata.TabIndex = 98;
            this.alldata.TabStop = true;
            this.alldata.Text = "All Data";
            this.alldata.UseVisualStyleBackColor = true;
            this.alldata.MouseUp += new System.Windows.Forms.MouseEventHandler(this.alldata_MouseUp);
            // 
            // option2
            // 
            this.option2.AutoSize = true;
            this.option2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.option2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2.ForeColor = System.Drawing.Color.Red;
            this.option2.Location = new System.Drawing.Point(7, 157);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(95, 24);
            this.option2.TabIndex = 96;
            this.option2.Text = "Option 2";
            this.option2.UseVisualStyleBackColor = true;
            this.option2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.option2_MouseUp);
            // 
            // option1
            // 
            this.option1.AutoSize = true;
            this.option1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.option1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1.ForeColor = System.Drawing.Color.Red;
            this.option1.Location = new System.Drawing.Point(7, 74);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(95, 24);
            this.option1.TabIndex = 95;
            this.option1.Text = "Option 1";
            this.option1.UseVisualStyleBackColor = true;
            this.option1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.option1_MouseUp);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(149, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 17);
            this.label14.TabIndex = 92;
            this.label14.Text = "Write / Scan w Device";
            // 
            // barcode
            // 
            this.barcode.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcode.Location = new System.Drawing.Point(141, 117);
            this.barcode.MaxLength = 9;
            this.barcode.Multiline = true;
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(280, 41);
            this.barcode.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(8, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 90;
            this.label10.Text = "Barcode";
            // 
            // cmbStoreList
            // 
            this.cmbStoreList.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStoreList.FormattingEnabled = true;
            this.cmbStoreList.ItemHeight = 23;
            this.cmbStoreList.Items.AddRange(new object[] {
            "CM",
            "Inch",
            "Pixel"});
            this.cmbStoreList.Location = new System.Drawing.Point(145, 315);
            this.cmbStoreList.Name = "cmbStoreList";
            this.cmbStoreList.Size = new System.Drawing.Size(280, 31);
            this.cmbStoreList.TabIndex = 88;
            // 
            // cmbCategoryName
            // 
            this.cmbCategoryName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCategoryName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategoryName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoryName.FormattingEnabled = true;
            this.cmbCategoryName.ItemHeight = 23;
            this.cmbCategoryName.Location = new System.Drawing.Point(145, 278);
            this.cmbCategoryName.Name = "cmbCategoryName";
            this.cmbCategoryName.Size = new System.Drawing.Size(280, 31);
            this.cmbCategoryName.TabIndex = 86;
            this.cmbCategoryName.SelectedIndexChanged += new System.EventHandler(this.cmbCategoryName_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12.75F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(8, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 58;
            this.label4.Text = "Category";
            // 
            // totalrecord
            // 
            this.totalrecord.Location = new System.Drawing.Point(773, 647);
            this.totalrecord.Multiline = true;
            this.totalrecord.Name = "totalrecord";
            this.totalrecord.Size = new System.Drawing.Size(102, 22);
            this.totalrecord.TabIndex = 73;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(659, 648);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(111, 15);
            this.label19.TabIndex = 72;
            this.label19.Text = "Total Rec";
            // 
            // totalQty
            // 
            this.totalQty.Location = new System.Drawing.Point(553, 645);
            this.totalQty.Multiline = true;
            this.totalQty.Name = "totalQty";
            this.totalQty.Size = new System.Drawing.Size(102, 22);
            this.totalQty.TabIndex = 70;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(435, 647);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(112, 15);
            this.label20.TabIndex = 69;
            this.label20.Text = "Total QTY";
            // 
            // totalTable
            // 
            this.totalTable.Location = new System.Drawing.Point(1059, 647);
            this.totalTable.Multiline = true;
            this.totalTable.Name = "totalTable";
            this.totalTable.Size = new System.Drawing.Size(102, 22);
            this.totalTable.TabIndex = 75;
          
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(881, 651);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 15);
            this.label1.TabIndex = 74;
            this.label1.Text = " From Total Rec";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(438, 77);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(732, 554);
            this.dataGridView1.TabIndex = 121;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(339, 83);
            this.ID.Margin = new System.Windows.Forms.Padding(2);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(76, 20);
            this.ID.TabIndex = 127;
            this.ID.Visible = false;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 683);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.totalTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalrecord);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.totalQty);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalrecord;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbCategoryName;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button AddSpearpart;
        private System.Windows.Forms.Button clearcondition;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.ComboBox cmbStoreList;
        private System.Windows.Forms.TextBox totalQty;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox totalTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox barcode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton option2;
        private System.Windows.Forms.RadioButton option1;
        private System.Windows.Forms.RadioButton alldata;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton option3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox productlist;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox Storec;
        private System.Windows.Forms.CheckBox categoryName;
    }
}