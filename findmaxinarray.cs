using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Arrayprog
{
    public class findmaxinarray
    {
        public static void maxarray()
        {
            Console.WriteLine("Find max in Array");

            Console.WriteLine("Enter Array Size:");
            int Length = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[Length];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter Array Elements :");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
           
            int max =  a[0];
            for(int i = 1;i < a.Length; i++)
            {
               if(max < a[i])
                {
                    max = a[i];
                }
            }
            Console.WriteLine("Greater Number is :" + max);

        }
    }
}
