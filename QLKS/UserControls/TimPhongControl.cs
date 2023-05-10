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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            string query = "SELECT MADP, TENKH, NGAYNHAN, NGAYTRA, NGAYDATPHONG, LOAIPHONG, TRANGTHAI FROM DATPHONG JOIN KHACHHANG ON DATPHONG.MAKH = KHACHHANG.MAKH";
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




        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                // Get the row index of the selected cell
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                // In case drop last empty row 
                if (rowIndex == dataGridView1.RowCount - 1) return;
                // Retrieve the user ID from the selected row
                string madp = dataGridView1.Rows[rowIndex].Cells["madp"].Value.ToString();


                CheckInForm CapNhatTrangThaiPhongForm = new CheckInForm(madp);
                if (CapNhatTrangThaiPhongForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else
            {
                MessageBox.Show("Please select a cell to view role info.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource is DataTable dataTable)
            {
                // Get the entered text from the TextBox
                string filterText = textBox1.Text.Trim();

                // Set the RowFilter property of the DataTable to filter the data by username
                if (!string.IsNullOrEmpty(filterText))
                {
                    dataTable.DefaultView.RowFilter = string.Format("TENKH LIKE '%{0}%'", filterText);
                }
                else
                {
                    dataTable.DefaultView.RowFilter = string.Empty;
                }

                // Refresh the DataGridView to show the filtered data
                dataGridView1.Refresh();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource is DataTable dataTable)
            {
                // Get the entered text from TextBox2
                string filterText = textBox2.Text.Trim();

                // Set the RowFilter property of the DataTable to filter the data by madp
                if (!string.IsNullOrEmpty(filterText))
                {
                    dataTable.DefaultView.RowFilter = string.Format("MADP LIKE '%{0}%'", filterText);
                }
                else
                {
                    dataTable.DefaultView.RowFilter = string.Empty;
                }

                // Refresh the DataGridView to show the filtered data
                dataGridView1.Refresh();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource is DataTable dataTable)
            {
                // Get the selected item from ComboBox2
                string selectedStatus = comboBox2.SelectedItem.ToString();

                // Set the RowFilter property of the DataTable to filter the data by trangthai
                if (!string.IsNullOrEmpty(selectedStatus) && selectedStatus != "all")
                {
                    dataTable.DefaultView.RowFilter = string.Format("TRANGTHAI LIKE '%{0}%'", selectedStatus);
                }
                else
                {
                    dataTable.DefaultView.RowFilter = string.Empty;
                }

                // Refresh the DataGridView to show the filtered data
                dataGridView1.Refresh();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource is DataTable dataTable)
            {
                // Get the selected date from DateTimePicker1
                DateTime selectedDate = dateTimePicker1.Value;

                // Set the RowFilter property of the DataTable to filter the data by ngaynhan greater than or equal to selected date
                dataTable.DefaultView.RowFilter = string.Format("NGAYNHAN >= #{0}#", selectedDate.ToString("yyyy-MM-dd"));

                // Refresh the DataGridView to show the filtered data
                dataGridView1.Refresh();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource is DataTable dataTable)
            {
                // Get the selected date from DateTimePicker2
                DateTime selectedDate = dateTimePicker2.Value;

                // Set the RowFilter property of the DataTable to filter the data by ngaytra less than or equal to selected date
                dataTable.DefaultView.RowFilter = string.Format("NGAYTRA <= #{0}#", selectedDate.ToString("yyyy-MM-dd"));

                // Refresh the DataGridView to show the filtered data
                dataGridView1.Refresh();
            }
        }


    }
}
