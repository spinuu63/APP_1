using System.Collections.Generic;
using System.Linq;
using System;

namespace APP_1.Nesting
{
    public class Task21
    {
        public static int solution21(string S)
        {
            var map = new Dictionary<char, char>()
            {
                {')', '('},
                {']', '['},
                {'{', '}'}
            };
            int index = 0;

            var stack = new Stack<char>();

            for (var i = 0; i < S.Length; i++)
            {
                var character = S[i];
                if (!(character == ')' || character == '(' || character == '[' || character == ']' ||
                      character == '{' || character == '}'))
                    continue;

                if (!map.ContainsKey(S[i]))
                {
                    stack.Push(S[i]);
                    index = 1;
                }
                else if (stack.Count != 0 && map[S[i]] == stack.Last())
                {
                    stack.Pop();
                }
                else
                {
                    index = 0;
                }

                if (stack.Count > S.Length / 2)
                    index = 0;
            }

            return index;
        }
    }
}