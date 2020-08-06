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
    public partial class FPHA : Form
    {
        public FPHA()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            label1.Text = progressBar1.Value.ToString() + "%";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(label1.Text == "100%")
            
            {


                FLogin f = new FLogin();
                f.ShowDialog();
                this.Show();
                this.Hide();

            }
            else if (label1.Text != "100%")
             {
                MessageBox.Show("Hãy chờ tải xong ","caption",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            }
            
            
        }

        private void FPHA_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
