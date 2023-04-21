using System;

/*
 * WAP Program to find whether the number is divisible by 2.
 */

namespace CheckNumberIsDivisableBy2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Please enter a number: ");
            num = int.Parse(Console.ReadLine());

            if ( num % 2 == 0)
            {
                Console.WriteLine("Number is divisiable by 2 ");
            } else
            {
                Console.WriteLine("Number is not divisiable by 2 ");
            }

            Console.WriteLine(num);
            Console.Read();
        }
    }
}
