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
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.VisualStyles;

namespace VeriTabanıMasaüstüProjesi
{
    public partial class ProductPage : Form
    {
       //like kullanmak için ürün arama kullan

        
        SqlConnection con = new SqlConnection("Data Source=MEHMET_EREN;Initial Catalog=Urun_DataBase_Project;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public int deger;
        public int toplam = 0;
        public int sayac = 0;
        public string pName="";
        public int uPrice;
  
     
        public ProductPage()
        {
            InitializeComponent();
        }

        private void ProductPage_Load(object sender, EventArgs e)
        {
            btnSendToCart.BringToFront();
            btnCart.BringToFront();
            lblToplam.BringToFront();
            pb1.BringToFront();
            Descrease1.BringToFront();
            Increase1.BringToFront();
            label1.BringToFront();
            lblAmount.BringToFront();
            lblToplam.BringToFront();
            lblinfo.BringToFront();
            SqlConnection con = new SqlConnection("Data Source=MEHMET_EREN;Initial Catalog=Urun_DataBase_Project;Integrated Security=True");
            SqlDataAdapter da1, da2, da3, da4, da5, da6;
            DataTable ds1, ds2, ds3, ds4, ds5, ds6;
            dataGridView1.ReadOnly = true;


          
            pb1.BackColor=Color.White;
            





            string sqlCommand1 = "select ProductName,UnitPrice,ProductImg from Tbl_Product where CategoryId=1";
            da1 = new SqlDataAdapter(sqlCommand1, con);
            string sqlCommand2 = "select ProductName,UnitPrice,ProductImg from Tbl_Product where CategoryId=2";
            da2 = new SqlDataAdapter(sqlCommand2, con);
            string sqlCommand3 = "select ProductName,UnitPrice,ProductImg from Tbl_Product where CategoryId=3";
            da3 = new SqlDataAdapter(sqlCommand3, con);
            string sqlCommand4 = "select ProductName,UnitPrice,ProductImg from Tbl_Product where CategoryId=4";
            da4 = new SqlDataAdapter(sqlCommand4, con);
            string sqlCommand5 = "select ProductName,UnitPrice,ProductImg from Tbl_Product where CategoryId=5";
            da5 = new SqlDataAdapter(sqlCommand5, con);
            string sqlCommand6 = "select ProductName,UnitPrice,ProductImg from Tbl_Product where CategoryId=6";
            con.Open();
            da6 = new SqlDataAdapter(sqlCommand6, con);
            ds1 = new DataTable();
            ds2 = new DataTable();
            ds3 = new DataTable();
            ds4 = new DataTable();
            ds5 = new DataTable();
            ds6 = new DataTable();



            da1.Fill(ds1);
            da2.Fill(ds2);
            da3.Fill(ds3);
            da4.Fill(ds4);
            da5.Fill(ds5);
            da6.Fill(ds6);


            dataGridView1.DataSource = ds1;
            dataGridView2.DataSource = ds2;
            dataGridView3.DataSource = ds3;
            dataGridView4.DataSource = ds4;
            dataGridView5.DataSource = ds5;
            dataGridView6.DataSource = ds6;
            con.Close();

        }

        

        private void button97_Click(object sender, EventArgs e)
        {
            ShopPage sp = new ShopPage();
            sp.Show();
            this.Hide();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            pb1.ImageLocation = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
           
            deger = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[1].Value);

             pName= dataGridView1.Rows[secilen].Cells[0].Value.ToString(); ;
             uPrice = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[1].Value);

            

        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            pb1.ImageLocation = dataGridView2.Rows[secilen].Cells[2].Value.ToString();

            deger = Convert.ToInt32(dataGridView2.Rows[secilen].Cells[1].Value);
            pName = dataGridView2.Rows[secilen].Cells[0].Value.ToString(); ;
            uPrice = Convert.ToInt32(dataGridView2.Rows[secilen].Cells[1].Value);

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView3.SelectedCells[0].RowIndex;
            pb1.ImageLocation = dataGridView3.Rows[secilen].Cells[2].Value.ToString();

            deger = Convert.ToInt32(dataGridView3.Rows[secilen].Cells[1].Value);
            pName = dataGridView3.Rows[secilen].Cells[0].Value.ToString(); ;
            uPrice = Convert.ToInt32(dataGridView3.Rows[secilen].Cells[1].Value);

        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView4.SelectedCells[0].RowIndex;
            pb1.ImageLocation = dataGridView4.Rows[secilen].Cells[2].Value.ToString();

            deger = Convert.ToInt32(dataGridView4.Rows[secilen].Cells[1].Value);
            pName = dataGridView4.Rows[secilen].Cells[0].Value.ToString(); ;
            uPrice = Convert.ToInt32(dataGridView4.Rows[secilen].Cells[1].Value);

        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView5.SelectedCells[0].RowIndex;
            pb1.ImageLocation = dataGridView5.Rows[secilen].Cells[2].Value.ToString();

            deger = Convert.ToInt32(dataGridView5.Rows[secilen].Cells[1].Value);
            pName = dataGridView5.Rows[secilen].Cells[0].Value.ToString(); ;
            uPrice = Convert.ToInt32(dataGridView5.Rows[secilen].Cells[1].Value);

        }

        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView6.SelectedCells[0].RowIndex;
            pb1.ImageLocation = dataGridView6.Rows[secilen].Cells[2].Value.ToString();

            deger = Convert.ToInt32(dataGridView6.Rows[secilen].Cells[1].Value);
            pName = dataGridView6.Rows[secilen].Cells[0].Value.ToString(); ;
            uPrice = Convert.ToInt32(dataGridView6.Rows[secilen].Cells[1].Value);
        }
        private void Increase(object sender, EventArgs e)
        {
            if (sayac > 0) Descrease1.Enabled = true;
            toplam += deger;
            lblToplam.Text = toplam.ToString();
            sayac++;
            lblAmount.Text = sayac.ToString();

        }
        private void Descrease(object sender, EventArgs e)
        {
            sayac--;
            if (sayac <= 0) Descrease1.Enabled = false;

            if (sayac >= 0)
            {
                lblAmount.Text = sayac.ToString();
                toplam -= deger;
            }

            if (toplam < 0)
            {
                toplam = 0;
            }

            lblToplam.Text = toplam.ToString();
            

        }
     


        private void SelectionChanged(object sender, EventArgs e)
        {
            lblAmount.Text = "0";
            sayac = 0;
        }



        private void btnCart_Click(object sender, EventArgs e)
        {
            CartPage cp = new CartPage();
            cp.Show();
            this.Dispose();
        }

        private void btnSendToCart_Click(object sender, EventArgs e)
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

            SqlCommand cmd = new SqlCommand("Insert into Tbl_Cart (UserName,ProductName,ProductPrice,Amount) values(@UserName,@ProductName,@ProductPrice,@Amount)");

            con.Open();

            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@UserName", UName);
            cmd.Parameters.AddWithValue("@ProductName", pName);
            cmd.Parameters.AddWithValue("@ProductPrice", uPrice);
            cmd.Parameters.AddWithValue("@Amount", lblAmount.Text);

            cmd.ExecuteNonQuery();

            con.Close();



        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}



