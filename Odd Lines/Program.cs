using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input/input.txt");
            for (int i = 0; i < input.Length; i++)
            {
                if (i%2==1)
                {
                    File.AppendAllText("output/output.txt", input[i].ToString()+Environment.NewLine);
                }
            }
        }
    }
}
