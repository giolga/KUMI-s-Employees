using KUMIEmployees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KUMIEmployees.UserControls
{
    /// <summary>
    /// Interaction logic for DeleteEmployeeInfo.xaml
    /// </summary>
    public partial class DeleteEmployeeInfo : UserControl
    {

        //public DeleteEmployeeInfo()
        //{
        //    InitializeComponent();

        //    DeleteEmployee employee = new DeleteEmployee();

        //    employee.getEmployee += GetEmployee;
        //}

        private DeleteEmployee deleteEmployee;

        public DeleteEmployeeInfo(DeleteEmployee deleteEmployee)
        {
            InitializeComponent();

            this.deleteEmployee = deleteEmployee;
            this.deleteEmployee.getEmployee += GetEmployee;

        }

        public void GetEmployee(Employee employee)
        {
            NameTBl.Text = employee.Name;
            SurenameTBL.Text = employee.Surename;
            PersonalIDTBL.Text = employee.PersonalId;
            BirthTBL.Text = employee.BirthDate.ToString().Split(' ')[0];
            JobPositionTBL.Text = employee.JobPosition.ToString();
            MobileTBL.Text = employee.Tel;
            DegreeTBL.Text = employee.Degree.ToString();
            AddressTBL.Text = employee.Address;
            BiographyTBL.Text = employee.Biography;
        }


        // Remove employee
        public void DeleteEmployeeFromCompany(Employee employee)
        {
            if (employee != null)
            {
                // Remove from the global list
                MainWindow.employees.Remove(employee);

                // Remove from the DataGrid
                var dataGrid = Application.Current.MainWindow.FindName("ShowAllDG") as DataGrid;
                if (dataGrid != null)
                {
                    dataGrid.Items.Remove(employee);
                }
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {

            //MessageBox.Show($"Employee Name and ID {NameTBl.Text} {PersonalIDTBL.Text}");
            var employeeToDelete = MainWindow.employees.FirstOrDefault(emp => int.Parse(emp.PersonalId) == int.Parse(PersonalIDTBL.Text));
            if (employeeToDelete != null)
            {
                DeleteEmployeeFromCompany(employeeToDelete);
                deleteEmployee.InfoGrid.Children.Remove(this);
                MessageBox.Show("Employee deleted successfully");
            }
            else
            {
                MessageBox.Show("Employee not found.");
            }

        }

        private void DeleteBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            DeleteBtn.Cursor = Cursors.Hand;
        }

        private void DeleteBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            DeleteBtn.Cursor = Cursors.Arrow;
        }

        private void MaleRB_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void MaleRB_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void FemaleRB_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void FemaleRB_Unchecked(object sender, RoutedEventArgs e)
        {

        }
    }
}
