namespace VeriTabanıMasaüstüProjesi
{
    partial class RegisterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPasswordRepeat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKayıtOl = new System.Windows.Forms.Button();
            this.lblSifreUyusmazlik = new System.Windows.Forms.Label();
            this.lblDogrula = new System.Windows.Forms.Label();
            this.lblUyari = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.button97 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.pictureBox1.Image = global::VeriTabanıMasaüstüProjesi.Properties.Resources.logo3;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(30, 186);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(204, 29);
            this.txtUserName.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(30, 239);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(204, 32);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtPasswordRepeat
            // 
            this.txtPasswordRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordRepeat.Location = new System.Drawing.Point(26, 300);
            this.txtPasswordRepeat.Multiline = true;
            this.txtPasswordRepeat.Name = "txtPasswordRepeat";
            this.txtPasswordRepeat.Size = new System.Drawing.Size(208, 32);
            this.txtPasswordRepeat.TabIndex = 10;
            this.txtPasswordRepeat.TextChanged += new System.EventHandler(this.txtPasswordRepeat_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(27, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(27, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(27, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Şifre Tekrar";
            // 
            // btnKayıtOl
            // 
            this.btnKayıtOl.BackColor = System.Drawing.Color.PowderBlue;
            this.btnKayıtOl.FlatAppearance.BorderSize = 0;
            this.btnKayıtOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayıtOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKayıtOl.ForeColor = System.Drawing.Color.White;
            this.btnKayıtOl.Location = new System.Drawing.Point(83, 364);
            this.btnKayıtOl.Name = "btnKayıtOl";
            this.btnKayıtOl.Size = new System.Drawing.Size(97, 33);
            this.btnKayıtOl.TabIndex = 17;
            this.btnKayıtOl.Text = "Kayıt Ol";
            this.btnKayıtOl.UseVisualStyleBackColor = false;
            this.btnKayıtOl.Click += new System.EventHandler(this.btnKayıtOl_Click);
            // 
            // lblSifreUyusmazlik
            // 
            this.lblSifreUyusmazlik.AutoSize = true;
            this.lblSifreUyusmazlik.ForeColor = System.Drawing.Color.Red;
            this.lblSifreUyusmazlik.Location = new System.Drawing.Point(169, 335);
            this.lblSifreUyusmazlik.Name = "lblSifreUyusmazlik";
            this.lblSifreUyusmazlik.Size = new System.Drawing.Size(100, 13);
            this.lblSifreUyusmazlik.TabIndex = 18;
            this.lblSifreUyusmazlik.Text = "Şifreler Eşleşmiyor!!!";
            // 
            // lblDogrula
            // 
            this.lblDogrula.AutoSize = true;
            this.lblDogrula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogrula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDogrula.Location = new System.Drawing.Point(240, 308);
            this.lblDogrula.Name = "lblDogrula";
            this.lblDogrula.Size = new System.Drawing.Size(22, 24);
            this.lblDogrula.TabIndex = 19;
            this.lblDogrula.Text = "✓";
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.ForeColor = System.Drawing.Color.Red;
            this.lblUyari.Location = new System.Drawing.Point(18, 348);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(232, 13);
            this.lblUyari.TabIndex = 20;
            this.lblUyari.Text = "Kullanıcı Adı ve Şifre en az 8 karakter olmalıdır!!!";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Red;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuit.Location = new System.Drawing.Point(257, -2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(24, 23);
            this.btnQuit.TabIndex = 21;
            this.btnQuit.Text = "X";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // button97
            // 
            this.button97.BackColor = System.Drawing.Color.MediumPurple;
            this.button97.FlatAppearance.BorderSize = 0;
            this.button97.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button97.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button97.ForeColor = System.Drawing.Color.White;
            this.button97.Location = new System.Drawing.Point(-1, -2);
            this.button97.Name = "button97";
            this.button97.Size = new System.Drawing.Size(26, 23);
            this.button97.TabIndex = 22;
            this.button97.Text = "<---";
            this.button97.UseVisualStyleBackColor = false;
            this.button97.Click += new System.EventHandler(this.button97_Click);
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(281, 429);
            this.ControlBox = false;
            this.Controls.Add(this.button97);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblUyari);
            this.Controls.Add(this.lblDogrula);
            this.Controls.Add(this.lblSifreUyusmazlik);
            this.Controls.Add(this.btnKayıtOl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPasswordRepeat);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JustBring";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterPage_FormClosing);
            this.Load += new System.EventHandler(this.RegisterPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPasswordRepeat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKayıtOl;
        private System.Windows.Forms.Label lblSifreUyusmazlik;
        private System.Windows.Forms.Label lblDogrula;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button button97;
    }
}