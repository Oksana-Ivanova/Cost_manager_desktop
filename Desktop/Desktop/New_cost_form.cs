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
        public enum FormMode
        {
            CreateMode = 0,
            UpdateMode = 1
        };

        private FormMode formMode;
        private Cost currentCost;

        public New_cost_form()
        {
            InitializeComponent();
            comboBoxCategoryNewCost_Set();

            formMode = FormMode.CreateMode;
            currentCost = new Cost();
            initFormByMode(formMode);
        }

        public New_cost_form(Cost cost)
        {
            InitializeComponent();
            comboBoxCategoryNewCost_Set();

            formMode = FormMode.UpdateMode;
            currentCost = cost;
            initFormByMode(formMode);
            initFieldsByCost();
        }

        const string host = "127.0.0.1";
        const string database = "heroku_9e3361f1a2a704a";
        const string user = "root";
        const string password = "123";
        
        private void initFormByMode(FormMode mode)
        {
            switch (mode)
            {
                case FormMode.CreateMode:
                    this.Text = "New Cost";
                    btnOk.Text = "Create";
                    btnDelete.Text = String.Empty;
                    btnDelete.Hide();
                    btnCancel.Text = "Cencel";
                    break;

                case FormMode.UpdateMode:
                    this.Text = "Update Cost";
                    btnOk.Text = "Update";
                    btnDelete.Text = "Delete";
                    btnDelete.Show();
                    btnCancel.Text = "Cencel";
                    break;

                default:
                    this.Text = "New Cost";
                    btnOk.Text = "Create";
                    btnDelete.Text = String.Empty;
                    btnDelete.Hide();
                    btnCancel.Text = "Cencel";
                    break;
            }
        }
        private void initFieldsByCost()
        {
            if (formMode == FormMode.UpdateMode)
            {
                tbNameNewCost.Text = currentCost.Name;
                richTextBoxDescriptionNewCost.Text = currentCost.Description;
                cboCategory.SelectedText = controller.getCostCategory(currentCost.Name, LoginForm.user_name).Name;
                numValue.Value = (decimal)currentCost.Price;
                dateTimePickerNewCost.Value = currentCost.CreateDate;
            }
        }

        DBHandler controller = new DBHandler(host, database, user, password);      
        BindingSource new_cost_binding = new BindingSource();
        SqlFunction connect = new SqlFunction(host, database, user, password);
                
        private void comboBoxCategoryNewCost_Set()
        {
            List<CostType> categories = new List<CostType>();
            categories = controller.getCategoriesByUserID(LoginForm.user_ID);

            new_cost_binding.DataSource = categories;
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

            if (formMode == FormMode.CreateMode)
            {
                try
                {
                    string categoryName = cboCategory.Text;
                    //string id = connect.generator_id(table_name, column_name);
                    string id = SequenceGenerator.GenerateUniqueString();
                    int ID_user = LoginForm.user_ID;
                    string ID_cost = controller.getCategoryByNameAndUserID(categoryName).Id;
                    string name = tbNameNewCost.Text;
                    string description = richTextBoxDescriptionNewCost.Text;
                    double money = Convert.ToDouble(numValue.Value);
                    string Date = secondary_methods.datetime_to_sql_format(dateTimePickerNewCost.Value);
                    connect.Insert_into_cost(id, ID_user, ID_cost, name, description, money, Date);

                    // DataGridView2__Drow(ID_cost); 

                    this.Close();
                }
                catch { }
            }
            else if (formMode == FormMode.UpdateMode)
            {
                try
                {
                    string createDate = secondary_methods.datetime_to_sql_format(currentCost.CreateDate);
                    string updateDate = secondary_methods.datetime_to_sql_format(dateTimePickerNewCost.Value);

                    connect.Update(currentCost.Id,
                                   currentCost.UserId,
                                   currentCost.CostTypeId,
                                   tbNameNewCost.Text,
                                   richTextBoxDescriptionNewCost.Text,
                                   (double)numValue.Value,
                                   createDate,
                                   updateDate);
                    this.Close();
                }
                catch { }
            }
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

<<<<<<< HEAD
        private void richTextBoxDescriptionNewCost_TextChanged(object sender, EventArgs e)
        {

=======
        private void btnDelete_Click(object sender, EventArgs e)
        {
        
>>>>>>> 9f402c3bcc418c965e82e9aaae30cdf81883c825
        }

       
    }
}
