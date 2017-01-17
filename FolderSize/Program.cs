using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo("TestFolder");
            FileInfo[] files = di.GetFiles();
            var sum = 0d;
            foreach (var file in files)
            {
                sum += file.Length;
            }
            File.WriteAllText("output/output.txt", (sum / 1024 / 1024).ToString());
        }
    }
}