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
    public partial class ThemDoanKhachForm : Form
    {
        public ThemDoanKhachForm()
        {
            InitializeComponent();
        }

        private void ThemDoanKhachForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Them thanh cong!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
