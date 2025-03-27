using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the array of integers:");
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine("Enter the number of rotations:");
        int k = int.Parse(Console.ReadLine());

        int n = array.Length;
        int[] sum = new int[n]; 


        for (int r = 1; r <= k; r++)
        {
            int[] rotated = new int[n];

            for (int i = 0; i < n; i++)
            {
                rotated[(i + r) % n] = array[i];
            }

            for (int i = 0; i < n; i++)
            {
                sum[i] += rotated[i];
            }

            Console.WriteLine($"Rotated {r}: {string.Join(" ", rotated)}");
        }

        Console.WriteLine($"Sum: {string.Join(" ", sum)}");
    }
}