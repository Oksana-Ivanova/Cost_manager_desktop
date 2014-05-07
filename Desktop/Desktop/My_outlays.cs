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
            comboBoxCategoryOutlays.Text = "Yesterday";
            comboBoxCategory.Text = "Any";
            panel_chart.Visible = true;
             double x = 0;
                for (int i = 0; i < 4; i++)
                {
                    chart_outlays.Series[0].Points.AddXY(x, Math.Sin(x));
                    x += i;
                }
            
        }

    
     
      


        private void button_new_cost_Click(object sender, EventArgs e)
        {
            New_cost_form CostForm = new New_cost_form();
            CostForm.Show();
        }

     

   
   
        private void comboBoxViewAs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxViewAs.Text == "Table") 
            {
                panel_table.Visible = true; 
                panel_chart.Visible = false; 
            }
            if (comboBoxViewAs.Text == "Chart")
            {
                panel_table.Visible = false; panel_chart.Visible = true;
            } 
        }

      


        private void comboBoxCategoryOutlays_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch (comboBoxCategory.Text)
            //{
            //    case "Custom":
            //        panel_custom_date.Visible = true;
            //        break;
            //    case "Yesterday":
            //        panel_custom_date.Visible = false;
            //        //change chart;
            //        break;
            //    // default: comboBoxPeriod.Text = "Yesterday"; break;

            //}
             if (comboBoxCategoryOutlays.Text == "Custom") panel_custom_date.Visible = true;
             else panel_custom_date.Visible = false; 
        }

        private void panel_custom_date_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_new_category_Click(object sender, EventArgs e)
        {
            New_Category_Form categoryForm = new New_Category_Form();
            categoryForm.ShowDialog();
        }

        private void chart_outlays_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerStart.Value > dateTimePickerEnd.Value)
            { dateTimePickerEnd.Value = DateTime.Now;
                dateTimePickerStart.Value = DateTime.Now;
                MessageBox.Show("Error in date!");
               
            }
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {

        }

      

      



      

    }
}
