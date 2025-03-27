using System;

class Program
{
    static void Main()
    {
        // Generate a random number between 1 and 3
        Random random = new Random();
        int randomNumber = random.Next(1, 4); // Upper bound is exclusive, so use 4

        Console.WriteLine("Guess a number between 1 and 3:");

        // Read the user's guess
        int guessedNumber = int.Parse(Console.ReadLine());

        // Check if the guess is within the valid range
        if (guessedNumber < 1 || guessedNumber > 3)
        {
            Console.WriteLine("Your guess is outside the valid range (1-3).");
        }
        else if (guessedNumber < randomNumber)
        {
            Console.WriteLine("Your guess is too low.");
        }
        else if (guessedNumber > randomNumber)
        {
            Console.WriteLine("Your guess is too high.");
        }
        else
        {
            Console.WriteLine("Congratulations! You guessed the correct number.");
        }
    }
}