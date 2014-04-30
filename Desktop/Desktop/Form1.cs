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
            InitializeComponent();
            double x = 0;
            for (int i = 0; i < 4; i++)
            {
                chart_recent_cost.Series[0].Points.AddXY(x, Math.Sin(x));
                x += i;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void viewOutlaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My_outlays outlays_form = new My_outlays();
            outlays_form.Show();
        }

        private void viewIncomesToolStripMenuItem_Click(object sender, EventArgs e)
        {
 Incomes inc_form = new Incomes();
            inc_form.Show();
        }

        private void newIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Incomes new_inc = new New_Incomes();
            new_inc.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chart_recent_cost_Click(object sender, EventArgs e)
        {
            
        }

    
    }
}
