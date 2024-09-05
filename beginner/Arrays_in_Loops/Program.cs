﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_in_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(  "**************************************************************************" +
                                "  Loop  "  +
                                "**************************************************************************");

            int[ ] a = new int[10];
            for (int k = 0; k < 10; k++) {
                a[k] = k*2;
            }
            for (int k = 0; k < 10; k++) {
                Console.WriteLine(a[k]);
            }

            Console.WriteLine(  "**************************************************************************" +
                                "  Foreach-Loop  "  +
                                "**************************************************************************");

            int[ ] aa = new int[10];
            for (int k = 0; k < 10; k++) {
                aa[k] = k*2;
            }
            foreach (int k in aa) {
                Console.WriteLine(k);
            }

            Console.WriteLine(  "**************************************************************************" +
                                "  Addition Loop  "  +
                                "**************************************************************************");


            int[ ] arr = {11, 35, 62, 555, 989};
            int sum = 0; 
            
            foreach (int x in arr) {
                sum += x;
            }
            Console.WriteLine(sum);
        }
    }
}