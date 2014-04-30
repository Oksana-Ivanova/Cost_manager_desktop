namespace Desktop
{
    partial class Main
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newIncomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOutlaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewIncomesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFirst = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPageRecentCosts = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTotalPerWeek = new System.Windows.Forms.Label();
            this.labelTotalPerWeekRef = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxMostOften = new System.Windows.Forms.GroupBox();
            this.labelWeekOutlay = new System.Windows.Forms.Label();
            this.labelCategoryName = new System.Windows.Forms.Label();
            this.buttonExamine = new System.Windows.Forms.Button();
            this.labelOutlayRef = new System.Windows.Forms.Label();
            this.labelCategoryRef = new System.Windows.Forms.Label();
            this.groupBoxBiggestCost = new System.Windows.Forms.GroupBox();
            this.labelWeekOutlay2 = new System.Windows.Forms.Label();
            this.labelCategoryName2 = new System.Windows.Forms.Label();
            this.buttonExamine2 = new System.Windows.Forms.Button();
            this.labelOutlayRef2 = new System.Windows.Forms.Label();
            this.labelCategoryRef2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart_recent_cost = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageRecentIncomes = new System.Windows.Forms.TabPage();
            this.panel = new System.Windows.Forms.Panel();
            this.buttonDetailedIncomes = new System.Windows.Forms.Button();
            this.labelTotalPerWeek2 = new System.Windows.Forms.Label();
            this.labelTotalPerWeekRef2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Decription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageFirst.SuspendLayout();
            this.tabPageRecentCosts.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxMostOften.SuspendLayout();
            this.groupBoxBiggestCost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_recent_cost)).BeginInit();
            this.tabPageRecentIncomes.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.moreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCostToolStripMenuItem,
            this.newCategoryToolStripMenuItem,
            this.newIncomeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newCostToolStripMenuItem
            // 
            this.newCostToolStripMenuItem.Name = "newCostToolStripMenuItem";
            this.newCostToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.newCostToolStripMenuItem.Text = "New Cost";
            // 
            // newCategoryToolStripMenuItem
            // 
            this.newCategoryToolStripMenuItem.Name = "newCategoryToolStripMenuItem";
            this.newCategoryToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.newCategoryToolStripMenuItem.Text = "New Category";
            // 
            // newIncomeToolStripMenuItem
            // 
            this.newIncomeToolStripMenuItem.Name = "newIncomeToolStripMenuItem";
            this.newIncomeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.newIncomeToolStripMenuItem.Text = "New Income";
            this.newIncomeToolStripMenuItem.Click += new System.EventHandler(this.newIncomeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewOutlaysToolStripMenuItem,
            this.viewIncomesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewOutlaysToolStripMenuItem
            // 
            this.viewOutlaysToolStripMenuItem.Name = "viewOutlaysToolStripMenuItem";
            this.viewOutlaysToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.viewOutlaysToolStripMenuItem.Text = "View Outlays";
            this.viewOutlaysToolStripMenuItem.Click += new System.EventHandler(this.viewOutlaysToolStripMenuItem_Click);
            // 
            // viewIncomesToolStripMenuItem
            // 
            this.viewIncomesToolStripMenuItem.Name = "viewIncomesToolStripMenuItem";
            this.viewIncomesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.viewIncomesToolStripMenuItem.Text = "View Incomes";
            this.viewIncomesToolStripMenuItem.Click += new System.EventHandler(this.viewIncomesToolStripMenuItem_Click);
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.moreToolStripMenuItem.Text = "More";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFirst);
            this.tabControl1.Controls.Add(this.tabPageRecentCosts);
            this.tabControl1.Controls.Add(this.tabPageRecentIncomes);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(869, 403);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageFirst
            // 
            this.tabPageFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPageFirst.Controls.Add(this.label7);
            this.tabPageFirst.Location = new System.Drawing.Point(4, 22);
            this.tabPageFirst.Name = "tabPageFirst";
            this.tabPageFirst.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFirst.Size = new System.Drawing.Size(861, 377);
            this.tabPageFirst.TabIndex = 0;
            this.tabPageFirst.Text = "StartPage";
            this.tabPageFirst.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(695, 200);
            this.label7.TabIndex = 0;
            this.label7.Text = resources.GetString("label7.Text");
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPageRecentCosts
            // 
            this.tabPageRecentCosts.Controls.Add(this.panel2);
            this.tabPageRecentCosts.Controls.Add(this.panel1);
            this.tabPageRecentCosts.Controls.Add(this.label1);
            this.tabPageRecentCosts.Controls.Add(this.chart_recent_cost);
            this.tabPageRecentCosts.Location = new System.Drawing.Point(4, 22);
            this.tabPageRecentCosts.Name = "tabPageRecentCosts";
            this.tabPageRecentCosts.Padding = new System.Windows.Forms.Padding(7);
            this.tabPageRecentCosts.Size = new System.Drawing.Size(861, 377);
            this.tabPageRecentCosts.TabIndex = 1;
            this.tabPageRecentCosts.Text = "Recent Cost";
            this.tabPageRecentCosts.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.labelTotalPerWeek);
            this.panel2.Controls.Add(this.labelTotalPerWeekRef);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(7, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 38);
            this.panel2.TabIndex = 8;
            // 
            // labelTotalPerWeek
            // 
            this.labelTotalPerWeek.AutoSize = true;
            this.labelTotalPerWeek.Location = new System.Drawing.Point(200, 16);
            this.labelTotalPerWeek.Name = "labelTotalPerWeek";
            this.labelTotalPerWeek.Size = new System.Drawing.Size(98, 13);
            this.labelTotalPerWeek.TabIndex = 8;
            this.labelTotalPerWeek.Text = "labelTotalPerWeek";
            // 
            // labelTotalPerWeekRef
            // 
            this.labelTotalPerWeekRef.AutoSize = true;
            this.labelTotalPerWeekRef.Location = new System.Drawing.Point(30, 16);
            this.labelTotalPerWeekRef.Name = "labelTotalPerWeekRef";
            this.labelTotalPerWeekRef.Size = new System.Drawing.Size(128, 13);
            this.labelTotalPerWeekRef.TabIndex = 7;
            this.labelTotalPerWeekRef.Text = "Total outlay per last week";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(400, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 25);
            this.button3.TabIndex = 6;
            this.button3.Text = "View more";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.groupBoxMostOften);
            this.panel1.Controls.Add(this.groupBoxBiggestCost);
            this.panel1.Location = new System.Drawing.Point(551, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 325);
            this.panel1.TabIndex = 7;
            // 
            // groupBoxMostOften
            // 
            this.groupBoxMostOften.Controls.Add(this.labelWeekOutlay);
            this.groupBoxMostOften.Controls.Add(this.labelCategoryName);
            this.groupBoxMostOften.Controls.Add(this.buttonExamine);
            this.groupBoxMostOften.Controls.Add(this.labelOutlayRef);
            this.groupBoxMostOften.Controls.Add(this.labelCategoryRef);
            this.groupBoxMostOften.Location = new System.Drawing.Point(20, 20);
            this.groupBoxMostOften.Name = "groupBoxMostOften";
            this.groupBoxMostOften.Size = new System.Drawing.Size(275, 120);
            this.groupBoxMostOften.TabIndex = 2;
            this.groupBoxMostOften.TabStop = false;
            this.groupBoxMostOften.Text = "The most often cost:";
            // 
            // labelWeekOutlay
            // 
            this.labelWeekOutlay.AutoSize = true;
            this.labelWeekOutlay.Location = new System.Drawing.Point(120, 60);
            this.labelWeekOutlay.Name = "labelWeekOutlay";
            this.labelWeekOutlay.Size = new System.Drawing.Size(62, 13);
            this.labelWeekOutlay.TabIndex = 6;
            this.labelWeekOutlay.Text = "outlayValue";
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.AutoSize = true;
            this.labelCategoryName.Location = new System.Drawing.Point(120, 30);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Size = new System.Drawing.Size(76, 13);
            this.labelCategoryName.TabIndex = 5;
            this.labelCategoryName.Text = "categoryName";
            // 
            // buttonExamine
            // 
            this.buttonExamine.Location = new System.Drawing.Point(120, 90);
            this.buttonExamine.Name = "buttonExamine";
            this.buttonExamine.Size = new System.Drawing.Size(75, 23);
            this.buttonExamine.TabIndex = 4;
            this.buttonExamine.Text = "Examine";
            this.buttonExamine.UseVisualStyleBackColor = true;
            // 
            // labelOutlayRef
            // 
            this.labelOutlayRef.AutoSize = true;
            this.labelOutlayRef.Location = new System.Drawing.Point(10, 60);
            this.labelOutlayRef.Name = "labelOutlayRef";
            this.labelOutlayRef.Size = new System.Drawing.Size(65, 13);
            this.labelOutlayRef.TabIndex = 1;
            this.labelOutlayRef.Text = "Total outlay:";
            // 
            // labelCategoryRef
            // 
            this.labelCategoryRef.AutoSize = true;
            this.labelCategoryRef.Location = new System.Drawing.Point(10, 30);
            this.labelCategoryRef.Name = "labelCategoryRef";
            this.labelCategoryRef.Size = new System.Drawing.Size(52, 13);
            this.labelCategoryRef.TabIndex = 0;
            this.labelCategoryRef.Text = "Category:";
            // 
            // groupBoxBiggestCost
            // 
            this.groupBoxBiggestCost.Controls.Add(this.labelWeekOutlay2);
            this.groupBoxBiggestCost.Controls.Add(this.labelCategoryName2);
            this.groupBoxBiggestCost.Controls.Add(this.buttonExamine2);
            this.groupBoxBiggestCost.Controls.Add(this.labelOutlayRef2);
            this.groupBoxBiggestCost.Controls.Add(this.labelCategoryRef2);
            this.groupBoxBiggestCost.Location = new System.Drawing.Point(20, 160);
            this.groupBoxBiggestCost.Name = "groupBoxBiggestCost";
            this.groupBoxBiggestCost.Size = new System.Drawing.Size(275, 120);
            this.groupBoxBiggestCost.TabIndex = 5;
            this.groupBoxBiggestCost.TabStop = false;
            this.groupBoxBiggestCost.Text = "The biggest cost:";
            // 
            // labelWeekOutlay2
            // 
            this.labelWeekOutlay2.AutoSize = true;
            this.labelWeekOutlay2.Location = new System.Drawing.Point(120, 60);
            this.labelWeekOutlay2.Name = "labelWeekOutlay2";
            this.labelWeekOutlay2.Size = new System.Drawing.Size(62, 13);
            this.labelWeekOutlay2.TabIndex = 6;
            this.labelWeekOutlay2.Text = "outlayValue";
            // 
            // labelCategoryName2
            // 
            this.labelCategoryName2.AutoSize = true;
            this.labelCategoryName2.Location = new System.Drawing.Point(120, 30);
            this.labelCategoryName2.Name = "labelCategoryName2";
            this.labelCategoryName2.Size = new System.Drawing.Size(76, 13);
            this.labelCategoryName2.TabIndex = 5;
            this.labelCategoryName2.Text = "categoryName";
            // 
            // buttonExamine2
            // 
            this.buttonExamine2.Location = new System.Drawing.Point(120, 90);
            this.buttonExamine2.Name = "buttonExamine2";
            this.buttonExamine2.Size = new System.Drawing.Size(75, 23);
            this.buttonExamine2.TabIndex = 4;
            this.buttonExamine2.Text = "Examine";
            this.buttonExamine2.UseVisualStyleBackColor = true;
            // 
            // labelOutlayRef2
            // 
            this.labelOutlayRef2.AutoSize = true;
            this.labelOutlayRef2.Location = new System.Drawing.Point(10, 60);
            this.labelOutlayRef2.Name = "labelOutlayRef2";
            this.labelOutlayRef2.Size = new System.Drawing.Size(65, 13);
            this.labelOutlayRef2.TabIndex = 1;
            this.labelOutlayRef2.Text = "Total outlay:";
            // 
            // labelCategoryRef2
            // 
            this.labelCategoryRef2.AutoSize = true;
            this.labelCategoryRef2.Location = new System.Drawing.Point(10, 30);
            this.labelCategoryRef2.Name = "labelCategoryRef2";
            this.labelCategoryRef2.Size = new System.Drawing.Size(52, 13);
            this.labelCategoryRef2.TabIndex = 0;
            this.labelCategoryRef2.Text = "Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(94, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Last week";
            // 
            // chart_recent_cost
            // 
            this.chart_recent_cost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart_recent_cost.ChartAreas.Add(chartArea1);
            this.chart_recent_cost.Location = new System.Drawing.Point(4, 31);
            this.chart_recent_cost.Name = "chart_recent_cost";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart_recent_cost.Series.Add(series1);
            this.chart_recent_cost.Size = new System.Drawing.Size(541, 307);
            this.chart_recent_cost.TabIndex = 0;
            this.chart_recent_cost.Text = "Last week";
            // 
            // tabPageRecentIncomes
            // 
            this.tabPageRecentIncomes.Controls.Add(this.panel);
            this.tabPageRecentIncomes.Controls.Add(this.dataGridView1);
            this.tabPageRecentIncomes.Location = new System.Drawing.Point(4, 22);
            this.tabPageRecentIncomes.Name = "tabPageRecentIncomes";
            this.tabPageRecentIncomes.Padding = new System.Windows.Forms.Padding(7);
            this.tabPageRecentIncomes.Size = new System.Drawing.Size(861, 377);
            this.tabPageRecentIncomes.TabIndex = 2;
            this.tabPageRecentIncomes.Text = "Recent Incomes";
            this.tabPageRecentIncomes.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.Controls.Add(this.buttonDetailedIncomes);
            this.panel.Controls.Add(this.labelTotalPerWeek2);
            this.panel.Controls.Add(this.labelTotalPerWeekRef2);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(7, 332);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(847, 38);
            this.panel.TabIndex = 8;
            // 
            // buttonDetailedIncomes
            // 
            this.buttonDetailedIncomes.Location = new System.Drawing.Point(400, 10);
            this.buttonDetailedIncomes.Name = "buttonDetailedIncomes";
            this.buttonDetailedIncomes.Size = new System.Drawing.Size(120, 25);
            this.buttonDetailedIncomes.TabIndex = 7;
            this.buttonDetailedIncomes.Text = "View more";
            this.buttonDetailedIncomes.UseVisualStyleBackColor = true;
            this.buttonDetailedIncomes.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelTotalPerWeek2
            // 
            this.labelTotalPerWeek2.AutoSize = true;
            this.labelTotalPerWeek2.Location = new System.Drawing.Point(200, 16);
            this.labelTotalPerWeek2.Name = "labelTotalPerWeek2";
            this.labelTotalPerWeek2.Size = new System.Drawing.Size(104, 13);
            this.labelTotalPerWeek2.TabIndex = 8;
            this.labelTotalPerWeek2.Text = "labelTotalPerWeek2";
            // 
            // labelTotalPerWeekRef2
            // 
            this.labelTotalPerWeekRef2.AutoSize = true;
            this.labelTotalPerWeekRef2.Location = new System.Drawing.Point(30, 16);
            this.labelTotalPerWeekRef2.Name = "labelTotalPerWeekRef2";
            this.labelTotalPerWeekRef2.Size = new System.Drawing.Size(134, 13);
            this.labelTotalPerWeekRef2.TabIndex = 1;
            this.labelTotalPerWeekRef2.Text = "Total income per last week";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_num,
            this.Column_title,
            this.Column_Decription,
            this.Column_Value,
            this.Column_date});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(847, 363);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(869, 427);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Cost Manager v0.04";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageFirst.ResumeLayout(false);
            this.tabPageFirst.PerformLayout();
            this.tabPageRecentCosts.ResumeLayout(false);
            this.tabPageRecentCosts.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBoxMostOften.ResumeLayout(false);
            this.groupBoxMostOften.PerformLayout();
            this.groupBoxBiggestCost.ResumeLayout(false);
            this.groupBoxBiggestCost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_recent_cost)).EndInit();
            this.tabPageRecentIncomes.ResumeLayout(false);
            this.tabPageRecentIncomes.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newIncomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOutlaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewIncomesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFirst;
        private System.Windows.Forms.TabPage tabPageRecentCosts;
        private System.Windows.Forms.GroupBox groupBoxMostOften;
        private System.Windows.Forms.Label labelOutlayRef;
        private System.Windows.Forms.Label labelCategoryRef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_recent_cost;
        private System.Windows.Forms.TabPage tabPageRecentIncomes;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBoxBiggestCost;
        private System.Windows.Forms.Button buttonExamine2;
        private System.Windows.Forms.Label labelOutlayRef2;
        private System.Windows.Forms.Label labelCategoryRef2;
        private System.Windows.Forms.Button buttonExamine;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Decription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDetailedIncomes;
        private System.Windows.Forms.Label labelTotalPerWeek2;
        private System.Windows.Forms.Label labelTotalPerWeekRef2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelWeekOutlay;
        private System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.Label labelWeekOutlay2;
        private System.Windows.Forms.Label labelCategoryName2;
        private System.Windows.Forms.Label labelTotalPerWeek;
        private System.Windows.Forms.Label labelTotalPerWeekRef;
    }
}

