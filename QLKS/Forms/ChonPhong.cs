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
    public partial class ChonPhong : Form
    {
        public ChonPhong()
        {
            InitializeComponent();
            gv_Phong.ReadOnly = true;
        }

        private void ChonPhong_Load(object sender, EventArgs e)
        {
            gv_Phong.DataSource = QLKS.Class.LichSuDungPhong.LAYLSDPHOPLE();

        }

        private void gv_Phong_cellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gv_Phong.Rows.Count - 1 && e.ColumnIndex >= 0 && e.ColumnIndex < gv_Phong.Columns.Count)
            {


                QLKS.Forms.ChinhSuaNTG NTG = (QLKS.Forms.ChinhSuaNTG)Application.OpenForms["ChinhSuaNTG"];
                NTG.capnhatLSDP(Convert.ToInt32(gv_Phong.Rows[e.RowIndex].Cells[0].Value.ToString()));
               
                this.Close();
                NTG.Show();
         
                //  DVCT.Show();

            }
        }

        private void btn_Tim_Clicked(object sender, EventArgs e)
        {
            DataTable table = QLKS.Class.LichSuDungPhong.LAYLSDPHOPLE(txt_TenPhong.Text.ToString());
            gv_Phong.DataSource = table;
        }
    }

}
