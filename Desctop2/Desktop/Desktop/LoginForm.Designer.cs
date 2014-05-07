namespace Desktop
{
    partial class LoginForm
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
            this.button_Ok = new System.Windows.Forms.Button();
            this.linkLabel_ForgotPass = new System.Windows.Forms.LinkLabel();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LabelStatusLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(89, 120);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(62, 23);
            this.button_Ok.TabIndex = 0;
            this.button_Ok.Text = "Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // linkLabel_ForgotPass
            // 
            this.linkLabel_ForgotPass.ActiveLinkColor = System.Drawing.Color.YellowGreen;
            this.linkLabel_ForgotPass.AutoSize = true;
            this.linkLabel_ForgotPass.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_ForgotPass.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel_ForgotPass.Location = new System.Drawing.Point(98, 97);
            this.linkLabel_ForgotPass.Name = "linkLabel_ForgotPass";
            this.linkLabel_ForgotPass.Size = new System.Drawing.Size(100, 13);
            this.linkLabel_ForgotPass.TabIndex = 1;
            this.linkLabel_ForgotPass.TabStop = true;
            this.linkLabel_ForgotPass.Text = "Forgot a password?";
            this.linkLabel_ForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ForgotPass_LinkClicked);
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(89, 31);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(136, 20);
            this.tbLogin.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(89, 63);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(136, 20);
            this.tbPassword.TabIndex = 3;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Location = new System.Drawing.Point(12, 31);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Login";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Location = new System.Drawing.Point(12, 63);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password";
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(161, 120);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(64, 23);
            this.button_Cancel.TabIndex = 6;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelStatusLogin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 146);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(261, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LabelStatusLogin
            // 
            this.LabelStatusLogin.BackColor = System.Drawing.Color.Transparent;
            this.LabelStatusLogin.Name = "LabelStatusLogin";
            this.LabelStatusLogin.Size = new System.Drawing.Size(42, 17);
            this.LabelStatusLogin.Text = "Status:";
            // 
            // LoginForm
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Desktop.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(261, 168);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.linkLabel_ForgotPass);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.LinkLabel linkLabel_ForgotPass;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LabelStatusLogin;

    }
}