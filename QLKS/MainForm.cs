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

        public void LoadData()
        {
            TimPhongControl.LoadData();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}