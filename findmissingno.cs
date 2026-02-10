using System;
using System.Collections.Generic;
using System.Text;

namespace Arrayprog
{
    internal class findmissingno
    {
        public static void missno()
        {
            Console.WriteLine("Program for Find Missing number in series");
            Console.WriteLine("Enter Array size:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Array Elements:");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);

                sum = sum + a[i];

            }
            int total = n * (n + 1) / 2;
            int missing = total - sum;

            Console.WriteLine("Missing Number is :" + missing);
        }
    }
}
