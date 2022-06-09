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
    public partial class RegisterPage : Form
    {
        SqlConnection con = new SqlConnection("Data Source=MEHMET_EREN;Initial Catalog=Urun_DataBase_Project;Integrated Security=True");
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {
            lblSifreUyusmazlik.Visible = false;
            lblDogrula.Visible = false;
            lblUyari.Visible = false;

            
        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
     
           

            if ((txtPassword.Text == txtPasswordRepeat.Text) && txtUserName.TextLength>=8 && txtPassword.TextLength>=8 && txtPasswordRepeat.TextLength>=8)
            {
                SqlCommand cmd = new SqlCommand("Insert into Tbl_User (UserName,Password) values(@UserName,@Password)");
                con.Open();
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                lblUyari.Visible = false;
                LoginPage loginPage = new LoginPage();
                loginPage.Show();
                this.Hide();

            }
            else if (txtUserName.TextLength < 8 && txtPassword.TextLength < 8 && txtPasswordRepeat.TextLength < 8)
            {

                lblUyari.Visible = true;

            }
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtPasswordRepeat.Text)
            {

                lblDogrula.Visible = true;

            }
            else if (txtPassword.Text != txtPasswordRepeat.Text)
            {
                lblDogrula.Visible = false;

            }
        }

        private void txtPasswordRepeat_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtPasswordRepeat.Text)
            {
                lblDogrula.Visible = true;
                lblSifreUyusmazlik.Visible = false;

            }
            else if (txtPassword.Text != txtPasswordRepeat.Text)
            {
                lblDogrula.Visible = false;
                lblSifreUyusmazlik.Visible = true;

            }
        }

        private void RegisterPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button97_Click(object sender, EventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Show();
            this.Dispose();
        }
    }
}
