namespace Desktop
{
    partial class New_Incomes
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.tbTitleNewIncome = new System.Windows.Forms.TextBox();
            this.richTextBoxDescriptionNewIncome = new System.Windows.Forms.RichTextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.tbValueNewIncome = new System.Windows.Forms.TextBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerNewIncome = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Location = new System.Drawing.Point(41, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(27, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            // 
            // tbTitleNewIncome
            // 
            this.tbTitleNewIncome.Location = new System.Drawing.Point(87, 9);
            this.tbTitleNewIncome.Name = "tbTitleNewIncome";
            this.tbTitleNewIncome.Size = new System.Drawing.Size(170, 20);
            this.tbTitleNewIncome.TabIndex = 1;
            // 
            // richTextBoxDescriptionNewIncome
            // 
            this.richTextBoxDescriptionNewIncome.Location = new System.Drawing.Point(87, 35);
            this.richTextBoxDescriptionNewIncome.Name = "richTextBoxDescriptionNewIncome";
            this.richTextBoxDescriptionNewIncome.Size = new System.Drawing.Size(170, 69);
            this.richTextBoxDescriptionNewIncome.TabIndex = 2;
            this.richTextBoxDescriptionNewIncome.Text = "";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Location = new System.Drawing.Point(12, 35);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description";
            // 
            // tbValueNewIncome
            // 
            this.tbValueNewIncome.Location = new System.Drawing.Point(87, 111);
            this.tbValueNewIncome.Name = "tbValueNewIncome";
            this.tbValueNewIncome.Size = new System.Drawing.Size(170, 20);
            this.tbValueNewIncome.TabIndex = 4;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.BackColor = System.Drawing.Color.Transparent;
            this.labelValue.Location = new System.Drawing.Point(38, 115);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(34, 13);
            this.labelValue.TabIndex = 5;
            this.labelValue.Text = "Value";
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(182, 175);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(87, 175);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 6;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Location = new System.Drawing.Point(38, 141);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 9;
            this.labelDate.Text = "Date";
            // 
            // dateTimePickerNewIncome
            // 
            this.dateTimePickerNewIncome.Location = new System.Drawing.Point(87, 137);
            this.dateTimePickerNewIncome.Name = "dateTimePickerNewIncome";
            this.dateTimePickerNewIncome.Size = new System.Drawing.Size(170, 20);
            this.dateTimePickerNewIncome.TabIndex = 10;
            // 
            // New_Incomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Desktop.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 206);
            this.Controls.Add(this.dateTimePickerNewIncome);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.tbValueNewIncome);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.richTextBoxDescriptionNewIncome);
            this.Controls.Add(this.tbTitleNewIncome);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "New_Incomes";
            this.Text = "New Income";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox tbTitleNewIncome;
        private System.Windows.Forms.RichTextBox richTextBoxDescriptionNewIncome;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox tbValueNewIncome;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerNewIncome;
    }
}