using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUMIEmployees.Model
{

    public enum Jobs
    {
        Network_Administrator,
        Pentester,
        Software_Developer,
        Software_Engineer,
        Devops_Engineer,
        Sys_Admin,
        Manager,
        Front_End_Developer,
        Support,
        Accountant,
        Guard
    }

    public enum Gender
    {
        Male,
        Female
    }

    public enum UniversityDegree
    {
        Bachelor,
        Master,
        Doctoral
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }
        public string PersonalId { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string JobPosition { get; set; }
        public string Tel { get; set; }
        public int Salary { get; set; }
        public int Bonus { get; set; }
        public string ImageUrl { get; set; } = "/Images/add-person.png";

        public Employee()
        {
            
        }
        public Employee(int id, string name, string surename, string email, string jobPosition, string tel, int salary, int bonus)
        {
            Id = id;
            Name = name;
            Surename = surename;
            Email = email;
            JobPosition = jobPosition;
            Tel = tel;
            Salary = salary;
            Bonus = bonus;
        }

    }
}
