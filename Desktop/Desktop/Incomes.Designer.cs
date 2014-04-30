namespace Desktop
{
    partial class Incomes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Decription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_period = new System.Windows.Forms.GroupBox();
            this.comboBoxPeriod = new System.Windows.Forms.ComboBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.labelStartDateRef = new System.Windows.Forms.Label();
            this.labelEndDateRef = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.panel_custom_date = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_period.SuspendLayout();
            this.panel_custom_date.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_num,
            this.Column_title,
            this.Column_Decription,
            this.Column_Value,
            this.Column_date});
            this.dataGridView1.Location = new System.Drawing.Point(258, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 312);
            this.dataGridView1.TabIndex = 1;
            // 
            // col_num
            // 
            this.col_num.HeaderText = "№";
            this.col_num.Name = "col_num";
            // 
            // Column_title
            // 
            this.Column_title.HeaderText = "Title";
            this.Column_title.Name = "Column_title";
            // 
            // Column_Decription
            // 
            this.Column_Decription.HeaderText = "Decription";
            this.Column_Decription.Name = "Column_Decription";
            // 
            // Column_Value
            // 
            this.Column_Value.HeaderText = "Value";
            this.Column_Value.Name = "Column_Value";
            // 
            // Column_date
            // 
            this.Column_date.HeaderText = "Date";
            this.Column_date.Name = "Column_date";
            // 
            // groupBox_period
            // 
            this.groupBox_period.Controls.Add(this.comboBoxPeriod);
            this.groupBox_period.Controls.Add(this.panel_custom_date);
            this.groupBox_period.Location = new System.Drawing.Point(12, 23);
            this.groupBox_period.Name = "groupBox_period";
            this.groupBox_period.Size = new System.Drawing.Size(219, 175);
            this.groupBox_period.TabIndex = 2;
            this.groupBox_period.TabStop = false;
            this.groupBox_period.Text = "Period";
            // 
            // comboBoxPeriod
            // 
            this.comboBoxPeriod.FormattingEnabled = true;
            this.comboBoxPeriod.Items.AddRange(new object[] {
            "Yesterday",
            "Last 3 days",
            "Last week",
            "Last month",
            "Last year",
            "Custom"});
            this.comboBoxPeriod.Location = new System.Drawing.Point(7, 20);
            this.comboBoxPeriod.Name = "comboBoxPeriod";
            this.comboBoxPeriod.Size = new System.Drawing.Size(185, 21);
            this.comboBoxPeriod.TabIndex = 0;
            this.comboBoxPeriod.Text = "Yesterday";
            this.comboBoxPeriod.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(6, 24);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(179, 20);
            this.dateTimePickerStart.TabIndex = 1;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(6, 63);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(179, 20);
            this.dateTimePickerEnd.TabIndex = 2;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // labelStartDateRef
            // 
            this.labelStartDateRef.AutoSize = true;
            this.labelStartDateRef.Location = new System.Drawing.Point(3, 5);
            this.labelStartDateRef.Name = "labelStartDateRef";
            this.labelStartDateRef.Size = new System.Drawing.Size(33, 13);
            this.labelStartDateRef.TabIndex = 3;
            this.labelStartDateRef.Text = "From:";
            // 
            // labelEndDateRef
            // 
            this.labelEndDateRef.AutoSize = true;
            this.labelEndDateRef.Location = new System.Drawing.Point(3, 47);
            this.labelEndDateRef.Name = "labelEndDateRef";
            this.labelEndDateRef.Size = new System.Drawing.Size(23, 13);
            this.labelEndDateRef.TabIndex = 4;
            this.labelEndDateRef.Text = "To:";
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(30, 215);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(80, 20);
            this.buttonNew.TabIndex = 3;
            this.buttonNew.Text = "Add new";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_custom_date
            // 
            this.panel_custom_date.Controls.Add(this.labelStartDateRef);
            this.panel_custom_date.Controls.Add(this.labelEndDateRef);
            this.panel_custom_date.Controls.Add(this.dateTimePickerStart);
            this.panel_custom_date.Controls.Add(this.dateTimePickerEnd);
            this.panel_custom_date.Location = new System.Drawing.Point(7, 63);
            this.panel_custom_date.Name = "panel_custom_date";
            this.panel_custom_date.Size = new System.Drawing.Size(195, 90);
            this.panel_custom_date.TabIndex = 5;
            this.panel_custom_date.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox_period);
            this.panel1.Controls.Add(this.buttonNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 393);
            this.panel1.TabIndex = 6;
            // 
            // Incomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 393);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Incomes";
            this.Text = "Incomes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_period.ResumeLayout(false);
            this.panel_custom_date.ResumeLayout(false);
            this.panel_custom_date.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Decription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_date;
        private System.Windows.Forms.GroupBox groupBox_period;
        private System.Windows.Forms.ComboBox comboBoxPeriod;
        private System.Windows.Forms.Panel panel_custom_date;
        private System.Windows.Forms.Label labelStartDateRef;
        private System.Windows.Forms.Label labelEndDateRef;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Panel panel1;
    }
}