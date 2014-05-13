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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.groupBoxPeriod = new System.Windows.Forms.GroupBox();
            this.cboPeriod = new System.Windows.Forms.ComboBox();
            this.panelCustomDate = new System.Windows.Forms.Panel();
            this.lblStartDateRef = new System.Windows.Forms.Label();
            this.lblEndDateRef = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.btnNewIncome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncomes)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.groupBoxPeriod.SuspendLayout();
            this.panelCustomDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewIncomes
            // 
            this.dataGridViewIncomes.AllowUserToAddRows = false;
            this.dataGridViewIncomes.AllowUserToDeleteRows = false;
            this.dataGridViewIncomes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIncomes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewIncomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIncomes.Location = new System.Drawing.Point(258, 32);
            this.dataGridViewIncomes.Name = "dataGridViewIncomes";
            this.dataGridViewIncomes.ReadOnly = true;
            this.dataGridViewIncomes.Size = new System.Drawing.Size(547, 320);
            this.dataGridViewIncomes.TabIndex = 1;
            this.dataGridViewIncomes.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridViewIncomes_ColumnAdded);
            this.dataGridViewIncomes.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewIncomes_RowHeaderMouseDoubleClick);
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.Transparent;
            this.leftPanel.Controls.Add(this.groupBoxPeriod);
            this.leftPanel.Controls.Add(this.btnNewIncome);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(245, 393);
            this.leftPanel.TabIndex = 7;
            // 
            // groupBoxPeriod
            // 
            this.groupBoxPeriod.Controls.Add(this.cboPeriod);
            this.groupBoxPeriod.Controls.Add(this.panelCustomDate);
            this.groupBoxPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxPeriod.Location = new System.Drawing.Point(12, 23);
            this.groupBoxPeriod.Name = "groupBoxPeriod";
            this.groupBoxPeriod.Size = new System.Drawing.Size(219, 175);
            this.groupBoxPeriod.TabIndex = 2;
            this.groupBoxPeriod.TabStop = false;
            this.groupBoxPeriod.Text = "Period";
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
            this.cboPeriod.Location = new System.Drawing.Point(7, 20);
            this.cboPeriod.Name = "cboPeriod";
            this.cboPeriod.Size = new System.Drawing.Size(185, 24);
            this.cboPeriod.TabIndex = 0;
            this.cboPeriod.SelectedIndexChanged += new System.EventHandler(this.comboBoxPeriod_SelectedIndexChanged);
            // 
            // panelCustomDate
            // 
            this.panelCustomDate.Controls.Add(this.lblStartDateRef);
            this.panelCustomDate.Controls.Add(this.lblEndDateRef);
            this.panelCustomDate.Controls.Add(this.dateTimePickerStart);
            this.panelCustomDate.Controls.Add(this.dateTimePickerEnd);
            this.panelCustomDate.Location = new System.Drawing.Point(7, 63);
            this.panelCustomDate.Name = "panelCustomDate";
            this.panelCustomDate.Size = new System.Drawing.Size(195, 90);
            this.panelCustomDate.TabIndex = 5;
            // 
            // lblStartDateRef
            // 
            this.lblStartDateRef.AutoSize = true;
            this.lblStartDateRef.Location = new System.Drawing.Point(3, 5);
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
            this.dateTimePickerStart.MaxDate = new System.DateTime(2014, 5, 10, 0, 0, 0, 0);
            this.dateTimePickerStart.MinDate = new System.DateTime(2009, 5, 10, 0, 0, 0, 0);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(179, 23);
            this.dateTimePickerStart.TabIndex = 1;
            this.dateTimePickerStart.Value = new System.DateTime(2014, 5, 10, 0, 0, 0, 0);
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(6, 63);
            this.dateTimePickerEnd.MaxDate = new System.DateTime(2014, 5, 10, 0, 0, 0, 0);
            this.dateTimePickerEnd.MinDate = new System.DateTime(2009, 5, 10, 0, 0, 0, 0);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(179, 23);
            this.dateTimePickerEnd.TabIndex = 2;
            this.dateTimePickerEnd.Value = new System.DateTime(2014, 5, 10, 0, 0, 0, 0);
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // btnNewIncome
            // 
            this.btnNewIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewIncome.Location = new System.Drawing.Point(19, 216);
            this.btnNewIncome.Name = "btnNewIncome";
            this.btnNewIncome.Size = new System.Drawing.Size(87, 25);
            this.btnNewIncome.TabIndex = 3;
            this.btnNewIncome.Text = "Add new";
            this.btnNewIncome.UseVisualStyleBackColor = true;
            this.btnNewIncome.Click += new System.EventHandler(this.buttonNewIncome_Click);
            // 
            // Incomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Desktop.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 393);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.dataGridViewIncomes);
            this.Name = "Incomes";
            this.Text = "Incomes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncomes)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.groupBoxPeriod.ResumeLayout(false);
            this.panelCustomDate.ResumeLayout(false);
            this.panelCustomDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIncomes;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.GroupBox groupBoxPeriod;
        private System.Windows.Forms.ComboBox cboPeriod;
        private System.Windows.Forms.Panel panelCustomDate;
        private System.Windows.Forms.Label lblStartDateRef;
        private System.Windows.Forms.Label lblEndDateRef;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button btnNewIncome;
    }
}