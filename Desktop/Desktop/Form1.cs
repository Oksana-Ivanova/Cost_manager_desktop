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
    public partial class Main : Form
    {
        
        public Main()
        {
            //LoginForm Loginform = new LoginForm();
            //Loginform.Close();
            InitializeComponent();
            double x = 0;
            draw_chart_recent_cost();
            get_all_incomes_by_week();
            most_often_cost();
            biggest_cost();
           // if (!loginForm.Visible) { loginForm.Close(); }
        }

        const string host = "eu-cdbr-west-01.cleardb.com";
        const string database = "heroku_9e3361f1a2a704a";
        const string user = "b7d511d516e6e4";
        const string password = "e2941bb5";
        DBHandler controller = new DBHandler(host, database, user, password);
        SqlFunction connect = new SqlFunction(host, database, user, password);
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void draw_chart_recent_cost() 
        {
            DateTime period_begin_date = DateTime.Today.AddDays(-6);

            DateTime period_end_date = DateTime.Today.AddHours(23);
            int number_of_periods = 7;
            chart_recent_cost.Series[0].Points.Clear();
            chart_recent_cost.ChartAreas[0].AxisX.Minimum = period_begin_date.ToOADate();
            chart_recent_cost.ChartAreas[0].AxisX.Maximum = period_end_date.ToOADate();
            chart_recent_cost.Series[0].Color = Color.YellowGreen;
            chart_recent_cost.ChartAreas[0].AxisX.Interval = 1;
            period_begin_date = period_begin_date.AddDays(-1);
            period_end_date = period_end_date.AddDays(1);

            double costs_sum_from_period = 0;
            for (int i = 0; i <= number_of_periods; i++)
            {
                
                costs_sum_from_period = controller.get_sum_from_all_cost_by_week(period_begin_date, period_begin_date.AddDays(1));                   
                chart_recent_cost.Series[0].Points.AddXY(period_begin_date.AddDays(1), costs_sum_from_period);
                period_begin_date = period_begin_date.AddDays(1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void viewOutlaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My_outlays outlays_form = new My_outlays();
            outlays_form.ShowDialog();
            
        }
        private void most_often_cost() 
        { string cost_type_id;
            double sum;
            string category_name = secondary_methods.get_most_often_cost(out sum, out cost_type_id);         
            labelCategoryName.Text = category_name;
            labelWeekOutlay.Text = sum.ToString();
        }
        private void biggest_cost()
        {
            string cost_type_id;
            double sum;
            string category_name = secondary_methods.get_biggest_cost(out sum, out cost_type_id);           
            labelCategoryName2.Text = category_name;
            labelWeekOutlay2.Text = sum.ToString();
        }
        private void viewIncomesToolStripMenuItem_Click(object sender, EventArgs e)
        {
 Incomes inc_form = new Incomes();
            inc_form.ShowDialog();
        }

        private void newIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Incomes new_inc = new New_Incomes();
            new_inc.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeApplication();
        }

        private void chart_recent_cost_Click(object sender, EventArgs e)
        {
            
        }

        private void newCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_cost_form CostForm = new New_cost_form();
            CostForm.ShowDialog();
        }

        private void newCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Category_Form CategoryForm = new New_Category_Form();
            CategoryForm.ShowDialog();
        }

        private void viewLimitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limits_Form LimitForm = new Limits_Form();
            LimitForm.ShowDialog();
        }

        private void buttonDetailedOutlays_Click(object sender, EventArgs e)
        {
            My_outlays outlaysForm = new My_outlays();
            outlaysForm.ShowDialog();
        }

        private void buttonDetalisedIncomes_Click(object sender, EventArgs e)
        {
            Incomes incomesForm = new Incomes();
            incomesForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox AboutBoxForm = new AboutBox();
            AboutBoxForm.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            labelTotalIncomePerWeek.Visible = false;
            labelTotalOutlayPerWeek.Visible = false;
        }

        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            closeApplication();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        private void closeApplication()
        {
            Application.Exit();           
        }

        private void refreshForm()
        {
            this.dataGridViewRecentIncomes.DataSource = null;
            this.dataGridViewRecentIncomes.Rows.Clear();
            try
            {
                this.dataGridViewRecentIncomes.Columns.Remove("ColumnEdit");
                this.dataGridViewRecentIncomes.Columns.Remove("ColumnDelete");
            }
            catch { }
            DateTime period_begin_date = DateTime.Today.AddDays(-6);
            DateTime period_end_date = DateTime.Now;

            DataSet ds = new DataSet();
            ds = controller.getAllIncomesBySelectedPeriod(period_begin_date, period_end_date);

            dataGridViewRecentIncomes.DataSource = ds.Tables["incomes"];
            add_column_edit();
            add_column_delete();
        }

        private void get_all_incomes_by_week()
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
            this.dataGridViewRecentIncomes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            ColumnDelete.Width = 75;
            ColumnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewRecentIncomes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    ColumnDelete});
        }

        private void dataGridViewRecentIncomes_ColumnAdded(Object sender, DataGridViewColumnEventArgs e)
        {
            if (dataGridViewRecentIncomes.Columns.Contains("updated_at"))
            {
                try
                {
                    this.dataGridViewRecentIncomes.Columns["id"].Visible = false;
                    this.dataGridViewRecentIncomes.Columns["user_id"].Visible = false;
                    //   this.dataGridViewRecentIncomes.Columns["created_at"].Visible = false;
                    this.dataGridViewRecentIncomes.Columns["updated_at"].Visible = false;
                    this.dataGridViewRecentIncomes.Columns["name"].HeaderText = "Title";
                    this.dataGridViewRecentIncomes.Columns["description"].HeaderText = "Notes";
                    this.dataGridViewRecentIncomes.Columns["price"].HeaderText = "Income value";
                    this.dataGridViewRecentIncomes.Columns["created_at"].HeaderText = "Date";
                }

                catch { }
            }
        }

        private void labelSrartPage_Click(object sender, EventArgs e)
        {

        }
        private void ColumnEdit_Clic(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewRecentIncomes.Columns["ColumnEdit"].Index && e.RowIndex >= 0)
            {
                Income income = controller.getIncomeById(dataGridViewRecentIncomes.Rows[e.RowIndex].Cells["id"].Value.ToString(), LoginForm.user_name);

                New_Incomes incomeForm = new New_Incomes(income);
                incomeForm.Show();

                refreshForm();
            }
            else
                if (e.ColumnIndex == dataGridViewRecentIncomes.Columns["ColumnDelete"].Index && e.RowIndex >= 0)
                {
                    if (MessageBox.Show("Do you realy want to remove entry?",
                                       "Are you sure?",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question,
                                       MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Income income = controller.getIncomeById(dataGridViewRecentIncomes.Rows[e.RowIndex].Cells["id"].Value.ToString(), LoginForm.user_name);

                        connect.Delete_income(income.Id, LoginForm.user_ID);

                        refreshForm();
                    }
                }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
