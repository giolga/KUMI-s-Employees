using Microsoft.Win32;
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
using System.IO;
using KUMIEmployees.Model;

namespace KUMIEmployees.UserControls
{
    /// <summary>
    /// Interaction logic for AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : UserControl
    {
        public delegate void AddNewEmployeeInMyCompany(Employee employee);
        public event AddNewEmployeeInMyCompany addNewEmployeeInMyCompany;

        public static Employee addNewEmployee;
        public static string imageUrl = "/Images/add-person.png";
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void DistractedBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Saved!");
            addNewEmployee = new Employee();


            if (NameTB.Text.Trim().Equals(""))
            {
                NameTB.Background = Brushes.Pink;
                if (MessageBox.Show("Empty Field!\nPLease Enter the Employee name", "Error", MessageBoxButton.OK) == MessageBoxResult.OK)
                {
                    NameTB.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#DADADA"));
                }
            }
            else if (SurenameTB.Text.Trim().Equals(""))
            {
                SurenameTB.Background = Brushes.Pink;
                if (MessageBox.Show("Empty Field!\nPLease Enter the Employee name", "Error", MessageBoxButton.OK) == MessageBoxResult.OK)
                {
                    SurenameTB.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#DADADA"));
                }
            }
            else if (PersonalIDTB.Text.Trim().Equals(""))
            {
                PersonalIDTB.Background = Brushes.Pink;
                if (MessageBox.Show("Empty Field!\nPLease Enter the Employee personal ID", "Error", MessageBoxButton.OK) == MessageBoxResult.OK)
                {
                    PersonalIDTB.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#DADADA"));
                }
            }
            else if (PersonalIDTB.Text.Trim().Length != 11 || !PersonalIDTB.Text.Trim().ToString().All(char.IsDigit))
            {
                PersonalIDTB.Background = Brushes.Pink;
                if (MessageBox.Show("Incorrect field!\nEmployee ID must contain 11 digits", "Error", MessageBoxButton.OK) == MessageBoxResult.OK)
                {
                    PersonalIDTB.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#DADADA"));
                }
            }
            else if (MaleRB.IsChecked == false && FemaleRB.IsChecked == false)
            {
                MaleLbl.Background = Brushes.Pink;
                FemaleLbl.Background = Brushes.Pink;
                if (MessageBox.Show("Empty Field\nPlease Enter employee gender", "Error", MessageBoxButton.OK) == MessageBoxResult.OK)
                {
                    MaleLbl.Background = Brushes.Transparent;
                    FemaleLbl.Background = Brushes.Transparent;
                }
            }
            else if (BirthTB.Text.Trim().Equals(""))
            {
                BirthTB.Background = Brushes.Pink;
                if (MessageBox.Show("Empty Field!\nPLease Enter the Employee birth date", "Error", MessageBoxButton.OK) == MessageBoxResult.OK)
                {
                    BirthTB.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#DADADA"));
                }
            }
            else if (!DateTime.TryParse(BirthTB.Text.ToString(), out DateTime empBirthDay)) //DateTime correctness
            {
                BirthTB.Background = Brushes.Pink;
                if (MessageBox.Show("Incorrect field!\nPLease Enter the Employee birth date in correct format (yy/mm/dd)", "Error", MessageBoxButton.OK) == MessageBoxResult.OK)
                {
                    BirthTB.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#DADADA"));
                }
            }
            else if (JobPositionTB.Text.Trim().Equals(""))
            {
                JobPositionTB.Background = Brushes.Pink;
                if (MessageBox.Show("Empty Field!\nPLease Enter the Employee name", "Error", MessageBoxButton.OK) == MessageBoxResult.OK)
                {
                    JobPositionTB.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#DADADA"));
                }
            }
            else if (MobileTB.Text.Trim().Equals(""))
            {
                MobileTB.Background = Brushes.Pink;
                if (MessageBox.Show("Empty Field!\nPLease Enter the Employee name", "Error", MessageBoxButton.OK) == MessageBoxResult.OK)
                {
                    MobileTB.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#DADADA"));
                }
            }
            else if (DegreeTB.Text.Trim().Equals(""))
            {
                DegreeTB.Background = Brushes.Pink;
                if (MessageBox.Show("Empty Field!\nPLease Enter the Employee name", "Error", MessageBoxButton.OK) == MessageBoxResult.OK)
                {
                    DegreeTB.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#DADADA"));
                }
            }
            else if (AddressTB.Text.Trim().Equals(""))
            {
                AddressTB.Background = Brushes.Pink;
                if (MessageBox.Show("Empty Field!\nPLease Enter the Employee address", "Error", MessageBoxButton.OK) == MessageBoxResult.OK)
                {
                    AddressTB.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#DADADA"));
                }
            }
            else
            {
                MessageBox.Show("Everything is OK, Ready To Add Employee :)");
                addNewEmployee.Id = 155;
                addNewEmployee.Name = NameTB.Text.ToString();
                addNewEmployee.Surename = SurenameTB.Text.ToString();
                addNewEmployee.PersonalId = PersonalIDTB.Text.ToString();
                addNewEmployee.Email = $"{NameTB.Text[0].ToString().ToLower()}.{SurenameTB.Text.ToString().ToLower().Replace(' ', '_')}@gmail.com";
                addNewEmployee.Gender = Gender.Male;
                addNewEmployee.BirthDate = empBirthDay;
                addNewEmployee.JobPosition = (Jobs)Enum.Parse(typeof(Jobs), JobPositionTB.Text.ToString().Replace(' ', '_'));
                addNewEmployee.Degree = (UniversityDegree)Enum.Parse(typeof (UniversityDegree), DegreeTB.Text.ToString());
                addNewEmployee.Tel = MobileTB.Text.ToString();
                addNewEmployee.Salary = 3500;
                addNewEmployee.Bonus = 150;
                addNewEmployee.ImageUrl = imageUrl;
                addNewEmployee.Biography = BiographyTb.Text.ToString();

                addNewEmployeeInMyCompany?.Invoke(addNewEmployee);

                //MessageBox.Show($"Given person dateTime: {addNewEmployee.BirthDate}");
                MessageBox.Show($"Given person Job Position: {addNewEmployee.JobPosition}");
                MessageBox.Show($"Given person Uni Degree: {addNewEmployee.Degree}");
            }

        }


        private void EmployeePhotoBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == true)
            {
                AddPersonImg.Source = new BitmapImage(new Uri(openFileDialog.FileName, UriKind.Absolute));
                imageUrl = openFileDialog.FileName;
                MessageBox.Show(openFileDialog.FileName);
            }
        }


        private void MaleRB_Checked(object sender, RoutedEventArgs e)
        {
            MaleLbl.FontWeight = FontWeights.Bold;
            MaleImg.Opacity = 1;
        }


        private void FemaleRB_Checked(object sender, RoutedEventArgs e)
        {
            FemaleLbl.FontWeight = FontWeights.Bold;
            FemaleImg.Opacity = 1;
        }


        private void MaleRB_Unchecked(object sender, RoutedEventArgs e)
        {
            MaleLbl.FontWeight = FontWeights.Normal;
            MaleImg.Opacity = 0.5;
        }


        private void FemaleRB_Unchecked(object sender, RoutedEventArgs e)
        {
            FemaleImg.Opacity = 0.5;
            FemaleLbl.FontWeight = FontWeights.Normal;
        }

        private void JobPosition_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem item = (ComboBoxItem)comboBox.SelectedItem;
            JobPositionTB.Text = item.Content.ToString();
        }

        private void DegreeCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem item = (ComboBoxItem)comboBox.SelectedItem;
            DegreeTB.Text = item.Content.ToString();
        }
    }
}
