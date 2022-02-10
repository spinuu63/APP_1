using System;

namespace APP_1.CountDiv
{
    public class Task12
    {
        public static int found(int A, int B, int K)
        {
            // int Index;
            // Index = A;
            // Index = Index - 1;
            // do
            // {
            //     Index++;
            //     Console.Write(Index + "\t");
            // } while (Index < B);
            //
            //
            // Console.WriteLine("\nValoarea lui K este: " + K);
            // return K;

            return B / K - (A / K) + (A % K == 0 ? 1 : 0);
        }
    }
}