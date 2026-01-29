using System;
using System.Collections.Generic;
using System.Text;

namespace Arrayprog
{
    public class traversearray
    {
        public static void trarray()
        {
            Console.WriteLine("Teraverse Of Array");

            Console.WriteLine("Enter array size:");
            int Length = Convert.ToInt32(Console.ReadLine());
            
            int[] a = new int[Length];
            for( int i=0; i<a.Length ; i++)
            {
                Console.WriteLine("Enter Array Elements :");
                a[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            
            for ( int  i=0; i<a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        
        }
    }
}
