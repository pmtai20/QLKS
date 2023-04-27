using QLKS.UserControls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QLKS.Forms
{
    public partial class CheckOutForm : Form
    {
        public CheckOutForm()
        {
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;
            this.Location = new Point(0, 0);
            InitializeComponent();
        }

        private void CheckOutForm_Load(object sender, EventArgs e)
        {
        }
        public void LoadData()
        {
            // Query the Rooms table and store the results in a DataTable
            string query = "SELECT * FROM Room";
            DataTable dataTable = DataAccess.ExecuteQuery(query);

            // Bind the DataTable to the DataGridView
            dataPhong.DataSource = dataTable;
            dataKH.DataSource = dataTable;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dataPhong.Rows[e.RowIndex].Cells[e.ColumnIndex];
            string newValue = cell.Value.ToString();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DSPhong_Enter(object sender, EventArgs e)
        {

        }

        private void dataPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DSKhachHang_Enter(object sender, EventArgs e)
        {
        }

        private void dataKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void timKiem_Enter(object sender, EventArgs e)
        {
        }

        private void ngayDi_ValueChanged(object sender, EventArgs e)
        {
        }

        private void ngayDen_ValueChanged(object sender, EventArgs e)
        {
        }

        private void timTen_Click(object sender, EventArgs e)
        {
        }

        private void timPhong_Click(object sender, EventArgs e)
        {
        }

        private void textKH_TextChanged(object sender, EventArgs e)
        {
        }

        private void textPhong_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void thanhToan_Click(object sender, EventArgs e)
        {
            ThanhToanControl thanhToanControl = new ThanhToanControl();
            thanhToanControl.LoadData();
            this.Controls.Clear();
            this.Controls.Add(thanhToanControl);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
