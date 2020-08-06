using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bản_chính_thức
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gìayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FGIAY f = new FGIAY();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void găngTayThủMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FKEEPER r = new FKEEPER();
            this.Hide();
            r.ShowDialog();
            this.Show();
        }

        private void banhBóngĐaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FBall f = new FBall();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void áOThểThaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSCOCCER g = new FSCOCCER();
            this.Hide();
            g.ShowDialog();
            this.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            FPHA f = new FPHA();
            this.Hide();
            f.ShowDialog();
            this.Show();


        }

        private void oolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
