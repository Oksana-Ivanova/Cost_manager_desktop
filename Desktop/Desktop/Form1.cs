using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class Main : Form
    {
        
        public Main()
        {
            //LoginForm Loginform = new LoginForm();
            //Loginform.Close();
            InitializeComponent();
            double x = 0;
            for (int i = 0; i < 4; i++)
            {
                chart_recent_cost.Series[0].Points.AddXY(x, Math.Sin(x));
                x += i;
            }

           // if (!loginForm.Visible) { loginForm.Close(); }
        }
        LoginForm loginForm = new LoginForm();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void viewOutlaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My_outlays outlays_form = new My_outlays();
            outlays_form.ShowDialog();
        }

        private void viewIncomesToolStripMenuItem_Click(object sender, EventArgs e)
        {
 Incomes inc_form = new Incomes();
            inc_form.ShowDialog();
        }

        private void newIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Incomes new_inc = new New_Incomes();
            new_inc.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // this.Close();
            Application.Exit();
        }

        private void chart_recent_cost_Click(object sender, EventArgs e)
        {
            
        }

        private void newCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_cost_form CostForm = new New_cost_form();
            CostForm.ShowDialog();
        }

        private void newCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Category_Form CategoryForm = new New_Category_Form();
            CategoryForm.ShowDialog();
        }

        private void viewLimitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limits_Form LimitForm = new Limits_Form();
            LimitForm.ShowDialog();
        }

        private void buttonDetailedOutlays_Click(object sender, EventArgs e)
        {
            My_outlays outlaysForm = new My_outlays();
            outlaysForm.ShowDialog();
        }

        private void buttonDetalisedIncomes_Click(object sender, EventArgs e)
        {
            Incomes incomesForm = new Incomes();
            incomesForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox AboutBoxForm = new AboutBox();
            AboutBoxForm.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Application.Exit();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

       

    
    }
}
