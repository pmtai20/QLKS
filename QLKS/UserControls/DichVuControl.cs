using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLKS.UserControls
{
    public partial class DichVuControl : UserControl
    {
        
        public DichVuControl()
        {
            InitializeComponent();
           
            


            // DataTable table = new DataTable(); adapter.Fill(table);
            // gv_Phong.DataSource = table;
            
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Tim_Clicked(object sender, EventArgs e)
        {
            DataTable table = QLKS.Class.LichSuDungPhong.LAYLSDPHOPLE(txt_TenPhong.Text.ToString()); 
            gv_Phong.DataSource = table;
            
        }

        private void MH_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            DataRow row;
            gv_Phong.DataSource = QLKS.Class.LichSuDungPhong.LAYLSDPHOPLE();
            Application.OpenForms["MainForm"].Show();
        }

        private void gv_Phong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0 && e.RowIndex< gv_Phong.Rows.Count-1 && e.ColumnIndex>=0 &&e.ColumnIndex<gv_Phong.Columns.Count)
               {

                
                    Application.OpenForms["MainForm"].Hide();
                    QLKS.Forms.DichVuChitiet DVCT = new QLKS.Forms.DichVuChitiet(Convert.ToInt32(gv_Phong.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    DVCT.Show();
                
            }
        }
    }
}
