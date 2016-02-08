using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _10001stPrime
{
    /// <summary>
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13,
    /// we can see that the 6th prime is 13.
    /// What is the 10 001st prime number?
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            const int depth = 10001;
            var watch = Stopwatch.StartNew();
            var cache = PrimeCache().Take(depth);
            var answer = cache.Last();
            Console.WriteLine($"{answer} found in {watch.ElapsedMilliseconds} ms");
            Console.ReadKey();
        }

        static IEnumerable<ulong> PrimeCache()
        {
            yield return 2;
            for (ulong i = 3; ; i += 2)
            {
                if (IsPrime(i)) yield return i;
            }
        }

        private static bool IsPrime(ulong candidate)
        {
            // Check if candidate is even
            if ((candidate & 1) == 0)
            {
                return candidate == 2;
            }

            for (ulong i = 3; (i * i) <= candidate; i += 2)
            {
                if (candidate % i == 0)
                {
                    return false;
                }
            }

            return candidate != 1;
        }
    }
}
