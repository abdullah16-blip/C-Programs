using System;

namespace ProgrammingAssignment1
{
    class Program
    {
        /// <summary>
        /// Programming Assignment 1 Solution
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //welcome message
            Console.WriteLine("Welcome!");
            Console.WriteLine("This application will calculate the distance between two points and the angle between those points");
            
            //prompt for input
            Console.WriteLine("Enter first point's x value: ");
            float point1x=float.Parse(Console.ReadLine());

            Console.WriteLine("Enter first point's y value: ");
            float point1y=float.Parse(Console.ReadLine());

            Console.WriteLine("Enter second point's x value: ");
            float point2x=float.Parse(Console.ReadLine());

            Console.WriteLine("Enter second point's y value: ");
            float point2y=float.Parse(Console.ReadLine());

            //calculate delta x and delta y
            float deltaX = point2x - point1x;
            float deltaY = point2y - point1y;

            //calculate distance between point 1 and point 2
            float distance = (float)Math.Sqrt(Math.Pow(deltaX,2) + Math.Pow(deltaY,2));
            Console.WriteLine("Distance between two points: " + Math.Round(distance,3));

            //calculate angle between two points
            float radian = (float)Math.Atan2(deltaY,deltaX);
            float angle = radian * (180/(float)Math.PI);
            Console.WriteLine("Angle between two points: " + Math.Round(angle,3));
        }
    }
}
