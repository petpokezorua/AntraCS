using System;

class Program
{
    static void Main()
    {
        DateTime birthDate = new DateTime(2002, 1, 1); 

        DateTime currentDate = DateTime.Now;

        int daysOld = (currentDate - birthDate).Days;

        int daysToNextAnniversary = 10000 - (daysOld % 10000);
        DateTime nextAnniversaryDate = currentDate.AddDays(daysToNextAnniversary);

        Console.WriteLine($"You are {daysOld} days old.");
        Console.WriteLine($"Your next 10,000-day anniversary will be on {nextAnniversaryDate:MMMM dd, yyyy}.");
    }
}