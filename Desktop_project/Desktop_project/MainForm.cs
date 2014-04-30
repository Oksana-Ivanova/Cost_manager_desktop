using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenOutLaysWindow()
        {
            this.Hide();
            OutlaysForm form = new OutlaysForm();
            form.Show();
        }

        private void buttonMore_Click(object sender, EventArgs e)
        {
            OpenOutLaysWindow();
        }

        private void buttonExamine_Click(object sender, EventArgs e)
        {
            OpenOutLaysWindow();
        }

        private void buttonExamine2_Click(object sender, EventArgs e)
        {
            OpenOutLaysWindow();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelTotalPerWeek.Text = "";
            labelCategoryName.Text = "";
            labelWeekOutlay.Text = "";
            labelCategoryName2.Text = "";
            labelWeekOutlay2.Text = "";

        }

   }
}
