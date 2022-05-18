using System;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string in this order (pyramid slot number,block letter,whether or not the block should be lit");
            string str = Console.ReadLine();
            
            int commalocation = str.IndexOf(',');
            int pslotnumber = int.Parse(str.Substring(0,commalocation));
            Console.WriteLine("Pyramid slot number: "+pslotnumber);

            string newstr = str.Substring(commalocation+1);
            int newcommalocation = newstr.IndexOf(',');
            char bletter = char.Parse(newstr.Substring(0,newcommalocation));
            Console.WriteLine("Block Letter: "+bletter);
            bool wontbsbl = bool.Parse(newstr.Substring(newcommalocation+1));
            Console.WriteLine("Whether or not the block should be lit: "+wontbsbl);
        }
    }
}
