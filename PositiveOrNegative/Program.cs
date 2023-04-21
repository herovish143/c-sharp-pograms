using System;

namespace PositiveOrNegative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("number is negative " + number );
            } else if(number == 0)
            {
                Console.WriteLine("number is zero (0) " + number);
            } else
            {
                Console.WriteLine("number is positive " + number);
            }
        }
    }
}
