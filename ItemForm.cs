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
    public partial class ItemForm: Form
    {
        public ItemForm()
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

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Userform users = new Userform();
            users.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserOrder user = new UserOrder();
            user.Show();
            this.Hide();
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ItemNameTb.Text=="" || ItemNumTb.Text=="" || ItemPrice.Text=="")
            {
                MessageBox.Show("fill all the fields");
            }
            else
            {
                con.Open();
                string query = "insert into ItemTb1 values('" + ItemNumTb.Text + "','" + ItemNameTb.Text + "','" + CatCb.SelectedItem.ToString() + "','"+ItemPrice.Text+"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("item successfully created");
                con.Close();
                populate();
                reset();
            }

        }

        private void ItemGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemNumTb.Text = ItemGV.SelectedRows[0].Cells[0].Value.ToString();
            ItemNameTb.Text = ItemGV.SelectedRows[0].Cells[1].Value.ToString();
            CatCb.SelectedItem = ItemGV.SelectedRows[0].Cells[2].Value.ToString();
            ItemPrice.Text = ItemGV.SelectedRows[0].Cells[3].Value.ToString();
        }


        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "Delete from ItemTb1 where ItemNum='"+ItemNumTb.Text+"';";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("item deleted successfully !");
                con.Close();
                populate();
                reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (ItemNumTb.Text == "" || ItemNameTb.Text == "" || ItemPrice.Text == "")
            {
                MessageBox.Show("fill all the Data");
            }
            else
            {
                con.Open();
                string query = "update ItemTb1 set ItemName='" + ItemNameTb.Text + "',ItemCat='" + CatCb.SelectedItem.ToString()+ "',ItemPrice='" + ItemPrice.Text + "' where ItemNum='"+ItemNumTb.Text+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("item successfully updated");
                con.Close();
                populate();
                reset();
            }
        }
         public void reset()
        {
           ItemNumTb.Text = "";
           ItemNameTb.Text = "";
           CatCb.SelectedItem = "";
            ItemPrice.Text = "";
        }
    }
}
