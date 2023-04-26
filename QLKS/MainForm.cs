using System;
using System.Data;
using System.Windows.Forms;

namespace QLKS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            datPhongControl = new();
            datPhongControl.LoadData();
            datPhongControl.Dock = DockStyle.Fill;
            tabPageDatPhong.Controls.Add(datPhongControl);
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}