using System;

namespace IntegerDataTypes
{
    /// <summary>
    /// Integer Data Types Lecture code
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates Integer data types
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int totalSecondsPlayed = 100;
            const int SecondsPerMinute = 60;
            // Calculates minutes and seconds played
            int minutesPlayed = totalSecondsPlayed / SecondsPerMinute;
            int secondsPlayed = totalSecondsPlayed % SecondsPerMinute;
            // Print results
            Console.WriteLine("Minutes Played: " + minutesPlayed);
            Console.WriteLine("Seconds Played: " + secondsPlayed);
        }
    }
}
