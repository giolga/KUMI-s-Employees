﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUMIEmployees.Model
{

    public enum Jobs
    {
        Network_Administrator = 0,
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
        Doctorate
    }

    public class Employee
    {
        public static int PersonId { get; set; } = 42;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }
        public string PersonalId { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public Jobs JobPosition { get; set; }
        public UniversityDegree Degree{ get; set; }
        public string Tel { get; set; }
        public int Salary { get; set; }
        public int Bonus { get; set; }
        public string ImageUrl { get; set; } = "/Images/add-person.png";
        public string Biography {get; set; }
        public string Address { get; set; }

        public Employee()
        {
            
        }
        public Employee(int id, string name, string surename, string email, Jobs jobPosition, string tel, int salary, int bonus)
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
        public Employee(int id, string name, string surename, string personalId ,string email, Jobs jobPosition, string tel, int salary, int bonus)
        {
            Id = id;
            Name = name;
            Surename = surename;
            PersonalId  = personalId;
            Email = email;
            JobPosition = jobPosition;
            Tel = tel;
            Salary = salary;
            Bonus = bonus;
        }
        public Employee(int id, string name, string surename, string email, Jobs jobPosition, UniversityDegree degree ,string tel, int salary, int bonus)
        {
            Id = id;
            Name = name;
            Surename = surename;
            Email = email;
            JobPosition = jobPosition;
            Degree = degree;
            Tel = tel;
            Salary = salary;
            Bonus = bonus;
        }

    }
}
