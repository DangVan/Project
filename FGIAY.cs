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
    public partial class FGIAY : Form
    {
        SqlConnection lienket = new SqlConnection(@"Data Source=DESKTOP-GHOBMIR\SQLEXPRESS;Initial Catalog=QLSP;Integrated Security=True");
        public FGIAY()
        {
            InitializeComponent();
            HienThi();
        }
        void HienThi()
        {
            lienket.Open();
            SqlCommand cmd = new SqlCommand("select * from CacLoai", lienket);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            lienket.Close();
        }
        private void FGIAY_Load(object sender, EventArgs e)
        {

        }

        private void pHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pH.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            byte[] b = PathToByteArray(this.Text);
            lienket.Open();
            SqlCommand cmd = new SqlCommand("insert into CacLoai values(@TenSanPham,@Gia,@MaSanPham,@SoLuong,@Hinh) ", lienket);
            cmd.Parameters.Add("TenSanPham", txtT.Text);
            cmd.Parameters.Add("Gia", cbmG.Text);
            cmd.Parameters.Add("MaSanPham", txtMS.Text);
            cmd.Parameters.Add("SoLuong",nbmgiay.Text);
            cmd.Parameters.Add("Hinh",b);
            cmd.ExecuteNonQuery();
            lienket.Close();
            HienThi();
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
            int i = dataGridView1.CurrentCell.RowIndex;
            txtT.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            cbmG.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtMS.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            nbmgiay.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            byte[] b = (byte[])dataGridView1.Rows[i].Cells[4].Value;
            pH.Image = ByteArrayToImage(b);
        }
        Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);

        }
    }
}
