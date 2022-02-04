using System;
using System.Linq;
using APP_1.BinaryGap;
using APP_1.CyclinRotation;
using APP_1.FrogJmp;

//using APP_1.BinaryGap;

namespace APP_1
{
    class Program
    {
        
        private static  void Main(string[] args)
        {
            // Raspunsul pentru task-ul nr.1
            // int result1 = Task1.task1(1041);
            // Console.WriteLine(result1);

            // Raspunsul pentru task-ul nr.2
            //  int[]  A = {3, 8, 9, 7, 6};
           //  // int k = 3;
           //
           //  Console.Write("Our String is: \n");
           //  for (int i = 0 ; i < A.Length; i++) 
           //  {
           //      Console.Write(A[i] + " ");
           //  }
           //
           //  int[] result2 = Task2.solution(A, 3);
           // Console.WriteLine(result2);
           
           // Raspunsul programului nr.3
        //    int[] pairsArray = new int[] {9, 3, 9, 3, 9, 7, 9};
        //    int resultunpaired = findUnpairdLINQ(pairsArray);
        //    Console.WriteLine(resultunpaired);
        //    Console.Read();
        // }
        //
        //
        // private static int findUnpairdLINQ(int[] pairsArray)
        // {
        //     return pairsArray.Aggregate(0, (prev, next) => prev ^= next);
        // }
        //
        // private static int findUnpired(int[] pairsArray)
        // {
        //     int unapairednumber = 0;
        //
        //     for (int i = 0; i < pairsArray.Length; i++)
        //     {
        //         unapairednumber ^= pairsArray[i];
        //     }
        //
        //     return unapairednumber;

        // Raspunsul pentru task-ul nr.4
        int result4 = Task4.sol(10, 85, 2);
        Console.WriteLine(result4);
        }
    }
}