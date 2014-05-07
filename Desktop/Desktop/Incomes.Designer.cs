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
            this.dataGridViewIncomes = new System.Windows.Forms.DataGridView();
            this.col_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Decription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox_period = new System.Windows.Forms.GroupBox();
            this.comboBoxPeriod = new System.Windows.Forms.ComboBox();
            this.panel_custom_date = new System.Windows.Forms.Panel();
            this.labelStartDateRef = new System.Windows.Forms.Label();
            this.labelEndDateRef = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.buttonNewIncome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncomes)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox_period.SuspendLayout();
            this.panel_custom_date.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewIncomes
            // 
            this.dataGridViewIncomes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewIncomes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIncomes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewIncomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIncomes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_num,
            this.Column_title,
            this.Column_Decription,
            this.Column_Value,
            this.Column_date});
            this.dataGridViewIncomes.Location = new System.Drawing.Point(258, 32);
            this.dataGridViewIncomes.Name = "dataGridViewIncomes";
            this.dataGridViewIncomes.Size = new System.Drawing.Size(547, 320);
            this.dataGridViewIncomes.TabIndex = 1;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.groupBox_period);
            this.panel1.Controls.Add(this.buttonNewIncome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 393);
            this.panel1.TabIndex = 7;
            // 
            // groupBox_period
            // 
            this.groupBox_period.Controls.Add(this.comboBoxPeriod);
            this.groupBox_period.Controls.Add(this.panel_custom_date);
            this.groupBox_period.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.comboBoxPeriod.Size = new System.Drawing.Size(185, 24);
            this.comboBoxPeriod.TabIndex = 0;
            this.comboBoxPeriod.Text = "Yesterday";
            this.comboBoxPeriod.SelectedIndexChanged += new System.EventHandler(this.comboBoxPeriod_SelectedIndexChanged);
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
            // labelStartDateRef
            // 
            this.labelStartDateRef.AutoSize = true;
            this.labelStartDateRef.Location = new System.Drawing.Point(3, 5);
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
            this.dateTimePickerStart.Size = new System.Drawing.Size(179, 23);
            this.dateTimePickerStart.TabIndex = 1;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(6, 63);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(179, 23);
            this.dateTimePickerEnd.TabIndex = 2;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // buttonNewIncome
            // 
            this.buttonNewIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewIncome.Location = new System.Drawing.Point(19, 216);
            this.buttonNewIncome.Name = "buttonNewIncome";
            this.buttonNewIncome.Size = new System.Drawing.Size(87, 25);
            this.buttonNewIncome.TabIndex = 3;
            this.buttonNewIncome.Text = "Add new";
            this.buttonNewIncome.UseVisualStyleBackColor = true;
            this.buttonNewIncome.Click += new System.EventHandler(this.buttonNewIncome_Click);
            // 
            // Incomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Desktop.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 393);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewIncomes);
            this.Name = "Incomes";
            this.Text = "Incomes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncomes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox_period.ResumeLayout(false);
            this.panel_custom_date.ResumeLayout(false);
            this.panel_custom_date.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIncomes;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Decription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox_period;
        private System.Windows.Forms.ComboBox comboBoxPeriod;
        private System.Windows.Forms.Panel panel_custom_date;
        private System.Windows.Forms.Label labelStartDateRef;
        private System.Windows.Forms.Label labelEndDateRef;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button buttonNewIncome;
    }
}