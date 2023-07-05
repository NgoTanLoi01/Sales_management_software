using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project_quanlybanhang
{
    class NhaCC
    {
        ThaotacCSDL db;
        public NhaCC()
        {
            db = new ThaotacCSDL();
        }
        public void addTacgia(String mancc, String tenncc, string diachincc, string dtncc)
        {
            string sql = string.Format("Insert Into NHACUNGCAP Values(N'{0}',N'{1}', N'{2}', N'{3}')",
                                      mancc, tenncc, diachincc, dtncc);
            Console.WriteLine(sql);
            db.ExecuteNonQuery(sql);
        }
        public DataTable listNhanvien()
        {
            DataTable dt;
            string sql = "select * from NHACUNGCAP";
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
