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
        private enum PeriodMode
        {
            LastWeek    = 0,
            LastMonth   = 1,
            LastYear    = 2,
            Custom      = 3
        };
        
        private void initControls()
        {
            cboPeriod.SelectedIndex = (int)PeriodMode.LastWeek;

            dateTimePickerStart.MinDate = DateTime.Today.AddYears(-5);
            dateTimePickerStart.MaxDate = DateTime.Today;
            dateTimePickerEnd.MinDate = DateTime.Today.AddYears(-5);
            dateTimePickerEnd.MaxDate = DateTime.Today;
        }

        private void fillDateBoundsByPeriod()
        {
            switch ((PeriodMode)cboPeriod.SelectedIndex)
            {
                case PeriodMode.LastWeek:
                    dateTimePickerStart.Value = dateTimePickerEnd.Value.AddDays(-7);
                    break;
                case PeriodMode.LastMonth:
                    dateTimePickerStart.Value = dateTimePickerEnd.Value.AddMonths(-1);
                    break;
                case PeriodMode.LastYear:
                    dateTimePickerStart.Value = dateTimePickerEnd.Value.AddYears(-1);
                    break;
                default:
                    break;
            }
        }

        public Incomes()
        {
            InitializeComponent();

            initControls();
        }

        private void comboBoxPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPeriod.SelectedIndex == (int)PeriodMode.Custom)
            {
                panelCustomDate.Enabled = true; 
            }
            else
            {
                panelCustomDate.Enabled = false; 
            }

            fillDateBoundsByPeriod();
        }
       
        private void buttonNewIncome_Click(object sender, EventArgs e)
        {
            New_Incomes newIncomeWindow = new New_Incomes();
            newIncomeWindow.Show();
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerStart.MaxDate = dateTimePickerEnd.Value;
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerEnd.MinDate = dateTimePickerStart.Value;           
        }

        private void dataGridViewIncomes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
            
    }
}