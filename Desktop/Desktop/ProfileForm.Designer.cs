namespace Desktop
{
    partial class ProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOK = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbConfirmPasswordPrifile = new System.Windows.Forms.TextBox();
            this.lblPasswordConfirm = new System.Windows.Forms.Label();
            this.tbPasswordProfile = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.tbCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbxViewPassword = new System.Windows.Forms.CheckBox();
            this.panelPasswords = new System.Windows.Forms.Panel();
            this.panelPasswords.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(159, 197);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(23, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(159, 27);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(153, 20);
            this.tbName.TabIndex = 0;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(159, 53);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(153, 20);
            this.tbEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Location = new System.Drawing.Point(23, 57);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "E-mail";
            // 
            // tbConfirmPasswordPrifile
            // 
            this.tbConfirmPasswordPrifile.Location = new System.Drawing.Point(157, 58);
            this.tbConfirmPasswordPrifile.Name = "tbConfirmPasswordPrifile";
            this.tbConfirmPasswordPrifile.Size = new System.Drawing.Size(153, 20);
            this.tbConfirmPasswordPrifile.TabIndex = 4;
            this.tbConfirmPasswordPrifile.UseSystemPasswordChar = true;
            // 
            // lblPasswordConfirm
            // 
            this.lblPasswordConfirm.AutoSize = true;
            this.lblPasswordConfirm.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordConfirm.Location = new System.Drawing.Point(21, 62);
            this.lblPasswordConfirm.Name = "lblPasswordConfirm";
            this.lblPasswordConfirm.Size = new System.Drawing.Size(113, 13);
            this.lblPasswordConfirm.TabIndex = 9;
            this.lblPasswordConfirm.Text = "Password confirmation";
            // 
            // tbPasswordProfile
            // 
            this.tbPasswordProfile.Location = new System.Drawing.Point(157, 32);
            this.tbPasswordProfile.Name = "tbPasswordProfile";
            this.tbPasswordProfile.Size = new System.Drawing.Size(153, 20);
            this.tbPasswordProfile.TabIndex = 3;
            this.tbPasswordProfile.UseSystemPasswordChar = true;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPassword.Location = new System.Drawing.Point(21, 35);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(78, 13);
            this.lblNewPassword.TabIndex = 11;
            this.lblNewPassword.Text = "New Password";
            // 
            // tbCurrentPassword
            // 
            this.tbCurrentPassword.Location = new System.Drawing.Point(157, 6);
            this.tbCurrentPassword.Name = "tbCurrentPassword";
            this.tbCurrentPassword.Size = new System.Drawing.Size(153, 20);
            this.tbCurrentPassword.TabIndex = 2;
            this.tbCurrentPassword.UseSystemPasswordChar = true;
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPassword.Location = new System.Drawing.Point(21, 9);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(89, 13);
            this.lblCurrentPassword.TabIndex = 13;
            this.lblCurrentPassword.Text = "Current password";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(237, 197);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbxViewPassword
            // 
            this.cbxViewPassword.AutoSize = true;
            this.cbxViewPassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxViewPassword.Location = new System.Drawing.Point(157, 84);
            this.cbxViewPassword.Name = "cbxViewPassword";
            this.cbxViewPassword.Size = new System.Drawing.Size(107, 18);
            this.cbxViewPassword.TabIndex = 5;
            this.cbxViewPassword.Text = "Show password";
            this.cbxViewPassword.UseVisualStyleBackColor = true;
            this.cbxViewPassword.CheckedChanged += new System.EventHandler(this.cbxViewPassword_CheckedChanged);
            // 
            // panelPasswords
            // 
            this.panelPasswords.BackColor = System.Drawing.Color.Transparent;
            this.panelPasswords.Controls.Add(this.lblCurrentPassword);
            this.panelPasswords.Controls.Add(this.cbxViewPassword);
            this.panelPasswords.Controls.Add(this.lblPasswordConfirm);
            this.panelPasswords.Controls.Add(this.tbConfirmPasswordPrifile);
            this.panelPasswords.Controls.Add(this.tbCurrentPassword);
            this.panelPasswords.Controls.Add(this.lblNewPassword);
            this.panelPasswords.Controls.Add(this.tbPasswordProfile);
            this.panelPasswords.Location = new System.Drawing.Point(2, 79);
            this.panelPasswords.Name = "panelPasswords";
            this.panelPasswords.Size = new System.Drawing.Size(338, 117);
            this.panelPasswords.TabIndex = 21;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Desktop.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(341, 230);
            this.Controls.Add(this.panelPasswords);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfileForm";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.panelPasswords.ResumeLayout(false);
            this.panelPasswords.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbConfirmPasswordPrifile;
        private System.Windows.Forms.Label lblPasswordConfirm;
        private System.Windows.Forms.TextBox tbPasswordProfile;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox tbCurrentPassword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbxViewPassword;
        private System.Windows.Forms.Panel panelPasswords;
    }
}