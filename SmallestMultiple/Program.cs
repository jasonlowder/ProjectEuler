using System;
using System.Diagnostics;

namespace SmallestMultiple
{
    /// <summary>
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    class Program
    {
        private static int upper = 20;

        static void Main(string[] args)
        {
            var watch = Stopwatch.StartNew();
            for (var i = upper; ; i += upper)
            {
                if (!IsDivisibleByAll(i)) continue;

                watch.Stop();
                Console.WriteLine($"{i} found in {watch.ElapsedMilliseconds} ms");
                Console.ReadKey();
                return;
            }
        }

        private static bool IsDivisibleByAll(int x)
        {
            for (var i = upper; i > 1; i--)
            {
                if (x%i == 0) continue;

                return false;
            }
            return true;
        }
    }
}
