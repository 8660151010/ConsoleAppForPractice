namespace ConsoleAppForPractice.models
{
    public static class Context
    {
        public static List<Employee> GetEmployees()
        {
            Random random = new Random();
            List<Employee> employees = new();

            for (int i = 1; i <= 100; i++)
            {
                employees.Add(new Employee
                {
                    EmployeeId = i,
                    Name = "Employee" + i,
                    Department = "IT",
                    Age = 25 + (i % 10),
                    Email = "employee" + i + "@example.com",

                    Salary = new Salary
                    {
                        SalaryId = i,
                        BasicSalary = random.Next(1000, 10000)
                    }
                });
            }

            return employees;
        }

        public static List<EmployeeA> GetEmployeesA()
        {
            List<EmployeeA> employees = new()
            {
                new EmployeeA {Id = 1, Name = "Employee1", Email = "employee1@example.com", Department = "IT", Age = 25, Salary = 5000 },
                new EmployeeA {Id = 2, Name = "Employee2", Email = "employee2@example.com", Department = "BPO", Age = 26, Salary = 5500 },
                new EmployeeA {Id = 3, Name = "Employee3", Email = "employee3@example.com", Department = "HR", Age = 27, Salary = 6000 },
                new EmployeeA {Id = 4, Name = "Employee4", Email = "employee4@example.com", Department = "IT", Age = 28, Salary = 6500 },
                new EmployeeA {Id = 5, Name = "Employee5", Email = "employee5@example.com", Department = "BPO", Age = 29, Salary = 7000 },
                new EmployeeA {Id = 6, Name = "Employee6", Email = "employee6@example.com", Department = "IT", Age = 30, Salary = 7500 },
                new EmployeeA {Id = 7, Name = "Employee7", Email = "employee7@example.com", Department = "HR", Age = 31, Salary = 8000 },
                new EmployeeA {Id = 8, Name = "Employee8", Email = "employee8@example.com", Department = "BPO", Age = 32, Salary = 8500 },
                new EmployeeA {Id = 9, Name = "Employee9", Email = "employee9@example.com", Department = "IT", Age = 33, Salary = 9000 },
                new EmployeeA {Id = 10, Name = "Employee10", Email = "employee10@example.com", Department = "HR", Age = 34, Salary = 9500 },
                new EmployeeA {Id = 11, Name = "Employee11", Email = "employee11@example.com", Department = "BPO", Age = 35, Salary = 10000 }
            };           
                
            return employees;
        }

    }
}
