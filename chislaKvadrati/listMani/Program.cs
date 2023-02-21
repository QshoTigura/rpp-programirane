using System;
using System.Collections.Generic;
using System.Linq;

namespace listMani
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string com = input[0];
                if (com =="print")
                {
                    break;
                }
                switch (com)
                {
                    case "add": var n = int.Parse(input[1]);
                        var e = int.Parse(input[2]);
                        nums.Insert(n, e);
                        break;
                    case "addMany":
                        break;
                    case "contains":
                        break;
                    case "remove":
                        break;
                    case "shift":
                        break;
                    case "sumPairs":
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(" ",nums));
        }
    }
}
