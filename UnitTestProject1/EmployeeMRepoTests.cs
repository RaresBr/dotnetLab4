using System;
using System.Collections.Generic;
using System.Linq;
using lab3dotnet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
#pragma warning disable

namespace UnitTestProject1
{
    [TestClass]
    public class EmployeeMRepoTests
    {
        private SUTClass sutclass = new SUTClass();
       
        [TestMethod]
        public void When_RetrieveingAllArchitects_ShouldReturnAllArchitects()
        {
            var employees = sutclass.MethodRepo.RetrieveAllArchitects();

            Assert.AreEqual(employees.Count(),5);
        }
        [TestMethod]
        public void When_RetrieveingAllManagers_ShouldReturnAllArchitects()
        {            
            var employees = sutclass.MethodRepo.RetrieveAllManagers();

            Assert.AreEqual(employees.Count(), 5);
        }
        [TestMethod]
        public void When_RetrievingEmployeesByDescendingSalary_HighestShouldBeFirst()
        {
            var employees = sutclass.MethodRepo.RetrieveAllOrderBySalaryDescending();

            Assert.AreEqual(5000, employees.ToList()[0].Salary);
        }
        [TestMethod]
        public void When_RetrievingEmployeesByAscendingSalary_LowestShouldBeFirst()
        {
            var employees = sutclass.MethodRepo.RetrieveAllOrderBySalaryAscending();

            Assert.AreEqual(4000, employees.ToList()[0].Salary);
        }

        [TestMethod]
        public void When_RetrieveingActiveEmployees_ListShouldBeProper()
        {
            var employees = sutclass.MethodRepo.RetrieveAllActiveEmployees();

            Assert.AreEqual(2,employees.Count());
        }
        [TestMethod]
        public void When_RetrievingEmployeesByName_ListShouldBeOfProperLength()
        {
            var employees = sutclass.MethodRepo.RetrieveAllContainsName("first");

            Assert.AreEqual(2, employees.Count());
        }
        [TestMethod]
        public void When_RetrievingEmployeesByName_ShouldReturnAllEmployeesContainingNameParameter()
        {
            var employees = sutclass.MethodRepo.RetrieveAllContainsName("Man1");

            Assert.AreEqual(employees.ToList()[0].FirstName, "firstMan1");
        }
        [TestMethod]
        public void When_Retrieving_EmployeesByDate_ShouldReturnThoseInThatTimeInterval()
        {
            var employees = sutclass.MethodRepo.RetrieveAllByDate(DateTime.Now.AddDays(-1), DateTime.Now.AddDays(2));

            Assert.AreEqual(1, employees.Count());

        }
    }
}
