using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project_quanlybanhang
{
    class Khachhang
    {
        ThaotacCSDL db;
        public Khachhang()
        {
            db = new ThaotacCSDL();
        }
        public void addTacgia(String makh, String tenkh, string diachikh, string dienthoaikh, string gioitinkh)
        {
            string sql = string.Format("Insert Into NHANVIEN Values(N'{0}',N'{1}', N'{2}', N'{3}', N'{4}')",
                                      makh, tenkh, diachikh, dienthoaikh, gioitinkh );
            Console.WriteLine(sql);
            db.ExecuteNonQuery(sql);
        }
        public DataTable listNhanvien()
        {
            DataTable dt;
            string sql = "select * from KHACHHANG";
            dt = db.Execute(sql);
            return dt;
        }
        //public DataTable listNhanvien(string manv)
        //{
        //    DataTable dt;
        //    string sql = "select * from tblTacgia where matg like '" + manv + "'";
        //    dt = db.Execute(sql);
        //    return dt;
        //}
    }
}
