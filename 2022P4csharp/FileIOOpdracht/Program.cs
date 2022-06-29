using System;
using System.IO;

namespace FileIOOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] file = File.ReadAllLines(@"C:\Users\boazb\Desktop\Ma-School\Bewijzend\Periode 4\F2M4GD\2022P4csharp\2022P4csharp\FileIOOpdracht\improf.txt");

            foreach(string ln in file)
            {
                Console.WriteLine(ln);
            }

        }
    }
}
