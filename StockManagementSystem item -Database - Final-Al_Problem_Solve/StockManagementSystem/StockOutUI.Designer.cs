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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockOutUI));
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
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellButton = new System.Windows.Forms.Button();
            this.damageButton = new System.Windows.Forms.Button();
            this.lostButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxMessage = new System.Windows.Forms.GroupBox();
            this.notificationLebel = new System.Windows.Forms.Label();
            this.messageLabel2 = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemStockInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyStockInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryStockInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductListDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxMessage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addStockOutButton
            // 
            this.addStockOutButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addStockOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addStockOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStockOutButton.ForeColor = System.Drawing.Color.White;
            this.addStockOutButton.Location = new System.Drawing.Point(270, 210);
            this.addStockOutButton.Name = "addStockOutButton";
            this.addStockOutButton.Size = new System.Drawing.Size(178, 32);
            this.addStockOutButton.TabIndex = 6;
            this.addStockOutButton.Text = "Add";
            this.addStockOutButton.UseVisualStyleBackColor = false;
            this.addStockOutButton.Click += new System.EventHandler(this.addStockOutButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Stock Out Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Available Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Reorder Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Category";
            // 
            // quantityStockOutTextBox
            // 
            this.quantityStockOutTextBox.Location = new System.Drawing.Point(226, 156);
            this.quantityStockOutTextBox.Name = "quantityStockOutTextBox";
            this.quantityStockOutTextBox.Size = new System.Drawing.Size(281, 23);
            this.quantityStockOutTextBox.TabIndex = 5;
            this.quantityStockOutTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityStockOutTextBox_KeyPress);
            // 
            // availableViewTextBox
            // 
            this.availableViewTextBox.BackColor = System.Drawing.Color.LightCyan;
            this.availableViewTextBox.ForeColor = System.Drawing.Color.Black;
            this.availableViewTextBox.Location = new System.Drawing.Point(226, 130);
            this.availableViewTextBox.Name = "availableViewTextBox";
            this.availableViewTextBox.ReadOnly = true;
            this.availableViewTextBox.Size = new System.Drawing.Size(281, 23);
            this.availableViewTextBox.TabIndex = 4;
            // 
            // reoderTextBox
            // 
            this.reoderTextBox.BackColor = System.Drawing.Color.LightCyan;
            this.reoderTextBox.ForeColor = System.Drawing.Color.Black;
            this.reoderTextBox.Location = new System.Drawing.Point(226, 104);
            this.reoderTextBox.Name = "reoderTextBox";
            this.reoderTextBox.ReadOnly = true;
            this.reoderTextBox.Size = new System.Drawing.Size(281, 23);
            this.reoderTextBox.TabIndex = 3;
            // 
            // itemStockOutComboBox
            // 
            this.itemStockOutComboBox.DataSource = this.itemStockInBindingSource;
            this.itemStockOutComboBox.DisplayMember = "Item";
            this.itemStockOutComboBox.FormattingEnabled = true;
            this.itemStockOutComboBox.Location = new System.Drawing.Point(226, 77);
            this.itemStockOutComboBox.Name = "itemStockOutComboBox";
            this.itemStockOutComboBox.Size = new System.Drawing.Size(281, 24);
            this.itemStockOutComboBox.TabIndex = 2;
            this.itemStockOutComboBox.ValueMember = "ItemID";
            this.itemStockOutComboBox.SelectedIndexChanged += new System.EventHandler(this.itemStockOutComboBox_SelectedIndexChanged);
            // 
            // companyStockOutComboBox
            // 
            this.companyStockOutComboBox.DataSource = this.companyStockInBindingSource;
            this.companyStockOutComboBox.DisplayMember = "Company";
            this.companyStockOutComboBox.FormattingEnabled = true;
            this.companyStockOutComboBox.Location = new System.Drawing.Point(226, 50);
            this.companyStockOutComboBox.Name = "companyStockOutComboBox";
            this.companyStockOutComboBox.Size = new System.Drawing.Size(281, 24);
            this.companyStockOutComboBox.TabIndex = 1;
            this.companyStockOutComboBox.ValueMember = "CompanyID";
            this.companyStockOutComboBox.SelectedIndexChanged += new System.EventHandler(this.companyStockOutComboBox_SelectedIndexChanged);
            // 
            // categoryStockOutComboBox
            // 
            this.categoryStockOutComboBox.DataSource = this.categoryStockInBindingSource;
            this.categoryStockOutComboBox.DisplayMember = "Category";
            this.categoryStockOutComboBox.FormattingEnabled = true;
            this.categoryStockOutComboBox.Location = new System.Drawing.Point(226, 23);
            this.categoryStockOutComboBox.Name = "categoryStockOutComboBox";
            this.categoryStockOutComboBox.Size = new System.Drawing.Size(281, 24);
            this.categoryStockOutComboBox.TabIndex = 0;
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
            this.ProductListDataGridView.Location = new System.Drawing.Point(69, 254);
            this.ProductListDataGridView.Name = "ProductListDataGridView";
            this.ProductListDataGridView.Size = new System.Drawing.Size(590, 171);
            this.ProductListDataGridView.TabIndex = 15;
            this.ProductListDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.ProductListDataGridView_RowPostPaint);
            // 
            // SL
            // 
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            this.SL.Width = 50;
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.Width = 200;
            // 
            // Company
            // 
            this.Company.DataPropertyName = "Company";
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            this.Company.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // sellButton
            // 
            this.sellButton.BackColor = System.Drawing.Color.Aquamarine;
            this.sellButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sellButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellButton.ForeColor = System.Drawing.Color.White;
            this.sellButton.Location = new System.Drawing.Point(256, 431);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(130, 32);
            this.sellButton.TabIndex = 7;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = false;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // damageButton
            // 
            this.damageButton.BackColor = System.Drawing.Color.Maroon;
            this.damageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.damageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damageButton.ForeColor = System.Drawing.Color.White;
            this.damageButton.Location = new System.Drawing.Point(393, 431);
            this.damageButton.Name = "damageButton";
            this.damageButton.Size = new System.Drawing.Size(130, 32);
            this.damageButton.TabIndex = 8;
            this.damageButton.Text = "Damage";
            this.damageButton.UseVisualStyleBackColor = false;
            this.damageButton.Click += new System.EventHandler(this.damageButton_Click);
            // 
            // lostButton
            // 
            this.lostButton.BackColor = System.Drawing.Color.Purple;
            this.lostButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lostButton.ForeColor = System.Drawing.Color.White;
            this.lostButton.Location = new System.Drawing.Point(530, 431);
            this.lostButton.Name = "lostButton";
            this.lostButton.Size = new System.Drawing.Size(130, 32);
            this.lostButton.TabIndex = 9;
            this.lostButton.Text = "Lost";
            this.lostButton.UseVisualStyleBackColor = false;
            this.lostButton.Click += new System.EventHandler(this.lostButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxMessage);
            this.groupBox1.Controls.Add(this.messageLabel2);
            this.groupBox1.Controls.Add(this.messageLabel);
            this.groupBox1.Controls.Add(this.companyStockOutComboBox);
            this.groupBox1.Controls.Add(this.lostButton);
            this.groupBox1.Controls.Add(this.damageButton);
            this.groupBox1.Controls.Add(this.ProductListDataGridView);
            this.groupBox1.Controls.Add(this.sellButton);
            this.groupBox1.Controls.Add(this.categoryStockOutComboBox);
            this.groupBox1.Controls.Add(this.itemStockOutComboBox);
            this.groupBox1.Controls.Add(this.reoderTextBox);
            this.groupBox1.Controls.Add(this.availableViewTextBox);
            this.groupBox1.Controls.Add(this.addStockOutButton);
            this.groupBox1.Controls.Add(this.quantityStockOutTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(79, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 485);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // groupBoxMessage
            // 
            this.groupBoxMessage.Controls.Add(this.notificationLebel);
            this.groupBoxMessage.Location = new System.Drawing.Point(517, 122);
            this.groupBoxMessage.Name = "groupBoxMessage";
            this.groupBoxMessage.Size = new System.Drawing.Size(200, 31);
            this.groupBoxMessage.TabIndex = 20;
            this.groupBoxMessage.TabStop = false;
            // 
            // notificationLebel
            // 
            this.notificationLebel.AutoSize = true;
            this.notificationLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationLebel.ForeColor = System.Drawing.Color.Red;
            this.notificationLebel.Location = new System.Drawing.Point(178, 11);
            this.notificationLebel.Name = "notificationLebel";
            this.notificationLebel.Size = new System.Drawing.Size(11587, 15);
            this.notificationLebel.TabIndex = 0;
            this.notificationLebel.Text = resources.GetString("notificationLebel.Text");
            // 
            // messageLabel2
            // 
            this.messageLabel2.AutoSize = true;
            this.messageLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel2.ForeColor = System.Drawing.Color.Red;
            this.messageLabel2.Location = new System.Drawing.Point(514, 159);
            this.messageLabel2.Name = "messageLabel2";
            this.messageLabel2.Size = new System.Drawing.Size(109, 15);
            this.messageLabel2.TabIndex = 19;
            this.messageLabel2.Text = "Input Number Only";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(236, 184);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(261, 17);
            this.messageLabel.TabIndex = 18;
            this.messageLabel.Text = "Damage Information Saved Successfully";
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
            this.groupBox2.Location = new System.Drawing.Point(669, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 42);
            this.groupBox2.TabIndex = 18;
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
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(387, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 29);
            this.label7.TabIndex = 19;
            this.label7.Text = "Stock Out";
            // 
            // StockOutUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(900, 599);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "StockOutUI";
            this.Text = "StockOut";
            this.Load += new System.EventHandler(this.StockOutUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemStockInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyStockInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryStockInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductListDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxMessage.ResumeLayout(false);
            this.groupBoxMessage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label messageLabel2;
        private System.Windows.Forms.GroupBox groupBoxMessage;
        private System.Windows.Forms.Label notificationLebel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label7;
    }
}