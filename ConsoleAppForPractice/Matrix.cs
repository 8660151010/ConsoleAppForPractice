using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForPractice
{
    public class Matrix
    {
        public void Display()
        {
            Console.WriteLine("Enter Size Of Matrix");
            int size = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int first = 0;
            int second = 0;
            int total = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (i == j)
                        first = first + matrix[i, j];
                    if (i + j == size - 1)
                        second = second + matrix[i, j];
                    if(i == j || i + j == size - 1)
                        total = total + matrix[i, j];
                }
            }

            Console.WriteLine($"Primary Diagonal Sum = {first} Secondary Diagonal Sum = {second} Total Diagonal Sum = {total}");
        }
    }
}


//Write a C# program to find the sum of the diagonal elements of a square matrix. The program should: 
//Accept the size of the square matrix from the user. 
//Accept all elements of the matrix as user input. 
//Display the matrix in proper format. 
//Compute and display: 
//The sum of the primary diagonal elements. 
//The sum of the secondary diagonal elements. 
//The total diagonal sum, ensuring the center element (in case of an odd-sized matrix) is not counted twice.
 
//Example Enter the size of square matrix: 3 Enter the elements of the matrix: 
//1 2 3
//4 5 6
//7 8 9


//O / p:
//Matrix:
//1 2 3
//4 5 6
//7 8 9


//Primary Diagonal Sum = 15
//Secondary Diagonal Sum = 15
//Total Diagonal Sum = 25
