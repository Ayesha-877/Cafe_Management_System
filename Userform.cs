using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Cafe_Management_system
{
    public partial class Userform: Form
    {
        public Userform()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HQUBR9F;Initial Catalog=CafeDB;Integrated Security=True;Connect Timeout=30");
       void populate()
        {
            con.Open();
            string query = "select * from UserTB1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UserGV.DataSource = ds.Tables[0];
            con.Close();

        }
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserOrder user = new UserOrder();
            user.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into UserTB1 values('"+unameTb.Text+"','"+uphoneTb.Text+"','"+upassTb.Text+"')";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User successfully created");
            con.Close();
            populate();
            reset();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Userform_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void UserGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            unameTb.Text = UserGV.SelectedRows[0].Cells[0].Value.ToString();
            uphoneTb.Text = UserGV.SelectedRows[0].Cells[1].Value.ToString();
            upassTb.Text = UserGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (uphoneTb.Text == "")
            {
                MessageBox.Show("selected user to be deleted");
            }
            else
            {
                con.Open();
                string query = "delete from UserTB1 where phone='" + uphoneTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("user successfuly deleted");
                con.Close();
                populate();
                reset();
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if(unameTb.Text=="" || uphoneTb.Text=="" || upassTb.Text=="")
            {
                MessageBox.Show("fill all the feild");
            }
            else
            {
                con.Open();
                string query = "update UserTB1 set user_name='" + unameTb.Text + "',password='" + upassTb.Text + "'where phone='" + uphoneTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("user successfully updated");
                con.Close();
                populate();
                reset();
            }
           
        }
        public void reset()
        {
            unameTb.Text = "";
            upassTb.Text = "";
            uphoneTb.Text = "";

        }
    }
}
