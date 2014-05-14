﻿using System;
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
        public static string user_email;
        public static string user_pasword;
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            user_email = tbEmail.Text;
            user_pasword = tbPassword.Text;

            if (user_email.Equals(String.Empty) && user_pasword.Equals(String.Empty))
            { 
                MessageBox.Show("Заповніть поля Email та Pasword"); 
                return; 
            }
            else
            {
                if (user_email.Equals(String.Empty)) 
                {
                    MessageBox.Show("Заповніть поле Email");
                    return;
                }
                else
                {
                    if (user_pasword.Equals(String.Empty))
                    {
                        MessageBox.Show("Заповніть поле Pasword");
                        return; 
                    } 
                }
            }
            
            if (controller.getUserByEmail(user_email).Pasword.Equals(user_pasword))
            {
                User requestedUser = controller.getUserByEmail(user_email);
                user_ID = int.Parse(requestedUser.Id);
                user_name = requestedUser.Name;
                this.Hide();
                Main mainform = new Main();
                mainform.ShowDialog();

                Application.Exit();

            }
            else
            {                
                tbPassword.Clear();
                MessageBox.Show("Неправильно заповнені поля Email або Pasword");
            }
           // if (!mainform.Enabled) { Application.Exit(); }

        }

        private void btnCancel_Click(object sender, EventArgs e)
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
        private void LoginForm_Closed(object sender, EventArgs e)
        {

        }
    }
}
