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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox_period = new System.Windows.Forms.GroupBox();
            this.panel_custom_date = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_new_cost = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_table = new System.Windows.Forms.Panel();
            this.panel_chart = new System.Windows.Forms.Panel();
            this.chart_outlays = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_period.SuspendLayout();
            this.panel_custom_date.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_table.SuspendLayout();
            this.panel_chart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_outlays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_period
            // 
            this.groupBox_period.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_period.Controls.Add(this.panel_custom_date);
            this.groupBox_period.Controls.Add(this.comboBox1);
            this.groupBox_period.Location = new System.Drawing.Point(12, 69);
            this.groupBox_period.Name = "groupBox_period";
            this.groupBox_period.Size = new System.Drawing.Size(200, 153);
            this.groupBox_period.TabIndex = 3;
            this.groupBox_period.TabStop = false;
            this.groupBox_period.Text = "Period";
            // 
            // panel_custom_date
            // 
            this.panel_custom_date.Controls.Add(this.label2);
            this.panel_custom_date.Controls.Add(this.label3);
            this.panel_custom_date.Controls.Add(this.dateTimePicker1);
            this.panel_custom_date.Controls.Add(this.dateTimePicker2);
            this.panel_custom_date.Location = new System.Drawing.Point(6, 46);
            this.panel_custom_date.Name = "panel_custom_date";
            this.panel_custom_date.Size = new System.Drawing.Size(188, 90);
            this.panel_custom_date.TabIndex = 6;
            this.panel_custom_date.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "To:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 63);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
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
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button_new_cost);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category";
            // 
            // button_new_cost
            // 
            this.button_new_cost.Location = new System.Drawing.Point(14, 62);
            this.button_new_cost.Name = "button_new_cost";
            this.button_new_cost.Size = new System.Drawing.Size(75, 23);
            this.button_new_cost.TabIndex = 1;
            this.button_new_cost.Text = "New Cost";
            this.button_new_cost.UseVisualStyleBackColor = true;
            this.button_new_cost.Click += new System.EventHandler(this.button_new_cost_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(14, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Chart",
            "Table"});
            this.comboBox3.Location = new System.Drawing.Point(291, 33);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(222, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "View As";
            // 
            // panel_table
            // 
            this.panel_table.Controls.Add(this.panel_chart);
            this.panel_table.Controls.Add(this.dataGridView1);
            this.panel_table.Location = new System.Drawing.Point(225, 69);
            this.panel_table.Name = "panel_table";
            this.panel_table.Size = new System.Drawing.Size(673, 361);
            this.panel_table.TabIndex = 6;
            this.panel_table.Visible = false;
            this.panel_table.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_table_Paint);
            // 
            // panel_chart
            // 
            this.panel_chart.Controls.Add(this.chart_outlays);
            this.panel_chart.Location = new System.Drawing.Point(4, 0);
            this.panel_chart.Name = "panel_chart";
            this.panel_chart.Size = new System.Drawing.Size(645, 357);
            this.panel_chart.TabIndex = 7;
            this.panel_chart.Visible = false;
            // 
            // chart_outlays
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_outlays.ChartAreas.Add(chartArea3);
            this.chart_outlays.Location = new System.Drawing.Point(3, 3);
            this.chart_outlays.Name = "chart_outlays";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "Series1";
            this.chart_outlays.Series.Add(series3);
            this.chart_outlays.Size = new System.Drawing.Size(662, 349);
            this.chart_outlays.TabIndex = 0;
            this.chart_outlays.Text = "chart1";
            this.chart_outlays.Click += new System.EventHandler(this.chart_outlays_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(4, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 338);
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
            // My_outlays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Desktop.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 442);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel_table);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.groupBox_period);
            this.Name = "My_outlays";
            this.Text = "My_outlays";
            this.groupBox_period.ResumeLayout(false);
            this.panel_custom_date.ResumeLayout(false);
            this.panel_custom_date.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel_table.ResumeLayout(false);
            this.panel_chart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_outlays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_period;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_new_cost;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;

    }
}