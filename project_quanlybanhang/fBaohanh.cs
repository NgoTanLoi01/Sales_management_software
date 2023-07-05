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
    public partial class fBaohanh : Form
    {
        Baohanh baohanh;
        int BH;
        public fBaohanh()
        {
            InitializeComponent();
            baohanh = new Baohanh();
        }

        private void pHIEUBAOHANHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHIEUBAOHANHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qUANLY_CUAHANGMAYTINHDataSet4);

        }

        private void fBaohanh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLY_CUAHANGMAYTINHDataSet3.ChiTietHDB' table. You can move, or remove it, as needed.
            this.chiTietHDBTableAdapter.Fill(this.qUANLY_CUAHANGMAYTINHDataSet3.ChiTietHDB);
            // TODO: This line of code loads data into the 'qUANLY_CUAHANGMAYTINHDataSet3.PHIEUBAOHANH' table. You can move, or remove it, as needed.
            this.pHIEUBAOHANHTableAdapter1.Fill(this.qUANLY_CUAHANGMAYTINHDataSet3.PHIEUBAOHANH);
            // TODO: This line of code loads data into the 'qUANLY_CUAHANGMAYTINHDataSet3.HOADONBANHANG' table. You can move, or remove it, as needed.
            this.hOADONBANHANGTableAdapter.Fill(this.qUANLY_CUAHANGMAYTINHDataSet3.HOADONBANHANG);
            // TODO: This line of code loads data into the 'qUANLY_CUAHANGMAYTINHDataSet3.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qUANLY_CUAHANGMAYTINHDataSet3.NHANVIEN);
            comboBox1.Text = "Mã phiếu";
            // TODO: This line of code loads data into the 'qUANLY_CUAHANGMAYTINHDataSet4.PHIEUBAOHANH' table. You can move, or remove it, as needed.
            this.pHIEUBAOHANHTableAdapter.Fill(this.qUANLY_CUAHANGMAYTINHDataSet4.PHIEUBAOHANH);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            DataColumn col1 = new DataColumn("MaPhieuBH");
            DataColumn col2 = new DataColumn("KhachHangBaoHanh");
            DataColumn col3 = new DataColumn("NhanVienBaoHanh");
            DataColumn col4 = new DataColumn("NgayLapPhieuBH");
            DataColumn col5 = new DataColumn("NgayHenTra");
            DataColumn col6 = new DataColumn("QuyTrinh");
            DataColumn col7 = new DataColumn("LinhKienBaoHanh");
            DataColumn col8 = new DataColumn("TinhTrangBaoHanh");
            DataColumn col9 = new DataColumn("SoLuongBaoHanh");
            DataColumn col10 = new DataColumn("SDT_BH");
            DataColumn col11 = new DataColumn("MaNV");



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



            foreach (DataGridViewRow dtgvRow in pHIEUBAOHANHDataGridView.Rows)
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



                dataTable.Rows.Add(dtrow);
            }
            ExportFile(dataTable, "Danh sach", "Danh sách bảo hành");
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
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "K1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã phiếu";

            cl1.ColumnWidth = 10;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Khách Hàng";

            cl2.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Nhân viên";
            cl3.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Ngày Lập";

            cl4.ColumnWidth = 15.5;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Ngày hẹn trả";

            cl5.ColumnWidth = 20;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "Quy trình";

            cl6.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            cl7.Value2 = "Sản phẩm bảo hành";

            cl7.ColumnWidth = 30;

            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");

            cl8.Value2 = "Tình trạng";

            cl8.ColumnWidth = 20.5;
            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");

            cl9.Value2 = "Số lượng";

            cl9.ColumnWidth = 10.5;
            Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");

            cl10.Value2 = "SDT khách hàng";

            cl10.ColumnWidth = 20.5;

            Microsoft.Office.Interop.Excel.Range cl11 = oSheet.get_Range("K3", "K3");

            cl11.Value2 = "Mã nhân viên";

            cl11.ColumnWidth = 10.5;


            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "K3");

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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            fPhieuBaoHanh f = new fPhieuBaoHanh();
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
            if (comboBox1.Text == "Mã phiếu")
            {
                pHIEUBAOHANHDataGridView.DataSource = HienDL("select * from PHIEUBAOHANH where Maphieubh like '%" + textBox1.Text.Trim() + "%'");
            }
            if (comboBox1.Text == "Tên sản phẩm")
            {
                pHIEUBAOHANHDataGridView.DataSource = HienDL("select * from PHIEUBAOHANH where Linhkienbaohanh like '%" + textBox1.Text.Trim() + "%'");
            }
            if (comboBox1.Text == "SĐT khách hàng")
            {
                pHIEUBAOHANHDataGridView.DataSource = HienDL("select * from PHIEUBAOHANH where Sdt_kh like '%" + textBox1.Text.Trim() + "%'");
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            BH = BH + 1;
            maPhieuBHTextBox.Text = "BH" + BH.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
