using System;

namespace LargestPrimeFactor
{
    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            const double test = 600851475143;

            //long number = (long)test;
            //long x;
            //for (x = 1; x <= number; x++)
            //    if (number % x == 0)
            //        number = number / x;

            //Console.WriteLine(--x);

            if (IsPrime((ulong)test))
            {
                Console.WriteLine(test);
                return;
            }
            for (var i = 2; i < test / 2; i++)
            {
                var divided = test/i;
                if (divided != (ulong)divided) continue;
                if (!IsPrime((ulong)divided)) continue;

                Console.WriteLine(divided);
                Console.ReadKey();
                return;
            }
        }

        //static IEnumerable<int> PrimeCache()
        //{
        //    yield return 2;
        //    for (var i = 3;; i +=2)
        //    {
        //        if (IsPrime(i)) yield return i;
        //    }
        //}

        private static bool IsPrime(ulong candidate)
        {
            // Check if candidate is even
            if ((candidate & 1) == 0)
            {
                return candidate == 2;
            }

            for (ulong i = 3; (i * i) < candidate; i += 2)
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
