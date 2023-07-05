using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project_quanlybanhang
{
    class Hoadonnhap
    {
        ThaotacCSDL db;
        public Hoadonnhap()
        {
            db = new ThaotacCSDL();
        }
        public void addTacgia(String manv, String tennv)
        {
            string sql = string.Format("Insert Into HOADONNHAPHANG Values(N'{0}',N'{1}')", manv, tennv);
            Console.WriteLine(sql);
            db.ExecuteNonQuery(sql);
        }
        public DataTable listNhanvien()
        {
            DataTable dt;
            string sql = "select * from HOADONNHAPHANG";
            dt = db.Execute(sql);
            return dt;
        }
        public DataTable listNhanvien(string mamt)
        {
            DataTable dt;
            string sql = "select * from tblTacgia where matg like '" + mamt + "'";
            dt = db.Execute(sql);
            return dt;
        }
    }
}
