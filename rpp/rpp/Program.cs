using System;

namespace rpp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0;i<n;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(nastroiki.CountLess100(arr));
            Console.WriteLine(nastroiki.MaxNum(arr));
            arr = nastroiki.ReverseArr(arr);
            nastroiki.ChetniChisla(arr);
            Console.WriteLine(nastroiki.BroiChetniChisla(arr));
            Console.WriteLine(nastroiki.SumaNaChetniChisla(arr));
            nastroiki.PrintArr(arr);

        }
    }
}
