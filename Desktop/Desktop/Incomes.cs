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
    public partial class Incomes : Form
    {
        public Incomes()
        {
            InitializeComponent();
            //comboBoxPeriod.Text = "Yesterday";

        }

        private void comboBoxPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxPeriod.Text)
            {
                case "Custom": 
                    panel_custom_date.Visible = true; 
                    break;
                case "Yesterday":
                    panel_custom_date.Visible = false; 
                    //change chart;
                    break;
                default: comboBoxPeriod.Text = "Yesterday"; break;

            }
       
        }

     

        private void button_ok_Click(object sender, EventArgs e)
        {

        }

       
        private void buttonNewIncome_Click(object sender, EventArgs e)
        {
            New_Incomes new_inc = new New_Incomes();
            new_inc.Show();

        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
        
            if (dateTimePickerStart.Value > dateTimePickerEnd.Value) 
            {
                dateTimePickerEnd.Value=DateTime.Now;
                dateTimePickerStart.Value = DateTime.Now;
                MessageBox.Show("Error in date!"); 
                
            }
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
           
        }

      

    }
}