namespace bản_chính_thức
{
    partial class FBall
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cbmGia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMsp = new System.Windows.Forms.TextBox();
            this.pHinh = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nbmball = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbmball)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::bản_chính_thức.Properties.Resources.btnLuu_Image;
            this.btnLuu.Location = new System.Drawing.Point(364, 134);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(65, 41);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Sản phẫm:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(282, 22);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(164, 20);
            this.txtTen.TabIndex = 2;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 181);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(434, 247);
            this.dgv.TabIndex = 4;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbmGia
            // 
            this.cbmGia.FormattingEnabled = true;
            this.cbmGia.Items.AddRange(new object[] {
            "100.000 -600.000 vnđ",
            "700.000 - 1.000.0000 vnđ"});
            this.cbmGia.Location = new System.Drawing.Point(282, 86);
            this.cbmGia.Name = "cbmGia";
            this.cbmGia.Size = new System.Drawing.Size(121, 21);
            this.cbmGia.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gía:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã Sản Phẫm:";
            // 
            // txtMsp
            // 
            this.txtMsp.Location = new System.Drawing.Point(282, 54);
            this.txtMsp.Name = "txtMsp";
            this.txtMsp.Size = new System.Drawing.Size(84, 20);
            this.txtMsp.TabIndex = 8;
            // 
            // pHinh
            // 
            this.pHinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pHinh.Location = new System.Drawing.Point(12, 12);
            this.pHinh.Name = "pHinh";
            this.pHinh.Size = new System.Drawing.Size(164, 163);
            this.pHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pHinh.TabIndex = 3;
            this.pHinh.TabStop = false;
            this.pHinh.Click += new System.EventHandler(this.pHinh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số Lượng:";
            // 
            // nbmball
            // 
            this.nbmball.Location = new System.Drawing.Point(282, 118);
            this.nbmball.Name = "nbmball";
            this.nbmball.Size = new System.Drawing.Size(47, 20);
            this.nbmball.TabIndex = 10;
            // 
            // FBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(452, 434);
            this.Controls.Add(this.nbmball);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMsp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbmGia);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pHinh);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLuu);
            this.Name = "FBall";
            this.Text = "FBall";
            this.Load += new System.EventHandler(this.FBall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbmball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.PictureBox pHinh;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cbmGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMsp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nbmball;
    }
}