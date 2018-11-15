﻿namespace StockManagementSystem
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.categorySetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companySetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categorySetupToolStripMenuItem,
            this.companySetupToolStripMenuItem,
            this.itemSetupToolStripMenuItem,
            this.stockInToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // categorySetupToolStripMenuItem
            // 
            this.categorySetupToolStripMenuItem.Name = "categorySetupToolStripMenuItem";
            this.categorySetupToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.categorySetupToolStripMenuItem.Text = " CategorySetup";
            this.categorySetupToolStripMenuItem.Click += new System.EventHandler(this.categorySetupToolStripMenuItem_Click);
            // 
            // companySetupToolStripMenuItem
            // 
            this.companySetupToolStripMenuItem.Name = "companySetupToolStripMenuItem";
            this.companySetupToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.companySetupToolStripMenuItem.Text = " CompanySetup";
            this.companySetupToolStripMenuItem.Click += new System.EventHandler(this.companySetupToolStripMenuItem_Click);
            // 
            // itemSetupToolStripMenuItem
            // 
            this.itemSetupToolStripMenuItem.Name = "itemSetupToolStripMenuItem";
            this.itemSetupToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.itemSetupToolStripMenuItem.Text = "ItemSetup";
            this.itemSetupToolStripMenuItem.Click += new System.EventHandler(this.itemSetupToolStripMenuItem_Click);
            // 
            // stockInToolStripMenuItem
            // 
            this.stockInToolStripMenuItem.Name = "stockInToolStripMenuItem";
            this.stockInToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.stockInToolStripMenuItem.Text = "StockIn";
            this.stockInToolStripMenuItem.Click += new System.EventHandler(this.stockInToolStripMenuItem_Click);
            // 
            // StockManagementSystemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(746, 429);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StockManagementSystemUI";
            this.Text = "StockManagementSystem";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem categorySetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companySetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockInToolStripMenuItem;
    }
}

