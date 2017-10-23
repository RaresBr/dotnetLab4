using System;

namespace lab3dotnet
{
    public class Architect : Employee
    {
        public Architect(string firstName, string lastName, DateTime startDate, DateTime endDate, double salary) : base(firstName, lastName, startDate, endDate, salary)
        {
        }

        public override String Salutation()
        {
            return "Hello" + " architect";
        }
    }
}
