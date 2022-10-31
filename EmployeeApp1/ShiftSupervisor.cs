using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp1
{
    /// <summary>
    /// Shift Supervisor Class
    /// </summary>
    public class ShiftSupervisor : Employee
    {
        /// <summary>
        /// Annual Salary
        /// </summary>
        public decimal AnnualSalary { get; set; }

        /// <summary>
        /// Annual Earned Bonus
        /// </summary>
        public decimal AnnualBonus { get; set; }

        /// <summary>
        /// Shift Supervisor All Parameter Constructor
        /// </summary>
        /// <param name="employeeID">Employee ID</param>
        /// <param name="employeeName">Employee Name</param>
        /// <param name="annualSalary">Yearly Salary</param>
        /// <param name="annualBonus">Annual Earned Bonus</param>
        public ShiftSupervisor(int employeeID, string employeeName,
            decimal annualSalary, decimal annualBonus) : base(employeeID, employeeName)
        {
            AnnualSalary = annualSalary;
            AnnualBonus = annualBonus;
        }

        /// <summary>
        /// Calculates the Employee Yearly Salary for the Shift Supervisor
        /// </summary>
        /// <returns>Yearly Salary</returns>
        public override decimal GetEmployeeYearlySalary() => AnnualSalary + AnnualBonus;
    }
}
