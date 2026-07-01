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
    public partial class ViewOrder : Form
    {
        public ViewOrder()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HQUBR9F;Initial Catalog=CafeDB;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            con.Open();
            string query = "select * from OrderTab1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OrderGV.DataSource = ds.Tables[0];
            con.Close();

        }

        private void AddToCartBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OrderGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("***** FOODIE HUB *****", new Font("Abeezee", 20, FontStyle.Bold),Brushes.BlueViolet,new Point(210,50));
            e.Graphics.DrawString("***** Orders Summary *****", new Font("Abeezee", 20, FontStyle.Bold), Brushes.Blue, new Point(210, 95));
            e.Graphics.DrawString("Order No:" + OrderGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Abeezee", 12, FontStyle.Regular), Brushes.Black, new Point(120, 150));
            e.Graphics.DrawString("Seller Name:" + OrderGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Abeezee", 12, FontStyle.Regular), Brushes.Black, new Point(120, 180));
            e.Graphics.DrawString("Order Date:" + OrderGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Abeezee", 12, FontStyle.Regular), Brushes.Black, new Point(120, 220));
            e.Graphics.DrawString("Order Amount:" + OrderGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Abeezee", 12, FontStyle.Regular), Brushes.Black, new Point(120, 250));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
