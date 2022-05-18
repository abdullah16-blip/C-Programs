using System;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Guy! Please type in your birth month: ");
            string bmonth = Console.ReadLine();

            Console.WriteLine("Yer birthday?");
            int bday = int.Parse(Console.ReadLine());

            Console.WriteLine("Yer Birth month: "+bmonth);
            Console.WriteLine("Yer Birthday: "+bday);
            bday-=1;
            Console.WriteLine("You'll get a reminder on "+bday+ " for 20% off on a local store!!!! eeeee");
        }
    }
}
