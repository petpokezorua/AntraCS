using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of rows for the pyramid: ");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine();
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}