using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp1
{
    /// <summary>
    /// Team Leader Class
    /// </summary>
    public class TeamLeader : Employee
    {
        /// <summary>
        /// Monthly Salary
        /// </summary>
        public decimal MonthlySalary { get; set; }

        /// <summary>
        /// Monthly Bonus
        /// </summary>
        public decimal MonthlyBonus { get; set; }

        /// <summary>
        /// Training Hours Required
        /// </summary>
        public int TrainingHrsRequired { get; set; }

        /// <summary>
        /// Training Hours Taken
        /// </summary>
        public int TrainingHrsTaken { get; set; }

        /// <summary>
        /// Team Leader All Parameter Constructor
        /// </summary>
        /// <param name="employeeID">Employee ID</param>
        /// <param name="employeeName">Employee Name</param>
        /// <param name="monthlySalary">Monthly Salary</param>
        /// <param name="monthlyBonus">Monthly Bonus</param>
        /// <param name="trainingHrsRequired">Training Hours Required</param>
        /// <param name="trainingHrsTaken">Training Hours Taken</param>
        public TeamLeader(int employeeID, string employeeName,
            decimal monthlySalary, decimal monthlyBonus, int trainingHrsRequired,
            int trainingHrsTaken) : base(employeeID, employeeName)
        {
            MonthlySalary = monthlySalary;
            MonthlyBonus = monthlyBonus;
            TrainingHrsRequired = trainingHrsRequired;
            TrainingHrsTaken = trainingHrsTaken;
        }

        /// <summary>
        /// Calculates the Employee Yearly Salary for the Team Leader
        /// </summary>
        /// <returns>Yearly Salary</returns>
        public override decimal GetEmployeeYearlySalary() =>
            MonthlySalary * 12 + MonthlyBonus * 12;
    }
}
