using System;
using System.IO;

namespace sec13_using_block
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\gguima\Documents\file1.txt";
            try
            {

                using (
                    StreamReader sr = File.OpenText(path)
                    )
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
