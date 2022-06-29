using System;
using System.IO;

namespace FileDirOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo myDir = new DirectoryInfo(@"C:\Users\boazb\Desktop\Ma-School\Bewijzend\Periode 4\F2M4GD\BELANGERIJK!!!\");
            /*DirectoryInfo parent = myDir.Parent;*/

            foreach (FileInfo fi in myDir.GetFiles())
            {
                Console.WriteLine(fi.Name);
            }
        }
    }
}