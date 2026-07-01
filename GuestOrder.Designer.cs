namespace Cafe_Management_system
{
    partial class GuestOrder
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelb1 = new System.Windows.Forms.Label();
            this.OrderGV = new System.Windows.Forms.DataGridView();
            this.OrderAmountBtn = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ItemGV = new System.Windows.Forms.DataGridView();
            this.lable2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.QtyTbb = new System.Windows.Forms.TextBox();
            this.guestbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.QtyTb = new System.Windows.Forms.ComboBox();
            this.Ordernum = new System.Windows.Forms.TextBox();
            this.CellernameTb = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(1246, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.Datelb1);
            this.panel1.Controls.Add(this.OrderGV);
            this.panel1.Controls.Add(this.OrderAmountBtn);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ItemGV);
            this.panel1.Controls.Add(this.lable2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.QtyTbb);
            this.panel1.Controls.Add(this.guestbtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(190, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 716);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Datelb1
            // 
            this.Datelb1.AutoSize = true;
            this.Datelb1.BackColor = System.Drawing.SystemColors.Control;
            this.Datelb1.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelb1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.Datelb1.Location = new System.Drawing.Point(76, 663);
            this.Datelb1.Name = "Datelb1";
            this.Datelb1.Size = new System.Drawing.Size(72, 35);
            this.Datelb1.TabIndex = 28;
            this.Datelb1.Text = "Date";
            this.Datelb1.Click += new System.EventHandler(this.Datelb1_Click);
            // 
            // OrderGV
            // 
            this.OrderGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.OrderGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGV.Location = new System.Drawing.Point(176, 416);
            this.OrderGV.Name = "OrderGV";
            this.OrderGV.RowHeadersWidth = 51;
            this.OrderGV.RowTemplate.Height = 24;
            this.OrderGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderGV.Size = new System.Drawing.Size(866, 155);
            this.OrderGV.TabIndex = 27;
            // 
            // OrderAmountBtn
            // 
            this.OrderAmountBtn.AutoSize = true;
            this.OrderAmountBtn.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderAmountBtn.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.OrderAmountBtn.Location = new System.Drawing.Point(873, 653);
            this.OrderAmountBtn.Name = "OrderAmountBtn";
            this.OrderAmountBtn.Size = new System.Drawing.Size(147, 28);
            this.OrderAmountBtn.TabIndex = 26;
            this.OrderAmountBtn.Text = "Order Amount";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(603, 653);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 35);
            this.button3.TabIndex = 25;
            this.button3.Text = "Place The Order";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Location = new System.Drawing.Point(482, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 36);
            this.label4.TabIndex = 24;
            this.label4.Text = "Your Order";
            // 
            // ItemGV
            // 
            this.ItemGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ItemGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemGV.Location = new System.Drawing.Point(176, 186);
            this.ItemGV.Name = "ItemGV";
            this.ItemGV.RowHeadersWidth = 51;
            this.ItemGV.RowTemplate.Height = 24;
            this.ItemGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemGV.Size = new System.Drawing.Size(866, 154);
            this.ItemGV.TabIndex = 23;
            this.ItemGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemGV_CellContentClick_1);
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lable2.Location = new System.Drawing.Point(482, 112);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(211, 36);
            this.lable2.TabIndex = 21;
            this.lable2.Text = "Place Order";
            this.lable2.Click += new System.EventHandler(this.lable1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(357, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "Welcome To Foodie_Hub";
            // 
            // QtyTbb
            // 
            this.QtyTbb.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyTbb.ForeColor = System.Drawing.Color.Silver;
            this.QtyTbb.Location = new System.Drawing.Point(708, 346);
            this.QtyTbb.Multiline = true;
            this.QtyTbb.Name = "QtyTbb";
            this.QtyTbb.Size = new System.Drawing.Size(164, 30);
            this.QtyTbb.TabIndex = 19;
            this.QtyTbb.Text = "Quantity";
            this.QtyTbb.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // guestbtn
            // 
            this.guestbtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.guestbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guestbtn.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.guestbtn.ForeColor = System.Drawing.Color.White;
            this.guestbtn.Location = new System.Drawing.Point(878, 346);
            this.guestbtn.Name = "guestbtn";
            this.guestbtn.Size = new System.Drawing.Size(164, 35);
            this.guestbtn.TabIndex = 16;
            this.guestbtn.Text = "Add To Cart";
            this.guestbtn.UseVisualStyleBackColor = false;
            this.guestbtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cafe_Management_system.Properties.Resources.pictur3;
            this.pictureBox1.Location = new System.Drawing.Point(27, -23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1085, 756);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.button2.Location = new System.Drawing.Point(33, 713);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "LogOut";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // QtyTb
            // 
            this.QtyTb.BackColor = System.Drawing.SystemColors.Control;
            this.QtyTb.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.QtyTb.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.QtyTb.FormattingEnabled = true;
            this.QtyTb.Items.AddRange(new object[] {
            "Food",
            "Burger",
            "Pizza",
            "Sandwich",
            "Shawarma",
            "Cold Drink",
            "Coffee"});
            this.QtyTb.Location = new System.Drawing.Point(20, 153);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(164, 36);
            this.QtyTb.TabIndex = 9;
            this.QtyTb.Text = "Categories";
            this.QtyTb.SelectedIndexChanged += new System.EventHandler(this.CatCb_SelectedIndexChanged);
            this.QtyTb.SelectionChangeCommitted += new System.EventHandler(this.CatCb_SelectionChangeCommitted);
            // 
            // Ordernum
            // 
            this.Ordernum.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ordernum.ForeColor = System.Drawing.Color.Silver;
            this.Ordernum.Location = new System.Drawing.Point(20, 236);
            this.Ordernum.Multiline = true;
            this.Ordernum.Name = "Ordernum";
            this.Ordernum.Size = new System.Drawing.Size(164, 30);
            this.Ordernum.TabIndex = 17;
            this.Ordernum.Text = "Order No.";
            // 
            // CellernameTb
            // 
            this.CellernameTb.Enabled = false;
            this.CellernameTb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CellernameTb.ForeColor = System.Drawing.Color.Blue;
            this.CellernameTb.Location = new System.Drawing.Point(20, 272);
            this.CellernameTb.Multiline = true;
            this.CellernameTb.Name = "CellernameTb";
            this.CellernameTb.Size = new System.Drawing.Size(164, 31);
            this.CellernameTb.TabIndex = 18;
            this.CellernameTb.Text = "Guest";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(20, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 35);
            this.button4.TabIndex = 20;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // GuestOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1290, 778);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QtyTb);
            this.Controls.Add(this.CellernameTb);
            this.Controls.Add(this.Ordernum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuestOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemForm";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox QtyTbb;
        private System.Windows.Forms.Button guestbtn;
        private System.Windows.Forms.TextBox Ordernum;
        private System.Windows.Forms.TextBox CellernameTb;
        private System.Windows.Forms.ComboBox QtyTb;
        private System.Windows.Forms.DataGridView ItemGV;
        private System.Windows.Forms.DataGridView OrderGV;
        private System.Windows.Forms.Label OrderAmountBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Datelb1;
    }
}