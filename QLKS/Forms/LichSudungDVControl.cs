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
    public partial class LichSudungDVControl : Form
    {
        private int MALSDP;
        private int MATTSDDV;
        private int SL;
        public LichSudungDVControl(int mALSDP, int mATTSDDV, int sL)
        {
            InitializeComponent();
            thoigiansudung.Format = DateTimePickerFormat.Custom;
            thoigiansudung.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            MALSDP = mALSDP;
            MATTSDDV = mATTSDDV;
            SL = sL;


        }

        private void LichSudungDVControl_Load(object sender, EventArgs e)
        {
            CapNhatManHinh();
        }
        private void CapNhatManHinh()
        {
            DataTable kq = QLKS.Class.LichSuDungDichVu.LAYDSLICH(MATTSDDV);
            gv_LichSuDung.DataSource = kq;
            for (int i = 0; i < gv_LichSuDung.Rows.Count - 1; i++)
            {
                gv_LichSuDung.Rows[i].Cells[0].Value = i + 1;
            }
            gv_LichSuDung.Columns["sttdv"].DisplayIndex = 0;
            gv_LichSuDung.Columns["TGSD"].DisplayIndex = 1;
            gv_LichSuDung.Columns["SOLUONGTG"].DisplayIndex = 2;
            gv_LichSuDung.Columns["NGAYDANGKY"].DisplayIndex = 3;
            gv_LichSuDung.Columns["YEUCAUDACBIET"].DisplayIndex = 4;
            gv_LichSuDung.Columns["MAPHIEUDK"].Visible = false;
            gv_LichSuDung.Columns["MATTSDDV"].Visible = false;
            //gv_LichSuDung.Columns["check"].DisplayIndex = 5;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_TroVe_Clicked(object sender, EventArgs e)
        {
            QLKS.Forms.DichVuChitiet DVCT = new QLKS.Forms.DichVuChitiet(MALSDP);
            this.Close();
            DVCT.Show();
        }

        private void btn_Them_Clicked(object sender, EventArgs e)
        {
            if (txt_SoNguoi.Text.Length > 0)
            {
                if (thoigiansudung.Value >= DateTime.Now)
                {
                    QLKS.Class.LichSuDungDichVu kq = new QLKS.Class.LichSuDungDichVu(MATTSDDV, Convert.ToInt32(txt_SoNguoi.Text), thoigiansudung.Value, txt_ChuThich.Text);

                    kq.ThemLich(SL);
                    CapNhatManHinh();
                }
                else return;
            }
            else return;
        }

        private void gv_LichSuDung_CellValuedChanged(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btn_Sua_Clicked(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)gv_LichSuDung.DataSource;
            for (int i = 0; i < gv_LichSuDung.RowCount - 1; i++)
            {
                if (gv_LichSuDung.Rows[i].Selected == true)
                {

                    int slNew = Convert.ToInt32(gv_LichSuDung.Rows[i].Cells[gv_LichSuDung.Columns["SOLUONGTG"].Index].Value.ToString());
                    string ycdb = gv_LichSuDung.Rows[i].Cells[gv_LichSuDung.Columns["YEUCAUDACBIET"].Index].Value.ToString();
                    dt.RejectChanges();
                    int slOld = Convert.ToInt32(gv_LichSuDung.Rows[i].Cells[gv_LichSuDung.Columns["SOLUONGTG"].Index].Value.ToString());
                    QLKS.Class.LichSuDungDichVu kq = new QLKS.Class.LichSuDungDichVu(MATTSDDV, 0, new DateTime(), null);
                    if (kq.KiemTraSL(slNew - slOld, SL) == 1)
                    {
                        gv_LichSuDung.Rows[i].Cells[gv_LichSuDung.Columns["SOLUONGTG"].Index].Value = slNew;
                        gv_LichSuDung.Rows[i].Cells[gv_LichSuDung.Columns["YEUCAUDACBIET"].Index].Value = ycdb;
                        LichSuDungDichVu.CapNhatLich(Convert.ToInt32(gv_LichSuDung.Rows[i].Cells[gv_LichSuDung.Columns["MAPHIEUDK"].Index].Value.ToString()), slNew, ycdb);
                    }


                    //gv_LichSuDung.Rows.RemoveAt(i);

                }
            }





        }

        private void btn_Xoa_Clicked(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)gv_LichSuDung.DataSource;
            for (int i = 0; i < gv_LichSuDung.RowCount - 1; i++)
            {
                if (gv_LichSuDung.Rows[i].Selected == true)
                {

                    LichSuDungDichVu.XoaLich(Convert.ToInt32(gv_LichSuDung.Rows[i].Cells[gv_LichSuDung.Columns["MAPHIEUDK"].Index].Value.ToString()));
                    dt.Rows.RemoveAt(i);
                }
            }
        }
    }
}
