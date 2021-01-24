using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjectEuler.Solutions.Q022
{
    class Q022
    {
        static void Main(string[] args)
        {
            int line = 0;
            int sum = 0;
            string path = @"D:\bktmzrak\Projects\GithubProjects\ProjectEuler\Solutions\Q022\p022_names.txt";
            String[] lines = File.ReadAllLines(path);
            String[] parsedNames = lines[0].Split(',');

            for (int i = 0; i < parsedNames.Length; i++)
            {
                parsedNames[i] = parsedNames[i].Trim(new Char[] {'"'});                              
            }

            IEnumerable<string> query = from word in parsedNames
                                        orderby word.Substring(0, word.Length)
                                        select word;
            
            foreach (var item in query)
            {
                line++;
                int asciiValue = 0;

                for (int i = 0; i < item.Length; i++)
                {
                    asciiValue += item[i] - 64;
                }

                sum += line * asciiValue;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}

