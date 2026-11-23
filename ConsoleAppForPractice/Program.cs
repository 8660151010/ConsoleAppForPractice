
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

//3).   Write a program to count the number of occurrences of each character in a string using C# using LINQ
//I / P: hello
//O/P:
//h: 1
//e: 1
//l: 2
//o: 1

//CharCount charCount = new();
//Using Dictionary
//charCount.CountCharachters();

//Using LINQ
//charCount.CountCharachtersUsingLINQ();
//String Input = "My Name is Prashant Kumar";
//Input.GroupBy(c => c).Select(s => new { Character = s.Key, Count = s.Count() }).ToList().ForEach(s => Console.WriteLine($"Character: {s.Character}, Count: {s.Count}"));
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
//var _ = Context.GetEmployeesA();
//_.Select(x => x).Distinct().OrderByDescending(s => s.Salary).Skip(5).Take(1).ToList()
//    .ForEach(s => Console.WriteLine($"id: {s.Id}, Name: {s.Name}, Salary: {s.Salary}"));

//var result = _.GroupBy(e => e.Department)
//    .Select(g => new
//    {
//        Department = g.Key,
//        AverageSalary = g.Average(e => e.Salary)
//    }).Skip(1).Take(3).ToList();

//result.ForEach(s =>
//    Console.WriteLine(
//        $"Department: {s.Department}, Average Salary: {s.AverageSalary:F2}"
//    ));

//10).   Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target. Each input would have exactly one solution, and you may not use the same element twice. You can return the answer in any order

//Example 1:
//Input: nums = [2,7,11,15], target = 9
//Output: [0,1]
//Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

//Example 2:
//Input: nums = [3,2,4], target = 6
//Output: [1,2]

//Example 3:
//Input: nums = [3,3], target = 6
//Output: [0,1]

//AddTwoNoFromArray.GetIndices();
//AddTwoNoFromArray.GetIndicesUsingDictionary();

//11). find duplicate using LINQ int[] numbers = { 1, 2, 3, 4, 5, 2, 3, 7, 8, 5 };
int[] numbers = { 1, 2, 3, 4, 5, 2, 3, 7, 8, 5 };
numbers.GroupBy(x => x).Where(w => w.Count() > 1).Select(s => new { Number = s.Key, Count = s.Count() }).ToList().ForEach(f => Console.WriteLine($"Number :- {f.Number} and Count :- {f.Count}"));
;