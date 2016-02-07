using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenFibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFibonacciSequence(4000000).Sum(i => i%2 == 0 ? i : 0));
            Console.WriteLine(FibonacciSequence(0,1).TakeWhile(i => i <= 4000000).Sum(i => i % 2 == 0 ? i : 0));
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
