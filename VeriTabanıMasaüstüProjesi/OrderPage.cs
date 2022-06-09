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
    public partial class OrderPage : Form
    {
        SqlConnection con = new SqlConnection("Data Source=MEHMET_EREN;Initial Catalog=Urun_DataBase_Project;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        DataTable dt;
        public OrderPage()
        {
            InitializeComponent();
        }

       

        private void button97_Click(object sender, EventArgs e)
        {
            ShopPage sp = new ShopPage();
            sp.Show();
            this.Dispose();
        }

        private void OrderPage_Load(object sender, EventArgs e)
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

            dataGridView1.ReadOnly = true;
            string sqlCommand1 = "select orderId,Sum,Date from Tbl_Orders where UserName='"+ UName + "'";
            da = new SqlDataAdapter(sqlCommand1, con);
            con.Open();
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }
    }
}
