using System;

/**
 * WAP to get a number and display the sum of the digits.
 */

namespace SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, r, sum = 0;

            Console.WriteLine("Please enter the number");

            num = int.Parse(Console.ReadLine());

            while ( num != 0 )
            {
                r = num % 10;
                num /= 10;
                sum += r;
            }

            Console.WriteLine("Sum of digits of the numbers : {0}", sum);

            Console.ReadLine();
        }
    }
}
