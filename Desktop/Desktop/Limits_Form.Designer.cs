namespace Desktop
{
    partial class Limits_Form
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
            this.dataGridViewLimits = new System.Windows.Forms.DataGridView();
            this.Column_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_limit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonNewLimit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLimits)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLimits
            // 
            this.dataGridViewLimits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLimits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLimits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLimits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_category,
            this.Column_limit});
            this.dataGridViewLimits.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewLimits.Name = "dataGridViewLimits";
            this.dataGridViewLimits.Size = new System.Drawing.Size(260, 148);
            this.dataGridViewLimits.TabIndex = 0;
            // 
            // Column_category
            // 
            this.Column_category.HeaderText = "Category";
            this.Column_category.Name = "Column_category";
            // 
            // Column_limit
            // 
            this.Column_limit.HeaderText = "Limits";
            this.Column_limit.Name = "Column_limit";
            // 
            // buttonNewLimit
            // 
            this.buttonNewLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewLimit.Location = new System.Drawing.Point(197, 166);
            this.buttonNewLimit.Name = "buttonNewLimit";
            this.buttonNewLimit.Size = new System.Drawing.Size(75, 23);
            this.buttonNewLimit.TabIndex = 1;
            this.buttonNewLimit.Text = "New limit";
            this.buttonNewLimit.UseVisualStyleBackColor = true;
            // 
            // Limits_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Desktop.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.buttonNewLimit);
            this.Controls.Add(this.dataGridViewLimits);
            this.Name = "Limits_Form";
            this.Text = "Limits";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLimits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLimits;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_limit;
        private System.Windows.Forms.Button buttonNewLimit;
    }
}