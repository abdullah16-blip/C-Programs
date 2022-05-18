using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an angle: ");
            float angle = float.Parse(Console.ReadLine());
            angle *= (float)Math.PI / 180;
            Console.WriteLine("Cosine: " + Math.Cos(angle));
            Console.WriteLine("Sine:   " + Math.Sin(angle));
        }
    }
}