using System;
using System.Linq;

namespace APP_1.MissingInteger
{
    public class Task10
    {
        public static int Solution(int[] A)
        {
            
            int z;
            z = A.Length;
            double m, n = 0;
            Console.WriteLine("\n---------------------------------");
            Console.WriteLine("Numarul de elemnte este " + A.Max()); 
            m = A.Max();
            Console.WriteLine("Valoarea maxim este: " + m);
            do
            {
                n++;
            } while (n < m);
            
            if (n == m)
            {
                n = n + 1;
            }
            Console.WriteLine("---------------------------------");
            return (int) n;
        }
    }
}