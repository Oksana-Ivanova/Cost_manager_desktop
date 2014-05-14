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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbCategoryTitle = new System.Windows.Forms.TextBox();
            this.gbCategoryLimit = new System.Windows.Forms.GroupBox();
            this.numLimitValue = new System.Windows.Forms.NumericUpDown();
            this.cboLimitChecking = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.gbCategoryLimit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLimitValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(12, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // tbCategoryTitle
            // 
            this.tbCategoryTitle.Location = new System.Drawing.Point(44, 15);
            this.tbCategoryTitle.Name = "tbCategoryTitle";
            this.tbCategoryTitle.Size = new System.Drawing.Size(151, 20);
            this.tbCategoryTitle.TabIndex = 0;
            this.tbCategoryTitle.TextChanged += new System.EventHandler(this.tbCategoryTitle_TextChanged);
            this.tbCategoryTitle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCategoryTitle_KeyUp);
            // 
            // gbCategoryLimit
            // 
            this.gbCategoryLimit.BackColor = System.Drawing.Color.Transparent;
            this.gbCategoryLimit.Controls.Add(this.numLimitValue);
            this.gbCategoryLimit.Controls.Add(this.cboLimitChecking);
            this.gbCategoryLimit.Location = new System.Drawing.Point(8, 41);
            this.gbCategoryLimit.Name = "gbCategoryLimit";
            this.gbCategoryLimit.Size = new System.Drawing.Size(187, 111);
            this.gbCategoryLimit.TabIndex = 2;
            this.gbCategoryLimit.TabStop = false;
            this.gbCategoryLimit.Text = "Limit";
            // 
            // numLimitValue
            // 
            this.numLimitValue.DecimalPlaces = 2;
            this.numLimitValue.Location = new System.Drawing.Point(16, 71);
            this.numLimitValue.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numLimitValue.Name = "numLimitValue";
            this.numLimitValue.Size = new System.Drawing.Size(151, 20);
            this.numLimitValue.TabIndex = 2;
            // 
            // cboLimitChecking
            // 
            this.cboLimitChecking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLimitChecking.FormattingEnabled = true;
            this.cboLimitChecking.Items.AddRange(new object[] {
            "No Limit",
            "Limit per month"});
            this.cboLimitChecking.Location = new System.Drawing.Point(17, 29);
            this.cboLimitChecking.Name = "cboLimitChecking";
            this.cboLimitChecking.Size = new System.Drawing.Size(150, 21);
            this.cboLimitChecking.TabIndex = 1;
            this.cboLimitChecking.SelectedIndexChanged += new System.EventHandler(this.cboLimitChecking_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(120, 171);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(8, 171);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            this.btnOk.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnOk_KeyUp);
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
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbCategoryLimit);
            this.Controls.Add(this.tbCategoryTitle);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "New_Category_Form";
            this.ShowInTaskbar = false;
            this.Text = "New category";
            this.gbCategoryLimit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numLimitValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbCategoryTitle;
        private System.Windows.Forms.GroupBox gbCategoryLimit;
        private System.Windows.Forms.NumericUpDown numLimitValue;
        private System.Windows.Forms.ComboBox cboLimitChecking;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}