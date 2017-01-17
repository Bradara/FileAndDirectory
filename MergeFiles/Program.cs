using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = File.ReadAllLines("input/FileOne.txt");
            string[] input2 = File.ReadAllLines("input/FileTwo.txt");
            for (int i = 0; i < input1.Length; i++)
            {
                File.AppendAllText("output/output.txt", String.Format(input1[i] + Environment.NewLine + input2[i]+Environment.NewLine));
            }
        }

    }
}
