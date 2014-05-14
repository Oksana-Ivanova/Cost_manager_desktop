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

           
             //  period_begin_date = DateTime.Today.AddDays(-6);
            //   period_end_date = DateTime.Today;
            
        }

        const string host = "eu-cdbr-west-01.cleardb.com";
        const string database = "heroku_9e3361f1a2a704a";
        const string user = "b7d511d516e6e4";
        const string password = "e2941bb5";

        DBHandler controller = new DBHandler(host, database, user, password);
        BindingSource outlays_binding = new BindingSource();
        SqlFunction connect = new SqlFunction(host, database, user, password);

       // DateTime period_begin_date;
       // DateTime period_end_date;
       // int number_of_periods;
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
            categoryName = controller.getCategoriesByUserID(LoginForm.user_ID);
            CostType tempObject = new CostType();
            categoryName.Insert(0, new CostType(tempObject.Id = "", tempObject.Name = "Any", tempObject.CreateDate = DateTime.Today, tempObject.UpdateDate = DateTime.Today));
          
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
            dateTimePickerStart.Value = DateTime.Today.AddDays(-6);
            dateTimePickerEnd.MinDate = DateTime.Today.AddYears(-5);
            dateTimePickerEnd.MaxDate = DateTime.Today;
            dateTimePickerEnd.Value = DateTime.Today;

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
                    dateTimePickerStart.Value = dateTimePickerEnd.Value.AddDays(-6);
                    draw_chart_outlays_by_week();                 
                    break;
                case PeriodMode.LastMonth:
                    dateTimePickerStart.Value = dateTimePickerEnd.Value.AddMonths(-1);
                    draw_chart_outlays_by_month();                    
                    break;
                case PeriodMode.LastYear:
                    dateTimePickerStart.Value = dateTimePickerEnd.Value.AddYears(-1);
                    draw_chart_outlays_by_year();                   
                    break;
                case PeriodMode.Custom:
                    draw_chart_outlays_by_custom();
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
            draw_chart_outlays_by_custom();
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerEnd.MinDate = dateTimePickerStart.Value;
            draw_chart_outlays_by_custom();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDateBoundsByPeriod();
                this.dataGridViewOutlays.DataSource = null;
                this.dataGridViewOutlays.Rows.Clear();
                try
                {
                    this.dataGridViewOutlays.Columns.Remove("ColumnEdit");
                }
                catch { }
               // this.dataGridViewOutlays.DataSource = this.GetNewValues();
         
           DateTime period_begin_date = Convert.ToDateTime(dateTimePickerStart.Value);
           DateTime period_end_date = Convert.ToDateTime(dateTimePickerEnd.Value);
            string categoryName = cboCategory.Text;   
           string cost_type_id = controller.getCategoryByNameAndUserID(categoryName).Id;
                   // MessageBox.Show(connectionString);
            DataSet ds = new DataSet();
            ds = controller.getAllCostsBySelectedPeriod(cost_type_id, period_begin_date, period_end_date);
          
            dataGridViewOutlays.DataSource = ds.Tables["costs"]; // ataGridViewOutlays end     
           // draw_chart_outlays(cost_type_id);
            add_column_edit();
            label_sum_for_period.Text = controller.get_sum_from_cost_by_date_and_cost_type_id(cost_type_id, period_begin_date, period_end_date.AddDays(1)).ToString();
        }
        private void add_column_edit()
        {
            System.Windows.Forms.DataGridViewButtonColumn ColumnEdit;
            ColumnEdit = new System.Windows.Forms.DataGridViewButtonColumn();

            ColumnEdit.HeaderText = "";
            ColumnEdit.Name = "ColumnEdit";
            ColumnEdit.ReadOnly = true;
            ColumnEdit.Text = "Edit";
            ColumnEdit.ToolTipText = "Edit";
            ColumnEdit.UseColumnTextForButtonValue = true;
            ColumnEdit.Width = 50;
            ColumnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewOutlays.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    ColumnEdit});
        }

        private void btnNewCost_Click(object sender, EventArgs e)
        {
            New_cost_form newCostForm = new New_cost_form();
            newCostForm.Show();
        }
        private void draw_chart_outlays_by_week()
        {
            DateTime period_begin_date = Convert.ToDateTime(dateTimePickerStart.Value);
            DateTime period_end_date = Convert.ToDateTime(dateTimePickerEnd.Value);
            int number_of_periods = 6;
            chart_outlays.Series[0].Points.Clear();
            chart_outlays.ChartAreas[0].AxisX.Minimum = period_begin_date.ToOADate();
            chart_outlays.ChartAreas[0].AxisX.Maximum = period_end_date.ToOADate();
            chart_outlays.Series[0].Color = Color.YellowGreen;
            chart_outlays.ChartAreas[0].AxisX.Interval = 1;
            period_begin_date = period_begin_date.AddDays(-1);
            period_end_date = period_end_date.AddDays(1);
            string categoryName = cboCategory.Text;
            string cost_type_id = controller.getCategoryByNameAndUserID(categoryName).Id;
            for (int i = 0; i <= number_of_periods; i++)
            {
                double costs_sum_from_period = 0;
                costs_sum_from_period = controller.get_sum_from_cost_by_date_and_cost_type_id(cost_type_id, period_begin_date, period_begin_date.AddDays(1));
                // chart_outlays.Series[0].Points.AddXY(period_begin_date.AddDays(1), i);
                chart_outlays.Series[0].Points.AddXY(period_begin_date.AddDays(1), costs_sum_from_period);
                period_begin_date = period_begin_date.AddDays(1);
            }
        }
        private void draw_chart_outlays_by_month()
        {
            DateTime period_begin_date = Convert.ToDateTime(dateTimePickerStart.Value);
            DateTime period_end_date = Convert.ToDateTime(dateTimePickerEnd.Value);
            int number_of_periods = 6;
            // int i = 0;
            chart_outlays.Series[0].Points.Clear();
            chart_outlays.ChartAreas[0].AxisX.Minimum = period_begin_date.ToOADate();
            chart_outlays.ChartAreas[0].AxisX.Maximum = period_end_date.ToOADate();
            chart_outlays.ChartAreas[0].AxisX.Interval = 5;
            chart_outlays.Series[0].Color = Color.YellowGreen;
            //int number_of_periods = Convert.ToInt16((Convert.ToDouble(period_end_date.AddHours(-22)) - Convert.ToDouble(period_begin_date.AddHours(-23).ToOADate()))/2);
            string categoryName = cboCategory.Text;
            //chart_outlays.Series[0].Points.AddXY(period_begin_date, 2);
            //chart_outlays.Series[0].Points.AddXY(period_end_date, 7);
            string cost_type_id = controller.getCategoryByNameAndUserID(categoryName).Id;
            for (int i = 0; i <= number_of_periods; i++)
            // while (!(period_begin_date==period_end_date))
            {
                //i++;
                double costs_sum_from_period = 0;
                costs_sum_from_period = controller.get_sum_from_cost_by_date_and_cost_type_id(cost_type_id, period_begin_date, period_begin_date.AddDays(1));

                chart_outlays.Series[0].Points.AddXY(period_begin_date, costs_sum_from_period);
                period_begin_date = period_begin_date.AddDays(5);
            }
        }
        private void draw_chart_outlays_by_year()
        {
            DateTime period_begin_date = Convert.ToDateTime(dateTimePickerStart.Value);
            DateTime period_end_date = Convert.ToDateTime(dateTimePickerEnd.Value);
            chart_outlays.Series[0].Points.Clear();
            int number_of_periods = 12;
            chart_outlays.ChartAreas[0].AxisX.Minimum = period_begin_date.ToOADate();
            chart_outlays.ChartAreas[0].AxisX.Maximum = period_end_date.ToOADate();

            chart_outlays.Series[0].Color = Color.YellowGreen;
            //int i = 0;

            string categoryName = cboCategory.Text;
            string cost_type_id = controller.getCategoryByNameAndUserID(categoryName).Id;
            for (int i = 0; i <= number_of_periods; i++)
            // while (!(period_begin_date == period_end_date))
            {
                //i++;
                TimeSpan interval = period_begin_date.AddMonths(1) - period_begin_date;
                double diff = interval.TotalDays;
                chart_outlays.ChartAreas[0].AxisX.Interval = diff;
                
                double costs_sum_from_period = 0;
                costs_sum_from_period = controller.get_sum_from_cost_by_date_and_cost_type_id(cost_type_id, period_begin_date, period_begin_date.AddMonths(1));
                chart_outlays.Series[0].Points.AddXY(period_begin_date, costs_sum_from_period);
                period_begin_date = period_begin_date.AddMonths(1);
            }
        }
        private void draw_chart_outlays_by_custom()
        {

            DateTime period_begin_date = Convert.ToDateTime(dateTimePickerStart.Value);
            DateTime period_end_date = Convert.ToDateTime(dateTimePickerEnd.Value);
            int number_of_periods = 7;
            // int i = 0;
            TimeSpan interval = period_end_date - period_begin_date;
            double diff = interval.TotalDays;
            chart_outlays.Series[0].Points.Clear();
            chart_outlays.ChartAreas[0].AxisX.Minimum = period_begin_date.ToOADate();
            chart_outlays.ChartAreas[0].AxisX.Maximum = period_end_date.ToOADate();
            chart_outlays.Series[0].Color = Color.YellowGreen;

            if (diff <= 14) chart_outlays.ChartAreas[0].AxisX.Interval = 1;
            if (diff > 14 && diff <= 92) chart_outlays.ChartAreas[0].AxisX.Interval = 7;
            if (diff > 92 && diff <= 425) chart_outlays.ChartAreas[0].AxisX.Interval = 30;
            if (diff > 425) { chart_outlays.ChartAreas[0].AxisX.Interval = 90; }
            //chart_outlays.ChartAreas[0].AxisX.Interval=Convert.ToInt32((period_end_date-period_begin_date));
            //int number_of_periods = Convert.ToInt16((Convert.ToDouble(period_end_date.AddHours(-22)) - Convert.ToDouble(period_begin_date.AddHours(-23).ToOADate()))/2);
            string categoryName = cboCategory.Text;
            string cost_type_id = controller.getCategoryByNameAndUserID(categoryName).Id;
            for (int i = 0; i <= number_of_periods; i++)
            // while (!(period_begin_date==period_end_date))
            {
                //i++;
                double costs_sum_from_period = 0;
                costs_sum_from_period = controller.get_sum_from_cost_by_date_and_cost_type_id(cost_type_id, period_begin_date, period_begin_date.AddDays(1));
                chart_outlays.Series[0].Points.AddXY(period_begin_date, costs_sum_from_period);
                period_begin_date = period_begin_date.AddDays(1);
            }

        }
        private void draw_chart_outlays(string cost_type_id)
        {
           
            chart_outlays.Series[0].Points.Clear();
            double x = 0;
           /* for (int i = 0; i < 6; i++)
            {
                chart_outlays.Series[0].Points.AddXY(period_begin_date.AddDays(-number_of_periods+ i), x);
                x += i;
            }*/
            /*while(i<number_of_periods)
            {

                double costs_sum_from_period = 0;
                costs_sum_from_period = controller.get_sum_from_cost_by_date_and_cost_type_id(cost_type_id, period_begin_date, period_begin_date.AddDays(5));
                MessageBox.Show(period_begin_date.AddDays( 5).ToString());
                chart_outlays.Series[0].Points.AddXY(period_begin_date, costs_sum_from_period);
                i++;
            }*/
            
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
                 //   this.dataGridViewOutlays.Columns["created_at"].Visible = false;
                    this.dataGridViewOutlays.Columns["updated_at"].Visible = false;
                    this.dataGridViewOutlays.Columns["name"].HeaderText = "Назва витрати";
                    this.dataGridViewOutlays.Columns["description"].HeaderText = "Нотатки";
                    this.dataGridViewOutlays.Columns["price"].HeaderText = "затрачена сумма";
                    this.dataGridViewOutlays.Columns["created_at"].HeaderText = "Дата";
                }

                catch { }
            }
        }

       private void ColumnEdit_Clic(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewOutlays.Columns["ColumnEdit"].Index && e.RowIndex >= 0)
            {
                Cost cost = controller.getCostByName(dataGridViewOutlays.Rows[e.RowIndex].Cells["name"].Value.ToString(), LoginForm.user_name)[0];

                New_cost_form costForm = new New_cost_form(cost);
                costForm.Show();

            }
        }
      // private void set_sum_from_period() { }
       protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
       {
           if (keyData == Keys.Escape)
           {
               this.Close();
               return true;
           }
           return base.ProcessCmdKey(ref msg, keyData);
       }

    }
}
