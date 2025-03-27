using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the array of integers (space-separated):");
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int maxLength = 1;
        int currentLength = 1;
        int bestStartIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1]) 
            {
                currentLength++;
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    bestStartIndex = i - maxLength + 1;
                }
            }
            else
            {
                currentLength = 1; 
            }
        }

        int[] longestSequence = array.Skip(bestStartIndex).Take(maxLength).ToArray();
        Console.WriteLine(string.Join(" ", longestSequence));
    }
}