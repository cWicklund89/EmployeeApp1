namespace EmployeeApp1
{
    partial class TeamLeaderForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.monthlyBonusTextBox = new System.Windows.Forms.TextBox();
            this.monthlySalaryTextBox = new System.Windows.Forms.TextBox();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trainingHrsTakenTextBox = new System.Windows.Forms.TextBox();
            this.trainingHrsRequiredTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(496, 392);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 46);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(296, 392);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(150, 46);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // monthlyBonusTextBox
            // 
            this.monthlyBonusTextBox.Location = new System.Drawing.Point(296, 232);
            this.monthlyBonusTextBox.Name = "monthlyBonusTextBox";
            this.monthlyBonusTextBox.Size = new System.Drawing.Size(230, 39);
            this.monthlyBonusTextBox.TabIndex = 11;
            // 
            // monthlySalaryTextBox
            // 
            this.monthlySalaryTextBox.Location = new System.Drawing.Point(296, 177);
            this.monthlySalaryTextBox.Name = "monthlySalaryTextBox";
            this.monthlySalaryTextBox.Size = new System.Drawing.Size(230, 39);
            this.monthlySalaryTextBox.TabIndex = 9;
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(296, 119);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(413, 39);
            this.employeeNameTextBox.TabIndex = 7;
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.Location = new System.Drawing.Point(296, 62);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(413, 32);
            this.employeeIDLabel.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Monthly Bonus:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Monthly Salary:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Employee Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employee ID:";
            // 
            // trainingHrsTakenTextBox
            // 
            this.trainingHrsTakenTextBox.Location = new System.Drawing.Point(296, 342);
            this.trainingHrsTakenTextBox.Name = "trainingHrsTakenTextBox";
            this.trainingHrsTakenTextBox.Size = new System.Drawing.Size(230, 39);
            this.trainingHrsTakenTextBox.TabIndex = 18;
            // 
            // trainingHrsRequiredTextBox
            // 
            this.trainingHrsRequiredTextBox.Location = new System.Drawing.Point(296, 287);
            this.trainingHrsRequiredTextBox.Name = "trainingHrsRequiredTextBox";
            this.trainingHrsRequiredTextBox.Size = new System.Drawing.Size(230, 39);
            this.trainingHrsRequiredTextBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "Training Hrs Completed:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "Training Hrs Required";
            // 
            // TeamLeaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trainingHrsTakenTextBox);
            this.Controls.Add(this.trainingHrsRequiredTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.monthlyBonusTextBox);
            this.Controls.Add(this.monthlySalaryTextBox);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.employeeIDLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TeamLeaderForm";
            this.Text = "TeamLeaderForm";
            this.Load += new System.EventHandler(this.TeamLeaderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cancelButton;
        private Button addButton;
        private TextBox monthlyBonusTextBox;
        private TextBox monthlySalaryTextBox;
        private TextBox employeeNameTextBox;
        private Label employeeIDLabel;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox trainingHrsTakenTextBox;
        private TextBox trainingHrsRequiredTextBox;
        private Label label5;
        private Label label6;
    }
}