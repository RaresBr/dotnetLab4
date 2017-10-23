using System;
using System.Linq;
using lab3dotnet;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class EmployeeQRepoTests { 
        private SUTClass sutclass = new SUTClass();

        [TestMethod]
        public void When_RetrieveingAllArchitects_ShouldReturnAllArchitects()
        {
            var employees = sutclass.QueryRepo.RetrieveAllArchitects();

            Assert.AreEqual(employees.Count(), 5);
        }
        [TestMethod]
        public void When_RetrieveingAllManagers_ShouldReturnAllArchitects()
        {
            var employees = sutclass.QueryRepo.RetrieveAllManagers();

            Assert.AreEqual(employees.Count(), 5);
        }
        [TestMethod]
        public void When_RetrievingEmployeesByDescendingSalary_HighestShouldBeFirst()
        {
            var employees = sutclass.QueryRepo.RetrieveAllOrderBySalaryDescending();

            Assert.AreEqual(5000, employees.ToList()[0].Salary);
        }
        [TestMethod]
        public void When_RetrievingEmployeesByAscendingSalary_LowestShouldBeFirst()
        {
            var employees = sutclass.QueryRepo.RetrieveAllOrderBySalaryAscending();

            Assert.AreEqual(4000, employees.ToList()[0].Salary);
        }

        [TestMethod]
        public void When_RetrieveingActiveEmployees_ListShouldBeProper()
        {
            var employees = sutclass.QueryRepo.RetrieveActiveEmployees();

            Assert.AreEqual(2, employees.Count());
        }
        [TestMethod]
        public void When_RetrievingEmployeesByName_ListShouldBeOfProperLength()
        {
            var employees = sutclass.QueryRepo.RetrieveAllContainsName("first");

            Assert.AreEqual(2, employees.Count());
        }
        [TestMethod]
        public void When_RetrievingEmployeesByName_ShouldReturnAllEmployeesContainingNameParameter()
        {
            var employees = sutclass.QueryRepo.RetrieveAllContainsName("Man1");

            Assert.AreEqual(employees.ToList()[0].FirstName, "firstMan1");
        }
        [TestMethod]
        public void When_Retrieving_EmployeesByDate_ShouldReturnThoseInThatTimeInterval()
        {
            var employees = sutclass.QueryRepo.RetrieveAllByDate(DateTime.Now.AddDays(-1), DateTime.Now.AddDays(2));

            Assert.AreEqual(1, employees.Count());

        }
    }
}
