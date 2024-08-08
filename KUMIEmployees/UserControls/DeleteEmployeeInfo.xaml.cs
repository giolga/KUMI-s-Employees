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
        public DeleteEmployeeInfo()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {

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
