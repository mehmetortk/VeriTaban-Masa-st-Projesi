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
    public partial class LoginPage : Form
    {
        SqlConnection con = new SqlConnection("Data Source=MEHMET_EREN;Initial Catalog=Urun_DataBase_Project;Integrated Security=True");
        SqlConnection con1 = new SqlConnection("Data Source=MEHMET_EREN;Initial Catalog=Urun_DataBase_Project;Integrated Security=True");

        public LoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();

        }


        private void button2_Click(object sender, EventArgs e)
        {


            DateTime dt = DateTime.Now;
     
           
        
            SqlCommand cmd = new SqlCommand("Select UserName,Password from Tbl_User where UserName='" + txtUserName.Text + "'and Password='" + txtPassword.Text + "'");
            con.Open();
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {

                SqlCommand cmd1 = new SqlCommand("insert into  Tbl_Log (UserName,Date) values (@UserName,@Date) ");
                con1.Open();
                cmd1.Connection = con1;
                cmd1.Parameters.Add("@UserName", txtUserName.Text);
                cmd1.Parameters.Add("@Date", dt);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                con1.Close();
                ShopPage sp = new ShopPage();
                sp.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
            }
          
            con.Close();
        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterPage rp = new RegisterPage();
            rp.Show();
            this.Hide();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGoster.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
