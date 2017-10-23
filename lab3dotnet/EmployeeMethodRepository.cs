using System;
using System.Collections.Generic;
using System.Linq;

namespace lab3dotnet
{
    public class EmployeeMethodRepository
    {
        private readonly List<Employee> employees;
        public EmployeeMethodRepository(List<Employee> employees)
        {
            this.employees = employees;
        }

        public IEnumerable<Employee> RetrieveAllArchitects()
        {
            return employees.Where(emp => emp.GetType() == typeof(Architect));
        }
        public IEnumerable<Employee> RetrieveAllManagers()
        {
            return employees.Where(emp => emp.GetType() == typeof(Manager));
        }

        public IEnumerable<Employee> RetrieveAllActiveEmployees()
        {
            return employees.Where(emp => emp.IsActive());
        }

        public IEnumerable<Employee> RetrieveAllOrderBySalaryDescending()
        {
            return employees.OrderByDescending(emp => emp.Salary);
        }
        public IEnumerable<Employee> RetrieveAllOrderBySalaryAscending()
        {
            return employees.OrderBy(emp => emp.Salary);
        }

        public IEnumerable<Employee> RetrieveAllContainsName(string name)
        {
            return employees.Where(emp => emp.GetFullName().Contains(name));
        }

        public IEnumerable<Employee> RetrieveAllByDate(DateTime startDate, DateTime endDate)
        {
            return employees.Where(emp => emp.StartDate >= startDate && emp.EndDate <= endDate);
        }
    }
}
