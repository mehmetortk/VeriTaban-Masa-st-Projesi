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
    public partial class UserInfo : Form
    {
        SqlConnection con = new SqlConnection("Data Source=MEHMET_EREN;Initial Catalog=Urun_DataBase_Project;Integrated Security=True");
        SqlConnection con2 = new SqlConnection("Data Source=MEHMET_EREN;Initial Catalog=Urun_DataBase_Project;Integrated Security=True");

        SqlCommand cmd = new SqlCommand();
        public UserInfo()
        {
            InitializeComponent();
        }

        private void UserInfo_Load(object sender, EventArgs e)

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


            


            string SqlCmd = "Select Tbl_User.UserName,Tbl_User.Password, Tbl_Customer.ContactName,Tbl_Customer.CityId,Tbl_Customer.Address,Tbl_Customer.PhoneNumber from Tbl_Customer inner join Tbl_User on Tbl_Customer.UserName = Tbl_User.UserName where Tbl_User.UserName='" + UName + "'";
            cmd = new SqlCommand(SqlCmd, con);
            con.Open();
            SqlDataReader dr1 = cmd.ExecuteReader();

            if (dr1.Read())
            {
                txtUserName.Text = dr1["UserName"].ToString();
                txtPassword.Text = dr1["Password"].ToString();
                txtName.Text = dr1["ContactName"].ToString();
                comboCity.SelectedText = dr1["CityId"].ToString();
                txtAddress.Text = dr1["Address"].ToString();
                txtPhone.Text = dr1["PhoneNumber"].ToString();

            }
            con.Close();

            // TODO: This line of code loads data into the 'urun_DataBase_ProjectDataSet.Tbl_Sehir' table. You can move, or remove it, as needed.
            this.tbl_SehirTableAdapter.Fill(this.urun_DataBase_ProjectDataSet.Tbl_Sehir);
            // TODO: This line of code loads data into the 'urun_DataBase_ProjectDataSet.Tbl_Customer' table. You can move, or remove it, as needed.
            this.tbl_CustomerTableAdapter.Fill(this.urun_DataBase_ProjectDataSet.Tbl_Customer);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into Tbl_Customer (ContactName,CityId,UserName,Address,PhoneNumber) values(@ContactName,@CityId,@UserName,@Address,@PhoneNumber)");

            con.Open();



            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@ContactName", txtName.Text);
            cmd.Parameters.AddWithValue("@CityId", comboCity.SelectedIndex);
            cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Başarıyla Kaydedildi");
            con.Close();
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShopPage sp = new ShopPage();
            sp.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd =
                new SqlCommand("Update  Tbl_Customer set ContactName=@ContactName,CityId=@CityId,Address=@Address,PhoneNumber=@PhoneNumber where UserName=@UserName");

            con.Open();



            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@ContactName", txtName.Text);
            cmd.Parameters.AddWithValue("@CityId", comboCity.SelectedIndex);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);
            cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Başarıyla Güncellendi.");

            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           DialogResult dialog= MessageBox.Show("Hesabınızı silmek istediğinize emin misiniz?","Uyarı",MessageBoxButtons.YesNo);
           if (dialog == DialogResult.Yes)


           {
               string UName = "";

               string command = "select UserName from Tbl_Log";

               SqlCommand cmd2 = new SqlCommand(command, con2);
               con2.Open();
               SqlDataReader dr1 = cmd2.ExecuteReader();
               if (dr1.Read())
               {
                   UName = dr1["UserName"].ToString();

               }
               con.Close();

               SqlCommand cmd3 = new SqlCommand("Delete from  Tbl_Log  where UserName=@UserName");
               con2.Open();
               cmd3.Connection = con2;
               cmd3.Parameters.AddWithValue("@UserName", UName);
               SqlDataReader dr2 = cmd3.ExecuteReader();
               con.Close();




                con.Open();
               SqlCommand cmd =
                   new SqlCommand("Delete from  Tbl_Customer  where UserName=@UserName");
               SqlCommand cmd1 =
                   new SqlCommand("Delete from  Tbl_User  where UserName=@UserName");


               cmd1.Connection = con;
               cmd.Connection = con;
               cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
               cmd1.Parameters.AddWithValue("@UserName", txtUserName.Text);
               cmd.ExecuteNonQuery();
               cmd1.ExecuteNonQuery();
               con.Close();
               txtName.Text = "";
               comboCity.Text = "";
               txtUserName.Text = "";
               txtAddress.Text = "";
               txtPhone.Text = "";

               MessageBox.Show("Kullanıcı başarıyla silindi");
               LoginPage lp = new LoginPage();
               lp.Show();
               this.Dispose();
            }
           
        else if (dialog == DialogResult.No)
           {

           }

        }

        private void button1_Click(object sender, EventArgs e)
        {
         

        }
    }
}
