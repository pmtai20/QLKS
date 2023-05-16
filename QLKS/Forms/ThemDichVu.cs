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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLKS.Forms
{
    public partial class ThemDichVu : Form
    {
        int MADVCT;
        int MAKH;
        public ThemDichVu(int mADVDT, int mAKH)
        {
            InitializeComponent();
            MADVCT = mADVDT;
            MAKH = mAKH;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
      
        private void CapNhatManHinh()
        {
            double tongtien = 0;
            for (int i = 0; i < gv_DichVuDaThem.RowCount - 1; i++)
            {
                gv_DichVuDaThem.Rows[i].Cells[0].Value = i + 1;
                tongtien += Convert.ToDouble(gv_DichVuDaThem.Rows[i].Cells[gv_DichVuDaThem.Columns["SOLUONG"].Index].Value.ToString()) * Convert.ToDouble(gv_DichVuDaThem.Rows[i].Cells[gv_DichVuDaThem.Columns["GIATHANH"].Index].Value.ToString()) * (100 - Convert.ToDouble(gv_DichVuDaThem.Rows[i].Cells[gv_DichVuDaThem.Columns["GIAMGIA"].Index].Value.ToString())) / 100;

            }
            txt_TongTien.Text = tongtien.ToString();
        }
        private void ThemDichVu_Load(object sender, EventArgs e)
        {
            DataTable NGUOIDK = QLKS.Class.KHACHHANGCANHAN.LAYDSKHLUUTRU(MAKH);
            cbb_NguoiDK.DataSource = NGUOIDK;
            cbb_NguoiDK.DisplayMember = "TENKHCN";

            gv_KQTimDV.DataSource = QLKS.Class.SANPHAMDICHVU.LAYDSSP();

            gv_KQTimDV.Columns["stt"].DisplayIndex = 0;
            gv_KQTimDV.Columns["TENSP"].DisplayIndex = 1;
            gv_KQTimDV.Columns["GIASP"].DisplayIndex = 2;
            gv_KQTimDV.Columns["check"].DisplayIndex = 3;
            gv_KQTimDV.Columns["MASP"].Visible = false;
            gv_KQTimDV.Columns["LOAISP"].Visible = false;
            gv_KQTimDV.Columns["DONVI"].Visible = false;
            gv_KQTimDV.Columns["THONGTINSP"].Visible = false;



            for (int i = 0; i < gv_KQTimDV.RowCount - 1; i++)
            {
                gv_KQTimDV.Rows[i].Cells[0].Value = i + 1;
            }

            DataTable DVDT = new DataTable();
            DataColumn col;



            col = new DataColumn();
            col.DataType = typeof(int);
            col.ColumnName = "MATT";

            col.ReadOnly = true;

            //col.Unique = true;
            DVDT.Columns.Add(col);


            col = new DataColumn();
            col.DataType = typeof(int);
            col.ColumnName = "MASP";
            col.ReadOnly = true;
            //col.Unique = true;
            DVDT.Columns.Add(col);

            col = new DataColumn();
            col.DataType = typeof(int);
            col.ColumnName = "MADVCT";
            col.ReadOnly = true;
            //col.Unique = true;
            DVDT.Columns.Add(col);

            col = new DataColumn();
            col.DataType = typeof(string);
            col.ColumnName = "TENDV";
            col.ReadOnly = true;
            //col.Unique = true;
            DVDT.Columns.Add(col);

            col = new DataColumn();
            col.DataType = typeof(int);
            col.ColumnName = "MAHD";
            col.ReadOnly = true;
            //col.Unique = true;
            DVDT.Columns.Add(col);

            col = new DataColumn();
            col.DataType = typeof(int);
            col.ColumnName = "GIATHANH";
            col.ReadOnly = true;
            //col.Unique = true;
            DVDT.Columns.Add(col);

            col = new DataColumn();
            col.DataType = typeof(int);
            col.ColumnName = "SOLUONG";
            //col.ReadOnly = true;
            //col.Unique = true;
            DVDT.Columns.Add(col);

            col = new DataColumn();
            col.DataType = typeof(int);
            col.ColumnName = "GIAMGIA";
            //col.ReadOnly = true;
            //col.Unique = true;
            DVDT.Columns.Add(col);

            col = new DataColumn();
            col.DataType = typeof(int);
            col.ColumnName = "MAKH";
            col.ReadOnly = true;
            //col.Unique = true;
            DVDT.Columns.Add(col);

            col = new DataColumn();
            col.DataType = typeof(string);
            col.ColumnName = "TENNGUOIDK";
            col.ReadOnly = true;
            //col.Unique = true;
            DVDT.Columns.Add(col);
            gv_DichVuDaThem.DataSource = DVDT;
            gv_DichVuDaThem.Columns["sttdv"].ReadOnly = true;
            gv_DichVuDaThem.Columns["MATT"].Visible = false;
            gv_DichVuDaThem.Columns["MASP"].Visible = false;
            gv_DichVuDaThem.Columns["MADVCT"].Visible = false;
            gv_DichVuDaThem.Columns["MAHD"].Visible = false;
            gv_DichVuDaThem.Columns["MAKH"].Visible = false;
            gv_DichVuDaThem.Columns["sttdv"].DisplayIndex = 0;
            gv_DichVuDaThem.Columns["TENDV"].DisplayIndex = 1;
            gv_DichVuDaThem.Columns["SOLUONG"].DisplayIndex = 2;
            gv_DichVuDaThem.Columns["GIATHANH"].DisplayIndex = 3;
            gv_DichVuDaThem.Columns["GIAMGIA"].DisplayIndex = 4;
            gv_DichVuDaThem.Columns["TENNGUOIDK"].DisplayIndex = 5;
            gv_DichVuDaThem.Columns["checkbox"].DisplayIndex = 6;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_TroVe_Clicked(object sender, EventArgs e)
        {
            QLKS.Forms.DichVuChitiet DVCT = new QLKS.Forms.DichVuChitiet(MADVCT);
            Application.OpenForms["ThemDichVu"].Close();
            DVCT.Show();

        }

        private void btn_Tim_Clicked(object sender, EventArgs e)
        {
            string ten = txt_TenDV.Text.ToString();
           
                gv_KQTimDV.DataSource = QLKS.Class.SANPHAMDICHVU.LAYDSSP(txt_TenDV.Text.ToString());

            for (int i = 0; i < gv_KQTimDV.RowCount; i++)
            {
                gv_KQTimDV.Rows[i].Cells[0].Value = i + 1;
            }

        }

        private void btn_Them_Clicked(object sender, EventArgs e)
        {
            DataTable DVDT;
            DVDT = (DataTable)gv_DichVuDaThem.DataSource;

            for (int i = 0; i < gv_KQTimDV.Rows.Count; i++)
            {

                if (Convert.ToBoolean(gv_KQTimDV.Rows[i].Cells[1].Value))
                {
                    DataRow row;
                    row = DVDT.NewRow();
                    row["MASP"] = gv_KQTimDV.Rows[i].Cells[2].Value;
                    row["TENDV"] = gv_KQTimDV.Rows[i].Cells[3].Value;
                    row["MADVCT"] = MADVCT;
                    row["GIATHANH"] = gv_KQTimDV.Rows[i].Cells[5].Value;
                    row["SOLUONG"] = 1;
                    row["GIAMGIA"] = 0;
                    row["MAKH"] = ((System.Data.DataRowView)(cbb_NguoiDK.SelectedItem))["MAKHCN"];
                    row["TENNGUOIDK"] = ((System.Data.DataRowView)(cbb_NguoiDK.SelectedItem))["TENKHCN"];


                    DVDT.Rows.Add(row);

                }
            }

            gv_DichVuDaThem.DataSource = DVDT;

            for (int i = 0; i < gv_DichVuDaThem.RowCount - 1; i++)
            {
                gv_DichVuDaThem.Rows[i].Cells[0].Value = i + 1;

            }
            gv_DichVuDaThem.Columns["sttdv"].DisplayIndex = 0;
            gv_DichVuDaThem.Columns["TENDV"].DisplayIndex = 1;
            gv_DichVuDaThem.Columns["SOLUONG"].DisplayIndex = 2;
            gv_DichVuDaThem.Columns["GIATHANH"].DisplayIndex = 3;
            gv_DichVuDaThem.Columns["GIAMGIA"].DisplayIndex = 4;
            gv_DichVuDaThem.Columns["TENNGUOIDK"].DisplayIndex = 5;
            gv_DichVuDaThem.Columns["checkbox"].DisplayIndex = 6;
            CapNhatManHinh();



        }

        private void btn_Xoa_Clicked(object sender, EventArgs e)
        {
            for (int i = gv_DichVuDaThem.RowCount - 1; i >= 0; i--)
            {
                if (Convert.ToBoolean(gv_DichVuDaThem.Rows[i].Cells[gv_DichVuDaThem.Columns["checkbox"].Index].Value))
                {
                    gv_DichVuDaThem.Rows.RemoveAt(i);
                }
            }

            for (int i = 0; i < gv_DichVuDaThem.RowCount - 1; i++)
            {
                gv_DichVuDaThem.Rows[i].Cells[0].Value = i + 1;


            }
            CapNhatManHinh();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gv_DichVuDaThem.RowCount - 1; i++)
            {
                int MASP = Convert.ToInt32(gv_DichVuDaThem.Rows[i].Cells[gv_DichVuDaThem.Columns["MASP"].Index].Value.ToString());
                int MALSDP = Convert.ToInt32(gv_DichVuDaThem.Rows[i].Cells[gv_DichVuDaThem.Columns["MADVCT"].Index].Value.ToString());
                int GIATHANH = Convert.ToInt32(gv_DichVuDaThem.Rows[i].Cells[gv_DichVuDaThem.Columns["GIATHANH"].Index].Value.ToString());
                int SOLUONG = Convert.ToInt32(gv_DichVuDaThem.Rows[i].Cells[gv_DichVuDaThem.Columns["SOLUONG"].Index].Value.ToString());
                int GIAMGIA = Convert.ToInt32(gv_DichVuDaThem.Rows[i].Cells[gv_DichVuDaThem.Columns["GIAMGIA"].Index].Value.ToString());
                int MANGUOIDK = Convert.ToInt32(gv_DichVuDaThem.Rows[i].Cells[gv_DichVuDaThem.Columns["MAKH"].Index].Value.ToString());
                QLKS.Class.ThongTinSuDungDichVu kq = new QLKS.Class.ThongTinSuDungDichVu(MASP, MALSDP, GIATHANH, SOLUONG, GIAMGIA, MANGUOIDK);
                kq.ThemTTSDDV();

                
            }
            QLKS.Forms.DichVuChitiet DVCT = new QLKS.Forms.DichVuChitiet(MADVCT);
            Application.OpenForms["ThemDichVu"].Close();
            DVCT.Show();
        }

        private void gv_DVDT_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)gv_DichVuDaThem.DataSource;
            if (gv_DichVuDaThem.Columns["GIAMGIA"] != null && e.ColumnIndex == gv_DichVuDaThem.Columns["GIAMGIA"].Index)
            {
                if (ThongTinSuDungDichVu.KTGIAMGIA(Convert.ToInt32(gv_DichVuDaThem.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())))                {
                    dt.AcceptChanges();
                    CapNhatManHinh();
                }
                else
                    dt.RejectChanges();
            }
            if (gv_DichVuDaThem.Columns["SOLUONG"] != null && e.ColumnIndex == gv_DichVuDaThem.Columns["SOLUONG"].Index)
            {
                if ( ThongTinSuDungDichVu.KTSL(Convert.ToInt32(gv_DichVuDaThem.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())))
                   {
                    dt.AcceptChanges();
                    CapNhatManHinh();
                }
                else
                    dt.RejectChanges();
            }
        }
    }
}
