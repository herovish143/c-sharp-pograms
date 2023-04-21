using System;

namespace Largest_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b;

            Console.WriteLine("Please enter the two numbers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Biggest number is a " + a);
            }
            else
            {
                Console.WriteLine("Biggest numbetr is b " + b);
            }

            Console.Read();
        }
    }
}
