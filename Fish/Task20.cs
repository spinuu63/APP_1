using System;
using System.Linq;

namespace APP_1.Fish
{
    public class Task20
    {
        public static int solution20(int[] A, int[] B)
        {
            int len = A.Length;
            Console.WriteLine("\n");
            int con, end;
            con = end = 0;
            
            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] == 1)
                {
                    con++;
                    end = 1;
                }
            }
            Console.WriteLine("\n");
            int a = A.Max();
            for (int i = con; i < len; i++)
            {
                Array.Sort(A);
            }
            Console.WriteLine("\n");
            if (a > A[con])
            {
                end = end + 1;
            }
            return end;
        }
    }
}