namespace Desktop
{
    partial class HelpForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Зайдіть у вкладку More->Profile, введіть новий і старий пароль або змініть свої д" +
         "ані, та підтвердіть зміни.");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Змінити пароль, персональні дані?", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Доходи за останній тиждень знаходяться на закладці RecentIncomes, для детальнішог" +
        "о перегляду за вказаним періодом зайдіть на вкладу View->Incomes");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Де переглянути доходи?", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Витрати за останній тиждень знаходяться на закладці RecentOutlays, для детальнішо" +
        "го перегляду зі вказаним періодом зайдіть на вкладу View->MyOutlays");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Де переглянути витрати?", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Нову категорію Ви можете створити у вікні New Category, яке знаходиться у File.");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Як створити нову категорію?", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Зайдіть у вікно Limits, у панелі View.");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Як мені змінити ліміти?", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("з допомогою вкладки Incomes можна вказати період, коли були отримані доходи;");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("на вкладці Limits є можливість встановити обмеження по певній категорії;");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Login- з допомогою цієї вкладки можна увійти на сайт, для цього потрібно ввести с" +
        "вій логін та пароль, також є змога відновити пароль, ");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("вкладка My_Outlays дозволяє побачити  витрати у вказаний період і в певній катего" +
        "рії, а також переглянути графік витрат;");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("на вкладці New Incomes вказуємо назву доходу, його опис, значення та  дату, коли " +
        "він був отриманий;");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("для створення нової категорії та задання ліміту використовуємо вкладку New_Catego" +
        "ry;");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("з допомогою вкладки New_cost вводимо назву нової вартості, також опис, значення, " +
        "обираємо категорію та  визначаємо дату;");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("редагувати особисту інформацію можна з допомогою вкладки Profile.");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Є кілька вкладок з різними можливостями", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Служба підтримки програмного забезпечення support_costs_manager@ukr.net");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Не знайшли те, що шукали?", new System.Windows.Forms.TreeNode[] {
            treeNode20});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Window;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.treeView1.LineColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Зайдіть у вкладку More->Profile, введіть новий і старий пароль або змініть свої д" +
    "ані, та підтвердіть зміни.";
            treeNode2.BackColor = System.Drawing.SystemColors.Window;
            treeNode2.ForeColor = System.Drawing.Color.Black;
            treeNode2.Name = "Node0";
            treeNode2.Text = "Змінити пароль, персональні дані?";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Доходи за останній тиждень знаходяться на закладці RecentIncomes, для детальнішог" +
    "о перегляду за вказаним періодом зайдіть на вкладу View->Incomes";
            treeNode4.Name = "Node2";
            treeNode4.Text = "Де переглянути доходи?";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Витрати за останній тиждень знаходяться на закладці RecentOutlays, для детальнішо" +
    "го перегляду зі вказаним періодом зайдіть на вкладу View->MyOutlays";
            treeNode6.Name = "Node4";
            treeNode6.Text = "Де переглянути витрати?";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Нову категорію Ви можете створити у вікні New Category, яке знаходиться у File.";
            treeNode8.Name = "Node6";
            treeNode8.Text = "Як створити нову категорію?";
            treeNode9.Name = "Node9";
            treeNode9.Text = "Зайдіть у вікно Limits, у панелі View.";
            treeNode10.Name = "Node8";
            treeNode10.Text = "Як мені змінити ліміти?";
            treeNode11.Name = "Узел1";
            treeNode11.Text = "з допомогою вкладки Incomes можна вказати період, коли були отримані доходи;";
            treeNode12.Name = "Узел3";
            treeNode12.Text = "на вкладці Limits є можливість встановити обмеження по певній категорії;";
            treeNode13.Name = "Узел4";
            treeNode13.Text = "Login- з допомогою цієї вкладки можна увійти на сайт, для цього потрібно ввести с" +
    "вій логін та пароль, також є змога відновити пароль, ";
            treeNode14.Name = "Узел5";
            treeNode14.Text = "вкладка My_Outlays дозволяє побачити  витрати у вказаний період і в певній катего" +
    "рії, а також переглянути графік витрат;";
            treeNode15.Name = "Узел6";
            treeNode15.Text = "на вкладці New Incomes вказуємо назву доходу, його опис, значення та  дату, коли " +
    "він був отриманий;";
            treeNode16.Name = "Узел7";
            treeNode16.Text = "для створення нової категорії та задання ліміту використовуємо вкладку New_Catego" +
    "ry;";
            treeNode17.Name = "Узел8";
            treeNode17.Text = "з допомогою вкладки New_cost вводимо назву нової вартості, також опис, значення, " +
    "обираємо категорію та  визначаємо дату;";
            treeNode18.BackColor = System.Drawing.SystemColors.Window;
            treeNode18.Name = "Узел9";
            treeNode18.Text = "редагувати особисту інформацію можна з допомогою вкладки Profile.";
            treeNode19.Name = "Узел0";
            treeNode19.Text = "Є кілька вкладок з різними можливостями";
            treeNode20.Name = "Node1";
            treeNode20.Text = "Служба підтримки програмного забезпечення support_costs_manager@ukr.net";
            treeNode21.Name = "Node0";
            treeNode21.Text = "Не знайшли те, що шукали?";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode6,
            treeNode8,
            treeNode10,
            treeNode19,
            treeNode21});
            this.treeView1.Size = new System.Drawing.Size(692, 298);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Desktop.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 298);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpForm";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;

    }
}