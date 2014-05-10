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
        
    public partial class New_Category_Form : Form
    {
        public New_Category_Form()
        {
            InitializeComponent();
            cboLimitChecking.SelectedIndex = 0;
        }
        const string host = "127.0.0.1";
        const string database = "heroku_9e3361f1a2a704a";
        const string user = "root";
        const string password = "123";
        
        SqlFunction connect = new SqlFunction(host, database, user, password);

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (tbCategoryTitle.Text == String.Empty)
            {
                MessageBox.Show( "Set Category name, please!", "Empty Category name.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk );
                return;
            }

            string table_name = "cost_types";
            string column_name = "id";
            string id = connect.generator_id(table_name, column_name);

            int ID_user = LoginForm.user_ID;
            double limit = 1000;
            string type_name = tbCategoryTitle.Text;
            string Date = secondary_methods.date();

            connect.Insert_into_cost_type(id, ID_user, limit, type_name, Date);
            tbCategoryTitle.Clear();

            this.Close();
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboLimitChecking_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLimitChecking.SelectedIndex == 0)
            {
                numLimitValue.Enabled = false;
            }
            else
            {
                numLimitValue.Enabled = true;
            }
        }
        
    }
}
