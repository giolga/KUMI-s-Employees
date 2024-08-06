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
        public DeleteEmployee()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            Button myBtn = new Button() { Content = "Some button", Width = 100, Height = 20 };

            InfoGrid.Children.Add(myBtn);
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
