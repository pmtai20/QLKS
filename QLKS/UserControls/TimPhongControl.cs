using QLKS.Forms;
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
    public partial class TimPhongControl : UserControl
    {
        public TimPhongControl()
        {
            InitializeComponent();
        }

        private void TimPhongControl_Load(object sender, EventArgs e)
        {
<<<<<<< refs/remotes/origin/master:QLKS/UserControls/TimPhongControl.cs

=======
            LoadData();
>>>>>>> Create UI ControlUser DP, PDP:QLKS/UserControls/DatPhongControl.cs
        }

        public void LoadData()
        {
            // Query the Rooms table and store the results in a DataTable
            string query = "SELECT * FROM Room";
            DataTable dataTable = DataAccess.ExecuteQuery(query);

            // Bind the DataTable to the DataGridView
            dvgDSPT.DataSource = dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckInForm CapNhatTrangThaiPhongForm = new CheckInForm();
            CapNhatTrangThaiPhongForm.Show();
        }
    }
}
