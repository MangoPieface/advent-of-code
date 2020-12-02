using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = System.IO.File.ReadAllLines(@"/Users/708506/projects/advent-of-code/day 1/input.txt");

            var isBullseye = false;
            foreach (string line in text)
            {
                int numberInList1 = int.Parse(line);
                foreach (string line2 in text.Skip(1)) 
                {
                    int numberInList2 = int.Parse(line2);
   
                    if (numberInList1 + numberInList2 == 2020)
                    {
                        Console.WriteLine(numberInList1 + " " + numberInList2 + " gotcha");
                        isBullseye = true;
                        break;
                    }
                }
                if (isBullseye){
                    break;
                }
            }
          
            Console.ReadLine();
        }
    }
}
