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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
          
        }
        SqlConnection l;
        private void dgy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int u;
            u = dgy.CurrentRow.Index;
            txtHĐ.Text = dgy.Rows[u].Cells[0].Value.ToString();
            txtMaSP.Text= dgy.Rows[u].Cells[1].Value.ToString();
            cbMK.Text=dgy.Rows[u].Cells[2].Value.ToString();
            txtTien.Text=dgy.Rows[u].Cells[3].Value.ToString();

        }
        public void Thi()
        {
            string s = "select * from HD ";
            SqlCommand cd = new SqlCommand(s,l);
            SqlDataReader d = cd.ExecuteReader();
            DataTable b = new DataTable();
            b.Load(d);
            dgy.DataSource = b;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            l = new SqlConnection(@"Data Source=DESKTOP-GHOBMIR\SQLEXPRESS;Initial Catalog=ThanhToan;Integrated Security=True");
            l.Open();
            Thi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string st = "insert into  HD values(@MãSảnPhẫm,@MãHóaĐơn,@MãKháchHàng,@ThànhTiền)";
            SqlCommand cd = new SqlCommand(st, l);
            cd.Parameters.AddWithValue("MãSảnPhẫm", txtHĐ.Text);
            cd.Parameters.AddWithValue("MãHóaĐơn", txtMaSP.Text);
            cd.Parameters.AddWithValue("MãKháchHàng", cbMK.Text);
            cd.Parameters.AddWithValue("ThànhTiền", txtTien.Text);
            cd.ExecuteNonQuery();
           Thi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sT = "UPDATE  HD SET MãSảnPhẫm=@MãSảnPhẫm,MãKháchHàng=@MãKháchHàng,ThànhTiền=@ThànhTiền WHERE  MãHóaĐơn =@MãHóaĐơn ";
            SqlCommand cd = new SqlCommand(sT, l);
            cd.Parameters.AddWithValue("MãSảnPhẫm", txtHĐ.Text);
            cd.Parameters.AddWithValue("MãHóaĐơn", txtMaSP.Text);
            cd.Parameters.AddWithValue("MãKháchHàng", cbMK.Text);
            cd.Parameters.AddWithValue("ThànhTiền", txtTien.Text);
            cd.ExecuteNonQuery();
            Thi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sX = "DELETE FROM HD WHERE MãSảnPhẫm =@MãSảnPhẫm ";
            SqlCommand cd = new SqlCommand(sX, l);
            cd.Parameters.AddWithValue("MãSảnPhẫm", txtHĐ.Text);
            cd.Parameters.AddWithValue("MãHóaĐơn",txtMaSP.Text);
            cd.Parameters.AddWithValue("MãKháchHàng", cbMK.Text);
            cd.Parameters.AddWithValue("ThànhTiền", txtTien.Text);
            cd.ExecuteNonQuery();
            Thi();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
