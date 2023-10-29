
namespace MaintenanceStore.Interface.Forms
{
    partial class movements_prod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(movements_prod));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Import = new System.Windows.Forms.RadioButton();
            this.Export = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SourcePlace = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.source_place = new System.Windows.Forms.RadioButton();
            this.department = new System.Windows.Forms.RadioButton();
            this.Cmbstorelist = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.qtyav = new System.Windows.Forms.TextBox();
            this.cmdproductname = new System.Windows.Forms.ComboBox();
            this.category = new System.Windows.Forms.TextBox();
            this.notes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdtofrom = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Supmit2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 59);
            this.panel2.TabIndex = 60;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MaintenanceStore.Properties.Resources._3;
            this.pictureBox1.Location = new System.Drawing.Point(473, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::MaintenanceStore.Properties.Resources.g1;
            this.pictureBox4.Location = new System.Drawing.Point(636, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MaintenanceStore.Properties.Resources.resize_3_64;
            this.pictureBox3.Location = new System.Drawing.Point(16, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightCoral;
            this.label10.Font = new System.Drawing.Font("Rockwell Extra Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.ForestGreen;
            this.label10.Location = new System.Drawing.Point(80, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 24);
            this.label10.TabIndex = 22;
            this.label10.Text = "Movements";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.SourcePlace);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.Cmbstorelist);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.description);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.qtyav);
            this.panel1.Controls.Add(this.cmdproductname);
            this.panel1.Controls.Add(this.category);
            this.panel1.Controls.Add(this.notes);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmdtofrom);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.qty);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.code);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.Supmit2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(4, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 678);
            this.panel1.TabIndex = 66;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Import);
            this.groupBox1.Controls.Add(this.Export);
            this.groupBox1.Location = new System.Drawing.Point(210, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 45);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IN/OUT";
            // 
            // Import
            // 
            this.Import.AutoSize = true;
            this.Import.Checked = true;
            this.Import.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Import.ForeColor = System.Drawing.Color.Red;
            this.Import.Location = new System.Drawing.Point(74, 11);
            this.Import.Margin = new System.Windows.Forms.Padding(2);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(86, 28);
            this.Import.TabIndex = 97;
            this.Import.TabStop = true;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.CheckedChanged += new System.EventHandler(this.Import_CheckedChanged);
            // 
            // Export
            // 
            this.Export.AutoSize = true;
            this.Export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export.ForeColor = System.Drawing.Color.Red;
            this.Export.Location = new System.Drawing.Point(232, 11);
            this.Export.Margin = new System.Windows.Forms.Padding(2);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(89, 28);
            this.Export.TabIndex = 98;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(210, 333);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(403, 20);
            this.dateTimePicker1.TabIndex = 103;
            this.dateTimePicker1.Value = new System.DateTime(2021, 10, 4, 0, 0, 0, 0);
            // 
            // SourcePlace
            // 
            this.SourcePlace.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.SourcePlace.FormattingEnabled = true;
            this.SourcePlace.ItemHeight = 25;
            this.SourcePlace.Items.AddRange(new object[] {
            "CM",
            "Inch",
            "Pixel"});
            this.SourcePlace.Location = new System.Drawing.Point(210, 456);
            this.SourcePlace.Name = "SourcePlace";
            this.SourcePlace.Size = new System.Drawing.Size(403, 33);
            this.SourcePlace.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(52, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 101;
            this.label1.Text = "Source_place";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.source_place);
            this.groupBox2.Controls.Add(this.department);
            this.groupBox2.Location = new System.Drawing.Point(210, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 49);
            this.groupBox2.TabIndex = 100;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose the location";
            // 
            // source_place
            // 
            this.source_place.AutoSize = true;
            this.source_place.Cursor = System.Windows.Forms.Cursors.Hand;
            this.source_place.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.source_place.ForeColor = System.Drawing.Color.Red;
            this.source_place.Location = new System.Drawing.Point(209, 12);
            this.source_place.Margin = new System.Windows.Forms.Padding(2);
            this.source_place.Name = "source_place";
            this.source_place.Size = new System.Drawing.Size(157, 28);
            this.source_place.TabIndex = 94;
            this.source_place.Text = "Source_place";
            this.source_place.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.source_place.UseVisualStyleBackColor = true;
            this.source_place.MouseUp += new System.Windows.Forms.MouseEventHandler(this.source_place_MouseUp);
            // 
            // department
            // 
            this.department.AutoSize = true;
            this.department.Checked = true;
            this.department.Cursor = System.Windows.Forms.Cursors.Hand;
            this.department.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department.ForeColor = System.Drawing.Color.Red;
            this.department.Location = new System.Drawing.Point(25, 12);
            this.department.Margin = new System.Windows.Forms.Padding(2);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(135, 28);
            this.department.TabIndex = 93;
            this.department.TabStop = true;
            this.department.Text = "Department";
            this.department.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.department.UseVisualStyleBackColor = true;
            this.department.MouseUp += new System.Windows.Forms.MouseEventHandler(this.department_MouseUp);
            // 
            // Cmbstorelist
            // 
            this.Cmbstorelist.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Cmbstorelist.FormattingEnabled = true;
            this.Cmbstorelist.ItemHeight = 25;
            this.Cmbstorelist.Items.AddRange(new object[] {
            "CM",
            "Inch",
            "Pixel"});
            this.Cmbstorelist.Location = new System.Drawing.Point(210, 188);
            this.Cmbstorelist.Name = "Cmbstorelist";
            this.Cmbstorelist.Size = new System.Drawing.Size(403, 33);
            this.Cmbstorelist.TabIndex = 99;
            this.Cmbstorelist.SelectedIndexChanged += new System.EventHandler(this.Cmbstorelist_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(26, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 96;
            this.label2.Text = "Import/Export";
            // 
            // description
            // 
            this.description.Enabled = false;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(210, 263);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Size = new System.Drawing.Size(403, 61);
            this.description.TabIndex = 89;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(46, 288);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 25);
            this.label14.TabIndex = 88;
            this.label14.Text = "Description";
            // 
            // qtyav
            // 
            this.qtyav.Enabled = false;
            this.qtyav.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyav.Location = new System.Drawing.Point(210, 227);
            this.qtyav.Multiline = true;
            this.qtyav.Name = "qtyav";
            this.qtyav.ReadOnly = true;
            this.qtyav.Size = new System.Drawing.Size(227, 30);
            this.qtyav.TabIndex = 87;
            // 
            // cmdproductname
            // 
            this.cmdproductname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmdproductname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmdproductname.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdproductname.FormattingEnabled = true;
            this.cmdproductname.ItemHeight = 25;
            this.cmdproductname.Items.AddRange(new object[] {
            "CM",
            "Inch",
            "Pixel"});
            this.cmdproductname.Location = new System.Drawing.Point(210, 107);
            this.cmdproductname.Name = "cmdproductname";
            this.cmdproductname.Size = new System.Drawing.Size(403, 33);
            this.cmdproductname.TabIndex = 85;
            this.cmdproductname.SelectedIndexChanged += new System.EventHandler(this.cmdproductname_SelectedIndexChanged);
            // 
            // category
            // 
            this.category.Enabled = false;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(210, 147);
            this.category.Multiline = true;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Size = new System.Drawing.Size(403, 32);
            this.category.TabIndex = 27;
            // 
            // notes
            // 
            this.notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes.Location = new System.Drawing.Point(208, 538);
            this.notes.Multiline = true;
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(405, 68);
            this.notes.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(54, 554);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 81;
            this.label8.Text = "Notes";
            // 
            // cmdtofrom
            // 
            this.cmdtofrom.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdtofrom.FormattingEnabled = true;
            this.cmdtofrom.ItemHeight = 25;
            this.cmdtofrom.Items.AddRange(new object[] {
            "CM",
            "Inch",
            "Pixel"});
            this.cmdtofrom.Location = new System.Drawing.Point(210, 417);
            this.cmdtofrom.Name = "cmdtofrom";
            this.cmdtofrom.Size = new System.Drawing.Size(403, 33);
            this.cmdtofrom.TabIndex = 80;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(52, 417);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 25);
            this.label13.TabIndex = 79;
            this.label13.Text = "Department";
            // 
            // qty
            // 
            this.qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty.Location = new System.Drawing.Point(208, 500);
            this.qty.Multiline = true;
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(227, 30);
            this.qty.TabIndex = 6;
            this.qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(58, 505);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 25);
            this.label9.TabIndex = 77;
            this.label9.Text = "QTY .";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(52, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 73;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(44, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 68;
            this.label4.Text = "Store";
            // 
            // code
            // 
            this.code.CausesValidation = false;
            this.code.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code.Location = new System.Drawing.Point(210, 65);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(403, 29);
            this.code.TabIndex = 1;
            this.code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.code_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(44, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 25);
            this.label12.TabIndex = 65;
            this.label12.Text = "Code";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(44, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 25);
            this.label11.TabIndex = 58;
            this.label11.Text = "Category";
            // 
            // Supmit2
            // 
            this.Supmit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Supmit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Supmit2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.Supmit2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Linen;
            this.Supmit2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Supmit2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supmit2.ForeColor = System.Drawing.Color.Red;
            this.Supmit2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Supmit2.Location = new System.Drawing.Point(284, 612);
            this.Supmit2.Name = "Supmit2";
            this.Supmit2.Size = new System.Drawing.Size(222, 61);
            this.Supmit2.TabIndex = 40;
            this.Supmit2.Text = "Supmit";
            this.Supmit2.UseVisualStyleBackColor = false;
            this.Supmit2.Click += new System.EventHandler(this.Supmit2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(44, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(45, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "QTY. available";
            // 
            // movements_prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 743);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "movements_prod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import";
            this.Load += new System.EventHandler(this.movements_prod_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Supmit2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmdtofrom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.Label label9;
       // private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.TextBox notes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.ComboBox cmdproductname;
        private System.Windows.Forms.TextBox qtyav;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton source_place;
        private System.Windows.Forms.RadioButton department;
        private System.Windows.Forms.ComboBox Cmbstorelist;
        private System.Windows.Forms.RadioButton Export;
        private System.Windows.Forms.RadioButton Import;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox SourcePlace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}