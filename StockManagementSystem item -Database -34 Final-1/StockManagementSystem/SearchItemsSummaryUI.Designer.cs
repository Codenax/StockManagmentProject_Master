namespace StockManagementSystem
{
    partial class SearchItemsSummaryUI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.companySearchComboBox = new System.Windows.Forms.ComboBox();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.categorySearchComboBox = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchButton = new System.Windows.Forms.Button();
            this.viewSearchResultDataGridView = new System.Windows.Forms.DataGridView();
            this.printButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReorderLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSearchResultDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company";
            // 
            // companySearchComboBox
            // 
            this.companySearchComboBox.DataSource = this.companiesBindingSource;
            this.companySearchComboBox.DisplayMember = "Company";
            this.companySearchComboBox.FormattingEnabled = true;
            this.companySearchComboBox.Location = new System.Drawing.Point(278, 27);
            this.companySearchComboBox.Name = "companySearchComboBox";
            this.companySearchComboBox.Size = new System.Drawing.Size(272, 24);
            this.companySearchComboBox.TabIndex = 0;
            this.companySearchComboBox.ValueMember = "SL";
            this.companySearchComboBox.DropDown += new System.EventHandler(this.companySearchComboBox_DropDown);
            this.companySearchComboBox.SelectionChangeCommitted += new System.EventHandler(this.companySearchComboBox_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category";
            // 
            // categorySearchComboBox
            // 
            this.categorySearchComboBox.DataSource = this.categoriesBindingSource;
            this.categorySearchComboBox.DisplayMember = "Category";
            this.categorySearchComboBox.FormattingEnabled = true;
            this.categorySearchComboBox.Location = new System.Drawing.Point(278, 65);
            this.categorySearchComboBox.Name = "categorySearchComboBox";
            this.categorySearchComboBox.Size = new System.Drawing.Size(272, 24);
            this.categorySearchComboBox.TabIndex = 1;
            this.categorySearchComboBox.ValueMember = "SL";
            this.categorySearchComboBox.SelectionChangeCommitted += new System.EventHandler(this.categorySearchComboBox_SelectionChangeCommitted);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Aquamarine;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(431, 125);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(119, 32);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // viewSearchResultDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewSearchResultDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewSearchResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewSearchResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.Item,
            this.Company,
            this.Category,
            this.AvailableQuantity,
            this.ReorderLevel});
            this.viewSearchResultDataGridView.Location = new System.Drawing.Point(21, 178);
            this.viewSearchResultDataGridView.Name = "viewSearchResultDataGridView";
            this.viewSearchResultDataGridView.Size = new System.Drawing.Size(762, 216);
            this.viewSearchResultDataGridView.TabIndex = 3;
            this.viewSearchResultDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.viewSearchResultDataGridView_RowPostPaint);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.Location = new System.Drawing.Point(278, 125);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(123, 32);
            this.printButton.TabIndex = 3;
            this.printButton.Text = "Print Report";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.messageLabel);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.viewSearchResultDataGridView);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.printButton);
            this.groupBox1.Controls.Add(this.companySearchComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.categorySearchComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 411);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.ForeColor = System.Drawing.Color.Red;
            this.messageLabel.Location = new System.Drawing.Point(367, 96);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(98, 17);
            this.messageLabel.TabIndex = 4;
            this.messageLabel.Text = "No data found";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.timeLabel);
            this.groupBox2.Controls.Add(this.dateLabel);
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(635, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 44);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(5, 11);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(57, 14);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "12-12-12";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(5, 27);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(76, 14);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "12Non-2018";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(274, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Items Summary Details";
            // 
            // SL
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SL.DefaultCellStyle = dataGridViewCellStyle2;
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            this.SL.Width = 40;
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 200;
            // 
            // Company
            // 
            this.Company.DataPropertyName = "Company";
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            this.Company.Width = 150;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 150;
            // 
            // AvailableQuantity
            // 
            this.AvailableQuantity.DataPropertyName = "AvailableQuantity";
            this.AvailableQuantity.HeaderText = "Available Quantity";
            this.AvailableQuantity.Name = "AvailableQuantity";
            this.AvailableQuantity.ReadOnly = true;
            // 
            // ReorderLevel
            // 
            this.ReorderLevel.DataPropertyName = "ReoderLevel";
            this.ReorderLevel.HeaderText = "Reorder Level";
            this.ReorderLevel.Name = "ReorderLevel";
            this.ReorderLevel.ReadOnly = true;
            this.ReorderLevel.Width = 80;
            // 
            // SearchItemsSummaryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(827, 499);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchItemsSummaryUI";
            this.Text = "SearchItemsSummary";
            this.Load += new System.EventHandler(this.SearchItemsSummaryUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSearchResultDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox companySearchComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox categorySearchComboBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private System.Windows.Forms.DataGridView viewSearchResultDataGridView;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label messageLabel;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReorderLevel;
    }
}