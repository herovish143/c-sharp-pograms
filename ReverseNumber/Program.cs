using System;

/**
 *  WAP to Reverse a Number
 */

namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, reverse = 0;

            Console.WriteLine("Please enter the number.");
            num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                reverse *= 10;
                reverse += num % 10;
                num /= 10;
            }

            Console.WriteLine("Reversed number is: {0} ", reverse);
            Console.ReadKey();
        }
    }
}
