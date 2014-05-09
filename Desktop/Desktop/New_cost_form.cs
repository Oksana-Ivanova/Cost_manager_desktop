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
    public partial class New_cost_form : Form
    {
        public New_cost_form()
        {
            InitializeComponent();
            comboBoxCategoryNewCost_Set();
            tbValue.AppendText("0");
        }
        const string host = "127.0.0.1";
        const string database = "heroku_9e3361f1a2a704a";
        const string user = "root";
        const string password = "123";
    

        DBHandler controller = new DBHandler(host, database, user, password);      
        BindingSource new_cost_binding = new BindingSource();
        SqlFunction connect = new SqlFunction(host, database, user, password);
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
         private void   comboBoxCategoryNewCost_Set()
        {
            List<CostType> categoryName = new List<CostType>();
            categoryName = controller.getCategorysByUserID(LoginForm.user_ID);
             CostType tempObject = new CostType();
             categoryName.Add(new CostType(tempObject.Id = "", tempObject.Name = "Any", tempObject.CreateDate = DateTime.Today, tempObject.UpdateDate = DateTime.Today));
          
              new_cost_binding.DataSource= categoryName;
              comboBoxCategoryNewCost.DataSource = new_cost_binding.DataSource;
              comboBoxCategoryNewCost.DisplayMember = "Name";
              comboBoxCategoryNewCost.ValueMember = "Name";
        }
        private void button_ok_Click(object sender, EventArgs e)
        {
            try
            {
                string categoryName = comboBoxCategoryNewCost.Text;
                string id =secondary_methods.generator();
                int ID_user = LoginForm.user_ID;             
                string ID_cost =  controller.getCategoryByNameAndUserID(categoryName).Id;             
                string name = tbNameNewCost.Text;
                string description = richTextBoxDescriptionNewCost.Text;
                double money = double.Parse(tbValue.Text);
                string Date = secondary_methods.date();               
               connect.Insert_into_cost(id, ID_user, ID_cost, name, description, money, Date);
               
                                // DataGridView2__Drow(ID_cost); 
                         
            }
            catch { }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
