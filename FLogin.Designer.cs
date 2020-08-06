namespace bản_chính_thức
{
    partial class FLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtPhoneLogin = new System.Windows.Forms.TextBox();
            this.txtMKLogin = new System.Windows.Forms.TextBox();
            this.txtTenLogin = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLgoin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật Khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox1.Controls.Add(this.btnDangXuat);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.txtPhoneLogin);
            this.groupBox1.Controls.Add(this.txtMKLogin);
            this.groupBox1.Controls.Add(this.txtTenLogin);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnLgoin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 392);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng Nhập";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(238, 193);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(137, 23);
            this.btnDangXuat.TabIndex = 10;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(248, 170);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Xác nhận đăng nhập";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtPhoneLogin
            // 
            this.txtPhoneLogin.Location = new System.Drawing.Point(222, 132);
            this.txtPhoneLogin.Name = "txtPhoneLogin";
            this.txtPhoneLogin.Size = new System.Drawing.Size(175, 20);
            this.txtPhoneLogin.TabIndex = 8;
            // 
            // txtMKLogin
            // 
            this.txtMKLogin.Location = new System.Drawing.Point(222, 92);
            this.txtMKLogin.Name = "txtMKLogin";
            this.txtMKLogin.Size = new System.Drawing.Size(223, 20);
            this.txtMKLogin.TabIndex = 7;
            this.txtMKLogin.UseSystemPasswordChar = true;
            // 
            // txtTenLogin
            // 
            this.txtTenLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLogin.Location = new System.Drawing.Point(222, 45);
            this.txtTenLogin.Name = "txtTenLogin";
            this.txtTenLogin.Size = new System.Drawing.Size(223, 21);
            this.txtTenLogin.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.GhostWhite;
            this.button2.Image = global::bản_chính_thức.Properties.Resources.logout__1_;
            this.button2.Location = new System.Drawing.Point(323, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Thoát";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLgoin
            // 
            this.btnLgoin.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLgoin.Image = global::bản_chính_thức.Properties.Resources.login__3_;
            this.btnLgoin.Location = new System.Drawing.Point(190, 233);
            this.btnLgoin.Name = "btnLgoin";
            this.btnLgoin.Size = new System.Drawing.Size(87, 36);
            this.btnLgoin.TabIndex = 3;
            this.btnLgoin.Text = "Đăng Nhập";
            this.btnLgoin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLgoin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLgoin.UseVisualStyleBackColor = false;
            this.btnLgoin.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại:";
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 403);
            this.Controls.Add(this.groupBox1);
            this.Name = "FLogin";
            this.Text = "FLogin";
            this.Load += new System.EventHandler(this.FLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPhoneLogin;
        private System.Windows.Forms.TextBox txtMKLogin;
        private System.Windows.Forms.TextBox txtTenLogin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLgoin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnDangXuat;
    }
}