namespace StockManagementSystem
{
    partial class StockManagementSystemUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockManagementSystemUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.categorySetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companySetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAndViewItemsSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSalesBetweenTwoDatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categorySetupToolStripMenuItem,
            this.companySetupToolStripMenuItem,
            this.itemSetupToolStripMenuItem,
            this.stockInToolStripMenuItem,
            this.stockOutToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // categorySetupToolStripMenuItem
            // 
            this.categorySetupToolStripMenuItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.categorySetupToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.categorySetupToolStripMenuItem.Name = "categorySetupToolStripMenuItem";
            this.categorySetupToolStripMenuItem.Size = new System.Drawing.Size(144, 25);
            this.categorySetupToolStripMenuItem.Text = " Category Setup";
            this.categorySetupToolStripMenuItem.Click += new System.EventHandler(this.categorySetupToolStripMenuItem_Click);
            // 
            // companySetupToolStripMenuItem
            // 
            this.companySetupToolStripMenuItem.BackColor = System.Drawing.Color.Plum;
            this.companySetupToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.companySetupToolStripMenuItem.Name = "companySetupToolStripMenuItem";
            this.companySetupToolStripMenuItem.Size = new System.Drawing.Size(147, 25);
            this.companySetupToolStripMenuItem.Text = " Company Setup";
            this.companySetupToolStripMenuItem.Click += new System.EventHandler(this.companySetupToolStripMenuItem_Click);
            // 
            // itemSetupToolStripMenuItem
            // 
            this.itemSetupToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.itemSetupToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.itemSetupToolStripMenuItem.Name = "itemSetupToolStripMenuItem";
            this.itemSetupToolStripMenuItem.Size = new System.Drawing.Size(105, 25);
            this.itemSetupToolStripMenuItem.Text = "Item Setup";
            this.itemSetupToolStripMenuItem.Click += new System.EventHandler(this.itemSetupToolStripMenuItem_Click);
            // 
            // stockInToolStripMenuItem
            // 
            this.stockInToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.stockInToolStripMenuItem.BackColor = System.Drawing.Color.DarkKhaki;
            this.stockInToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.stockInToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stockInToolStripMenuItem.Name = "stockInToolStripMenuItem";
            this.stockInToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.stockInToolStripMenuItem.Text = "Stock In";
            this.stockInToolStripMenuItem.Click += new System.EventHandler(this.stockInToolStripMenuItem_Click);
            // 
            // stockOutToolStripMenuItem
            // 
            this.stockOutToolStripMenuItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.stockOutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.stockOutToolStripMenuItem.Name = "stockOutToolStripMenuItem";
            this.stockOutToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.stockOutToolStripMenuItem.Text = "Stock Out";
            this.stockOutToolStripMenuItem.Click += new System.EventHandler(this.stockOutToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchAndViewItemsSummaryToolStripMenuItem,
            this.viewSalesBetweenTwoDatesToolStripMenuItem});
            this.searchToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Red;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // searchAndViewItemsSummaryToolStripMenuItem
            // 
            this.searchAndViewItemsSummaryToolStripMenuItem.BackColor = System.Drawing.Color.PaleVioletRed;
            this.searchAndViewItemsSummaryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.searchAndViewItemsSummaryToolStripMenuItem.Name = "searchAndViewItemsSummaryToolStripMenuItem";
            this.searchAndViewItemsSummaryToolStripMenuItem.Size = new System.Drawing.Size(313, 26);
            this.searchAndViewItemsSummaryToolStripMenuItem.Text = "View Items Summary";
            this.searchAndViewItemsSummaryToolStripMenuItem.Click += new System.EventHandler(this.searchAndViewItemsSummaryToolStripMenuItem_Click);
            // 
            // viewSalesBetweenTwoDatesToolStripMenuItem
            // 
            this.viewSalesBetweenTwoDatesToolStripMenuItem.BackColor = System.Drawing.Color.PaleVioletRed;
            this.viewSalesBetweenTwoDatesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewSalesBetweenTwoDatesToolStripMenuItem.Name = "viewSalesBetweenTwoDatesToolStripMenuItem";
            this.viewSalesBetweenTwoDatesToolStripMenuItem.Size = new System.Drawing.Size(313, 26);
            this.viewSalesBetweenTwoDatesToolStripMenuItem.Text = "View Sales Between Two Dates";
            this.viewSalesBetweenTwoDatesToolStripMenuItem.Click += new System.EventHandler(this.viewSalesBetweenTwoDatesToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PapayaWhip;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(167, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stock Management System Project";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SeaShell;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(221, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Developed by Green Wave Team";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(280, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(5, 10);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(66, 16);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "12-12-12";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(5, 29);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(88, 16);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "12Non-2018";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timeLabel);
            this.groupBox1.Controls.Add(this.dateLabel);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(647, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 47);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // StockManagementSystemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(892, 502);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StockManagementSystemUI";
            this.Text = "StockManagementSystem";
            this.Load += new System.EventHandler(this.StockManagementSystemUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem categorySetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companySetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchAndViewItemsSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSalesBetweenTwoDatesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

