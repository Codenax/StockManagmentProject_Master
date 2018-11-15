namespace StockManagementSystem
{
    partial class StockInUI
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
            this.categoryStockInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyStockInComboBox = new System.Windows.Forms.ComboBox();
            this.companyStockInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemStockInComboBox = new System.Windows.Forms.ComboBox();
            this.itemStockInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reoderTextBox = new System.Windows.Forms.TextBox();
            this.categoryStockInComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.availableViewTextBox = new System.Windows.Forms.TextBox();
            this.stockInQuTextBox = new System.Windows.Forms.TextBox();
            this.saveItenInButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categoryStockInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyStockInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemStockInBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // companyStockInComboBox
            // 
            this.companyStockInComboBox.DataSource = this.companyStockInBindingSource;
            this.companyStockInComboBox.DisplayMember = "Company";
            this.companyStockInComboBox.FormattingEnabled = true;
            this.companyStockInComboBox.Location = new System.Drawing.Point(214, 136);
            this.companyStockInComboBox.Name = "companyStockInComboBox";
            this.companyStockInComboBox.Size = new System.Drawing.Size(240, 21);
            this.companyStockInComboBox.TabIndex = 1;
            this.companyStockInComboBox.ValueMember = "CompanyID";
            this.companyStockInComboBox.SelectedIndexChanged += new System.EventHandler(this.companyStockInComboBox_SelectedIndexChanged);
            // 
            // itemStockInComboBox
            // 
            this.itemStockInComboBox.DataSource = this.itemStockInBindingSource;
            this.itemStockInComboBox.DisplayMember = "Item";
            this.itemStockInComboBox.FormattingEnabled = true;
            this.itemStockInComboBox.Location = new System.Drawing.Point(214, 172);
            this.itemStockInComboBox.Name = "itemStockInComboBox";
            this.itemStockInComboBox.Size = new System.Drawing.Size(240, 21);
            this.itemStockInComboBox.TabIndex = 1;
            this.itemStockInComboBox.ValueMember = "ItemID";
            this.itemStockInComboBox.SelectedIndexChanged += new System.EventHandler(this.itemStockInComboBox_SelectedIndexChanged);
            // 
            // reoderTextBox
            // 
            this.reoderTextBox.Location = new System.Drawing.Point(214, 208);
            this.reoderTextBox.Name = "reoderTextBox";
            this.reoderTextBox.Size = new System.Drawing.Size(240, 20);
            this.reoderTextBox.TabIndex = 2;
            // 
            // categoryStockInComboBox
            // 
            this.categoryStockInComboBox.DataSource = this.categoryStockInBindingSource;
            this.categoryStockInComboBox.DisplayMember = "Category";
            this.categoryStockInComboBox.FormattingEnabled = true;
            this.categoryStockInComboBox.Location = new System.Drawing.Point(214, 100);
            this.categoryStockInComboBox.Name = "categoryStockInComboBox";
            this.categoryStockInComboBox.Size = new System.Drawing.Size(240, 21);
            this.categoryStockInComboBox.TabIndex = 0;
            this.categoryStockInComboBox.ValueMember = "CategoryID";
            this.categoryStockInComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryStockInComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Company";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reorder Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Available Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Stock In Quantity";
            // 
            // availableViewTextBox
            // 
            this.availableViewTextBox.Location = new System.Drawing.Point(214, 243);
            this.availableViewTextBox.Name = "availableViewTextBox";
            this.availableViewTextBox.Size = new System.Drawing.Size(240, 20);
            this.availableViewTextBox.TabIndex = 2;
            // 
            // stockInQuTextBox
            // 
            this.stockInQuTextBox.Location = new System.Drawing.Point(214, 278);
            this.stockInQuTextBox.Name = "stockInQuTextBox";
            this.stockInQuTextBox.Size = new System.Drawing.Size(240, 20);
            this.stockInQuTextBox.TabIndex = 2;
            // 
            // saveItenInButton
            // 
            this.saveItenInButton.Location = new System.Drawing.Point(244, 314);
            this.saveItenInButton.Name = "saveItenInButton";
            this.saveItenInButton.Size = new System.Drawing.Size(178, 23);
            this.saveItenInButton.TabIndex = 4;
            this.saveItenInButton.Text = "Save";
            this.saveItenInButton.UseVisualStyleBackColor = true;
            this.saveItenInButton.Click += new System.EventHandler(this.saveItenInButton_Click);
            // 
            // StockInUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 432);
            this.Controls.Add(this.saveItenInButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stockInQuTextBox);
            this.Controls.Add(this.availableViewTextBox);
            this.Controls.Add(this.reoderTextBox);
            this.Controls.Add(this.itemStockInComboBox);
            this.Controls.Add(this.companyStockInComboBox);
            this.Controls.Add(this.categoryStockInComboBox);
            this.Name = "StockInUI";
            this.Text = "StockIn";
            this.Load += new System.EventHandler(this.StockInUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryStockInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyStockInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemStockInBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource categoryStockInBindingSource;
        private System.Windows.Forms.ComboBox companyStockInComboBox;
        private System.Windows.Forms.ComboBox itemStockInComboBox;
        private System.Windows.Forms.BindingSource itemStockInBindingSource;
        private System.Windows.Forms.BindingSource companyStockInBindingSource;
        private System.Windows.Forms.TextBox reoderTextBox;
        private System.Windows.Forms.ComboBox categoryStockInComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox availableViewTextBox;
        private System.Windows.Forms.TextBox stockInQuTextBox;
        private System.Windows.Forms.Button saveItenInButton;
    }
}