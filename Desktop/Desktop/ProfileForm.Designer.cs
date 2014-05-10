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
            this.buttonUpdateProfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbConfirmPasswordPrifile = new System.Windows.Forms.TextBox();
            this.labelPasswordConfirm = new System.Windows.Forms.Label();
            this.tbPasswordProfile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCurrentPassword = new System.Windows.Forms.TextBox();
            this.labelCurrentPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUpdateProfile
            // 
            this.buttonUpdateProfile.Location = new System.Drawing.Point(237, 160);
            this.buttonUpdateProfile.Name = "buttonUpdateProfile";
            this.buttonUpdateProfile.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateProfile.TabIndex = 0;
            this.buttonUpdateProfile.Text = "Update";
            this.buttonUpdateProfile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(159, 53);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(153, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(23, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-mail";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbConfirmPasswordPrifile
            // 
            this.tbConfirmPasswordPrifile.Location = new System.Drawing.Point(159, 105);
            this.tbConfirmPasswordPrifile.Name = "tbConfirmPasswordPrifile";
            this.tbConfirmPasswordPrifile.Size = new System.Drawing.Size(153, 20);
            this.tbConfirmPasswordPrifile.TabIndex = 10;
            // 
            // labelPasswordConfirm
            // 
            this.labelPasswordConfirm.AutoSize = true;
            this.labelPasswordConfirm.BackColor = System.Drawing.Color.Transparent;
            this.labelPasswordConfirm.Location = new System.Drawing.Point(23, 109);
            this.labelPasswordConfirm.Name = "labelPasswordConfirm";
            this.labelPasswordConfirm.Size = new System.Drawing.Size(113, 13);
            this.labelPasswordConfirm.TabIndex = 9;
            this.labelPasswordConfirm.Text = "Password confirmation";
            // 
            // tbPasswordProfile
            // 
            this.tbPasswordProfile.Location = new System.Drawing.Point(159, 79);
            this.tbPasswordProfile.Name = "tbPasswordProfile";
            this.tbPasswordProfile.Size = new System.Drawing.Size(153, 20);
            this.tbPasswordProfile.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(23, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password";
            // 
            // tbCurrentPassword
            // 
            this.tbCurrentPassword.Location = new System.Drawing.Point(159, 134);
            this.tbCurrentPassword.Name = "tbCurrentPassword";
            this.tbCurrentPassword.Size = new System.Drawing.Size(153, 20);
            this.tbCurrentPassword.TabIndex = 14;
            // 
            // labelCurrentPassword
            // 
            this.labelCurrentPassword.AutoSize = true;
            this.labelCurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentPassword.Location = new System.Drawing.Point(23, 137);
            this.labelCurrentPassword.Name = "labelCurrentPassword";
            this.labelCurrentPassword.Size = new System.Drawing.Size(89, 13);
            this.labelCurrentPassword.TabIndex = 13;
            this.labelCurrentPassword.Text = "Current password";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Desktop.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(337, 196);
            this.Controls.Add(this.tbCurrentPassword);
            this.Controls.Add(this.labelCurrentPassword);
            this.Controls.Add(this.tbPasswordProfile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbConfirmPasswordPrifile);
            this.Controls.Add(this.labelPasswordConfirm);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpdateProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfileForm";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdateProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbConfirmPasswordPrifile;
        private System.Windows.Forms.Label labelPasswordConfirm;
        private System.Windows.Forms.TextBox tbPasswordProfile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCurrentPassword;
        private System.Windows.Forms.Label labelCurrentPassword;
    }
}