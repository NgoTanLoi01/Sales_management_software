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

namespace project_quanlybanhang
{
    public partial class fLogin : Form
    {
        

        public fLogin()
        {
            InitializeComponent();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }
         
        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
             

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.button1.BackColor = Color.Transparent;
            //SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-KNCJTSN8;Initial Catalog=QUANLY_CUAHANGMAYTINH;Integrated Security=True");
            //try
            //{
            //    conn.Open();
            //    string tk = txtuser.Text;
            //    string mk = txtpass.Text;
            //    string sql = "select *from TAIKHOAN where TenTaiKhoan = '" + tk + "'and MatKhau= '" + mk + "'";
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    SqlDataReader dta = cmd.ExecuteReader();
            //    if (dta.Read() == true)
            //    {
            //        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        fTableManager f = new fTableManager(tk);
            //        f.ShowDialog();
            //        this.Hide();
            //        this.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi kết nối!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
                if (txtuser.Text == "admin" && txtpass.Text == "123")
                {
                    fTableManager f = new fTableManager(txtuser.Text);
                    f.Show();

                }
                else if (txtuser.Text == "nhanvien" && txtpass.Text == "123")
                {
                    fTableManager f = new fTableManager(txtuser.Text);
                    f.Show();

                }
                else
                {
                MessageBox.Show("Đăng nhập thất bại!!!");
            }
            //this.button1.BackColor = Color.Transparent;
            //SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-KNCJTSN8;Initial Catalog=QUANLY_CUAHANGMAYTINH;Integrated Security=True");
            //try
            //{
            //    conn.Open();
            //    string tk = txtuser.Text;
            //    string mk = txtpass.Text;
            //    string sql = "select *from TAIKHOAN where TenTaiKhoan = '" + tk + "'and MatKhau= '" + mk + "'";
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    SqlDataReader dta = cmd.ExecuteReader();
            //    if (dta.Read() == true)
            //    {
            //        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        fTableManager f = new fTableManager(tk);
            //        f.ShowDialog();
            //        this.Hide();
            //        this.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi kết nối!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
    }
}
