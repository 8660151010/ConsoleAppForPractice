namespace ConsoleAppForPractice.models
{
    public class Salary
    {
        public int SalaryId { get; set; }

        public decimal BasicSalary { get; set; }

        public decimal Bonus { get; set; }

        public decimal TotalSalary { get; set; }

        // Foreign key
        public int EmployeeId { get; set; }

        // Navigation property
        public Employee Employee { get; set; }
    }
}
