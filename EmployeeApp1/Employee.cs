using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeApp1
{
    public abstract class Employee
    {
        [Display(Name = "ID#")]
        /// <summary>
        /// Employee ID
        /// </summary>
        public int Id { get; set; }

        [Display(Name = "Name")]
        /// <summary>
        /// Employee Name
        /// </summary>
        public string Name { get; set; }

        [Display(Name = "Employee Type")]
        /// <summary>
        /// Employee Type - based on the type of object
        /// </summary>
        public string Type { get => this.GetType().Name; }

        [Display(Name = "Yearly Salary")]
        /// <summary>
        /// Employee Yearly Salary
        /// </summary>
        public string YearlySalary { get => this.GetEmployeeYearlySalary().ToString("c"); }

        // All Parameter Constructor
        public Employee(int employeeID, string employeeName)
        {
            Id = employeeID;
            Name = employeeName;
        }

        /// <summary>
        /// Calculates the Employee Yearly Salary for each Employee.  Since it
        /// is declared as abstract, the implementation for this calculation
        /// will occur in each derived class based on the class properties
        /// defined for calculating the salary.
        /// </summary>
        /// <returns>Calculated Employee Pay</returns>
        public abstract decimal GetEmployeeYearlySalary();
    }
}
