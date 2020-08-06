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
    public partial class FKEEPER : Form
    {
        SqlConnection lienket = new SqlConnection(@"Data Source=DESKTOP-GHOBMIR\SQLEXPRESS;Initial Catalog=QLSP;Integrated Security=True");
        public FKEEPER()
        {
            InitializeComponent();
                HienThi(); 

        }
        void HienThi()
        {
            lienket.Open();
            SqlCommand cmd = new SqlCommand("select * from GoalKeeper ", lienket);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgm.DataSource = dt;
            lienket.Close();
        }
        private void FKEEPER_Load(object sender, EventArgs e)
        {

        }

        private void PHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                PHinh.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void dgm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgm.CurrentCell.RowIndex;
            txtTenSP.Text = dgm.Rows[i].Cells[0].Value.ToString();
            txtMaSP.Text = dgm.Rows[i].Cells[1].Value.ToString();
            cbGia.Text = dgm.Rows[i].Cells[2].Value.ToString();
            nbmInt.Text = dgm.Rows[i].Cells[3].Value.ToString();
            byte[] b = (byte[])dgm.Rows[i].Cells[4].Value;
            PHinh.Image = ByteArrayToImage(b);
        }
        Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            byte[] b = PathToByteArray(this.Text);
            lienket.Open();
            SqlCommand cmd = new SqlCommand("insert into GoalKeeper values(@TenSanPham,@MaSanPham,@Gia,@SoLuong,@Hinh) ", lienket);
            cmd.Parameters.Add("TenSanPham", txtTenSP.Text);
            cmd.Parameters.Add("MaSanPham", txtMaSP.Text);
            cmd.Parameters.Add("Gia", cbGia.Text);
            cmd.Parameters.Add("SoLuong", nbmInt.Text);
            cmd.Parameters.Add("Hinh", b);
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
    }
}
