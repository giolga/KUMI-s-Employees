﻿using KUMIEmployees.Model;
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
        private static Random random = new Random();

        public static List<Employee> employees = new List<Employee>(); // List of employees

        //public static Employee emp = new Employee();

        public MainWindow()
        {
            InitializeComponent();

            //string nameTxtFile = "C:\\Users\\Mikey\\OneDrive\\Desktop\\KUMIEmployees\\KUMIEmployees\\names.txt";
            //string surenameTxtFile = "C:\\Users\\Mikey\\OneDrive\\Desktop\\KUMIEmployees\\KUMIEmployees\\surenames.txt";
            addEmployeeUC.addNewEmployeeInMyCompany += AddEmp;
            getEmploye.GetPerson += GetEmp;

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
            string[] filePathsIds = Directory.GetFiles(employeeListPath, "personalIDs.txt");

            //MessageBox.Show($"{filePathsName[0]}");

            string[] names = File.ReadAllLines(filePathsName[0]);
            string[] surenames = File.ReadAllLines(filePathsSurename[0]);
            string[] personalIDs = File.ReadAllLines(filePathsIds[0]);

            //MessageBox.Show(surenames.Length.ToString());

            //MessageBox.Show($"Count of Personal IDs {personalIDs[0]}");

            for (int i = 0; i < names.Length; i++)
            {
                Jobs position = GetRandomPosition();
                Employee emp = new Employee(i + 1, names[i], surenames[i], personalIDs[i] ,$"{names[i][0].ToString().ToLower()}.{surenames[i].ToString().ToLower()}@gmail.com", position, "+995557" + random.Next(100000, 999999).ToString(), random.Next(1200, 3501), random.Next(100, 551));
                ShowAllDG.Items.Add(emp);
                employees.Add(emp);
            }

            //ShowAllDG.Items.RemoveAt(40);
        }

        public static Jobs GetRandomPosition()
        {
            // Get all values of the Position enum
            Array values = Enum.GetValues(typeof(Jobs));

            // Generate a random index
            int randomIndex = random.Next(values.Length);

            // Return the value at the random index
            return (Jobs)values.GetValue(randomIndex);
        }

        public void AddEmp(Employee myEmp)
        {
            ShowAllDG.Items.Add(myEmp);
            employees.Add(myEmp);
        }

        public int CalculateAge(DateTime birthDate, DateTime now)
        {
            int age = now.Year - birthDate.Year;

            // For leap years we need this
            if (birthDate > now.AddYears(-age))
                age--;
            // Don't use:
            // if (birthDate.AddYears(age) > now) 
            //     age--;

            return age;
        }

        public void GetEmp(int empId)
        {
            var myEmp = employees.FirstOrDefault(e => e.Id == empId);

            if (myEmp == null)
            {
                MessageBox.Show($"No such employee exists in My Company (Probably he/she doesn't deserve it): {empId}");
                return;
            }

            getEmploye.employeePhoto.Source = new BitmapImage(new Uri(myEmp.ImageUrl, UriKind.RelativeOrAbsolute));
            getEmploye.NameTBl.Text = myEmp.Name;
            getEmploye.LastnameTBl.Text = myEmp.Surename;
            getEmploye.MobileTBl.Text = myEmp.Tel;
            getEmploye.EmailTBl.Text = myEmp.Email;
            getEmploye.GenderTBl.Text = myEmp.Gender.ToString();
            getEmploye.AddressTBl.Text = myEmp.Address;
            getEmploye.BirthDateTBl.Text = myEmp.BirthDate.ToString();
            getEmploye.AgeTBl.Text = CalculateAge(myEmp.BirthDate, DateTime.Now).ToString();
            getEmploye.PersonalIdTBl.Text = myEmp.PersonalId;
            getEmploye.UniversityDegreeDBl.Text = myEmp.Degree.ToString();
            getEmploye.JobPositionTBl.Text = myEmp.JobPosition.ToString().Replace('_', ' ');
            getEmploye.BiographyTBl.Text = myEmp.Biography;

            int rating = random.Next(1, 6);
            for (int i = 0; i < rating; i++)
            {
                getEmploye.RatingLbl.Content += '⭐'.ToString();
                getEmploye.EmpLblRating.Content = $"Employee Rating: {rating}/5";
            }

        }
    }
}
