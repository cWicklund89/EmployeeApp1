using System.ComponentModel;

namespace EmployeeApp1
{
    public partial class Form1 : Form
    {

        /// <summary>
        /// Used for assigning the next Employee ID
        /// </summary>
        private static int nextEmployeeID = 0;

        /// <summary>
        /// Contains the Employee instance that was selected in the DataGridView
        /// </summary>
        private Employee selectedEmployee = null;

        /// <summary>
        /// Used as the DataSource for the DataGridView
        /// </summary>
        private BindingList<Employee> employeeList = new BindingList<Employee>();

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Shows the Production Worker Dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void workerButton_Click(object sender, EventArgs e)
        {
            ProductionWorkerForm productionWorkerForm = new ProductionWorkerForm();
            // Set the next Employee Number
            productionWorkerForm.AddNewEmployee(++nextEmployeeID);
            productionWorkerForm.ShowDialog();

            // Before we dispose of the form, check to see if we have an object
            if (productionWorkerForm.productionWorker != null)
                // Add it to the Employee List so it shows in the datagrid
                employeeList.Add(productionWorkerForm.productionWorker);
            productionWorkerForm.Dispose();
        }

        /// <summary>
        /// Form Initialization Activities
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void Form1_Load(object sender, EventArgs e)
        //{
        //  var source = new BindingSource(employeeList, null);
        //employeeDataGridView.DataSource = source;
        //}

        /// <summary>
        /// Display the Employee in the associated object window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayButton_Click(object sender, EventArgs e)
        {
            if (selectedEmployee.GetType() == typeof(ProductionWorker))
            {
                ProductionWorkerForm productionWorkerForm = new ProductionWorkerForm();
                productionWorkerForm.DisplayEmployee((ProductionWorker)selectedEmployee);
                productionWorkerForm.ShowDialog();
                productionWorkerForm.Dispose();
            }
        }

        /// <summary>
        /// Determines if a row has been selected and if it has, it will store
        /// the selected row in case the user clicks the "Display Details" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void employeeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var rowsCount = employeeDataGridView.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1) return;
            var currentIndex = employeeDataGridView.CurrentCell.RowIndex;

            // Based on the currentIndex, get the item in the employeeList
            selectedEmployee = employeeList.ElementAt(currentIndex);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            var source = new BindingSource(employeeList, null);
            employeeDataGridView.DataSource = source;
        }

        /// <summary>
        /// Display the Employee in the associated object window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayButton_Click_1(object sender, EventArgs e)
        {
            if (selectedEmployee.GetType() == typeof(ProductionWorker))
            {
                ProductionWorkerForm productionWorkerForm = new ProductionWorkerForm();
                productionWorkerForm.DisplayEmployee((ProductionWorker)selectedEmployee);
                productionWorkerForm.ShowDialog();
                productionWorkerForm.Dispose();
            }
            else if (selectedEmployee.GetType() == typeof(ShiftSupervisor))
            {
                ShiftSupervisorForm shiftSupervisorForm = new ShiftSupervisorForm();
                shiftSupervisorForm.DisplayEmployee((ShiftSupervisor)selectedEmployee);
                shiftSupervisorForm.ShowDialog();
                shiftSupervisorForm.Dispose();
            }
            else if (selectedEmployee.GetType() == typeof(TeamLeader))
            {
                TeamLeaderForm teamLeaderForm = new TeamLeaderForm();
                teamLeaderForm.DisplayEmployee((TeamLeader)selectedEmployee);
                teamLeaderForm.ShowDialog();
                teamLeaderForm.Dispose();
            }
        }

        /// <summary>
        /// Shows the Shift Supervisor Dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void workerButton_Click_1(object sender, EventArgs e)
        {
            ShiftSupervisorForm shiftSupervisorForm = new ShiftSupervisorForm();
            shiftSupervisorForm.ShowDialog();
            shiftSupervisorForm.Dispose();
        }

        /// <summary>
        /// Shows the Shift Supervisor Dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void supervisorButton_Click(object sender, EventArgs e)
        {
            ShiftSupervisorForm shiftSupervisorForm = new ShiftSupervisorForm();

            // Set the next Employee Number
            shiftSupervisorForm.AddNewEmployee(++nextEmployeeID);
            shiftSupervisorForm.ShowDialog();

            // Before we dispose of the form, check to see if we have an object
            if (shiftSupervisorForm.shiftSupervisor != null)
                // Add it to the Employee List so it shows in the datagrid
                employeeList.Add(shiftSupervisorForm.shiftSupervisor);
            shiftSupervisorForm.Dispose();
        }

        private void teamLeadButton_Click(object sender, EventArgs e)
        {
            TeamLeaderForm teamLeaderForm = new TeamLeaderForm();

            // Set the next Employee Number
            teamLeaderForm.AddNewEmployee(++nextEmployeeID);
            teamLeaderForm.ShowDialog();

            // Before we dispose of the form, check to see if we have an object
            if (teamLeaderForm.teamLeader != null)
                // Add it to the Employee List so it shows in the datagrid
                employeeList.Add(teamLeaderForm.teamLeader);
            teamLeaderForm.Dispose();
        }
    }
}