using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.Class
{
    internal class SANPHAMDICHVU
    {
        private int MASP;
        private string TENSP;
        private string LOAISP;
        private string GIASP;
        private string DONVI;
        private string THONGTINSP;
        public static DataTable LAYDSSP()
        {
            return DB_SANPHAMDICHVU.LAYDSSP();
        }
        public static DataTable LAYDSSP(string ten)
        {
            return DB_SANPHAMDICHVU.LAYDSSP(ten);
        }
        public static DataTable LAYDV(int MASP)
        {
            return DB_SANPHAMDICHVU.LAYDV(MASP);
        }
    }
    internal class DB_SANPHAMDICHVU
    {
       public static DataTable LAYDSSP()
        {
            string query = "SELECT * FROM SANPHAMDICHVU ";// AND GETDATE() BETWEEN NGAYNHAN AND NGAYTRA";
            DataTable KHCN = DataAccess.ExecuteQuery(query);
            return KHCN;
        }
        public static DataTable LAYDSSP(string ten)
        {
            string query = "SELECT * FROM SANPHAMDICHVU WHERE TENSP like '%"+ten+ "%'" ;// AND GETDATE() BETWEEN NGAYNHAN AND NGAYTRA";
            DataTable KHCN = DataAccess.ExecuteQuery(query);
            return KHCN;
        }
        public static DataTable LAYDV(int madv)
        {
            string query = "SELECT * FROM SANPHAMDICHVU WHERE MASP=" +madv.ToString();// AND GETDATE() BETWEEN NGAYNHAN AND NGAYTRA";
            DataTable KHCN = DataAccess.ExecuteQuery(query);
            return KHCN;
        }
    }
}
