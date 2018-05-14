﻿namespace WindowsFormsApp1
{
    partial class Form1
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.higherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gammaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gammaCorectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contrastToolStripMenuItem,
            this.gammaToolStripMenuItem,
            this.filteringToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // contrastToolStripMenuItem
            // 
            this.contrastToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.higherToolStripMenuItem,
            this.lowerToolStripMenuItem});
            this.contrastToolStripMenuItem.Name = "contrastToolStripMenuItem";
            this.contrastToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.contrastToolStripMenuItem.Text = "Contrast";
            // 
            // higherToolStripMenuItem
            // 
            this.higherToolStripMenuItem.Name = "higherToolStripMenuItem";
            this.higherToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.higherToolStripMenuItem.Text = "Higher";
            this.higherToolStripMenuItem.Click += new System.EventHandler(this.higherToolStripMenuItem_Click);
            // 
            // lowerToolStripMenuItem
            // 
            this.lowerToolStripMenuItem.Name = "lowerToolStripMenuItem";
            this.lowerToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.lowerToolStripMenuItem.Text = "Lower";
            this.lowerToolStripMenuItem.Click += new System.EventHandler(this.lowerToolStripMenuItem_Click);
            // 
            // gammaToolStripMenuItem
            // 
            this.gammaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gammaCorectionToolStripMenuItem});
            this.gammaToolStripMenuItem.Name = "gammaToolStripMenuItem";
            this.gammaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gammaToolStripMenuItem.Text = "Gamma";
            // 
            // gammaCorectionToolStripMenuItem
            // 
            this.gammaCorectionToolStripMenuItem.Name = "gammaCorectionToolStripMenuItem";
            this.gammaCorectionToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.gammaCorectionToolStripMenuItem.Text = "Gamma Correction";
            this.gammaCorectionToolStripMenuItem.Click += new System.EventHandler(this.gammaCorectionToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 331);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(558, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(431, 331);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loaded image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Edited image";
            // 
            // filteringToolStripMenuItem
            // 
            this.filteringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medianToolStripMenuItem});
            this.filteringToolStripMenuItem.Name = "filteringToolStripMenuItem";
            this.filteringToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.filteringToolStripMenuItem.Text = "Filtering";
            // 
            // medianToolStripMenuItem
            // 
            this.medianToolStripMenuItem.Name = "medianToolStripMenuItem";
            this.medianToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.medianToolStripMenuItem.Text = "Median";
            this.medianToolStripMenuItem.Click += new System.EventHandler(this.medianToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 435);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem higherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowerToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        public  System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem gammaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gammaCorectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianToolStripMenuItem;
    }
}

