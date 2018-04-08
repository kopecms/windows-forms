namespace Cars
{
    partial class CreateDialog
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
            this.branTextBox = new System.Windows.Forms.TextBox();
            this.maxSpeedTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.createButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.carControl1 = new Cars.CarControl();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // branTextBox
            // 
            this.branTextBox.Location = new System.Drawing.Point(123, 14);
            this.branTextBox.Name = "branTextBox";
            this.branTextBox.Size = new System.Drawing.Size(376, 22);
            this.branTextBox.TabIndex = 0;
            this.branTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.branTextBox_Validating);
            this.branTextBox.Validated += new System.EventHandler(this.branTextBox_Validated);
            // 
            // maxSpeedTextBox
            // 
            this.maxSpeedTextBox.Location = new System.Drawing.Point(123, 42);
            this.maxSpeedTextBox.Name = "maxSpeedTextBox";
            this.maxSpeedTextBox.Size = new System.Drawing.Size(376, 22);
            this.maxSpeedTextBox.TabIndex = 1;
            this.maxSpeedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.maxSpeedTextBox_Validating);
            this.maxSpeedTextBox.Validated += new System.EventHandler(this.maxSpeedTextBox_Validated);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(123, 70);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(376, 22);
            this.dateTimePicker.TabIndex = 3;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(123, 292);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(376, 23);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Max Speed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Production Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Type";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // carControl1
            // 
            this.carControl1.CarType = "Family";
            this.carControl1.Location = new System.Drawing.Point(123, 98);
            this.carControl1.Name = "carControl1";
            this.carControl1.Size = new System.Drawing.Size(376, 188);
            this.carControl1.TabIndex = 10;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CreateDialog
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 327);
            this.Controls.Add(this.carControl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.maxSpeedTextBox);
            this.Controls.Add(this.branTextBox);
            this.MinimumSize = new System.Drawing.Size(522, 327);
            this.Name = "CreateDialog";
            this.Text = "CreateDialog";
            this.Load += new System.EventHandler(this.CreateDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox branTextBox;
        public System.Windows.Forms.TextBox maxSpeedTextBox;
        public System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public CarControl carControl1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}