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
            comboBoxCategory_Set();
            panel_chart.Visible = true;
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
        private void comboBoxCategory_Set()
        {
            List<CostType> categoryName = new List<CostType>();
            categoryName = controller.getCategorysByUserID(LoginForm.user_ID);
             CostType tempObject = new CostType();
             categoryName.Add(new CostType(tempObject.Id = "", tempObject.Name = "Any", tempObject.CreateDate = DateTime.Today, tempObject.UpdateDate = DateTime.Today));
          
            outlays_binding.DataSource = categoryName;        
            comboBoxCategory.DataSource = outlays_binding.DataSource;
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "Name";
        }
        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoryName = comboBoxCategory.Text;    //     dataGridViewOutlays begin
           string cost_type_id = controller.getCategoryByNameAndUserID(categoryName).Id;
                   // MessageBox.Show(connectionString);
            DataSet ds = new DataSet();
            ds = controller.getAllCosts(cost_type_id);
          
            dataGridViewOutlays.DataSource = ds.Tables["costs"]; // ataGridViewOutlays end     
            draw_chart_outlays(cost_type_id);

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
