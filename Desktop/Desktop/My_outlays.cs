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
            comboBoxViewAs.Text = "Chart";
        }

        private void panel_table_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxViewAs.Text == "Table") { panel_table.Visible = true; panel_chart.Visible = false; }
            else if (comboBoxViewAs.Text == "Chart") { panel_table.Visible = false; panel_chart.Visible = true; }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Custom") { panel_custom_date.Visible = true; }
            else panel_custom_date.Visible = false;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerStart.Value > dateTimePickerEnd.Value) { MessageBox.Show("Error in date!"); }
        }


    }
}
