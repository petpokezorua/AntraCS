using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();

        string separators = @"[.,:;=\(\)&\[\]""'\\/!? ]+";

        string[] words = Regex.Split(input, separators).Where(w => !string.IsNullOrEmpty(w)).ToArray();
        string[] separatorsArray = Regex.Matches(input, separators).Select(m => m.Value).ToArray();

        Array.Reverse(words);

        StringBuilder result = new StringBuilder();
        int wordIndex = 0, separatorIndex = 0;

        while (wordIndex < words.Length || separatorIndex < separatorsArray.Length)
        {
            if (wordIndex < words.Length)
            {
                result.Append(words[wordIndex]);
                wordIndex++;
            }

            if (separatorIndex < separatorsArray.Length)
            {
                result.Append(separatorsArray[separatorIndex]);
                separatorIndex++;
            }
        }

        Console.WriteLine(result.ToString());
    }
}