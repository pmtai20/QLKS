using System;
using System.Data;
using System.Windows.Forms;

namespace QLKS
{
    public partial class DatPhongControl : UserControl
    {
        public DatPhongControl()
        {
            InitializeComponent();
        }

        private void DatPhongControl_Load(object sender, EventArgs e)
        {
          
        }
        public void LoadData()
        {
            // Query the Rooms table and store the results in a DataTable
            string query = "SELECT * FROM Room";
            DataTable dataTable = DataAccess.ExecuteQuery(query);

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dataTable;
        }
    }
}
