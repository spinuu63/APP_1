using System;
using System.Linq;
using APP_1.BinaryGap;
using APP_1.CyclinRotation;
using APP_1.FrogJmp;
using System.Linq;
using APP_1.PassingCars;
using APP_1.CountDiv;

//using APP_1.BinaryGap;

namespace APP_1
{
    class Program
    {
        

        private static void Main(string[] args)
        {
            //Raspunsul pentru task-ul nr.1
            int result1 = Task1.task1(1041);
            Console.WriteLine(result1);

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
            // int result4 = Task4.sol(10, 85, 2);
            // Console.WriteLine(result4);

            // Raspunsul programului nr.5
            // int[]  Arr = {2, 3, 1,4, 6};
            // for (int i = 0; i < Arr.Length; i++)
            // {
            //     Console.Write(Arr[i] + "\t");
            // }
            //
            // Console.WriteLine();
            // Array.Sort(Arr);
            // foreach (var i  in Arr)
            // {
            //     Console.Write(i + "\t");
            // }
            //
            // Console.WriteLine("\n\n" + "The missing digit in this string is:\n " + Solution(Arr));
            // }
            //
            // public static int Solution(int[] Arr)
            // {
            //     return (int)((Arr.Length == 0) ? 1 : ((long)(Arr.Length + 1) * (Arr.Length + 2) / 2) - Arr.Sum(x => (long)x));

            // Raspunsul programului nr.7
            // int n = 5, index = 0;
            // int[] arr7 = {1, 3, 1, 4, 2, 3, 5, 3};
            // for (int i = 0; i < arr7.Length; i++)
            // {
            //     Console.Write ( arr7[i] + "\t");
            //     if (arr7[i] == n)
            //     {
            //         index++;
            //     }
            // }
            // int t = 0;
            // do
            // {
            //     t++;
            // } while (arr7[t] < n);
            // Console.WriteLine(t);

            // Raspunsul programului nr.10
            // int[] poka = {1,2,3,4,5};
            // int z;
            // z = poka.Length;
            // Console.WriteLine( "Lungimea siru;ui este:" + z);
            // double m, n = 0;
            // Console.WriteLine(poka.Max()); // returns the largest value
            // m = poka.Max();
            // Console.WriteLine("Numarul maxim este: " + m);
            // do
            // {
            //     n++;
            // } while (n < m);
            //
            // if (n == m)
            // {
            //     n = n + 1;
            // }
            //
            // Console.WriteLine("Numarul final este: " + n);

            // Raspunsul pentru task-ul nr.11
            // int result11 = Task11.solution(new[] {0, 1, 0, 1, 1});
            // Console.WriteLine("Raspunsul task-ului 11 este: " + result11);

            int result12 = Task12.found(6, 11, 2);
            Console.WriteLine("Raspunsul task-ului 12 este: " + result12);

        }
    
    }
}