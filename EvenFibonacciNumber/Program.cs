﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenFibonacciNumber
{
    /// <summary>
    /// Each new term in the Fibonacci sequence is generated by adding the previous two terms.
    /// By starting with 1 and 2, the first 10 terms will be:
    /// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
    /// By considering the terms in the Fibonacci sequence whose values do not exceed four million,
    /// find the sum of the even-valued terms.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFibonacciSequence(4000000).Sum(i => i%2 == 0 ? i : 0));
            Console.WriteLine(FibonacciSequence(0,1).TakeWhile(i => i <= 4000000).Sum(i => i % 2 == 0 ? i : 0));
            Console.WriteLine(GetFibonacciSequence(4000000).Sum(i => (i & 1) == 0 ? i : 0));
            Console.WriteLine(FibonacciSequence(0, 1).TakeWhile(i => i <= 4000000).Sum(i => (i & 1) == 0 ? i : 0));
            Console.WriteLine(Fib3().TakeWhile(i => i <= 4000000).Sum());
            Console.ReadKey();
        }

        static List<int> GetFibonacciSequence(int max)
        {
            var sequence = new List<int> {0,1};
            for (var i = 2; sequence[i - 2] + sequence[i - 1] < max; i++)
            {
                sequence.Add(sequence[i - 2] + sequence[i - 1]);
            }
            return sequence;
        }

        static IEnumerable<int> FibonacciSequence(int a, int b)
        {
            for (;;)
            {
                var c = a + b;
                a = b;
                b = c;
                yield return c;
            }
        }

        static IEnumerable<int> Fib3()
        {
            for (int a = 2, b = 0; ;)
            {
                yield return a += b << 2;
                yield return b += a << 2;
            }
        }
    }
}
