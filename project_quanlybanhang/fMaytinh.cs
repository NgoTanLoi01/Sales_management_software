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
    public partial class fMaytinh : Form
    {
        int TB;
        Thietbi thietbi;
        public fMaytinh()
        {
            thietbi = new Thietbi();
            InitializeComponent();
        }

        private void fMaytinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLY_CUAHANGMAYTINHDataSet3.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter1.Fill(this.qUANLY_CUAHANGMAYTINHDataSet3.NHACUNGCAP);
            // TODO: This line of code loads data into the 'qUANLY_CUAHANGMAYTINHDataSet3.LOAIMAYTINH' table. You can move, or remove it, as needed.
            this.lOAIMAYTINHTableAdapter1.Fill(this.qUANLY_CUAHANGMAYTINHDataSet3.LOAIMAYTINH);
            comboBox1.Text = "Mã thiết bị";
            // TODO: This line of code loads data into the 'qUANLY_CUAHANGMAYTINHDataSet2.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.qUANLY_CUAHANGMAYTINHDataSet2.NHACUNGCAP);
            // TODO: This line of code loads data into the 'qUANLY_CUAHANGMAYTINHDataSet2.LOAIMAYTINH' table. You can move, or remove it, as needed.
            this.lOAIMAYTINHTableAdapter.Fill(this.qUANLY_CUAHANGMAYTINHDataSet2.LOAIMAYTINH);
            // TODO: This line of code loads data into the 'qUANLY_CUAHANGMAYTINHDataSet2.MAYTINH' table. You can move, or remove it, as needed.
            this.mAYTINHTableAdapter.Fill(this.qUANLY_CUAHANGMAYTINHDataSet2.MAYTINH);


        }

        private void mAYTINHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mAYTINHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qUANLY_CUAHANGMAYTINHDataSet2);

        }
        private void mAYTINHBindingNavigatorSaveItem_Click1(object sender, EventArgs e)
        {
            this.Validate();
            this.mAYTINHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qUANLY_CUAHANGMAYTINHDataSet2);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            TB = TB + 1;
            maMTTextBox.Text = "TB" + TB.ToString();
        }

        private void hinhAnhPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                hinhAnhPictureBox.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void mAYTINHBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

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
            if (comboBox1.Text == "Mã thiết bị")
            {
                mAYTINHDataGridView.DataSource = HienDL("select * from MAYTINH where Mamt like '%" + textBox1.Text.Trim() + "%'");
            }
            if (comboBox1.Text == "Tên thiết bị")
            {
                mAYTINHDataGridView.DataSource = HienDL("select * from MAYTINH where Tenmt like '%" + textBox1.Text.Trim() + "%'");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            maMTTextBox.Text = "";
            tenMTTextBox.Text = "";
            tinhTrangMTComboBox.Text = "";
            thoiGianBaoHanhComboBox.Text = "";
            maLMTComboBox.Text = "";
            loaiThietBiCCComboBox.Text = "";
            maNCCComboBox.Text = "";
            nCCThietBiComboBox.Text = "";
            donViTinhTextBox.Text = "";
            giaMTTextBox.Text = "";
            soLuongMTTextBox.Text = "";
        }
    }
}
