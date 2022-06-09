namespace VeriTabanıMasaüstüProjesi
{
    partial class ShopPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopPage));
            this.btnHesap = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnBasket = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSession = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHesap
            // 
            this.btnHesap.BackColor = System.Drawing.Color.PowderBlue;
            this.btnHesap.FlatAppearance.BorderSize = 0;
            this.btnHesap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesap.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHesap.Location = new System.Drawing.Point(12, 272);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(95, 54);
            this.btnHesap.TabIndex = 0;
            this.btnHesap.Text = "Hesap Bilgileri";
            this.btnHesap.UseVisualStyleBackColor = false;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(62, 28);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(22, 31);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = " ";
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.PowderBlue;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrders.Location = new System.Drawing.Point(336, 272);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(85, 54);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "Siparişlerim";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.Color.PowderBlue;
            this.btnShop.FlatAppearance.BorderSize = 0;
            this.btnShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShop.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShop.Location = new System.Drawing.Point(123, 272);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(94, 54);
            this.btnShop.TabIndex = 3;
            this.btnShop.Text = "Alışveriş";
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnBasket
            // 
            this.btnBasket.BackColor = System.Drawing.Color.PowderBlue;
            this.btnBasket.FlatAppearance.BorderSize = 0;
            this.btnBasket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasket.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBasket.Location = new System.Drawing.Point(234, 272);
            this.btnBasket.Name = "btnBasket";
            this.btnBasket.Size = new System.Drawing.Size(87, 54);
            this.btnBasket.TabIndex = 4;
            this.btnBasket.Text = "Sepet";
            this.btnBasket.UseVisualStyleBackColor = false;
            this.btnBasket.Click += new System.EventHandler(this.btnBasket_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Location = new System.Drawing.Point(459, 28);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(56, 13);
            this.lblSession.TabIndex = 5;
            this.lblSession.Text = "Oturum= 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.pictureBox1.Image = global::VeriTabanıMasaüstüProjesi.Properties.Resources.logo3;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(527, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Salmon;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(440, 272);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 54);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Kullanıcı Çıkış";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // ShopPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(527, 367);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.btnBasket);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnHesap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShopPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JustBring";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Shopping_FormClosing);
            this.Load += new System.EventHandler(this.Shopping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnBasket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
    }
}