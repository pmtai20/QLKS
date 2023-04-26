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
        public CheckInForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThemDoanKhachForm ThemDoanKhachForm = new ThemDoanKhachForm();

            ThemDoanKhachForm.Show();
        }

    }
}
