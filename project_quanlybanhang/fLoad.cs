using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_quanlybanhang
{
    public partial class fLoad : Form
    {
        public fLoad()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Hide();
            fLogin form = new fLogin();
            form.ShowDialog();
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void giaodien_Load(object sender, EventArgs e)
        {

        }
    }
}
