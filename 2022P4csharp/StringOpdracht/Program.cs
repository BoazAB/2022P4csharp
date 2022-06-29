using System;
using System.IO;

namespace StringOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string read = File.ReadAllText(@"C:\Users\boazb\Desktop\Ma-School\Bewijzend\Periode 4\F2M4GD\2022P4csharp\2022P4csharp\StringOpdracht\stringsplit.txt");
            
            string[] value = read.Split(':',',');

            string[] thing = value;

            foreach (string ln in value)
            {
                Console.WriteLine(ln);
            }
        }
    }
}
