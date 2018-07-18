using System;
using System.Collections.Generic;

namespace BalancedParentheses
{
    public class Program
    {
        public static void Main()
        {
            string sequence = Console.ReadLine();
            Stack<char> paired = new Stack<char>();

            bool isOneChar = sequence.Length <= 1;
            string answer = "NO";

            if (isOneChar)
            {
                Console.WriteLine(answer);
                return;
            }

            foreach (char chr in sequence)
            {
                switch (chr)
                {
                    case '(':
                        paired.Push(')');
                        break;
                    case '[':
                        paired.Push(']');
                        break;
                    case '{':
                        paired.Push('}');
                        break;
                    default:
                        bool pairNotMissing = paired.Count > 0;
                        bool areWithEqualLenghts = paired.Count <= sequence.Length / 2;

                        if (pairNotMissing && areWithEqualLenghts)
                        {
                            if (chr == paired.Pop())
                            {
                                answer = "YES";
                            }
                        }
                        else
                        {
                            answer = "NO";
                        }
                        break;
                }
            }
            Console.WriteLine(answer);
        }
    }
}
