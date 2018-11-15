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
            this.saveStockInButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoryStockInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyStockInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemStockInBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // companyStockInComboBox
            // 
            this.companyStockInComboBox.DataSource = this.companyStockInBindingSource;
            this.companyStockInComboBox.DisplayMember = "Company";
            this.companyStockInComboBox.FormattingEnabled = true;
            this.companyStockInComboBox.Location = new System.Drawing.Point(155, 60);
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
            this.itemStockInComboBox.Location = new System.Drawing.Point(155, 96);
            this.itemStockInComboBox.Name = "itemStockInComboBox";
            this.itemStockInComboBox.Size = new System.Drawing.Size(240, 21);
            this.itemStockInComboBox.TabIndex = 2;
            this.itemStockInComboBox.ValueMember = "ItemID";
            this.itemStockInComboBox.SelectedIndexChanged += new System.EventHandler(this.itemStockInComboBox_SelectedIndexChanged);
            // 
            // reoderTextBox
            // 
            this.reoderTextBox.BackColor = System.Drawing.Color.LightCyan;
            this.reoderTextBox.Location = new System.Drawing.Point(155, 132);
            this.reoderTextBox.Name = "reoderTextBox";
            this.reoderTextBox.ReadOnly = true;
            this.reoderTextBox.Size = new System.Drawing.Size(240, 20);
            this.reoderTextBox.TabIndex = 3;
            // 
            // categoryStockInComboBox
            // 
            this.categoryStockInComboBox.DataSource = this.categoryStockInBindingSource;
            this.categoryStockInComboBox.DisplayMember = "Category";
            this.categoryStockInComboBox.FormattingEnabled = true;
            this.categoryStockInComboBox.Location = new System.Drawing.Point(155, 24);
            this.categoryStockInComboBox.Name = "categoryStockInComboBox";
            this.categoryStockInComboBox.Size = new System.Drawing.Size(240, 21);
            this.categoryStockInComboBox.TabIndex = 0;
            this.categoryStockInComboBox.ValueMember = "CategoryID";
            this.categoryStockInComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryStockInComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Company";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reorder Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Available Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Stock In Quantity";
            // 
            // availableViewTextBox
            // 
            this.availableViewTextBox.BackColor = System.Drawing.Color.LightCyan;
            this.availableViewTextBox.Location = new System.Drawing.Point(155, 167);
            this.availableViewTextBox.Name = "availableViewTextBox";
            this.availableViewTextBox.ReadOnly = true;
            this.availableViewTextBox.Size = new System.Drawing.Size(240, 20);
            this.availableViewTextBox.TabIndex = 4;
            // 
            // stockInQuTextBox
            // 
            this.stockInQuTextBox.Location = new System.Drawing.Point(155, 202);
            this.stockInQuTextBox.Name = "stockInQuTextBox";
            this.stockInQuTextBox.Size = new System.Drawing.Size(240, 20);
            this.stockInQuTextBox.TabIndex = 5;
            this.stockInQuTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stockInQuTextBox_KeyPress);
            // 
            // saveStockInButton
            // 
            this.saveStockInButton.Location = new System.Drawing.Point(186, 267);
            this.saveStockInButton.Name = "saveStockInButton";
            this.saveStockInButton.Size = new System.Drawing.Size(178, 23);
            this.saveStockInButton.TabIndex = 6;
            this.saveStockInButton.Text = "Save";
            this.saveStockInButton.UseVisualStyleBackColor = true;
            this.saveStockInButton.Click += new System.EventHandler(this.saveStockInButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(206, 239);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(35, 13);
            this.messageLabel.TabIndex = 7;
            this.messageLabel.Text = "label7";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.categoryStockInComboBox);
            this.groupBox1.Controls.Add(this.messageLabel);
            this.groupBox1.Controls.Add(this.companyStockInComboBox);
            this.groupBox1.Controls.Add(this.saveStockInButton);
            this.groupBox1.Controls.Add(this.itemStockInComboBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.reoderTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.availableViewTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.stockInQuTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(192, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 309);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock In";
            // 
            // StockInUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 432);
            this.Controls.Add(this.groupBox1);
            this.Name = "StockInUI";
            this.Text = "StockIn";
            this.Load += new System.EventHandler(this.StockInUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryStockInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyStockInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemStockInBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button saveStockInButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}