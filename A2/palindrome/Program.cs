using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a text:");
        string input = Console.ReadLine();

        string separators = @"[.,:;=\(\)&\[\]""'\\/!? ]+";
        string[] words = Regex.Split(input, separators).Where(w => !string.IsNullOrEmpty(w)).ToArray();

        List<string> palindromes = new List<string>();

        foreach (string word in words)
        {
            if (IsPalindrome(word) && !palindromes.Contains(word))
            {
                palindromes.Add(word);
            }
        }

        var sortedPalindromes = palindromes.OrderBy(p => p);
        Console.WriteLine(string.Join(", ", sortedPalindromes));
    }

    static bool IsPalindrome(string word)
    {
        if (string.IsNullOrEmpty(word)) return false;

        int length = word.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (word[i] != word[length - i - 1]) 
            {
                return false;
            }
        }
        return true;
    }
}