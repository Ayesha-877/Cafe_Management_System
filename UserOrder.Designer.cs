namespace Cafe_Management_system
{
    partial class UserOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelb1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.PlaceOrderBtn = new System.Windows.Forms.Button();
            this.QtyTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OrderGV = new System.Windows.Forms.DataGridView();
            this.AddToCartBtn = new System.Windows.Forms.Button();
            this.OrderAmountBtn = new System.Windows.Forms.Label();
            this.SellerNameTb = new System.Windows.Forms.TextBox();
            this.OrderNumTb = new System.Windows.Forms.TextBox();
            this.ItemGV = new System.Windows.Forms.DataGridView();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.Datelb1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.RefreshBtn);
            this.panel1.Controls.Add(this.PlaceOrderBtn);
            this.panel1.Controls.Add(this.QtyTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.OrderGV);
            this.panel1.Controls.Add(this.AddToCartBtn);
            this.panel1.Controls.Add(this.OrderAmountBtn);
            this.panel1.Controls.Add(this.SellerNameTb);
            this.panel1.Controls.Add(this.OrderNumTb);
            this.panel1.Controls.Add(this.ItemGV);
            this.panel1.Controls.Add(this.CatCb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lable1);
            this.panel1.Location = new System.Drawing.Point(190, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 736);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Datelb1
            // 
            this.Datelb1.AutoSize = true;
            this.Datelb1.BackColor = System.Drawing.SystemColors.Control;
            this.Datelb1.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelb1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.Datelb1.Location = new System.Drawing.Point(13, 680);
            this.Datelb1.Name = "Datelb1";
            this.Datelb1.Size = new System.Drawing.Size(72, 35);
            this.Datelb1.TabIndex = 29;
            this.Datelb1.Text = "Date";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(487, 677);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 35);
            this.button1.TabIndex = 18;
            this.button1.Text = "View Orders";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RefreshBtn.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.RefreshBtn.ForeColor = System.Drawing.Color.White;
            this.RefreshBtn.Location = new System.Drawing.Point(45, 197);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(164, 35);
            this.RefreshBtn.TabIndex = 17;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // PlaceOrderBtn
            // 
            this.PlaceOrderBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.PlaceOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlaceOrderBtn.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.PlaceOrderBtn.ForeColor = System.Drawing.Color.White;
            this.PlaceOrderBtn.Location = new System.Drawing.Point(725, 677);
            this.PlaceOrderBtn.Name = "PlaceOrderBtn";
            this.PlaceOrderBtn.Size = new System.Drawing.Size(229, 35);
            this.PlaceOrderBtn.TabIndex = 16;
            this.PlaceOrderBtn.Text = "Place The Order";
            this.PlaceOrderBtn.UseVisualStyleBackColor = false;
            this.PlaceOrderBtn.Click += new System.EventHandler(this.PlaceOrderBtn_Click);
            // 
            // QtyTb
            // 
            this.QtyTb.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyTb.ForeColor = System.Drawing.Color.Silver;
            this.QtyTb.Location = new System.Drawing.Point(500, 360);
            this.QtyTb.Multiline = true;
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(192, 30);
            this.QtyTb.TabIndex = 15;
            this.QtyTb.Text = "Quantity";
            this.QtyTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Location = new System.Drawing.Point(494, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 36);
            this.label4.TabIndex = 14;
            this.label4.Text = "Your Order";
            // 
            // OrderGV
            // 
            this.OrderGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.OrderGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGV.Location = new System.Drawing.Point(319, 485);
            this.OrderGV.Name = "OrderGV";
            this.OrderGV.RowHeadersWidth = 51;
            this.OrderGV.RowTemplate.Height = 24;
            this.OrderGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderGV.Size = new System.Drawing.Size(799, 165);
            this.OrderGV.TabIndex = 13;
            // 
            // AddToCartBtn
            // 
            this.AddToCartBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.AddToCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddToCartBtn.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.AddToCartBtn.ForeColor = System.Drawing.Color.White;
            this.AddToCartBtn.Location = new System.Drawing.Point(500, 396);
            this.AddToCartBtn.Name = "AddToCartBtn";
            this.AddToCartBtn.Size = new System.Drawing.Size(192, 35);
            this.AddToCartBtn.TabIndex = 6;
            this.AddToCartBtn.Text = "Add To Cart";
            this.AddToCartBtn.UseVisualStyleBackColor = false;
            this.AddToCartBtn.Click += new System.EventHandler(this.AddToCartBtn_Click);
            // 
            // OrderAmountBtn
            // 
            this.OrderAmountBtn.AutoSize = true;
            this.OrderAmountBtn.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderAmountBtn.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.OrderAmountBtn.Location = new System.Drawing.Point(960, 684);
            this.OrderAmountBtn.Name = "OrderAmountBtn";
            this.OrderAmountBtn.Size = new System.Drawing.Size(147, 28);
            this.OrderAmountBtn.TabIndex = 12;
            this.OrderAmountBtn.Text = "Order Amount";
            // 
            // SellerNameTb
            // 
            this.SellerNameTb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerNameTb.ForeColor = System.Drawing.Color.Blue;
            this.SellerNameTb.Location = new System.Drawing.Point(45, 274);
            this.SellerNameTb.Multiline = true;
            this.SellerNameTb.Name = "SellerNameTb";
            this.SellerNameTb.Size = new System.Drawing.Size(164, 31);
            this.SellerNameTb.TabIndex = 11;
            this.SellerNameTb.Text = "Seller Name";
            // 
            // OrderNumTb
            // 
            this.OrderNumTb.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderNumTb.ForeColor = System.Drawing.Color.Silver;
            this.OrderNumTb.Location = new System.Drawing.Point(45, 238);
            this.OrderNumTb.Multiline = true;
            this.OrderNumTb.Name = "OrderNumTb";
            this.OrderNumTb.Size = new System.Drawing.Size(164, 30);
            this.OrderNumTb.TabIndex = 10;
            this.OrderNumTb.Text = "Order No.";
            // 
            // ItemGV
            // 
            this.ItemGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ItemGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemGV.Location = new System.Drawing.Point(252, 155);
            this.ItemGV.Name = "ItemGV";
            this.ItemGV.RowHeadersWidth = 51;
            this.ItemGV.RowTemplate.Height = 24;
            this.ItemGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemGV.Size = new System.Drawing.Size(866, 195);
            this.ItemGV.TabIndex = 9;
            this.ItemGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemGV_CellContentClick);
            // 
            // CatCb
            // 
            this.CatCb.BackColor = System.Drawing.SystemColors.Control;
            this.CatCb.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CatCb.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Items.AddRange(new object[] {
            "Food",
            "Burger",
            "Pizza",
            "Sandwich",
            "Shawarma",
            "Cold Drink",
            "Coffee"});
            this.CatCb.Location = new System.Drawing.Point(45, 155);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(164, 36);
            this.CatCb.TabIndex = 8;
            this.CatCb.Text = "Categories";
            this.CatCb.SelectionChangeCommitted += new System.EventHandler(this.CatCb_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(395, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome To Foodie_Hub";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lable1.Location = new System.Drawing.Point(481, 83);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(211, 36);
            this.lable1.TabIndex = 6;
            this.lable1.Text = "Place Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(1306, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.button2.Location = new System.Drawing.Point(25, 721);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "LogOut";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.button4.Location = new System.Drawing.Point(25, 292);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 35);
            this.button4.TabIndex = 17;
            this.button4.Text = "Users";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button5.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.button5.Location = new System.Drawing.Point(25, 206);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 35);
            this.button5.TabIndex = 18;
            this.button5.Text = "Item";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // UserOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1343, 778);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserOrder";
            this.Load += new System.EventHandler(this.UserOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PlaceOrderBtn;
        private System.Windows.Forms.TextBox QtyTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView OrderGV;
        private System.Windows.Forms.Button AddToCartBtn;
        private System.Windows.Forms.Label OrderAmountBtn;
        private System.Windows.Forms.TextBox SellerNameTb;
        private System.Windows.Forms.TextBox OrderNumTb;
        private System.Windows.Forms.DataGridView ItemGV;
        private System.Windows.Forms.ComboBox CatCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Datelb1;
    }
}