namespace Tupel02;

using System;
using System.Collections.Generic;
using System.Linq;



    [Run(1)]
    public class Zip
    {
        public Zip()
        {
//            IEnumerable<int> s = new[] {1, 5, 7, 13};
//            IEnumerable<Tuple<int, int>> zipped =
//                s.Zip(s.Skip(1), Tuple.Create);
//            foreach (Tuple<int, int> t in zipped)
//                Console.WriteLine($"{t.Item1}, {t.Item2}");

            IEnumerable<int> s = new[] { 1, 5, 7, 13 };
            IEnumerable<(int num1, int num2)> zipped = s.Zip(s.Skip(1),
                (num1, num2) => (num1, num2));
            foreach ((int num1, int num2) t in zipped)
            {
                Console.WriteLine($"{t.num1}, {t.num2}");

                ValueTuple<int, int> t2 = t;
                Tuple<int, int> t3 = t.ToTuple();
                (int num1, int num2) t4 = t3.ToValueTuple();
                (int num1, int num2) = t3.ToValueTuple();
                (num2, num1) = (num1, num2);
                Console.WriteLine($"{num1}, {num2}");

                (int num3, _) = t;
                (_, _) = t;
            }
        }
    }
