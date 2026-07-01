using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_system
{
    public partial class GuestOrder: Form
    {
        public GuestOrder()
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
            string query = "select * from ItemTb1 where ItemCat='" + QtyTb.SelectedItem.ToString() + "'";
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

        private void lable1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            populate();
            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("Total", typeof(int));
            OrderGV.DataSource = table;
            Datelb1.Text = DateTime.Today.Day.ToString()+"/"+ DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
           // DateTb.Text = DateTime.Today.ToString();
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
           
        }
        int num = 0;
       int total, price;
        string item, cat;
        DataTable table = new DataTable();
        int flag = 0, sum = 0;



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lable1_Click_1(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            int maxQuantity = 50;
            int quantity;

            // Validate if quantity is a number
            if (!int.TryParse(QtyTbb.Text, out quantity))
            {
                MessageBox.Show("Please enter a valid numeric quantity.");
                return;
            }

            if (quantity > maxQuantity)
            {
                MessageBox.Show("Insufficient stock. The maximum quantity available is 50.");
                return;
            }

            if (QtyTbb.Text == "Quantity" || quantity <= 0)
            {
                MessageBox.Show("What is the Quantity?");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select the form to be ordered.");
            }
            else
            {
                num = num + 1;
                total = price * quantity;
                table.Rows.Add(num, item, cat, price, total);
                OrderGV.DataSource = table;
                flag = 0;

                sum = sum + total;
                OrderAmountBtn.Text = "RS. : " + sum;
            }
        }




        private void ItemGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            item = ItemGV.SelectedRows[0].Cells[1].Value.ToString();
            cat = ItemGV.SelectedRows[0].Cells[2].Value.ToString();
            price = Convert.ToInt32(ItemGV.SelectedRows[0].Cells[3].Value.ToString());
            flag = 1;
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into OrderTab1 values(" + Ordernum.Text + ",'" + CellernameTb.Text + "','" + Datelb1.Text + "','" + OrderAmountBtn.Text+ "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("order successfully created");
            con.Close();
           // populate();
            //reset();
        }

        private void Datelb1_Click(object sender, EventArgs e)
        {

        }

        private void CatCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CatCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterbycategory();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
