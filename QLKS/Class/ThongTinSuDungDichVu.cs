using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace QLKS.Class
{
    internal class ThongTinSuDungDichVu
    {
        private int MATT;
        private int MASP;
        private string TENDV;
        private int MALSDP;
        private int MAHD;
        private int GIATHANH;
        private int SOLUONG;
        private int GIAMGIA;
        private int MANGUOIDK;
        private string TENNGUOIDK;
        
        public ThongTinSuDungDichVu()
        {

        }
        public ThongTinSuDungDichVu( int mASP, int mALSDP, int gIATHANH, int sOLUONG, int gIAMGIA, int mANGUOIDK)
        {
           
            MASP = mASP;
     
            MALSDP = mALSDP;
       
            GIATHANH = gIATHANH;
            SOLUONG = sOLUONG;
            GIAMGIA = gIAMGIA;
            MANGUOIDK = mANGUOIDK;
      
        }
        public static bool KTSL(int i)
        {
            if (i >= 1)
                return true;
            else return false;
        }
        public static bool KTGIAMGIA(int i)
        {
            if (i >= 0 && i < 100)
                return true;
            else return false;
        }
        public int getMASP()
        {
            return MASP;
        }
        public int getMALSDP()
        {
            return MALSDP;
        }
        public int getMANGUOIDK()
        {
            return MANGUOIDK;
        }
        public int getGIATHANH()
        {
            return GIATHANH;
        }
        public int getSL()
        {
            return SOLUONG;
        }
        public int getGIAMGIA()
        {
            return GIAMGIA;
        }
        
        
        public int ThemTTSDDV()
        {
            
            return DB_ThongTinSuDungDichVu.ThemTTSDDV(this);
        }
        public static DataTable LAYDSSDDV(int MALSDP)
        {
            return DB_ThongTinSuDungDichVu.LayDSSDDV(MALSDP);
        }
        public static int CapNhatSDDV(int MATT, int SL, int GG)
        {
            return DB_ThongTinSuDungDichVu.CapNhatSDDV(MATT, SL, GG);   
        }    
        public static int XoaSDDV(int MATT)
        {
            return DB_ThongTinSuDungDichVu.XoaSDDV(MATT);
        }
        /*
                //public int CapNhatSDDV() { }
                public void CapNhatGiamGia(int GG)
                {
                    MASP = 0;
                }
                public void CapNhatSL(int SL)
                {
                    MASP = 1;
                }
                public static ThongTinSuDungDichVu[] LayDSSDDV(int)
                {

                } 
                public static int XoaSDDV(int)
                {

                }*/
    }
    internal class DB_ThongTinSuDungDichVu
    {
        public static int CapNhatSDDV(int MATT,int SL,int GG)
        {
            string query = "Update THONGTINSUDUNGDICHVU SET SOLUONG=" + SL.ToString() + ",GIAMGIA=" + GG.ToString() + "WHERE MATT=" + MATT.ToString();
            return DataAccess.ExecuteNonQuery(query);
        }
        public static int ThemTTSDDV(ThongTinSuDungDichVu TT)
        {
            string query = "Insert into THONGTINSUDUNGDICHVU(MASP,MALSDP,GIATHANH,SOLUONG,GIAMGIA,MAKH) VALUES (" +TT.getMASP().ToString()+","+TT.getMALSDP().ToString()+","+TT.getGIATHANH().ToString()+","+TT.getSL().ToString()+","+TT.getGIAMGIA().ToString()+","+TT.getMANGUOIDK().ToString()+")";
            return DataAccess.ExecuteNonQuery(query);
        }
        public static DataTable LayDSSDDV(int MALSDP)
        {

            string query = "SELECT TTSDDV.*,SP.TENSP,KHCN.TENKHCN TENNGUOIDK FROM THONGTINSUDUNGDICHVU TTSDDV JOIN SANPHAMDICHVU SP ON TTSDDV.MASP=SP.MASP JOIN KHACHHANGCANHAN KHCN ON KHCN.MAKHCN=TTSDDV.MAKH WHERE MALSDP="+MALSDP.ToString();
            DataTable kq = DataAccess.ExecuteQuery(query);
            return kq;
        }       
        public static int XoaSDDV(int MATT)
        {
            string query = "DELETE THONGTINSUDUNGDICHVU WHERE MATT=" + MATT.ToString();
            return DataAccess.ExecuteNonQuery(query);
        }
    }
}
