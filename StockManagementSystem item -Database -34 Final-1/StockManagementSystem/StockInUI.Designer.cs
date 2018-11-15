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
            this.messageLabel2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryStockInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyStockInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemStockInBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // companyStockInComboBox
            // 
            this.companyStockInComboBox.DataSource = this.companyStockInBindingSource;
            this.companyStockInComboBox.DisplayMember = "Company";
            this.companyStockInComboBox.FormattingEnabled = true;
            this.companyStockInComboBox.Location = new System.Drawing.Point(155, 78);
            this.companyStockInComboBox.Name = "companyStockInComboBox";
            this.companyStockInComboBox.Size = new System.Drawing.Size(240, 24);
            this.companyStockInComboBox.TabIndex = 1;
            this.companyStockInComboBox.ValueMember = "CompanyID";
            this.companyStockInComboBox.SelectionChangeCommitted += new System.EventHandler(this.companyStockInComboBox_SelectionChangeCommitted);
            // 
            // itemStockInComboBox
            // 
            this.itemStockInComboBox.DataSource = this.itemStockInBindingSource;
            this.itemStockInComboBox.DisplayMember = "Item";
            this.itemStockInComboBox.FormattingEnabled = true;
            this.itemStockInComboBox.Location = new System.Drawing.Point(155, 114);
            this.itemStockInComboBox.Name = "itemStockInComboBox";
            this.itemStockInComboBox.Size = new System.Drawing.Size(240, 24);
            this.itemStockInComboBox.TabIndex = 2;
            this.itemStockInComboBox.ValueMember = "ItemID";
            this.itemStockInComboBox.SelectedIndexChanged += new System.EventHandler(this.itemStockInComboBox_SelectedIndexChanged);
            // 
            // reoderTextBox
            // 
            this.reoderTextBox.BackColor = System.Drawing.Color.LightCyan;
            this.reoderTextBox.Location = new System.Drawing.Point(155, 150);
            this.reoderTextBox.Name = "reoderTextBox";
            this.reoderTextBox.ReadOnly = true;
            this.reoderTextBox.Size = new System.Drawing.Size(240, 23);
            this.reoderTextBox.TabIndex = 3;
            // 
            // categoryStockInComboBox
            // 
            this.categoryStockInComboBox.DataSource = this.categoryStockInBindingSource;
            this.categoryStockInComboBox.DisplayMember = "Category";
            this.categoryStockInComboBox.FormattingEnabled = true;
            this.categoryStockInComboBox.Location = new System.Drawing.Point(155, 42);
            this.categoryStockInComboBox.Name = "categoryStockInComboBox";
            this.categoryStockInComboBox.Size = new System.Drawing.Size(240, 24);
            this.categoryStockInComboBox.TabIndex = 0;
            this.categoryStockInComboBox.ValueMember = "CategoryID";
            this.categoryStockInComboBox.SelectionChangeCommitted += new System.EventHandler(this.categoryStockInComboBox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Company";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reorder Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Available Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Stock In Quantity";
            // 
            // availableViewTextBox
            // 
            this.availableViewTextBox.BackColor = System.Drawing.Color.LightCyan;
            this.availableViewTextBox.Location = new System.Drawing.Point(155, 185);
            this.availableViewTextBox.Name = "availableViewTextBox";
            this.availableViewTextBox.ReadOnly = true;
            this.availableViewTextBox.Size = new System.Drawing.Size(240, 23);
            this.availableViewTextBox.TabIndex = 4;
            // 
            // stockInQuTextBox
            // 
            this.stockInQuTextBox.Location = new System.Drawing.Point(155, 220);
            this.stockInQuTextBox.Name = "stockInQuTextBox";
            this.stockInQuTextBox.Size = new System.Drawing.Size(240, 23);
            this.stockInQuTextBox.TabIndex = 5;
            this.stockInQuTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stockInQuTextBox_KeyPress);
            // 
            // saveStockInButton
            // 
            this.saveStockInButton.BackColor = System.Drawing.Color.Aquamarine;
            this.saveStockInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.saveStockInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveStockInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveStockInButton.ForeColor = System.Drawing.Color.White;
            this.saveStockInButton.Location = new System.Drawing.Point(186, 288);
            this.saveStockInButton.Name = "saveStockInButton";
            this.saveStockInButton.Size = new System.Drawing.Size(178, 36);
            this.saveStockInButton.TabIndex = 6;
            this.saveStockInButton.Text = "Save";
            this.saveStockInButton.UseVisualStyleBackColor = false;
            this.saveStockInButton.Click += new System.EventHandler(this.saveStockInButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(173, 257);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(212, 17);
            this.messageLabel.TabIndex = 7;
            this.messageLabel.Text = "Fill Up The Required Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.categoryStockInComboBox);
            this.groupBox1.Controls.Add(this.messageLabel2);
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(96, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 345);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // messageLabel2
            // 
            this.messageLabel2.AutoSize = true;
            this.messageLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel2.ForeColor = System.Drawing.Color.Red;
            this.messageLabel2.Location = new System.Drawing.Point(401, 225);
            this.messageLabel2.Name = "messageLabel2";
            this.messageLabel2.Size = new System.Drawing.Size(95, 13);
            this.messageLabel2.TabIndex = 7;
            this.messageLabel2.Text = "Only Number Input";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.timeLabel);
            this.groupBox2.Controls.Add(this.dateLabel);
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(525, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 42);
            this.groupBox2.TabIndex = 8;
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(306, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 29);
            this.label7.TabIndex = 20;
            this.label7.Text = "Stock In";
            // 
            // StockInUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(719, 460);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "StockInUI";
            this.Text = "Stock In";
            this.Load += new System.EventHandler(this.StockInUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryStockInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyStockInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemStockInBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button saveStockInButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label messageLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
    }
}