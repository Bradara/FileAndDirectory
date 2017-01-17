using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText("input/words.txt").Split();
            string[] input = File.ReadAllText("input/text.txt").ToLower().Split(new char[] { ' ', '-', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (var word in words)
            {
                result[word] = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (word == input[i])
                    {
                        result[word]++;
                    }
                }
            }
            foreach (var item in result.OrderBy(n => -n.Value))
            {
                var output = String.Format("{0} - {1}", item.Key, item.Value + Environment.NewLine);
                File.AppendAllText("output/output.txt", output);
            }
        }
    }
}
