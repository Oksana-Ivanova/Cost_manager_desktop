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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxCategory = new System.Windows.Forms.GroupBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.btnNewCost = new System.Windows.Forms.Button();
            this.groupBoxPeriod = new System.Windows.Forms.GroupBox();
            this.panelCustomDate = new System.Windows.Forms.Panel();
            this.lblStartDateRef = new System.Windows.Forms.Label();
            this.lblEndDateRef = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.cboPeriod = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboViewAs = new System.Windows.Forms.ComboBox();
            this.lblViewAsRef = new System.Windows.Forms.Label();
            this.chart_outlays = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTable = new System.Windows.Forms.Panel();
            this.dataGridViewOutlays = new System.Windows.Forms.DataGridView();
            this.panelChart = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBoxCategory.SuspendLayout();
            this.groupBoxPeriod.SuspendLayout();
            this.panelCustomDate.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_outlays)).BeginInit();
            this.panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutlays)).BeginInit();
            this.panelChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.groupBoxCategory);
            this.panel1.Controls.Add(this.btnNewCost);
            this.panel1.Controls.Add(this.groupBoxPeriod);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 442);
            this.panel1.TabIndex = 7;
            // 
            // groupBoxCategory
            // 
            this.groupBoxCategory.Controls.Add(this.cboCategory);
            this.groupBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCategory.Location = new System.Drawing.Point(15, 192);
            this.groupBoxCategory.Name = "groupBoxCategory";
            this.groupBoxCategory.Size = new System.Drawing.Size(208, 65);
            this.groupBoxCategory.TabIndex = 4;
            this.groupBoxCategory.TabStop = false;
            this.groupBoxCategory.Text = "Category";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(7, 20);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(184, 24);
            this.cboCategory.TabIndex = 0;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // btnNewCost
            // 
            this.btnNewCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewCost.Location = new System.Drawing.Point(21, 279);
            this.btnNewCost.Name = "btnNewCost";
            this.btnNewCost.Size = new System.Drawing.Size(117, 28);
            this.btnNewCost.TabIndex = 1;
            this.btnNewCost.Text = "New Cost";
            this.btnNewCost.UseVisualStyleBackColor = true;
            this.btnNewCost.Click += new System.EventHandler(this.btnNewCost_Click);
            // 
            // groupBoxPeriod
            // 
            this.groupBoxPeriod.AutoSize = true;
            this.groupBoxPeriod.Controls.Add(this.panelCustomDate);
            this.groupBoxPeriod.Controls.Add(this.cboPeriod);
            this.groupBoxPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxPeriod.Location = new System.Drawing.Point(15, 20);
            this.groupBoxPeriod.Name = "groupBoxPeriod";
            this.groupBoxPeriod.Size = new System.Drawing.Size(208, 166);
            this.groupBoxPeriod.TabIndex = 3;
            this.groupBoxPeriod.TabStop = false;
            this.groupBoxPeriod.Text = "Period";
            // 
            // panelCustomDate
            // 
            this.panelCustomDate.Controls.Add(this.lblStartDateRef);
            this.panelCustomDate.Controls.Add(this.lblEndDateRef);
            this.panelCustomDate.Controls.Add(this.dateTimePickerStart);
            this.panelCustomDate.Controls.Add(this.dateTimePickerEnd);
            this.panelCustomDate.Location = new System.Drawing.Point(14, 49);
            this.panelCustomDate.Name = "panelCustomDate";
            this.panelCustomDate.Size = new System.Drawing.Size(177, 90);
            this.panelCustomDate.TabIndex = 6;
            // 
            // lblStartDateRef
            // 
            this.lblStartDateRef.AutoSize = true;
            this.lblStartDateRef.Location = new System.Drawing.Point(3, 4);
            this.lblStartDateRef.Name = "lblStartDateRef";
            this.lblStartDateRef.Size = new System.Drawing.Size(44, 17);
            this.lblStartDateRef.TabIndex = 3;
            this.lblStartDateRef.Text = "From:";
            // 
            // lblEndDateRef
            // 
            this.lblEndDateRef.AutoSize = true;
            this.lblEndDateRef.Location = new System.Drawing.Point(3, 47);
            this.lblEndDateRef.Name = "lblEndDateRef";
            this.lblEndDateRef.Size = new System.Drawing.Size(29, 17);
            this.lblEndDateRef.TabIndex = 4;
            this.lblEndDateRef.Text = "To:";
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
            // cboPeriod
            // 
            this.cboPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriod.FormattingEnabled = true;
            this.cboPeriod.Items.AddRange(new object[] {
            "Last week",
            "Last month",
            "Last year",
            "Custom"});
            this.cboPeriod.Location = new System.Drawing.Point(14, 19);
            this.cboPeriod.Name = "cboPeriod";
            this.cboPeriod.Size = new System.Drawing.Size(177, 24);
            this.cboPeriod.TabIndex = 0;
            this.cboPeriod.SelectedIndexChanged += new System.EventHandler(this.comboBoxPeriod_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.cboViewAs);
            this.panel2.Controls.Add(this.lblViewAsRef);
            this.panel2.Location = new System.Drawing.Point(244, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 45);
            this.panel2.TabIndex = 8;
            // 
            // cboViewAs
            // 
            this.cboViewAs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboViewAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboViewAs.FormattingEnabled = true;
            this.cboViewAs.Items.AddRange(new object[] {
            "Chart",
            "Table"});
            this.cboViewAs.Location = new System.Drawing.Point(110, 15);
            this.cboViewAs.Name = "cboViewAs";
            this.cboViewAs.Size = new System.Drawing.Size(129, 24);
            this.cboViewAs.TabIndex = 4;
            this.cboViewAs.SelectedIndexChanged += new System.EventHandler(this.comboBoxViewAs_SelectedIndexChanged);
            // 
            // lblViewAsRef
            // 
            this.lblViewAsRef.AutoSize = true;
            this.lblViewAsRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblViewAsRef.Location = new System.Drawing.Point(14, 18);
            this.lblViewAsRef.Name = "lblViewAsRef";
            this.lblViewAsRef.Size = new System.Drawing.Size(57, 17);
            this.lblViewAsRef.TabIndex = 5;
            this.lblViewAsRef.Text = "View As";
            // 
            // chart_outlays
            // 
            this.chart_outlays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_outlays.BackColor = System.Drawing.Color.Transparent;
            this.chart_outlays.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Right;
            this.chart_outlays.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            chartArea2.Name = "ChartArea1";
            this.chart_outlays.ChartAreas.Add(chartArea2);
            this.chart_outlays.Location = new System.Drawing.Point(10, 10);
            this.chart_outlays.Name = "chart_outlays";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series1";
            this.chart_outlays.Series.Add(series2);
            this.chart_outlays.Size = new System.Drawing.Size(641, 367);
            this.chart_outlays.TabIndex = 0;
            this.chart_outlays.Text = "chart1";
            this.chart_outlays.Click += new System.EventHandler(this.chart_outlays_Click);
            // 
            // panelTable
            // 
            this.panelTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTable.BackColor = System.Drawing.Color.Transparent;
            this.panelTable.Controls.Add(this.dataGridViewOutlays);
            this.panelTable.Location = new System.Drawing.Point(244, 45);
            this.panelTable.Name = "panelTable";
            this.panelTable.Padding = new System.Windows.Forms.Padding(10);
            this.panelTable.Size = new System.Drawing.Size(661, 397);
            this.panelTable.TabIndex = 9;
            this.panelTable.Visible = false;
            // 
            // dataGridViewOutlays
            // 
            this.dataGridViewOutlays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOutlays.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOutlays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutlays.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewOutlays.Name = "dataGridViewOutlays";
            this.dataGridViewOutlays.Size = new System.Drawing.Size(641, 377);
            this.dataGridViewOutlays.TabIndex = 0;
            this.dataGridViewOutlays.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOutlays_CellContentClick);
            this.dataGridViewOutlays.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridViewOutlays_ColumnAdded);
            // 
            // panelChart
            // 
            this.panelChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChart.BackColor = System.Drawing.Color.Transparent;
            this.panelChart.Controls.Add(this.chart_outlays);
            this.panelChart.Location = new System.Drawing.Point(244, 42);
            this.panelChart.Name = "panelChart";
            this.panelChart.Padding = new System.Windows.Forms.Padding(10);
            this.panelChart.Size = new System.Drawing.Size(661, 387);
            this.panelChart.TabIndex = 10;
            this.panelChart.Visible = false;
            // 
            // My_outlays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Desktop.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 442);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelChart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTable);
            this.Name = "My_outlays";
            this.Text = "My Outlays";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxCategory.ResumeLayout(false);
            this.groupBoxPeriod.ResumeLayout(false);
            this.panelCustomDate.ResumeLayout(false);
            this.panelCustomDate.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_outlays)).EndInit();
            this.panelTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutlays)).EndInit();
            this.panelChart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewCost;
        private System.Windows.Forms.GroupBox groupBoxPeriod;
        private System.Windows.Forms.Panel panelCustomDate;
        private System.Windows.Forms.Label lblStartDateRef;
        private System.Windows.Forms.Label lblEndDateRef;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.ComboBox cboPeriod;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboViewAs;
        private System.Windows.Forms.Label lblViewAsRef;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_outlays;
        private System.Windows.Forms.Panel panelTable;
        private System.Windows.Forms.DataGridView dataGridViewOutlays;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.GroupBox groupBoxCategory;
        private System.Windows.Forms.ComboBox cboCategory;

    }
}