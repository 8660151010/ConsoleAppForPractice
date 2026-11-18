
using ConsoleAppForPractice;
using ConsoleAppForPractice.models;

//GetHeighestFromArray
//GetHeighestFromArray getHeighestFromArray = new();
//getHeighestFromArray.Display();

//Load Employee and salary data
//Context context = new();
//var employees = context.GetEmployees();

//foreach (var employee in employees)
//{
//    Console.WriteLine($"Employee ID: {employee.EmployeeId}, Name: {employee.Name}, Department: {employee.Department}, Age: {employee.Age}, Email: {employee.Email}, Basic Salary: {employee.Salary.BasicSalary}");
//}

//Extension Method
//ExtensionMethods.Square(5); //TBD
//Console.WriteLine($"Square of 5 is: {5.Square()}");

//Singleton
    Singleton singleton1 = Singleton.singleton;
    Singleton singleton2 = Singleton.singleton;
    if (singleton1 == singleton2)
        Console.WriteLine("Both instances are the same.");
    else
        Console.WriteLine("Instances are different.");