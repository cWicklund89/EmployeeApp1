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

    public partial class ShiftSupervisorForm : Form
    {
        // Shift Supervisor Instance
        public ShiftSupervisor shiftSupervisor { get; private set; }
        public ShiftSupervisorForm()
        {
            InitializeComponent();
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

        /// <summary>
        /// Creates the instance of the Shift Supervisor based on the field entries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            StringBuilder message = new StringBuilder();
            int employeeId = 0;
            decimal annualSalary = 0;
            decimal annualBonus = 0;

            try
            {
                // Validate the Employee ID
                if (!int.TryParse(employeeIDLabel.Text, out employeeId))
                    message.AppendLine("Employee ID has not been assigned. ");

                // Validate the Employee Name
                if (String.IsNullOrEmpty(employeeNameTextBox.Text))
                    message.AppendLine("Employee Name is required. ");

                // Validate the Annual Salary
                if (!decimal.TryParse(annualSalaryTextBox.Text, out annualSalary))
                    message.AppendLine("Annual Salary is required. ");

                // Validate the Hourly Pay Rate
                if (!decimal.TryParse(annualBonusTextBox.Text, out annualBonus))
                    message.AppendLine("Annual Bonus is required. ");

                if (message.Length == 0)
                {
                    shiftSupervisor = new ShiftSupervisor(employeeId,
                        employeeNameTextBox.Text, annualSalary, annualBonus);

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
        /// Sets the Shift Supervisor Data for Display
        /// </summary>
        /// <param name="employeeID">Shift Supervisor Object Instance</param>
        internal void DisplayEmployee(ShiftSupervisor employee)
        {
            // Need to set our shift supervisor instance
            shiftSupervisor = employee;

            // Now use the data in the shift supervisor instance to populate the form fields
            employeeIDLabel.Text = shiftSupervisor.Id.ToString();
            employeeIDLabel.Enabled = false;
            employeeNameTextBox.Text = shiftSupervisor.Name;
            employeeNameTextBox.Enabled = false;
            annualSalaryTextBox.Text = shiftSupervisor.AnnualSalary.ToString();
            annualSalaryTextBox.Enabled = false;
            annualBonusTextBox.Text = shiftSupervisor.AnnualBonus.ToString();
            annualBonusTextBox.Enabled = false;

            // The last thing that needs to be done is to turn off the Add button
            addButton.Enabled = false;
        }
    }
}
