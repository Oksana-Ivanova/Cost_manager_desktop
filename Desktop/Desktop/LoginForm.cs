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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        const string host = "127.0.0.1";
        const string database = "heroku_9e3361f1a2a704a";
        const string user = "root";
        const string password = "123";

        DBHandler controller = new DBHandler(host, database, user, password);
        public static int user_ID;
        public static string user_name;
        public static string user_pasword;
        
        private void button_Ok_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            user_name = tbLogin.Text;
            user_pasword = tbPassword.Text;

           if (controller.getUserByName(user_name).Pasword.Contains(user_pasword))
            {
                user_ID =int.Parse( controller.getUserByName(user_name).Id);
              //  this.Hide();
                Main mainform = new Main();
                mainform.Show();
                MessageBox.Show(user_ID.ToString());
            }
            else
            {

                tbLogin.Clear();
                tbPassword.Clear();
                MessageBox.Show("неправильно введений пароль або імя");
            }
            
         

          
           // if (!mainform.Enabled) { Application.Exit(); }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel_ForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("A password was sent on your e-mail.");
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
        }

        
    }
}
