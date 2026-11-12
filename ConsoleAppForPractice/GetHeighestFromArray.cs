using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForPractice
{
    public class GetHeighestFromArray
    {
        public void Display()
        {
            Console.WriteLine("Enter Size of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int first = 0, second = 0;
            Console.WriteLine("Enter elements of array: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

                if (arr[i] > first)
                {
                    second = first;
                    first = arr[i];
                }
                else if (arr[i] > second && arr[i] < first)
                {
                    second = arr[i];
                }
            }

            Console.WriteLine("First largest element is: " + first);
            Console.WriteLine("Second largest element is: " + second);


        }
    }
}
