using System;
using System.IO;

namespace sec13_stream_writer
{
    class Program
    {
        static void Main(string[] args)
        {
            string targetPath = @"C:\Users\gguima\Documents\file2.txt";
            string sourcePath = @"C:\Users\gguima\Documents\file1.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using(StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }catch(IOException e)
            {
                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
