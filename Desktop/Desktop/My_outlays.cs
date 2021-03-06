﻿using System;
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

        const string host = "127.0.0.1";
        const string database = "heroku_9e3361f1a2a704a";
        const string user = "root";
        const string password = "123";

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
        private void out_of_limit(string cost_type_id) 
        {
            if (secondary_methods.out_of_limit(cost_type_id)) { label_out_of_the_limit.Visible = true; label_out_of_the_limit.Text = "OUT OF LIMIT"; }
        }

        private void initCategoriesComboData()
        {
            List<CostType> categoryName = new List<CostType>();
            categoryName = controller.getCategoriesByUserID(LoginForm.user_ID);
            //categoryName.Insert(0, new CostType("", "Any", DateTime.Now, DateTime.Now));
          
            outlays_binding.DataSource = categoryName;
            cboCategory.DataSource = outlays_binding.DataSource;
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "Name";
        }

        private void initControls()
        {
            initCategoriesComboData();

            cboPeriod.SelectedIndex = (int)PeriodMode.LastWeek;

            dateTimePickerStart.MinDate = DateTime.Today.AddYears(-5);
            dateTimePickerStart.MaxDate = DateTime.Now;
            dateTimePickerStart.Value = DateTime.Now.AddDays(-6);
            dateTimePickerEnd.MinDate = DateTime.Today.AddYears(-5);
            dateTimePickerEnd.MaxDate = DateTime.Now;
            dateTimePickerEnd.Value = DateTime.Now;

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

        private void refreshForm()
        {
            label_out_of_the_limit.Visible = false;
            fillDateBoundsByPeriod();
            //this.dataGridViewOutlays.DataSource = null;
            //this.dataGridViewOutlays.Rows.Clear();
            try
            {
                this.dataGridViewOutlays.Columns.Remove("ColumnEdit");
                this.dataGridViewOutlays.Columns.Remove("ColumnDelete");
            }
            catch { }
            // this.dataGridViewOutlays.DataSource = this.GetNewValues();

            DateTime period_begin_date = Convert.ToDateTime(dateTimePickerStart.Value);
            DateTime period_end_date = Convert.ToDateTime(dateTimePickerEnd.Value);
            string categoryName = cboCategory.Text;
            string cost_type_id = controller.getCategoryByNameAndUserID(categoryName).Id;
            out_of_limit(cost_type_id);
            // MessageBox.Show(connectionString);
            DataSet ds = new DataSet();
            ds = controller.getAllCostsBySelectedPeriod(cost_type_id, period_begin_date, period_end_date);

            dataGridViewOutlays.DataSource = ds.Tables["costs"]; // ataGridViewOutlays end     
            // draw_chart_outlays(cost_type_id);
           // add_column_edit();
            //add_column_delete();

            label_sum_for_period.Text = controller.get_sum_from_cost_by_date_and_cost_type_id(cost_type_id, period_begin_date, period_end_date.AddDays(1)).ToString();
            
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshForm();
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
            ColumnEdit.Width = 75;
            ColumnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewOutlays.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    ColumnEdit});
        }
        private void add_column_delete()
        {
            System.Windows.Forms.DataGridViewButtonColumn ColumnEdit;
            ColumnEdit = new System.Windows.Forms.DataGridViewButtonColumn();

            ColumnEdit.HeaderText = "";
            ColumnEdit.Name = "ColumnDelete";
            ColumnEdit.ReadOnly = true;
            ColumnEdit.Text = "Delete";
            ColumnEdit.ToolTipText = "Delete";
            ColumnEdit.UseColumnTextForButtonValue = true;
            ColumnEdit.Width = 75;
            ColumnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewOutlays.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    ColumnEdit});
        }

        private void btnNewCost_Click(object sender, EventArgs e)
        {
            New_cost_form newCostForm = new New_cost_form();
            newCostForm.Show();

            refreshForm();
        }
        private void draw_chart_outlays_by_week()
        {
            DateTime period_begin_date = Convert.ToDateTime(dateTimePickerStart.Value);
            DateTime period_end_date = Convert.ToDateTime(dateTimePickerEnd.Value).AddHours(23);
            int number_of_periods = 7;
            chart_outlays.Series[0].Points.Clear();
            chart_outlays.ChartAreas[0].AxisX.Minimum = period_begin_date.ToOADate();
            chart_outlays.ChartAreas[0].AxisX.Maximum = period_end_date.ToOADate();
            chart_outlays.Series[0].Color = Color.DarkBlue;
            chart_outlays.ChartAreas[0].AxisX.Interval = 1;
           // period_begin_date = period_begin_date.AddDays(-1);
          //  period_end_date = period_end_date.AddDays(1);
            string categoryName = cboCategory.Text;
            string cost_type_id = controller.getCategoryByNameAndUserID(categoryName).Id;
            double costs_sum_from_period = 0;
            for (int i = 0; i <= number_of_periods; i++)
            {
               
                costs_sum_from_period = controller.get_sum_from_cost_by_date_and_cost_type_id(cost_type_id, period_begin_date, period_begin_date.AddDays(1));
             
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
            chart_outlays.Series[0].Color = Color.DarkBlue;
            //int number_of_periods = Convert.ToInt16((Convert.ToDouble(period_end_date.AddHours(-22)) - Convert.ToDouble(period_begin_date.AddHours(-23).ToOADate()))/2);
            string categoryName = cboCategory.Text;
            //chart_outlays.Series[0].Points.AddXY(period_begin_date, 2);
            //chart_outlays.Series[0].Points.AddXY(period_end_date, 7);
            string cost_type_id = controller.getCategoryByNameAndUserID(categoryName).Id;
            double costs_sum_from_period = 0;
            for (int i = 0; i <= number_of_periods; i++)
            // while (!(period_begin_date==period_end_date))
            {
                //i++;
              
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

            chart_outlays.Series[0].Color = Color.DarkBlue;
            //int i = 0;
            TimeSpan interval = period_begin_date.AddMonths(1) - period_begin_date;
            double costs_sum_from_period = 0;
            double diff = interval.TotalDays;
            string categoryName = cboCategory.Text;
            string cost_type_id = controller.getCategoryByNameAndUserID(categoryName).Id;
            for (int i = 0; i <= number_of_periods; i++)
            // while (!(period_begin_date == period_end_date))
            {
                //i++;
                chart_outlays.ChartAreas[0].AxisX.Interval = diff;
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
            chart_outlays.Series[0].Color = Color.DarkBlue;

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
                    this.dataGridViewOutlays.Columns["name"].HeaderText = "Title";
                    this.dataGridViewOutlays.Columns["description"].HeaderText = "Notes";
                    this.dataGridViewOutlays.Columns["price"].HeaderText = "Cost value";
                    this.dataGridViewOutlays.Columns["created_at"].HeaderText = "Date";
                }

                catch { }
            }
        }
        
        private void ColumnEdit_Clic(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewOutlays.Columns["ColumnEdit"].Index && e.RowIndex >= 0)
            {
                Cost cost = controller.getCostById(dataGridViewOutlays.Rows[e.RowIndex].Cells["id"].Value.ToString())[0];
          
              New_cost_form costForm = new New_cost_form(cost);
                costForm.Show();

               refreshForm();
            }
            else
                if (e.ColumnIndex == dataGridViewOutlays.Columns["ColumnDelete"].Index && e.RowIndex >= 0)
                {
                    if (MessageBox.Show("Do you realy want to remove entry?",
                                        "Are you sure?",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question,
                                        MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Cost cost = controller.getCostById(dataGridViewOutlays.Rows[e.RowIndex].Cells["id"].Value.ToString(), LoginForm.user_name);

                        connect.Delete_cost(cost.Id, cost.CostTypeId, LoginForm.user_ID);

                        refreshForm();
                    }
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

        private void My_outlays_Activated(object sender, EventArgs e)
        {
            refreshForm();
        }

    }
}
