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
            dateTimePickerStart.MaxDate = DateTime.Now;
            dateTimePickerStart.Value = DateTime.Now.AddDays(-6);
            dateTimePickerEnd.MinDate = DateTime.Today.AddYears(-5);
            dateTimePickerEnd.MaxDate = DateTime.Now;
            dateTimePickerEnd.Value = DateTime.Now;
        }
        const string host = "127.0.0.1";
        const string database = "heroku_9e3361f1a2a704a";
        const string user = "root";
        const string password = "123";

        DBHandler controller = new DBHandler(host, database, user, password);
        SqlFunction connect = new SqlFunction(host, database, user, password);
    
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

        private void refreshForm()
        {
            this.dataGridViewIncomes.DataSource = null;
            this.dataGridViewIncomes.Rows.Clear();
            try
            {
                this.dataGridViewIncomes.Columns.Remove("ColumnEdit");
                this.dataGridViewIncomes.Columns.Remove("ColumnDelete");
            }
            catch { }
            DateTime period_begin_date = Convert.ToDateTime(dateTimePickerStart.Value);
            DateTime period_end_date = Convert.ToDateTime(dateTimePickerEnd.Value);          
         
            DataSet ds = new DataSet();
            ds = controller.getAllIncomesBySelectedPeriod( period_begin_date, period_end_date);
            dataGridViewIncomes.DataSource = ds.Tables["incomes"];
            add_column_edit();
            add_column_delete();
        }

        private void get_incomes_by_selected_period()
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
            ColumnEdit.Width = 50;
            ColumnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewIncomes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    ColumnEdit});
        }
        private void add_column_delete()
        {
            System.Windows.Forms.DataGridViewButtonColumn ColumnDelete;
            ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();

            ColumnDelete.HeaderText = "";
            ColumnDelete.Name = "ColumnDelete";
            ColumnDelete.ReadOnly = true;
            ColumnDelete.Text = "Delete";
            ColumnDelete.ToolTipText = "Delete";
            ColumnDelete.UseColumnTextForButtonValue = true;
            ColumnDelete.Width = 50;
            ColumnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewIncomes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    ColumnDelete});
        }

        public Incomes()
        {
            InitializeComponent();
        }

        private void Incomes_Load(object sender, EventArgs e)
        {
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

            refreshForm();
        }
       
        private void buttonNewIncome_Click(object sender, EventArgs e)
        {
            New_Incomes newIncomeWindow = new New_Incomes();
            newIncomeWindow.Show();

            refreshForm();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerStart.MaxDate = dateTimePickerEnd.Value;

            refreshForm();
        }
        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerEnd.MinDate = dateTimePickerStart.Value;

            refreshForm();
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
                    this.dataGridViewIncomes.Columns["name"].HeaderText = "Title";
                    this.dataGridViewIncomes.Columns["description"].HeaderText = "Notes";
                    this.dataGridViewIncomes.Columns["price"].HeaderText = "Income value";
                    this.dataGridViewIncomes.Columns["created_at"].HeaderText = "Date";
                }

                catch { }
            }
        }

        private void ColumnEdit_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewIncomes.Columns["ColumnEdit"].Index && e.RowIndex >= 0)
            {
                Income income = controller.getIncomeById(dataGridViewIncomes.Rows[e.RowIndex].Cells["id"].Value.ToString(), LoginForm.user_name);

                New_Incomes incomeForm = new New_Incomes(income);
                incomeForm.Show();

                refreshForm();
            }
            else
                if (e.ColumnIndex == dataGridViewIncomes.Columns["ColumnDelete"].Index && e.RowIndex >= 0)
                {
                    if (MessageBox.Show("Do you realy want to remove entry?",
                                        "Are you sure?",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question,
                                        MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Income income = controller.getIncomeById(dataGridViewIncomes.Rows[e.RowIndex].Cells["id"].Value.ToString(), LoginForm.user_name);

                        connect.Delete_income(income.Id, LoginForm.user_ID);

                        refreshForm();
                    }
                }
        }

        private void Incomes_Activated(object sender, EventArgs e)
        {
            refreshForm();
        }

    }
}