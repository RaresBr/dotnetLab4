using System;
using System.Collections.Generic;
using System.Linq;

namespace lab3dotnet
{
    public class EmployeeQueryRepository
    {
        private readonly List<Employee> employees;
        public EmployeeQueryRepository(List<Employee> employees)
        {
            this.employees = employees;
        }

        public IEnumerable<Employee> RetrieveAllArchitects()
        {
            IEnumerable<Employee> architects =
                from employee in employees
                where employee.GetType() == typeof(Architect)
                select employee;
            return architects;

        }
        public IEnumerable<Employee> RetrieveAllManagers()
        {
            IEnumerable<Employee> managers =
                from employee in employees
                where employee.GetType() == typeof(Manager)
                select employee;
            return managers;
        }

        public IEnumerable<Employee> RetrieveActiveEmployees()
        {
            IEnumerable<Employee> activeEmployees =
                from employee in employees
                where employee.IsActive()
                select employee;
            return activeEmployees;
        }

        public IEnumerable<Employee> RetrieveAllOrderBySalaryDescending()
        {
            IEnumerable<Employee> descendingEmployees =
                from employee in employees
                orderby employee.Salary descending
                select employee;
            return descendingEmployees;
        }
        public IEnumerable<Employee> RetrieveAllOrderBySalaryAscending()
        {
            IEnumerable<Employee> ascendingEmployees =
                from employee in employees
                orderby employee.Salary
                select employee;
            return ascendingEmployees;
        }

        public IEnumerable<Employee> RetrieveAllContainsName(string name)
        {
            IEnumerable<Employee> employees =
                from employee in this.employees
                where employee.GetFullName().Contains(name)
                select employee;
            return employees;
        }

        public IEnumerable<Employee> RetrieveAllByDate(DateTime startDate, DateTime endDate)
        {
            IEnumerable<Employee> employees =
                from employee in this.employees
                where employee.StartDate >= startDate && employee.EndDate <= endDate
                select employee;
            return employees;
        }
    }
}
