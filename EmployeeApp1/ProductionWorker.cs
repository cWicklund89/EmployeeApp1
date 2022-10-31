using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp1
{
    /// <summary>
    /// Production Worker Class
    /// </summary>
    public class ProductionWorker : Employee
    {
        private int shiftNumber;
        private int hoursPerWeek;

        /// <summary>
        /// Shift Number, Value should be 1 or 2
        /// </summary>
        public int ShiftNumber
        {
            get { return shiftNumber; }
            set
            {
                if (value < 1 || value > 2)
                    throw new ApplicationException("Invalid Shift Number");
                else
                    shiftNumber = value;
            }
        }

        /// <summary>
        /// Hourly Pay Rate
        /// </summary>
        public decimal HourlyPayRate { get; set; }

        /// <summary>
        /// Hours Worked Per Week
        /// </summary>
        public int HoursPerWeek
        {
            get { return hoursPerWeek; }
            set
            {
                if (value >= 0 && value <= 40)
                    hoursPerWeek = value;
                else
                    throw new ApplicationException("Weekly hours must be between 0 and 40 inclusive.");
            }
        }

        /// <summary>
        /// Production Worker All Parameter Constructor
        /// </summary>
        /// <param name="employeeID">Employee ID</param>
        /// <param name="employeeName">Employee Name</param>
        /// <param name="shiftNumber">Shift Number</param>
        /// <param name="hourlyPayRate">Hourly Pay Rate</param>
        /// <param name="hoursPerWeek">Hours Worked Per Week</param>
        public ProductionWorker(int employeeID, string employeeName,
            int shiftNumber, decimal hourlyPayRate, int hoursPerWeek)
            : base(employeeID, employeeName)
        {
            ShiftNumber = shiftNumber;
            HourlyPayRate = hourlyPayRate;
            HoursPerWeek = hoursPerWeek;
        }

        /// <summary>
        /// Calculates the Employee Yearly Salary for the Production Worker.
        /// Assumption is that each employee will work 50 weeks out of the year
        /// accounting for company holidays
        /// </summary>
        /// <returns>Yearly Salary</returns>
        public override decimal GetEmployeeYearlySalary() => 50 * HourlyPayRate * HoursPerWeek;

    }
}
