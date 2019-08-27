using System;
using System.IO;

namespace sec13_fileinfo_file_ioexception
{
    class Program
    {
        static void Main(string[] args)
        {
            string SoucePath = @"C:\Users\gguima\Documents\file1.txt";
            string TargetPath = @"C:\Users\gguima\Documents\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(SoucePath);

                fileInfo.CopyTo(TargetPath);
                string[] lines = File.ReadAllLines(SoucePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error occurred.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
