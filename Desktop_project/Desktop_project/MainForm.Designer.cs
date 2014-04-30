namespace Desktop_project
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newIncomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOutlaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewIncomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLimitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxMostOftenCost = new System.Windows.Forms.GroupBox();
            this.labelWeekOutlay = new System.Windows.Forms.Label();
            this.labelCategoryName = new System.Windows.Forms.Label();
            this.labelOutlayRef = new System.Windows.Forms.Label();
            this.labelCategoryRef = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBoxBiggestCost = new System.Windows.Forms.GroupBox();
            this.labelWeekOutlay2 = new System.Windows.Forms.Label();
            this.labelCategoryName2 = new System.Windows.Forms.Label();
            this.labelOutlayRef2 = new System.Windows.Forms.Label();
            this.labelCategoryRef2 = new System.Windows.Forms.Label();
            this.buttonExamine = new System.Windows.Forms.Button();
            this.buttonExamine2 = new System.Windows.Forms.Button();
            this.buttonMore = new System.Windows.Forms.Button();
            this.labelTotalPerWeekRef = new System.Windows.Forms.Label();
            this.labelTotalPerWeek = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxMostOftenCost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBoxBiggestCost.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(984, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCostToolStripMenuItem,
            this.newCategoryToolStripMenuItem,
            this.newIncomeToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newCostToolStripMenuItem
            // 
            this.newCostToolStripMenuItem.Name = "newCostToolStripMenuItem";
            this.newCostToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newCostToolStripMenuItem.Text = "New Cost";
            // 
            // newCategoryToolStripMenuItem
            // 
            this.newCategoryToolStripMenuItem.Name = "newCategoryToolStripMenuItem";
            this.newCategoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newCategoryToolStripMenuItem.Text = "New Category";
            // 
            // newIncomeToolStripMenuItem
            // 
            this.newIncomeToolStripMenuItem.Name = "newIncomeToolStripMenuItem";
            this.newIncomeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newIncomeToolStripMenuItem.Text = "New Income";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewOutlaysToolStripMenuItem,
            this.viewIncomsToolStripMenuItem,
            this.viewLimitsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewOutlaysToolStripMenuItem
            // 
            this.viewOutlaysToolStripMenuItem.Name = "viewOutlaysToolStripMenuItem";
            this.viewOutlaysToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewOutlaysToolStripMenuItem.Text = "View Outlays";
            // 
            // viewIncomsToolStripMenuItem
            // 
            this.viewIncomsToolStripMenuItem.Name = "viewIncomsToolStripMenuItem";
            this.viewIncomsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewIncomsToolStripMenuItem.Text = "View Incoms";
            // 
            // viewLimitsToolStripMenuItem
            // 
            this.viewLimitsToolStripMenuItem.Name = "viewLimitsToolStripMenuItem";
            this.viewLimitsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewLimitsToolStripMenuItem.Text = "View Limits";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 488);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Desktop_project.Properties.Resources.bg;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 462);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Start Page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(970, 456);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Desktop_project.Properties.Resources.bg;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.labelTotalPerWeek);
            this.tabPage2.Controls.Add(this.labelTotalPerWeekRef);
            this.tabPage2.Controls.Add(this.buttonMore);
            this.tabPage2.Controls.Add(this.groupBoxBiggestCost);
            this.tabPage2.Controls.Add(this.groupBoxMostOftenCost);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recent costs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxMostOftenCost
            // 
            this.groupBoxMostOftenCost.Controls.Add(this.buttonExamine);
            this.groupBoxMostOftenCost.Controls.Add(this.labelWeekOutlay);
            this.groupBoxMostOftenCost.Controls.Add(this.labelCategoryName);
            this.groupBoxMostOftenCost.Controls.Add(this.labelOutlayRef);
            this.groupBoxMostOftenCost.Controls.Add(this.labelCategoryRef);
            this.groupBoxMostOftenCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMostOftenCost.Location = new System.Drawing.Point(572, 110);
            this.groupBoxMostOftenCost.Name = "groupBoxMostOftenCost";
            this.groupBoxMostOftenCost.Size = new System.Drawing.Size(275, 120);
            this.groupBoxMostOftenCost.TabIndex = 2;
            this.groupBoxMostOftenCost.TabStop = false;
            this.groupBoxMostOftenCost.Text = "The most often cost:";
            // 
            // labelWeekOutlay
            // 
            this.labelWeekOutlay.AutoSize = true;
            this.labelWeekOutlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWeekOutlay.Location = new System.Drawing.Point(120, 60);
            this.labelWeekOutlay.Name = "labelWeekOutlay";
            this.labelWeekOutlay.Size = new System.Drawing.Size(62, 13);
            this.labelWeekOutlay.TabIndex = 3;
            this.labelWeekOutlay.Text = "outlayValue";
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.AutoSize = true;
            this.labelCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategoryName.Location = new System.Drawing.Point(120, 30);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Size = new System.Drawing.Size(76, 13);
            this.labelCategoryName.TabIndex = 2;
            this.labelCategoryName.Text = "categoryName";
            // 
            // labelOutlayRef
            // 
            this.labelOutlayRef.AutoSize = true;
            this.labelOutlayRef.Location = new System.Drawing.Point(10, 60);
            this.labelOutlayRef.Name = "labelOutlayRef";
            this.labelOutlayRef.Size = new System.Drawing.Size(78, 13);
            this.labelOutlayRef.TabIndex = 1;
            this.labelOutlayRef.Text = "Total outlay:";
            // 
            // labelCategoryRef
            // 
            this.labelCategoryRef.AutoSize = true;
            this.labelCategoryRef.Location = new System.Drawing.Point(10, 30);
            this.labelCategoryRef.Name = "labelCategoryRef";
            this.labelCategoryRef.Size = new System.Drawing.Size(61, 13);
            this.labelCategoryRef.TabIndex = 0;
            this.labelCategoryRef.Text = "Category:";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(30, 70);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(500, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last week";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::Desktop_project.Properties.Resources.bg;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 462);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Recent incomes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBoxBiggestCost
            // 
            this.groupBoxBiggestCost.Controls.Add(this.buttonExamine2);
            this.groupBoxBiggestCost.Controls.Add(this.labelWeekOutlay2);
            this.groupBoxBiggestCost.Controls.Add(this.labelCategoryName2);
            this.groupBoxBiggestCost.Controls.Add(this.labelOutlayRef2);
            this.groupBoxBiggestCost.Controls.Add(this.labelCategoryRef2);
            this.groupBoxBiggestCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxBiggestCost.Location = new System.Drawing.Point(572, 260);
            this.groupBoxBiggestCost.Name = "groupBoxBiggestCost";
            this.groupBoxBiggestCost.Size = new System.Drawing.Size(275, 119);
            this.groupBoxBiggestCost.TabIndex = 4;
            this.groupBoxBiggestCost.TabStop = false;
            this.groupBoxBiggestCost.Text = "The biggest cost:";
            // 
            // labelWeekOutlay2
            // 
            this.labelWeekOutlay2.AutoSize = true;
            this.labelWeekOutlay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWeekOutlay2.Location = new System.Drawing.Point(120, 60);
            this.labelWeekOutlay2.Name = "labelWeekOutlay2";
            this.labelWeekOutlay2.Size = new System.Drawing.Size(62, 13);
            this.labelWeekOutlay2.TabIndex = 3;
            this.labelWeekOutlay2.Text = "outlayValue";
            // 
            // labelCategoryName2
            // 
            this.labelCategoryName2.AutoSize = true;
            this.labelCategoryName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategoryName2.Location = new System.Drawing.Point(120, 30);
            this.labelCategoryName2.Name = "labelCategoryName2";
            this.labelCategoryName2.Size = new System.Drawing.Size(76, 13);
            this.labelCategoryName2.TabIndex = 2;
            this.labelCategoryName2.Text = "categoryName";
            // 
            // labelOutlayRef2
            // 
            this.labelOutlayRef2.AutoSize = true;
            this.labelOutlayRef2.Location = new System.Drawing.Point(10, 60);
            this.labelOutlayRef2.Name = "labelOutlayRef2";
            this.labelOutlayRef2.Size = new System.Drawing.Size(78, 13);
            this.labelOutlayRef2.TabIndex = 1;
            this.labelOutlayRef2.Text = "Total outlay:";
            // 
            // labelCategoryRef2
            // 
            this.labelCategoryRef2.AutoSize = true;
            this.labelCategoryRef2.Location = new System.Drawing.Point(10, 30);
            this.labelCategoryRef2.Name = "labelCategoryRef2";
            this.labelCategoryRef2.Size = new System.Drawing.Size(61, 13);
            this.labelCategoryRef2.TabIndex = 0;
            this.labelCategoryRef2.Text = "Category:";
            // 
            // buttonExamine
            // 
            this.buttonExamine.Location = new System.Drawing.Point(120, 90);
            this.buttonExamine.Name = "buttonExamine";
            this.buttonExamine.Size = new System.Drawing.Size(75, 23);
            this.buttonExamine.TabIndex = 4;
            this.buttonExamine.Text = "Examine";
            this.buttonExamine.UseVisualStyleBackColor = true;
            this.buttonExamine.Click += new System.EventHandler(this.buttonExamine_Click);
            // 
            // buttonExamine2
            // 
            this.buttonExamine2.Location = new System.Drawing.Point(120, 90);
            this.buttonExamine2.Name = "buttonExamine2";
            this.buttonExamine2.Size = new System.Drawing.Size(75, 23);
            this.buttonExamine2.TabIndex = 5;
            this.buttonExamine2.Text = "Examine";
            this.buttonExamine2.UseVisualStyleBackColor = true;
            this.buttonExamine2.Click += new System.EventHandler(this.buttonExamine2_Click);
            // 
            // buttonMore
            // 
            this.buttonMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMore.Location = new System.Drawing.Point(675, 406);
            this.buttonMore.Name = "buttonMore";
            this.buttonMore.Size = new System.Drawing.Size(120, 23);
            this.buttonMore.TabIndex = 5;
            this.buttonMore.Text = "View More";
            this.buttonMore.UseVisualStyleBackColor = true;
            this.buttonMore.Click += new System.EventHandler(this.buttonMore_Click);
            // 
            // labelTotalPerWeekRef
            // 
            this.labelTotalPerWeekRef.AutoSize = true;
            this.labelTotalPerWeekRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalPerWeekRef.Location = new System.Drawing.Point(582, 81);
            this.labelTotalPerWeekRef.Name = "labelTotalPerWeekRef";
            this.labelTotalPerWeekRef.Size = new System.Drawing.Size(140, 13);
            this.labelTotalPerWeekRef.TabIndex = 5;
            this.labelTotalPerWeekRef.Text = "Total Outlay Per Week:";
            // 
            // labelTotalPerWeek
            // 
            this.labelTotalPerWeek.AutoSize = true;
            this.labelTotalPerWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalPerWeek.Location = new System.Drawing.Point(742, 81);
            this.labelTotalPerWeek.MinimumSize = new System.Drawing.Size(100, 0);
            this.labelTotalPerWeek.Name = "labelTotalPerWeek";
            this.labelTotalPerWeek.Size = new System.Drawing.Size(100, 13);
            this.labelTotalPerWeek.TabIndex = 5;
            this.labelTotalPerWeek.Text = "totalOutlayValue";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 512);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "Cost manager v0.00.04";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxMostOftenCost.ResumeLayout(false);
            this.groupBoxMostOftenCost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBoxBiggestCost.ResumeLayout(false);
            this.groupBoxBiggestCost.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newIncomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOutlaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewIncomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLimitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBoxMostOftenCost;
        private System.Windows.Forms.Label labelWeekOutlay;
        private System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.Label labelOutlayRef;
        private System.Windows.Forms.Label labelCategoryRef;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxBiggestCost;
        private System.Windows.Forms.Button buttonExamine2;
        private System.Windows.Forms.Label labelWeekOutlay2;
        private System.Windows.Forms.Label labelCategoryName2;
        private System.Windows.Forms.Label labelOutlayRef2;
        private System.Windows.Forms.Label labelCategoryRef2;
        private System.Windows.Forms.Button buttonExamine;
        private System.Windows.Forms.Button buttonMore;
        private System.Windows.Forms.Label labelTotalPerWeek;
        private System.Windows.Forms.Label labelTotalPerWeekRef;
    }
}