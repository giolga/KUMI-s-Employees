using KUMIEmployees.Model;
using KUMIEmployees.UserControls;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace KUMIEmployees
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static string[] jobs = { "Network Administrator", "Pentester", "Software_Developer", "Software_Engineer", "Devops_Engineer", "Sys_Admin", "Manager", "Front_End_Developer", "Support", "Accountant", "Guard" };
        private Random random = new Random();

        public static Employee emp = new Employee();
        public MainWindow()
        {
            InitializeComponent();

            //string nameTxtFile = "C:\\Users\\Mikey\\OneDrive\\Desktop\\KUMIEmployees\\KUMIEmployees\\names.txt";
            //string surenameTxtFile = "C:\\Users\\Mikey\\OneDrive\\Desktop\\KUMIEmployees\\KUMIEmployees\\surenames.txt";
            addEmployeeUC.addNewEmployeeInMyCompany += AddEmp;

            string basePath = Environment.CurrentDirectory;

            //MessageBox.Show($"{basePath}");
            // Move up two directories from the current directory (bin\Debug\netX.X)
            string projectRoot = System.IO.Path.GetFullPath(System.IO.Path.Combine(basePath, @"..\..\"));

            //MessageBox.Show($"{projectRoot}");
            // Combine the project root with the EmployeeList directory
            string employeeListPath = System.IO.Path.Combine(projectRoot, "EmployeeList");

            //MessageBox.Show($"{employeeListPath}");
            // Get all files named "names.txt" in the specified directory
            string[] filePathsName = Directory.GetFiles(employeeListPath, "names.txt");
            string[] filePathsSurename = Directory.GetFiles(employeeListPath, "surenames.txt");

            //MessageBox.Show($"{filePathsName[0]}");

            string[] names = File.ReadAllLines(filePathsName[0]);
            string[] surenames = File.ReadAllLines(filePathsSurename[0]);

            //MessageBox.Show(surenames.Length.ToString());

            for (int i = 0; i < names.Length; i++)
            {
                Employee emp = new Employee(i + 1, names[i], surenames[i], $"{names[i][0].ToString().ToLower()}.{surenames[i].ToString().ToLower()}@gmail.com", "Developer", "+995557443766", 2000, 150);
                ShowAllDG.Items.Add(emp);
            }

            //ShowAllDG.Items.RemoveAt(40);
        }

        public void AddEmp(Employee myEmp) {
            ShowAllDG.Items.Add(myEmp);
        }
    }
}
