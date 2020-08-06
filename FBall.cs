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
using System.IO;
namespace bản_chính_thức
{
    public partial class FBall : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GHOBMIR\SQLEXPRESS;Initial Catalog=QLSP;Integrated Security=True");
        public FBall()
        {
            InitializeComponent();
            loadata();
        }
        void loadata()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from HinhBanh", con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv.DataSource = dt;
            con.Close();


        }
        private void FBall_Load(object sender, EventArgs e)
        {

        }

        private void pHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pHinh.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            byte[] b = PathToByteArray(this.Text);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into HinhBanh values(@TenSanPham,@Gia,@MaSanPham,@SoLuong,@Hinh) ", con);
            cmd.Parameters.Add("TenSanPham",txtTen.Text);
            cmd.Parameters.Add("Gia", cbmGia.Text);
            cmd.Parameters.Add("MaSanPham",txtMsp.Text);
            cmd.Parameters.Add("SoLuong",nbmball.Text);
            cmd.Parameters.Add("Hinh",b);
            cmd.ExecuteNonQuery();
            con.Close();
            loadata();
        }
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        byte[] PathToByteArray(string path)
        {
            //MemoryStream m = new MemoryStream();
            // Image img = Image.FromFile(path);
            //img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            //return m.ToArray();
            return File.ReadAllBytes(path);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv.CurrentCell.RowIndex;
            txtTen.Text = dgv.Rows[i].Cells[0].Value.ToString();
            cbmGia.Text = dgv.Rows[i].Cells[1].Value.ToString();
            txtMsp.Text = dgv.Rows[i].Cells[2].Value.ToString();
            nbmball.Text = dgv.Rows[i].Cells[3].Value.ToString();
            byte[] b = (byte[])dgv.Rows[i].Cells[4].Value;
            pHinh.Image = ByteArrayToImage(b);
        }
        Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
