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

namespace VeriTabanıMasaüstüProjesi
{
    public partial class ShopPage : Form
    {
        SqlConnection con =
            new SqlConnection("Data Source=MEHMET_EREN;Initial Catalog=Urun_DataBase_Project;Integrated Security=True");
        SqlConnection con1=
            new SqlConnection("Data Source=MEHMET_EREN;Initial Catalog=Urun_DataBase_Project;Integrated Security=True");



        SqlCommand cmd = new SqlCommand();
        int time;
   
        public ShopPage()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time += 1;
            lblSession.Text = "Oturum: " + time + " sn";
        }

        private void Shopping_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Shopping_Load(object sender, EventArgs e)
        {
            string UName = "";

            string command = "select UserName from Tbl_Log";

            SqlCommand cmd1 = new SqlCommand(command, con);
            con.Open();
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                UName = dr["UserName"].ToString();

            }
            con.Close();
            label1.Text = "Sayın : "+UName+"'";
            label1.BackColor=Color.PowderBlue;
            
          
            lblSession.BringToFront();
            lblSession.BackColor = Color.PowderBlue;
            timer1.Enabled = true;


           
           

            lblInfo.BackColor = Color.PowderBlue;
            lblInfo.BringToFront();
            lblInfo.Top = 10;
            lblInfo.Left = 10;
            lblInfo.Width = 20;
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            UserInfo ui = new UserInfo();
            ui.Show();
            this.Hide();
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            ProductPage pp = new ProductPage();
            pp.Show();
            this.Hide();

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            string UName = "";
       
            string command = "select UserName from Tbl_Log";
         
            SqlCommand cmd1 = new SqlCommand(command, con);
            con.Open();
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                UName = dr["UserName"].ToString();
             
            }
            con.Close();

            SqlCommand cmd = new SqlCommand("Delete from  Tbl_Log  where UserName=@UserName");
            con1.Open();
            cmd.Connection = con1;
            cmd.Parameters.AddWithValue("@UserName", UName);
            SqlDataReader dr1 = cmd.ExecuteReader();
            con.Close();


         
            con1.Close();
            LoginPage lp = new LoginPage();
            lp.Show();
            this.Hide();
        }

        private void btnBasket_Click(object sender, EventArgs e)
        {
                CartPage cp = new CartPage();
                cp.Show();
                this.Dispose();
         
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrderPage op = new OrderPage();
            op.Show();
            this.Dispose();
        }
    }
}
