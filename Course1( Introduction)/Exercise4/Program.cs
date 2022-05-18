using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first altitude: ");
            int altitude1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second altitude: ");
            int altitude2 = int.Parse(Console.ReadLine());
            int ans = altitude2 - altitude1;
            Console.WriteLine("The altitude change: " + ans);
        }
    }
}
