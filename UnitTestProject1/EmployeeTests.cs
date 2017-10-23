using System;
using lab3dotnet;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void When_ManagerSalutes_ShouldSay_HelloManager()
        {
            Manager manager = new Manager("f", "l", DateTime.Now, DateTime.Now.AddDays(1), 2500);

            var salutation = manager.Salutation();

            Assert.AreEqual("Hello manager", salutation);
            
        }
        [TestMethod]
        public void When_ManagerSalutes_ShouldSay_HelloArchitect()
        {
            Architect architect = new Architect("f", "l", DateTime.Now, DateTime.Now.AddDays(1), 2500);

            var salutation = architect.Salutation();

            Assert.AreEqual("Hello architect", salutation);

        }

        [TestMethod]
        public void When_CreatingEmployee_PropsShouldBeProperlySet()
        {
         
            Assert.AreEqual("f",employee.FirstName);
            Assert.AreEqual("l",employee.LastName);
            Assert.AreEqual(DateTime.Now.Date,employee.StartDate.Date);
            Assert.AreEqual(DateTime.Now.AddDays(1).Date,employee.EndDate.Date);
            Assert.AreEqual(2500,employee.Salary);
        }

        [TestMethod]
        public void Given_AnEmployee_GetFullName_ShouldReturnFullName()
        {
          
            Assert.AreEqual(employee.GetFullName(),"f l");
        }

        [TestMethod]
        public void Given_AnActiveEmployee_IsActive_ShouldReturnTrue()
        {
            
            Assert.AreEqual(true,employee.IsActive());
        }

        private Employee employee = new Architect("f", "l", DateTime.Now, DateTime.Now.AddDays(1), 2500);
    }
}
