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
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
            
            
        }
        String username;
        public fTableManager( String s)
        {
            InitializeComponent();
            lbUsername.Text = s;
            username = s;

        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void fTableManager_Load(object sender, EventArgs e)
        {
            if(username == "nhanvien")
            {
                btn_fNhanvien.Hide();
                btn_fHoadonnhap.Hide();
                btn_fNhacungcap.Hide();
                btn_fBaohanh.Hide();
                btn_fThongke.Hide();
                button4.Hide();
            }
        }

        private void btn_fNhanvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fNhanvien());
            label1.Text = btn_fNhanvien.Text;
        }

        private void btn_fKhachhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fKhachhang());
            label1.Text = btn_fKhachhang.Text;
        }

        private void btn_fHoadonban_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fHoadonban());
            label1.Text = btn_fHoadonban.Text;
        }

        private void btn_fHoadonnhap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fHoadonnhap());
            label1.Text = btn_fHoadonnhap.Text;
        }

        private void btn_fNhacungcap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fMaytinh());
            label1.Text = btn_fNhacungcap.Text;
        }

        private void btn_fBaohanh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fBaohanh());
            label1.Text = btn_fBaohanh.Text;
        }

        private void btn_fThongke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fNhacungcap());
            label1.Text = btn_fThongke.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            label1.Text = "Trang Chủ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void lbUsername_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn đăng xuất tài khoản?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
                
        }

        private void fTableManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != System.Windows.Forms.DialogResult.OK)
            //{
            //    e.Cancel = true;
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fLoaimaytinh());
            label1.Text = button4.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
