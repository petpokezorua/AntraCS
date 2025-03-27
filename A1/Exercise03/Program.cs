using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

/* For the upcoming code of byte i = 0 loop, it will give you compilation error because we're comparing a byte var i with int max. 

We can add a check before the loop to ensure it doesn't overflow.

Ex:             int max = 500;
            if (max > byte.MaxValue)
            {
                Console.WriteLine("Warning: The max value exceeds the range of the byte type (0-255).");
                return;
            }

            for (byte i = 0; i < max; i++) // This will still cause an issue
            {
                Console.WriteLine(i);
            }
*/