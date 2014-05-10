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
            comboBox_Limit_Cheking.Text = "No Limit";
            
        }
        const string host = "127.0.0.1";
        const string database = "heroku_9e3361f1a2a704a";
        const string user = "root";
        const string password = "123";


        SqlFunction connect = new SqlFunction(host, database, user, password);
        private void button_ok_Click(object sender, EventArgs e)
        {
            string table_name = "cost_types";
            string column_name = "id";
            string id = connect.generator_id(table_name, column_name);

            int ID_user = LoginForm.user_ID;
            double limit = double.Parse(numericUpDownLimit.Value.ToString());
            string type_name = tbTitle.Text;
            string Date = secondary_methods.date();

           connect.Insert_into_cost_type(id, ID_user, limit, type_name, Date);
           
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           // if (comboBox3.Text == "No Limit") { numericUpDown1.Enabled = false; }
        }

    
    }
}
