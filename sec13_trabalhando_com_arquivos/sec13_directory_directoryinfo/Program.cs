using System;
using System.IO;
using System.Collections.Generic;

namespace sec13_directory_directoryinfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\gguima\Documents\myfolder";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders: ");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); //Usando a keyword var
                Console.WriteLine("Files: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + @"\NovaPastaCsharp");

                //UTILIZANDO O DIRECTORYINFO
                DirectoryInfo di = new DirectoryInfo(path);
                var folders2 = di.EnumerateDirectories("*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders: ");
                foreach (DirectoryInfo s in folders2)
                {
                    Console.WriteLine(s.FullName);
                }
                var files2 = di.EnumerateFiles("*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files: ");
                foreach (FileInfo s in files2)
                {
                    Console.WriteLine(s.FullName);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An Error Occurred!");
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
