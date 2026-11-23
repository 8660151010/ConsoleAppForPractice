
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
//CharCount charCount = new();
//charCount.CountCharachters();
//----------------------------------------------------------------------------------------

//4).   Get Highest from Array
//GetHeighestFromArray getHeighestFromArray = new();
//getHeighestFromArray.Display();

//5).   Load Employee and salary data
//var employees = Context.GetEmployees().Select(x => x.Salary).Distinct().OrderByDescending(s => s.BasicSalary).Skip(1).Take(10).ToList();

//foreach (var employee in employees)
//{
//    //Console.WriteLine($"Employee ID: {employee.EmployeeId}, Name: {employee.Name}, Department: {employee.Department}, Age: {employee.Age}, Email: {employee.Email}, Basic Salary: {employee.Salary.BasicSalary}");
//    Console.WriteLine($"Basic Salary: {employee.BasicSalary}");
//}

//6).   Tuple Practice
//TuplePractice tuple = new();
//var data = tuple.GetData();
//Console.WriteLine($"Item1: {data.Item1}, Item2: {data.Item2}, Item3: {data.Item3}, Item4: {data.Item4}, Item5: {data.Item5}");

//7).   LINQ Index
//LinqIndex linqIndex = new();
//linqIndex.Display();

//9).   LINQ Practice
var _ = Context.GetEmployeesA();
//_.Select(x => x).Distinct().OrderByDescending(s => s.Salary).Skip(5).Take(1).ToList()
//    .ForEach(s => Console.WriteLine($"id: {s.Id}, Name: {s.Name}, Salary: {s.Salary}"));

var result = _.GroupBy(e => e.Department)
    .Select(g => new
    {
        Department = g.Key,
        AverageSalary = g.Average(e => e.Salary)
    }).Skip(1).Take(3).ToList();

result.ForEach(s =>
    Console.WriteLine(
        $"Department: {s.Department}, Average Salary: {s.AverageSalary:F2}"
    ));

