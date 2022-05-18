using System;

namespace FloatDataTypes
{
    /// <summary>
    /// Demonstrates Floating Point Data Types
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int score = 1369;
            int secondsPlayed = 100000;
            float pointsPerSecond = (float)score/secondsPlayed;

            Console.WriteLine("Points Per Second: " + pointsPerSecond);
        }
    }
}
