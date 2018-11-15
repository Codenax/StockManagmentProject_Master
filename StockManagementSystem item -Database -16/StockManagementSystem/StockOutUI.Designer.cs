namespace StockManagementSystem
{
    partial class StockOutUI
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
            this.addStockOutButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quantityStockOutTextBox = new System.Windows.Forms.TextBox();
            this.availableViewTextBox = new System.Windows.Forms.TextBox();
            this.reoderTextBox = new System.Windows.Forms.TextBox();
            this.itemStockOutComboBox = new System.Windows.Forms.ComboBox();
            this.itemStockInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyStockOutComboBox = new System.Windows.Forms.ComboBox();
            this.companyStockInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryStockOutComboBox = new System.Windows.Forms.ComboBox();
            this.categoryStockInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductListDataGridView = new System.Windows.Forms.DataGridView();
            this.sellButton = new System.Windows.Forms.Button();
            this.damageButton = new System.Windows.Forms.Button();
            this.lostButton = new System.Windows.Forms.Button();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.itemStockInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyStockInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryStockInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addStockOutButton
            // 
            this.addStockOutButton.Location = new System.Drawing.Point(275, 189);
            this.addStockOutButton.Name = "addStockOutButton";
            this.addStockOutButton.Size = new System.Drawing.Size(178, 23);
            this.addStockOutButton.TabIndex = 17;
            this.addStockOutButton.Text = "Add";
            this.addStockOutButton.UseVisualStyleBackColor = true;
            this.addStockOutButton.Click += new System.EventHandler(this.addStockOutButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Stock Out Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Available Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Reorder Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Category";
            // 
            // quantityStockOutTextBox
            // 
            this.quantityStockOutTextBox.Location = new System.Drawing.Point(246, 163);
            this.quantityStockOutTextBox.Name = "quantityStockOutTextBox";
            this.quantityStockOutTextBox.Size = new System.Drawing.Size(240, 20);
            this.quantityStockOutTextBox.TabIndex = 8;
            // 
            // availableViewTextBox
            // 
            this.availableViewTextBox.Location = new System.Drawing.Point(246, 137);
            this.availableViewTextBox.Name = "availableViewTextBox";
            this.availableViewTextBox.Size = new System.Drawing.Size(240, 20);
            this.availableViewTextBox.TabIndex = 9;
            // 
            // reoderTextBox
            // 
            this.reoderTextBox.Location = new System.Drawing.Point(246, 111);
            this.reoderTextBox.Name = "reoderTextBox";
            this.reoderTextBox.Size = new System.Drawing.Size(240, 20);
            this.reoderTextBox.TabIndex = 10;
            // 
            // itemStockOutComboBox
            // 
            this.itemStockOutComboBox.DataSource = this.itemStockInBindingSource;
            this.itemStockOutComboBox.DisplayMember = "Item";
            this.itemStockOutComboBox.FormattingEnabled = true;
            this.itemStockOutComboBox.Location = new System.Drawing.Point(246, 84);
            this.itemStockOutComboBox.Name = "itemStockOutComboBox";
            this.itemStockOutComboBox.Size = new System.Drawing.Size(240, 21);
            this.itemStockOutComboBox.TabIndex = 6;
            this.itemStockOutComboBox.ValueMember = "ItemID";
            this.itemStockOutComboBox.SelectedIndexChanged += new System.EventHandler(this.itemStockOutComboBox_SelectedIndexChanged);
            // 
            // companyStockOutComboBox
            // 
            this.companyStockOutComboBox.DataSource = this.companyStockInBindingSource;
            this.companyStockOutComboBox.DisplayMember = "Company";
            this.companyStockOutComboBox.FormattingEnabled = true;
            this.companyStockOutComboBox.Location = new System.Drawing.Point(246, 57);
            this.companyStockOutComboBox.Name = "companyStockOutComboBox";
            this.companyStockOutComboBox.Size = new System.Drawing.Size(240, 21);
            this.companyStockOutComboBox.TabIndex = 7;
            this.companyStockOutComboBox.ValueMember = "CompanyID";
            this.companyStockOutComboBox.SelectedIndexChanged += new System.EventHandler(this.companyStockOutComboBox_SelectedIndexChanged);
            // 
            // categoryStockOutComboBox
            // 
            this.categoryStockOutComboBox.DataSource = this.categoryStockInBindingSource;
            this.categoryStockOutComboBox.DisplayMember = "Category";
            this.categoryStockOutComboBox.FormattingEnabled = true;
            this.categoryStockOutComboBox.Location = new System.Drawing.Point(246, 30);
            this.categoryStockOutComboBox.Name = "categoryStockOutComboBox";
            this.categoryStockOutComboBox.Size = new System.Drawing.Size(240, 21);
            this.categoryStockOutComboBox.TabIndex = 5;
            this.categoryStockOutComboBox.ValueMember = "CategoryID";
            this.categoryStockOutComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryStockOutComboBox_SelectedIndexChanged);
            // 
            // ProductListDataGridView
            // 
            this.ProductListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.Item,
            this.Company,
            this.Quantity});
            this.ProductListDataGridView.Location = new System.Drawing.Point(159, 218);
            this.ProductListDataGridView.Name = "ProductListDataGridView";
            this.ProductListDataGridView.Size = new System.Drawing.Size(445, 135);
            this.ProductListDataGridView.TabIndex = 18;
            this.ProductListDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.ProductListDataGridView_RowPostPaint);
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(266, 359);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(130, 23);
            this.sellButton.TabIndex = 17;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // damageButton
            // 
            this.damageButton.Location = new System.Drawing.Point(402, 359);
            this.damageButton.Name = "damageButton";
            this.damageButton.Size = new System.Drawing.Size(130, 23);
            this.damageButton.TabIndex = 17;
            this.damageButton.Text = "Damage";
            this.damageButton.UseVisualStyleBackColor = true;
            // 
            // lostButton
            // 
            this.lostButton.Location = new System.Drawing.Point(543, 359);
            this.lostButton.Name = "lostButton";
            this.lostButton.Size = new System.Drawing.Size(130, 23);
            this.lostButton.TabIndex = 17;
            this.lostButton.Text = "Lost";
            this.lostButton.UseVisualStyleBackColor = true;
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
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // StockOutUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 399);
            this.Controls.Add(this.ProductListDataGridView);
            this.Controls.Add(this.lostButton);
            this.Controls.Add(this.damageButton);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.addStockOutButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantityStockOutTextBox);
            this.Controls.Add(this.availableViewTextBox);
            this.Controls.Add(this.reoderTextBox);
            this.Controls.Add(this.itemStockOutComboBox);
            this.Controls.Add(this.companyStockOutComboBox);
            this.Controls.Add(this.categoryStockOutComboBox);
            this.Name = "StockOutUI";
            this.Text = "StockOut";
            this.Load += new System.EventHandler(this.StockOutUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemStockInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyStockInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryStockInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addStockOutButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantityStockOutTextBox;
        private System.Windows.Forms.TextBox availableViewTextBox;
        private System.Windows.Forms.TextBox reoderTextBox;
        private System.Windows.Forms.ComboBox itemStockOutComboBox;
        private System.Windows.Forms.ComboBox companyStockOutComboBox;
        private System.Windows.Forms.ComboBox categoryStockOutComboBox;
        private System.Windows.Forms.DataGridView ProductListDataGridView;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button damageButton;
        private System.Windows.Forms.Button lostButton;
        private System.Windows.Forms.BindingSource categoryStockInBindingSource;
        private System.Windows.Forms.BindingSource companyStockInBindingSource;
        private System.Windows.Forms.BindingSource itemStockInBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}