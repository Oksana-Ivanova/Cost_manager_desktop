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
    public partial class ProfileForm : Form
    {
        bool editable; 

        public ProfileForm()
        {
            editable = false;
            
            InitializeComponent();

            initControls();
        }

        private void initControls()
        {
            panelPasswords.Visible = false;

            tbName.Enabled = false;
            tbEmail.Enabled = false;

            cbxViewPassword.Checked = false;

            btnOK.Text = "Update profile";
            btnCancel.Text = "Close";
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            tbName.Text = LoginForm.user_name;
            tbEmail.Text = LoginForm.user_email;
        }

        private bool isFieldsValid()
        {
            if (tbPasswordProfile.Text == string.Empty)
            {
                if (tbConfirmPasswordPrifile.Text == string.Empty)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        private bool tryUpdate()
        {
            if (tbPasswordProfile.Text == tbConfirmPasswordPrifile.Text)
            {
                const string host = "127.0.0.1";
                const string database = "heroku_9e3361f1a2a704a";
                const string user = "root";
                const string password = "123";

                SqlFunction con = new SqlFunction(host, database, user, password);
                con.Update_user_password(tbConfirmPasswordPrifile.Text);

                return true;
            }
            else 
            {
                MessageBox.Show("Type the sama new password twice.");
                return false;
            }

        }

        public void makeEditable()
        {
            if (editable)
            {
                panelPasswords.Visible = false;
                
                tbName.Enabled = false;
                tbEmail.Enabled = false;
                
                btnOK.Text = "Update profile";
                btnCancel.Text = "Close";

                editable = false;
            }
            else
            {
                panelPasswords.Visible = true;

                tbName.Enabled = true;
                tbEmail.Enabled = true;

                cbxViewPassword.Checked = false;

                tbCurrentPassword.Clear();
                tbPasswordProfile.Clear();
                tbConfirmPasswordPrifile.Clear();

                btnOK.Text = "Accept";
                btnCancel.Text = "Reject";

                editable = true;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (editable)
            {
                if (isFieldsValid())
                {
                    if (tryUpdate() )
                        makeEditable();
                }                
            }
            else
            {
                makeEditable();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (editable)
                makeEditable();
            else
                this.Close();
        }

        private void setAllPasswordsHidden(bool isHidden)
        {
            tbPasswordProfile.UseSystemPasswordChar = isHidden;
            tbConfirmPasswordPrifile.UseSystemPasswordChar = isHidden;
            tbCurrentPassword.UseSystemPasswordChar = isHidden;
        }

        private void cbxViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            setAllPasswordsHidden(!cbxViewPassword.Checked);
        }
    }
}
