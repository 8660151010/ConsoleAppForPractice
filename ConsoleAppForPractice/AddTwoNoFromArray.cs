using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForPractice
{
    public static class AddTwoNoFromArray
    {
        public static void GetIndices()
        {
            Console.WriteLine("Enter the Size of the Array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine($"Enter the Element {size} times:");
            for (int i = 0; i < size; i++)
            {
            //    Console.WriteLine($"Enter the Element at Index {i}:");
                int element = Convert.ToInt32(Console.ReadLine());
                arr[i] = element;
            }

            Console.WriteLine("Enter the Target Sum:");
            int target = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        Console.WriteLine($"Indices of the two numbers that add up to {target} are: [{i}, {j}]");
                        return;
                    }
                }
            }
        }

        public static void GetIndicesUsingDictionary()
        {
            Console.WriteLine("Enter the Size of the Array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine($"Enter the Element {size} times:");
            for (int i = 0; i < size; i++)
            {
                int element = Convert.ToInt32(Console.ReadLine());
                arr[i] = element;
            }
            Console.WriteLine("Enter the Target Sum:");
            int target = Convert.ToInt32(Console.ReadLine());
            Dictionary<int, int> numDict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int complement = target - arr[i];
                if (numDict.ContainsKey(complement))
                {
                    Console.WriteLine($"Indices of the two numbers that add up to {target} are: [{numDict[complement]}, {i}]");
                    return;
                }
                if (!numDict.ContainsKey(arr[i]))
                {
                    numDict[arr[i]] = i;
                }
            }
        }
    }
}
