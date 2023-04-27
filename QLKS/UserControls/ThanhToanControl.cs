using QLKS.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLKS.UserControls
{
    public partial class ThanhToanControl : UserControl
    {
        public ThanhToanControl()
        {
            InitializeComponent();
        }

        private void ThanhToanControl_Load(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            // Query the Rooms table and store the results in a DataTable
            string query = "SELECT * FROM Room";
            DataTable dataTable = DataAccess.ExecuteQuery(query);

            // Bind the DataTable to the DataGridView
            dataDV.DataSource = dataTable;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tienPhong_Click(object sender, EventArgs e)
        {

        }

        private void tongTIen_Click(object sender, EventArgs e)
        {

        }

        private void thoat_Click(object sender, EventArgs e)
        {

        }
    }
}
