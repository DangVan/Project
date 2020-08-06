namespace bản_chính_thức
{
    partial class FKEEPER
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
            this.dgm = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nbmInt = new System.Windows.Forms.NumericUpDown();
            this.cbGia = new System.Windows.Forms.ComboBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.PHinh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbmInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgm
            // 
            this.dgm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgm.Location = new System.Drawing.Point(12, 177);
            this.dgm.Name = "dgm";
            this.dgm.Size = new System.Drawing.Size(397, 164);
            this.dgm.TabIndex = 1;
            this.dgm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgm_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên Sản Phẫm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Sản Phẫm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số Lượng:";
            // 
            // nbmInt
            // 
            this.nbmInt.Location = new System.Drawing.Point(269, 124);
            this.nbmInt.Name = "nbmInt";
            this.nbmInt.Size = new System.Drawing.Size(49, 20);
            this.nbmInt.TabIndex = 7;
            // 
            // cbGia
            // 
            this.cbGia.FormattingEnabled = true;
            this.cbGia.Location = new System.Drawing.Point(269, 86);
            this.cbGia.Name = "cbGia";
            this.cbGia.Size = new System.Drawing.Size(94, 21);
            this.cbGia.TabIndex = 8;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(269, 44);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(80, 20);
            this.txtMaSP.TabIndex = 9;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(269, 9);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(190, 20);
            this.txtTenSP.TabIndex = 10;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.BurlyWood;
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnLuu.Image = global::bản_chính_thức.Properties.Resources.btnLuu1;
            this.btnLuu.Location = new System.Drawing.Point(395, 128);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(72, 43);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // PHinh
            // 
            this.PHinh.BackColor = System.Drawing.Color.CadetBlue;
            this.PHinh.Location = new System.Drawing.Point(12, 12);
            this.PHinh.Name = "PHinh";
            this.PHinh.Size = new System.Drawing.Size(164, 159);
            this.PHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PHinh.TabIndex = 0;
            this.PHinh.TabStop = false;
            this.PHinh.Click += new System.EventHandler(this.PHinh_Click);
            // 
            // FKEEPER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(479, 346);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.cbGia);
            this.Controls.Add(this.nbmInt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgm);
            this.Controls.Add(this.PHinh);
            this.Name = "FKEEPER";
            this.Text = "FKEEPER";
            this.Load += new System.EventHandler(this.FKEEPER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbmInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PHinh;
        private System.Windows.Forms.DataGridView dgm;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nbmInt;
        private System.Windows.Forms.ComboBox cbGia;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
    }
}