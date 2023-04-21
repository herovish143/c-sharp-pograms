using System;
/**
 * WAP to find sum of digits of a number using recursion.
 */
namespace SumOfDigitsUsingRecurssion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            Vish vish = new Vish();

            Console.WriteLine("Please enter number to get sum of digits.");
            num = int.Parse(Console.ReadLine());

            sum = vish.sum(num);

            Console.WriteLine("Sum of digits: {0}", sum);

            Console.ReadKey();
        }
    }

    class Vish
    {
        public int sum(int num)
        {
            if(num != 0)
            {
                return ( num % 10 + sum(num /10));
            } else
            {
                return 0;
            }
        }
    }
}


