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
    }
}
