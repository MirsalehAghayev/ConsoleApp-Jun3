
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Helpers;
namespace ConsoleApp1
{
    class Department
    {

        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        public int Budget { get; set; }
        public int RequiredExperience { get; set; }
        public bool IsBachelorDegreeRequired { get; set; }

        Employee[] employees = new Employee[0];
        public Department()
        {
        }
        public Department(string name, int employeelimit, int budget, int requiredexperience, bool isbachelordegreerequired) : this()
        {

            Name = name;
            EmployeeLimit = employeelimit;
            Budget = budget;
            RequiredExperience = requiredexperience;
            IsBachelorDegreeRequired = isbachelordegreerequired;

        }
        public bool AddEmployee(Employee employee)
        {

            if (employee.Experience >= RequiredExperience && employee.HasBachelorDegree == IsBachelorDegreeRequired)
            {
                Array.Resize(ref employees, employees.Length + 1);
                employees[employees.Length - 1] = employee;
                int sum = 0;
                foreach (var ep in employees)
                {
                    sum += ep.Salary;
                }
                if (EmployeeLimit >= employees.Length && sum <= Budget)
                {
                    return true;
                }
            }

            return false;
        }
        public void Ortalama()
        {
            int cem = 0;

            foreach (var item in employees)
            {
                cem += item.Salary;
            }

            int count = employees.Length;
            Helper.Print($"Umumi emek haqqi ortalamasi :{cem / count}", ConsoleColor.Blue);
        }
    }

}



