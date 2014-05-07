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

       


        private void button_Ok_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Main mainform = new Main();     
            mainform.Show();

          
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

        
    }
}
