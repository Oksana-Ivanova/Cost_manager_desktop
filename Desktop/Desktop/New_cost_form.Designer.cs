namespace Desktop
{
    partial class New_cost_form
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
            this.dateTimePickerNewCost = new System.Windows.Forms.DateTimePicker();
            this.lblDateNewCost = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblDescriotion = new System.Windows.Forms.Label();
            this.richTextBoxDescriptionNewCost = new System.Windows.Forms.RichTextBox();
            this.tbNameNewCost = new System.Windows.Forms.TextBox();
            this.lblNameNewCost = new System.Windows.Forms.Label();
            this.lblCategoryNewCost = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusNewCost = new System.Windows.Forms.ToolStripStatusLabel();
            this.numValue = new System.Windows.Forms.NumericUpDown();
            this.btnNewCategory = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerNewCost
            // 
            this.dateTimePickerNewCost.Location = new System.Drawing.Point(84, 181);
            this.dateTimePickerNewCost.Name = "dateTimePickerNewCost";
            this.dateTimePickerNewCost.Size = new System.Drawing.Size(170, 20);
            this.dateTimePickerNewCost.TabIndex = 5;
            // 
            // lblDateNewCost
            // 
            this.lblDateNewCost.AutoSize = true;
            this.lblDateNewCost.BackColor = System.Drawing.Color.Transparent;
            this.lblDateNewCost.Location = new System.Drawing.Point(10, 187);
            this.lblDateNewCost.Name = "lblDateNewCost";
            this.lblDateNewCost.Size = new System.Drawing.Size(30, 13);
            this.lblDateNewCost.TabIndex = 19;
            this.lblDateNewCost.Text = "Date";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(179, 219);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(98, 219);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.BackColor = System.Drawing.Color.Transparent;
            this.lblValue.Location = new System.Drawing.Point(10, 156);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(34, 13);
            this.lblValue.TabIndex = 16;
            this.lblValue.Text = "Value";
            // 
            // lblDescriotion
            // 
            this.lblDescriotion.AutoSize = true;
            this.lblDescriotion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescriotion.Location = new System.Drawing.Point(10, 44);
            this.lblDescriotion.Name = "lblDescriotion";
            this.lblDescriotion.Size = new System.Drawing.Size(60, 13);
            this.lblDescriotion.TabIndex = 14;
            this.lblDescriotion.Text = "Description";
            // 
            // richTextBoxDescriptionNewCost
            // 
            this.richTextBoxDescriptionNewCost.Location = new System.Drawing.Point(84, 41);
            this.richTextBoxDescriptionNewCost.Name = "richTextBoxDescriptionNewCost";
            this.richTextBoxDescriptionNewCost.Size = new System.Drawing.Size(170, 82);
            this.richTextBoxDescriptionNewCost.TabIndex = 1;
            this.richTextBoxDescriptionNewCost.Text = "";
            this.richTextBoxDescriptionNewCost.TextChanged += new System.EventHandler(this.richTextBoxDescriptionNewCost_TextChanged);
            // 
            // tbNameNewCost
            // 
            this.tbNameNewCost.Location = new System.Drawing.Point(84, 17);
            this.tbNameNewCost.Name = "tbNameNewCost";
            this.tbNameNewCost.Size = new System.Drawing.Size(170, 20);
            this.tbNameNewCost.TabIndex = 0;
            // 
            // lblNameNewCost
            // 
            this.lblNameNewCost.AutoSize = true;
            this.lblNameNewCost.BackColor = System.Drawing.Color.Transparent;
            this.lblNameNewCost.Location = new System.Drawing.Point(10, 20);
            this.lblNameNewCost.Name = "lblNameNewCost";
            this.lblNameNewCost.Size = new System.Drawing.Size(35, 13);
            this.lblNameNewCost.TabIndex = 11;
            this.lblNameNewCost.Text = "Name";
            // 
            // lblCategoryNewCost
            // 
            this.lblCategoryNewCost.AutoSize = true;
            this.lblCategoryNewCost.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoryNewCost.Location = new System.Drawing.Point(10, 130);
            this.lblCategoryNewCost.Name = "lblCategoryNewCost";
            this.lblCategoryNewCost.Size = new System.Drawing.Size(49, 13);
            this.lblCategoryNewCost.TabIndex = 21;
            this.lblCategoryNewCost.Text = "Category";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "Household,",
            "Business,",
            "Health"});
            this.cboCategory.Location = new System.Drawing.Point(84, 127);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(141, 21);
            this.cboCategory.TabIndex = 3;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusNewCost});
            this.statusStrip1.Location = new System.Drawing.Point(0, 261);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(298, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // StatusNewCost
            // 
            this.StatusNewCost.Name = "StatusNewCost";
            this.StatusNewCost.Size = new System.Drawing.Size(42, 17);
            this.StatusNewCost.Text = "Status:";
            // 
            // numValue
            // 
            this.numValue.DecimalPlaces = 2;
            this.numValue.Location = new System.Drawing.Point(84, 154);
            this.numValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numValue.Name = "numValue";
            this.numValue.Size = new System.Drawing.Size(170, 20);
            this.numValue.TabIndex = 4;
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewCategory.Location = new System.Drawing.Point(231, 125);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(23, 23);
            this.btnNewCategory.TabIndex = 24;
            this.btnNewCategory.Text = "+";
            this.btnNewCategory.UseVisualStyleBackColor = true;
            this.btnNewCategory.Click += new System.EventHandler(this.btnNewCategory_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(13, 219);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // New_cost_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Desktop.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(294, 262);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNewCategory);
            this.Controls.Add(this.numValue);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblCategoryNewCost);
            this.Controls.Add(this.dateTimePickerNewCost);
            this.Controls.Add(this.lblDateNewCost);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblDescriotion);
            this.Controls.Add(this.richTextBoxDescriptionNewCost);
            this.Controls.Add(this.tbNameNewCost);
            this.Controls.Add(this.lblNameNewCost);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "New_cost_form";
            this.Text = "New cost";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerNewCost;
        private System.Windows.Forms.Label lblDateNewCost;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblDescriotion;
        private System.Windows.Forms.RichTextBox richTextBoxDescriptionNewCost;
        private System.Windows.Forms.TextBox tbNameNewCost;
        private System.Windows.Forms.Label lblNameNewCost;
        private System.Windows.Forms.Label lblCategoryNewCost;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ToolStripStatusLabel StatusNewCost;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.NumericUpDown numValue;
        private System.Windows.Forms.Button btnNewCategory;
        private System.Windows.Forms.Button btnDelete;
    }
}