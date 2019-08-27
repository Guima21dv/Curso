using System;
using System.IO;
using System.Globalization;
using sec13_exe_fix.Entities;

namespace sec13_exe_fix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter full file path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                string sourceDirectoryPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolder = sourceDirectoryPath + @"\out";
                string targetFile = targetFolder + @"\summary.csv";
                string[] lines = File.ReadAllLines(sourceFilePath);

                Directory.CreateDirectory(targetFolder);
                using (StreamWriter sw = File.AppendText(targetFile))
                {
                    foreach (string line in lines)
                    {
                        string[] atrb = line.Split(',');
                        Product prod = new Product(
                            atrb[0],
                            double.Parse(atrb[1], CultureInfo.InvariantCulture),
                            int.Parse(atrb[2])
                            );
                        sw.WriteLine(prod.ToString());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
