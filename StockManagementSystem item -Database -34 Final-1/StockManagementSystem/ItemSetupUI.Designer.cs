namespace StockManagementSystem
{
    partial class ItemSetupUI
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
            this.categoriesComboBox = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companiesComboBox = new System.Windows.Forms.ComboBox();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.reoderLevelTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.messageLabel2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoriesComboBox
            // 
            this.categoriesComboBox.DataSource = this.categoriesBindingSource;
            this.categoriesComboBox.DisplayMember = "Category";
            this.categoriesComboBox.FormattingEnabled = true;
            this.categoriesComboBox.Location = new System.Drawing.Point(169, 70);
            this.categoriesComboBox.Name = "categoriesComboBox";
            this.categoriesComboBox.Size = new System.Drawing.Size(265, 24);
            this.categoriesComboBox.TabIndex = 0;
            this.categoriesComboBox.ValueMember = "SL";
            this.categoriesComboBox.SelectedIndexChanged += new System.EventHandler(this.categoriesComboBox_SelectedIndexChanged);
            // 
            // companiesComboBox
            // 
            this.companiesComboBox.DataSource = this.companiesBindingSource;
            this.companiesComboBox.DisplayMember = "Company";
            this.companiesComboBox.FormattingEnabled = true;
            this.companiesComboBox.Location = new System.Drawing.Point(169, 104);
            this.companiesComboBox.Name = "companiesComboBox";
            this.companiesComboBox.Size = new System.Drawing.Size(265, 24);
            this.companiesComboBox.TabIndex = 1;
            this.companiesComboBox.ValueMember = "SL";
            this.companiesComboBox.SelectedIndexChanged += new System.EventHandler(this.companiesComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Company";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Reorder Level";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(169, 138);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(265, 23);
            this.itemNameTextBox.TabIndex = 2;
            // 
            // reoderLevelTextBox
            // 
            this.reoderLevelTextBox.Location = new System.Drawing.Point(169, 171);
            this.reoderLevelTextBox.Name = "reoderLevelTextBox";
            this.reoderLevelTextBox.Size = new System.Drawing.Size(265, 23);
            this.reoderLevelTextBox.TabIndex = 3;
            this.reoderLevelTextBox.Text = "0";
            this.reoderLevelTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.reoderLevelTextBox_KeyPress);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Aquamarine;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.Transparent;
            this.saveButton.Location = new System.Drawing.Point(221, 235);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 32);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.Color.Red;
            this.messageLabel.Location = new System.Drawing.Point(197, 205);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(212, 17);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.Text = "Fill Up The Required Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.messageLabel2);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.categoriesComboBox);
            this.groupBox1.Controls.Add(this.reoderLevelTextBox);
            this.groupBox1.Controls.Add(this.companiesComboBox);
            this.groupBox1.Controls.Add(this.itemNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.messageLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(103, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 303);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // messageLabel2
            // 
            this.messageLabel2.AutoSize = true;
            this.messageLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel2.ForeColor = System.Drawing.Color.Red;
            this.messageLabel2.Location = new System.Drawing.Point(440, 176);
            this.messageLabel2.Name = "messageLabel2";
            this.messageLabel2.Size = new System.Drawing.Size(95, 13);
            this.messageLabel2.TabIndex = 5;
            this.messageLabel2.Text = "Only Number Input";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.timeLabel);
            this.groupBox2.Controls.Add(this.dateLabel);
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(585, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 42);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Goldenrod;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(336, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 29);
            this.label7.TabIndex = 21;
            this.label7.Text = "Item Setup";
            // 
            // ItemSetupUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(779, 457);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ItemSetupUI";
            this.Text = "ItemSetup";
            this.Load += new System.EventHandler(this.ItemSetupUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox categoriesComboBox;
        private System.Windows.Forms.ComboBox companiesComboBox;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox reoderLevelTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label messageLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
    }
}