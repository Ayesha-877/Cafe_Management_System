using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_system
{
    public partial class UserOrder: Form
    {
        public UserOrder()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HQUBR9F;Initial Catalog=CafeDB;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            con.Open();
            string query = "select * from ItemTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemGV.DataSource = ds.Tables[0];
            con.Close();

        }
        void filterbycategory()
        {
            con.Open();
            string query = "select * from ItemTb1 where ItemCat='" + CatCb.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemGV.DataSource = ds.Tables[0];
            con.Close();

        }
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Hide();
            ItemForm item = new ItemForm();
            item.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Userform users = new Userform();
            users.Show();
        }
        int num = 0;
        int total, price,qty;
        string item,cat;

        private void AddToCartBtn_Click(object sender, EventArgs e)
        {
            if(QtyTb.Text=="Quantity")
            {
                MessageBox.Show("What is the Quantity ?");
            }
            else if (flag==0)
            {
                MessageBox.Show("Select the form to be ordered");
            }    
            else
            {
                num = num + 1;
                total = price * Convert.ToInt32(QtyTb.Text);
                table.Rows.Add(num, item, cat, price, total);
                OrderGV.DataSource = table;
                flag = 0;
            }
            sum = sum + total;
            OrderAmountBtn.Text= "RS. :  " + sum;
        }

        private void ItemGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            item = ItemGV.SelectedRows[0].Cells[1].Value.ToString();
            cat= ItemGV.SelectedRows[0].Cells[2].Value.ToString();
            price= Convert.ToInt32(ItemGV.SelectedRows[0].Cells[3].Value.ToString());
            flag = 1;


        }
        DataTable table = new DataTable();
        int flag = 0;
        int sum = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            ViewOrder view = new ViewOrder();
            view.Show();

        }

        private void PlaceOrderBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into OrderTab1 values(" + OrderNumTb.Text + ",'" + SellerNameTb.Text + "','" + Datelb1.Text + "','" + OrderAmountBtn.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("order successfully created");
            con.Close();
            // populate();
            //reset();
        }

        private void CatCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterbycategory();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            populate();
        }

       
        

        private void UserOrder_Load(object sender, EventArgs e)
        {
            populate();
            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("Total", typeof(int));
            OrderGV.DataSource = table;
            Datelb1.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            SellerNameTb.Text = Form1.User;
        }
    }
}
