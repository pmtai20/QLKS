using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.Forms
{
    public partial class ChinhSuaNTG : Form
    {
        int MALSDP;
        int MAPHIEUDK;
        public ChinhSuaNTG()
        {
            InitializeComponent();
        }
        public void capnhatLSDP(int mALSDP)
        {
            MALSDP = mALSDP;
            txt_Phong.Text = MALSDP.ToString();
            loadDSKH();
        }
        public void capnhatMAPHIEU(int mAPHIEUDK)
        {
            MAPHIEUDK = mAPHIEUDK;
        }
        public void loadDSKH()
        {
            QLKS.Class.DATPHONG DP = new QLKS.Class.DATPHONG(MALSDP);
            DataTable dt;

            dt = QLKS.Class.KHACHHANGCANHAN.LAYDSKHLUUTRU(DP.getMAKH());
            DataTable dt1 = dt.Clone();
            gv_ThamGia.DataSource = dt1;
            gv_KhachHang.DataSource = dt;
            dt1.Rows.Clear();

            gv_ThamGia.Columns["stt"].DisplayIndex = 0;
            gv_ThamGia.Columns["tenkh"].DisplayIndex = 1;
            gv_ThamGia.Columns["cmnd"].DisplayIndex = 3;
            gv_ThamGia.Columns["sdt"].DisplayIndex = 2;
            gv_ThamGia.Columns["chon1"].DisplayIndex = 4;
            gv_ThamGia.Columns["MAKHCN"].Visible = false;
            gv_ThamGia.Columns["DIACHI"].Visible = false;
            gv_ThamGia.Columns["MADOAN"].Visible = false;

            gv_KhachHang.Columns["stt1"].DisplayIndex = 0;
            gv_KhachHang.Columns["TENKHCN1"].DisplayIndex = 1;
            gv_KhachHang.Columns["cmnd1"].DisplayIndex = 3;
            gv_KhachHang.Columns["sdt1"].DisplayIndex = 2;
            gv_KhachHang.Columns["check"].DisplayIndex = 4;
            gv_KhachHang.Columns["MAKHCN"].Visible = false;
            gv_KhachHang.Columns["DIACHI"].Visible = false;
            gv_KhachHang.Columns["MADOAN"].Visible = false;
            for (int i = 0; i < gv_KhachHang.RowCount - 1; i++)
            {
                gv_KhachHang.Rows[i].Cells[0].Value = i + 1;
            }

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ChinhSuaNTG_Load(object sender, EventArgs e)
        {

        }

        private void btn_TaiDuLieu_Clicked(object sender, EventArgs e)
        {

            QLKS.Forms.ChonPhong CP = new QLKS.Forms.ChonPhong();
            CP.Show();
            this.Hide();

        }

        private void btn_Them_Clicked(object sender, EventArgs e)
        {
            for (int i = gv_KhachHang.RowCount - 1; i >= 0; i--)
            {

                if (Convert.ToBoolean(gv_KhachHang.Rows[i].Cells[gv_KhachHang.Columns["check"].Index].Value))
                {
                    int flag = 0;

                    for (int j = 0; j < gv_ThamGia.RowCount - 1; j++)
                    {
                        if (Convert.ToInt32(gv_KhachHang.Rows[i].Cells[gv_KhachHang.Columns["MAKHCN"].Index].Value.ToString()) == Convert.ToInt32(gv_ThamGia.Rows[j].Cells[gv_ThamGia.Columns["MAKHCN"].Index].Value.ToString()))
                        {
                            flag = 1;
                        }
                    }
                    if (flag == 0)
                    {
                        DataTable kh = (DataTable)gv_KhachHang.DataSource;
                        DataTable tg = (DataTable)gv_ThamGia.DataSource;
                        DataRow row;
                        row = tg.NewRow();

                        row["TENKHCN"] = gv_KhachHang.Rows[i].Cells[gv_KhachHang.Columns["TENKHCN1"].Index].Value.ToString();
                        row["CMND"] = gv_KhachHang.Rows[i].Cells[gv_KhachHang.Columns["cmnd1"].Index].Value.ToString();
                        row["SDT"] = gv_KhachHang.Rows[i].Cells[gv_KhachHang.Columns["sdt1"].Index].Value.ToString();
                        row["MAKHCN"] = Convert.ToInt32(gv_KhachHang.Rows[i].Cells[gv_KhachHang.Columns["MAKHCN"].Index].Value.ToString());


                        tg.Rows.Add(row);

                        gv_KhachHang.Rows.RemoveAt(i);

                    }
                }
            }

            for (int i = 0; i < gv_KhachHang.RowCount - 1; i++)
            {
                gv_KhachHang.Rows[i].Cells[gv_KhachHang.Columns["stt1"].Index].Value = i + 1;

            }
            for (int i = 0; i < gv_ThamGia.RowCount - 1; i++)
            {
                gv_ThamGia.Rows[i].Cells[gv_ThamGia.Columns["stt"].Index].Value = i + 1;


            }

        }

        private void btn_XacNhan_Clicked(object sender, EventArgs e)
        {
            QLKS.Forms.DangKyTour DKT = (QLKS.Forms.DangKyTour)Application.OpenForms["DangKyTour"];
            DKT.CapNhatDSTG((DataTable)gv_ThamGia.DataSource);
            this.Close();
            DKT.Show();

        }

        private void btn_TroVe_Clicked(object sender, EventArgs e)
        {
            QLKS.Forms.DangKyTour DKT = (QLKS.Forms.DangKyTour)Application.OpenForms["DangKyTour"];
            //DKT.CapNhatDSTG((DataTable)gv_ThamGia.DataSource);
            this.Close();
            DKT.Show();
        }

        private void btn_Xoa_Clicked(object sender, EventArgs e)
        {
            for (int i = gv_ThamGia.RowCount - 1; i >= 0; i--)
            {

                if (Convert.ToBoolean(gv_ThamGia.Rows[i].Cells[gv_ThamGia.Columns["chon1"].Index].Value))
                {
                    int flag = 0;

                  
                        

                        gv_ThamGia.Rows.RemoveAt(i);

                  
                }
            }

            for (int i = 0; i < gv_ThamGia.RowCount - 1; i++)
            {
                gv_ThamGia.Rows[i].Cells[gv_ThamGia.Columns["stt"].Index].Value = i + 1;


            }
        }
    }
}
