namespace VeriTabanıMasaüstüProjesi
{
    partial class CartPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartPage));
            this.btnPay = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new VeriTabanıMasaüstüProjesi.Urun_DataBase_ProjectDataSetTableAdapters.TableAdapterManager();
            this.lbltop = new System.Windows.Forms.Label();
            this.lbldeger = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button97 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(240, 286);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Öde";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.Tbl_CategoryTableAdapter = null;
            this.tableAdapterManager1.Tbl_CustomerTableAdapter = null;
            this.tableAdapterManager1.Tbl_ProductTableAdapter = null;
            this.tableAdapterManager1.Tbl_SehirTableAdapter = null;
            this.tableAdapterManager1.Tbl_UserTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = VeriTabanıMasaüstüProjesi.Urun_DataBase_ProjectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lbltop
            // 
            this.lbltop.AutoSize = true;
            this.lbltop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltop.Location = new System.Drawing.Point(181, 267);
            this.lbltop.Name = "lbltop";
            this.lbltop.Size = new System.Drawing.Size(64, 16);
            this.lbltop.TabIndex = 1;
            this.lbltop.Text = "Toplam:";
            // 
            // lbldeger
            // 
            this.lbldeger.AutoSize = true;
            this.lbldeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeger.Location = new System.Drawing.Point(251, 267);
            this.lbldeger.Name = "lbldeger";
            this.lbldeger.Size = new System.Drawing.Size(15, 16);
            this.lbldeger.TabIndex = 2;
            this.lbldeger.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.GridColor = System.Drawing.Color.PowderBlue;
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 231);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ProductName";
            this.Column1.HeaderText = "Ürün Adı";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ProductPrice";
            this.Column2.HeaderText = "Ürün Fiyat";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Amount";
            this.Column3.HeaderText = "Ürün Adet";
            this.Column3.Name = "Column3";
            // 
            // button97
            // 
            this.button97.BackColor = System.Drawing.Color.MediumPurple;
            this.button97.FlatAppearance.BorderSize = 0;
            this.button97.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button97.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button97.ForeColor = System.Drawing.Color.White;
            this.button97.Location = new System.Drawing.Point(-2, 0);
            this.button97.Name = "button97";
            this.button97.Size = new System.Drawing.Size(26, 23);
            this.button97.TabIndex = 22;
            this.button97.Text = "<---";
            this.button97.UseVisualStyleBackColor = false;
            this.button97.Click += new System.EventHandler(this.button97_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(163, 286);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(61, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(471, 321);
            this.ControlBox = false;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button97);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbldeger);
            this.Controls.Add(this.lbltop);
            this.Controls.Add(this.btnPay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sepet";
            this.Load += new System.EventHandler(this.CartPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPay;
        private Urun_DataBase_ProjectDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.Label lbldeger;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button97;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnDelete;
    }
}