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
    /// Interaction logic for DeleteEmployee.xaml
    /// </summary>
    public partial class DeleteEmployee : UserControl
    {
        public delegate void GetEmployeeFromMyCompany(Employee employee);
        public event GetEmployeeFromMyCompany getEmployee;
        public DeleteEmployee()
        {
            InitializeComponent();

        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {

            try
            {

                int employeeId = int.Parse(EmployeeId.Text);

                var employee = MainWindow.employees.FirstOrDefault(emp => emp.Id == employeeId);
                if (employee == null)
                {
                    MessageBox.Show($"Employee with the id: {employeeId} doesn't Exists! Try Again!");
                }
                else
                {
                    DeleteEmployeeInfo deleteInfo = new DeleteEmployeeInfo(this); // Once I start searching pop up the employee info/UC
                    InfoGrid.Children.Add(deleteInfo);
                    ProfilePicture.Source = new BitmapImage(new Uri(employee.ImageUrl, UriKind.RelativeOrAbsolute));
                    getEmployee?.Invoke(employee);
                }
            }
            catch
            {
                MessageBox.Show("Insert Id!");
            }


        }

        private void SearchBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            SearchBtn.Cursor = Cursors.Hand;
        }

        private void SearchBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            SearchBtn.Cursor = Cursors.Arrow;
        }
    }
}
