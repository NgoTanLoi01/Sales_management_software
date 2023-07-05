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
    public partial class fHoadonban : Form
    {
        int HDB;
        Sanpham sanpham;
        public fHoadonban()
        {
            InitializeComponent();
            sanpham = new Sanpham();
        }

        

        private void fHoadonban_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLY_CUAHANGMAYTINHDataSet3.MAYTINH' table. You can move, or remove it, as needed.
            this.mAYTINHTableAdapter.Fill(this.qUANLY_CUAHANGMAYTINHDataSet3.MAYTINH);
            // TODO: This line of code loads data into the 'qUANLY_CUAHANGMAYTINHDataSet3.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qUANLY_CUAHANGMAYTINHDataSet3.KHACHHANG);
            // TODO: This line of code loads data into the 'qUANLY_CUAHANGMAYTINHDataSet3.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qUANLY_CUAHANGMAYTINHDataSet3.NHANVIEN);
            comboBox1.Text = "Sản phẩm";
            // TODO: This line of code loads data into the 'qUANLY_CUAHANGMAYTINHDataSet3.HOADONBANHANG' table. You can move, or remove it, as needed.
            this.hOADONBANHANGTableAdapter.Fill(this.qUANLY_CUAHANGMAYTINHDataSet3.HOADONBANHANG);

        }

        private void hOADONBANHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            this.Validate();
            this.hOADONBANHANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qUANLY_CUAHANGMAYTINHDataSet3);

            
        }

        private void tongTienBanLabel_Click(object sender, EventArgs e)
        {

        }

        private void maNVComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nhanVienBanHangComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ngayXuatHDBLabel_Click(object sender, EventArgs e)
        {

        }

        private void ngayXuatHDBDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maNVLabel_Click(object sender, EventArgs e)
        {

        }

        private void nhanVienBanHangLabel_Click(object sender, EventArgs e)
        {

        }

        private void maHDBLabel_Click(object sender, EventArgs e)
        {

        }

        private void maHDBTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void soLuongLinhKienTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tongTienBanTextBox.Text = (float.Parse(giaMTComboBox.Text) * float.Parse(soLuongLinhKienTextBox.Text)).ToString();
            }
            catch
            {

            }
        }

        private void hOADONBANHANGDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.hOADONBANHANGDataGridView.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txttongthanhtoan.Text = row.Cells[0].Value.ToString();
                txttongthanhtoan.Text = row.Cells[1].Value.ToString();
                txttongthanhtoan.Text = row.Cells[2].Value.ToString();
                txttongthanhtoan.Text = row.Cells[3].Value.ToString();
                

                //Không cho phép sửa trường STT
                txttongthanhtoan.Enabled = false;
            }
        }

        private void txttienkhachdua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtthoilaikhach.Text = (float.Parse(txttongthanhtoan.Text) - float.Parse(txttienkhachdua.Text)).ToString();
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Thanh toán thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txttienkhachdua.Text = "";
            txtthoilaikhach.Text = "";
            txttongthanhtoan.Text = "";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            DataColumn col1 = new DataColumn("LinhKien");
            DataColumn col2 = new DataColumn("SoLuongLinhKien");
            DataColumn col3 = new DataColumn("DonGiaLinhKien");
            DataColumn col4 = new DataColumn("TongTienBan");
            DataColumn col5 = new DataColumn("MaNV");
            DataColumn col6 = new DataColumn("MaKH");
            DataColumn col7 = new DataColumn("NgayXuatHDB");
            DataColumn col8 = new DataColumn("NhanVienBanHang");
            DataColumn col9 = new DataColumn("KhachHangMuaHang");
            DataColumn col10 = new DataColumn("SDT_KH");
            DataColumn col11 = new DataColumn("GioiTinhKH");
            DataColumn col12 = new DataColumn("DiaChiKH");
            DataColumn col13 = new DataColumn("MaHDB");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);
            dataTable.Columns.Add(col8);
            dataTable.Columns.Add(col9);
            dataTable.Columns.Add(col10);
            dataTable.Columns.Add(col11);
            dataTable.Columns.Add(col12);
            dataTable.Columns.Add(col13);

            foreach (DataGridViewRow dtgvRow in hOADONBANHANGDataGridView.Rows)
            {
                DataRow dtrow = dataTable.NewRow();
                dtrow[0] = dtgvRow.Cells[0].Value;
                dtrow[1] = dtgvRow.Cells[1].Value;
                dtrow[2] = dtgvRow.Cells[2].Value;
                dtrow[3] = dtgvRow.Cells[3].Value;
                dtrow[4] = dtgvRow.Cells[4].Value;
                dtrow[5] = dtgvRow.Cells[5].Value;
                dtrow[6] = dtgvRow.Cells[6].Value;
                dtrow[7] = dtgvRow.Cells[7].Value;
                dtrow[8] = dtgvRow.Cells[8].Value;
                dtrow[9] = dtgvRow.Cells[9].Value;
                dtrow[10] = dtgvRow.Cells[10].Value;
                dtrow[11] = dtgvRow.Cells[11].Value;
                dtrow[12] = dtgvRow.Cells[12].Value;

                dataTable.Rows.Add(dtrow);
            }
            ExportFile(dataTable, "Danh sach", "Danh sách bán hàng");
        }
        public void ExportFile(DataTable dataTable, string sheetName, string title)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "M1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Sản phẩm";

            cl1.ColumnWidth = 30;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Số lượng";

            cl2.ColumnWidth = 10.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Đơn giá";
            cl3.ColumnWidth = 15.5;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Thành tiền";

            cl4.ColumnWidth = 15.5;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Mã nhân viên";

            cl5.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "Mã khách hàng";

            cl6.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            cl7.Value2 = "Ngày xuất hóa đơn";

            cl7.ColumnWidth = 20.5;
            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");

            cl8.Value2 = "Tên nhân viên";

            cl8.ColumnWidth = 20.5;
            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");

            cl9.Value2 = "Tên khách hàng";

            cl9.ColumnWidth = 20.5;

            Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");

            cl10.Value2 = "SDT khách hàng";

            cl10.ColumnWidth = 20.5;
            Microsoft.Office.Interop.Excel.Range cl11 = oSheet.get_Range("K3", "K3");

            cl11.Value2 = "Giới tính";

            cl11.ColumnWidth = 10.5;
            Microsoft.Office.Interop.Excel.Range cl12 = oSheet.get_Range("L3", "L3");

            cl12.Value2 = "Địa chỉ";

            cl12.ColumnWidth = 20.5;
            Microsoft.Office.Interop.Excel.Range cl13 = oSheet.get_Range("M3", "M3");

            cl13.Value2 = "Mã hóa đơn";

            cl13.ColumnWidth = 10.5;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "M3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 6;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo datatable

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 2;

            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột mã nhân viên

            //Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            //Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            //Căn giữa cả bảng 
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fHoaDonBanHang f = new fHoaDonBanHang();
            f.ShowDialog();
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
            if (comboBox1.Text == "Sản phẩm")
            {
                hOADONBANHANGDataGridView.DataSource = HienDL("select * from HOADONBANHANG where Linhkien like '%" + textBox1.Text.Trim() + "%'");
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            HDB = HDB + 1;
            maHDBTextBox.Text = "HDB" + HDB.ToString();
        }
    }
}
