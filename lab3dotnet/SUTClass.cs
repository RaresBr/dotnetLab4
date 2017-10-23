using System;
using System.Collections.Generic;

namespace lab3dotnet
{
    public  class SUTClass
    {
        List<Employee> Employees;
        Employee manager1 = new Manager("firstMan1", "lastMan1", DateTime.Now, DateTime.Now.AddDays(1), 5000);
        Employee manager2 = new Manager("a", "b", DateTime.Now.AddDays(33), DateTime.Now.AddDays(111), 4555);
        Employee manager3 = new Manager("a", "b", DateTime.Now.AddDays(33), DateTime.Now.AddDays(111), 4555);
        Employee manager4 = new Manager("a", "b", DateTime.Now.AddDays(33), DateTime.Now.AddDays(111), 4555);
        Employee manager5 = new Manager("a", "b", DateTime.Now.AddDays(33), DateTime.Now.AddDays(111), 4555);

        Employee architect1 = new Architect("firstArch1", "lastArch1", DateTime.Now, DateTime.Now.AddDays(10), 4000);
        Employee architect2 = new Architect("a", "b", DateTime.Now.AddDays(33), DateTime.Now.AddDays(101), 4400);
        Employee architect3 = new Architect("a", "b", DateTime.Now.AddDays(33), DateTime.Now.AddDays(101), 4400);
        Employee architect4 = new Architect("a", "b", DateTime.Now.AddDays(33), DateTime.Now.AddDays(101), 4400);
        Employee architect5 = new Architect("a", "b", DateTime.Now.AddDays(33), DateTime.Now.AddDays(101), 4400);

        private EmployeeMethodRepository mrepo;
        private EmployeeQueryRepository qrepo;

        public EmployeeMethodRepository MethodRepo {
            get {
                Employees = new List<Employee>
                {
                    manager1,
                    manager2,
                    manager3,
                    manager4,
                    manager5,
                    architect1,
                    architect2,
                    architect3,
                    architect4,
                    architect5
                };

                mrepo = new EmployeeMethodRepository(Employees);
                return mrepo;
            }
        }

        public EmployeeQueryRepository QueryRepo {
            get {
                Employees = new List<Employee>
                {
                    manager1,
                    manager2,
                    manager3,
                    manager4,
                    manager5,
                    architect1,
                    architect2,
                    architect3,
                    architect4,
                    architect5
                };
                qrepo = new EmployeeQueryRepository(Employees);
                return qrepo;
            }
        }
    }
}
