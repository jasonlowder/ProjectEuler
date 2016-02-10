using System;
using System.Collections.Generic;
using System.Linq;

namespace PythagoreanTriplet
{
    class Program
    {
        static void Main(string[] args)
        {
            var triplets = PythagoreanTriplets();
            //var triplet = triplets.Where(x => {var sum = x.A + x.B + x.C;
            //                                    return sum >= 999 && sum <= 1001;
            //});

            var triplet = triplets.Where(x => x.Sum >= 999.99999999 && x.Sum <= 1000.00000001);
            //Console.WriteLine(triplet.A * triplet.B * triplet.C);
            Console.ReadKey();
        }

        static double PythagoreanTherem(double a, double b)
        {
            return Math.Sqrt(Math.Pow(a, 2.0) + Math.Pow(b, 2.0));
        }

        static IEnumerable<PythagoreanTriplet> PythagoreanTriplets()
        {
            const int a = 3;
            const int b = 4;
            const int c = 5;
            const double incrementer = .000000001;
            for (double i = 83.4999999; i <=83.511111; i += incrementer)
            {
                yield return new PythagoreanTriplet {A = a*i, B = b*i, C = c*i};
            }
        }

        class PythagoreanTriplet
        {
            public double A { get; set; }
            public double B { get; set; }
            public double C { get; set; }
            public double Sum => A + B + C;
        }
    }
}
