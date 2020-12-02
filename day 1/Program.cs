using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = System.IO.File.ReadAllLines(@"/Users/708506/projects/advent-of-code/day 1/input.txt");

            
            int counterLoop2 = 0;
            foreach (string line in text)
            {
                int x = Int32.Parse(line);
                foreach (string line2 in text) 
                {
                    int y = Int32.Parse(line2);
                    if (counterLoop2 == 0)
                    {
                        counterLoop2++;
                        continue;
                    }

                    if (y + x == 2020)
                    {
                        Console.WriteLine(x + " " + y + " gotcha");
                        break;
                    }
                }
            }
          
            Console.ReadLine();
        }
    }
}
