namespace Desktop_project
{
    partial class OutlaysForm
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
            this.groupBoxPeriod = new System.Windows.Forms.GroupBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.groupBoxCategory = new System.Windows.Forms.GroupBox();
            this.comboBoxPeriod = new System.Windows.Forms.ComboBox();
            this.labelFromDateRef = new System.Windows.Forms.Label();
            this.labelToDateRef = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.groupBoxPeriod.SuspendLayout();
            this.groupBoxCategory.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPeriod
            // 
            this.groupBoxPeriod.Controls.Add(this.panel1);
            this.groupBoxPeriod.Controls.Add(this.comboBoxPeriod);
            this.groupBoxPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxPeriod.Location = new System.Drawing.Point(20, 90);
            this.groupBoxPeriod.Name = "groupBoxPeriod";
            this.groupBoxPeriod.Size = new System.Drawing.Size(250, 195);
            this.groupBoxPeriod.TabIndex = 0;
            this.groupBoxPeriod.TabStop = false;
            this.groupBoxPeriod.Text = "Period";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.AutoCompleteCustomSource.AddRange(new string[] {
            "Any"});
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Any"});
            this.comboBoxCategory.Location = new System.Drawing.Point(30, 30);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(150, 21);
            this.comboBoxCategory.TabIndex = 2;
            // 
            // groupBoxCategory
            // 
            this.groupBoxCategory.Controls.Add(this.comboBoxCategory);
            this.groupBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCategory.Location = new System.Drawing.Point(20, 329);
            this.groupBoxCategory.Name = "groupBoxCategory";
            this.groupBoxCategory.Size = new System.Drawing.Size(250, 100);
            this.groupBoxCategory.TabIndex = 0;
            this.groupBoxCategory.TabStop = false;
            this.groupBoxCategory.Text = "Category";
            // 
            // comboBoxPeriod
            // 
            this.comboBoxPeriod.FormattingEnabled = true;
            this.comboBoxPeriod.Items.AddRange(new object[] {
            "Yesterday",
            "Last 3 days",
            "Last week"});
            this.comboBoxPeriod.Location = new System.Drawing.Point(30, 30);
            this.comboBoxPeriod.Name = "comboBoxPeriod";
            this.comboBoxPeriod.Size = new System.Drawing.Size(200, 21);
            this.comboBoxPeriod.TabIndex = 1;
            // 
            // labelFromDateRef
            // 
            this.labelFromDateRef.AutoSize = true;
            this.labelFromDateRef.Location = new System.Drawing.Point(20, 10);
            this.labelFromDateRef.Name = "labelFromDateRef";
            this.labelFromDateRef.Size = new System.Drawing.Size(38, 13);
            this.labelFromDateRef.TabIndex = 2;
            this.labelFromDateRef.Text = "From:";
            // 
            // labelToDateRef
            // 
            this.labelToDateRef.AutoSize = true;
            this.labelToDateRef.Location = new System.Drawing.Point(20, 70);
            this.labelToDateRef.Name = "labelToDateRef";
            this.labelToDateRef.Size = new System.Drawing.Size(26, 13);
            this.labelToDateRef.TabIndex = 3;
            this.labelToDateRef.Text = "To:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePickerFrom);
            this.panel1.Controls.Add(this.dateTimePickerTo);
            this.panel1.Controls.Add(this.labelFromDateRef);
            this.panel1.Controls.Add(this.labelToDateRef);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 120);
            this.panel1.TabIndex = 4;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(20, 85);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 1;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(20, 30);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 4;
            // 
            // OutlaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Desktop_project.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 512);
            this.Controls.Add(this.groupBoxCategory);
            this.Controls.Add(this.groupBoxPeriod);
            this.Name = "OutlaysForm";
            this.Text = "My Outlays";
            this.groupBoxPeriod.ResumeLayout(false);
            this.groupBoxCategory.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPeriod;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.GroupBox groupBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxPeriod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label labelFromDateRef;
        private System.Windows.Forms.Label labelToDateRef;
    }
}