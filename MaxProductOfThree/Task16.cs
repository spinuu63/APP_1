using System;
using System.Linq;

namespace APP_1.MaxProductOfThree
{
    public class Task16
    {
        public static int solution16(int[] A)
        {
            // int len = A.Length,v1,v2,v3;
            // v1 = v2 = v3 = 0;
            // int[] B = {0, 0, 0};
            // for (int i = 0; i < len; i++)
            // {
            //     v1 = A[0] * A[1] * A[2];
            //     v2 = A[1] * A[2] * A[4];
            //     v3 = A[2] * A[4] * A[5];
            //
            // }
            // Console.WriteLine("Rezultatul valori1: " + v1);
            // Console.WriteLine("Rezultatul valori2: " + v2);
            // Console.WriteLine("Rezultatul valori3: " + v3);
            //
            // B[0] = v1;
            // B[1] = v2;
            // B[2] = v3;
            // int raspuns = B.Max();
            //
            // return raspuns;
            Array.Sort(A);
            Console.WriteLine("Acesta este array-ul sortat: ");
            for (int i = 0; i < A.Length; i++)
            {
               Console.Write(A[i] + "\t");
            }
            int z = A.Length;
            int k = A[z - 1] * A[z - 2] * A[z - 3];
            int j = A[0] * A[1] * A[z - 1];
            Console.WriteLine("\nRezultatul z:" + z);
            Console.WriteLine("Rezultatul k:" + k);
            Console.WriteLine("Rezultatul j:" + j);

            return k > j ? k : j;
        }
    }
}