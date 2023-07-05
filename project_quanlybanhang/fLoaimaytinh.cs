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
    public partial class fLoaimaytinh : Form
    {
        Loaimaytinh loaimt;
        public fLoaimaytinh()
        {
            InitializeComponent();
            loaimt = new Loaimaytinh();
        }

        private void lOAIMAYTINHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOAIMAYTINHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qUANLY_CUAHANGMAYTINHDataSet);

        }

        private void fLoaimaytinh_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Mã loại";
            // TODO: This line of code loads data into the 'qUANLY_CUAHANGMAYTINHDataSet.LOAIMAYTINH' table. You can move, or remove it, as needed.
            this.lOAIMAYTINHTableAdapter.Fill(this.qUANLY_CUAHANGMAYTINHDataSet.LOAIMAYTINH);

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
            if (comboBox1.Text == "Mã loại")
            {
                lOAIMAYTINHDataGridView.DataSource = HienDL("select * from LOAIMAYTINH where Malmt like '%" + textBox1.Text.Trim() + "%'");
            }
            if (comboBox1.Text == "Tên loại")
            {
                lOAIMAYTINHDataGridView.DataSource = HienDL("select * from LOAIMAYTINH where Tenlmt like '%" + textBox1.Text.Trim() + "%'");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            maLMTTextBox.Text = "";
            tenLMTTextBox.Text = "";

        }
    }
}
