using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.Class
{
    internal class DATPHONG
    {
        private int MADP;
        private int MANV;
        private DateTime NGAYNHAN;
        private DateTime NGAYTRA;
        private DateTime NGAYDAT;
        private string LOAIPHONG;
        private string TRANGTHAI;
        private int MAKH;
        private int MADVLH;
        public DATPHONG(int MALSDP)
        {
            DataTable kq = DB_DATPHONG.LAYDATPHONG(MALSDP);
            MADP =Convert.ToInt32( kq.Rows[0][0]);
            //MANV = Convert.ToInt32(kq.Rows[0][1]);
            NGAYNHAN = Convert.ToDateTime(kq.Rows[0][2]);
            NGAYTRA = Convert.ToDateTime(kq.Rows[0][3]);
            TRANGTHAI = kq.Rows[0][6].ToString();
            MAKH = Convert.ToInt32(kq.Rows[0][7]);
        }
        public string getTRANGTHAI()
        {
            return TRANGTHAI;
        }
        public int getMAKH()
        {
            return MAKH;
        }
    }
    internal class DB_DATPHONG
    {
        public static DataTable LAYDATPHONG(int MALSDP)
        {
            string query = "SELECT DP.* FROM DATPHONG DP JOIN LICHSUDUNGPHONG LSDP ON DP.MADP=LSDP.MADP WHERE LSDP.MALSDP=" + MALSDP.ToString();// AND GETDATE() BETWEEN NGAYNHAN AND NGAYTRA";
            DataTable DP = DataAccess.ExecuteQuery(query);
            return DP;
        }
    }
}
