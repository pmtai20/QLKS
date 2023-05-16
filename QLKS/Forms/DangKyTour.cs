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
    public partial class DangKyTour : Form
    {
        private DataTable NTG;
        public DangKyTour()
        {

            InitializeComponent();
        }
        public void CapNhatDSTG(DataTable nTG)
        {


            gv_ThamGia.DataSource = nTG;
            gv_ThamGia.Columns["MAKHCN"].Visible = false;
            gv_ThamGia.Columns["DIACHI"].Visible = false;
            gv_ThamGia.Columns["MADOAN"].Visible = false;
            for (int i = 0; i < gv_ThamGia.RowCount - 1; i++)
            {
                gv_ThamGia.Rows[i].Cells[0].Value = i + 1;
            }
            txt_SoLuong.Text = (gv_ThamGia.RowCount - 1).ToString();
        }
        private void DangKyTour_Load(object sender, EventArgs e)
        {

        }

        private void btn_ChinhSua_Clicked(object sender, EventArgs e)
        {
            QLKS.Forms.ChinhSuaNTG NTG = new QLKS.Forms.ChinhSuaNTG();
            this.Hide();
            NTG.Show();
        }

        private void btn_TroVe_Clicked(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["MainForm"].Show();
        }
    }
}
