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
namespace bản_chính_thức
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
            settooltip();
        }
        private void settooltip()
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this.txtTenLogin,"Điền vào tên người dùng");
            tip.SetToolTip(this.txtMKLogin, "Điền vào mật khẩu không nên để trống");
            tip.SetToolTip(this.txtPhoneLogin,"Điền vào số điện thoại người dùng ");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
                
                string tk =txtTenLogin.Text;
                string mk = txtMKLogin.Text;
                string dt = txtPhoneLogin.Text;
              
                
                if (tk=="NganHao2000" && mk=="Thanhcattuhan" && dt=="01236927659")
                {
                    MessageBox.Show("Đăng nhập thành công ");
                    FSYSTEM f = new FSYSTEM();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }



        }
            

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn có muốn thoát hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (t == DialogResult.Yes)
               
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult p = MessageBox.Show("Bạn có muốn đăng xuất ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (p == DialogResult.Yes)

            {
                Form1 f = new Form1();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }
    }
}
