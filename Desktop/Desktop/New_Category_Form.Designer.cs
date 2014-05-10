namespace Desktop
{
    partial class New_Category_Form
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
            this.labelTitleCategory = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.gbLimitCategory = new System.Windows.Forms.GroupBox();
            this.numericUpDownLimit = new System.Windows.Forms.NumericUpDown();
            this.comboBox_Limit_Cheking = new System.Windows.Forms.ComboBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.gbLimitCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitleCategory
            // 
            this.labelTitleCategory.AutoSize = true;
            this.labelTitleCategory.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleCategory.Location = new System.Drawing.Point(12, 18);
            this.labelTitleCategory.Name = "labelTitleCategory";
            this.labelTitleCategory.Size = new System.Drawing.Size(27, 13);
            this.labelTitleCategory.TabIndex = 0;
            this.labelTitleCategory.Text = "Title";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(44, 15);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(151, 20);
            this.tbTitle.TabIndex = 1;
            // 
            // gbLimitCategory
            // 
            this.gbLimitCategory.BackColor = System.Drawing.Color.Transparent;
            this.gbLimitCategory.Controls.Add(this.numericUpDownLimit);
            this.gbLimitCategory.Controls.Add(this.comboBox_Limit_Cheking);
            this.gbLimitCategory.Location = new System.Drawing.Point(8, 41);
            this.gbLimitCategory.Name = "gbLimitCategory";
            this.gbLimitCategory.Size = new System.Drawing.Size(187, 111);
            this.gbLimitCategory.TabIndex = 2;
            this.gbLimitCategory.TabStop = false;
            this.gbLimitCategory.Text = "Limit";
            // 
            // numericUpDownLimit
            // 
            this.numericUpDownLimit.DecimalPlaces = 2;
            this.numericUpDownLimit.Location = new System.Drawing.Point(16, 71);
            this.numericUpDownLimit.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownLimit.Name = "numericUpDownLimit";
            this.numericUpDownLimit.Size = new System.Drawing.Size(151, 20);
            this.numericUpDownLimit.TabIndex = 1;            
            // 
            // comboBox_Limit_Cheking
            // 
            this.comboBox_Limit_Cheking.FormattingEnabled = true;
            this.comboBox_Limit_Cheking.Items.AddRange(new object[] {
            "No Limit",
            "Per week",
            "Per month"});
            this.comboBox_Limit_Cheking.Location = new System.Drawing.Point(17, 29);
            this.comboBox_Limit_Cheking.Name = "comboBox_Limit_Cheking";
            this.comboBox_Limit_Cheking.Size = new System.Drawing.Size(150, 21);
            this.comboBox_Limit_Cheking.TabIndex = 0;
            this.comboBox_Limit_Cheking.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(120, 171);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 20;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(39, 171);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 19;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // New_Category_Form
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Desktop.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(206, 206);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.gbLimitCategory);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.labelTitleCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "New_Category_Form";
            this.ShowInTaskbar = false;
            this.Text = "New category";
            this.gbLimitCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleCategory;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.GroupBox gbLimitCategory;
        private System.Windows.Forms.NumericUpDown numericUpDownLimit;
        private System.Windows.Forms.ComboBox comboBox_Limit_Cheking;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_ok;
    }
}