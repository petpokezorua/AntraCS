using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the sequence of numbers (space-separated):");
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Dictionary<int, int> frequency = new Dictionary<int, int>();

        int maxFrequency = 0;
        int mostFrequentNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (!frequency.ContainsKey(number))
            {
                frequency[number] = 0;
            }
            frequency[number]++;

            if (frequency[number] > maxFrequency || 
                (frequency[number] == maxFrequency && Array.IndexOf(numbers, number) < Array.IndexOf(numbers, mostFrequentNumber)))
            {
                maxFrequency = frequency[number];
                mostFrequentNumber = number;
            }
        }

        Console.WriteLine($"The number {mostFrequentNumber} is the most frequent (occurs {maxFrequency} times).");
    }
}