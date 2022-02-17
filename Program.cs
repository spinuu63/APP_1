using System;
using System.Collections;
using System.Collections.Generic;
using APP_1.BinaryGap;
using APP_1.CyclinRotation;
using APP_1.FrogJmp;
using System.Linq;
using APP_1.PassingCars;
using APP_1.CountDiv;
using APP_1.OddOccurrencesInArray;
using APP_1.PermMissingElem;
using APP_1.TapeEquilibrium;
using APP_1.FrogJmp;
using APP_1.FrogRiverOne;
using APP_1.PermCheck;
using APP_1.MissingInteger;
using APP_1.MinAvgTwoSlice;
using APP_1.Distinct;
using APP_1.MaxProductOfThree;
using APP_1.Microsoft; using APP_1.NumberOfDiscIntersections; using APP_1.Brackets; using APP_1.Fish; using APP_1.Nesting;
using APP_1.StoneWall; using APP_1.Dominator;


namespace APP_1
{
    class Program
    {


        private static void Main(string[] args)
        {
            //Microsoft Problem
            // int solution = Micro_problem.sollution( 0 ,0);
            // Console.WriteLine("Raspunsul problemei este: " + solution);
            
            // Raspunsul pentru task-ul nr.1
            // int result1 = Task1.task1(1041);
            // Console.WriteLine("Raspunsul Task1: " + result1);

            // Raspunsul pentru task-ul nr.2
            //  int[]  A = {3, 8, 9, 7, 6};
            //  Console.Write("Our String is: \n");
            //  for (int i = 0 ; i < A.Length; i++) 
            //  {
            //      Console.Write(A[i] + " ");
            //  }
            //
            //  int[] result2 = Task2.solution(A, 3);
            // Console.WriteLine("Raspunsul Task2: " + result2);

            // //Raspunsul programului nr.3
            // int[] Array3 = new int[] {9, 3, 9, 3, 9, 7, 9};
            //  int result3 = Task3.findUnpairdLINQ(Array3);
            //  Console.WriteLine("Raspunsul Task3: " + result3);
            
            //Raspunsul pentru task-ul nr.4
            // int result4 = Task4.sol(10, 85, 2);
            // Console.WriteLine("Raspunsul Task4: " + result4);

            // Raspunsul programului nr.5
            // int[]  Arr5 = {2, 3, 1,4, 6};
            // Console.WriteLine("\n---------------------------------");
            // Console.WriteLine("Array-ul initial este: ");
            // for (int i = 0; i < Arr5.Length; i++)
            // {
            //     Console.Write(Arr5[i] + "\t");
            // }
            //
            // Console.WriteLine("\nArray-ul sortat este:");
            // Array.Sort(Arr5);
            // foreach (var i  in Arr5)
            // {
            //     Console.Write(i + "\t");
            // }
            // Console.WriteLine("\n---------------------------------");
            // Console.WriteLine("Raspunsul Task5: " + Task5.Solution(Arr5));

            // Raspunsul programului nr.6
            // int[] arr6 = {3, 1, 2, 4, 3};
            // int result6 = Task6.solution(arr6);
            // Console.WriteLine("Raspunsul Task6: " + result6);


            // Raspunsul programului nr.7
            // int[] arr7 = {1, 3, 1, 4, 2, 3, 5, 4};
            // Console.WriteLine("\n---------------------------------");
            // Console.WriteLine("Array-ul initial este: ");
            // for (int i = 0; i < arr7.Length; i++)
            // {
            //     Console.Write ( arr7[i] + "\t");
            // }
            // Console.WriteLine("\n---------------------------------");
            // int result7 = Task7.solution7(arr7);
            // Console.WriteLine("Raspunsul Task7: " + result7);

            // Raspunsul programului nr.8
            // int[] arr8 = {4, 1, 3, 2};
            // int result8 = Task8.Solution(arr8);
            // Console.WriteLine("Raspunsul Task8: " + result8);

            // Problema 9 nu mi-a reusit sa o realize :(
            
            //Raspunsul programului nr.10
            // int[] arr10 = {1,2,3,4,5};
            // int result10 = Task10.Solution(arr10);
            // Console.WriteLine("Raspunsul Task10: " + result10);

            // Raspunsul pentru task-ul nr.11
            // int[] arr11 = {0, 1, 0, 1, 1};
            // int result11 = Task11.solution(new[] {0, 1, 0, 1, 1});
            // Console.WriteLine("Raspunsul Task11: " + result11);

            // Raspunsul pentru task-ul nr.12 
            // int result12 = Task12.found(6, 11, 2);
            // Console.WriteLine("Raspunsul Task12: " + result12);

            // Raspunsul pentru task-ul nr.14
            // int[] arr14 = {4, 2, 2, 5, 1, 5, 8};
            // int result14 = Task14.solution14(arr14);
            // Console.WriteLine("Raspunsul Task14: " + result14);

            // Raspunsul pentru task-ul nr.15
            // int[] arr15 = {2, 1, 1, 2, 3, 1, 4,4,4,5,6,8};
            // int result15 = Task15_Artur.solution15(arr15);
            // Console.WriteLine("\nRaspunsul Task15: " + result15);
            
            // Raspunsul pentru task-ul nr.16
            // int[] arr16 = {-3, 1, 2, -2, 5, 6};
            // int result16 = Task16.solution16(arr16);
            // Console.WriteLine("Raspunsul Task16: " + result16);
            
            // Raspunsul pentru task-ul nr.18
            // int[] arr18 = {1,5,2,1,4,0};
            // int resul18 = Task18.solution18(arr18);
            // Console.WriteLine("Raspunsul Task18: " + resul18);

            // Raspunsul pentru task-ul nr.19
            // string a = "([)()]";
            // int result19 = Task19.solution19(a);
            // Console.Write("Raspunsul Task19: " + result19);          
                
            // Raspunsul pentru task-ul nr.20
            // int[] arr20a = {4,3,2,1,5};
            // int[] arr20b = {0, 1, 0, 0, 0};
            // int result20 = Task20.solution20(arr20a, arr20b);
            // Console.WriteLine("Raspunsul Task20: " + result20);
            
            // Raspunsul pentru task-ul nr.21
            // string string21 = "(()(())())";
            // int result21 = Task21.solution21(string21);
            // Console.Write("Raspunsul Task21: " + result21);
            
            // Raspunsul pentru task-ul nr.22
            // int[] arr22 = {8,8,5,7,9,8,7,4,8 };
            // int result22 = Task22.solution22(arr22);
            // Console.WriteLine("Raspunsul Task22: " + result22);
            
            // Raspunsul pentru task-ul nr.23
            int[] arr23 = {3, 4, 3, 2, 3, -1, 3, 3};
            int result23 = Task23.solution23(arr23);
            Console.WriteLine("Rezultatul pentru task23: " + result23);
        }
    }
}