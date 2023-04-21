using System;
using System.Collections.Generic;
using System.Linq;
/*
*  A C# Program to generate odd numbers within a range.
*/
namespace Odd_In_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startRange, totalRecords;

            Console.WriteLine("Enter the start range \n");
            startRange = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of records");
            totalRecords = int.Parse(Console.ReadLine());

            IEnumerable<int> oddNums = Enumerable.Range(startRange, totalRecords).Where( x => x % 2 != 0);
            
            foreach (int i in oddNums)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
