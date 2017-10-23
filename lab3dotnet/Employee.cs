using System;

namespace lab3dotnet
{
    public abstract class Employee
    {
        protected Employee(string firstName, string lastName, DateTime startDate, DateTime endDate, double salary)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            StartDate = startDate;
            EndDate = endDate;
            Salary = salary;
        }

        public Guid Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Salary { get; set; }

        public String GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public bool IsActive()
        {
            return DateTime.Now > StartDate && DateTime.Now < EndDate;
        }

        public abstract String Salutation();
    }
}
