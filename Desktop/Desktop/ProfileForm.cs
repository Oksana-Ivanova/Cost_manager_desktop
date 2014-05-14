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

        private void tryUpdate()
        {

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
                    tryUpdate();
                }
                makeEditable();
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
