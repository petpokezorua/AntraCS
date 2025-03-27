using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversedUsingArray = new string(charArray);
        Console.WriteLine($"Reversed (using char array): {reversedUsingArray}");

        string reversedUsingLoop = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversedUsingLoop += input[i];
        }
        Console.WriteLine($"Reversed (using for-loop): {reversedUsingLoop}");
    }
}