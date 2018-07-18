using System;
using System.Collections.Generic;

namespace MaximumElement
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            Stack<int> maxNumbers = new Stack<int>();

            int maxNumber = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();
                string command = parts[0];

                if (command == "1")
                {
                    int numToPush = int.Parse(parts[1]);
                    if (maxNumbers.Count == 0 || numToPush >= maxNumbers.Peek())
                    {
                        maxNumbers.Push(numToPush);
                    }
                    numbers.Push(numToPush);
                }
                else if (command == "2")
                {
                    int removedNum = numbers.Pop();
                    if (removedNum == maxNumbers.Peek())
                    {
                        maxNumbers.Pop();

                        if (maxNumbers.Count > 0)
                        {
                            maxNumber = maxNumbers.Peek();
                        }
                    }
                }
                else
                {
                    Console.WriteLine(maxNumbers.Peek());
                }
            }
        }
    }
}
