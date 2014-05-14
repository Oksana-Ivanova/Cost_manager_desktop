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
    public partial class New_Incomes : Form
    {
        public enum FormMode
        {
            CreateMode = 0,
            UpdateMode = 1
        };

        private FormMode formMode;
        private Income currentIncome;

        public New_Incomes()
        {
            InitializeComponent();

            formMode = FormMode.CreateMode;
            currentIncome = new Income();
            initFormByMode(formMode);
        }

        public New_Incomes(Income income)
        {
            InitializeComponent();

            formMode = FormMode.UpdateMode;
            currentIncome = income;
            initFormByMode(formMode);
            initFieldsByIncome();
        }

        const string host = "eu-cdbr-west-01.cleardb.com";
        const string database = "heroku_9e3361f1a2a704a";
        const string user = "b7d511d516e6e4";
        const string password = "e2941bb5";

        private void initFormByMode(FormMode mode)
        {
            switch (mode)
            {
                case FormMode.CreateMode:
                    this.Text = "New Income";
                    btnOk.Text = "Create";
                    btnDelete.Text = String.Empty;
                    btnDelete.Hide();
                    btnCancel.Text = "Cencel";
                    break;

                case FormMode.UpdateMode:
                    this.Text = "Update Income";
                    btnOk.Text = "Update";
                    btnDelete.Text = "Delete";
                    btnDelete.Show();
                    btnCancel.Text = "Cencel";
                    break;

                default:
                    this.Text = "New Income";
                    btnOk.Text = "Create";
                    btnDelete.Text = String.Empty;
                    btnDelete.Hide();
                    btnCancel.Text = "Cencel";
                    break;
            }

            dateTimePickerNewIncome.MinDate = DateTime.Today.AddYears(-7);
            dateTimePickerNewIncome.MaxDate = DateTime.Now;
            dateTimePickerNewIncome.Value = DateTime.Now;
        }

        private void initFieldsByIncome()
        {
            if (formMode == FormMode.UpdateMode)
            {
                tbTitleNewIncome.Text = currentIncome.Name;
                txtDescription.Text = currentIncome.Description;
                numValue.Value = (decimal)currentIncome.Price;
                dateTimePickerNewIncome.Value = currentIncome.CreateDate;
            }
        }

        DBHandler controller = new DBHandler(host, database, user, password);      
        BindingSource new_cost_binding = new BindingSource();
        SqlFunction connect = new SqlFunction(host, database, user, password);

        /// <summary>
        /// Validate fields on the form
        /// </summary>
        /// <returns>true if all fields on the form are filled correctly 
        /// and there are no empty eesential fields</returns>
        private bool validateFields()
        {
            if (tbTitleNewIncome.Text == String.Empty)
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
                    //string id = connect.generator_id(table_name, column_name);
                    string id = SequenceGenerator.GenerateUniqueString();
                    int ID_user = LoginForm.user_ID;
                    string name = tbTitleNewIncome.Text;
                    string description = txtDescription.Text;
                    double money = Double.Parse(numValue.Value.ToString());
                    string Date = secondary_methods.datetime_to_sql_format(dateTimePickerNewIncome.Value);
                    connect.Insert_into_income(id, ID_user, name, description, money, Date);

                    // DataGridView2__Drow(ID_cost); 

                    this.Close();
                }
                catch { }
            }
            else if (formMode == FormMode.UpdateMode)
            {
                try
                {
                    string createDate = secondary_methods.datetime_to_sql_format(currentIncome.CreateDate);
                    string updateDate = secondary_methods.datetime_to_sql_format(dateTimePickerNewIncome.Value);

                    connect.Update_income(currentIncome.Id,
                                           currentIncome.UserId,
                                           tbTitleNewIncome.Text,
                                           txtDescription.Text,
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you realy wish to remove entry?",
                                "Are you sure?",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                Income income = controller.getIncomeByName(tbTitleNewIncome.Text, LoginForm.user_name)[0];

                connect.Delete_income(income.Id, LoginForm.user_ID);

                this.Close();
            }
        }
    }
}
