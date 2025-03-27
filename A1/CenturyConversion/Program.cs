using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of centuries: ");
        if (int.TryParse(Console.ReadLine(), out int centuries)) {
            const int YearsInCentury = 100;
            const double DaysInYear = 36524 / 100;
            const int HoursInDay = 24;
            const int MinutesInHour = 60;
            const int SecondsInMinute = 60;
            const int MillisecondsInSecond = 1000;
            const int MicrosecondsInMillisecond = 1000;
            const int NanosecondsInMicrosecond = 1000;

            long years = centuries * YearsInCentury;
            long days = years * (long) DaysInYear;
            long hours = days * HoursInDay;
            long minutes = hours * MinutesInHour;
            long seconds = minutes * SecondsInMinute;
            long milliseconds = seconds * MillisecondsInSecond;
            long microseconds = milliseconds * MicrosecondsInMillisecond;
            decimal nanoseconds = (decimal)microseconds * NanosecondsInMicrosecond;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
        else {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}