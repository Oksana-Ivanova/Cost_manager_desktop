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
            for (int i = 0; i < 4; i++)
            {
                chart_recent_cost.Series[0].Points.AddXY(x, Math.Sin(x));
                x += i;
            } draw_chart_recent_cost();
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void draw_chart_recent_cost() 
        {
            DateTime period_begin_date = DateTime.Today.AddDays(-6);
            DateTime period_end_date = DateTime.Today;
            int number_of_periods = 6;
            chart_recent_cost.Series[0].Points.Clear();            
            for (int i = 0; i <= number_of_periods; i++)
            {
                double costs_sum_from_period = 0;
                costs_sum_from_period = controller.get_sum_from_all_cost_by_week( period_begin_date, period_begin_date.AddDays(1));
                chart_recent_cost.Series[0].Points.AddXY(period_begin_date.AddDays(1), i);
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
        private void get_all_incomes_by_week()
        {
            DateTime period_begin_date = DateTime.Today.AddDays(-6);
            DateTime period_end_date = DateTime.Today;

            DataSet ds = new DataSet();
            ds = controller.getAllIncomesBySelectedPeriod(period_begin_date, period_end_date);

            dataGridViewRecentIncomes.DataSource = ds.Tables["incomes"];
            add_column_edit();

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
            this.dataGridViewRecentIncomes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    ColumnEdit});
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
                    this.dataGridViewRecentIncomes.Columns["name"].HeaderText = "Назва доходу";
                    this.dataGridViewRecentIncomes.Columns["description"].HeaderText = "Нотатки";
                    this.dataGridViewRecentIncomes.Columns["price"].HeaderText = " сумма доходу";
                    this.dataGridViewRecentIncomes.Columns["created_at"].HeaderText = "Дата";
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
                MessageBox.Show("a");
            }
        }
    }
}
