using System;

namespace EvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter a number");

            num = int.Parse(Console.ReadLine());

            if( num % 2 == 0)
            {
                Console.WriteLine("Entered number is Even");
            }
            else
            {
                Console.WriteLine("Entered number is Odd");
            }
            Console.Read();
        }
    }
}
