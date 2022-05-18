using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World! Write an Integer: ");
                int i = int.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Give a good Input BOB!!!");
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("Not in range BOB!!!");
            }
            finally
            {
                Console.WriteLine("All done");
            }
            
        }
    }
}
