using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.Class
{
  
    internal class KHACHHANGCANHAN
    {
        private int MAKHCN;
        private string TENKHCN;
        private string CMND;
        private string SDT;
        private string DIACHI;
        private int MADOAN;
        private int LOAIKH;
        public KHACHHANGCANHAN(int mAKHCN, string tENKHCN, string cMND, string sDT, string dIACHI, int mADOAN)
        {
            MAKHCN = mAKHCN;
            TENKHCN = tENKHCN;
            CMND = cMND;
            SDT = sDT;
            DIACHI = dIACHI;
            MADOAN = mADOAN;
        }
        public static int LAYLOAIKH(int mAKHCN)
        {
            DataTable KHCN= DB_KHACHHANGCANHAN.LAYLOAIKH(mAKHCN);
            
            return Convert.ToInt32(KHCN.Rows[0][1]);
        }
        public static DataTable LAYDSKHLUUTRU(int mAKHCN)
        {
            int LOAIKH = LAYLOAIKH(mAKHCN);
            if (LOAIKH == 0)
            {

              
                return DB_KHACHHANGCANHAN.LAYKHCN(mAKHCN);
            }
            else if (LOAIKH == 1)
            {
                return DB_KHACHHANGCANHAN.LAYKHDOAN(mAKHCN);
            }
            else  return null;
        }
        public static DataTable LAYKHCN(int mAKHCN)
        {
            DataTable kq = DB_KHACHHANGCANHAN.LAYKHCN(mAKHCN);
            
            return kq;
        }
        public static DataTable LAYKHDOAN(int mADOAN)
        {
            DataTable kq = DB_KHACHHANGCANHAN.LAYKHDOAN(mADOAN);
           
            return kq;
        }    

    }
    internal class DB_KHACHHANGCANHAN
    {
        public static DataTable LAYKHCN(int mAKHCN)
        {
            string query = "SELECT * FROM KHACHHANGCANHAN WHERE MAKHCN=" + mAKHCN.ToString();// AND GETDATE() BETWEEN NGAYNHAN AND NGAYTRA";
            DataTable KHCN = DataAccess.ExecuteQuery(query);
            return KHCN;
        }
        public static DataTable LAYKHDOAN(int mADOAN)
        {
            string query = "SELECT * FROM KHACHHANGCANHAN WHERE MADOAN=" + mADOAN.ToString();// AND GETDATE() BETWEEN NGAYNHAN AND NGAYTRA";
            DataTable KHCN = DataAccess.ExecuteQuery(query);
            return KHCN;
        }
        public static DataTable LAYLOAIKH(int mAKHCN)
        {
            string query = "SELECT * FROM KHACHHANG WHERE MAKH=" + mAKHCN.ToString();// AND GETDATE() BETWEEN NGAYNHAN AND NGAYTRA";
            DataTable KHCN = DataAccess.ExecuteQuery(query);
            return KHCN;
        }
    }
}
