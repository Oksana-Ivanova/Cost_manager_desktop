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
        public New_Incomes()
        {
            InitializeComponent();
        }

        const string host = "127.0.0.1";
        const string database = "heroku_9e3361f1a2a704a";
        const string user = "root";
        const string password = "123";
    

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

            try
            {
                
                //string id = connect.generator_id(table_name, column_name);
                string id = SequenceGenerator.GenerateUniqueString();
                int ID_user = LoginForm.user_ID;               
                string name = tbTitleNewIncome.Text;
                string description = txtDescription.Text;
                double money = Convert.ToDouble(numValue.Value);
                string Date = secondary_methods.datetime_to_sql_format(dateTimePickerNewIncome.Value);
                connect.Insert_into_income(id, ID_user,  name, description, money, Date);

                // DataGridView2__Drow(ID_cost); 

               
            }
            catch { } 
           
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
