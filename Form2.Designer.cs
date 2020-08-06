namespace bản_chính_thức
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateSP = new System.Windows.Forms.DateTimePicker();
            this.cbMK = new System.Windows.Forms.ComboBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtHĐ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgy = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgy)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateSP);
            this.groupBox1.Controls.Add(this.cbMK);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.txtHĐ);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(6, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTien
            // 
            this.txtTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTien.Location = new System.Drawing.Point(457, 63);
            this.txtTien.Multiline = true;
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(146, 27);
            this.txtTien.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thành Tiền :";
            // 
            // dateSP
            // 
            this.dateSP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSP.Location = new System.Drawing.Point(430, 16);
            this.dateSP.Name = "dateSP";
            this.dateSP.Size = new System.Drawing.Size(200, 20);
            this.dateSP.TabIndex = 7;
            // 
            // cbMK
            // 
            this.cbMK.FormattingEnabled = true;
            this.cbMK.Location = new System.Drawing.Point(133, 74);
            this.cbMK.Name = "cbMK";
            this.cbMK.Size = new System.Drawing.Size(132, 21);
            this.cbMK.TabIndex = 6;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(133, 22);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(132, 20);
            this.txtMaSP.TabIndex = 5;
            // 
            // txtHĐ
            // 
            this.txtHĐ.Location = new System.Drawing.Point(133, 128);
            this.txtHĐ.Name = "txtHĐ";
            this.txtHĐ.Size = new System.Drawing.Size(132, 20);
            this.txtHĐ.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã Sản Phẫm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày lập :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Khách Hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgy);
            this.groupBox2.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox2.Location = new System.Drawing.Point(0, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 216);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // dgy
            // 
            this.dgy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgy.GridColor = System.Drawing.Color.Blue;
            this.dgy.Location = new System.Drawing.Point(6, 19);
            this.dgy.Name = "dgy";
            this.dgy.Size = new System.Drawing.Size(447, 191);
            this.dgy.TabIndex = 0;
            this.dgy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgy_CellContentClick);
            // 
            // button1
            // 
            this.button1.Image = global::bản_chính_thức.Properties.Resources.btnThem1;
            this.button1.Location = new System.Drawing.Point(6, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Image = global::bản_chính_thức.Properties.Resources.btnSua1;
            this.button3.Location = new System.Drawing.Point(112, 411);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = "Sửa";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Image = global::bản_chính_thức.Properties.Resources.btnXoa_Image;
            this.button4.Location = new System.Drawing.Point(211, 411);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 43);
            this.button4.TabIndex = 5;
            this.button4.Text = "Xóa ";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Image = global::bản_chính_thức.Properties.Resources.btnThoat_Image;
            this.button2.Location = new System.Drawing.Point(311, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Thoát ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(648, 466);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateSP;
        private System.Windows.Forms.ComboBox cbMK;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtHĐ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}