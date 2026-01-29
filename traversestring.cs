using System;
using System.Collections.Generic;
using System.Text;

namespace Arrayprog
{
    internal class traversestring
    {
        public static void trastring()
        {
            Console.WriteLine("Traverse of string ");

            Console.WriteLine("Enter Charcters:");
            string a = Console.ReadLine();
            string b = "";
            for(int j=a.Length-1;j >= 0 ; j--)
            {
                b = b + a[j];
            }
            
            if( a == b)
            {
                Console.WriteLine("Given String is Palindrom");
            }
            else
            {
                Console.WriteLine("Given string is not Palindrom");
            }
        }
    }
}
