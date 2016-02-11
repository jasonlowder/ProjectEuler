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

            var triplet = triplets.First(x => x.Sum == 1000); // 200, 375, 425
            Console.WriteLine(triplet.A * triplet.B * triplet.C);
            Console.ReadKey();
        }

        static bool IsPythagoreanTherem(double a, double b, double c)
        {
            return (Math.Pow(a, 2.0) + Math.Pow(b, 2.0)) == Math.Pow(c, 2.0);
        }

        static IEnumerable<PythagoreanTriplet> PythagoreanTriplets()
        {
            var list = new List<PythagoreanTriplet>();
            for (var x = 1; x < 500; x++)
            {
                for(var y = 1; y < 500; y++)
                {
                    for(var z = 1; z < 500; z++)
                    {
                        if (IsPythagoreanTherem(x, y, z))
                        {
                            var triplet = new PythagoreanTriplet { A = x, B = y, C = z };
                            list.Add(triplet);
                            yield return triplet;
                        }
                    }
                }
            }
        }

        class PythagoreanTriplet
        {
            public double A { get; set; }
            public double B { get; set; }
            public double C { get; set; }
            public double Sum { get { return A + B + C; } }
        }
    }
}
//Without programming:

//a= 2mn; b= m^2 -n^2; c= m^2 + n^2;
//a + b + c = 1000;

//2mn + (m^2 -n^2) + (m^2 + n^2) = 1000;
//2mn + 2m^2 = 1000;
//2m(m+n) = 1000;
//m(m+n) = 500;

//m>n;

//m= 20; n= 5;

//a= 200; b= 375; c= 425;

//It can be shown easily (or easily found on the internet if you're lazy) that all Prime Pythagorean triples using two naturals numbers can be written as:
//a=2mn
//b=m^2−n^2
//c=m^2+n^2

//The constraint:

//a+b+c=1000

//thus become

//2mn+2m^2=1000

//2m∗(n+m)=1000

//n=(500/m)−m

//We know that m>n since has b has to be positive, so by solving when (n=m) we find:

//m>16>Math.Sqrt(250)

//We also know m>0, so solving for (n=0) we find:

//m<Math.Sqrt(500)<23

//Finally, we also know (500/m) has to be an integer, so m is the product of any or all of (2,2,5,5,5). 

//The only possible product between 16 and 23 is thus 2∗2∗5=20, so m=20
//n=500/20−20=5

//a=5∗20∗2=200
//b=202−52=375
//c=202+52=425

//a+b+c=1000
//a∗b∗c=31875000