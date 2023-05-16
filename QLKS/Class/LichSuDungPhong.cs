using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.Class
{
    internal class LichSuDungPhong
    {
        private int MADP;
        private int MALSDP;
        private int MAPHONG;
        private DateTime NGAYTRA;
        private DateTime NGAYNHAN;
        public LichSuDungPhong(int mADP, int mALSDP, int mAPHONG, DateTime nGAYTRA, DateTime nGAYNHAN)
        {
            MADP = mADP;
            MALSDP = mALSDP;
            MAPHONG = mAPHONG;
            NGAYTRA = nGAYTRA;
            NGAYNHAN = nGAYNHAN;
        }
        public int getMALSDP()
        {
            return MALSDP;
        }
        public int getMADP()
        {
            return MADP;
        }
        public int getMAPHONG()
        {
            return MAPHONG;
        }
        public DateTime getNGAYNHAN()
        {
            return NGAYNHAN;
        }
        public DateTime getNGAYTRA()
        {
            return NGAYTRA;
        }
        public static DataTable LAYLSDP(int mADP)
        {
            DB_LichSuDungPhong xuly = new DB_LichSuDungPhong();
            DataTable query= xuly.LayLSDP(mADP);
            DateTime NGAYNHAN;
            DateTime NGAYTRA;
            int LSDP = Convert.ToInt32(query.Rows[0][0].ToString());
            int THONGTIN = Convert.ToInt32(query.Rows[0][1]);
            int PHONG = Convert.ToInt32(query.Rows[0][2]);
            LichSuDungPhong kq;
            try
            {
                NGAYNHAN = Convert.ToDateTime(query.Rows[0][3]);
            }
            catch
            {
                NGAYNHAN = new DateTime();
            }
            try
            {
                NGAYTRA = Convert.ToDateTime(query.Rows[0][4]);
            }
            catch { NGAYTRA = new DateTime(); }
            
            return query;
        }
        public static DataTable LAYLSDPHOPLE()
        {
            DB_LichSuDungPhong xuly=new DB_LichSuDungPhong();
            DataTable query = xuly.LayDSLSDPHopLe();
            return query;
           
        }
        public static DataTable LAYLSDPHOPLE(string tenphong)
        {

            DataTable query;
            DB_LichSuDungPhong xuly = new DB_LichSuDungPhong();
            if (tenphong != "")
            {
                 query = xuly.LayDSLSDPHopLe(tenphong);
            }
            else
            {
                 query = xuly.LayDSLSDPHopLe();
            }

            
            return query;
        }
    }
    internal class DB_LichSuDungPhong
    {

        public DataTable LayLSDP(int mALSDP)
        {

            string query = "SELECT * FROM LICHSUDUNGPHONG WHERE MALSDP=" + mALSDP.ToString();// +" AND GETDATE() BETWEEN NGAYNHAN AND NGAYTRA";
            DataTable LSDP= DataAccess.ExecuteQuery(query);
            return LSDP;
            //LichSuDungPhong kq = new LichSuDungPhong(LSDP.Rows[0]["MADP"], LSDP.Rows[0]["MALSDP"], LSDP.Rows[0]["MAPHONG"], LSDP.Rows[0]["NGAYNHAN"], LSDP.Rows[0]["NGAYTRA"]);

            
        }
        public  DataTable LayDSLSDPHopLe()
        {

            string query = "SELECT * FROM LICHSUDUNGPHONG";// WHERE GETDATE() BETWEEN NGAYNHAN AND NGAYTRA";
            DataTable LSDP = DataAccess.ExecuteQuery(query);
            return LSDP;
        }
        public DataTable LayDSLSDPHopLe(string tenphong)
        {

            string query = "SELECT * FROM LICHSUDUNGPHONG WHERE MAPHONG='" + tenphong + "'";// AND GETDATE() BETWEEN NGAYNHAN AND NGAYTRA";
            DataTable LSDP = DataAccess.ExecuteQuery(query);
            return LSDP;
        }
    }
}
