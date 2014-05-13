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
        const string host = "127.0.0.1";
        const string database = "heroku_9e3361f1a2a704a";
        const string user = "root";
        const string password = "123";

        DBHandler controller = new DBHandler(host, database, user, password);
    
        private void fillDateBoundsByPeriod()
        {
            switch ((PeriodMode)cboPeriod.SelectedIndex)
            {
                case PeriodMode.LastWeek:
                    dateTimePickerStart.Value = dateTimePickerEnd.Value.AddDays(-6);
                    get_incomes_by_selected_period();
                    break;
                case PeriodMode.LastMonth:
                    dateTimePickerStart.Value = dateTimePickerEnd.Value.AddMonths(-1);
                    get_incomes_by_selected_period();
                    break;
                case PeriodMode.LastYear:
                    dateTimePickerStart.Value = dateTimePickerEnd.Value.AddYears(-1);
                    get_incomes_by_selected_period();
                    break;
                default:
                    break;
            }
        }
        private void get_incomes_by_selected_period()
        {
            DateTime period_begin_date = Convert.ToDateTime(dateTimePickerStart.Value);
            DateTime period_end_date = Convert.ToDateTime(dateTimePickerEnd.Value);          
         
            DataSet ds = new DataSet();
            ds = controller.getAllIncomesBySelectedPeriod( period_begin_date, period_end_date);
            dataGridViewIncomes.DataSource = ds.Tables["incomes"];     
          

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

        private void dataGridViewIncomes_ColumnAdded(Object sender, DataGridViewColumnEventArgs e)
        {
            if (dataGridViewIncomes.Columns.Contains("updated_at"))
            {
                try
                {
                    this.dataGridViewIncomes.Columns["id"].Visible = false;
                    this.dataGridViewIncomes.Columns["user_id"].Visible = false;                    
                    //   this.dataGridViewIncomes.Columns["created_at"].Visible = false;
                    this.dataGridViewIncomes.Columns["updated_at"].Visible = false;
                    this.dataGridViewIncomes.Columns["name"].HeaderText = "Назва доходу";
                    this.dataGridViewIncomes.Columns["description"].HeaderText = "Нотатки";
                    this.dataGridViewIncomes.Columns["price"].HeaderText = " сумма доходу";
                    this.dataGridViewIncomes.Columns["created_at"].HeaderText = "Дата";
                }

                catch { }
            }
        }

        private void dataGridViewIncomes_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        
        }
     
    }
}