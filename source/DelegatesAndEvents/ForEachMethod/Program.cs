using System;
using System.Collections.Generic;

namespace ForEachMethod
{
    class Program
    {
        public delegate void IntAction(int value);

        static void Main(string[] args)
        {
            int[] array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            IntAction action = Console.WriteLine;

            int sum = 0;
            action += n => sum += n;

            ForEach(array, action);

            Console.WriteLine($"Sum: {sum}");
        }

        public static void ForEach(IEnumerable<int> values, IntAction action)
        {
            foreach (int value in values)
            {
                action.Invoke(value);
            }
        }
    }
}
