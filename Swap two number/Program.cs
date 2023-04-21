using System;

namespace Swap_two_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Please enter the two numbers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("A -> " + a + " B -> " +  b);

            int c = a;
            a = b;
            b = c;

            Console.WriteLine("A -> " + a + " B -> " +  b);

            Console.Read();
        }
    }
}
