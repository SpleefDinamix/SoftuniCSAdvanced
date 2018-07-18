using System;
using System.Collections.Generic;

namespace CalculateSequenceWithQueue
{
    public class Program
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            Queue<long> sequence = new Queue<long>();
            sequence.Enqueue(n);

            long currentWorkable = n;

            for (int i = 0; i < 16; i++)
            {
                sequence.Enqueue(currentWorkable + 1);
                sequence.Enqueue(2 * currentWorkable + 1);
                sequence.Enqueue(currentWorkable + 2);

                Console.Write(sequence.Dequeue() + " ");
                currentWorkable = sequence.Peek();
            }
            sequence.Enqueue(currentWorkable + 1);

            Console.WriteLine(String.Join(" ", sequence));
        }
    }
}
