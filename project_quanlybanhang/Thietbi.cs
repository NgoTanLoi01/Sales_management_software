using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project_quanlybanhang
{
    class Thietbi
    {
        ThaotacCSDL db;
        public Thietbi()
        {
            db = new ThaotacCSDL();
        }
        public void addTacgia(String mamt, String tenmt)
        {
            string sql = string.Format("Insert Into MARTINH Values(N'{0}',N'{1}')",
                                      mamt, tenmt);
            Console.WriteLine(sql);
            db.ExecuteNonQuery(sql);
        }
        public DataTable listNhanvien()
        {
            DataTable dt;
            string sql = "select * from MAYTINH";
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
