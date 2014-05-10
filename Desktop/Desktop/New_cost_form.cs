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
            categoryName.Add(new CostType(tempObject.Id = "", tempObject.Name = "Household", tempObject.CreateDate = DateTime.Today, tempObject.UpdateDate = DateTime.Today));
            categoryName.Add(new CostType(tempObject.Id = "", tempObject.Name = "Business", tempObject.CreateDate = DateTime.Today, tempObject.UpdateDate = DateTime.Today));
            categoryName.Add(new CostType(tempObject.Id = "", tempObject.Name = "Health", tempObject.CreateDate = DateTime.Today, tempObject.UpdateDate = DateTime.Today));
          
            new_cost_binding.DataSource= categoryName;
            cboCategory.DataSource = new_cost_binding.DataSource;
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "Name";
        }

        /// <summary>
        /// Validate fields on the form
        /// </summary>
        /// <returns>true if all fields on the form are filled correctly 
        /// and there are no empty eesential fields</returns>
        private bool validateFields()
        {
            if (tbNameNewCost.Text == String.Empty)
            {
                MessageBox.Show("Please fill cost name!", "Empty cost name.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            if (numValue.Value == Decimal.Zero)
            {
                MessageBox.Show("Please set cost value!", "Empty cost value.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            return true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (validateFields() == false)
                return;

            string table_name="costs";
            string column_name="id";
            try
            {
                string categoryName = cboCategory.Text;
                string id = connect.generator_id(table_name, column_name);
                int ID_user = LoginForm.user_ID;             
                string ID_cost =  controller.getCategoryByNameAndUserID(categoryName).Id;             
                string name = tbNameNewCost.Text;
                string description = richTextBoxDescriptionNewCost.Text;
                double money = Convert.ToDouble(numValue.Value);
                string Date = secondary_methods.date();
                connect.Insert_into_cost(id, ID_user, ID_cost, name, description, money, Date);
               
                // DataGridView2__Drow(ID_cost); 
                
                this.Close();
            }
            catch { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            New_Category_Form newCategoryForm = new New_Category_Form();
            newCategoryForm.Show();
        }

       
    }
}
