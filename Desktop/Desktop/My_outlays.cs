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
    public partial class My_outlays : Form
    {
        public My_outlays()
        {
            InitializeComponent();
            comboBox3.Text = "Chart";
            comboBox1.Text = "Yesterday";
            comboBox2.Text = "Any";
            
        }

        private void panel_table_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Table") { panel_table.Visible = true; panel_chart.Visible = false; }
            else if (comboBox3.Text == "Chart")
            {
                panel_table.Visible = false; panel_chart.Visible = true; 
                double x = 0;
                for (int i = 0; i < 4; i++)
                {
                    chart_outlays.Series[0].Points.AddXY(x, Math.Sin(x));
                    x += i;
                }
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Custom") { panel_custom_date.Visible = true; }
            else panel_custom_date.Visible = false;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value) { MessageBox.Show("Error in date!"); }
        }

        private void chart_outlays_Click(object sender, EventArgs e)
        {

        }

        private void button_new_cost_Click(object sender, EventArgs e)
        {
            New_cost_form CostForm = new New_cost_form();
            CostForm.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chart_outlays_Click_1(object sender, EventArgs e)
        {

        }

        private void panel_chart_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
