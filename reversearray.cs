using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Arrayprog
{
    public class reversearray
    {
        public static void revarray()
        {
            Console.WriteLine("Reverse Of Array:");

            Console.WriteLine("Enter Array Size:");
            int Length = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[Length];
            for(int i=0; i< a.Length;i++)
            {
                Console.WriteLine("Enter Array Elements :");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int temp = 0;
            int j = a.Length - 1;

            for (int i = 0; i < j; i++, j--)
            {
                temp = a[i];
                a[i] = a[j];
                a[j] = temp;
            }
            
            for(int i =0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            
        }
    }
}
