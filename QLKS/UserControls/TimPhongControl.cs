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
            LoadData();
        }

        public void LoadData()
        {
            // Query the Rooms table and store the results in a DataTable
            string query = "SELECT * FROM Room";
            DataTable dataTable = DataAccess.ExecuteQuery(query);

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dataTable;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CheckOutForm checkoutform = new CheckOutForm();
            checkoutform.LoadData();
            checkoutform.ShowDialog();
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
