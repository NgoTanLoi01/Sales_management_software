using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project_quanlybanhang
{
    class Nhanvien
    {
        ThaotacCSDL db;
        public Nhanvien()
        {
            db = new ThaotacCSDL();
        }
        public void addTacgia(String manv, String tennv, string diachinv, string dienthoainv, string chucvunv, string ngayvaolamnv, string gioitinhnv, string hinhanhnv)
        {
            string sql = string.Format("Insert Into NHANVIEN Values(N'{0}',N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}')",
                                      manv, tennv, diachinv, dienthoainv, chucvunv, ngayvaolamnv, gioitinhnv, hinhanhnv);
            Console.WriteLine(sql);
            db.ExecuteNonQuery(sql);
        }
        public DataTable listNhanvien()
        {
            DataTable dt;
            string sql = "select * from NHANVIEN";
            dt = db.Execute(sql);
            return dt;
        }
        public DataTable listNhanvien(string manv)
        {
            DataTable dt;
            string sql = "select * from tblTacgia where matg like '" + manv + "'";
            dt = db.Execute(sql);
            return dt;
        }
    }
}
