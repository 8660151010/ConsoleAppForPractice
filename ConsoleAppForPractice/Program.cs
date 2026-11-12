
using ConsoleAppForPractice;
using ConsoleAppForPractice.models;

//GetHeighestFromArray
//GetHeighestFromArray getHeighestFromArray = new();
//getHeighestFromArray.Display();

//Load Employee and salary data
Context context = new();
var employees = context.GetEmployees();

foreach (var employee in employees)
{
    Console.WriteLine($"Employee ID: {employee.EmployeeId}, Name: {employee.Name}, Department: {employee.Department}, Age: {employee.Age}, Email: {employee.Email}, Basic Salary: {employee.Salary.BasicSalary}");
}