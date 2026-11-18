using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForPractice
{
    public class LinqIndex
    {
        public void Display()
        {
            string[] tasks = [ "SLK", "Honeywell", "Geidea", "Marlabs", "Perficient" ];
            foreach(var (index, task) in tasks.Index())
            {
                Console.WriteLine($"Index: {index}, Task: {task}");
            }
        }
    }
}
