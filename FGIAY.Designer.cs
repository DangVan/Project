namespace bản_chính_thức
{
    partial class FGIAY
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtT = new System.Windows.Forms.TextBox();
            this.cbmG = new System.Windows.Forms.ComboBox();
            this.txtMS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.pH = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nbmgiay = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbmgiay)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 247);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtT
            // 
            this.txtT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT.Location = new System.Drawing.Point(277, 23);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(164, 22);
            this.txtT.TabIndex = 6;
            // 
            // cbmG
            // 
            this.cbmG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmG.FormattingEnabled = true;
            this.cbmG.Location = new System.Drawing.Point(277, 58);
            this.cbmG.Name = "cbmG";
            this.cbmG.Size = new System.Drawing.Size(121, 23);
            this.cbmG.TabIndex = 7;
            // 
            // txtMS
            // 
            this.txtMS.Location = new System.Drawing.Point(277, 98);
            this.txtMS.Name = "txtMS";
            this.txtMS.Size = new System.Drawing.Size(84, 20);
            this.txtMS.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên Sản phẫm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã Sản Phẫm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Gía:";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLuu.Image = global::bản_chính_thức.Properties.Resources.btnLuu1;
            this.btnLuu.Location = new System.Drawing.Point(403, 146);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(68, 52);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // pH
            // 
            this.pH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pH.Location = new System.Drawing.Point(12, 12);
            this.pH.Name = "pH";
            this.pH.Size = new System.Drawing.Size(173, 184);
            this.pH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pH.TabIndex = 4;
            this.pH.TabStop = false;
            this.pH.Click += new System.EventHandler(this.pHinh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Số Lượng :";
            // 
            // nbmgiay
            // 
            this.nbmgiay.Location = new System.Drawing.Point(277, 130);
            this.nbmgiay.Name = "nbmgiay";
            this.nbmgiay.Size = new System.Drawing.Size(50, 20);
            this.nbmgiay.TabIndex = 14;
            // 
            // FGIAY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(478, 463);
            this.Controls.Add(this.nbmgiay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMS);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbmG);
            this.Controls.Add(this.txtT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pH);
            this.Name = "FGIAY";
            this.Text = "FGIAY";
            this.Load += new System.EventHandler(this.FGIAY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbmgiay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pH;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.ComboBox cbmG;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtMS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nbmgiay;
    }
}