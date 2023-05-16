using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.UserControls
{
    public partial class TourControl : UserControl
    {
        public TourControl()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TourControl_Load(object sender, EventArgs e)
        {

        }

        private void btn_Tao_Clicked(object sender, EventArgs e)
        {
            QLKS.Forms.DangKyTour DKT = new QLKS.Forms.DangKyTour();
            Application.OpenForms["MainForm"].Hide();
            DKT.Show();
        }
    }
}
