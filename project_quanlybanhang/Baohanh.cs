using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project_quanlybanhang
{
    class Baohanh
    {
        ThaotacCSDL db;
        public Baohanh()
        {
            db = new ThaotacCSDL();
        }
        public void addTacgia(String maphieubh, String linhkienbaohanh, string sdt_kh)
        {
            string sql = string.Format("Insert Into PHIEUBAOHANH Values(N'{0}',N'{1}', N'{2}')",
                                      maphieubh, linhkienbaohanh, sdt_kh);
            Console.WriteLine(sql);
            db.ExecuteNonQuery(sql);
        }
        public DataTable listNhanvien()
        {
            DataTable dt;
            string sql = "select * from PHIEUBAOHANH";
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
