using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    public class Program
    {
        public static void Main()
        {
            int[] parts = Console.ReadLine()
                 .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int pushAmount = parts[0];
            int popAmount = parts[1];
            int compareNum = parts[2];

            Queue<int> numbers = new Queue<int>();

            int[] inputNums = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Take(pushAmount)
                .Select(int.Parse)
                .ToArray();

            foreach (var inNumber in inputNums)
                numbers.Enqueue(inNumber);

            for (int i = 0; i < popAmount; i++)
                numbers.Dequeue();

            if (numbers.Contains(compareNum))
                Console.WriteLine("true");

            else if (numbers.Count > 0)
                Console.WriteLine(numbers.Min());

            else
                Console.WriteLine(0);
        }
    }
}
