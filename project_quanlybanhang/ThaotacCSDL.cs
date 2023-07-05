using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_quanlybanhang
{
    class ThaotacCSDL
    {
        SqlConnection sqlConn;
        SqlDataAdapter da;
        DataSet ds;
        public ThaotacCSDL()
        {
            string strCnn = @"Data Source = LAPTOP-KNCJTSN8; Initial Catalog = QUANLY_CUAHANGMAYTINH; Integrated Security = True";
            sqlConn = new SqlConnection(strCnn);
        }
        //Cho cau lenh select
        public DataTable Execute(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, sqlConn);
            ds = new DataSet();
            da.Fill(ds);  // Lấy dữ liệu từ CSDL đổ vào dataset (fill)
            return ds.Tables[0];
        }
        //Cho cau lenh Them, Xoa, Sua
        public void ExecuteNonQuery(string strSQL) // insert, delete, update
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
            sqlConn.Open(); //Mo ket noi

            sqlcmd.ExecuteNonQuery();//Lenh hien lenh Them/Xoa/Sua
            sqlConn.Close();//Dong ket noi          
        }

    }
    
}
