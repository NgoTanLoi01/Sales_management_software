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
    public partial class fNhacungcap : Form
    {

        NhaCC nhacungcap;
        public fNhacungcap()
        {
            InitializeComponent();
            nhacungcap = new NhaCC();
        }


        private void nHACUNGCAPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void fNhacungcap_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Mã NCC";
            // TODO: This line of code loads data into the 'qUANLY_CUAHANGMAYTINHDataSet.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.qUANLY_CUAHANGMAYTINHDataSet.NHACUNGCAP);





        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void nHACUNGCAPBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            

        }

        private void nHACUNGCAPBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.nHACUNGCAPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qUANLY_CUAHANGMAYTINHDataSet);

        }
        public SqlConnection cn = new SqlConnection();
        public void Ketnoi()
        {
            try
            {
                if (cn.State == 0)
                {
                    cn.ConnectionString = "Data Source = LAPTOP-KNCJTSN8; Initial Catalog = QUANLY_CUAHANGMAYTINH; Integrated Security = True";
                    cn.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Ngatketnoi()
        {
            if (cn.State != 0)
            {
                cn.Close();
            }
        }
        public DataTable HienDL(string sql)
        {
            Ketnoi();
            Ngatketnoi();
            SqlDataAdapter adap = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Mã NCC")
            {
                nHACUNGCAPDataGridView.DataSource = HienDL("select * from NHACUNGCAP where Mancc like '%" + textBox1.Text.Trim() + "%'");
            }
            if (comboBox1.Text == "Tên NCC")
            {
                nHACUNGCAPDataGridView.DataSource = HienDL("select * from NHACUNGCAP where Tenncc like '%" + textBox1.Text.Trim() + "%'");
            }
        }

        private void huy_Click(object sender, EventArgs e)
        {
            maNCCTextBox.Text = "";
            tenNCCTextBox.Text = "";
            sDTNCCTextBox.Text = "";
            diaChiNCCTextBox.Text = "";
        }
    }
}
