using System;

namespace APP_1.NumberOfDiscIntersections
{
    public class Task18
    {
        public static int solution18(int[] A)
        {
            int len = A.Length;
            int index = 0;
            
            Console.Write("Array-ul initial este: \n");
            for (int i = 0; i < len; i++)
            {
                Console.Write(A[i] + "\t");
                long a = (long) i + A[i];
                for (int j = 0; j < len; j++)
                {
                    long b = (long) j + A[j];

                    if (a > b)
                    {
                        index++;
                    }

                    if (a > 10000000)
                    {
                        return -1;
                    }
                }
            }
            
            return index;
        }
    }
}