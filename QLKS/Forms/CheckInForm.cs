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
    public partial class CheckInForm : Form
    {
        private string madp;

        public CheckInForm(string madp)
        {
            this.madp = madp;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThemDoanKhachForm ThemDoanKhachForm = new ThemDoanKhachForm();

            ThemDoanKhachForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Check-in
                string query = "UPDATE DATPHONG SET TRANGTHAI = 'check in' WHERE madp = '" + madp + "'";
                Console.WriteLine("Query: " + query); // Print the query for debugging

                DataAccess.ExecuteNonQuery(query);

                // Notification on success
                MessageBox.Show("Check-in successful.");

                // Reload data
                DataAccess.LoadData();
            }
            catch (Exception ex)
            {
                // Handle the exception (display error message, log, etc.)
                MessageBox.Show("Error occurred during check-in: " + ex.Message);
            }
        }

        private void CheckInForm_Load(object sender, EventArgs e)
        {
            label2.Text = madp;
        }
    }
}
