
using ConsoleAppForPractice;
using ConsoleAppForPractice.models;



//1).   Extension Method
    //ExtensionMethods.Square(5); //TBD
    //Console.WriteLine($"Square of 5 is: {5.Square()}");
//------------------------------------------------------------------------------------

//2).   Singleton
    //Singleton singleton1 = Singleton.singleton;
    //Singleton singleton2 = Singleton.singleton;
    //if (singleton1 == singleton2)
    //    Console.WriteLine("Both instances are the same.");
    //else
    //    Console.WriteLine("Instances are different.");
//--------------------------------------------------------------------------------------

//3).   Char Count From string
    CharCount charCount = new();
    charCount.CountCharachters();
//----------------------------------------------------------------------------------------

//4).   Get Highest from Array
    //GetHeighestFromArray getHeighestFromArray = new();
    //getHeighestFromArray.Display();

    //Load Employee and salary data
    //Context context = new();
    //var employees = context.GetEmployees();

    //foreach (var employee in employees)
    //{
    //    Console.WriteLine($"Employee ID: {employee.EmployeeId}, Name: {employee.Name}, Department: {employee.Department}, Age: {employee.Age}, Email: {employee.Email}, Basic Salary: {employee.Salary.BasicSalary}");
    //}