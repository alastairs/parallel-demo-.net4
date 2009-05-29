using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ParallelQuickSort.UI
{
    class Program
    {
        private static ParallelQuickSort quickSort = new ParallelQuickSort();
        static void Main(string[] args)
        {
            const int MaxValue = 10000;
            Console.WriteLine("Generating {0} random numbers...", MaxValue);
            Parallel.For(0, MaxValue - 1, delegate(int i)
            {
                int num = new Random(i).Next();
                quickSort.Numbers.Add(num);
                Console.Write("{0}, ", num);
            });

            Console.WriteLine("\n");
            Console.WriteLine("Sorting numbers via parallel quick sort...");
            quickSort.Sort();

            foreach (int i in quickSort.Numbers)
            {
                Console.Write(string.Format("{0}, ", i));
            }

            Console.WriteLine("\n");

            Console.Write("Hit any key to exit...");
            
            Console.ReadLine();
        }
    }
}
