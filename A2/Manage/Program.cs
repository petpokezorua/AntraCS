using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> itemList = new List<string>(); 

        while (true) 
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
            string input = Console.ReadLine()?.Trim(); 

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input. Please try again.");
                continue;
            }

            if (input == "--") // Clear list
            {
                itemList.Clear();
                Console.WriteLine("List cleared.");
            }
            else if (input.StartsWith("+")) // Add item
            {
                string itemToAdd = input.Substring(1).Trim();
                if (!string.IsNullOrEmpty(itemToAdd))
                {
                    itemList.Add(itemToAdd);
                    Console.WriteLine($"Added: {itemToAdd}");
                }
                else
                {
                    Console.WriteLine("No item specified to add.");
                }
            }
            else if (input.StartsWith("-")) // Remove item
            {
                string itemToRemove = input.Substring(1).Trim();
                if (itemList.Remove(itemToRemove))
                {
                    Console.WriteLine($"Removed: {itemToRemove}");
                }
                else
                {
                    Console.WriteLine($"Item not found: {itemToRemove}");
                }
            }
            else
            {
                Console.WriteLine("Invalid command. Please use +, -, or --.");
            }

            // Display the current list
            Console.WriteLine("Current List:");
            if (itemList.Count > 0)
            {
                foreach (string item in itemList)
                {
                    Console.WriteLine($"- {item}");
                }
            }
            else
            {
                Console.WriteLine("(empty)");
            }
        }
    }
}