using System;

namespace Fibonacci_series
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStop = 10, sum, preSum = 1, prepre = 0;
            Console.WriteLine();
            Console.Write($"{prepre} + {preSum} + ");
            for (int i = 2; i < numStop; i++)
            {
                sum = prepre + preSum;
                Console.Write(sum);
                prepre = preSum;
                preSum = sum;
                if (i < numStop-1) Console.Write(" + ");
            }
            Console.WriteLine();
        }
    }
}
