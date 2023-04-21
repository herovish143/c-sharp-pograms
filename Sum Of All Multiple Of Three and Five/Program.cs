using System;
/*
 * WAP to Print the Sum of all the Multiples of 3 and 5
 */
namespace Sum_Of_All_Multiple_Of_Three_and_Five
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, i, sum = 0;

            for ( i  = 1; i < 100; i++ )
            {
                a = i % 3;
                b = i % 5;

                if ( a == 0 || b == 0 )
                {
                    Console.Write( "{0}\t", i );
                    sum += i;
                }
            }

            Console.WriteLine("\nThe Sum of all the Multiples of 3 or 5 Below 100 : {0}",
                          sum);

            Console.Read();
        }
    }
}
