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
    /// Interaction logic for GetEmployee.xaml
    /// </summary>
    public partial class GetEmployee : UserControl
    {
        public delegate void GetEmployeeFromMyComapny(int empId);
        public event GetEmployeeFromMyComapny GetPerson;
        public GetEmployee()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            RatingLbl.Content = string.Empty;
            try
            {
                GetPerson?.Invoke(int.Parse(GetEmployeeTB.Text.ToString()));
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
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
