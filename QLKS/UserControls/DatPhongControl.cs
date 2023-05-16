using System;
using System.Data;
using System.Windows.Forms;

namespace QLKS.UserControls
{
    public partial class DatPhongControl : UserControl
    {
        public DatPhongControl()
        {
            InitializeComponent();
        }

        private void DatPhongControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            // Query the Rooms table and store the results in a DataTable
            string query = "SELECT * FROM PHONG";
            DataTable dataTable = DataAccess.ExecuteQuery(query);

            // Bind the DataTable to the DataGridView
            dvgDSPT.DataSource = dataTable;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
