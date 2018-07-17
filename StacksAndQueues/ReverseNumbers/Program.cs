using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseNumbers
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> reversedNumbers = new Stack<int>();

            foreach (var number in numbers)
            {
                reversedNumbers.Push(number);
            }

            Console.WriteLine(String.Join(" ", reversedNumbers));
        }
    }
}
