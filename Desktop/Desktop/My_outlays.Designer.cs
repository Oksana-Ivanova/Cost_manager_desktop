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
            this.groupBox_period = new System.Windows.Forms.GroupBox();
            this.panel_custom_date = new System.Windows.Forms.Panel();
            this.labelStartDateRef = new System.Windows.Forms.Label();
            this.labelEndDateRef = new System.Windows.Forms.Label();
            this.panel_table = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button_new_cost = new System.Windows.Forms.Button();
            this.comboBoxViewAs = new System.Windows.Forms.ComboBox();
            this.labelViewAsRef = new System.Windows.Forms.Label();
            this.panel_chart = new System.Windows.Forms.Panel();
            this.chart_outlays = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox_period.SuspendLayout();
            this.panel_custom_date.SuspendLayout();
            this.panel_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel_chart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_outlays)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_period
            // 
            this.groupBox_period.Controls.Add(this.panel_custom_date);
            this.groupBox_period.Controls.Add(this.comboBox1);
            this.groupBox_period.Location = new System.Drawing.Point(15, 20);
            this.groupBox_period.Name = "groupBox_period";
            this.groupBox_period.Size = new System.Drawing.Size(200, 153);
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
            this.panel_custom_date.Location = new System.Drawing.Point(6, 46);
            this.panel_custom_date.Name = "panel_custom_date";
            this.panel_custom_date.Size = new System.Drawing.Size(188, 90);
            this.panel_custom_date.TabIndex = 6;
            this.panel_custom_date.Visible = false;
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
            // panel_table
            // 
            this.panel_table.Controls.Add(this.dataGridView1);
            this.panel_table.Location = new System.Drawing.Point(245, 250);
            this.panel_table.Name = "panel_table";
            this.panel_table.Padding = new System.Windows.Forms.Padding(10);
            this.panel_table.Size = new System.Drawing.Size(661, 192);
            this.panel_table.TabIndex = 6;
            this.panel_table.Visible = false;
            this.panel_table.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_table_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_num,
            this.Column_Title,
            this.Column_category,
            this.Column_description,
            this.Column_cost,
            this.Column_date});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 172);
            this.dataGridView1.TabIndex = 0;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Yesterday",
            "Last 3 days",
            "Last week",
            "Last month",
            "Last year",
            "Custom"});
            this.comboBox1.Location = new System.Drawing.Point(14, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Yesterday";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Location = new System.Drawing.Point(15, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 57);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(7, 20);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(184, 21);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.Text = "Any";
            // 
            // button_new_cost
            // 
            this.button_new_cost.Location = new System.Drawing.Point(21, 254);
            this.button_new_cost.Name = "button_new_cost";
            this.button_new_cost.Size = new System.Drawing.Size(80, 20);
            this.button_new_cost.TabIndex = 1;
            this.button_new_cost.Text = "New Cost";
            this.button_new_cost.UseVisualStyleBackColor = true;
            // 
            // comboBoxViewAs
            // 
            this.comboBoxViewAs.FormattingEnabled = true;
            this.comboBoxViewAs.Items.AddRange(new object[] {
            "Chart",
            "Table"});
            this.comboBoxViewAs.Location = new System.Drawing.Point(110, 15);
            this.comboBoxViewAs.Name = "comboBoxViewAs";
            this.comboBoxViewAs.Size = new System.Drawing.Size(121, 21);
            this.comboBoxViewAs.TabIndex = 4;
            this.comboBoxViewAs.Text = "Chart";
            this.comboBoxViewAs.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // labelViewAsRef
            // 
            this.labelViewAsRef.AutoSize = true;
            this.labelViewAsRef.Location = new System.Drawing.Point(14, 18);
            this.labelViewAsRef.Name = "labelViewAsRef";
            this.labelViewAsRef.Size = new System.Drawing.Size(45, 13);
            this.labelViewAsRef.TabIndex = 5;
            this.labelViewAsRef.Text = "View As";
            // 
            // panel_chart
            // 
            this.panel_chart.Controls.Add(this.chart_outlays);
            this.panel_chart.Location = new System.Drawing.Point(245, 42);
            this.panel_chart.Name = "panel_chart";
            this.panel_chart.Padding = new System.Windows.Forms.Padding(10);
            this.panel_chart.Size = new System.Drawing.Size(661, 209);
            this.panel_chart.TabIndex = 7;
            this.panel_chart.Visible = false;
            // 
            // chart_outlays
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_outlays.ChartAreas.Add(chartArea1);
            this.chart_outlays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart_outlays.Location = new System.Drawing.Point(10, 10);
            this.chart_outlays.Name = "chart_outlays";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart_outlays.Series.Add(series1);
            this.chart_outlays.Size = new System.Drawing.Size(641, 189);
            this.chart_outlays.TabIndex = 0;
            this.chart_outlays.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_new_cost);
            this.panel1.Controls.Add(this.groupBox_period);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 442);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBoxViewAs);
            this.panel2.Controls.Add(this.labelViewAsRef);
            this.panel2.Location = new System.Drawing.Point(245, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 45);
            this.panel2.TabIndex = 1;
            // 
            // My_outlays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 442);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_table);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_chart);
            this.Name = "My_outlays";
            this.Text = "My Outlays";
            this.groupBox_period.ResumeLayout(false);
            this.panel_custom_date.ResumeLayout(false);
            this.panel_custom_date.PerformLayout();
            this.panel_table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel_chart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_outlays)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_period;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_new_cost;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxViewAs;
        private System.Windows.Forms.Label labelViewAsRef;
        private System.Windows.Forms.Panel panel_table;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_date;
        private System.Windows.Forms.Panel panel_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_outlays;
        private System.Windows.Forms.Panel panel_custom_date;
        private System.Windows.Forms.Label labelStartDateRef;
        private System.Windows.Forms.Label labelEndDateRef;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;

    }
}