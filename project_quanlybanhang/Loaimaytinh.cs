using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project_quanlybanhang
{
    class Loaimaytinh
    {
        ThaotacCSDL db;
        public Loaimaytinh()
        {
            db = new ThaotacCSDL();
        }
        public void addTacgia(String maloai, String tenloai, string mota)
        {
            string sql = string.Format("Insert Into LOAIMAYTINH Values(N'{0}',N'{1}', N'{2}'",
                                      maloai, tenloai, mota);
            Console.WriteLine(sql);
            db.ExecuteNonQuery(sql);
        }
        public DataTable listNhanvien()
        {
            DataTable dt;
            string sql = "select * from LOAIMAYTINH";
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
