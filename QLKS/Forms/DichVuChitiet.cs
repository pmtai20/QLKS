using QLKS.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.Forms
{
    public partial class DichVuChitiet : Form
    {
        private int MALSDP;
        private QLKS.Class.DATPHONG DP;

        public DichVuChitiet(int mALSDP)
        {
            InitializeComponent();
            MALSDP = mALSDP;
            DP = new QLKS.Class.DATPHONG(mALSDP);
            this.Hide();
        }

        private void DichVuChitiet_Load(object sender, EventArgs e)
        {
            DataTable LSDP = QLKS.Class.LichSuDungPhong.LAYLSDP(MALSDP);
            txt_MaPhong.Text = LSDP.Rows[0][2].ToString();
            txt_MaPhong.ReadOnly = true;
            txt_NgayDen.Text = Convert.ToDateTime(LSDP.Rows[0][3]).ToShortDateString();
            txt_NgayDen.ReadOnly = true;
            txt_NgayDi.Text = Convert.ToDateTime(LSDP.Rows[0][4]).ToShortDateString();
            txt_NgayDi.ReadOnly = true;
            gv_KhachHang.DataSource = QLKS.Class.KHACHHANGCANHAN.LAYDSKHLUUTRU(DP.getMAKH());
            for (int i = 0; i < gv_KhachHang.RowCount - 1; i++)
            {
                gv_KhachHang.Rows[i].Cells[0].Value = i + 1;
            }
            gv_KhachHang.Columns["stt"].DisplayIndex=0;
            gv_KhachHang.Columns["TENKH"].DisplayIndex=1;
            gv_KhachHang.Columns["cmnd"].DisplayIndex = 3;
            gv_KhachHang.Columns["sdt"].DisplayIndex = 2;
            //gv_KhachHang.Columns["check"].DisplayIndex = 4;
            gv_KhachHang.Columns["MAKHCN"].Visible=false;
            gv_KhachHang.Columns["DIACHI"].Visible = false;
            gv_KhachHang.Columns["MADOAN"].Visible = false;

            gv_DSDichVu.DataSource = QLKS.Class.ThongTinSuDungDichVu.LAYDSSDDV(MALSDP);
            for (int i = 0; i < gv_DSDichVu.RowCount - 1; i++)
            {
                gv_DSDichVu.Rows[i].Cells[0].Value = i + 1;
            }
            gv_DSDichVu.Columns["MATT"].Visible = false;
            gv_DSDichVu.Columns["MASP"].Visible = false;
            gv_DSDichVu.Columns["MALSDP"].Visible = false;
            gv_DSDichVu.Columns["MAHD"].Visible = false;
            gv_DSDichVu.Columns["MAKH"].Visible = false;
            gv_DSDichVu.Columns["sttdv"].DisplayIndex = 0;
            gv_DSDichVu.Columns["TENSP"].DisplayIndex = 1;
            gv_DSDichVu.Columns["SOLUONGDV"].DisplayIndex = 2;
            gv_DSDichVu.Columns["GIATHANH"].DisplayIndex = 3;
            gv_DSDichVu.Columns["GIAMGIA"].DisplayIndex = 4;
            gv_DSDichVu.Columns["TENNGUOIDK"].DisplayIndex = 5;
            gv_KhachHang.ReadOnly = true;


            gv_DSDichVu.Columns["sttdv"].ReadOnly = true;
            gv_DSDichVu.Columns["TENSP"].ReadOnly = true;
            gv_DSDichVu.Columns["SOLUONGDV"].ReadOnly = false;
            gv_DSDichVu.Columns["GIATHANH"].ReadOnly = true;
            gv_DSDichVu.Columns["GIAMGIA"].ReadOnly = false;
            gv_DSDichVu.Columns["TENNGUOIDK"].ReadOnly = true;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_TroVe_Clicked(object sender, EventArgs e)
        {
            this.Close();

            Application.OpenForms["MainForm"].Show();
        }

        private void btn_Them_Clicked(object sender, EventArgs e)
        {
            QLKS.Forms.ThemDichVu MH_ThemDV = new QLKS.Forms.ThemDichVu(MALSDP, DP.getMAKH());
            Application.OpenForms["DichVuChiTiet"].Close();
            MH_ThemDV.Show();
        }

        private void gv_DSDVDATHEM_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)gv_DSDichVu.DataSource;

            if (gv_DSDichVu.Columns["GIAMGIA"] != null && e.ColumnIndex == gv_DSDichVu.Columns["GIAMGIA"].Index)
            {
                if (QLKS.Class.ThongTinSuDungDichVu.KTGIAMGIA( Convert.ToInt32(gv_DSDichVu.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())))
                {
                    dt.AcceptChanges();
                }
                else
                    dt.RejectChanges();
            }
            if (gv_DSDichVu.Columns["SOLUONGDV"] != null && e.ColumnIndex == gv_DSDichVu.Columns["SOLUONGDV"].Index)
            {
                if (QLKS.Class.ThongTinSuDungDichVu.KTSL( Convert.ToInt32(gv_DSDichVu.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())) )
                {
                    dt.AcceptChanges();
                }
                else
                    dt.RejectChanges();
            }
        }

        private void btn_Sua_Clicked(object sender, EventArgs e)
        {
            for (int i = 0; i < gv_DSDichVu.RowCount - 1; i++)
            {
                if (gv_DSDichVu.Rows[i].Selected == true)
                {
                    QLKS.Class.ThongTinSuDungDichVu.CapNhatSDDV(Convert.ToInt32(gv_DSDichVu.Rows[i].Cells[gv_DSDichVu.Columns["MATT"].Index].Value.ToString()), Convert.ToInt32(gv_DSDichVu.Rows[i].Cells[gv_DSDichVu.Columns["SOLUONGDV"].Index].Value.ToString()), Convert.ToInt32(gv_DSDichVu.Rows[i].Cells[gv_DSDichVu.Columns["GIAMGIA"].Index].Value.ToString()));
                }
            }
        }

        private void btn_Xoa_Clicked(object sender, EventArgs e)
        {
            for (int i = 0; i < gv_DSDichVu.RowCount - 1; i++)
            {
                if (gv_DSDichVu.Rows[i].Selected == true)
                {
                    QLKS.Class.ThongTinSuDungDichVu.XoaSDDV(Convert.ToInt32(gv_DSDichVu.Rows[i].Cells[gv_DSDichVu.Columns["MATT"].Index].Value.ToString()));
                    gv_DSDichVu.Rows.RemoveAt(i);

                }
            }
            for (int i = 0; i < gv_DSDichVu.RowCount - 1; i++)
            {
                gv_DSDichVu.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void btn_XemLich_Clicked(object sender, EventArgs e)
        {
            for (int i = 0; i < gv_DSDichVu.RowCount - 1; i++)
            {
                if (gv_DSDichVu.Rows[i].Selected == true )
                {
                    DataTable dv= QLKS.Class.SANPHAMDICHVU.LAYDV(Convert.ToInt32(gv_DSDichVu.Rows[i].Cells[gv_DSDichVu.Columns["MASP"].Index].Value.ToString()));
                    if (dv.Rows[0]["LOAISP"].ToString()=="Dang Ky Lich")
                    {
                        QLKS.Forms.LichSudungDVControl LSDDV = new QLKS.Forms.LichSudungDVControl(MALSDP,Convert.ToInt32( gv_DSDichVu.Rows[i].Cells[gv_DSDichVu.Columns["MATT"].Index].Value.ToString()), Convert.ToInt32(gv_DSDichVu.Rows[i].Cells[gv_DSDichVu.Columns["SOLUONGDV"].Index].Value.ToString()));
                        this.Close();
                        LSDDV.Show();
                    }    

                }
            }
        }
    }
}
