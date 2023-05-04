using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GROUPEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EmployeeList = new List<Employee>();
            EmployeeList.Add(new Employee("Tarun", "Mumbai"));
            EmployeeList.Add(new Employee("Katir", "Chennai"));
            EmployeeList.Add(new Employee("Seema", "Kozhikode"));
            EmployeeList.Add(new Employee("Manu", "Kozhikode"));
            EmployeeList.Add(new Employee("Mukesh", "Hyderabad"));
            EmployeeList.Add(new Employee("Clara", "Mumbai"));
            EmployeeList.Add(new Employee("Megha", "Kolkata"));
            EmployeeList.Add(new Employee("Jeeva", "Chennai"));

            var lquery = from Employee in EmployeeList
                         orderby Employee.City
                         group Employee by Employee.City;
            foreach(var emp in lquery)
            {
                Console.WriteLine("Employees with " + emp.Key + " City:");
                foreach (var empCity in emp)
                {
                    Console.WriteLine(empCity.Name);
                }
            }
        }
    }
}
