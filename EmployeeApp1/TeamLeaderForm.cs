using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApp1
{
    public partial class TeamLeaderForm : Form
    {

        // Team Leader Instance
        public TeamLeader teamLeader { get; private set; }
        public TeamLeaderForm()
        {
            InitializeComponent();
        }

        private void TeamLeaderForm_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Sets the Employee ID's value
        /// </summary>
        /// <param name="employeeID"></param>
        internal void AddNewEmployee(int employeeID)
        {
            employeeIDLabel.Text = employeeID.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            StringBuilder message = new StringBuilder();
            int employeeId = 0;
            decimal monthlySalary = 0;
            decimal monthlyBonus = 0;
            int trainingHrsRequired = 0;
            int trainingHrsTaken = 0;

            try
            {
                // Validate the Employee ID
                if (!int.TryParse(employeeIDLabel.Text, out employeeId))
                    message.AppendLine("Employee ID has not been assigned. ");

                // Validate the Employee Name
                if (String.IsNullOrEmpty(employeeNameTextBox.Text))
                    message.AppendLine("Employee Name is required. ");

                // Validate the Monthly Salary
                if (!decimal.TryParse(monthlySalaryTextBox.Text, out monthlySalary))
                    message.AppendLine("Monthly Salary must be a valid numeric value. ");

                // Validate the Monthly Bonus
                if (!decimal.TryParse(monthlyBonusTextBox.Text, out monthlyBonus))
                    message.AppendLine("Annual Bonus must be a valid numeric value. ");

                // Validate the Training Hrs Required
                if (!int.TryParse(trainingHrsRequiredTextBox.Text, out trainingHrsRequired))
                    message.AppendLine("Training Hours Required must be a valid numeric value. ");

                // Validate the Training Hrs Completed
                if (!int.TryParse(trainingHrsTakenTextBox.Text, out trainingHrsTaken))
                    message.AppendLine("Training Hours Completed must be a valid numeric value. ");

                if (message.Length == 0)
                {
                    teamLeader = new TeamLeader(employeeId,
                        employeeNameTextBox.Text, monthlySalary, monthlyBonus,
                        trainingHrsRequired, trainingHrsTaken);

                    // Then Close the window.
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                // Add it to the message list to return
                message.AppendLine(ex.Message);
            }

            // If we had an error, the message length will be greater than 0
            if (message.Length > 0)
            {
                MessageBox.Show(message.ToString());
            }
        }

        /// <summary>
        /// Sets the Team Leader Data for Display
        /// </summary>
        /// <param name="employeeID">Team Leader Object Instance</param>
        internal void DisplayEmployee(TeamLeader employee)
        {
            // Need to set our team leader instance
            teamLeader = employee;

            // Now use the data in the team leader instance to populate the form fields
            employeeIDLabel.Text = teamLeader.Id.ToString();
            employeeIDLabel.Enabled = false;
            employeeNameTextBox.Text = teamLeader.Name;
            employeeNameTextBox.Enabled = false;
            monthlySalaryTextBox.Text = teamLeader.MonthlySalary.ToString();
            monthlySalaryTextBox.Enabled = false;
            monthlyBonusTextBox.Text = teamLeader.MonthlyBonus.ToString();
            monthlyBonusTextBox.Enabled = false;
            trainingHrsRequiredTextBox.Text = teamLeader.TrainingHrsRequired.ToString();
            trainingHrsRequiredTextBox.Enabled = false;
            trainingHrsTakenTextBox.Text = teamLeader.TrainingHrsTaken.ToString();
            trainingHrsTakenTextBox.Enabled = false;

            // The last thing that needs to be done is to turn off the Add button
            addButton.Enabled = false;
        }
    }
}
