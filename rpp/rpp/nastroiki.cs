﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rpp
{
    public static class nastroiki
    {
        public static int CountLess100(int[] arr)
        {
            return arr.Count(x => x < 100);
        }
        public static int MaxNum(int[] arr)
        {
            return arr.Max();
        }
        public static int[] ReverseArr(int[] arr)
        {
            return arr.Reverse().ToArray();
        }
        public static void ChetniChisla (int[] arr)
        {
            var result = arr.Where(x => x % 2 == 0).ToArray();
            Console.WriteLine(string.Join(", ",result));
        }
        public static int SumaNaChetniChisla(int[] arr)
        {
            return arr.Where(x => x % 2 == 0).Sum();
        }
        public static int BroiChetniChisla(int[] arr)
        {
            return arr.Where(x => x % 2 == 0).Count();
        }
        public static void PrintArr(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
    
