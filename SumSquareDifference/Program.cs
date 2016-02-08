using System;
using System.Diagnostics;

namespace SumSquareDifference
{
    /// <summary>
    /// The sum of the squares of the first ten natural numbers is,
    /// 1^2 + 2^2 + ... + 10^2 = 385
    /// The square of the sum of the first ten natural numbers is,
    /// (1 + 2 + ... + 10)^2 = 55^2 = 3025
    /// Hence the difference between the sum of the squares of the first ten natural
    /// numbers and the square of the sum is 3025 − 385 = 2640.
    /// Find the difference between the sum of the squares of the first one hundred
    /// natural numbers and the square of the sum.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            const int upper = 100;
            var watch = Stopwatch.StartNew();
            //var answer = SquareOfSum(upper) - SumOfSquares(upper);
            long sum = 0;
            long square = 0;
            for (var i = 1; i <= upper; i++)
            {
                sum += i;
                square += (i * i);
            }
            var answer = (sum * sum) - square;
            watch.Stop();
            Console.WriteLine($"{answer} found in {watch.ElapsedMilliseconds} ms");
            Console.ReadKey();
        }

        static long SumOfSquares(int upper)
        {
            long sum = 0;
            for (var i = 1; i <= upper; i++)
            {
                sum += (i*i);
            }
            return sum;
        }

        static long SquareOfSum(int upper)
        {
            long sum = 0;
            for (var i = 1; i <= upper; i++)
            {
                sum += i;
            }
            return (sum * sum);
        }
    }
}
