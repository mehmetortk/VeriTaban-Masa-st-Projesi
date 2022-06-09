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
    public partial class CartPage : Form
    {
        
        SqlConnection conn = new SqlConnection("Data Source=MEHMET_EREN;Initial Catalog=Urun_DataBase_Project;Integrated Security=True");
        private SqlCommand cmd;
        private SqlDataAdapter da;
        public CartPage()
        {
            InitializeComponent();
        }

        private void CartPage_Load(object sender, EventArgs e)
        {
            //kullanıcıya göre db işlemi
            string UName = "";

            string command3 = "select UserName from Tbl_Log";

            SqlCommand cmd1 = new SqlCommand(command3, conn);
            conn.Open();
            SqlDataReader dr3 = cmd1.ExecuteReader();
            if (dr3.Read())
            {
                UName = dr3["UserName"].ToString();

            }
            conn.Close();


            int toplam=0;
            string query = "select ProductName, ProductPrice,Amount from Tbl_Cart where UserName='"+ UName + "'";
            DataSet ds = new DataSet();

            conn.Open();
            da = new SqlDataAdapter(query, conn);
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            conn.Close();




            string query1 = "select ProductName, ProductPrice,Amount from Tbl_Cart  where UserName='" + UName + "'";
            cmd = new SqlCommand(query1, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string tutar = dr["ProductPrice"].ToString();
                string miktar = dr["Amount"].ToString();
                toplam += (Convert.ToInt32(tutar) * Convert.ToInt32(miktar));
            }
            conn.Close();
            lbldeger.Text = toplam.ToString();

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button97_Click(object sender, EventArgs e)
        {
            ShopPage sp = new ShopPage();
            sp.Show();
            this.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            string secili = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            SqlCommand sc = new SqlCommand("delete from Tbl_Cart where ProductName = @sec", conn);
            sc.Parameters.Add("@sec", secili);
            sc.ExecuteNonQuery();

            MessageBox.Show("Başarıyla silindi.");

        }

        private void btnPay_Click(object sender, EventArgs e)
        {


            int toplam = 0;
            string query1 = "select ProductName, ProductPrice,Amount from Tbl_Cart";
            cmd = new SqlCommand(query1, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string tutar = dr["ProductPrice"].ToString();
                string miktar = dr["Amount"].ToString();
                toplam += (Convert.ToInt32(tutar) * Convert.ToInt32(miktar));
            }
            conn.Close();


            
            DateTime tarih = DateTime.Now.Date;
            string UName = "";

            string command3 = "select UserName from Tbl_Log";

            SqlCommand cmd1 = new SqlCommand(command3, conn);
            conn.Open();
            SqlDataReader dr3 = cmd1.ExecuteReader();
            if (dr3.Read())
            {
                UName = dr3["UserName"].ToString();

            }
            conn.Close();

            conn.Open();
            SqlCommand sc = new SqlCommand("insert into Tbl_Orders  (UserName,Sum,Date)  values (@UserName,@Sum,@Date) ", conn);
            sc.Parameters.AddWithValue("@UserName", UName);
            sc.Parameters.AddWithValue("@Sum",toplam );
            sc.Parameters.AddWithValue("@Date", tarih);

            sc.ExecuteNonQuery();
            conn.Close();
                MessageBox.Show("Başarıyla Ödendi.");






                conn.Open();
                SqlCommand sc5 = new SqlCommand("delete from Tbl_Cart where UserName=@UserName", conn);
                sc5.Parameters.AddWithValue("@UserName", UName);
                sc5.ExecuteNonQuery();
                conn.Close();
          














        }
    }
}
