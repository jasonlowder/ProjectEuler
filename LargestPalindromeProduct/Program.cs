using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestPalindromeProduct
{
    /// <summary>
    /// A palindromic number reads the same both ways.
    /// The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Palindromes(100,999).Max());
            Console.ReadKey();
        }

        static IEnumerable<int> Palindromes(int lower, int upper)
        {
            for (var i = lower; i <= upper; i++)
            {
                for (var j = lower; j <= upper; j++)
                {
                    var product = i*j;
                    if (IsPalidrome(product))
                    {
                        yield return (product);
                    }
                }
            }
        }

        static bool IsPalidrome(int candidant)
        {
            return candidant == int.Parse(new string(candidant.ToString().Reverse().ToArray()));
        }
    }
}
