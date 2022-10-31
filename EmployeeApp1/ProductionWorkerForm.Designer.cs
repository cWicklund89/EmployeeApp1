namespace EmployeeApp1
{
    partial class ProductionWorkerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.shiftListBox = new System.Windows.Forms.ListBox();
            this.hrsPerWeekTextBox = new System.Windows.Forms.TextBox();
            this.hrlyPayRateTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(111, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID:";
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.Location = new System.Drawing.Point(317, 38);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(377, 41);
            this.employeeIDLabel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(111, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Name:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(111, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 41);
            this.label3.TabIndex = 3;
            this.label3.Text = "Shift:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(111, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 41);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hours Per Week:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(111, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 41);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hourly Pay Rate:";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(317, 93);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(377, 39);
            this.employeeNameTextBox.TabIndex = 1;
            // 
            // shiftListBox
            // 
            this.shiftListBox.FormattingEnabled = true;
            this.shiftListBox.ItemHeight = 32;
            this.shiftListBox.Items.AddRange(new object[] {
            "Add 1 and 2"});
            this.shiftListBox.Location = new System.Drawing.Point(317, 152);
            this.shiftListBox.Name = "shiftListBox";
            this.shiftListBox.Size = new System.Drawing.Size(163, 100);
            this.shiftListBox.TabIndex = 2;
            // 
            // hrsPerWeekTextBox
            // 
            this.hrsPerWeekTextBox.Location = new System.Drawing.Point(317, 263);
            this.hrsPerWeekTextBox.Name = "hrsPerWeekTextBox";
            this.hrsPerWeekTextBox.Size = new System.Drawing.Size(200, 39);
            this.hrsPerWeekTextBox.TabIndex = 3;
            // 
            // hrlyPayRateTextBox
            // 
            this.hrlyPayRateTextBox.Location = new System.Drawing.Point(317, 308);
            this.hrlyPayRateTextBox.Name = "hrlyPayRateTextBox";
            this.hrlyPayRateTextBox.Size = new System.Drawing.Size(200, 39);
            this.hrlyPayRateTextBox.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(317, 375);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(109, 46);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(447, 375);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(109, 46);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ProductionWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.hrlyPayRateTextBox);
            this.Controls.Add(this.hrsPerWeekTextBox);
            this.Controls.Add(this.shiftListBox);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.employeeIDLabel);
            this.Controls.Add(this.label1);
            this.Name = "ProductionWorkerForm";
            this.Text = "Production Worker";
            this.Load += new System.EventHandler(this.ProductionWorkerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label employeeIDLabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox employeeNameTextBox;
        private ListBox shiftListBox;
        private TextBox hrsPerWeekTextBox;
        private TextBox hrlyPayRateTextBox;
        private Button addButton;
        private Button cancelButton;

    }
}