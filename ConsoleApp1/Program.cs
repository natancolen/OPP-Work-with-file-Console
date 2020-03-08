using System;
using System.Globalization;
using System.IO;
using Entities;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFilePath = @"productList.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string folderPath = @"out";
                string targetFilePath = folderPath + "/summary.txt";

                Directory.CreateDirectory(folderPath);

                using (StreamWriter sw = new StreamWriter(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] split = line.Split(',');

                        string name = split[0];
                        double price = double.Parse(split[1]);
                        int amount = int.Parse(split[2]);

                        Product p = new Product(name, price, amount);

                        Console.WriteLine(p.name + ", " + p.TotalCost().ToString("F2", CultureInfo.InvariantCulture));
                        sw.WriteLine(p.name + ", " + p.TotalCost().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
                Console.ReadKey();
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e);
            }
        }
    }
}
