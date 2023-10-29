
namespace MaintenanceStore.Interface.Forms
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.Add_Category = new System.Windows.Forms.Button();
            this.Add_Source = new System.Windows.Forms.Button();
            this.Add_Store = new System.Windows.Forms.Button();
            this.Add_Department = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.close);
            this.panel1.Location = new System.Drawing.Point(-7, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 80);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MaintenanceStore.Properties.Resources.add_row_64;
            this.pictureBox3.Location = new System.Drawing.Point(16, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Rockwell Extra Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(97, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Maintenance Store";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MaintenanceStore.Properties.Resources._3;
            this.pictureBox1.Location = new System.Drawing.Point(566, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = global::MaintenanceStore.Properties.Resources.g1;
            this.close.Location = new System.Drawing.Point(732, 16);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(48, 48);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.close.TabIndex = 21;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Add_Category
            // 
            this.Add_Category.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Add_Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Add_Category.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Add_Category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_Category.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Category.Location = new System.Drawing.Point(515, 111);
            this.Add_Category.Name = "Add_Category";
            this.Add_Category.Size = new System.Drawing.Size(232, 96);
            this.Add_Category.TabIndex = 4;
            this.Add_Category.Text = "Add Category";
            this.Add_Category.UseVisualStyleBackColor = false;
            this.Add_Category.Click += new System.EventHandler(this.Add_Category_Click);
            // 
            // Add_Source
            // 
            this.Add_Source.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Add_Source.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Add_Source.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Add_Source.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_Source.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Source.Location = new System.Drawing.Point(23, 320);
            this.Add_Source.Name = "Add_Source";
            this.Add_Source.Size = new System.Drawing.Size(249, 96);
            this.Add_Source.TabIndex = 5;
            this.Add_Source.Text = "Add Source Place";
            this.Add_Source.UseVisualStyleBackColor = false;
            this.Add_Source.Click += new System.EventHandler(this.Add_Source_Click);
            // 
            // Add_Store
            // 
            this.Add_Store.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Add_Store.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Add_Store.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Add_Store.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_Store.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Store.Location = new System.Drawing.Point(23, 101);
            this.Add_Store.Name = "Add_Store";
            this.Add_Store.Size = new System.Drawing.Size(249, 96);
            this.Add_Store.TabIndex = 7;
            this.Add_Store.Text = "Add Store";
            this.Add_Store.UseVisualStyleBackColor = false;
            this.Add_Store.Click += new System.EventHandler(this.Add_Store_Click);
            // 
            // Add_Department
            // 
            this.Add_Department.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Add_Department.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Add_Department.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Add_Department.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_Department.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Department.Location = new System.Drawing.Point(515, 320);
            this.Add_Department.Name = "Add_Department";
            this.Add_Department.Size = new System.Drawing.Size(232, 96);
            this.Add_Department.TabIndex = 8;
            this.Add_Department.Text = "Add Department";
            this.Add_Department.UseVisualStyleBackColor = false;
            this.Add_Department.Click += new System.EventHandler(this.Add_Department_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MaintenanceStore.Properties.Resources._3;
            this.pictureBox2.Location = new System.Drawing.Point(278, 194);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(231, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 479);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Add_Department);
            this.Controls.Add(this.Add_Store);
            this.Controls.Add(this.Add_Source);
            this.Controls.Add(this.Add_Category);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        //private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_Source;
        private System.Windows.Forms.Button Add_Category;
        private System.Windows.Forms.Button Add_Store;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Add_Department;
    }
}