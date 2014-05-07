namespace Desktop
{
    partial class My_outlays
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.button_new_category = new System.Windows.Forms.Button();
            this.groupBox_period = new System.Windows.Forms.GroupBox();
            this.panel_custom_date = new System.Windows.Forms.Panel();
            this.labelStartDateRef = new System.Windows.Forms.Label();
            this.labelEndDateRef = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCategoryOutlays = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxViewAs = new System.Windows.Forms.ComboBox();
            this.labelViewAsRef = new System.Windows.Forms.Label();
            this.chart_outlays = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_table = new System.Windows.Forms.Panel();
            this.dataGridViewOutlays = new System.Windows.Forms.DataGridView();
            this.Column_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_chart = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_period.SuspendLayout();
            this.panel_custom_date.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_outlays)).BeginInit();
            this.panel_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutlays)).BeginInit();
            this.panel_chart.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(222, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "View As";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button_new_category);
            this.panel1.Controls.Add(this.groupBox_period);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 442);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxCategory);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(15, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 65);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(7, 20);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(184, 24);
            this.comboBoxCategory.TabIndex = 0;
            this.comboBoxCategory.Text = "Any";
            // 
            // button_new_category
            // 
            this.button_new_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_new_category.Location = new System.Drawing.Point(21, 279);
            this.button_new_category.Name = "button_new_category";
            this.button_new_category.Size = new System.Drawing.Size(117, 28);
            this.button_new_category.TabIndex = 1;
            this.button_new_category.Text = "New Category";
            this.button_new_category.UseVisualStyleBackColor = true;
            this.button_new_category.Click += new System.EventHandler(this.button_new_category_Click);
            // 
            // groupBox_period
            // 
            this.groupBox_period.AutoSize = true;
            this.groupBox_period.Controls.Add(this.panel_custom_date);
            this.groupBox_period.Controls.Add(this.comboBoxCategoryOutlays);
            this.groupBox_period.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_period.Location = new System.Drawing.Point(15, 20);
            this.groupBox_period.Name = "groupBox_period";
            this.groupBox_period.Size = new System.Drawing.Size(208, 166);
            this.groupBox_period.TabIndex = 3;
            this.groupBox_period.TabStop = false;
            this.groupBox_period.Text = "Period";
            // 
            // panel_custom_date
            // 
            this.panel_custom_date.Controls.Add(this.labelStartDateRef);
            this.panel_custom_date.Controls.Add(this.labelEndDateRef);
            this.panel_custom_date.Controls.Add(this.dateTimePickerStart);
            this.panel_custom_date.Controls.Add(this.dateTimePickerEnd);
            this.panel_custom_date.Location = new System.Drawing.Point(14, 49);
            this.panel_custom_date.Name = "panel_custom_date";
            this.panel_custom_date.Size = new System.Drawing.Size(177, 90);
            this.panel_custom_date.TabIndex = 6;
            this.panel_custom_date.Visible = false;
            this.panel_custom_date.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_custom_date_Paint);
            // 
            // labelStartDateRef
            // 
            this.labelStartDateRef.AutoSize = true;
            this.labelStartDateRef.Location = new System.Drawing.Point(3, 4);
            this.labelStartDateRef.Name = "labelStartDateRef";
            this.labelStartDateRef.Size = new System.Drawing.Size(44, 17);
            this.labelStartDateRef.TabIndex = 3;
            this.labelStartDateRef.Text = "From:";
            // 
            // labelEndDateRef
            // 
            this.labelEndDateRef.AutoSize = true;
            this.labelEndDateRef.Location = new System.Drawing.Point(3, 47);
            this.labelEndDateRef.Name = "labelEndDateRef";
            this.labelEndDateRef.Size = new System.Drawing.Size(29, 17);
            this.labelEndDateRef.TabIndex = 4;
            this.labelEndDateRef.Text = "To:";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(6, 24);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(168, 23);
            this.dateTimePickerStart.TabIndex = 1;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(6, 63);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(168, 23);
            this.dateTimePickerEnd.TabIndex = 2;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // comboBoxCategoryOutlays
            // 
            this.comboBoxCategoryOutlays.FormattingEnabled = true;
            this.comboBoxCategoryOutlays.Items.AddRange(new object[] {
            "Yesterday",
            "Last 3 days",
            "Last week",
            "Last month",
            "Last year",
            "Custom"});
            this.comboBoxCategoryOutlays.Location = new System.Drawing.Point(14, 19);
            this.comboBoxCategoryOutlays.Name = "comboBoxCategoryOutlays";
            this.comboBoxCategoryOutlays.Size = new System.Drawing.Size(177, 24);
            this.comboBoxCategoryOutlays.TabIndex = 0;
            this.comboBoxCategoryOutlays.Text = "Yesterday";
            this.comboBoxCategoryOutlays.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoryOutlays_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.comboBoxViewAs);
            this.panel2.Controls.Add(this.labelViewAsRef);
            this.panel2.Location = new System.Drawing.Point(244, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 45);
            this.panel2.TabIndex = 8;
            // 
            // comboBoxViewAs
            // 
            this.comboBoxViewAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxViewAs.FormattingEnabled = true;
            this.comboBoxViewAs.Items.AddRange(new object[] {
            "Chart",
            "Table"});
            this.comboBoxViewAs.Location = new System.Drawing.Point(110, 15);
            this.comboBoxViewAs.Name = "comboBoxViewAs";
            this.comboBoxViewAs.Size = new System.Drawing.Size(129, 24);
            this.comboBoxViewAs.TabIndex = 4;
            this.comboBoxViewAs.Text = "Chart";
            this.comboBoxViewAs.SelectedIndexChanged += new System.EventHandler(this.comboBoxViewAs_SelectedIndexChanged);
            // 
            // labelViewAsRef
            // 
            this.labelViewAsRef.AutoSize = true;
            this.labelViewAsRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelViewAsRef.Location = new System.Drawing.Point(14, 18);
            this.labelViewAsRef.Name = "labelViewAsRef";
            this.labelViewAsRef.Size = new System.Drawing.Size(57, 17);
            this.labelViewAsRef.TabIndex = 5;
            this.labelViewAsRef.Text = "View As";
            // 
            // chart_outlays
            // 
            this.chart_outlays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_outlays.BackColor = System.Drawing.Color.Transparent;
            this.chart_outlays.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Right;
            this.chart_outlays.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            chartArea1.Name = "ChartArea1";
            this.chart_outlays.ChartAreas.Add(chartArea1);
            this.chart_outlays.Location = new System.Drawing.Point(10, 10);
            this.chart_outlays.Name = "chart_outlays";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart_outlays.Series.Add(series1);
            this.chart_outlays.Size = new System.Drawing.Size(641, 367);
            this.chart_outlays.TabIndex = 0;
            this.chart_outlays.Text = "chart1";
            this.chart_outlays.Click += new System.EventHandler(this.chart_outlays_Click);
            // 
            // panel_table
            // 
            this.panel_table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_table.BackColor = System.Drawing.Color.Transparent;
            this.panel_table.Controls.Add(this.dataGridViewOutlays);
            this.panel_table.Location = new System.Drawing.Point(244, 45);
            this.panel_table.Name = "panel_table";
            this.panel_table.Padding = new System.Windows.Forms.Padding(10);
            this.panel_table.Size = new System.Drawing.Size(661, 397);
            this.panel_table.TabIndex = 9;
            this.panel_table.Visible = false;
            // 
            // dataGridViewOutlays
            // 
            this.dataGridViewOutlays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOutlays.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOutlays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutlays.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_num,
            this.Column_Title,
            this.Column_category,
            this.Column_description,
            this.Column_cost,
            this.Column_date});
            this.dataGridViewOutlays.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewOutlays.Name = "dataGridViewOutlays";
            this.dataGridViewOutlays.Size = new System.Drawing.Size(641, 377);
            this.dataGridViewOutlays.TabIndex = 0;
            // 
            // Column_num
            // 
            this.Column_num.HeaderText = " №";
            this.Column_num.Name = "Column_num";
            // 
            // Column_Title
            // 
            this.Column_Title.HeaderText = "Title";
            this.Column_Title.Name = "Column_Title";
            // 
            // Column_category
            // 
            this.Column_category.HeaderText = "Category";
            this.Column_category.Name = "Column_category";
            // 
            // Column_description
            // 
            this.Column_description.HeaderText = "Description";
            this.Column_description.Name = "Column_description";
            // 
            // Column_cost
            // 
            this.Column_cost.HeaderText = "Cost";
            this.Column_cost.Name = "Column_cost";
            // 
            // Column_date
            // 
            this.Column_date.HeaderText = "Date";
            this.Column_date.Name = "Column_date";
            // 
            // panel_chart
            // 
            this.panel_chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_chart.BackColor = System.Drawing.Color.Transparent;
            this.panel_chart.Controls.Add(this.chart_outlays);
            this.panel_chart.Location = new System.Drawing.Point(244, 42);
            this.panel_chart.Name = "panel_chart";
            this.panel_chart.Padding = new System.Windows.Forms.Padding(10);
            this.panel_chart.Size = new System.Drawing.Size(661, 387);
            this.panel_chart.TabIndex = 10;
            this.panel_chart.Visible = false;
            // 
            // My_outlays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Desktop.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 442);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_chart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_table);
            this.Name = "My_outlays";
            this.Text = "My Outlays";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox_period.ResumeLayout(false);
            this.panel_custom_date.ResumeLayout(false);
            this.panel_custom_date.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_outlays)).EndInit();
            this.panel_table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutlays)).EndInit();
            this.panel_chart.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_new_category;
        private System.Windows.Forms.GroupBox groupBox_period;
        private System.Windows.Forms.Panel panel_custom_date;
        private System.Windows.Forms.Label labelStartDateRef;
        private System.Windows.Forms.Label labelEndDateRef;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.ComboBox comboBoxCategoryOutlays;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxViewAs;
        private System.Windows.Forms.Label labelViewAsRef;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_outlays;
        private System.Windows.Forms.Panel panel_table;
        private System.Windows.Forms.DataGridView dataGridViewOutlays;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_date;
        private System.Windows.Forms.Panel panel_chart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxCategory;

    }
}