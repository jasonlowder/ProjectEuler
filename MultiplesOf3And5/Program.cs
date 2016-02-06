using System;

namespace MultiplesOf3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            var upper = 1000 - 1;
            var factor = new[] {3, 5, 15};
            var three = Summation(1, upper/factor[0])*factor[0];
            var five = Summation(1, upper/factor[1])*factor[1];
            var fifteen = Summation(1, upper/factor[2])*factor[2];
            Console.WriteLine(three + five - fifteen);
            Console.ReadKey();
        }

        static int Summation(int lower, int upper)
        {
            if (lower > 1)
            {
                return (Summation(1, upper) - Summation(1, lower - 1));
            }
            return ((upper * (upper + 1)) / 2);
        }

        //int max = 1000;
        //Func<int, int> sum = n => { var k = (max - 1) / n; return n * k * (k + 1) / 2; };
        //var result = sum(3) + sum(5) - sum(15);

        //Func<int, int> triangle = n => n * (n + 1) / 2;
        //Func<int, int, int> sumOfMultiples = (n, bound) => n * triangle(bound / n);
        //return sumOfMultiples(3, 999) + sumOfMultiples(5, 999) - sumOfMultiples(3 * 5, 999);
    }
}
