using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project_quanlybanhang
{
    class Sanpham
    {
        ThaotacCSDL db;
        public Sanpham()
        {
            db = new ThaotacCSDL();
        }
        public void addTacgia(String mahdb, String linhkien)
        {
            string sql = string.Format("Insert Into HOADONBANHANG Values(N'{0}',N'{1}')",
                                      mahdb, linhkien);
            Console.WriteLine(sql);
            db.ExecuteNonQuery(sql);
        }
        public DataTable listNhanvien()
        {
            DataTable dt;
            string sql = "select * from HOADONBANHANG";
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
