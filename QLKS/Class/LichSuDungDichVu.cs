using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.Class
{
    internal class LichSuDungDichVu
    {
        private int MAPHIEUDK;
        private DateTime THOIGIANSUDUNG;
        private DateTime NGAYDK;
        private string YEUCAUDACBIET;
        private int SOLUONG;
        private int MATTSDDV;
      
        public LichSuDungDichVu(int MATT, int SL, DateTime TGSD, string YCDB)
        {
            MATTSDDV = MATT;
            SOLUONG = SL;
            THOIGIANSUDUNG = TGSD;
            YEUCAUDACBIET = YCDB;
        }    

        public DateTime getTGSD()
        {
            return THOIGIANSUDUNG;
        }
        public DateTime getNGAYDK() { 
            return NGAYDK;
        }
        public string getYEUCAUDACBIET()
        {
            return YEUCAUDACBIET;
        }
        public int getSOLUONG()
        {
            return SOLUONG;
        }
        public int getMATTSDDV() { 
            return MATTSDDV;
        }
       
        public int CapNhatSoNguoi(int SL)
        {
            if (SL>=1)
            {
                SOLUONG=SL;
                return 1;
            }
            else return 0;
        }
        public int CapNhatYCDB(string YCDB)
        {
            YEUCAUDACBIET = YCDB;
            return 1;
        }
        public int KiemTraSL(int SL,int MAX) {

            DataTable kq = DB_LichSuDungDichVu.LayDSLich(this.MATTSDDV);
            int SLDACO = 0;
            for (int i = 0;i<kq.Rows.Count;i++)
            {
                SLDACO += Convert.ToInt32(kq.Rows[i]["SOLUONG"]);
            }
            if (SLDACO + SL > MAX)
                return 0;
            else return 1;
        }

        public static DataTable LAYDSLICH(int MATT)
        {
            DataTable kq = DB_LichSuDungDichVu.LayDSLich(MATT);
            return kq;
        }
        public static int CapNhatLich(int MALICH, int SL, string YCDB)
        {
            //LichSuDungDichVu kq=new LichSuDungDichVu(0,)

            return DB_LichSuDungDichVu.CapNhatLich(MALICH, SL, YCDB);   
        }
        public int ThemLich( int MAX)
        {

            NGAYDK = DateTime.Now;
            if (KiemTraSL(SOLUONG, MAX) == 1)
                return DB_LichSuDungDichVu.ThemLich(this);
            else return 0;
            
        }
        public static int XoaLich(int MALICH)
        {
            return DB_LichSuDungDichVu.XoaLich(MALICH);
        }
    }
    internal class DB_LichSuDungDichVu
    {
        public static int CapNhatLich(int MALICH,int SL,string YCDB)
        {
            string query = "Update LICHSUDUNGDICHVU SET SOLUONG="+SL.ToString()+",YEUCAUDACBIET='"+YCDB+"'WHERE MAPHIEUDK=" + MALICH.ToString();
            return  DataAccess.ExecuteNonQuery(query);
             
        }
        public static DataTable LayDSLich(int MATT)
        {
            string query = "SELECT * FROM LICHSUDUNGDICHVU WHERE MATTSDDV=" + MATT.ToString();
            DataTable kq= DataAccess.ExecuteQuery(query);
            return kq;
        }
        public static int ThemLich(LichSuDungDichVu Lich)
        {
            string query = "Insert into LICHSUDUNGDICHVU(THOIGIANSUDUNG,NGAYDANGKY,YEUCAUDACBIET,SOLUONG,MATTSDDV) VALUES ('" + Lich.getTGSD().ToString() + "','" + Lich.getNGAYDK().ToString() + "','" + Lich.getYEUCAUDACBIET().ToString() + "'," + Lich.getSOLUONG().ToString() + "," + Lich.getMATTSDDV().ToString() + ")";
            return DataAccess.ExecuteNonQuery(query);
        }
        public static int XoaLich(int MALICH)
        {
            string query = "Delete LICHSUDUNGDICHVU WHERE MAPHIEUDK=" + MALICH.ToString();
            return DataAccess.ExecuteNonQuery(query);
          
        }
    }
}
