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

            initControls();
             double x = 0;
                for (int i = 0; i < 4; i++)
                {
                    chart_outlays.Series[0].Points.AddXY(DateTime.Today.AddDays(-4+i),x );
                    x += i;
                }
            
        }

        const string host = "127.0.0.1";
        const string database = "heroku_9e3361f1a2a704a";
        const string user = "root";
        const string password = "123";

        DBHandler controller = new DBHandler(host, database, user, password);
        BindingSource outlays_binding = new BindingSource();
        SqlFunction connect = new SqlFunction(host, database, user, password);

        private enum PeriodMode
        {
            LastWeek = 0,
            LastMonth = 1,
            LastYear = 2,
            Custom = 3
        };
        private enum ViewMode
        {
            Chart = 0,
            Table = 1
        };

        private void initCategoriesComboData()
        {
            List<CostType> categoryName = new List<CostType>();
            categoryName = controller.getCategorysByUserID(LoginForm.user_ID);
            CostType tempObject = new CostType();
            categoryName.Add(new CostType(tempObject.Id = "", tempObject.Name = "Any", tempObject.CreateDate = DateTime.Today, tempObject.UpdateDate = DateTime.Today));

            outlays_binding.DataSource = categoryName;
            cboCategory.DataSource = outlays_binding.DataSource;
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "Name";
        }

        private void initControls()
        {
            cboPeriod.SelectedIndex = (int)PeriodMode.LastWeek;

            dateTimePickerStart.MinDate = DateTime.Today.AddYears(-5);
            dateTimePickerStart.MaxDate = DateTime.Today;
            dateTimePickerEnd.MinDate = DateTime.Today.AddYears(-5);
            dateTimePickerEnd.MaxDate = DateTime.Today;

            initCategoriesComboData();
            cboCategory.SelectedIndex = 0;

            cboViewAs.SelectedIndex = 0;

            panelChart.Visible = true;
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
   
        private void comboBoxViewAs_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((ViewMode)cboViewAs.SelectedIndex) 
            {
                case ViewMode.Chart:
                    panelTable.Visible = false; 
                    panelChart.Visible = true;
                    break;
                case ViewMode.Table:
                    panelChart.Visible = false; 
                    panelTable.Visible = true;
                    break;
                default:
                    panelChart.Visible = false;
                    panelTable.Visible = true;
                    break;
            } 
        }
        
        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerStart.MaxDate = dateTimePickerEnd.Value;
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerEnd.MinDate = dateTimePickerStart.Value;     
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoryName = cboCategory.Text;    //     dataGridViewOutlays begin
           string cost_type_id = controller.getCategoryByNameAndUserID(categoryName).Id;
                   // MessageBox.Show(connectionString);
            DataSet ds = new DataSet();
            ds = controller.getAllCosts(cost_type_id);
          
            dataGridViewOutlays.DataSource = ds.Tables["costs"]; // ataGridViewOutlays end     
            draw_chart_outlays(cost_type_id);

        }

        private void btnNewCost_Click(object sender, EventArgs e)
        {
            New_cost_form newCostForm = new New_cost_form();
            newCostForm.Show();
        }

        public void draw_chart_outlays(string cost_type_id)
        {
           
            int i = 0;
            int type_of_period = 1;
            int number_of_periods = 4;
            chart_outlays.Series[0].Points.Clear();
            string Date;
            do
            {
                Date = secondary_methods.date_transform_to_sql_date(DateTime.UtcNow.ToString(), 9);
                MessageBox.Show(Convert.ToDateTime(Date).ToString());
                double costs_sum_from_period = 0;
                costs_sum_from_period = controller.get_sum_from_cost_by_date_and_cost_type_id(cost_type_id, Date);

                chart_outlays.Series[0].Points.AddXY(DateTime.UtcNow.AddDays(number_of_periods - i), costs_sum_from_period);
                i++;
            }
            while (i < number_of_periods);
        }
        private void dataGridViewOutlays_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewOutlays_ColumnAdded(Object sender, DataGridViewColumnEventArgs e)
        {
            if (dataGridViewOutlays.Columns.Contains("updated_at"))
            {
                try
                {
                    this.dataGridViewOutlays.Columns["id"].Visible = false;
                    this.dataGridViewOutlays.Columns["user_id"].Visible = false;
                    this.dataGridViewOutlays.Columns["cost_type_id"].Visible = false;
                    this.dataGridViewOutlays.Columns["created_at"].Visible = false;
                    this.dataGridViewOutlays.Columns["updated_at"].Visible = false;
                    this.dataGridViewOutlays.Columns["name"].HeaderText = "Назва витрати";
                    this.dataGridViewOutlays.Columns["description"].HeaderText = "Нотатки";
                    this.dataGridViewOutlays.Columns["price"].HeaderText = "затрачена сумма";
                }

                catch { }
            }
        }
              
    }
}
