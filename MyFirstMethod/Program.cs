using System;

namespace MyFirstMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux = Console.ReadLine();
            int nCount = Convert.ToInt32(aux);
            string aux2 = Console.ReadLine();
            int nCount2 = Convert.ToInt32(aux);

            CountTo10();
            CountTo10();
            CountToN(nCount);
            CountToN(nCount2);
        }
        private static void CountTo10()
        {
            for (int i = 1; i <= 10; i++)
            {
                CountToN(10);
            }
        }

        private static void CountToN(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}