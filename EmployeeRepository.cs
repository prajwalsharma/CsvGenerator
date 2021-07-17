using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvGenerator
{
    public static class EmployeeRepository
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>() { 
                new Employee { 
                    ID = 1, 
                    FirstName = "John", 
                    LastName = "Smith", 
                    Department = "Finance",
                    Email = "john@smith.com",
                    Location = "Seattle"
                },
                new Employee {
                    ID = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Department = "HR",
                    Email = "john@smith.com",
                    Location = "New York"
                },
                new Employee {
                    ID = 3,
                    FirstName = "Jenny",
                    LastName = "Smith",
                    Department = "Software Support Seervices",
                    Email = "john@smith.com",
                    Location = "California"
                },
                new Employee {
                    ID = 4,
                    FirstName = "Adam",
                    LastName = "Smith",
                    Department = "Networking",
                    Email = "john@smith.com",
                    Location = "Denver"
                },
                new Employee {
                    ID = 5,
                    FirstName = "Rambo",
                    LastName = "Smith",
                    Department = "Social Media",
                    Email = "john@smith.com",
                    Location = "Toronto"
                },
                new Employee {
                    ID = 6,
                    FirstName = "Jake",
                    LastName = "Smith",
                    Department = "Marketing",
                    Email = "john@smith.com",
                    Location = "London"
                },
                new Employee {
                    ID = 7,
                    FirstName = "Brandy",
                    LastName = "Smith",
                    Department = "HR",
                    Email = "john@smith.com",
                    Location = "Bangalore"
                }
            };

            return employees;
        }
    }
}
