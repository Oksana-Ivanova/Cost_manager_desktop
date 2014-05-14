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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageStart = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSrartPage = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelTotalOutlays = new System.Windows.Forms.Panel();
            this.buttonDetailedOutlays = new System.Windows.Forms.Button();
            this.labelTotalOutlayPerWeek = new System.Windows.Forms.Label();
            this.labelTotalOutlayPerWeekRef2 = new System.Windows.Forms.Label();
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
            this.chart_recent_cost = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panelTotalIncome = new System.Windows.Forms.Panel();
            this.buttonDetalisedIncomes = new System.Windows.Forms.Button();
            this.labelTotalIncomePerWeek = new System.Windows.Forms.Label();
            this.labelTotallIncomePerLastWeek = new System.Windows.Forms.Label();
            this.dataGridViewRecentIncomes = new System.Windows.Forms.DataGridView();
            this.linkLabelLogOut = new System.Windows.Forms.LinkLabel();
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
            this.tabControl.SuspendLayout();
            this.tabPageStart.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelTotalOutlays.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxMostOften.SuspendLayout();
            this.groupBoxBiggestCost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_recent_cost)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panelTotalIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecentIncomes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageStart);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(896, 400);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageStart
            // 
            this.tabPageStart.BackgroundImage = global::Desktop.Properties.Resources.bg;
            this.tabPageStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageStart.Controls.Add(this.groupBox1);
            this.tabPageStart.Location = new System.Drawing.Point(4, 25);
            this.tabPageStart.Name = "tabPageStart";
            this.tabPageStart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStart.Size = new System.Drawing.Size(888, 371);
            this.tabPageStart.TabIndex = 0;
            this.tabPageStart.Text = "StartPage";
            this.tabPageStart.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.labelSrartPage);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(882, 365);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Як зберегти та примножити гроші (поради фахівців)";
            // 
            // labelSrartPage
            // 
            this.labelSrartPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSrartPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSrartPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSrartPage.Location = new System.Drawing.Point(6, 22);
            this.labelSrartPage.Name = "labelSrartPage";
            this.labelSrartPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSrartPage.Size = new System.Drawing.Size(870, 338);
            this.labelSrartPage.TabIndex = 1;
            this.labelSrartPage.Text = resources.GetString("labelSrartPage.Text");
            this.labelSrartPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Desktop.Properties.Resources.bg;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.panelTotalOutlays);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.chart_recent_cost);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(888, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recent Cost";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelTotalOutlays
            // 
            this.panelTotalOutlays.AutoSize = true;
            this.panelTotalOutlays.BackColor = System.Drawing.Color.Transparent;
            this.panelTotalOutlays.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTotalOutlays.Controls.Add(this.buttonDetailedOutlays);
            this.panelTotalOutlays.Controls.Add(this.labelTotalOutlayPerWeek);
            this.panelTotalOutlays.Controls.Add(this.labelTotalOutlayPerWeekRef2);
            this.panelTotalOutlays.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTotalOutlays.Location = new System.Drawing.Point(3, 337);
            this.panelTotalOutlays.Name = "panelTotalOutlays";
            this.panelTotalOutlays.Size = new System.Drawing.Size(882, 31);
            this.panelTotalOutlays.TabIndex = 12;
            // 
            // buttonDetailedOutlays
            // 
            this.buttonDetailedOutlays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDetailedOutlays.Location = new System.Drawing.Point(400, 3);
            this.buttonDetailedOutlays.Name = "buttonDetailedOutlays";
            this.buttonDetailedOutlays.Size = new System.Drawing.Size(120, 25);
            this.buttonDetailedOutlays.TabIndex = 7;
            this.buttonDetailedOutlays.Text = "View more";
            this.buttonDetailedOutlays.UseVisualStyleBackColor = true;
            this.buttonDetailedOutlays.Click += new System.EventHandler(this.buttonDetailedOutlays_Click);
            // 
            // labelTotalOutlayPerWeek
            // 
            this.labelTotalOutlayPerWeek.AutoSize = true;
            this.labelTotalOutlayPerWeek.Location = new System.Drawing.Point(200, 9);
            this.labelTotalOutlayPerWeek.Name = "labelTotalOutlayPerWeek";
            this.labelTotalOutlayPerWeek.Size = new System.Drawing.Size(169, 17);
            this.labelTotalOutlayPerWeek.TabIndex = 8;
            this.labelTotalOutlayPerWeek.Text = "labelTotalOutlayPerWeek";
            // 
            // labelTotalOutlayPerWeekRef2
            // 
            this.labelTotalOutlayPerWeekRef2.AutoSize = true;
            this.labelTotalOutlayPerWeekRef2.Location = new System.Drawing.Point(30, 9);
            this.labelTotalOutlayPerWeekRef2.Name = "labelTotalOutlayPerWeekRef2";
            this.labelTotalOutlayPerWeekRef2.Size = new System.Drawing.Size(176, 17);
            this.labelTotalOutlayPerWeekRef2.TabIndex = 1;
            this.labelTotalOutlayPerWeekRef2.Text = "Total outlays per last week";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.groupBoxMostOften);
            this.panel1.Controls.Add(this.groupBoxBiggestCost);
            this.panel1.Location = new System.Drawing.Point(590, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 321);
            this.panel1.TabIndex = 9;
            // 
            // groupBoxMostOften
            // 
            this.groupBoxMostOften.Controls.Add(this.labelWeekOutlay);
            this.groupBoxMostOften.Controls.Add(this.labelCategoryName);
            this.groupBoxMostOften.Controls.Add(this.buttonExamine);
            this.groupBoxMostOften.Controls.Add(this.labelOutlayRef);
            this.groupBoxMostOften.Controls.Add(this.labelCategoryRef);
            this.groupBoxMostOften.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMostOften.Location = new System.Drawing.Point(15, 22);
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
            this.labelWeekOutlay.Size = new System.Drawing.Size(82, 17);
            this.labelWeekOutlay.TabIndex = 6;
            this.labelWeekOutlay.Text = "outlayValue";
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.AutoSize = true;
            this.labelCategoryName.Location = new System.Drawing.Point(120, 30);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Size = new System.Drawing.Size(100, 17);
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
            this.labelOutlayRef.Size = new System.Drawing.Size(86, 17);
            this.labelOutlayRef.TabIndex = 1;
            this.labelOutlayRef.Text = "Total outlay:";
            // 
            // labelCategoryRef
            // 
            this.labelCategoryRef.AutoSize = true;
            this.labelCategoryRef.Location = new System.Drawing.Point(10, 30);
            this.labelCategoryRef.Name = "labelCategoryRef";
            this.labelCategoryRef.Size = new System.Drawing.Size(69, 17);
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
            this.groupBoxBiggestCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxBiggestCost.Location = new System.Drawing.Point(15, 160);
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
            this.labelWeekOutlay2.Size = new System.Drawing.Size(82, 17);
            this.labelWeekOutlay2.TabIndex = 6;
            this.labelWeekOutlay2.Text = "outlayValue";
            // 
            // labelCategoryName2
            // 
            this.labelCategoryName2.AutoSize = true;
            this.labelCategoryName2.Location = new System.Drawing.Point(120, 30);
            this.labelCategoryName2.Name = "labelCategoryName2";
            this.labelCategoryName2.Size = new System.Drawing.Size(100, 17);
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
            this.labelOutlayRef2.Size = new System.Drawing.Size(86, 17);
            this.labelOutlayRef2.TabIndex = 1;
            this.labelOutlayRef2.Text = "Total outlay:";
            // 
            // labelCategoryRef2
            // 
            this.labelCategoryRef2.AutoSize = true;
            this.labelCategoryRef2.Location = new System.Drawing.Point(10, 30);
            this.labelCategoryRef2.Name = "labelCategoryRef2";
            this.labelCategoryRef2.Size = new System.Drawing.Size(69, 17);
            this.labelCategoryRef2.TabIndex = 0;
            this.labelCategoryRef2.Text = "Category:";
            // 
            // chart_recent_cost
            // 
            this.chart_recent_cost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_recent_cost.BackColor = System.Drawing.Color.Transparent;
            this.chart_recent_cost.BorderlineColor = System.Drawing.SystemColors.ActiveBorder;
            chartArea1.Name = "ChartArea1";
            this.chart_recent_cost.ChartAreas.Add(chartArea1);
            this.chart_recent_cost.Location = new System.Drawing.Point(-4, 14);
            this.chart_recent_cost.Name = "chart_recent_cost";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart_recent_cost.Series.Add(series1);
            this.chart_recent_cost.Size = new System.Drawing.Size(588, 310);
            this.chart_recent_cost.TabIndex = 8;
            this.chart_recent_cost.Text = "Last week";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::Desktop.Properties.Resources.bg;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.panelTotalIncome);
            this.tabPage3.Controls.Add(this.dataGridViewRecentIncomes);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(888, 371);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Recent Incomes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panelTotalIncome
            // 
            this.panelTotalIncome.AutoSize = true;
            this.panelTotalIncome.BackColor = System.Drawing.Color.Transparent;
            this.panelTotalIncome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTotalIncome.Controls.Add(this.buttonDetalisedIncomes);
            this.panelTotalIncome.Controls.Add(this.labelTotalIncomePerWeek);
            this.panelTotalIncome.Controls.Add(this.labelTotallIncomePerLastWeek);
            this.panelTotalIncome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTotalIncome.Location = new System.Drawing.Point(0, 340);
            this.panelTotalIncome.Name = "panelTotalIncome";
            this.panelTotalIncome.Size = new System.Drawing.Size(888, 31);
            this.panelTotalIncome.TabIndex = 12;
            // 
            // buttonDetalisedIncomes
            // 
            this.buttonDetalisedIncomes.Location = new System.Drawing.Point(400, 3);
            this.buttonDetalisedIncomes.Name = "buttonDetalisedIncomes";
            this.buttonDetalisedIncomes.Size = new System.Drawing.Size(120, 25);
            this.buttonDetalisedIncomes.TabIndex = 7;
            this.buttonDetalisedIncomes.Text = "View more";
            this.buttonDetalisedIncomes.UseVisualStyleBackColor = true;
            this.buttonDetalisedIncomes.Click += new System.EventHandler(this.buttonDetalisedIncomes_Click);
            // 
            // labelTotalIncomePerWeek
            // 
            this.labelTotalIncomePerWeek.AutoSize = true;
            this.labelTotalIncomePerWeek.Location = new System.Drawing.Point(200, 9);
            this.labelTotalIncomePerWeek.Name = "labelTotalIncomePerWeek";
            this.labelTotalIncomePerWeek.Size = new System.Drawing.Size(200, 17);
            this.labelTotalIncomePerWeek.TabIndex = 8;
            this.labelTotalIncomePerWeek.Text = "labelTotalIncomePerLastWeek";
            // 
            // labelTotallIncomePerLastWeek
            // 
            this.labelTotallIncomePerLastWeek.AutoSize = true;
            this.labelTotallIncomePerLastWeek.Location = new System.Drawing.Point(30, 9);
            this.labelTotallIncomePerLastWeek.Name = "labelTotallIncomePerLastWeek";
            this.labelTotallIncomePerLastWeek.Size = new System.Drawing.Size(176, 17);
            this.labelTotallIncomePerLastWeek.TabIndex = 1;
            this.labelTotallIncomePerLastWeek.Text = "Total income per last week";
            // 
            // dataGridViewRecentIncomes
            // 
            this.dataGridViewRecentIncomes.AllowUserToAddRows = false;
            this.dataGridViewRecentIncomes.AllowUserToDeleteRows = false;
            this.dataGridViewRecentIncomes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRecentIncomes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRecentIncomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecentIncomes.Location = new System.Drawing.Point(8, 42);
            this.dataGridViewRecentIncomes.Name = "dataGridViewRecentIncomes";
            this.dataGridViewRecentIncomes.ReadOnly = true;
            this.dataGridViewRecentIncomes.Size = new System.Drawing.Size(872, 250);
            this.dataGridViewRecentIncomes.TabIndex = 0;
            this.dataGridViewRecentIncomes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ColumnEdit_Clic);
            this.dataGridViewRecentIncomes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewRecentIncomes.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridViewRecentIncomes_ColumnAdded);
            // 
            // linkLabelLogOut
            // 
            this.linkLabelLogOut.ActiveLinkColor = System.Drawing.Color.YellowGreen;
            this.linkLabelLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelLogOut.AutoSize = true;
            this.linkLabelLogOut.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelLogOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.linkLabelLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelLogOut.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabelLogOut.Location = new System.Drawing.Point(755, 2);
            this.linkLabelLogOut.Name = "linkLabelLogOut";
            this.linkLabelLogOut.Size = new System.Drawing.Size(64, 22);
            this.linkLabelLogOut.TabIndex = 2;
            this.linkLabelLogOut.TabStop = true;
            this.linkLabelLogOut.Text = "LogOut";
            this.linkLabelLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogOut_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::Desktop.Properties.Resources.bg;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.moreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 27);
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
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newCostToolStripMenuItem
            // 
            this.newCostToolStripMenuItem.Name = "newCostToolStripMenuItem";
            this.newCostToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.newCostToolStripMenuItem.Text = "New Cost";
            this.newCostToolStripMenuItem.Click += new System.EventHandler(this.newCostToolStripMenuItem_Click);
            // 
            // newCategoryToolStripMenuItem
            // 
            this.newCategoryToolStripMenuItem.Name = "newCategoryToolStripMenuItem";
            this.newCategoryToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.newCategoryToolStripMenuItem.Text = "New Category";
            this.newCategoryToolStripMenuItem.Click += new System.EventHandler(this.newCategoryToolStripMenuItem_Click);
            // 
            // newIncomeToolStripMenuItem
            // 
            this.newIncomeToolStripMenuItem.Name = "newIncomeToolStripMenuItem";
            this.newIncomeToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.newIncomeToolStripMenuItem.Text = "New Income";
            this.newIncomeToolStripMenuItem.Click += new System.EventHandler(this.newIncomeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewOutlaysToolStripMenuItem,
            this.viewIncomesToolStripMenuItem});
            this.viewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(50, 23);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewOutlaysToolStripMenuItem
            // 
            this.viewOutlaysToolStripMenuItem.Name = "viewOutlaysToolStripMenuItem";
            this.viewOutlaysToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.viewOutlaysToolStripMenuItem.Text = "View Outlays";
            this.viewOutlaysToolStripMenuItem.Click += new System.EventHandler(this.viewOutlaysToolStripMenuItem_Click);
            // 
            // viewIncomesToolStripMenuItem
            // 
            this.viewIncomesToolStripMenuItem.Name = "viewIncomesToolStripMenuItem";
            this.viewIncomesToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.viewIncomesToolStripMenuItem.Text = "View Incomes";
            this.viewIncomesToolStripMenuItem.Click += new System.EventHandler(this.viewIncomesToolStripMenuItem_Click);
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.moreToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(54, 23);
            this.moreToolStripMenuItem.Text = "More";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 427);
            this.Controls.Add(this.linkLabelLogOut);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Cost Manager v0.09";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageStart.ResumeLayout(false);
            this.tabPageStart.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panelTotalOutlays.ResumeLayout(false);
            this.panelTotalOutlays.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBoxMostOften.ResumeLayout(false);
            this.groupBoxMostOften.PerformLayout();
            this.groupBoxBiggestCost.ResumeLayout(false);
            this.groupBoxBiggestCost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_recent_cost)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panelTotalIncome.ResumeLayout(false);
            this.panelTotalIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecentIncomes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageStart;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewRecentIncomes;
        private System.Windows.Forms.LinkLabel linkLabelLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxMostOften;
        private System.Windows.Forms.Label labelWeekOutlay;
        private System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.Button buttonExamine;
        private System.Windows.Forms.Label labelOutlayRef;
        private System.Windows.Forms.Label labelCategoryRef;
        private System.Windows.Forms.GroupBox groupBoxBiggestCost;
        private System.Windows.Forms.Label labelWeekOutlay2;
        private System.Windows.Forms.Label labelCategoryName2;
        private System.Windows.Forms.Button buttonExamine2;
        private System.Windows.Forms.Label labelOutlayRef2;
        private System.Windows.Forms.Label labelCategoryRef2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_recent_cost;
        private System.Windows.Forms.Panel panelTotalOutlays;
        private System.Windows.Forms.Button buttonDetailedOutlays;
        private System.Windows.Forms.Label labelTotalOutlayPerWeek;
        private System.Windows.Forms.Label labelTotalOutlayPerWeekRef2;
        private System.Windows.Forms.Panel panelTotalIncome;
        private System.Windows.Forms.Button buttonDetalisedIncomes;
        private System.Windows.Forms.Label labelTotalIncomePerWeek;
        private System.Windows.Forms.Label labelTotallIncomePerLastWeek;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSrartPage;
    }
}

