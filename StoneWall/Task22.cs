using System;
using System.Collections.Generic;

namespace APP_1.StoneWall
{
    public class Task22
    {
        public static int solution22(int[] H)
        {
            var index = 0;
            var name22 = new Stack<int>();

            for (int i = 0, len = H.Length; i < len; i++)
            {
                var height = H[i];
                Console.Write("Inaltimea este: " + height);
                var block = 0;

                while (name22.Count > 0)
                {
                    block = name22.Peek();
                    Console.WriteLine("Block este: " + block);
                    if (block > height)
                    {
                        name22.Pop();
                    }
                    else
                    {
                        break;
                    }
                }

                if (block != height)
                {
                    name22.Push(height);
                    index++;
                }
            }

            return index;
        }
    }
}