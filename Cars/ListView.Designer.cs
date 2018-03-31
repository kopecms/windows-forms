﻿namespace Cars
{
    partial class ListView
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
            this.carListView = new System.Windows.Forms.ListView();
            this.Brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductionDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterButton = new System.Windows.Forms.Button();
            this.speedUpInput = new System.Windows.Forms.TextBox();
            this.speedDownInput = new System.Windows.Forms.TextBox();
            this.speedUpLable = new System.Windows.Forms.Label();
            this.minimumSpeedLable = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.OutRadioButton = new System.Windows.Forms.RadioButton();
            this.inRadioButton = new System.Windows.Forms.RadioButton();
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // carListView
            // 
            this.carListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.carListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Brand,
            this.MaxSpeed,
            this.ProductionDate,
            this.Type});
            this.carListView.Location = new System.Drawing.Point(12, 12);
            this.carListView.Name = "carListView";
            this.carListView.Size = new System.Drawing.Size(447, 312);
            this.carListView.TabIndex = 0;
            this.carListView.UseCompatibleStateImageBehavior = false;
            this.carListView.View = System.Windows.Forms.View.Details;
            this.carListView.SelectedIndexChanged += new System.EventHandler(this.carListView_SelectedIndexChanged);
            // 
            // Brand
            // 
            this.Brand.Text = "Brand";
            // 
            // MaxSpeed
            // 
            this.MaxSpeed.Text = "Max Speed";
            this.MaxSpeed.Width = 87;
            // 
            // ProductionDate
            // 
            this.ProductionDate.Text = "Production Date";
            this.ProductionDate.Width = 119;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // menageToolStripMenuItem
            // 
            this.menageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menageToolStripMenuItem.Name = "menageToolStripMenuItem";
            this.menageToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.menageToolStripMenuItem.Text = "Menage";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // filterButton
            // 
            this.filterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.filterButton.Location = new System.Drawing.Point(482, 301);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(289, 23);
            this.filterButton.TabIndex = 2;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // speedUpInput
            // 
            this.speedUpInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.speedUpInput.Location = new System.Drawing.Point(482, 86);
            this.speedUpInput.Name = "speedUpInput";
            this.speedUpInput.Size = new System.Drawing.Size(289, 22);
            this.speedUpInput.TabIndex = 3;
            this.speedUpInput.Validating += new System.ComponentModel.CancelEventHandler(this.speedUpInput_Validating);
            this.speedUpInput.Validated += new System.EventHandler(this.speedUpInput_Validated);
            // 
            // speedDownInput
            // 
            this.speedDownInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.speedDownInput.Location = new System.Drawing.Point(482, 37);
            this.speedDownInput.Name = "speedDownInput";
            this.speedDownInput.Size = new System.Drawing.Size(289, 22);
            this.speedDownInput.TabIndex = 4;
            this.speedDownInput.Validating += new System.ComponentModel.CancelEventHandler(this.speedDownInput_Validating);
            this.speedDownInput.Validated += new System.EventHandler(this.speedDownInput_Validated);
            // 
            // speedUpLable
            // 
            this.speedUpLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.speedUpLable.AutoSize = true;
            this.speedUpLable.Location = new System.Drawing.Point(482, 66);
            this.speedUpLable.Name = "speedUpLable";
            this.speedUpLable.Size = new System.Drawing.Size(89, 17);
            this.speedUpLable.TabIndex = 5;
            this.speedUpLable.Text = "Speed up to:";
            // 
            // minimumSpeedLable
            // 
            this.minimumSpeedLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimumSpeedLable.AutoSize = true;
            this.minimumSpeedLable.Location = new System.Drawing.Point(482, 14);
            this.minimumSpeedLable.Name = "minimumSpeedLable";
            this.minimumSpeedLable.Size = new System.Drawing.Size(110, 17);
            this.minimumSpeedLable.TabIndex = 6;
            this.minimumSpeedLable.Text = "Minimum speed:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // OutRadioButton
            // 
            this.OutRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OutRadioButton.AutoSize = true;
            this.OutRadioButton.Location = new System.Drawing.Point(485, 143);
            this.OutRadioButton.Name = "OutRadioButton";
            this.OutRadioButton.Size = new System.Drawing.Size(109, 21);
            this.OutRadioButton.TabIndex = 7;
            this.OutRadioButton.TabStop = true;
            this.OutRadioButton.Text = "Out of range";
            this.OutRadioButton.UseVisualStyleBackColor = true;
            this.OutRadioButton.CheckedChanged += new System.EventHandler(this.allRadioButton_CheckedChanged);
            // 
            // inRadioButton
            // 
            this.inRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inRadioButton.AutoSize = true;
            this.inRadioButton.Location = new System.Drawing.Point(485, 114);
            this.inRadioButton.Name = "inRadioButton";
            this.inRadioButton.Size = new System.Drawing.Size(81, 21);
            this.inRadioButton.TabIndex = 8;
            this.inRadioButton.TabStop = true;
            this.inRadioButton.Text = "In range";
            this.inRadioButton.UseVisualStyleBackColor = true;
            this.inRadioButton.CheckedChanged += new System.EventHandler(this.allRadioButton_CheckedChanged);
            // 
            // allRadioButton
            // 
            this.allRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Location = new System.Drawing.Point(485, 170);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(44, 21);
            this.allRadioButton.TabIndex = 9;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Text = "All";
            this.allRadioButton.UseVisualStyleBackColor = true;
            this.allRadioButton.CheckedChanged += new System.EventHandler(this.allRadioButton_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 311);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(819, 25);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 336);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.allRadioButton);
            this.Controls.Add(this.inRadioButton);
            this.Controls.Add(this.OutRadioButton);
            this.Controls.Add(this.minimumSpeedLable);
            this.Controls.Add(this.speedUpLable);
            this.Controls.Add(this.speedDownInput);
            this.Controls.Add(this.speedUpInput);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.carListView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(819, 336);
            this.Name = "ListView";
            this.Text = "ListView";
            this.Activated += new System.EventHandler(this.ListView_Activated);
            this.Deactivate += new System.EventHandler(this.ListView_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListView_FormClosing);
            this.Load += new System.EventHandler(this.ListView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private int speedMax;
        private int speedMin;
        private System.Windows.Forms.ListView carListView;
        private System.Windows.Forms.ColumnHeader Brand;
        private System.Windows.Forms.ColumnHeader MaxSpeed;
        private System.Windows.Forms.ColumnHeader ProductionDate;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.TextBox speedUpInput;
        private System.Windows.Forms.TextBox speedDownInput;
        private System.Windows.Forms.Label speedUpLable;
        private System.Windows.Forms.Label minimumSpeedLable;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.RadioButton inRadioButton;
        private System.Windows.Forms.RadioButton OutRadioButton;
        private System.Windows.Forms.RadioButton allRadioButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}