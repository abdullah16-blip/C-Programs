using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = new List<string>();
            int i;

            // read from the text file
            StreamReader input = null;
            try
            {
                // create stream reader object
                input = File.OpenText("Text.txt");

                // read and echo lines until end of file
                string line = input.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = input.ReadLine();
                    lines.Add(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // always close input file
                if (input != null)
                {
                    input.Close();
                }
            }

            Console.WriteLine();

            // write to a text file
            StreamWriter output = null;
            try
            {
                // create stream writer object
                output = File.CreateText("OneStepCloser.txt");

                // write a few lines
                for (i = 0; i < lines.Count; i++)
                {
                    if (i%2==0)
                        output.WriteLine(lines[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // always close output file
                if (output != null)
                {
                    output.Close();
                }
            }
        }
    }
}
