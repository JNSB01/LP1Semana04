using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int Result = Fibonacci(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(Result);
        }

        private static int Fibonacci(int n)
        {
            if (n == 2 | n == 1)
            {
                return 1;
            }

            return Fibonacci(n-1) + Fibonacci(n-2);
        }
    }
}
