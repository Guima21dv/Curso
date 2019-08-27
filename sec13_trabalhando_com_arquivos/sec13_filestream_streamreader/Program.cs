using System;
using System.IO;

namespace sec13_filestream_streamreader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\gguima\Documents\file1.txt";

            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("um Erro ocorreu");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) { 
                    sr.Close();
                }
            }
        }
    }
}
