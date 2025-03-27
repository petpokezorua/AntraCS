using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Example usage
        int startNum = 10;
        int endNum = 50;
        int[] primes = FindPrimesInRange(startNum, endNum);

        Console.WriteLine($"Prime numbers between {startNum} and {endNum}:");
        Console.WriteLine(string.Join(", ", primes));
    }

    static int[] FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primes = new List<int>();

        for (int num = Math.Max(2, startNum); num <= endNum; num++)
        {
            if (IsPrime(num))
            {
                primes.Add(num);
            }
        }

        return primes.ToArray();
    }

    static bool IsPrime(int number)
    {
        if (number < 2) return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}