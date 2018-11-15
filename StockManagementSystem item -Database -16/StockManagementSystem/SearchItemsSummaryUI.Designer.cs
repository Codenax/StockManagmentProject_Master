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
            this.label1 = new System.Windows.Forms.Label();
            this.companySearchComboBox = new System.Windows.Forms.ComboBox();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.categorySearchComboBox = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchButton = new System.Windows.Forms.Button();
            this.viewSearchResultDataGridView = new System.Windows.Forms.DataGridView();
            this.clearButton = new System.Windows.Forms.Button();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReorderLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSearchResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company";
            // 
            // companySearchComboBox
            // 
            this.companySearchComboBox.DataSource = this.companiesBindingSource;
            this.companySearchComboBox.DisplayMember = "Company";
            this.companySearchComboBox.FormattingEnabled = true;
            this.companySearchComboBox.Location = new System.Drawing.Point(235, 46);
            this.companySearchComboBox.Name = "companySearchComboBox";
            this.companySearchComboBox.Size = new System.Drawing.Size(272, 21);
            this.companySearchComboBox.TabIndex = 1;
            this.companySearchComboBox.ValueMember = "SL";
            this.companySearchComboBox.DropDown += new System.EventHandler(this.companySearchComboBox_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category";
            // 
            // categorySearchComboBox
            // 
            this.categorySearchComboBox.DataSource = this.categoriesBindingSource;
            this.categorySearchComboBox.DisplayMember = "Category";
            this.categorySearchComboBox.FormattingEnabled = true;
            this.categorySearchComboBox.Location = new System.Drawing.Point(235, 84);
            this.categorySearchComboBox.Name = "categorySearchComboBox";
            this.categorySearchComboBox.Size = new System.Drawing.Size(272, 21);
            this.categorySearchComboBox.TabIndex = 1;
            this.categorySearchComboBox.ValueMember = "SL";
            this.categorySearchComboBox.DropDown += new System.EventHandler(this.categorySearchComboBox_DropDown);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(388, 114);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(119, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // viewSearchResultDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.viewSearchResultDataGridView.Location = new System.Drawing.Point(42, 171);
            this.viewSearchResultDataGridView.Name = "viewSearchResultDataGridView";
            this.viewSearchResultDataGridView.Size = new System.Drawing.Size(640, 166);
            this.viewSearchResultDataGridView.TabIndex = 3;
            this.viewSearchResultDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.viewSearchResultDataGridView_RowPostPaint);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(235, 114);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(123, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // SL
            // 
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // Company
            // 
            this.Company.DataPropertyName = "Company";
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // AvailableQuantity
            // 
            this.AvailableQuantity.DataPropertyName = "AvailableQuantity";
            this.AvailableQuantity.HeaderText = "Available Quantity";
            this.AvailableQuantity.Name = "AvailableQuantity";
            // 
            // ReorderLevel
            // 
            this.ReorderLevel.DataPropertyName = "ReoderLevel";
            this.ReorderLevel.HeaderText = "Reorder Level";
            this.ReorderLevel.Name = "ReorderLevel";
            // 
            // SearchItemsSummaryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 415);
            this.Controls.Add(this.viewSearchResultDataGridView);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.categorySearchComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.companySearchComboBox);
            this.Controls.Add(this.label1);
            this.Name = "SearchItemsSummaryUI";
            this.Text = "SearchItemsSummary";
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSearchResultDataGridView)).EndInit();
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
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReorderLevel;
    }
}